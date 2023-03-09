Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tNode As TreeNode
        tNode = TreeView1.Nodes.Add("Desktop")

        TreeView1.Nodes(0).Nodes.Add(" Winter 2021 Visual Programming")
        TreeView1.Nodes(0).Nodes.Add("Assignments")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("DA1")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("DA2")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("DA3")
        TreeView1.Nodes(0).Nodes.Add("Test")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("Test 1")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("Test 2")

        TreeView1.Nodes(0).Nodes.Add("Quiz")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("Quiz1")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("Quiz2")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("Quiz3")
        TreeView1.Nodes(0).Nodes.Add("Problem Solving")
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("PS1")
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("PS2")

    End Sub
End Class
