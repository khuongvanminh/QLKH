Public Class frmkhachhang
    Private _DBAccess As New DataBaseAccess

    Private _IsEdit As Boolean = False
    Public Sub New(Optional IsEdit As Boolean)
        InitializeComponent()
        _IsEdit = IsEdit
    End Sub
    Private Function InsertKhachHang() As Boolean
        Dim sqlQuery As String = "Insert into KhachHang (MaKH, TenKH, GioiTinh, DiaChi, SDT)"
        sqlQuery += String.Format("values('{0}','{1}','{2}','{3}','{4}')", txtmakh.Text, txttenkh.Text, txtgioitinh.Text, txtdiachi.Text, txtsdt.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateKhachHang() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE KhachHang SET TenKH = '{0}', GioiTinh = '{1}', DiaChi = '{2}', WHERE MaKH = '{3}'",
                                               Me.txttenkh.Text, Me.txtgioitinh.Text, Me.txtdiachi.Text, txtmakh.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) OrElse String.IsNullOrEmpty(txtgioitinh.Text) OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse String.IsNullOrEmpty(txtsdt.Text)
    End Function


    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If IsEmpty() Then
            MessageBox.Show(" hay nhap gia tri ", "Error", MessageBoxButtons.OKCancel)
        Else

            If InsertKhachHang() Then
                MessageBox.Show("du lieu da duoc them", "Infomation", MessageBoxButtons.OKCancel)
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                MessageBox.Show("loi them du lieu", "Error", MessageBoxButtons.OKCancel)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Me.Close()
        End If
    End Sub


End Class