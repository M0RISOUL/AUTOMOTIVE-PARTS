Imports System.Data.OleDb
Public Class frmSecurityV2
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
    Private Sub frmSecurityV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If txtCurrentPassword.Text = Nothing Or txtNewPassword.Text = Nothing Or txtConfirmPassword.Text = Nothing Then
            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM SecurityV2 WHERE [CURRENTPASSWORD] = @CURRENTPASSWORD OR [NEWPASSWORD] = @NEWPASSWORD OR [CONFIRMPASSWORD] = @CONFIRMPASSWORD", conn)
            cmd.Parameters.AddWithValue("@CURRENTPASSWORD", OleDbType.VarChar).Value = txtCurrentPassword.Text.Trim
            cmd.Parameters.AddWithValue("@NEWPASSWORD", OleDbType.VarChar).Value = txtNewPassword.Text.Trim
            cmd.Parameters.AddWithValue("@CONFIRMPASSWORD", OleDbType.VarChar).Value = txtConfirmPassword.Text.Trim

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then

                MessageBox.Show("Opps, username and password has already take", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using

        Using create As New OleDbCommand("INSERT INTO SecurityV2 ([CURRENTPASSWORD], [NEWPASSWORD], [CONFIRMPASSWORD])VALUES(@CURRENTPASSWORD, @NEWPASSWORD, @CONFIRMPASSWORD)", conn)
            create.Parameters.AddWithValue("@CURRENTPASSWORD", OleDbType.VarChar).Value = txtCurrentPassword.Text.Trim
            create.Parameters.AddWithValue("@NEWPASSWORD", OleDbType.VarChar).Value = txtNewPassword.Text.Trim
            create.Parameters.AddWithValue("@CONFIRMPASSWORD", OleDbType.VarChar).Value = txtConfirmPassword.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Account created!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCurrentPassword.Clear()
                txtNewPassword.Clear()
                txtConfirmPassword.Clear()
                Me.Hide()
                frmLogin.Show()
            End If
        End Using
        conn.Close()
    End Sub
End Class