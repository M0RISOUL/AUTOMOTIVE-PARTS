Imports System.Data.OleDb
Public Class frmTransaction
    Dim price As Single
    Dim totalAmount As Single
    Dim SubTotal As Single
    Dim List As ListViewItem
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbDataSource As String = "Data Source=C:\Users\Jet Boy Abordaje\source\repos\Project\Project\Automotive Parts.accdb"
    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Automotive_PartsDataSet2.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter1.Fill(Me.Automotive_PartsDataSet2.Transactions)
        'TODO: This line of code loads data into the 'Automotive_PartsDataSet1.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.Automotive_PartsDataSet1.Transactions)
        txtUserName.Text = "Automotive Parts"
        lblDate.Text = Today
        lblTime.Text = TimeOfDay.ToLongTimeString
        conn.ConnectionString = dbProvider & dbDataSource
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If rdoGCash.Checked = True Then
            lblPayment.Text = "GCash"
        ElseIf rdoPaymaya.Checked = True Then
            lblPayment.Text = "Paymaya"
        ElseIf rdoBankTransfer.Checked = True Then
            lblPayment.Text = "Bank Transfer"
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If




        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Transactions WHERE [ITEM] = @ITEM OR [QUANTITY] = @QUANTITY OR [PAYMENT] = @PAYMENT OR [ITEMSOLD] = @ITEMSOLD OR [PRICE] = @PRICE OR [AMOUNT] = @AMOUNT OR [TOTAL] = @TOTAL OR [TENDERED] = @TENDERED OR [CHANGE] = @CHANGE OR [DATE] = @DATE OR [TIME] = @TIME", conn)
            cmd.Parameters.AddWithValue("@ITEM", OleDbType.VarChar).Value = lstAppliances.Text.Trim
            cmd.Parameters.AddWithValue("@QUANTITY", OleDbType.VarChar).Value = nudQuantity.Text.Trim
            cmd.Parameters.AddWithValue("@PAYMENT", OleDbType.VarChar).Value = lblPayment.Text.Trim
            cmd.Parameters.AddWithValue("@ITEMSOLD", OleDbType.VarChar).Value = lstAutomotivePartsSold.Text.Trim
            cmd.Parameters.AddWithValue("@PRICE", OleDbType.VarChar).Value = lstUnitPrice.Text.Trim
            cmd.Parameters.AddWithValue("@AMOUNT", OleDbType.VarChar).Value = txtAmount.Text.Trim
            cmd.Parameters.AddWithValue("@TOTAL", OleDbType.VarChar).Value = txtTotalAmount.Text.Trim
            cmd.Parameters.AddWithValue("@TENDERED", OleDbType.VarChar).Value = txtAmountTendered.Text.Trim
            cmd.Parameters.AddWithValue("@CHANGE", OleDbType.VarChar).Value = txtChange.Text.Trim
            cmd.Parameters.AddWithValue("@DATE", OleDbType.VarChar).Value = txtDateOrder.Text.Trim
            cmd.Parameters.AddWithValue("@TIME", OleDbType.VarChar).Value = txtTimeOrder.Text.Trim
        End Using

        Using create As New OleDbCommand("INSERT INTO Transactions ([ITEM], [QUANTITY], [PAYMENT], [ITEMSOLD], [PRICE], [AMOUNT], [TOTAL], [TENDERED], [CHANGE], [DATE], [TIME])VALUES(@ITEM, @QUANTITY, @PAYMENT, @ITEMSOLD, @PRICE, @AMOUNT, @TOTAL, @TENDERED, @CHANGE, @DATE, @TIME)", conn)
            create.Parameters.AddWithValue("@ITEM", OleDbType.VarChar).Value = lstAppliances.Text.Trim
            create.Parameters.AddWithValue("@QUANTITY", OleDbType.VarChar).Value = nudQuantity.Text.Trim
            create.Parameters.AddWithValue("@PAYMENT", OleDbType.VarChar).Value = lblPayment.Text.Trim
            create.Parameters.AddWithValue("@ITEMSOLD", OleDbType.VarChar).Value = lstAutomotivePartsSold.Text.Trim
            create.Parameters.AddWithValue("@PRICE", OleDbType.VarChar).Value = lstUnitPrice.Text.Trim
            create.Parameters.AddWithValue("@AMOUNT", OleDbType.VarChar).Value = txtAmount.Text.Trim
            create.Parameters.AddWithValue("@TOTAL", OleDbType.VarChar).Value = txtTotalAmount.Text.Trim
            create.Parameters.AddWithValue("@TENDERED", OleDbType.VarChar).Value = txtAmountTendered.Text.Trim
            create.Parameters.AddWithValue("@CHANGE", OleDbType.VarChar).Value = txtChange.Text.Trim
            create.Parameters.AddWithValue("@DATE", OleDbType.VarChar).Value = txtDateOrder.Text.Trim
            create.Parameters.AddWithValue("@TIME", OleDbType.VarChar).Value = txtTimeOrder.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Your Transaction has been process!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lstAutomotivePartsSold.Items.Clear()
                lstUnitPrice.Items.Clear()
                nudQuantity.Text = 0
                txtAmount.Clear()
                txtTotalAmount.Clear()
                txtTotalAmount.Clear()
                txtAmountTendered.Clear()
                txtChange.Clear()
                Me.Hide()
            End If

            For item = 0 To lstAutomotivePartsSold.Items.Count - 1
                create.Parameters.AddWithValue("@ITEMSOLD", OleDbType.VarChar).Value = lstAutomotivePartsSold.Items(item)
                conn.Open()
                cmd.ExecuteNonQuery()
            Next
        End Using
        conn.Close()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim UserAmount As Integer

        UserAmount = txtAmountTendered.Text - txtTotalAmount.Text

        If (UserAmount < 0) Then
            MessageBox.Show("ENTER VALID AMOUNT", "ECOMMERCE, AUTOMOTIVE PARTS")
        Else
            txtChange.Text = FormatNumber(UserAmount, 2)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtAmount.Text = ""
        lstUnitPrice.Items.Clear()
        lstAppliances.ClearSelected()
        nudQuantity.TextAlign = 0
        lstAutomotivePartsSold.Items.Clear()
        txtTotalAmount.Text = ""
        txtAmountTendered.Text = ""
        txtChange.Text = ""
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs)
        btnCompute.Enabled = True
        totalAmount = SubTotal - (SubTotal * 0.05)
    End Sub

    Private Sub btnCharge_Click(sender As Object, e As EventArgs)
        btnCompute.Enabled = True
        totalAmount = SubTotal + (SubTotal * 0.05)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAutomotivePartsSold.Items.Clear()
        lstUnitPrice.Items.Clear()
        nudQuantity.Text = 0
        txtAmount.Text = ""
        txtTotalAmount.Text = ""
        txtTotalAmount.Text = ""
        txtAmountTendered.Text = ""
        txtChange.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub lstAppliances_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAppliances.SelectedIndexChanged
        Dim Quantity As Single
        Dim Amount As Single
        Quantity = nudQuantity.Text

        If nudQuantity.Text = 0 Then
            MessageBox.Show("ENTER QUANTITY", "ECOMMERCE, AUTOMOTIVE PARTS")
            Exit Sub
        End If
        If nudQuantity.Text > 0 Then

            If lstAppliances.SelectedIndex = 0 Then
                price = 5000
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = Amount
            End If
            If lstAppliances.SelectedIndex = 1 Then
                price = 6500
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 2 Then
                price = 8500
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 3 Then
                price = 1300
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 4 Then
                price = 1000
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 5 Then
                price = 530
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 6 Then
                price = 800
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 7 Then
                price = 700
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 8 Then
                price = 4000
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 9 Then
                price = 7000
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 10 Then
                price = 900
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 11 Then
                price = 1100
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 12 Then
                price = 6000
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 13 Then
                price = 500
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            If lstAppliances.SelectedIndex = 14 Then
                price = 14600
                lstUnitPrice.Items.Add(FormatNumber(price, 2))
                Amount = Quantity * price
                SubTotal = SubTotal + Amount
            End If
            For i = 0 To lstAppliances.Items.Count
                If lstAppliances.SelectedIndex = i Then
                    lstAutomotivePartsSold.Items.Add(lstAppliances.SelectedItem)
                End If
            Next
        End If
        txtTotalAmount.Text = FormatNumber(SubTotal, 2)
        txtAmount.Text = FormatNumber(Amount, 2)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtDateOrder.Text = DateTimePicker1.Text
        txtTimeOrder.Text = DateTimePicker1.Value
    End Sub
End Class