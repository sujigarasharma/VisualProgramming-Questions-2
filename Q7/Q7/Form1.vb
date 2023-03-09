Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        ListView1.Columns.Add("Fruit Name", 100)
        ListView1.Columns.Add("Price", 70)
        ListView1.Columns.Add("Quantity", 70)
        ListView1.Columns.Add("Total Amount", 170)

        Dim list(6) As String
        Dim item As ListViewItem

        list(0) = "Apple"
        list(1) = "300"
        list(2) = "1"
        list(3) = "300"
        item = New ListViewItem(list)
        ListView1.Items.Add(item)

        list(0) = "Mango "
        list(1) = "200"
        list(2) = "2"
        list(3) = "400"
        item = New ListViewItem(list)
        ListView1.Items.Add(item)

        list(0) = "Jack Fruit "
        list(1) = "250"
        list(2) = "4"
        list(3) = "1000"
        item = New ListViewItem(list)
        ListView1.Items.Add(item)

        list(0) = "Orange "
        list(1) = "500"
        list(2) = "5"
        list(3) = "2500"
        item = New ListViewItem(list)
        ListView1.Items.Add(item)

        list(0) = "Grapes "
        list(1) = "300"
        list(2) = "10"
        list(3) = "3000"
        item = New ListViewItem(list)
        ListView1.Items.Add(item)

    End Sub
End Class
