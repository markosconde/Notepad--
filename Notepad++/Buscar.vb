Public Class Buscar
    Private Sub Bbusca_Click(sender As Object, e As EventArgs) Handles Bbusca.Click
        Dim ventanaprincipal As MyNotepad
        ventanaprincipal = Me.Owner
        Dim TabPage As TabPage = ventanaprincipal.TabControl.SelectedTab
        Dim richTextBox As RichTextBox = TabPage.Controls(0)

        richTextBox.Select(richTextBox.Text.IndexOf(palabra.Text), palabra.Text.Length)
        ventanaprincipal.Focus()

    End Sub
End Class