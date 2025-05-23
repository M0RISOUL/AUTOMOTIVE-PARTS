<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaction))
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtAmountTendered = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.lblAmountTendered = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lstUnitPrice = New System.Windows.Forms.ListBox()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Automotive_PartsDataSet1 = New Project.Automotive_PartsDataSet1()
        Me.lstAutomotivePartsSold = New System.Windows.Forms.ListBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblApplianceSold = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPayments = New System.Windows.Forms.Label()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.rdoBankTransfer = New System.Windows.Forms.RadioButton()
        Me.rdoPaymaya = New System.Windows.Forms.RadioButton()
        Me.rdoGCash = New System.Windows.Forms.RadioButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstAppliances = New System.Windows.Forms.ListBox()
        Me.lblAppliances = New System.Windows.Forms.Label()
        Me.TransactionsTableAdapter = New Project.Automotive_PartsDataSet1TableAdapters.TransactionsTableAdapter()
        Me.Automotive_PartsDataSet2 = New Project.Automotive_PartsDataSet2()
        Me.TransactionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter1 = New Project.Automotive_PartsDataSet2TableAdapters.TransactionsTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTimeOrder = New System.Windows.Forms.TextBox()
        Me.txtDateOrder = New System.Windows.Forms.TextBox()
        Me.lblDateOrder = New System.Windows.Forms.Label()
        Me.lblTimeOrder = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Automotive_PartsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gb.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Automotive_PartsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNew.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(24, 148)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 63)
        Me.btnNew.TabIndex = 36
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtAmountTendered
        '
        Me.txtAmountTendered.Location = New System.Drawing.Point(345, 28)
        Me.txtAmountTendered.Name = "txtAmountTendered"
        Me.txtAmountTendered.Size = New System.Drawing.Size(180, 22)
        Me.txtAmountTendered.TabIndex = 49
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(347, 94)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(180, 22)
        Me.txtChange.TabIndex = 48
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnChange.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(17, 84)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(91, 40)
        Me.btnChange.TabIndex = 35
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'lblAmountTendered
        '
        Me.lblAmountTendered.AutoSize = True
        Me.lblAmountTendered.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountTendered.Location = New System.Drawing.Point(13, 27)
        Me.lblAmountTendered.Name = "lblAmountTendered"
        Me.lblAmountTendered.Size = New System.Drawing.Size(139, 22)
        Me.lblAmountTendered.TabIndex = 46
        Me.lblAmountTendered.Text = "Amount Tendered:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox5.Controls.Add(Me.lblPayment)
        Me.GroupBox5.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox5.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox5.Controls.Add(Me.txtAmount)
        Me.GroupBox5.Controls.Add(Me.lstUnitPrice)
        Me.GroupBox5.Controls.Add(Me.lstAutomotivePartsSold)
        Me.GroupBox5.Controls.Add(Me.lblAmount)
        Me.GroupBox5.Controls.Add(Me.lblUnitPrice)
        Me.GroupBox5.Controls.Add(Me.lblApplianceSold)
        Me.GroupBox5.Location = New System.Drawing.Point(491, 219)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(590, 302)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(363, 148)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(0, 17)
        Me.lblPayment.TabIndex = 53
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(11, 261)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(103, 22)
        Me.lblTotalAmount.TabIndex = 52
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(371, 261)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(152, 22)
        Me.txtTotalAmount.TabIndex = 51
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(371, 53)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 22)
        Me.txtAmount.TabIndex = 47
        '
        'lstUnitPrice
        '
        Me.lstUnitPrice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TransactionsBindingSource, "PRICE", True))
        Me.lstUnitPrice.DisplayMember = "PRICE"
        Me.lstUnitPrice.FormattingEnabled = True
        Me.lstUnitPrice.ItemHeight = 16
        Me.lstUnitPrice.Location = New System.Drawing.Point(173, 51)
        Me.lstUnitPrice.Name = "lstUnitPrice"
        Me.lstUnitPrice.Size = New System.Drawing.Size(152, 196)
        Me.lstUnitPrice.TabIndex = 44
        Me.lstUnitPrice.ValueMember = "PRICE"
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.Automotive_PartsDataSet1
        '
        'Automotive_PartsDataSet1
        '
        Me.Automotive_PartsDataSet1.DataSetName = "Automotive_PartsDataSet1"
        Me.Automotive_PartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstAutomotivePartsSold
        '
        Me.lstAutomotivePartsSold.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TransactionsBindingSource, "ITEMSOLD", True))
        Me.lstAutomotivePartsSold.DataBindings.Add(New System.Windows.Forms.Binding("SelectedIndex", Me.TransactionsBindingSource, "ITEMSOLD", True))
        Me.lstAutomotivePartsSold.DisplayMember = "ITEMSOLD"
        Me.lstAutomotivePartsSold.FormattingEnabled = True
        Me.lstAutomotivePartsSold.ItemHeight = 16
        Me.lstAutomotivePartsSold.Location = New System.Drawing.Point(10, 51)
        Me.lstAutomotivePartsSold.Name = "lstAutomotivePartsSold"
        Me.lstAutomotivePartsSold.Size = New System.Drawing.Size(157, 196)
        Me.lstAutomotivePartsSold.TabIndex = 43
        Me.lstAutomotivePartsSold.ValueMember = "ITEMSOLD"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(367, 19)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(69, 22)
        Me.lblAmount.TabIndex = 42
        Me.lblAmount.Text = "Amount:"
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(206, 19)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(82, 22)
        Me.lblUnitPrice.TabIndex = 41
        Me.lblUnitPrice.Text = "Unit Price:"
        '
        'lblApplianceSold
        '
        Me.lblApplianceSold.AutoSize = True
        Me.lblApplianceSold.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplianceSold.Location = New System.Drawing.Point(11, 19)
        Me.lblApplianceSold.Name = "lblApplianceSold"
        Me.lblApplianceSold.Size = New System.Drawing.Size(169, 22)
        Me.lblApplianceSold.TabIndex = 40
        Me.lblApplianceSold.Text = "Automotive Parts Sold:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox6.Controls.Add(Me.txtAmountTendered)
        Me.GroupBox6.Controls.Add(Me.txtChange)
        Me.GroupBox6.Controls.Add(Me.btnChange)
        Me.GroupBox6.Controls.Add(Me.lblAmountTendered)
        Me.GroupBox6.Location = New System.Drawing.Point(489, 527)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(591, 142)
        Me.GroupBox6.TabIndex = 72
        Me.GroupBox6.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox4.Controls.Add(Me.btnNew)
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Controls.Add(Me.btnCompute)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.lblQuantity)
        Me.GroupBox4.Controls.Add(Me.nudQuantity)
        Me.GroupBox4.Location = New System.Drawing.Point(348, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(134, 582)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClose.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(24, 335)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 59)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCompute.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(24, 441)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(90, 96)
        Me.btnCompute.TabIndex = 39
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(24, 251)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 63)
        Me.btnClear.TabIndex = 37
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(20, 19)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(69, 22)
        Me.lblQuantity.TabIndex = 33
        Me.lblQuantity.Text = "Quantity"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(24, 74)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(90, 22)
        Me.nudQuantity.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.lblTime)
        Me.GroupBox2.Controls.Add(Me.lblDate)
        Me.GroupBox2.Controls.Add(Me.txtUserName)
        Me.GroupBox2.Controls.Add(Me.lblUserName)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1053, 57)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(434, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker1.TabIndex = 73
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(913, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 19)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(749, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(93, 20)
        Me.lblDate.TabIndex = 32
        Me.lblDate.Text = "Date:"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(193, 17)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(217, 22)
        Me.txtUserName.TabIndex = 31
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(46, 21)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(138, 17)
        Me.lblUserName.TabIndex = 30
        Me.lblUserName.Text = "E-Commerce Name: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.lblPayments)
        Me.GroupBox1.Controls.Add(Me.gb)
        Me.GroupBox1.Controls.Add(Me.lstAppliances)
        Me.GroupBox1.Controls.Add(Me.lblAppliances)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 582)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'lblPayments
        '
        Me.lblPayments.AutoSize = True
        Me.lblPayments.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayments.Location = New System.Drawing.Point(59, 292)
        Me.lblPayments.Name = "lblPayments"
        Me.lblPayments.Size = New System.Drawing.Size(138, 22)
        Me.lblPayments.TabIndex = 37
        Me.lblPayments.Text = "Type of Payments:"
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.gb.Controls.Add(Me.rdoBankTransfer)
        Me.gb.Controls.Add(Me.rdoPaymaya)
        Me.gb.Controls.Add(Me.rdoGCash)
        Me.gb.Controls.Add(Me.PictureBox4)
        Me.gb.Controls.Add(Me.PictureBox3)
        Me.gb.Controls.Add(Me.PictureBox1)
        Me.gb.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb.Location = New System.Drawing.Point(28, 308)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(246, 255)
        Me.gb.TabIndex = 36
        Me.gb.TabStop = False
        '
        'rdoBankTransfer
        '
        Me.rdoBankTransfer.AutoSize = True
        Me.rdoBankTransfer.Location = New System.Drawing.Point(66, 222)
        Me.rdoBankTransfer.Name = "rdoBankTransfer"
        Me.rdoBankTransfer.Size = New System.Drawing.Size(129, 26)
        Me.rdoBankTransfer.TabIndex = 65
        Me.rdoBankTransfer.TabStop = True
        Me.rdoBankTransfer.Text = "Bank Transfer"
        Me.rdoBankTransfer.UseVisualStyleBackColor = True
        '
        'rdoPaymaya
        '
        Me.rdoPaymaya.AutoSize = True
        Me.rdoPaymaya.Location = New System.Drawing.Point(140, 116)
        Me.rdoPaymaya.Name = "rdoPaymaya"
        Me.rdoPaymaya.Size = New System.Drawing.Size(92, 26)
        Me.rdoPaymaya.TabIndex = 64
        Me.rdoPaymaya.TabStop = True
        Me.rdoPaymaya.Text = "Paymaya"
        Me.rdoPaymaya.UseVisualStyleBackColor = True
        '
        'rdoGCash
        '
        Me.rdoGCash.AutoSize = True
        Me.rdoGCash.Location = New System.Drawing.Point(21, 116)
        Me.rdoGCash.Name = "rdoGCash"
        Me.rdoGCash.Size = New System.Drawing.Size(77, 26)
        Me.rdoGCash.TabIndex = 63
        Me.rdoGCash.TabStop = True
        Me.rdoGCash.Text = "GCash"
        Me.rdoGCash.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(66, 148)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(110, 68)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(140, 39)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lstAppliances
        '
        Me.lstAppliances.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lstAppliances.FormattingEnabled = True
        Me.lstAppliances.ItemHeight = 16
        Me.lstAppliances.Items.AddRange(New Object() {"Fuel Tank", "Starter", "Condenser", "Radiator", "Coil", "Auxiliary Fan", "Timing Belt", "Alternator", "Transmission", "Fly Wheel", "Ball Joint", "Clutch Plate", "Propeller Shaft", "Release Bearing", "Computer Box"})
        Me.lstAppliances.Location = New System.Drawing.Point(28, 41)
        Me.lstAppliances.Name = "lstAppliances"
        Me.lstAppliances.Size = New System.Drawing.Size(246, 244)
        Me.lstAppliances.TabIndex = 34
        '
        'lblAppliances
        '
        Me.lblAppliances.AutoSize = True
        Me.lblAppliances.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppliances.Location = New System.Drawing.Point(59, 19)
        Me.lblAppliances.Name = "lblAppliances"
        Me.lblAppliances.Size = New System.Drawing.Size(134, 22)
        Me.lblAppliances.TabIndex = 33
        Me.lblAppliances.Text = "Automotive Parts:"
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Automotive_PartsDataSet2
        '
        Me.Automotive_PartsDataSet2.DataSetName = "Automotive_PartsDataSet2"
        Me.Automotive_PartsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionsBindingSource1
        '
        Me.TransactionsBindingSource1.DataMember = "Transactions"
        Me.TransactionsBindingSource1.DataSource = Me.Automotive_PartsDataSet2
        '
        'TransactionsTableAdapter1
        '
        Me.TransactionsTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTimeOrder)
        Me.GroupBox3.Controls.Add(Me.lblDateOrder)
        Me.GroupBox3.Controls.Add(Me.txtTimeOrder)
        Me.GroupBox3.Controls.Add(Me.txtDateOrder)
        Me.GroupBox3.Location = New System.Drawing.Point(491, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 127)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        '
        'txtTimeOrder
        '
        Me.txtTimeOrder.Location = New System.Drawing.Point(179, 76)
        Me.txtTimeOrder.Name = "txtTimeOrder"
        Me.txtTimeOrder.Size = New System.Drawing.Size(202, 22)
        Me.txtTimeOrder.TabIndex = 53
        '
        'txtDateOrder
        '
        Me.txtDateOrder.Location = New System.Drawing.Point(179, 29)
        Me.txtDateOrder.Name = "txtDateOrder"
        Me.txtDateOrder.Size = New System.Drawing.Size(202, 22)
        Me.txtDateOrder.TabIndex = 52
        '
        'lblDateOrder
        '
        Me.lblDateOrder.AutoSize = True
        Me.lblDateOrder.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOrder.Location = New System.Drawing.Point(24, 29)
        Me.lblDateOrder.Name = "lblDateOrder"
        Me.lblDateOrder.Size = New System.Drawing.Size(90, 22)
        Me.lblDateOrder.TabIndex = 54
        Me.lblDateOrder.Text = "Date Order:"
        '
        'lblTimeOrder
        '
        Me.lblTimeOrder.AutoSize = True
        Me.lblTimeOrder.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOrder.Location = New System.Drawing.Point(24, 76)
        Me.lblTimeOrder.Name = "lblTimeOrder"
        Me.lblTimeOrder.Size = New System.Drawing.Size(92, 22)
        Me.lblTimeOrder.TabIndex = 55
        Me.lblTimeOrder.Text = "Time Order:"
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1092, 716)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTransaction"
        Me.Text = "Transaction"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Automotive_PartsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Automotive_PartsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents txtAmountTendered As TextBox
    Friend WithEvents txtChange As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents lblAmountTendered As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lstUnitPrice As ListBox
    Friend WithEvents lstAutomotivePartsSold As ListBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblApplianceSold As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPayments As Label
    Friend WithEvents gb As GroupBox
    Friend WithEvents rdoBankTransfer As RadioButton
    Friend WithEvents rdoPaymaya As RadioButton
    Friend WithEvents rdoGCash As RadioButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstAppliances As ListBox
    Friend WithEvents lblAppliances As Label
    Friend WithEvents Automotive_PartsDataSet1 As Automotive_PartsDataSet1
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As Automotive_PartsDataSet1TableAdapters.TransactionsTableAdapter
    Friend WithEvents Automotive_PartsDataSet2 As Automotive_PartsDataSet2
    Friend WithEvents TransactionsBindingSource1 As BindingSource
    Friend WithEvents TransactionsTableAdapter1 As Automotive_PartsDataSet2TableAdapters.TransactionsTableAdapter
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTimeOrder As TextBox
    Friend WithEvents txtDateOrder As TextBox
    Friend WithEvents lblTimeOrder As Label
    Friend WithEvents lblDateOrder As Label
End Class
