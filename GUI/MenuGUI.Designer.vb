Partial Public Class MenuGUI
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGUI))
        Me.lblQuanLy = New System.Windows.Forms.Label()
        Me.lblNhapSach = New System.Windows.Forms.Label()
        Me.lblBanSach = New System.Windows.Forms.Label()
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.lblThuTien = New System.Windows.Forms.Label()
        Me.lblBaoCao = New System.Windows.Forms.Label()
        Me.lblPhanHoi = New System.Windows.Forms.Label()
        Me.lblThoat = New System.Windows.Forms.Label()
        Me.lblQuyDinh = New System.Windows.Forms.Label()
        Me.btnThayDoiQuiDinh = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnPhanHoi = New System.Windows.Forms.Button()
        Me.btnBaoCao = New System.Windows.Forms.Button()
        Me.btnThuTien = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnBanSach = New System.Windows.Forms.Button()
        Me.btnNhapSach = New System.Windows.Forms.Button()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.SuspendLayout()
        '
        'lblQuanLy
        '
        Me.lblQuanLy.AutoSize = True
        Me.lblQuanLy.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuanLy.Location = New System.Drawing.Point(287, 27)
        Me.lblQuanLy.Name = "lblQuanLy"
        Me.lblQuanLy.Size = New System.Drawing.Size(297, 46)
        Me.lblQuanLy.TabIndex = 0
        Me.lblQuanLy.Text = "Quản lý nhà sách"
        '
        'lblNhapSach
        '
        Me.lblNhapSach.AutoSize = True
        Me.lblNhapSach.Location = New System.Drawing.Point(39, 252)
        Me.lblNhapSach.Name = "lblNhapSach"
        Me.lblNhapSach.Size = New System.Drawing.Size(57, 13)
        Me.lblNhapSach.TabIndex = 2
        Me.lblNhapSach.Text = "Nhập sách"
        '
        'lblBanSach
        '
        Me.lblBanSach.AutoSize = True
        Me.lblBanSach.Location = New System.Drawing.Point(221, 252)
        Me.lblBanSach.Name = "lblBanSach"
        Me.lblBanSach.Size = New System.Drawing.Size(50, 13)
        Me.lblBanSach.TabIndex = 4
        Me.lblBanSach.Text = "Bán sách"
        '
        'lblTimKiem
        '
        Me.lblTimKiem.AutoSize = True
        Me.lblTimKiem.Location = New System.Drawing.Point(610, 252)
        Me.lblTimKiem.Name = "lblTimKiem"
        Me.lblTimKiem.Size = New System.Drawing.Size(48, 13)
        Me.lblTimKiem.TabIndex = 6
        Me.lblTimKiem.Text = "Tìm Kiếm"
        '
        'lblThuTien
        '
        Me.lblThuTien.AutoSize = True
        Me.lblThuTien.Location = New System.Drawing.Point(413, 252)
        Me.lblThuTien.Name = "lblThuTien"
        Me.lblThuTien.Size = New System.Drawing.Size(46, 13)
        Me.lblThuTien.TabIndex = 8
        Me.lblThuTien.Text = "Thu tiền"
        '
        'lblBaoCao
        '
        Me.lblBaoCao.AutoSize = True
        Me.lblBaoCao.Location = New System.Drawing.Point(39, 432)
        Me.lblBaoCao.Name = "lblBaoCao"
        Me.lblBaoCao.Size = New System.Drawing.Size(45, 13)
        Me.lblBaoCao.TabIndex = 10
        Me.lblBaoCao.Text = "Báo cáo"
        '
        'lblPhanHoi
        '
        Me.lblPhanHoi.AutoSize = True
        Me.lblPhanHoi.Location = New System.Drawing.Point(413, 432)
        Me.lblPhanHoi.Name = "lblPhanHoi"
        Me.lblPhanHoi.Size = New System.Drawing.Size(48, 13)
        Me.lblPhanHoi.TabIndex = 12
        Me.lblPhanHoi.Text = "Phản hồi"
        '
        'lblThoat
        '
        Me.lblThoat.AutoSize = True
        Me.lblThoat.Location = New System.Drawing.Point(613, 432)
        Me.lblThoat.Name = "lblThoat"
        Me.lblThoat.Size = New System.Drawing.Size(35, 13)
        Me.lblThoat.TabIndex = 14
        Me.lblThoat.Text = "Thoát"
        '
        'lblQuyDinh
        '
        Me.lblQuyDinh.AutoSize = True
        Me.lblQuyDinh.Location = New System.Drawing.Point(223, 432)
        Me.lblQuyDinh.Name = "lblQuyDinh"
        Me.lblQuyDinh.Size = New System.Drawing.Size(94, 13)
        Me.lblQuyDinh.TabIndex = 16
        Me.lblQuyDinh.Text = "Thay Đổi Qui Định"
        '
        'btnThayDoiQuiDinh
        '
        Me.btnThayDoiQuiDinh.Image = CType(resources.GetObject("btnThayDoiQuiDinh.Image"), System.Drawing.Image)
        Me.btnThayDoiQuiDinh.Location = New System.Drawing.Point(224, 279)
        Me.btnThayDoiQuiDinh.Name = "btnThayDoiQuiDinh"
        Me.btnThayDoiQuiDinh.Size = New System.Drawing.Size(150, 150)
        Me.btnThayDoiQuiDinh.TabIndex = 15
        Me.btnThayDoiQuiDinh.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(613, 279)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(150, 150)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnPhanHoi
        '
        Me.btnPhanHoi.ForeColor = System.Drawing.Color.White
        Me.btnPhanHoi.Image = CType(resources.GetObject("btnPhanHoi.Image"), System.Drawing.Image)
        Me.btnPhanHoi.Location = New System.Drawing.Point(416, 279)
        Me.btnPhanHoi.Name = "btnPhanHoi"
        Me.btnPhanHoi.Size = New System.Drawing.Size(150, 150)
        Me.btnPhanHoi.TabIndex = 11
        Me.btnPhanHoi.UseVisualStyleBackColor = True
        '
        'btnBaoCao
        '
        Me.btnBaoCao.Image = CType(resources.GetObject("btnBaoCao.Image"), System.Drawing.Image)
        Me.btnBaoCao.Location = New System.Drawing.Point(42, 279)
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.Size = New System.Drawing.Size(150, 150)
        Me.btnBaoCao.TabIndex = 9
        Me.btnBaoCao.UseVisualStyleBackColor = True
        '
        'btnThuTien
        '
        Me.btnThuTien.Image = CType(resources.GetObject("btnThuTien.Image"), System.Drawing.Image)
        Me.btnThuTien.Location = New System.Drawing.Point(416, 99)
        Me.btnThuTien.Name = "btnThuTien"
        Me.btnThuTien.Size = New System.Drawing.Size(150, 150)
        Me.btnThuTien.TabIndex = 7
        Me.btnThuTien.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Image = CType(resources.GetObject("btnTimKiem.Image"), System.Drawing.Image)
        Me.btnTimKiem.Location = New System.Drawing.Point(613, 99)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(150, 150)
        Me.btnTimKiem.TabIndex = 5
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnBanSach
        '
        Me.btnBanSach.Image = CType(resources.GetObject("btnBanSach.Image"), System.Drawing.Image)
        Me.btnBanSach.Location = New System.Drawing.Point(224, 99)
        Me.btnBanSach.Name = "btnBanSach"
        Me.btnBanSach.Size = New System.Drawing.Size(150, 150)
        Me.btnBanSach.TabIndex = 3
        Me.btnBanSach.UseVisualStyleBackColor = True
        '
        'btnNhapSach
        '
        Me.btnNhapSach.Image = CType(resources.GetObject("btnNhapSach.Image"), System.Drawing.Image)
        Me.btnNhapSach.Location = New System.Drawing.Point(42, 99)
        Me.btnNhapSach.Name = "btnNhapSach"
        Me.btnNhapSach.Size = New System.Drawing.Size(150, 150)
        Me.btnNhapSach.TabIndex = 1
        Me.btnNhapSach.UseVisualStyleBackColor = True
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'MenuGUI
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Appearance.ForeColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblQuyDinh)
        Me.Controls.Add(Me.btnThayDoiQuiDinh)
        Me.Controls.Add(Me.lblThoat)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.lblPhanHoi)
        Me.Controls.Add(Me.btnPhanHoi)
        Me.Controls.Add(Me.lblBaoCao)
        Me.Controls.Add(Me.btnBaoCao)
        Me.Controls.Add(Me.lblThuTien)
        Me.Controls.Add(Me.btnThuTien)
        Me.Controls.Add(Me.lblTimKiem)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.lblBanSach)
        Me.Controls.Add(Me.btnBanSach)
        Me.Controls.Add(Me.lblNhapSach)
        Me.Controls.Add(Me.btnNhapSach)
        Me.Controls.Add(Me.lblQuanLy)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuanLy As Label
    Friend WithEvents btnNhapSach As Button
    Friend WithEvents lblNhapSach As Label
    Friend WithEvents btnBanSach As Button
    Friend WithEvents lblBanSach As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents lblTimKiem As Label
    Friend WithEvents btnThuTien As Button
    Friend WithEvents lblThuTien As Label
    Friend WithEvents btnBaoCao As Button
    Friend WithEvents lblBaoCao As Label
    Friend WithEvents btnPhanHoi As Button
    Friend WithEvents lblPhanHoi As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents lblThoat As Label
    Friend WithEvents btnThayDoiQuiDinh As Button
    Friend WithEvents lblQuyDinh As Label
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

#End Region

End Class
