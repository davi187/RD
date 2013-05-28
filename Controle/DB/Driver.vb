Imports MySql.Data

Public Class Driver
    ''' <summary>
    ''' Essa classe fará a abstração da comunicação aplicaçao com o banco de dados
    ''' </summary>
    ''' <remarks>Classe utilizada para executar comandos e retornar recordsets</remarks>
    ''' 
    Dim conn As MySql.Data.MySqlClient.MySqlConnection
    Dim sqlBilder As MySql.Data.MySqlClient.MySqlCommandBuilder
    Dim dataReader As MySql.Data.MySqlClient.MySqlDataReader

    Public Shared Sub Execute(ByVal ComandoSql As String)

        Dim rs As New MySql.Data.MySqlClient.MySqlCommand(ComandoSql, Controle.Conexao.GetConexao)

        Try

            rs.ExecuteNonQuery()

            rs.Connection.Close()

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Public Shared Function Reader(ByVal ComandoSql As String) As System.Data.IDataReader


        Dim rs As New MySql.Data.MySqlClient.MySqlCommand(ComandoSql, Controle.Conexao.GetConexao)


        Try

            Return rs.ExecuteReader

        Catch ex As Exception

            Throw ex

        End Try

    End Function

    Public Shared Function Adapter(ByVal ComandoSql As String) As System.Data.IDataAdapter

        Dim ad As New MySql.Data.MySqlClient.MySqlDataAdapter(ComandoSql, Controle.Conexao.GetConexao)

        Try

            Return ad

        Catch ex As Exception

            Throw ex

        End Try

    End Function
    Public Shared Function DataSet(ByVal ComandoSql As String) As System.Data.DataSet

        Dim ad As New MySql.Data.MySqlClient.MySqlDataAdapter(ComandoSql, Controle.Conexao.GetConexao)

        Dim ds As DataSet = New DataSet

        Try

            ad.Fill(ds)

            Return ds

        Catch ex As Exception

            Throw ex

        End Try

    End Function
End Class
