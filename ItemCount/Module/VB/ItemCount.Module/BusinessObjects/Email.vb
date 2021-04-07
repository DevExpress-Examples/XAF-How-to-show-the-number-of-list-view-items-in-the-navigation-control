Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

<DefaultClassOptions>
Public Class Email
    Inherits BaseObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _Name As String

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(Name), _Name, value)
        End Set
    End Property
End Class
