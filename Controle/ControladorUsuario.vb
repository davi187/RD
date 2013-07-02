Public Class ControladorUsuario
    Public Shared Function GetUsuarios() As List(Of Usuario)
        Try

            Dim dr As MySql.Data.MySqlClient.MySqlDataReader = Driver.Reader("SELECT * FROM usuario WHERE excluido=0")
            Dim listaUsuarios As List(Of Usuario) = New List(Of Usuario)

            If dr.HasRows Then
                While dr.Read()
                    listaUsuarios.Add(New Usuario(dr.Item("id"), dr.Item("Nome"), dr.Item("senha")))
                End While
            End If

            dr.Close()
            Return listaUsuarios
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Retorna o objeto usuário populado, caso o mesmo exista, caso não, o objeto vazio será retornado 
    ''' </summary>
    ''' <param name="nome"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetUsuario(ByVal nome As String) As Usuario
        If GetUsuarios.Where(Function(f) f.Nome = nome).Count = 0 Then
            Return Nothing
        Else
            Return GetUsuarios.Where(Function(f) f.Nome = nome).First
        End If
    End Function
    ''' <summary>
    ''' Salva o usuario no banco de dados
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <remarks></remarks>
    Public Shared Sub SalvarUsuario(ByVal usuario As Usuario)
        Driver.Execute(String.Format("INSERT INTO USUARIO (NOME,SENHA) VALUES('{0}','{1}')", usuario.Nome, usuario.Senha))
    End Sub
    ''' <summary>
    ''' Valida as credenciais do fornecidas e retorna se elas estao validas
    ''' </summary>
    ''' <param name="loguin"></param>
    ''' <param name="senha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
