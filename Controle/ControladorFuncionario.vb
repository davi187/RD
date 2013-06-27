Public Class ControladorFuncionario
    Public Shared Function getFuncionarios() As List(Of Funcionario)

        Dim listaFuncionarios As List(Of Funcionario)

        Dim rs As DataSet = Driver.Reader("Select * FROM Pessoas WHERE TipoCadastro=2 AND dataDesativado=''")



        For Each linha As DataRow In rs.Tables(0).Rows
            Dim func As New Funcionario

            func.Bairro = linha.Item("bairro")
            func.CCidade = linha.Item("bairro")
            func.CEP = linha.Item("bairro")
            func.CPFCNPJ = linha.Item("bairro")
            func.CUF = linha.Item("bairro")
            func.CVendedor = linha.Item("bairro")
            func.DataAlterado = linha.Item("bairro")
            func.DataCadastro = linha.Item("bairro")
         

        Next


    End Function

End Class
