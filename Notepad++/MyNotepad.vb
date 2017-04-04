Public Class MyNotepad
    Private filename As String = String.Empty
    Private modificado As Boolean = False

    Private Sub NewTool_Click(sender As Object, e As EventArgs) Handles NewTool.Click
        If (modificado = True) Then
            If (MsgBox("Los datos no guardados se perderan, ¿Estas seguro?", vbCritical + vbYesNo) = vbYes) Then
                texto.Clear()
            Else
            End If
        Else
            texto.Clear()
        End If

    End Sub


    Private Sub OpenTool_Click(sender As Object, e As EventArgs) Handles OpenTool.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "text Files|*.txt"
        'Aqui se selecciona el tipo de documento que se podra escoger al buscar

        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            filename = OpenFileDialog.FileName
            Me.texto.LoadFile(filename, RichTextBoxStreamType.PlainText)
            'se carga el contenido del documento de texto y lo muestra

            'MsgBox(OpenFileDialog.FileName)
        End If

    End Sub


    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        If Not (filename = String.Empty) Then
            Me.texto.SaveFile(filename, RichTextBoxStreamType.PlainText)
        Else
            SaveAsTool_Click(sender, e)
        End If
        modificado = False

    End Sub


    Private Sub SaveAsTool_Click(sender As Object, e As EventArgs) Handles SaveAsTool.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files| *.txt*"

        If (SaveFileDialog.ShowDialog() = DialogResult.OK) Then
            filename = SaveFileDialog.FileName
            Me.texto.SaveFile(filename, RichTextBoxStreamType.PlainText)
            modificado = False

        End If

    End Sub

    Private Sub CloseTool_Click(sender As Object, e As EventArgs) Handles CloseTool.Click
        MyNotepad_FormClosing(Nothing, Nothing)
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) Handles texto.TextChanged
        Modificado = True
    End Sub

    Private Sub MyNotepad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (modificado = True) Then
            If (MsgBox("El archivo se ha modificado, ¿Desea guardarlo antes de salir?", vbCritical + vbYesNo) = vbYes) Then
                SaveTool_Click(Nothing, Nothing)
            Else
            End If
        Else
            Me.Close()

        End If
    End Sub
End Class
