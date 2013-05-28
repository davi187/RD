Public Class ControladorFuncionario
    Public Shared Function getFuncionarios() As List(Of Funcionario)

        Dim listaFuncionarios As List(Of Funcionario)
        Dim rs As DataSet = Driver.DataSet("Select * FROM Pessoas WHERE TipoCadastro=2 AND dataDesativado=''")


        For Each linha As DataRow In rs.Tables(0).Rows
            Dim func As New Funcionario

            func.Bairro = linha.Item("bairro")
            func.Fantasia = linha.Item("bairro")
            func.Bairro = linha.Item("bairro")
            func.Bairro = linha.Item("bairro")
            func.Bairro = linha.Item("bairro")
            func.Bairro = linha.Item("bairro")
            func.Bairro = linha.Item("bairro")
            func.Bairro = linha.Item("bairro")


        Next


    End Function

End Class
