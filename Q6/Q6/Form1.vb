Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick, MyBase.Load
        If OvalShape1.Visible Then
            OvalShape1.Visible = False
            OvalShape2.Visible = True
            OvalShape3.Visible = False
        ElseIf OvalShape2.Visible Then
            OvalShape1.Visible = False
            OvalShape2.Visible = False
            OvalShape3.Visible = True
        ElseIf OvalShape3.Visible Then
            OvalShape1.Visible = True
            OvalShape2.Visible = False
            OvalShape3.Visible = False
        End If
    End Sub


End Class
