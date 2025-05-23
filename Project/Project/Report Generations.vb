Imports System.Data.OleDb
Public Class frmReportGenerations
    Dim conn As New OleDbConnection
    Dim List As ListViewItem

    'Dim conn As New OleDbConnection
    'Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    'Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
    Private Sub frmReportGenerations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Automotive_PartsDataSet6.BuyerList' table. You can move, or remove it, as needed.
        Me.BuyerListTableAdapter2.Fill(Me.Automotive_PartsDataSet6.BuyerList)
        'TODO: This line of code loads data into the 'Automotive_PartsDataSet5.BuyerList' table. You can move, or remove it, as needed.
        Me.BuyerListTableAdapter1.Fill(Me.Automotive_PartsDataSet5.BuyerList)
        '   conn.ConnectionString = dbProvider & dbDataSource

        '        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb")
        '       con.Open()
        '      Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM BuyerList WHERE [SURNAME] = @SURNAME AND [FIRSTNAME] = @FIRSTNAME AND [MIDDLEINITIAL] = @MIDDLEINITIAL", con)
        '     Dim da As New OleDbDataAdapter
        '    da.SelectCommand = cmd
        '   Dim dt As New DataTable
        ''  dt.Clear()
        ' da.Fill(dt)
        ' DataGridView1.DataSource = dt
        'con.Close()

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
        conn.Open()

        datagridShow()

    End Sub
    Private Sub datagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from BuyerList", conn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click

        Dim Name As String = txtAPName.Text
        Dim Stock As String = txtAPStock.Text
        Dim Price As String = txtPrice.Text


        List = lsvItems.Items.Add(Name)
        List.SubItems.Add(Stock)
        List.SubItems.Add(Price)
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim items As ListViewItem
        items = lsvItems.SelectedItems(0)
        items.Remove()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvItems.SelectedIndexChanged
        List.Remove()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAPName.Text = "" Or txtAPStock.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Please enter complete data...",
           "Data Entry", MessageBoxButtons.OK,
           MessageBoxIcon.Information)
        Else
            txtAPName.Enabled = True
            txtAPStock.Enabled = True
            txtPrice.Enabled = True
            btnSave.Enabled = True
            btnADD.Enabled = True
        End If


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Inventory WHERE [ITEM] = @ITEM OR [STOCK] = @STOCK OR [PRICE] = @PRICE ", conn)
            cmd.Parameters.AddWithValue("@ITEM", OleDbType.VarChar).Value = txtAPName.Text.Trim
            cmd.Parameters.AddWithValue("@STOCK", OleDbType.VarChar).Value = txtAPStock.Text.Trim
            cmd.Parameters.AddWithValue("@PRICE", OleDbType.VarChar).Value = txtPrice.Text.Trim
        End Using

        Using create As New OleDbCommand("INSERT INTO Inventory ([ITEM], [STOCK], [PRICE])VALUES(@ITEM, @STOCK, @PRICE)", conn)
            create.Parameters.AddWithValue("@NAME", OleDbType.VarChar).Value = txtAPName.Text.Trim
            create.Parameters.AddWithValue("@STOCK", OleDbType.VarChar).Value = txtAPStock.Text.Trim
            create.Parameters.AddWithValue("@PRICE", OleDbType.VarChar).Value = txtPrice.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Your Order has been process!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAPName.Clear()
                txtAPStock.Clear()
                txtPrice.Clear()
                'Me.Hide()
                frmSALES.Show()
            End If
        End Using
        conn.Close()
        'Me.Hide()
        frmSALES.Show()

    End Sub
End Class