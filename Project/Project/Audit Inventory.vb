Public Class Audit_Inventory
    Private Sub Audit_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Today
        lblTime.Text = TimeOfDay.ToLongTimeString
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtDate.Text = DateTimePicker1.Text.Trim
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class