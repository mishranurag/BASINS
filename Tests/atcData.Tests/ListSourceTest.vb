﻿Imports atcControls
Imports atcUtility
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports atcData

'''<summary>
'''This is a test class for ListSourceTest and is intended
'''to contain all ListSourceTest Unit Tests
'''</summary>
<TestClass()> _
Public Class ListSourceTest
    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region

    '''<summary>Test ListSource Constructor</summary>
    <TestMethod()> Public Sub ListSourceConstructorTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>Test Alignment</summary>
    <TestMethod()> Public Sub AlignmentTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected) ' TODO: Initialize to an appropriate value
        Dim aRow As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aColumn As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As atcAlignment = New atcAlignment() ' TODO: Initialize to an appropriate value
        Dim actual As atcAlignment
        target.Alignment(aRow, aColumn) = expected
        actual = target.Alignment(aRow, aColumn)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test CellSelected</summary>
    <TestMethod()> Public Sub CellSelectedTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected) ' TODO: Initialize to an appropriate value
        Dim aRow As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aColumn As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        target.CellSelected(aRow, aColumn) = expected
        actual = target.CellSelected(aRow, aColumn)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test CellValue</summary>
    <TestMethod()> Public Sub CellValueTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected) ' TODO: Initialize to an appropriate value
        Dim aRow As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim aColumn As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        target.CellValue(aRow, aColumn) = expected
        actual = target.CellValue(aRow, aColumn)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Columns</summary>
    <TestMethod()> Public Sub ColumnsTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected) ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        target.Columns = expected
        actual = target.Columns
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test Rows</summary>
    <TestMethod()> Public Sub RowsTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected) ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        target.Rows = expected
        actual = target.Rows
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>Test SelectedItems</summary>
    <TestMethod()> Public Sub SelectedItemsTest()
        Dim aValues As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim aSelected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim target As ListSource = New ListSource(aValues, aSelected) ' TODO: Initialize to an appropriate value
        Dim expected As atcCollection = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As atcCollection
        target.SelectedItems = expected
        actual = target.SelectedItems
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
