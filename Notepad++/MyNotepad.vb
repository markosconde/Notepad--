Public Class MyNotepad
    Private contenido As New Contenido()
    Private Sub NewTool_Click(sender As Object, e As EventArgs) Handles NewTool.Click
        If (contenido.modificado = True) Then
            Dim resultado As MsgBoxResult = MsgBox("El archivo se ha modificado, ¿Desea guardarlo antes de salir?", vbCritical + vbYesNoCancel)
            If (resultado = vbYes) Then
                SaveTool_Click(Nothing, Nothing)
                texto.Clear()
                contenido.modificado = False
                contenido = New Contenido()
            ElseIf (resultado = vbNo) Then
                texto.Clear()
                contenido.modificado = False
                contenido = New Contenido()
            End If
        End If

    End Sub


    Private Sub OpenTool_Click(sender As Object, e As EventArgs) Handles OpenTool.Click

        If (contenido.modificado = True) Then
            Dim resultado As MsgBoxResult = MsgBox("El archivo se ha modificado, ¿Desea guardarlo antes de salir?", vbCritical + vbYesNoCancel)
            If (resultado = vbYes) Then
                SaveTool_Click(Nothing, Nothing)
            End If
        Else
            Dim OpenFileDialog As New OpenFileDialog
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "text Files|*.txt"
            'Aqui se selecciona el tipo de documento que se podra escoger al buscar

            If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
                contenido.filename = OpenFileDialog.FileName
                Me.texto.LoadFile(contenido.filename, RichTextBoxStreamType.PlainText)
                'se carga el contenido del documento de texto y lo muestra
                Me.Text = "Notepadd++ - " + contenido.filename

            End If
        End If


    End Sub


    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        If Not (contenido.filename = String.Empty) Then
            Me.texto.SaveFile(contenido.filename, RichTextBoxStreamType.PlainText)
        Else
            SaveAsTool_Click(sender, e)
        End If
        contenido.modificado = False

    End Sub


    Private Sub SaveAsTool_Click(sender As Object, e As EventArgs) Handles SaveAsTool.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files| *.txt*"

        If (SaveFileDialog.ShowDialog() = DialogResult.OK) Then
            contenido.filename = SaveFileDialog.FileName
            Me.texto.SaveFile(contenido.filename, RichTextBoxStreamType.PlainText)
            contenido.modificado = False
            Me.Text = "Notepadd++ - " + contenido.filename

        End If

    End Sub

    Private Sub CloseTool_Click(sender As Object, e As EventArgs) Handles CloseTool.Click
        Me.Close()

    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) Handles texto.TextChanged
        contenido.modificado = True
    End Sub

    Private Sub MyNotepad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (contenido.modificado = True) Then
            Dim resultado As MsgBoxResult = MsgBox("El archivo se ha modificado, ¿Desea guardarlo antes de salir?", vbCritical + vbYesNoCancel)
            If (resultado = vbYes) Then
                SaveTool_Click(Nothing, Nothing)
            End If
            If (resultado = vbCancel) Then
                e.Cancel = True
            End If
        End If
    End Sub


End Class


