<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.Location = New System.Drawing.Point(35, 34)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(40, 13)
        Me.lblmakh.TabIndex = 0
        Me.lblmakh.Text = "MaKH:"
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.Location = New System.Drawing.Point(35, 78)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(44, 13)
        Me.lbltenkh.TabIndex = 1
        Me.lbltenkh.Text = "TenKH:"
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Location = New System.Drawing.Point(35, 128)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(52, 13)
        Me.lblgioitinh.TabIndex = 2
        Me.lblgioitinh.Text = "Gioi Tinh:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(123, 34)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(206, 20)
        Me.txtmakh.TabIndex = 5
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(123, 75)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(206, 20)
        Me.txttenkh.TabIndex = 6
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(123, 125)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(206, 20)
        Me.txtgioitinh.TabIndex = 7
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(58, 289)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 10
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(296, 289)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 11
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(123, 219)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(206, 20)
        Me.txtsdt.TabIndex = 9
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Location = New System.Drawing.Point(35, 222)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(32, 13)
        Me.lblsdt.TabIndex = 4
        Me.lblsdt.Text = "SDT:"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(35, 176)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(44, 13)
        Me.lbldiachi.TabIndex = 3
        Me.lbldiachi.Text = "Dia Chi:"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(123, 169)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(206, 20)
        Me.txtdiachi.TabIndex = 8
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 353)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblgioitinh)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.lblmakh)
        Me.Name = "frmkhachhang"
        Me.Text = "khachhang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
End Class
