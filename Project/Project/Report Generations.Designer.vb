<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportGenerations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportGenerations))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BUYERS = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLEINITIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyerListBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Automotive_PartsDataSet6 = New Project.Automotive_PartsDataSet6()
        Me.INVETORY = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lsvItems = New System.Windows.Forms.ListView()
        Me.Stock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAPStock = New System.Windows.Forms.TextBox()
        Me.txtAPName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAPStock = New System.Windows.Forms.Label()
        Me.lblAPName = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.frmSALES = New System.Windows.Forms.TabPage()
        Me.AUDIT = New System.Windows.Forms.TabPage()
        Me.BuyerListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Automotive_PartsDataSet5 = New Project.Automotive_PartsDataSet5()
        Me.BuyerListTableAdapter = New Project.Automotive_PartsDataSet4TableAdapters.BuyerListTableAdapter()
        Me.BuyerListTableAdapter1 = New Project.Automotive_PartsDataSet5TableAdapters.BuyerListTableAdapter()
        Me.BuyerListTableAdapter2 = New Project.Automotive_PartsDataSet6TableAdapters.BuyerListTableAdapter()
        Me.BuyerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.BUYERS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerListBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Automotive_PartsDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.INVETORY.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Automotive_PartsDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BUYERS)
        Me.TabControl1.Controls.Add(Me.INVETORY)
        Me.TabControl1.Controls.Add(Me.frmSALES)
        Me.TabControl1.Controls.Add(Me.AUDIT)
        Me.TabControl1.Location = New System.Drawing.Point(38, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1353, 567)
        Me.TabControl1.TabIndex = 1
        '
        'BUYERS
        '
        Me.BUYERS.Controls.Add(Me.DataGridView1)
        Me.BUYERS.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUYERS.Location = New System.Drawing.Point(4, 25)
        Me.BUYERS.Name = "BUYERS"
        Me.BUYERS.Padding = New System.Windows.Forms.Padding(3)
        Me.BUYERS.Size = New System.Drawing.Size(1345, 538)
        Me.BUYERS.TabIndex = 0
        Me.BUYERS.Text = "LIST OF BUYERS"
        Me.BUYERS.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLEINITIALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BuyerListBindingSource2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1339, 532)
        Me.DataGridView1.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'SURNAMEDataGridViewTextBoxColumn
        '
        Me.SURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SURNAMEDataGridViewTextBoxColumn.Name = "SURNAMEDataGridViewTextBoxColumn"
        Me.SURNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Width = 125
        '
        'MIDDLEINITIALDataGridViewTextBoxColumn
        '
        Me.MIDDLEINITIALDataGridViewTextBoxColumn.DataPropertyName = "MIDDLEINITIAL"
        Me.MIDDLEINITIALDataGridViewTextBoxColumn.HeaderText = "MIDDLEINITIAL"
        Me.MIDDLEINITIALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MIDDLEINITIALDataGridViewTextBoxColumn.Name = "MIDDLEINITIALDataGridViewTextBoxColumn"
        Me.MIDDLEINITIALDataGridViewTextBoxColumn.Width = 125
        '
        'BuyerListBindingSource2
        '
        Me.BuyerListBindingSource2.DataMember = "BuyerList"
        Me.BuyerListBindingSource2.DataSource = Me.Automotive_PartsDataSet6
        '
        'Automotive_PartsDataSet6
        '
        Me.Automotive_PartsDataSet6.DataSetName = "Automotive_PartsDataSet6"
        Me.Automotive_PartsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVETORY
        '
        Me.INVETORY.Controls.Add(Me.btnSave)
        Me.INVETORY.Controls.Add(Me.lsvItems)
        Me.INVETORY.Controls.Add(Me.lstItems)
        Me.INVETORY.Controls.Add(Me.btnClose)
        Me.INVETORY.Controls.Add(Me.btnRemove)
        Me.INVETORY.Controls.Add(Me.btnADD)
        Me.INVETORY.Controls.Add(Me.PictureBox1)
        Me.INVETORY.Controls.Add(Me.txtAPStock)
        Me.INVETORY.Controls.Add(Me.txtAPName)
        Me.INVETORY.Controls.Add(Me.lblPrice)
        Me.INVETORY.Controls.Add(Me.lblAPStock)
        Me.INVETORY.Controls.Add(Me.lblAPName)
        Me.INVETORY.Controls.Add(Me.txtPrice)
        Me.INVETORY.Location = New System.Drawing.Point(4, 25)
        Me.INVETORY.Name = "INVETORY"
        Me.INVETORY.Padding = New System.Windows.Forms.Padding(3)
        Me.INVETORY.Size = New System.Drawing.Size(1345, 538)
        Me.INVETORY.TabIndex = 3
        Me.INVETORY.Text = "INVENTORY REPORT"
        Me.INVETORY.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(932, 475)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 29)
        Me.btnSave.TabIndex = 62
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
        Me.lsvItems.Location = New System.Drawing.Point(769, 25)
        Me.lsvItems.Name = "lsvItems"
        Me.lsvItems.Size = New System.Drawing.Size(467, 409)
        Me.lsvItems.TabIndex = 61
        Me.lsvItems.UseCompatibleStateImageBehavior = False
        Me.lsvItems.View = System.Windows.Forms.View.Details
        '
        'Stock
        '
        Me.Stock.Text = "Automotive Parts"
        Me.Stock.Width = 168
        '
        'Price
        '
        Me.Price.Text = "Stock"
        Me.Price.Width = 87
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Price"
        Me.ColumnHeader1.Width = 101
        '
        'lstItems
        '
        Me.lstItems.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 27
        Me.lstItems.Items.AddRange(New Object() {"Automotive Parts", "Fuel Tank", "Starter", "Condenser", "Radiator Tank", "Coil", "Auxiliary Fan", "Timing Belt", "Alternator", "Transmission", "Fly Wheel", "Ball Joint", "Clutch Plate", "Propeller Shaft", "Release Bearing", "Computer Box"})
        Me.lstItems.Location = New System.Drawing.Point(588, 25)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(175, 409)
        Me.lstItems.TabIndex = 60
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1080, 475)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(117, 29)
        Me.btnClose.TabIndex = 59
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(769, 475)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(117, 29)
        Me.btnRemove.TabIndex = 58
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.Location = New System.Drawing.Point(611, 475)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(117, 29)
        Me.btnADD.TabIndex = 57
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 231)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'txtAPStock
        '
        Me.txtAPStock.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPStock.Location = New System.Drawing.Point(312, 132)
        Me.txtAPStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAPStock.Name = "txtAPStock"
        Me.txtAPStock.Size = New System.Drawing.Size(132, 27)
        Me.txtAPStock.TabIndex = 54
        '
        'txtAPName
        '
        Me.txtAPName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPName.Location = New System.Drawing.Point(312, 25)
        Me.txtAPName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAPName.Name = "txtAPName"
        Me.txtAPName.Size = New System.Drawing.Size(132, 27)
        Me.txtAPName.TabIndex = 53
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(24, 250)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(66, 20)
        Me.lblPrice.TabIndex = 52
        Me.lblPrice.Text = "PRICE:"
        '
        'lblAPStock
        '
        Me.lblAPStock.AutoSize = True
        Me.lblAPStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPStock.Location = New System.Drawing.Point(24, 139)
        Me.lblAPStock.Name = "lblAPStock"
        Me.lblAPStock.Size = New System.Drawing.Size(259, 20)
        Me.lblAPStock.TabIndex = 51
        Me.lblAPStock.Text = "AUTOMOTIVE PARTS STOCK :"
        '
        'lblAPName
        '
        Me.lblAPName.AutoSize = True
        Me.lblAPName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPName.Location = New System.Drawing.Point(24, 32)
        Me.lblAPName.Name = "lblAPName"
        Me.lblAPName.Size = New System.Drawing.Size(248, 20)
        Me.lblAPName.TabIndex = 50
        Me.lblAPName.Text = "AUTOMOTIVE PARTS NAME :"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(312, 243)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 27)
        Me.txtPrice.TabIndex = 55
        '
        'frmSALES
        '
        Me.frmSALES.Location = New System.Drawing.Point(4, 25)
        Me.frmSALES.Name = "frmSALES"
        Me.frmSALES.Padding = New System.Windows.Forms.Padding(3)
        Me.frmSALES.Size = New System.Drawing.Size(1345, 538)
        Me.frmSALES.TabIndex = 2
        Me.frmSALES.Text = "SALES REPORT"
        Me.frmSALES.UseVisualStyleBackColor = True
        '
        'AUDIT
        '
        Me.AUDIT.Location = New System.Drawing.Point(4, 25)
        Me.AUDIT.Name = "AUDIT"
        Me.AUDIT.Padding = New System.Windows.Forms.Padding(3)
        Me.AUDIT.Size = New System.Drawing.Size(1345, 538)
        Me.AUDIT.TabIndex = 4
        Me.AUDIT.Text = "AUDIT TRAIL"
        Me.AUDIT.UseVisualStyleBackColor = True
        '
        'BuyerListBindingSource1
        '
        Me.BuyerListBindingSource1.DataMember = "BuyerList"
        Me.BuyerListBindingSource1.DataSource = Me.Automotive_PartsDataSet5
        '
        'Automotive_PartsDataSet5
        '
        Me.Automotive_PartsDataSet5.DataSetName = "Automotive_PartsDataSet5"
        Me.Automotive_PartsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerListTableAdapter
        '
        Me.BuyerListTableAdapter.ClearBeforeFill = True
        '
        'BuyerListTableAdapter1
        '
        Me.BuyerListTableAdapter1.ClearBeforeFill = True
        '
        'BuyerListTableAdapter2
        '
        Me.BuyerListTableAdapter2.ClearBeforeFill = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(1219, 15)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(168, 66)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmReportGenerations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1403, 693)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmReportGenerations"
        Me.Text = "Report Generations"
        Me.TabControl1.ResumeLayout(False)
        Me.BUYERS.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerListBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Automotive_PartsDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.INVETORY.ResumeLayout(False)
        Me.INVETORY.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Automotive_PartsDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BUYERS As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents frmSALES As TabPage
    Friend WithEvents BuyerListBindingSource As BindingSource
    Friend WithEvents BuyerListTableAdapter As Automotive_PartsDataSet4TableAdapters.BuyerListTableAdapter
    Friend WithEvents Automotive_PartsDataSet5 As Automotive_PartsDataSet5
    Friend WithEvents BuyerListBindingSource1 As BindingSource
    Friend WithEvents BuyerListTableAdapter1 As Automotive_PartsDataSet5TableAdapters.BuyerListTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLEINITIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Automotive_PartsDataSet6 As Automotive_PartsDataSet6
    Friend WithEvents BuyerListBindingSource2 As BindingSource
    Friend WithEvents BuyerListTableAdapter2 As Automotive_PartsDataSet6TableAdapters.BuyerListTableAdapter
    Friend WithEvents INVETORY As TabPage
    Friend WithEvents AUDIT As TabPage
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAPStock As TextBox
    Friend WithEvents txtAPName As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAPStock As Label
    Friend WithEvents lblAPName As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lsvItems As ListView
    Friend WithEvents Stock As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lstItems As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnADD As Button
End Class
