Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4, s5, s6, s7, salary As Integer

        s1 = TextBox3.Text
        s2 = TextBox4.Text
        s3 = TextBox5.Text
        s4 = TextBox6.Text
        s5 = TextBox7.Text
        s6 = TextBox8.Text
        s7 = TextBox9.Text

        salary = (s1 + s2 + s3 + s4) - (s5 + s6 + s7)

        Dim ListItem1 As ListViewItem
        ListItem1 = ListView1.Items.Add("Number : " & TextBox1.Text)

        Dim ListItem2 As ListViewItem
        ListItem2 = ListView1.Items.Add("Name : " & TextBox2.Text)

        Dim ListItem3 As ListViewItem
        ListItem3 = ListView1.Items.Add("Basic Salary : " & s1)

        Dim ListItem4 As ListViewItem
        ListItem4 = ListView1.Items.Add("HRA : " & s2)

        Dim ListItem5 As ListViewItem
        ListItem5 = ListView1.Items.Add("Transport Allowance : " & s3)

        Dim ListItem6 As ListViewItem
        ListItem6 = ListView1.Items.Add("Bonus : " & s4)

        Dim ListItem7 As ListViewItem
        ListItem7 = ListView1.Items.Add("Provident Fund : " & s5)

        Dim ListItem8 As ListViewItem
        ListItem8 = ListView1.Items.Add("Income Tax : " & s6)

        Dim ListItem9 As ListViewItem
        ListItem9 = ListView1.Items.Add("Insurance : " & s7)

        Dim ListItem10 As ListViewItem
        ListItem10 = ListView1.Items.Add("Salary : " & salary)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
    End Sub
End Class
