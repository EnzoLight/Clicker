<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Comeco
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btn_entrar = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaGreen
        Panel1.Controls.Add(btn_entrar)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(61, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(676, 373)
        Panel1.TabIndex = 0
        ' 
        ' btn_entrar
        ' 
        btn_entrar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_entrar.Location = New Point(230, 265)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(220, 57)
        btn_entrar.TabIndex = 1
        btn_entrar.Text = "ENTRAR"
        btn_entrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 48F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(123, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(430, 85)
        Label1.TabIndex = 0
        Label1.Text = "CLICK MANIA"
        ' 
        ' Comeco
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Comeco"
        Text = "Comeco"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_entrar As Button

End Class
