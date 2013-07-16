Public Class ControladorFornecedor
    Private Shared mtipoCadastro As Modelo.Pessoa.TipoPessoa
    Public Overridable ReadOnly Property TipoCadastro() As Modelo.Pessoa.TipoPessoa
        Get
            mtipoCadastro = Nothing
            Return mtipoCadastro
        End Get
    End Property

    Public Shared Function getPess() As List(Of Funcionario)

        Dim listaFuncionarios As New List(Of Funcionario)

        Dim rs As DataSet = Driver.Reader(String.Format("Select * FROM Pessoas WHERE TipoCadastro={0} AND dataDesativado=''", mtipoCadastro))



        For Each linha As DataRow In rs.Tables(0).Rows


            'func.Fantasia = linha.Item("Fantasia")
            'func.RazaoSocial = linha.Item("RazaoSocial")
            'func.CPFCNPJ = linha.Item("CPFCNPJ")
            'func.IERG = linha.Item("IERG")
            'func.Endereco = linha.Item("Endereco")
            'func.Numero = linha.Item("Numero")
            'func.Bairro = linha.Item("bairro")
            'func.CCidade = linha.Item("cCidade")
            'func.CUF = linha.Item("cUF")
            'func.CEP = linha.Item("CEP")
            'func.DataCadastro = linha.Item("DataCadastro")
            'func.Responsavel = linha.Item("Responsavel")
            'func.PontoReferencia = linha.Item("PontoReferencia")
            'func.CVendedor = linha.Item("cVendedor")
            'func.Email = linha.Item("Email")
            'func.UsuarioCriado = linha.Item("UsuarioCriado")
            'func.DataCriado = linha.Item("DataCriado")
            'func.UsuarioDesativado = linha.Item("UsuarioDesativado")
            'func.DataDesativado = linha.Item("DataDesativado")
            'func.UsuarioAlterado = linha.Item("UsuarioAlterado")
            'func.DataAlterado = linha.Item("DataAlterado")
            'Adicionando Funcionario a lista
            'listaFuncionarios.Add(func)

        Next


    End Function
End Class
