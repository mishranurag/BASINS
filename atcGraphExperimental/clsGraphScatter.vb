Imports System.Drawing

Imports atcData
Imports atcUtility
Imports ZedGraph

Public Class clsGraphScatter
    Inherits clsGraphBase

    <CLSCompliant(False)> _
    Public Sub New(ByVal aDataGroup As atcTimeseriesGroup, ByVal aZedGraphControl As ZedGraphControl)
        MyBase.New(aDataGroup, aZedGraphControl)
    End Sub

    Public Overrides Property Datasets() As atcTimeseriesGroup
        Get
            Return MyBase.Datasets
        End Get
        Set(ByVal newValue As atcTimeseriesGroup)
            MyBase.Datasets = newValue
            If newValue.Count > 1 Then
                Dim lTimeseriesX As atcTimeseries = newValue.ItemByIndex(0)
                Dim lTimeseriesY As atcTimeseries = newValue.ItemByIndex(1)

                'find common start and end dates
                Dim lSJDay As Double
                Dim lEJDay As Double
                If lTimeseriesX.Dates.Value(0) < lTimeseriesY.Dates.Value(0) Then
                    'y starts after x, use y start date
                    lSJDay = lTimeseriesY.Dates.Value(0)
                Else 'use x start date
                    lSJDay = lTimeseriesX.Dates.Value(0)
                End If
                If lTimeseriesX.Dates.Value(lTimeseriesX.Dates.numValues) < lTimeseriesY.Dates.Value(lTimeseriesY.Dates.numValues) Then
                    'x ends before y, use x end date
                    lEJDay = lTimeseriesX.Dates.Value(lTimeseriesX.Dates.numValues)
                Else 'use y end date
                    lEJDay = lTimeseriesY.Dates.Value(lTimeseriesY.Dates.numValues)
                End If

                Dim lSubsetTimeseriesX As atcTimeseries = SubsetByDate(lTimeseriesX, lSJDay, lEJDay, Nothing)
                Dim lSubsetTimeseriesY As atcTimeseries = SubsetByDate(lTimeseriesY, lSJDay, lEJDay, Nothing)
                Dim lSubsetGroup As New atcTimeseriesGroup
                lSubsetGroup.Add(lSubsetTimeseriesX)
                lSubsetGroup.Add(lSubsetTimeseriesY)

                Dim lPane As GraphPane = MyBase.pZgc.MasterPane.PaneList(0)
                lPane.Legend.IsVisible = False
                With lPane.XAxis
                    .Type = AxisType.Linear
                    .Scale.MaxAuto = False
                    .Title.Text = lTimeseriesX.ToString
                End With

                With lPane.YAxis
                    .Type = AxisType.Linear
                    .Scale.MaxAuto = False
                    .Title.Text = lTimeseriesY.ToString
                End With

                With lTimeseriesY.Attributes
                    'Dim lScen As String = .GetValue("scenario")
                    'Dim lLoc As String = .GetValue("location")
                    'Dim lCons As String = .GetValue("constituent")
                    'Dim lCurveColor As Color = GetMatchingColor(lScen & ":" & lLoc & ":" & lCons)
                    Dim lCurveColor As Color = Color.Blue
                    Dim lCurve As LineItem = Nothing
                    Dim lXValues() As Double = lSubsetTimeseriesX.Values
                    Dim lYValues() As Double = lSubsetTimeseriesY.Values
                    Dim lSymbol As SymbolType
                    Dim lNPts As Integer = lXValues.GetUpperBound(0)
                    If lNPts < 100 Then
                        lSymbol = SymbolType.Star
                    Else
                        lSymbol = SymbolType.Circle
                    End If
                    lCurve = lPane.AddCurve("", lXValues, lYValues, lCurveColor, lSymbol)
                    If lNPts >= 1000 Then
                        lCurve.Symbol.Size = 1
                    ElseIf lNPts >= 100 Then
                        lCurve.Symbol.Size = 2
                    End If
                    lCurve.Line.IsVisible = False
                    'Try 'Data Source' first for Tag, then use 'History 1' (for Subsetbydate TS)
                    Dim lSourceFileX As String = lTimeseriesX.Attributes.GetValue("Data Source", "")
                    Dim lSourceFileY As String = lTimeseriesY.Attributes.GetValue("Data Source", "")
                    If Not IO.File.Exists(lSourceFileX) And (lTimeseriesX.Attributes.ContainsAttribute("History 1") AndAlso lTimeseriesX.Attributes.GetValue("History 1").Length > 9) Then
                        'see if the history attribute contains a file name
                        lSourceFileX = lTimeseriesX.Attributes.GetValue("History 1").Substring(10)
                    End If
                    If Not IO.File.Exists(lSourceFileY) And (lTimeseriesY.Attributes.ContainsAttribute("History 1") AndAlso lTimeseriesY.Attributes.GetValue("History 1").Length > 9) Then
                        'see if the history attribute contains a file name
                        lSourceFileY = lTimeseriesY.Attributes.GetValue("History 1").Substring(10)
                    End If
                    lCurve.Tag = lTimeseriesX.Serial & "|" & lTimeseriesX.Attributes.GetValue("ID") & "|" & lSourceFileX & "||" &
                                 lTimeseriesY.Serial & "|" & lTimeseriesY.Attributes.GetValue("ID") & "|" & lSourceFileY
                End With
                ScaleAxis(lSubsetGroup, lPane.YAxis)
                lPane.XAxis.Scale.Min = lPane.YAxis.Scale.Min
                lPane.XAxis.Scale.Max = lPane.YAxis.Scale.Max
            End If
            pZgc.Refresh()
        End Set
    End Property

    Public Sub AddFitLine(Optional ByRef aACoef As String = "", Optional ByRef aBCoef As String = "")
        '45 degree line
        Dim lPane As ZedGraph.GraphPane = pZgc.MasterPane.PaneList(0)
        Dim lLine As ZedGraph.LineItem = AddLine(lPane, 1, 0, Drawing.Drawing2D.DashStyle.Dot, "45DegLine")
        lLine.Color = Color.Black

        'regression line 
        Dim lACoef As Double
        Dim lBCoef As Double
        Dim lRSquare As Double

        'use common period from the two datasets
        Dim lSJDay As Double
        Dim lEJDay As Double
        Dim lTimeseriesX As atcTimeseries = Datasets(1)
        Dim lTimeseriesY As atcTimeseries = Datasets(0)
        If lTimeseriesX.Dates.Value(0) < lTimeseriesY.Dates.Value(0) Then
            'y starts after x, use y start date
            lSJDay = lTimeseriesY.Dates.Value(0)
        Else 'use x start date
            lSJDay = lTimeseriesX.Dates.Value(0)
        End If
        If lTimeseriesX.Dates.Value(lTimeseriesX.Dates.numValues) < lTimeseriesY.Dates.Value(lTimeseriesY.Dates.numValues) Then
            'x ends before y, use x end date
            lEJDay = lTimeseriesX.Dates.Value(lTimeseriesX.Dates.numValues)
        Else 'use y end date
            lEJDay = lTimeseriesY.Dates.Value(lTimeseriesY.Dates.numValues)
        End If

        Dim lSubsetTimeseriesX As atcTimeseries = SubsetByDate(lTimeseriesX, lSJDay, lEJDay, Nothing)
        Dim lSubsetTimeseriesY As atcTimeseries = SubsetByDate(lTimeseriesY, lSJDay, lEJDay, Nothing)
        Dim lNote As String = ""

        FitLine(lSubsetTimeseriesX, lSubsetTimeseriesY, lACoef, lBCoef, lRSquare, lNote)
        AddLine(lPane, lACoef, lBCoef, Drawing.Drawing2D.DashStyle.Solid, "RegLine")

        aACoef = lACoef
        aBCoef = lBCoef

        Dim lText As New TextObj
        Dim lFmt As String = "###,##0.###"
        Dim lBstr As String = DoubleToString(lBCoef, , lFmt)
        If lBCoef >= 0 Then lBstr = "+ " & lBstr 'If it was negative, already have "-" prefix
        lText.Text = "Y = " & DoubleToString(lACoef, , lFmt) & " X " & lBstr & Environment.NewLine &
                     "R = " & DoubleToString(Math.Sqrt(lRSquare), , lFmt) & vbCrLf &
                     "R Squared = " & DoubleToString(lRSquare, , lFmt)
        'If lNote.Length > 0 Then lText.Text &= vbCrLf & lNote
        lText.FontSpec.StringAlignment = Drawing.StringAlignment.Near
        lText.Location = New Location(0.05, 0.05, CoordType.ChartFraction, AlignH.Left, AlignV.Top)
        lText.FontSpec.Border.IsVisible = False
        lPane.GraphObjList.Add(lText)
        lPane.XAxis.Title.Text &= vbCrLf & vbCrLf & "Scatter Plot"
    End Sub
End Class
