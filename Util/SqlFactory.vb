Public Class SqlFactory
    Structure campo
        Public campo As String
        Public valor As String
    End Structure
    Private listaCampos As List(Of campo)
    Public Sub New()
        listaCampos = New List(Of campo)
    End Sub
    Public Sub addCampo(ByVal campo As campo)
        listaCampos.Add(campo)
    End Sub
    Public Sub addCampo(ByVal campo As String, ByVal valor As String)

        'listaCampos.Add(campo)
    End Sub
End Class
