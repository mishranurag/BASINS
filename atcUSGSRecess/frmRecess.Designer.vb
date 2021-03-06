﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecess))
        Me.chkSaveInterimToFile = New System.Windows.Forms.CheckBox()
        Me.txtOutputDir = New System.Windows.Forms.TextBox()
        Me.lblOutpuDir = New System.Windows.Forms.Label()
        Me.txtMinRecessionDays = New System.Windows.Forms.TextBox()
        Me.lblRecessionDays = New System.Windows.Forms.Label()
        Me.gbMonthSeason = New System.Windows.Forms.GroupBox()
        Me.rdoNoSeason = New System.Windows.Forms.RadioButton()
        Me.rdoWinter = New System.Windows.Forms.RadioButton()
        Me.rdoFall = New System.Windows.Forms.RadioButton()
        Me.rdoSummer = New System.Windows.Forms.RadioButton()
        Me.rdoSpring = New System.Windows.Forms.RadioButton()
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.gbDates = New System.Windows.Forms.GroupBox()
        Me.lblAnalysisDates = New System.Windows.Forms.Label()
        Me.lblPeriodOfRecord = New System.Windows.Forms.Label()
        Me.txtEndDateUser = New System.Windows.Forms.TextBox()
        Me.txtStartDateUser = New System.Windows.Forms.TextBox()
        Me.btnExamineData = New System.Windows.Forms.Button()
        Me.txtDataEnd = New System.Windows.Forms.TextBox()
        Me.txtDataStart = New System.Windows.Forms.TextBox()
        Me.lblDataEnd = New System.Windows.Forms.Label()
        Me.lblDataStart = New System.Windows.Forms.Label()
        Me.lstRecessSegments = New System.Windows.Forms.CheckedListBox()
        Me.scDisplay = New System.Windows.Forms.SplitContainer()
        Me.txtAnalysisResults = New System.Windows.Forms.TextBox()
        Me.lstTable = New System.Windows.Forms.ListBox()
        Me.btnCurv = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnAnalyse = New System.Windows.Forms.Button()
        Me.btnGetAllSegments = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSelectData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelConfiguration = New System.Windows.Forms.Panel()
        Me.btnViewMRCs = New System.Windows.Forms.Button()
        Me.panRiseParam = New System.Windows.Forms.Panel()
        Me.txtPeakRisePct = New System.Windows.Forms.TextBox()
        Me.lblRisePct = New System.Windows.Forms.Label()
        Me.txtPeakAheadDays = New System.Windows.Forms.TextBox()
        Me.lblScreenWindow = New System.Windows.Forms.Label()
        Me.gbDataType = New System.Windows.Forms.GroupBox()
        Me.txtDataInfo = New System.Windows.Forms.TextBox()
        Me.panelAnalysis = New System.Windows.Forms.Panel()
        Me.lblFallD = New System.Windows.Forms.Label()
        Me.txtFallD = New System.Windows.Forms.TextBox()
        Me.btnFallPlot = New System.Windows.Forms.Button()
        Me.btnConfiguration = New System.Windows.Forms.Button()
        Me.gbMonthSeason.SuspendLayout()
        Me.gbDates.SuspendLayout()
        Me.scDisplay.Panel1.SuspendLayout()
        Me.scDisplay.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panelConfiguration.SuspendLayout()
        Me.panRiseParam.SuspendLayout()
        Me.gbDataType.SuspendLayout()
        Me.panelAnalysis.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSaveInterimToFile
        '
        Me.chkSaveInterimToFile.AutoSize = True
        Me.chkSaveInterimToFile.Location = New System.Drawing.Point(6, 210)
        Me.chkSaveInterimToFile.Name = "chkSaveInterimToFile"
        Me.chkSaveInterimToFile.Size = New System.Drawing.Size(150, 17)
        Me.chkSaveInterimToFile.TabIndex = 11
        Me.chkSaveInterimToFile.Text = "Save Intermediate Results"
        Me.chkSaveInterimToFile.UseVisualStyleBackColor = True
        '
        'txtOutputDir
        '
        Me.txtOutputDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputDir.Location = New System.Drawing.Point(6, 184)
        Me.txtOutputDir.Name = "txtOutputDir"
        Me.txtOutputDir.Size = New System.Drawing.Size(768, 20)
        Me.txtOutputDir.TabIndex = 10
        '
        'lblOutpuDir
        '
        Me.lblOutpuDir.AutoSize = True
        Me.lblOutpuDir.Location = New System.Drawing.Point(3, 168)
        Me.lblOutpuDir.Name = "lblOutpuDir"
        Me.lblOutpuDir.Size = New System.Drawing.Size(118, 13)
        Me.lblOutpuDir.TabIndex = 45
        Me.lblOutpuDir.Text = "Specify output directory"
        '
        'txtMinRecessionDays
        '
        Me.txtMinRecessionDays.Location = New System.Drawing.Point(232, 138)
        Me.txtMinRecessionDays.Name = "txtMinRecessionDays"
        Me.txtMinRecessionDays.Size = New System.Drawing.Size(72, 20)
        Me.txtMinRecessionDays.TabIndex = 9
        '
        'lblRecessionDays
        '
        Me.lblRecessionDays.AutoSize = True
        Me.lblRecessionDays.Location = New System.Drawing.Point(3, 141)
        Me.lblRecessionDays.Name = "lblRecessionDays"
        Me.lblRecessionDays.Size = New System.Drawing.Size(223, 13)
        Me.lblRecessionDays.TabIndex = 44
        Me.lblRecessionDays.Text = "Specify minimum flow recession length in days"
        '
        'gbMonthSeason
        '
        Me.gbMonthSeason.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMonthSeason.Controls.Add(Me.rdoNoSeason)
        Me.gbMonthSeason.Controls.Add(Me.rdoWinter)
        Me.gbMonthSeason.Controls.Add(Me.rdoFall)
        Me.gbMonthSeason.Controls.Add(Me.rdoSummer)
        Me.gbMonthSeason.Controls.Add(Me.rdoSpring)
        Me.gbMonthSeason.Controls.Add(Me.lstMonths)
        Me.gbMonthSeason.Location = New System.Drawing.Point(320, 3)
        Me.gbMonthSeason.Name = "gbMonthSeason"
        Me.gbMonthSeason.Size = New System.Drawing.Size(275, 175)
        Me.gbMonthSeason.TabIndex = 43
        Me.gbMonthSeason.TabStop = False
        Me.gbMonthSeason.Text = "Months and Season"
        '
        'rdoNoSeason
        '
        Me.rdoNoSeason.AutoSize = True
        Me.rdoNoSeason.Location = New System.Drawing.Point(6, 131)
        Me.rdoNoSeason.Name = "rdoNoSeason"
        Me.rdoNoSeason.Size = New System.Drawing.Size(122, 17)
        Me.rdoNoSeason.TabIndex = 8
        Me.rdoNoSeason.TabStop = True
        Me.rdoNoSeason.Text = "No particular season"
        Me.rdoNoSeason.UseVisualStyleBackColor = True
        '
        'rdoWinter
        '
        Me.rdoWinter.AutoSize = True
        Me.rdoWinter.Location = New System.Drawing.Point(183, 108)
        Me.rdoWinter.Name = "rdoWinter"
        Me.rdoWinter.Size = New System.Drawing.Size(56, 17)
        Me.rdoWinter.TabIndex = 7
        Me.rdoWinter.TabStop = True
        Me.rdoWinter.Text = "Winter"
        Me.rdoWinter.UseVisualStyleBackColor = True
        '
        'rdoFall
        '
        Me.rdoFall.AutoSize = True
        Me.rdoFall.Location = New System.Drawing.Point(136, 108)
        Me.rdoFall.Name = "rdoFall"
        Me.rdoFall.Size = New System.Drawing.Size(41, 17)
        Me.rdoFall.TabIndex = 6
        Me.rdoFall.TabStop = True
        Me.rdoFall.Text = "Fall"
        Me.rdoFall.UseVisualStyleBackColor = True
        '
        'rdoSummer
        '
        Me.rdoSummer.AutoSize = True
        Me.rdoSummer.Location = New System.Drawing.Point(67, 108)
        Me.rdoSummer.Name = "rdoSummer"
        Me.rdoSummer.Size = New System.Drawing.Size(63, 17)
        Me.rdoSummer.TabIndex = 5
        Me.rdoSummer.TabStop = True
        Me.rdoSummer.Text = "Summer"
        Me.rdoSummer.UseVisualStyleBackColor = True
        '
        'rdoSpring
        '
        Me.rdoSpring.AutoSize = True
        Me.rdoSpring.Location = New System.Drawing.Point(6, 108)
        Me.rdoSpring.Name = "rdoSpring"
        Me.rdoSpring.Size = New System.Drawing.Size(55, 17)
        Me.rdoSpring.TabIndex = 4
        Me.rdoSpring.TabStop = True
        Me.rdoSpring.Text = "Spring"
        Me.rdoSpring.UseVisualStyleBackColor = True
        '
        'lstMonths
        '
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.lstMonths.Location = New System.Drawing.Point(7, 20)
        Me.lstMonths.MultiColumn = True
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstMonths.Size = New System.Drawing.Size(256, 82)
        Me.lstMonths.TabIndex = 3
        '
        'gbDates
        '
        Me.gbDates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDates.Controls.Add(Me.lblAnalysisDates)
        Me.gbDates.Controls.Add(Me.lblPeriodOfRecord)
        Me.gbDates.Controls.Add(Me.txtEndDateUser)
        Me.gbDates.Controls.Add(Me.txtStartDateUser)
        Me.gbDates.Controls.Add(Me.btnExamineData)
        Me.gbDates.Controls.Add(Me.txtDataEnd)
        Me.gbDates.Controls.Add(Me.txtDataStart)
        Me.gbDates.Controls.Add(Me.lblDataEnd)
        Me.gbDates.Controls.Add(Me.lblDataStart)
        Me.gbDates.Location = New System.Drawing.Point(3, 3)
        Me.gbDates.Name = "gbDates"
        Me.gbDates.Size = New System.Drawing.Size(311, 120)
        Me.gbDates.TabIndex = 42
        Me.gbDates.TabStop = False
        Me.gbDates.Text = "Streamflow Analysis Dates"
        '
        'lblAnalysisDates
        '
        Me.lblAnalysisDates.AutoSize = True
        Me.lblAnalysisDates.Location = New System.Drawing.Point(184, 22)
        Me.lblAnalysisDates.Name = "lblAnalysisDates"
        Me.lblAnalysisDates.Size = New System.Drawing.Size(76, 13)
        Me.lblAnalysisDates.TabIndex = 16
        Me.lblAnalysisDates.Text = "Analysis Dates"
        '
        'lblPeriodOfRecord
        '
        Me.lblPeriodOfRecord.AutoSize = True
        Me.lblPeriodOfRecord.Location = New System.Drawing.Point(68, 22)
        Me.lblPeriodOfRecord.Name = "lblPeriodOfRecord"
        Me.lblPeriodOfRecord.Size = New System.Drawing.Size(87, 13)
        Me.lblPeriodOfRecord.TabIndex = 15
        Me.lblPeriodOfRecord.Text = "Period of Record"
        '
        'txtEndDateUser
        '
        Me.txtEndDateUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEndDateUser.Location = New System.Drawing.Point(187, 64)
        Me.txtEndDateUser.Name = "txtEndDateUser"
        Me.txtEndDateUser.Size = New System.Drawing.Size(118, 20)
        Me.txtEndDateUser.TabIndex = 1
        '
        'txtStartDateUser
        '
        Me.txtStartDateUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStartDateUser.Location = New System.Drawing.Point(187, 38)
        Me.txtStartDateUser.Name = "txtStartDateUser"
        Me.txtStartDateUser.Size = New System.Drawing.Size(118, 20)
        Me.txtStartDateUser.TabIndex = 0
        '
        'btnExamineData
        '
        Me.btnExamineData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExamineData.Location = New System.Drawing.Point(71, 91)
        Me.btnExamineData.Name = "btnExamineData"
        Me.btnExamineData.Size = New System.Drawing.Size(88, 23)
        Me.btnExamineData.TabIndex = 2
        Me.btnExamineData.Text = "Examine Data"
        Me.btnExamineData.UseVisualStyleBackColor = True
        '
        'txtDataEnd
        '
        Me.txtDataEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDataEnd.Location = New System.Drawing.Point(71, 65)
        Me.txtDataEnd.Name = "txtDataEnd"
        Me.txtDataEnd.ReadOnly = True
        Me.txtDataEnd.Size = New System.Drawing.Size(110, 20)
        Me.txtDataEnd.TabIndex = 3
        '
        'txtDataStart
        '
        Me.txtDataStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDataStart.Location = New System.Drawing.Point(71, 38)
        Me.txtDataStart.Name = "txtDataStart"
        Me.txtDataStart.ReadOnly = True
        Me.txtDataStart.Size = New System.Drawing.Size(110, 20)
        Me.txtDataStart.TabIndex = 2
        '
        'lblDataEnd
        '
        Me.lblDataEnd.AutoSize = True
        Me.lblDataEnd.Location = New System.Drawing.Point(9, 64)
        Me.lblDataEnd.Name = "lblDataEnd"
        Me.lblDataEnd.Size = New System.Drawing.Size(52, 13)
        Me.lblDataEnd.TabIndex = 1
        Me.lblDataEnd.Text = "Data End"
        '
        'lblDataStart
        '
        Me.lblDataStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataStart.AutoSize = True
        Me.lblDataStart.Location = New System.Drawing.Point(9, 38)
        Me.lblDataStart.Name = "lblDataStart"
        Me.lblDataStart.Size = New System.Drawing.Size(55, 13)
        Me.lblDataStart.TabIndex = 0
        Me.lblDataStart.Text = "Data Start"
        '
        'lstRecessSegments
        '
        Me.lstRecessSegments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRecessSegments.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecessSegments.FormattingEnabled = True
        Me.lstRecessSegments.IntegralHeight = False
        Me.lstRecessSegments.Location = New System.Drawing.Point(3, 3)
        Me.lstRecessSegments.Name = "lstRecessSegments"
        Me.lstRecessSegments.Size = New System.Drawing.Size(122, 206)
        Me.lstRecessSegments.TabIndex = 13
        '
        'scDisplay
        '
        Me.scDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scDisplay.Location = New System.Drawing.Point(132, 3)
        Me.scDisplay.Name = "scDisplay"
        '
        'scDisplay.Panel1
        '
        Me.scDisplay.Panel1.Controls.Add(Me.txtAnalysisResults)
        Me.scDisplay.Panel1.Controls.Add(Me.lstTable)
        Me.scDisplay.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'scDisplay.Panel2
        '
        Me.scDisplay.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scDisplay.Size = New System.Drawing.Size(580, 206)
        Me.scDisplay.SplitterDistance = 295
        Me.scDisplay.TabIndex = 39
        '
        'txtAnalysisResults
        '
        Me.txtAnalysisResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnalysisResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAnalysisResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnalysisResults.Location = New System.Drawing.Point(0, 0)
        Me.txtAnalysisResults.Multiline = True
        Me.txtAnalysisResults.Name = "txtAnalysisResults"
        Me.txtAnalysisResults.ReadOnly = True
        Me.txtAnalysisResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAnalysisResults.Size = New System.Drawing.Size(295, 206)
        Me.txtAnalysisResults.TabIndex = 15
        Me.txtAnalysisResults.Visible = False
        Me.txtAnalysisResults.WordWrap = False
        '
        'lstTable
        '
        Me.lstTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTable.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTable.FormattingEnabled = True
        Me.lstTable.IntegralHeight = False
        Me.lstTable.ItemHeight = 14
        Me.lstTable.Location = New System.Drawing.Point(0, 0)
        Me.lstTable.Name = "lstTable"
        Me.lstTable.Size = New System.Drawing.Size(295, 206)
        Me.lstTable.TabIndex = 0
        '
        'btnCurv
        '
        Me.btnCurv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCurv.Location = New System.Drawing.Point(299, 215)
        Me.btnCurv.Name = "btnCurv"
        Me.btnCurv.Size = New System.Drawing.Size(75, 23)
        Me.btnCurv.TabIndex = 19
        Me.btnCurv.Text = "View MRC >"
        Me.btnCurv.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSummary.Location = New System.Drawing.Point(218, 215)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(75, 23)
        Me.btnSummary.TabIndex = 18
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnAnalyse
        '
        Me.btnAnalyse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnalyse.Location = New System.Drawing.Point(137, 215)
        Me.btnAnalyse.Name = "btnAnalyse"
        Me.btnAnalyse.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalyse.TabIndex = 17
        Me.btnAnalyse.Text = "Analyze"
        Me.btnAnalyse.UseVisualStyleBackColor = True
        '
        'btnGetAllSegments
        '
        Me.btnGetAllSegments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGetAllSegments.AutoSize = True
        Me.btnGetAllSegments.Location = New System.Drawing.Point(3, 246)
        Me.btnGetAllSegments.Name = "btnGetAllSegments"
        Me.btnGetAllSegments.Size = New System.Drawing.Size(100, 27)
        Me.btnGetAllSegments.TabIndex = 12
        Me.btnGetAllSegments.Text = "Find Peaks >"
        Me.btnGetAllSegments.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSelectData})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileSelectData
        '
        Me.mnuFileSelectData.Name = "mnuFileSelectData"
        Me.mnuFileSelectData.Size = New System.Drawing.Size(132, 22)
        Me.mnuFileSelectData.Text = "Select Data"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'panelConfiguration
        '
        Me.panelConfiguration.Controls.Add(Me.btnViewMRCs)
        Me.panelConfiguration.Controls.Add(Me.panRiseParam)
        Me.panelConfiguration.Controls.Add(Me.gbDataType)
        Me.panelConfiguration.Controls.Add(Me.chkSaveInterimToFile)
        Me.panelConfiguration.Controls.Add(Me.gbDates)
        Me.panelConfiguration.Controls.Add(Me.txtOutputDir)
        Me.panelConfiguration.Controls.Add(Me.btnGetAllSegments)
        Me.panelConfiguration.Controls.Add(Me.gbMonthSeason)
        Me.panelConfiguration.Controls.Add(Me.lblOutpuDir)
        Me.panelConfiguration.Controls.Add(Me.lblRecessionDays)
        Me.panelConfiguration.Controls.Add(Me.txtMinRecessionDays)
        Me.panelConfiguration.Location = New System.Drawing.Point(0, 27)
        Me.panelConfiguration.Name = "panelConfiguration"
        Me.panelConfiguration.Size = New System.Drawing.Size(777, 276)
        Me.panelConfiguration.TabIndex = 31
        '
        'btnViewMRCs
        '
        Me.btnViewMRCs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewMRCs.Location = New System.Drawing.Point(694, 246)
        Me.btnViewMRCs.Name = "btnViewMRCs"
        Me.btnViewMRCs.Size = New System.Drawing.Size(75, 27)
        Me.btnViewMRCs.TabIndex = 48
        Me.btnViewMRCs.Text = "View MRCs"
        Me.btnViewMRCs.UseVisualStyleBackColor = True
        '
        'panRiseParam
        '
        Me.panRiseParam.Controls.Add(Me.txtPeakRisePct)
        Me.panRiseParam.Controls.Add(Me.lblRisePct)
        Me.panRiseParam.Controls.Add(Me.txtPeakAheadDays)
        Me.panRiseParam.Controls.Add(Me.lblScreenWindow)
        Me.panRiseParam.Location = New System.Drawing.Point(320, 110)
        Me.panRiseParam.Margin = New System.Windows.Forms.Padding(2)
        Me.panRiseParam.Name = "panRiseParam"
        Me.panRiseParam.Size = New System.Drawing.Size(276, 67)
        Me.panRiseParam.TabIndex = 47
        '
        'txtPeakRisePct
        '
        Me.txtPeakRisePct.Location = New System.Drawing.Point(205, 35)
        Me.txtPeakRisePct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPeakRisePct.Name = "txtPeakRisePct"
        Me.txtPeakRisePct.Size = New System.Drawing.Size(67, 20)
        Me.txtPeakRisePct.TabIndex = 3
        '
        'lblRisePct
        '
        Me.lblRisePct.AutoSize = True
        Me.lblRisePct.Location = New System.Drawing.Point(8, 37)
        Me.lblRisePct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRisePct.Name = "lblRisePct"
        Me.lblRisePct.Size = New System.Drawing.Size(191, 13)
        Me.lblRisePct.TabIndex = 2
        Me.lblRisePct.Text = "Peek ahead rise percent (50% ~ 100%)"
        '
        'txtPeakAheadDays
        '
        Me.txtPeakAheadDays.Location = New System.Drawing.Point(205, 12)
        Me.txtPeakAheadDays.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPeakAheadDays.Name = "txtPeakAheadDays"
        Me.txtPeakAheadDays.Size = New System.Drawing.Size(67, 20)
        Me.txtPeakAheadDays.TabIndex = 1
        '
        'lblScreenWindow
        '
        Me.lblScreenWindow.AutoSize = True
        Me.lblScreenWindow.Location = New System.Drawing.Point(112, 15)
        Me.lblScreenWindow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScreenWindow.Name = "lblScreenWindow"
        Me.lblScreenWindow.Size = New System.Drawing.Size(90, 13)
        Me.lblScreenWindow.TabIndex = 0
        Me.lblScreenWindow.Text = "Peek ahead days"
        '
        'gbDataType
        '
        Me.gbDataType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDataType.Controls.Add(Me.txtDataInfo)
        Me.gbDataType.Location = New System.Drawing.Point(601, 3)
        Me.gbDataType.Name = "gbDataType"
        Me.gbDataType.Size = New System.Drawing.Size(172, 175)
        Me.gbDataType.TabIndex = 46
        Me.gbDataType.TabStop = False
        Me.gbDataType.Text = "Data Info."
        '
        'txtDataInfo
        '
        Me.txtDataInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDataInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDataInfo.Location = New System.Drawing.Point(3, 16)
        Me.txtDataInfo.Multiline = True
        Me.txtDataInfo.Name = "txtDataInfo"
        Me.txtDataInfo.ReadOnly = True
        Me.txtDataInfo.Size = New System.Drawing.Size(166, 156)
        Me.txtDataInfo.TabIndex = 0
        '
        'panelAnalysis
        '
        Me.panelAnalysis.Controls.Add(Me.lblFallD)
        Me.panelAnalysis.Controls.Add(Me.txtFallD)
        Me.panelAnalysis.Controls.Add(Me.btnFallPlot)
        Me.panelAnalysis.Controls.Add(Me.btnConfiguration)
        Me.panelAnalysis.Controls.Add(Me.btnCurv)
        Me.panelAnalysis.Controls.Add(Me.lstRecessSegments)
        Me.panelAnalysis.Controls.Add(Me.btnSummary)
        Me.panelAnalysis.Controls.Add(Me.btnAnalyse)
        Me.panelAnalysis.Controls.Add(Me.scDisplay)
        Me.panelAnalysis.Location = New System.Drawing.Point(15, 337)
        Me.panelAnalysis.Name = "panelAnalysis"
        Me.panelAnalysis.Size = New System.Drawing.Size(715, 241)
        Me.panelAnalysis.TabIndex = 32
        Me.panelAnalysis.Visible = False
        '
        'lblFallD
        '
        Me.lblFallD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFallD.AutoSize = True
        Me.lblFallD.Location = New System.Drawing.Point(495, 218)
        Me.lblFallD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFallD.Name = "lblFallD"
        Me.lblFallD.Size = New System.Drawing.Size(138, 13)
        Me.lblFallD.TabIndex = 41
        Me.lblFallD.Text = "Pour-point GW elevation, d:"
        '
        'txtFallD
        '
        Me.txtFallD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFallD.Location = New System.Drawing.Point(637, 215)
        Me.txtFallD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFallD.Name = "txtFallD"
        Me.txtFallD.Size = New System.Drawing.Size(76, 20)
        Me.txtFallD.TabIndex = 40
        '
        'btnFallPlot
        '
        Me.btnFallPlot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFallPlot.Location = New System.Drawing.Point(380, 215)
        Me.btnFallPlot.Name = "btnFallPlot"
        Me.btnFallPlot.Size = New System.Drawing.Size(108, 23)
        Me.btnFallPlot.TabIndex = 20
        Me.btnFallPlot.Text = "Visually Estimate d"
        Me.btnFallPlot.UseVisualStyleBackColor = True
        '
        'btnConfiguration
        '
        Me.btnConfiguration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguration.AutoSize = True
        Me.btnConfiguration.Location = New System.Drawing.Point(3, 211)
        Me.btnConfiguration.Name = "btnConfiguration"
        Me.btnConfiguration.Size = New System.Drawing.Size(128, 27)
        Me.btnConfiguration.TabIndex = 16
        Me.btnConfiguration.Text = "< Back to Configuration"
        Me.btnConfiguration.UseVisualStyleBackColor = True
        '
        'frmRecess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 308)
        Me.Controls.Add(Me.panelAnalysis)
        Me.Controls.Add(Me.panelConfiguration)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRecess"
        Me.Text = "USGS RECESS"
        Me.gbMonthSeason.ResumeLayout(False)
        Me.gbMonthSeason.PerformLayout()
        Me.gbDates.ResumeLayout(False)
        Me.gbDates.PerformLayout()
        Me.scDisplay.Panel1.ResumeLayout(False)
        Me.scDisplay.Panel1.PerformLayout()
        Me.scDisplay.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelConfiguration.ResumeLayout(False)
        Me.panelConfiguration.PerformLayout()
        Me.panRiseParam.ResumeLayout(False)
        Me.panRiseParam.PerformLayout()
        Me.gbDataType.ResumeLayout(False)
        Me.gbDataType.PerformLayout()
        Me.panelAnalysis.ResumeLayout(False)
        Me.panelAnalysis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSelectData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtOutputDir As System.Windows.Forms.TextBox
    Friend WithEvents lblOutpuDir As System.Windows.Forms.Label
    Friend WithEvents txtMinRecessionDays As System.Windows.Forms.TextBox
    Friend WithEvents lblRecessionDays As System.Windows.Forms.Label
    Friend WithEvents gbMonthSeason As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNoSeason As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWinter As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFall As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSummer As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSpring As System.Windows.Forms.RadioButton
    Friend WithEvents lstMonths As System.Windows.Forms.ListBox
    Friend WithEvents gbDates As System.Windows.Forms.GroupBox
    Friend WithEvents txtEndDateUser As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDateUser As System.Windows.Forms.TextBox
    Friend WithEvents btnExamineData As System.Windows.Forms.Button
    Friend WithEvents txtDataEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtDataStart As System.Windows.Forms.TextBox
    Friend WithEvents lblDataEnd As System.Windows.Forms.Label
    Friend WithEvents lblDataStart As System.Windows.Forms.Label
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnAnalyse As System.Windows.Forms.Button
    Friend WithEvents btnGetAllSegments As System.Windows.Forms.Button
    Friend WithEvents scDisplay As System.Windows.Forms.SplitContainer
    Friend WithEvents lstTable As System.Windows.Forms.ListBox
    Friend WithEvents lstRecessSegments As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtAnalysisResults As System.Windows.Forms.TextBox
    Friend WithEvents chkSaveInterimToFile As System.Windows.Forms.CheckBox
    Friend WithEvents btnCurv As System.Windows.Forms.Button
    Friend WithEvents panelConfiguration As System.Windows.Forms.Panel
    Friend WithEvents panelAnalysis As System.Windows.Forms.Panel
    Friend WithEvents btnConfiguration As System.Windows.Forms.Button
    Friend WithEvents lblAnalysisDates As System.Windows.Forms.Label
    Friend WithEvents lblPeriodOfRecord As System.Windows.Forms.Label
    Friend WithEvents btnFallPlot As System.Windows.Forms.Button
    Friend WithEvents gbDataType As System.Windows.Forms.GroupBox
    Friend WithEvents txtDataInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtFallD As System.Windows.Forms.TextBox
    Friend WithEvents lblFallD As System.Windows.Forms.Label
    Friend WithEvents panRiseParam As System.Windows.Forms.Panel
    Friend WithEvents lblScreenWindow As System.Windows.Forms.Label
    Friend WithEvents lblRisePct As System.Windows.Forms.Label
    Friend WithEvents txtPeakAheadDays As System.Windows.Forms.TextBox
    Friend WithEvents txtPeakRisePct As System.Windows.Forms.TextBox
    Friend WithEvents btnViewMRCs As System.Windows.Forms.Button
End Class
