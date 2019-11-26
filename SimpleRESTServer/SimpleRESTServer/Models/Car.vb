Public Class Car

    Private _ID As Integer
    Private _Make As String
    Private _Model As String

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Make() As String
        Get
            Return _Make
        End Get
        Set(value As String)
            _Make = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return _Model
        End Get
        Set(value As String)
            _Model = value
        End Set
    End Property

End Class
