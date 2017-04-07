Imports System.Windows.Forms
Imports DTO.DTO
Imports System.Net.Mail
Imports DevExpress.XtraEditors
Public Class Feedback

#Region "1. Closing Form"
    Private Sub Feedback_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Dim KetQua As DialogResult
        KetQua = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (KetQua = DialogResult.Yes) Then
            Dim FormMenu As New MenuGUI 'Tạo mới form MenuGUI
            Me.Hide() 'Ẩn form feedback
            FormMenu.Show() ' Hiện form Menu
        End If
    End Sub
#End Region

#Region "2. Gửi"
    Private Sub btnGui_Click(sender As Object, e As EventArgs) Handles btnGui.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("15520035@gm.uit.edu.vn", "Dochibao1997")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtEmail.Text)
            e_mail.To.Add("cbao97@gmail.com")
            e_mail.Subject = txtTieuDe.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = "Tên: " & txtHoTen.Text & vbCrLf & "Email :" & txtEmail.Text & vbCrLf & "Nội dung :" & TxtNoiDung.Text
            Smtp_Server.Send(e_mail)
            XtraMessageBox.Show("Phản hồi đã được gửi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch error_t As Exception
            XtraMessageBox.Show(error_t.ToString, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "3. Xóa"
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        txtEmail.Clear() 'Làm trống ô Email 
        txtHoTen.Clear() 'Làm trống ô Họ tên
        TxtNoiDung.Clear() 'Làm trống ô Nội Dung
        txtTieuDe.Clear() 'Làm trống ô Tiêu đề
    End Sub

#End Region

#Region "4. Load"
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tạo ví dụ
        txtEmail.Text = "ViDu@gmail.com"
        txtHoTen.Text = "Nguyen Van A"
        TxtNoiDung.Text = "Miêu tả chi tiết"
        txtTieuDe.Text = "Lỗi XYZ"
        'Làm chữ màu bạc 
        txtEmail.ForeColor = Color.Silver
        txtHoTen.ForeColor = Color.Silver
        TxtNoiDung.ForeColor = Color.Silver
        txtTieuDe.ForeColor = Color.Silver
    End Sub

#End Region

#Region "5. Click chuột vào textbox"
#Region "5.1 Họ tên"
    Private Sub txtHoTen_MouseClick(sender As Object, e As MouseEventArgs) Handles txtHoTen.MouseClick
        txtHoTen.Clear()
        txtHoTen.ForeColor = Color.Black
        txtHoTen.Focus()
    End Sub
#End Region

#Region "5.2 Email"
    Private Sub txtEmail_MouseClick(sender As Object, e As MouseEventArgs) Handles txtEmail.MouseClick
        txtEmail.Clear()
        txtEmail.ForeColor = Color.Black
        txtEmail.Focus()
    End Sub

#End Region

#Region "5.3 Tiêu đề"
    Private Sub txtTieuDe_MouseClick(sender As Object, e As MouseEventArgs) Handles txtTieuDe.MouseClick
        txtTieuDe.Clear()
        txtTieuDe.ForeColor = Color.Black
        txtTieuDe.Focus()
    End Sub
#End Region

#Region "5.4 Nội dung"
    Private Sub TxtNoiDung_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtNoiDung.MouseClick
        TxtNoiDung.Clear()
        TxtNoiDung.ForeColor = Color.Black
        TxtNoiDung.Focus()
    End Sub


#End Region

#End Region

#Region "6.Phím tắt"
    Private Sub Feedback_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Alt = True And e.KeyCode = Keys.F4) Then
            Dim KetQua As DialogResult
            KetQua = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (KetQua = DialogResult.Yes) Then
                Me.Close()
            End If
        End If
    End Sub
#End Region
End Class