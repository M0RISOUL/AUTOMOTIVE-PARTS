Imports System.Data.OleDb
Module Login_Module
    Public Function strconnection() As OleDbConnection
        Return New OleDbConnection("Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb")
    End Function
    Public strconn As OleDbConnection = strconnection()
    Public result As String
    Public cmd As New OleDbCommand
    Public da As OleDbDataAdapter
    Public dt As DataTable

    Public Sub reload(ByVal sql As String, ByVal Datagrid As Object)
        Try
            strconn.Open()
            Datagrid = New DataTable
            cmd.Connection = strconn
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strconn.Close()
            da.Dispose()
        End Try
    End Sub
End Module