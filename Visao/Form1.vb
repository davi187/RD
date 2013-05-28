Imports MySql.Data

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        Dim rs As System.Data.DataSet = Driver.DataSet("Select * from auditoria")
        MessageBox.Show(rs.Tables(0).Rows(0).Item("acao"))

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'teste 
    End Sub
End Class
