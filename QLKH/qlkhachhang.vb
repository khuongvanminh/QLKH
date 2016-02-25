Public Class frmqlkhachhang
    Private _DBAccess As New DataBaseAccess

    'khai bao bien kiem tra load
    Private _isLoading As Boolean = False
    Private Sub LoadKH()
        Dim sqlQuery As String = String.Format("Select MaKH,TenKH,GioiTinh,DiaChi,SDT From KhachHang")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvhienthi.DataSource = dTable
        With Me.dgvhienthi
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "GioiTinh"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(4).HeaderText = "SDT"
        End With
    End Sub
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = "Select * From KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvhienthi.DataSource = dTable
    End Sub
    Private Sub Search(MaKH As String, value As String)
        Dim sqlQuery As String = "Select * From KhachHang"
        If Me.cbotimkiem.SelectedIndex = 0 Then 'tim theo MaKH'
            sqlQuery += String.Format(" Where MaKH LiKE '{0}%'", value)
        ElseIf Me.cbotimkiem.SelectedIndex = 1 Then 'tim theo TenKH'
            sqlQuery += String.Format(" Where TenKH LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvhienthi.DataSource = dTable
    End Sub
    Private Sub qlkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True       'true khi du lieu bat dau load

        LoadDataOnGridView()
        frmkhachhang.Show()

        _isLoading = False      'false khi load xong
    End Sub

    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged
        Search(Me.cbotimkiem.SelectedValue, Me.txttimkiem.Text)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmkhachhang.Show()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim MaKH As String = Me.dgvhienthi.Rows(Me.dgvhienthi.CurrentCell.RowIndex).Cells("MaKH").Value

        Dim sqlQuery As String = String.Format("DELETE TenKH where MaKH = '{0}'", MaKH)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show(" da xoa du lieu thanh cong ")
            LoadDataOnGridView()
        Else
            MessageBox.Show(" loi xoa du lieu ", "Error", MessageBoxButtons.OKCancel)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New frmkhachhang(True)
        frm.txtmakh.ReadOnly = True
        With Me.dgvhienthi
            frm.txtmakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            frm.txttenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
            frm.txtgioitinh.Text = .Rows(.CurrentCell.RowIndex).Cells("GioiTinh").Value
            frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            frm.txtsdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView()
        End If

    End Sub
End Class
