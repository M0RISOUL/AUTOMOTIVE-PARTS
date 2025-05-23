Imports System.Data.OleDb
Public Class frmRegister
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbDataSource
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUserName.Text = Nothing Or txtPassword.Text = Nothing Or cmbUserType.Text = Nothing Then
            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Accounts WHERE [USERNAME] = @USERNAME OR [PASSWORD] = @PASSWORD OR [USERTYPE] = @USERTYPE", conn)
            cmd.Parameters.AddWithValue("@FIRSTNAME", OleDbType.VarChar).Value = txtFirstName.Text.Trim
            cmd.Parameters.AddWithValue("@MIDDLENAME", OleDbType.VarChar).Value = txtMiddleName.Text.Trim
            cmd.Parameters.AddWithValue("@LASTNAME", OleDbType.VarChar).Value = txtLastName.Text.Trim
            cmd.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = txtEmail.Text.Trim
            cmd.Parameters.AddWithValue("@BIRTH", OleDbType.VarChar).Value = txtDB.Text.Trim
            cmd.Parameters.AddWithValue("@MOBILENO", OleDbType.VarChar).Value = txtMobNo.Text.Trim
            cmd.Parameters.AddWithValue("@ADDRESS", OleDbType.VarChar).Value = txtAddress.Text.Trim
            cmd.Parameters.AddWithValue("@GENDER", OleDbType.VarChar).Value = cmbGender.Text.Trim
            cmd.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUserName.Text.Trim
            cmd.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim
            cmd.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = cmbUserType.Text.Trim

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then

                MessageBox.Show("Opps, username and password has already take", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using

        Using create As New OleDbCommand("INSERT INTO Accounts ([FIRSTNAME], [MIDDLENAME], [LASTNAME], [EMAIL], [BIRTH], [MOBILENO], [ADDRESS], [GENDER], [USERNAME], [PASSWORD], [USERTYPE])VALUES(@FIRSTNAME, @MIDDLENAME, @LASTNAME, @EMAIL, @BIRTH, @MOBILENO, @ADDRESS, @GENDER, @USERNAME, @PASSWORD, @USERTYPE)", conn)
            create.Parameters.AddWithValue("@FIRSTNAME", OleDbType.VarChar).Value = txtFirstName.Text.Trim
            create.Parameters.AddWithValue("@MIDDLENAME", OleDbType.VarChar).Value = txtMiddleName.Text.Trim
            create.Parameters.AddWithValue("@LASTNAME", OleDbType.VarChar).Value = txtLastName.Text.Trim
            create.Parameters.AddWithValue("@EMAIL", OleDbType.VarChar).Value = txtEmail.Text.Trim
            create.Parameters.AddWithValue("@BIRTH", OleDbType.VarChar).Value = txtDB.Text.Trim
            create.Parameters.AddWithValue("@MOBILENO", OleDbType.VarChar).Value = txtMobNo.Text.Trim
            create.Parameters.AddWithValue("@ADDRESS", OleDbType.VarChar).Value = txtAddress.Text.Trim
            create.Parameters.AddWithValue("@GENDER", OleDbType.VarChar).Value = cmbGender.Text.Trim
            create.Parameters.AddWithValue("@USERNAME", OleDbType.VarChar).Value = txtUserName.Text.Trim
            create.Parameters.AddWithValue("@PASSWORD", OleDbType.VarChar).Value = txtPassword.Text.Trim
            create.Parameters.AddWithValue("@USERTYPE", OleDbType.VarChar).Value = cmbUserType.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Account created!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtFirstName.Clear()
                txtMiddleName.Clear()
                txtEmail.Clear()
                txtMobNo.Clear()
                cmbGender.Text = ""
                txtUserName.Clear()
                txtPassword.Clear()
                cmbUserType.Text = ""
                Me.Hide()
                frmLogin.Show()
            End If
        End Using
        conn.Close()
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class