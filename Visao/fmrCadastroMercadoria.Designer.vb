<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrCadastroMercadoria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtfotopath = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtInformacoesAdicionais = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "Imagem:"
        '
        'txtfotopath
        '
        Me.txtfotopath.Location = New System.Drawing.Point(121, 101)
        Me.txtfotopath.Name = "txtfotopath"
        Me.txtfotopath.Size = New System.Drawing.Size(382, 20)
        Me.txtfotopath.TabIndex = 127
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Info. Adicionais:"
        '
        'txtInformacoesAdicionais
        '
        Me.txtInformacoesAdicionais.Location = New System.Drawing.Point(121, 75)
        Me.txtInformacoesAdicionais.Name = "txtInformacoesAdicionais"
        Me.txtInformacoesAdicionais.Size = New System.Drawing.Size(382, 20)
        Me.txtInformacoesAdicionais.TabIndex = 123
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(262, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Código de Barra:"
        '
        'TxtCodigoBarra
        '
        Me.TxtCodigoBarra.Location = New System.Drawing.Point(378, 43)
        Me.TxtCodigoBarra.Name = "TxtCodigoBarra"
        Me.TxtCodigoBarra.Size = New System.Drawing.Size(125, 20)
        Me.TxtCodigoBarra.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Referência:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(121, 48)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(133, 20)
        Me.txtReferencia.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(121, 12)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(798, 20)
        Me.txtDescricao.TabIndex = 101
        '
        'fmrCadastroMercadoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 555)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtfotopath)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtInformacoesAdicionais)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCodigoBarra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescricao)
        Me.Name = "fmrCadastroMercadoria"
        Me.Text = "Cadastro mercadoria e serviços"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtfotopath As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtInformacoesAdicionais As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
End Class
