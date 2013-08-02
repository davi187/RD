Public Class ControladorFuncionario
    ''' <summary>
    ''' Retorna a lista dos funcionarios cadastrados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getFuncionarios() As List(Of Funcionario)

        Dim listaFuncionarios As New List(Of Funcionario)

        Dim dr As MySql.Data.MySqlClient.MySqlDataReader = Driver.Reader("Select * FROM Pessoas WHERE TipoCadastro=2 AND dataDesativado=''")

        If Not dr.HasRows Then Return Nothing

        While dr.Read()

            Dim func As New Funcionario
            func.Fantasia = dr.Item("Fantasia")
            func.RazaoSocial = dr.Item("RazaoSocial")
            func.CPFCNPJ = dr.Item("CPFCNPJ")
            func.IERG = dr.Item("IERG")
            func.Endereco = dr.Item("Endereco")
            'func.Numero = dr.Item("Numero")
            func.Bairro = dr.Item("bairro")
            func.CCidade = dr.Item("cCidade")
            func.CUF = dr.Item("cUF")
            func.CEP = dr.Item("CEP")
            func.DataCadastro = dr.Item("DataCadastro")
            func.Responsavel = dr.Item("Responsavel")
            func.PontoReferencia = dr.Item("PontoReferencia")
            func.CVendedor = dr.Item("cVendedor")
            func.Email = dr.Item("Email")
            func.UsuarioCriado = dr.Item("UsuarioCriado")
            func.DataCriado = dr.Item("DataCriado")
            func.UsuarioDesativado = dr.Item("UsuarioDesativado")
            func.DataDesativado = dr.Item("DataDesativado")
            func.UsuarioAlterado = dr.Item("UsuarioAlterado")
            func.DataAlterado = dr.Item("DataAlterado")
            'Adicionando Funcionario a lista
            listaFuncionarios.Add(func)
        End While

        Return listaFuncionarios

    End Function
    ''' <summary>
    ''' Retorna o funcionario buscando pelo codigo
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFuncionario(ByVal id As Integer) As Funcionario

        Dim sql As String = String.Format("Select * FROM Pessoas WHERE TipoCadastro=2 AND dataDesativado='' AND  id={0}", id)

        Dim dr As MySql.Data.MySqlClient.MySqlDataReader = Driver.Reader(sql)

        If Not dr.HasRows Then Return Nothing

        Dim func As New Funcionario

        While dr.Read()

            func.Fantasia = dr.Item("Fantasia")
            func.RazaoSocial = dr.Item("RazaoSocial")
            func.CPFCNPJ = dr.Item("CPFCNPJ")
            func.IERG = dr.Item("IERG")
            func.Endereco = dr.Item("Endereco")
            'func.Numero = dr.Item("Numero")
            func.Bairro = dr.Item("bairro")
            func.CCidade = dr.Item("cCidade")
            func.CUF = dr.Item("cUF")
            func.CEP = dr.Item("CEP")
            func.DataCadastro = dr.Item("DataCadastro")
            func.Responsavel = dr.Item("Responsavel")
            func.PontoReferencia = dr.Item("PontoReferencia")
            func.CVendedor = dr.Item("cVendedor")
            func.Email = dr.Item("Email")
            func.UsuarioCriado = dr.Item("UsuarioCriado")
            func.DataCriado = dr.Item("DataCriado")
            func.UsuarioDesativado = dr.Item("UsuarioDesativado")
            func.DataDesativado = dr.Item("DataDesativado")
            func.UsuarioAlterado = dr.Item("UsuarioAlterado")
            func.DataAlterado = dr.Item("DataAlterado")




        End While

        Return func

    End Function


End Class
