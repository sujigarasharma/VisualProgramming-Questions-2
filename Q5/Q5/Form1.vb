Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim root = New TreeNode("Visual Programming")
        Dim i As Integer
        TreeView1.Nodes.Add(root)

        TreeView1.Nodes(0).Nodes.Add(New TreeNode("Tree View Control1"))
        For i = 1 To 4
            TreeView1.Nodes(0).Nodes(0).Nodes.Add(New TreeNode("Tree View Control" & i))
        Next i
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("Tree View Control2"))
        For i = 1 To 4
            TreeView1.Nodes(0).Nodes(1).Nodes.Add(New TreeNode("Tree View Control" & i))
        Next i

    End Sub
End Class
