<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancellation
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RailwayDataSet = New RailwayReservationSystem.railwayDataSet()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter = New RailwayReservationSystem.railwayDataSetTableAdapters.reservationTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EplaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DojDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Not1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RailwayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(185, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Customer Complaints"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(265, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 24)
        Me.TextBox1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "PNR No."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(265, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RailwayReservationSystem.My.Resources.Resources.kashipara
        Me.PictureBox1.Location = New System.Drawing.Point(524, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.SplaceDataGridViewTextBoxColumn, Me.EplaceDataGridViewTextBoxColumn, Me.TnoDataGridViewTextBoxColumn, Me.TnameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.DojDataGridViewTextBoxColumn, Me.Not1DataGridViewTextBoxColumn, Me.TpriceDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.AddrDataGridViewTextBoxColumn, Me.MobDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(633, 282)
        Me.DataGridView1.TabIndex = 27
        '
        'RailwayDataSet
        '
        Me.RailwayDataSet.DataSetName = "railwayDataSet"
        Me.RailwayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "reservation"
        Me.ReservationBindingSource.DataSource = Me.RailwayDataSet
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SplaceDataGridViewTextBoxColumn
        '
        Me.SplaceDataGridViewTextBoxColumn.DataPropertyName = "s_place"
        Me.SplaceDataGridViewTextBoxColumn.HeaderText = "s_place"
        Me.SplaceDataGridViewTextBoxColumn.Name = "SplaceDataGridViewTextBoxColumn"
        '
        'EplaceDataGridViewTextBoxColumn
        '
        Me.EplaceDataGridViewTextBoxColumn.DataPropertyName = "e_place"
        Me.EplaceDataGridViewTextBoxColumn.HeaderText = "e_place"
        Me.EplaceDataGridViewTextBoxColumn.Name = "EplaceDataGridViewTextBoxColumn"
        '
        'TnoDataGridViewTextBoxColumn
        '
        Me.TnoDataGridViewTextBoxColumn.DataPropertyName = "t_no"
        Me.TnoDataGridViewTextBoxColumn.HeaderText = "t_no"
        Me.TnoDataGridViewTextBoxColumn.Name = "TnoDataGridViewTextBoxColumn"
        '
        'TnameDataGridViewTextBoxColumn
        '
        Me.TnameDataGridViewTextBoxColumn.DataPropertyName = "t_name"
        Me.TnameDataGridViewTextBoxColumn.HeaderText = "t_name"
        Me.TnameDataGridViewTextBoxColumn.Name = "TnameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'DojDataGridViewTextBoxColumn
        '
        Me.DojDataGridViewTextBoxColumn.DataPropertyName = "doj"
        Me.DojDataGridViewTextBoxColumn.HeaderText = "doj"
        Me.DojDataGridViewTextBoxColumn.Name = "DojDataGridViewTextBoxColumn"
        '
        'Not1DataGridViewTextBoxColumn
        '
        Me.Not1DataGridViewTextBoxColumn.DataPropertyName = "not1"
        Me.Not1DataGridViewTextBoxColumn.HeaderText = "not1"
        Me.Not1DataGridViewTextBoxColumn.Name = "Not1DataGridViewTextBoxColumn"
        '
        'TpriceDataGridViewTextBoxColumn
        '
        Me.TpriceDataGridViewTextBoxColumn.DataPropertyName = "t_price"
        Me.TpriceDataGridViewTextBoxColumn.HeaderText = "t_price"
        Me.TpriceDataGridViewTextBoxColumn.Name = "TpriceDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "c_name"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "c_name"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'AddrDataGridViewTextBoxColumn
        '
        Me.AddrDataGridViewTextBoxColumn.DataPropertyName = "addr"
        Me.AddrDataGridViewTextBoxColumn.HeaderText = "addr"
        Me.AddrDataGridViewTextBoxColumn.Name = "AddrDataGridViewTextBoxColumn"
        '
        'MobDataGridViewTextBoxColumn
        '
        Me.MobDataGridViewTextBoxColumn.DataPropertyName = "mob"
        Me.MobDataGridViewTextBoxColumn.HeaderText = "mob"
        Me.MobDataGridViewTextBoxColumn.Name = "MobDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'Cancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 476)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cancellation"
        Me.Text = "Cancellation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RailwayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RailwayDataSet As railwayDataSet
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As railwayDataSetTableAdapters.reservationTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SplaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EplaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DojDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Not1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
