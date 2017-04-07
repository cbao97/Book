Imports System.Windows.Forms
Imports DTO.DTO
Imports System.Net.Mail
Imports DevExpress.XtraEditors
Public Class Feedback

#Region "1.Closing Form"
    Private Sub Feedback_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Dim FormMenu As New MenuGUI 'Tạo mới form MenuGUI
        Me.Hide() 'Ẩn form feedback
        FormMenu.Show() ' Hiện form Menu
    End Sub
#End Region

#Region "2.Gui"
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

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Text = "Cbao97@gmail.com"
        txtHoTen.Text = "Do Chi Bao"
        TxtNoiDung.Text = "okey"
        txtTieuDe.Text = "Hi"
    End Sub
#End Region

#Region "3.Xoa"
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        txtEmail.Clear() 'Làm trống ô Email 
        txtHoTen.Clear() 'Làm trống ô Họ tên
        TxtNoiDung.Clear() 'Làm trống ô Nội Dung
        txtTieuDe.Clear() 'Làm trống ô Tiêu đề
    End Sub

#End Region



End Class