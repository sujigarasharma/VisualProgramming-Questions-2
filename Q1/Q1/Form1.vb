Public Class Form1
    'Display the following detail in the List View control
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ListItem1 As ListViewItem
        ListItem1 = ListView1.Items.Add("Registration Number : 19BCS0129")

        Dim ListItem2 As ListViewItem
        ListItem2 = ListView1.Items.Add("Name : Sujigarasharma K")

        Dim ListItem3 As ListViewItem
        ListItem3 = ListView1.Items.Add("Age : 20")

        Dim ListItem4 As ListViewItem
        ListItem4 = ListView1.Items.Add("Gender : Male")

        Dim ListItem5 As ListViewItem
        ListItem5 = ListView1.Items.Add("Address : No2, Sivan Street, Trincomalee")

        Dim ListItem6 As ListViewItem
        ListItem6 = ListView1.Items.Add("Total No of Credits Earned : 90")

        Dim ListItem7 As ListViewItem
        ListItem7 = ListView1.Items.Add("City : Trincomalee")

        Dim ListItem8 As ListViewItem
        ListItem8 = ListView1.Items.Add("State : Eastern Province")

        Dim ListItem9 As ListViewItem
        ListItem9 = ListView1.Items.Add("Country : SriLanka")
    End Sub

End Class
