<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Feedback))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.lblHoTen = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TxtNoiDung = New System.Windows.Forms.RichTextBox()
        Me.lblNoiDung = New System.Windows.Forms.Label()
        Me.btnGui = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtTieuDe = New System.Windows.Forms.TextBox()
        Me.lblTieuDe = New System.Windows.Forms.Label()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationIcon = CType(resources.GetObject("RibbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(701, 54)
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.Location = New System.Drawing.Point(60, 112)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(39, 13)
        Me.lblHoTen.TabIndex = 1
        Me.lblHoTen.Text = "Họ tên"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(147, 109)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(202, 21)
        Me.txtHoTen.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(147, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 21)
        Me.txtEmail.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(60, 139)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(31, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'TxtNoiDung
        '
        Me.TxtNoiDung.Location = New System.Drawing.Point(147, 192)
        Me.TxtNoiDung.Name = "TxtNoiDung"
        Me.TxtNoiDung.Size = New System.Drawing.Size(452, 168)
        Me.TxtNoiDung.TabIndex = 5
        Me.TxtNoiDung.Text = ""
        '
        'lblNoiDung
        '
        Me.lblNoiDung.AutoSize = True
        Me.lblNoiDung.Location = New System.Drawing.Point(60, 195)
        Me.lblNoiDung.Name = "lblNoiDung"
        Me.lblNoiDung.Size = New System.Drawing.Size(50, 13)
        Me.lblNoiDung.TabIndex = 6
        Me.lblNoiDung.Text = "Nội Dung"
        '
        'btnGui
        '
        Me.btnGui.Location = New System.Drawing.Point(147, 381)
        Me.btnGui.Name = "btnGui"
        Me.btnGui.Size = New System.Drawing.Size(75, 23)
        Me.btnGui.TabIndex = 7
        Me.btnGui.Text = "Gửi"
        Me.btnGui.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(274, 381)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtTieuDe
        '
        Me.txtTieuDe.Location = New System.Drawing.Point(147, 165)
        Me.txtTieuDe.Name = "txtTieuDe"
        Me.txtTieuDe.Size = New System.Drawing.Size(202, 21)
        Me.txtTieuDe.TabIndex = 11
        '
        'lblTieuDe
        '
        Me.lblTieuDe.AutoSize = True
        Me.lblTieuDe.Location = New System.Drawing.Point(60, 168)
        Me.lblTieuDe.Name = "lblTieuDe"
        Me.lblTieuDe.Size = New System.Drawing.Size(42, 13)
        Me.lblTieuDe.TabIndex = 10
        Me.lblTieuDe.Text = "Tiêu đề"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 444)
        Me.Controls.Add(Me.txtTieuDe)
        Me.Controls.Add(Me.lblTieuDe)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnGui)
        Me.Controls.Add(Me.lblNoiDung)
        Me.Controls.Add(Me.TxtNoiDung)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Feedback"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feedback"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents lblHoTen As Label
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents TxtNoiDung As RichTextBox
    Friend WithEvents lblNoiDung As Label
    Friend WithEvents btnGui As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtTieuDe As TextBox
    Friend WithEvents lblTieuDe As Label
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
