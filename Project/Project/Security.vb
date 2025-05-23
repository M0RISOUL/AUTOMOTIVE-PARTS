Imports System.Data.OleDb
Public Class frmSecurity
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
    Private Sub Security_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Please enter correct credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using Login As New OleDbCommand("SELECT COUNT(*) FROM Security WHERE [USERNAME] = @USERNAME AND [PASSWORD] = @PASSWORD", conn)
            Login.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUsername.Text.Trim
            Login.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim

            Dim Logincount = Convert.ToInt32(Login.ExecuteScalar())
            If Logincount > 0 Then
                Me.Hide()
                frmSecurityV2.Show()
            Else
                MessageBox.Show("Opps Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Clear()
                txtPassword.Clear()

            End If
        End Using
        conn.Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Me.Hide()
        frmSecurityV2.Show()
    End Sub
End Class