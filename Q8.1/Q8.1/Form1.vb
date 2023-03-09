Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tNode As TreeNode
        tNode = TreeView1.Nodes.Add("VIT University InformationTechnology")

        TreeView1.Nodes(0).Nodes.Add("Smart Computing System ")
        TreeView1.Nodes(0).Nodes.Add("MSC")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("MSC I")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("MSC II")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("MSC II")
        TreeView1.Nodes(0).Nodes.Add("BSC")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("BSC I")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("BSC II")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("BSC III")
        TreeView1.Nodes(0).Nodes.Add("BCA")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("BCA1")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("BCA2")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("BCA3")
        TreeView1.Nodes(0).Nodes.Add("MCA")
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("MCA1")
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("MCA2")
    End Sub
End Class
