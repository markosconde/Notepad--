<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.palabra = New System.Windows.Forms.TextBox()
        Me.Bbusca = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar: "
        '
        'palabra
        '
        Me.palabra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.palabra.Location = New System.Drawing.Point(74, 37)
        Me.palabra.Name = "palabra"
        Me.palabra.Size = New System.Drawing.Size(242, 20)
        Me.palabra.TabIndex = 1
        '
        'Bbusca
        '
        Me.Bbusca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Bbusca.Location = New System.Drawing.Point(111, 76)
        Me.Bbusca.Name = "Bbusca"
        Me.Bbusca.Size = New System.Drawing.Size(75, 23)
        Me.Bbusca.TabIndex = 2
        Me.Bbusca.Text = "Buscar "
        Me.Bbusca.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 111)
        Me.Controls.Add(Me.Bbusca)
        Me.Controls.Add(Me.palabra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Buscar"
        Me.Text = "Buscar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents palabra As TextBox
    Friend WithEvents Bbusca As Button
End Class
