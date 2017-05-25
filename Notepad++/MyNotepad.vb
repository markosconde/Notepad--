Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class MyNotepad

    Dim ListaArchivos As New List(Of Contenido)

    Private Sub NewTool_Click(sender As Object, e As EventArgs) Handles NewTool.Click
        Dim myTabPage As New TabPage()
        Dim tb As New RichTextBox()
        AddHandler tb.TextChanged, AddressOf texto_TextChanged
        myTabPage.Controls.Add(tb)
        tb.Dock = DockStyle.Fill

        myTabPage.Text = "New" & (TabControl.TabPages.Count)
        TabControl.TabPages.Insert(TabControl.TabPages.Count - 1, myTabPage)
        TabControl.SelectedTab = myTabPage
        Dim c As New Contenido
        c.modificado = False
        ListaArchivos.Add(c)

    End Sub


    Private Sub OpenTool_Click(sender As Object, e As EventArgs) Handles OpenTool.Click


        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "text Files|*.txt"
        'Aqui se selecciona el tipo de documento que se podra escoger al buscar

        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            ListaArchivos.Item(TabControl.SelectedIndex).filename = OpenFileDialog.FileName
            For Each c As Control In TabControl.SelectedTab.Controls
                CType(c, RichTextBox).LoadFile(ListaArchivos.Item(TabControl.SelectedIndex).filename, RichTextBoxStreamType.PlainText)
            Next
            'se carga el contenido del documento de texto y lo muestra
            Me.Text = "Notepadd++ - " + ListaArchivos(TabControl.SelectedIndex).filename
            TabControl.SelectedTab.Text = ListaArchivos(TabControl.SelectedIndex).filename
        End If


    End Sub


    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        If Not (ListaArchivos.Item(TabControl.SelectedIndex).filename = String.Empty) Then
            For Each g As Control In TabControl.SelectedTab.Controls
                CType(g, RichTextBox).SaveFile(ListaArchivos.Item(TabControl.SelectedIndex).filename, RichTextBoxStreamType.PlainText)
                TabControl.SelectedTab.Text = ListaArchivos(TabControl.SelectedIndex).filename
            Next
        Else
            SaveAsTool_Click(sender, e)
        End If
        ListaArchivos(TabControl.SelectedIndex).modificado = False

    End Sub


    Private Sub SaveAsTool_Click(sender As Object, e As EventArgs) Handles SaveAsTool.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files| *.txt*"

        If (SaveFileDialog.ShowDialog() = DialogResult.OK) Then
            ListaArchivos.Item(TabControl.SelectedIndex).filename = SaveFileDialog.FileName
            For Each g As Control In TabControl.SelectedTab.Controls
                CType(g, RichTextBox).SaveFile(ListaArchivos.Item(TabControl.SelectedIndex).filename, RichTextBoxStreamType.PlainText)
            Next
            ListaArchivos(TabControl.SelectedIndex).modificado = False
            Me.Text = "Notepadd++ - " + ListaArchivos(TabControl.SelectedIndex).filename
            TabControl.SelectedTab.Text = ListaArchivos(TabControl.SelectedIndex).filename

        End If

    End Sub

    Private Sub CloseTool_Click(sender As Object, e As EventArgs) Handles CloseTool.Click
        Me.Close()

    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs)
        ListaArchivos(TabControl.SelectedIndex).modificado = True
    End Sub
    '!!'
    Private Sub MyNotepad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As Integer = 0
        ''Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("gl-ES")
        ''Thread.CurrentThread.CurrentCulture = culture
        ''Thread.CurrentThread.CurrentUICulture = culture
        Dim rm As New ResourceManager("Notepad__.Resource",
        GetType(MyNotepad).Assembly)

        For Each b As Contenido In ListaArchivos
            Me.TabControl.SelectedIndex = i
            i = i + 1


            If (b.modificado = True) Then

                Dim resultado As MsgBoxResult = MsgBox(rm.GetString("mod1") + b.filename + " " + rm.GetString("mod2"), vbCritical + vbYesNoCancel)
                If (resultado = vbYes) Then
                    SaveTool_Click(Nothing, Nothing)
                End If
                If (resultado = vbCancel) Then
                    e.Cancel = True
                End If
            End If

        Next


    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        NewTool_Click(sender, e)
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenTool_Click(Nothing, Nothing)
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveTool_Click(Nothing, Nothing)
    End Sub

    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedTab.Name = tpMas.Name Then
            NewTool_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub MyNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewTool_Click(Nothing, Nothing)
        PestañasTool.Enabled = False
        PestañasTool.Checked = True
        VentanasTool.Enabled = True
        VentanasTool.Checked = False
        EnglishTool.Checked = True
        GalicianTool.Checked = False
        EnglishTool.Enabled = False
        GalicianTool.Enabled = True

    End Sub

    Private Sub FindTool_Click(sender As Object, e As EventArgs) Handles FindTool.Click
        Dim Buscar As New Buscar
        Buscar.Owner = Me
        Buscar.Show()
    End Sub

    Private Sub VentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentanasTool.Click
        PestañasTool.Enabled = True
        PestañasTool.Checked = False
        VentanasTool.Enabled = False
        VentanasTool.Checked = True

        Dim i As Integer = 0
        Me.IsMdiContainer = True

        While i < TabControl.TabCount - 1

            Dim frm As New Form2

            frm.MdiParent = Me
            frm.Controls.Add((TabControl.TabPages(i).Controls(0)))
            frm.Text = TabControl.TabPages(i).Text
            frm.Show()


            i = i + 1
        End While
        RemoveHandler TabControl.SelectedIndexChanged, AddressOf TabControl_SelectedIndexChanged
        TabControl.TabPages.Clear()
        TabControl.Visible = False

    End Sub

    Private Sub PestañasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PestañasTool.Click
        PestañasTool.Enabled = False
        PestañasTool.Checked = True
        VentanasTool.Enabled = True
        VentanasTool.Checked = False

        Dim i As Integer = 0


        While i < MdiChildren.Count
            Dim Tab As New TabPage

            Tab.Controls.Add(MdiChildren(i).Controls(0))
            TabControl.TabPages.Add(Tab)
            Tab.Text = MdiChildren(i).Text
            i = i + 1
        End While

        TabControl.Visible = True
        Me.IsMdiContainer = False
    End Sub

    Private Sub EnglishTool_Click(sender As Object, e As EventArgs) Handles EnglishTool.Click
        EnglishTool.Checked = True
        GalicianTool.Checked = False
        EnglishTool.Enabled = False
        GalicianTool.Enabled = True
        LimpiarControles(e)
        Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("en-EN")
        Thread.CurrentThread.CurrentCulture = culture
        Thread.CurrentThread.CurrentUICulture = culture
        Me.Refresh()
        Me.Controls.Clear()
        Me.InitializeComponent()

    End Sub

    Private Sub GalicianTool_Click(sender As Object, e As EventArgs) Handles GalicianTool.Click
        EnglishTool.Checked = False
        GalicianTool.Checked = True
        EnglishTool.Enabled = True
        GalicianTool.Enabled = False
        LimpiarControles(e)
        Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("gl-ES")
        Thread.CurrentThread.CurrentCulture = culture
        Thread.CurrentThread.CurrentUICulture = culture
        Me.Controls.Clear()
        Me.InitializeComponent()

    End Sub


    Public Sub LimpiarControles(ByVal control As Object)

        Dim i As Integer = 0

        While i < TabControl.TabPages.Count
            i = i + 1
        End While

    End Sub

End Class
