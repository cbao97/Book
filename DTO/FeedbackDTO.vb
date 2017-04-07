Namespace DTO
    Public Class FeedbackDTO
#Region "1.Khai Báo"
        Private strHoTen As String
        Private strEmail As String
        Private strNoiDung As String
#End Region

#Region "2.Ho ten"
        Property Hoten() As String
            Get
                Return strHoTen
            End Get
            Set(value As String)
                strHoTen = value
            End Set
        End Property
#End Region

#Region "3.Email"
        Property Email() As String
            Get
                Return strEmail
            End Get
            Set(value As String)
                strEmail = value
            End Set
        End Property
#End Region

#Region "4.Noi Dung "
        Property NoiDung() As String
            Get
                Return strNoiDung
            End Get
            Set(value As String)
                strNoiDung = value
            End Set
        End Property
#End Region


    End Class
End Namespace
