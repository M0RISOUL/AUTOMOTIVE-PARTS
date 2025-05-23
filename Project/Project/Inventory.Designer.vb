<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Stock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lsvItems = New System.Windows.Forms.ListView()
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtAPStock = New System.Windows.Forms.TextBox()
        Me.txtAPName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAPStock = New System.Windows.Forms.Label()
        Me.lblAPName = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stock
        '
        Me.Stock.Text = "Automotive Parts"
        Me.Stock.Width = 168
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(101, 409)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 231)
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Price"
        Me.ColumnHeader1.Width = 101
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(908, 545)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 29)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lsvItems
        '
        Me.lsvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Stock, Me.Price, Me.ColumnHeader1})
        Me.lsvItems.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvItems.FullRowSelect = True
        Me.lsvItems.GridLines = True
        Me.lsvItems.HideSelection = False
        Me.lsvItems.Location = New System.Drawing.Point(745, 95)
        Me.lsvItems.Name = "lsvItems"
        Me.lsvItems.Size = New System.Drawing.Size(467, 409)
        Me.lsvItems.TabIndex = 47
        Me.lsvItems.UseCompatibleStateImageBehavior = False
        Me.lsvItems.View = System.Windows.Forms.View.Details
        '
        'Price
        '
        Me.Price.Text = "Stock"
        Me.Price.Width = 87
        '
        'lstItems
        '
        Me.lstItems.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 27
        Me.lstItems.Items.AddRange(New Object() {"Automotive Parts", "Fuel Tank", "Starter", "Condenser", "Radiator Tank", "Coil", "Auxiliary Fan", "Timing Belt", "Alternator", "Transmission", "Fly Wheel", "Ball Joint", "Clutch Plate", "Propeller Shaft", "Release Bearing", "Computer Box"})
        Me.lstItems.Location = New System.Drawing.Point(564, 95)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(175, 409)
        Me.lstItems.TabIndex = 46
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Cyan
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(380, 34)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(576, 49)
        Me.lblHeader.TabIndex = 45
        Me.lblHeader.Text = "AUTOMOTIVE PARTS INVENTORY"
        '
        'txtAPStock
        '
        Me.txtAPStock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPStock.Location = New System.Drawing.Point(351, 262)
        Me.txtAPStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAPStock.Name = "txtAPStock"
        Me.txtAPStock.Size = New System.Drawing.Size(132, 27)
        Me.txtAPStock.TabIndex = 43
        '
        'txtAPName
        '
        Me.txtAPName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPName.Location = New System.Drawing.Point(351, 155)
        Me.txtAPName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAPName.Name = "txtAPName"
        Me.txtAPName.Size = New System.Drawing.Size(132, 27)
        Me.txtAPName.TabIndex = 42
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1056, 545)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 29)
        Me.btnClose.TabIndex = 41
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(745, 545)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(117, 29)
        Me.btnRemove.TabIndex = 40
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.Location = New System.Drawing.Point(587, 545)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(117, 29)
        Me.btnADD.TabIndex = 39
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(63, 380)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 20)
        Me.lblPrice.TabIndex = 38
        Me.lblPrice.Text = "PRICE:"
        '
        'lblAPStock
        '
        Me.lblAPStock.AutoSize = True
        Me.lblAPStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPStock.Location = New System.Drawing.Point(63, 269)
        Me.lblAPStock.Name = "lblAPStock"
        Me.lblAPStock.Size = New System.Drawing.Size(259, 20)
        Me.lblAPStock.TabIndex = 37
        Me.lblAPStock.Text = "AUTOMOTIVE PARTS STOCK :"
        '
        'lblAPName
        '
        Me.lblAPName.AutoSize = True
        Me.lblAPName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPName.Location = New System.Drawing.Point(63, 162)
        Me.lblAPName.Name = "lblAPName"
        Me.lblAPName.Size = New System.Drawing.Size(248, 20)
        Me.lblAPName.TabIndex = 36
        Me.lblAPName.Text = "AUTOMOTIVE PARTS NAME :"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(351, 373)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 27)
        Me.txtPrice.TabIndex = 44
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1275, 731)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lsvItems)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.txtAPStock)
        Me.Controls.Add(Me.txtAPName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblAPStock)
        Me.Controls.Add(Me.lblAPName)
        Me.Controls.Add(Me.txtPrice)
        Me.Name = "frmInventory"
        Me.Text = "Inventory"
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Stock As ColumnHeader
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnSave As Button
    Friend WithEvents lsvItems As ListView
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents lstItems As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtAPStock As TextBox
    Friend WithEvents txtAPName As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAPStock As Label
    Friend WithEvents lblAPName As Label
    Friend WithEvents txtPrice As TextBox
End Class
