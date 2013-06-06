Public Class ControladorUsuario
    Public Shared Function GetUsuarios() As List(Of Usuario)
        Try

            Dim ds As DataSet = Driver.DataSet("SELECT * FROM usuario WHERE excluido=0")
            Dim listaUsuarios As List(Of Usuario) = New List(Of Usuario)

            For Each linha In ds.Tables(0).Rows
                listaUsuarios.Add(New Usuario(linha("id"), linha("Nome"), linha("senha")))
            Next

            Return listaUsuarios

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Shared Function GetUsuario(ByVal nome As String) As Usuario
        'Retorna o objeto usuario com as informações do usuarui pesquisado, caso esse exista
        If GetUsuarios.Where(Function(f) f.Nome = nome).Count = 0 Then
            Return Nothing
        Else
            Return GetUsuarios.Where(Function(f) f.Nome = nome).First
        End If
    End Function
    Public Shared Function ValidarCredenciais(ByVal loguin As String, ByVal senha As String) As Boolean

        Dim musuario As Usuario = ControladorUsuario.GetUsuario(loguin)

        If Not musuario Is Nothing Then
            If musuario.Senha = senha Then
                Return True
                Exit Function
            End If
        End If
        Return False
    End Function


End Class
