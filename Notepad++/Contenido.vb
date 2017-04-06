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
End Class
