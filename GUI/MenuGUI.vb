Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors

Partial Public Class MenuGUI
    Inherits DevExpress.XtraEditors.XtraForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

#Region "1.Thoat"
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim KetQua As DialogResult 'Lưu kết quả của messeagebox 
        KetQua = XtraMessageBox.Show("Bạn có muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If (KetQua = DialogResult.Yes) Then 'Nếu Yes thì thoát 
            Me.Close()
        End If
    End Sub
#End Region

#Region "2.Phản hồi"
    Private Sub btnPhanHoi_Click(sender As Object, e As EventArgs) Handles btnPhanHoi.Click
        Me.Hide() 'Ẩn Form Menu
        Dim FormFeedback As New Feedback 'Tạo mới FormFeedback 
        FormFeedback.Show() 'Hiện form feedback

    End Sub
#End Region

End Class
