Public Class Contenido

    Private mfilename As String
    Public Property filename() As String
        Get
            Return mfilename
        End Get
        Set(ByVal value As String)
            mfilename = value
        End Set
    End Property

    Private mmodificado As Boolean
    Public Property modificado() As Boolean
        Get
            Return mmodificado
        End Get
        Set(ByVal value As Boolean)
            mmodificado = value
        End Set
    End Property

    Private mcodigo As Integer
    Public Property codigo() As Integer
        Get
            Return mcodigo
        End Get
        Set(value As Integer)
            mcodigo = value
        End Set
    End Property

    Private mID As Integer
    'Public Property ID() As Integer
    '    Get
    '        Return mID
    '    End Get
    '    Set(value As Integer)
    '        mID = value
    '    End Set
    'End Property

End Class
