Public Class Class2

   Public Property MyName As String
        Get
            Return My.Settings.Name
        End Get
        Set(value As String)
            My.Settings.Name = value
        End Set
    End Property

    Public Property MyColor
        Get
            Return My.Settings.Color
        End Get
        Set(value)
            My.Settings.Color = value
        End Set
    End Property

End Class