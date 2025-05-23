Imports System.Data.OleDb
Public Class frmLogin
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUname.Text = Nothing Or txtPass.Text = Nothing Or cmbUserType.Text = Nothing Then
            MessageBox.Show("Please enter correct credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using Login As New OleDbCommand("SELECT COUNT(*) FROM Accounts WHERE [USERNAME] = @USERNAME AND [PASSWORD] = @PASSWORD AND [USERTYPE] = @USERTYPE", conn)
            Login.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUname.Text.Trim
            Login.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPass.Text.Trim
            Login.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = cmbUserType.Text.Trim

            Dim Logincount = Convert.ToInt32(Login.ExecuteScalar())
            If Logincount > 0 Then
                Me.Hide()
                frmMenu.Show()
            Else
                MessageBox.Show("Opps Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUname.Clear()
                txtPass.Clear()
                cmbUserType.Text = ""

            End If
        End Using
        conn.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
