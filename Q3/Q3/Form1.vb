Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Dim obj As Excel.Workbook
    Dim ws As Excel.Worksheet

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oXL As Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim oRng As Excel.Range
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim myCommand As New System.Data.OleDb.OleDbCommand

        Dim sql As String
        ' Start Excel and get Application object.
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True

        ' Get a new workbook.
        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet

        oSheet.Cells(1, 1).Value = "Number 1"
        oSheet.Cells(1, 2).Value = "Number 2"
        oSheet.Cells(1, 3).Value = "Number 3"
        oSheet.Cells(1, 4).Value = "Number 4"
        oSheet.Cells(1, 5).Value = "Number 5"
        oSheet.Cells(1, 6).Value = "Addition"
        oSheet.Cells(1, 7).Value = "Subtraction"

        oSheet.Cells(2, 1).Value = "100"
        oSheet.Cells(2, 2).Value = "40"
        oSheet.Cells(2, 3).Value = "10"
        oSheet.Cells(2, 4).Value = "20"
        oSheet.Cells(2, 5).Value = "10"

        oSheet.Cells(2, 6).Value = "=SUM(A1:E1)"
        oSheet.Cells(2, 7).Value = "Number 1"

        oWB.SaveAs("e:\19BCS0073.xls")
    End Sub
End Class
