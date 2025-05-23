Public Class frmMenu
    Public Property Menu As String

    Private Sub TransactionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem1.Click
        Dim Item As New frmTransaction
        Item.Name = Menu
        Item.Show()
    End Sub

    Private Sub DeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryToolStripMenuItem.Click
        Dim Item As New frmDelivery
        Item.Name = Menu
        Item.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class