Public Class Form1
    Private Sub NewTool_Click(sender As Object, e As EventArgs) Handles NewTool.Click
        If (MsgBox("Los datos no guardados se perderan, ¿Estas seguro?", vbCritical + vbYesNo) = vbYes) Then
            texto.Clear()
        Else
        End If
    End Sub


    Private Sub OpenTool_Click(sender As Object, e As EventArgs) Handles OpenTool.Click
        OpenFileDialog

    End Sub

    Private Sub CloseTool_Click(sender As Object, e As EventArgs) Handles CloseTool.Click
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()

        Else
        End If
    End Sub


End Class
