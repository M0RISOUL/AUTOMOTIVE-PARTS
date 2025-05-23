<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Audit_Inventory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.SOLD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ITEM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AUDIT = New System.Windows.Forms.TabPage()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.AUTRANSACTIONRECORD = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AUORDER = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AUITEM = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.audit4 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2.SuspendLayout()
        Me.AUDIT.SuspendLayout()
        Me.AUTRANSACTIONRECORD.SuspendLayout()
        Me.AUORDER.SuspendLayout()
        Me.AUITEM.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.audit4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(582, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AUTOMOTIVE PARTS "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1090, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(266, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1255, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 17)
        Me.lblTime.TabIndex = 23
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1087, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 17)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Date"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1345, 545)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "AUDIT2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SOLD, Me.ITEM})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(87, 58)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(1174, 450)
        Me.ListView3.TabIndex = 0
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'SOLD
        '
        Me.SOLD.DisplayIndex = 1
        Me.SOLD.Text = "SOLD"
        Me.SOLD.Width = 751
        '
        'ITEM
        '
        Me.ITEM.DisplayIndex = 0
        Me.ITEM.Text = "ITEM"
        Me.ITEM.Width = 582
        '
        'AUDIT
        '
        Me.AUDIT.Controls.Add(Me.ListView4)
        Me.AUDIT.Controls.Add(Me.ListBox2)
        Me.AUDIT.Location = New System.Drawing.Point(4, 25)
        Me.AUDIT.Name = "AUDIT"
        Me.AUDIT.Padding = New System.Windows.Forms.Padding(3)
        Me.AUDIT.Size = New System.Drawing.Size(1345, 545)
        Me.AUDIT.TabIndex = 3
        Me.AUDIT.Text = "AUDIT"
        Me.AUDIT.UseVisualStyleBackColor = True
        '
        'ListView4
        '
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(47, 65)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(478, 419)
        Me.ListView4.TabIndex = 1
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(763, 64)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(440, 420)
        Me.ListBox2.TabIndex = 0
        '
        'AUTRANSACTIONRECORD
        '
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.ListView1)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label13)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox8)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox7)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox6)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.txtDate)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox4)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox3)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox2)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.TextBox1)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label12)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label11)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.ComboBox1)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label10)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label9)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label8)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label7)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label6)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label5)
        Me.AUTRANSACTIONRECORD.Controls.Add(Me.Label4)
        Me.AUTRANSACTIONRECORD.Location = New System.Drawing.Point(4, 25)
        Me.AUTRANSACTIONRECORD.Name = "AUTRANSACTIONRECORD"
        Me.AUTRANSACTIONRECORD.Padding = New System.Windows.Forms.Padding(3)
        Me.AUTRANSACTIONRECORD.Size = New System.Drawing.Size(1345, 545)
        Me.AUTRANSACTIONRECORD.TabIndex = 2
        Me.AUTRANSACTIONRECORD.Text = "TRANSACTION RECORD"
        Me.AUTRANSACTIONRECORD.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(44, 98)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(325, 416)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(113, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 25)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "DELIVERY DETAILS :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(636, 492)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(275, 22)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(636, 131)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(275, 22)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1056, 213)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(275, 22)
        Me.TextBox6.TabIndex = 12
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(1056, 47)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(275, 22)
        Me.txtDate.TabIndex = 11
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(636, 375)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(296, 74)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(636, 293)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(275, 22)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(636, 210)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(275, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(636, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(492, 492)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 37)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "CITY :"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(492, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 37)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "FIRSTNAME :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Monday, 5 October 2022", "Monday, 12 October 2022", "Monday, 19 October 2022", "Monday, 24 October 2022", "Monday, 2 October 2022", "", "Tuesday, 4 October 2022", "Tuesday, 11 October 2022", "Tuesday, 18 October 2022", "Tuesday, 25 October 2022", "Tuesday, 1 November 2022", "", "Wednesday, 5 October 2022", "Wednesday, 12 October 2022", "Wednesday, 19 October 2022", "Wednesday, 26 October 2022", "Wednesday, 2 November 2022", "", "Thursday, 6 October 2022", "Thursday, 13 October 2022", "Thursday, 20 October 2022", "Thursday, 27 October 2022", "Thursday, 3 November 2022", "", "Friday, 7 October 2022", "Friday, 14 October 2022", "Friday, 21 October 2022", "Friday, 28 October 2022", "Friday, 4 November 2022", "", "Saturday, 8 October 2022", "Saturday, 15 October 2022", "Saturday, 22 October 2022", "Saturday, 29 October 2022", "Saturday, 5 November 2022", "", "Sunday, 2 October 2022", "Sunday, 9 October 2022", "Sunday, 16 October 2022", "Sunday, 23 October 2022", "Sunday, 30 October 2022"})
        Me.ComboBox1.Location = New System.Drawing.Point(1090, 128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 24)
        Me.ComboBox1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(957, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 37)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "DATE :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(957, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 37)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "TOTAL :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(957, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 37)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "AMOUNT :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(492, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 37)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "QUANTITY :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(492, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 37)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Address :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(492, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Item :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(492, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 37)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SURNAME :"
        '
        'AUORDER
        '
        Me.AUORDER.Controls.Add(Me.Label18)
        Me.AUORDER.Controls.Add(Me.Label19)
        Me.AUORDER.Controls.Add(Me.Label20)
        Me.AUORDER.Controls.Add(Me.Label16)
        Me.AUORDER.Controls.Add(Me.Label15)
        Me.AUORDER.Controls.Add(Me.Label14)
        Me.AUORDER.Controls.Add(Me.Label3)
        Me.AUORDER.Location = New System.Drawing.Point(4, 25)
        Me.AUORDER.Name = "AUORDER"
        Me.AUORDER.Padding = New System.Windows.Forms.Padding(3)
        Me.AUORDER.Size = New System.Drawing.Size(1345, 545)
        Me.AUORDER.TabIndex = 1
        Me.AUORDER.Text = "ORDER"
        Me.AUORDER.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(41, 371)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(127, 37)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "CHANGE"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(41, 317)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(127, 37)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "TENDERED"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(41, 261)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 37)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "TOTAL"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(41, 209)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 37)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "AMOUNT"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(41, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 37)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "PRICE"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(41, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 37)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(41, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ITEMSOLD"
        '
        'AUITEM
        '
        Me.AUITEM.Controls.Add(Me.ListBox1)
        Me.AUITEM.Controls.Add(Me.ListView2)
        Me.AUITEM.Location = New System.Drawing.Point(4, 25)
        Me.AUITEM.Name = "AUITEM"
        Me.AUITEM.Padding = New System.Windows.Forms.Padding(3)
        Me.AUITEM.Size = New System.Drawing.Size(1345, 545)
        Me.AUITEM.TabIndex = 0
        Me.AUITEM.Text = "ITEM"
        Me.AUITEM.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(505, 51)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(430, 452)
        Me.ListBox1.TabIndex = 1
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(112, 51)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(371, 450)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AUITEM)
        Me.TabControl1.Controls.Add(Me.AUORDER)
        Me.TabControl1.Controls.Add(Me.AUTRANSACTIONRECORD)
        Me.TabControl1.Controls.Add(Me.AUDIT)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.audit4)
        Me.TabControl1.Location = New System.Drawing.Point(33, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1353, 574)
        Me.TabControl1.TabIndex = 3
        '
        'audit4
        '
        Me.audit4.Controls.Add(Me.DataGridView1)
        Me.audit4.Location = New System.Drawing.Point(4, 25)
        Me.audit4.Name = "audit4"
        Me.audit4.Padding = New System.Windows.Forms.Padding(3)
        Me.audit4.Size = New System.Drawing.Size(1345, 545)
        Me.audit4.TabIndex = 6
        Me.audit4.Text = "audit3"
        Me.audit4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(91, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1147, 416)
        Me.DataGridView1.TabIndex = 0
        '
        'Audit_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1394, 664)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Audit_Inventory"
        Me.Text = "Audit_Inventory"
        Me.TabPage2.ResumeLayout(False)
        Me.AUDIT.ResumeLayout(False)
        Me.AUTRANSACTIONRECORD.ResumeLayout(False)
        Me.AUTRANSACTIONRECORD.PerformLayout()
        Me.AUORDER.ResumeLayout(False)
        Me.AUITEM.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.audit4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ITEM As ColumnHeader
    Friend WithEvents SOLD As ColumnHeader
    Friend WithEvents AUDIT As TabPage
    Friend WithEvents AUTRANSACTIONRECORD As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AUORDER As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AUITEM As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListView2 As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ListView4 As ListView
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents audit4 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
End Class
