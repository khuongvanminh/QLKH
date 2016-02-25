<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmqlkhachhang
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvhienthi = New System.Windows.Forms.DataGridView()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.cbotimkiem = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.dgvhienthi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(40, 30)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search"
        '
        'dgvhienthi
        '
        Me.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhienthi.Location = New System.Drawing.Point(13, 72)
        Me.dgvhienthi.Name = "dgvhienthi"
        Me.dgvhienthi.Size = New System.Drawing.Size(583, 255)
        Me.dgvhienthi.TabIndex = 1
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(247, 26)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(256, 20)
        Me.txttimkiem.TabIndex = 2
        '
        'cbotimkiem
        '
        Me.cbotimkiem.FormattingEnabled = True
        Me.cbotimkiem.Items.AddRange(New Object() {"MaKH", "TenKH"})
        Me.cbotimkiem.Location = New System.Drawing.Point(97, 27)
        Me.cbotimkiem.Name = "cbotimkiem"
        Me.cbotimkiem.Size = New System.Drawing.Size(121, 21)
        Me.cbotimkiem.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(521, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(624, 128)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(108, 23)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(624, 178)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(108, 23)
        Me.btnedit.TabIndex = 6
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(624, 228)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(108, 23)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmqlkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 390)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbotimkiem)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.dgvhienthi)
        Me.Controls.Add(Me.lblSearch)
        Me.Name = "frmqlkhachhang"
        Me.Text = "Quan Ly KhachHang"
        CType(Me.dgvhienthi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents dgvhienthi As System.Windows.Forms.DataGridView
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents cbotimkiem As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button

End Class
