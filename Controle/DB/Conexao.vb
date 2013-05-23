Namespace Controle
    Public Class Conexao
        Shared conn As MySql.Data.MySqlClient.MySqlConnection
        Public Shared Function GetConexao() As MySql.Data.MySqlClient.MySqlConnection
            'Verificando status da conexao
            'Caso ja exista uma conexao aberta o sistema ira retornala
            If IsNothing(conn) = True Then
                Conectar()
            ElseIf conn.State = ConnectionState.Closed Then
                Conectar()
            End If
            Return conn
        End Function
        Private Shared Sub Conectar()
            'Conecta ao banco de dados
            Dim connextionString As String
            'Sedando dados da conexao
            connextionString = String.Format("server={0};" _
                & "uid={1};" _
                & "pwd={2};" _
                & "database={3};", My.Settings.Servidor, My.Settings.Usuario, My.Settings.Senha, My.Settings.Banco)
            Try
                'tentando a conexao
                conn = New MySql.Data.MySqlClient.MySqlConnection(connextionString)
                conn.Open()

            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Sub teste()
            Dim s As MySql.Data.MySqlClient.MySqlConnection
            s = GetConexao()
        End Sub
    End Class
End Namespace