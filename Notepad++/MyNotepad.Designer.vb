<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyNotepad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindReplaceTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.texto = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTool, Me.EditTool, Me.SearchTool, Me.helpToolStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileTool
        '
        Me.FileTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTool, Me.OpenTool, Me.SaveTool, Me.SaveAsTool, Me.CloseTool})
        Me.FileTool.Name = "FileTool"
        Me.FileTool.Size = New System.Drawing.Size(37, 20)
        Me.FileTool.Text = "File"
        '
        'NewTool
        '
        Me.NewTool.Image = Global.Notepad__.My.Resources.Resource.nuevo
        Me.NewTool.Name = "NewTool"
        Me.NewTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewTool.Size = New System.Drawing.Size(186, 22)
        Me.NewTool.Text = "New"
        '
        'OpenTool
        '
        Me.OpenTool.Image = Global.Notepad__.My.Resources.Resource.abrir
        Me.OpenTool.Name = "OpenTool"
        Me.OpenTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenTool.Size = New System.Drawing.Size(186, 22)
        Me.OpenTool.Text = "Open"
        '
        'SaveTool
        '
        Me.SaveTool.Image = Global.Notepad__.My.Resources.Resource.save_14949
        Me.SaveTool.Name = "SaveTool"
        Me.SaveTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveTool.Size = New System.Drawing.Size(186, 22)
        Me.SaveTool.Text = "Save"
        '
        'SaveAsTool
        '
        Me.SaveAsTool.Image = Global.Notepad__.My.Resources.Resource.diskette_save_saveas_1514
        Me.SaveAsTool.Name = "SaveAsTool"
        Me.SaveAsTool.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsTool.Size = New System.Drawing.Size(186, 22)
        Me.SaveAsTool.Text = "Save As"
        '
        'CloseTool
        '
        Me.CloseTool.Image = Global.Notepad__.My.Resources.Resource.Logout_37127
        Me.CloseTool.Name = "CloseTool"
        Me.CloseTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseTool.Size = New System.Drawing.Size(186, 22)
        Me.CloseTool.Text = "Close"
        '
        'EditTool
        '
        Me.EditTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoTool, Me.UndoTool, Me.ToolStripSeparator1, Me.CutToolStrip, Me.CopyToolStrip, Me.PasteTool})
        Me.EditTool.Name = "EditTool"
        Me.EditTool.Size = New System.Drawing.Size(39, 20)
        Me.EditTool.Text = "Edit"
        '
        'DoTool
        '
        Me.DoTool.Image = Global.Notepad__.My.Resources.Resource.redo_128
        Me.DoTool.Name = "DoTool"
        Me.DoTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.DoTool.Size = New System.Drawing.Size(144, 22)
        Me.DoTool.Text = "Do"
        '
        'UndoTool
        '
        Me.UndoTool.Image = Global.Notepad__.My.Resources.Resource.undo_1_icon_icons_com_62895
        Me.UndoTool.Name = "UndoTool"
        Me.UndoTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoTool.Size = New System.Drawing.Size(144, 22)
        Me.UndoTool.Text = "Undo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStrip
        '
        Me.CutToolStrip.Image = Global.Notepad__.My.Resources.Resource.cortar_icono_9536_128
        Me.CutToolStrip.Name = "CutToolStrip"
        Me.CutToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStrip.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStrip.Text = "Cut"
        '
        'CopyToolStrip
        '
        Me.CopyToolStrip.Image = Global.Notepad__.My.Resources.Resource.copy_two_paper_sheets_interface_symbol_icon_icons_com_73283
        Me.CopyToolStrip.Name = "CopyToolStrip"
        Me.CopyToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStrip.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStrip.Text = "Copy"
        '
        'PasteTool
        '
        Me.PasteTool.Image = Global.Notepad__.My.Resources.Resource.clipboard_paste_button_icon_icons_com_72805
        Me.PasteTool.Name = "PasteTool"
        Me.PasteTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteTool.Size = New System.Drawing.Size(144, 22)
        Me.PasteTool.Text = "Paste"
        '
        'SearchTool
        '
        Me.SearchTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindTool, Me.FindReplaceTool})
        Me.SearchTool.Name = "SearchTool"
        Me.SearchTool.Size = New System.Drawing.Size(54, 20)
        Me.SearchTool.Text = "Search"
        '
        'FindTool
        '
        Me.FindTool.Image = Global.Notepad__.My.Resources.Resource.find
        Me.FindTool.Name = "FindTool"
        Me.FindTool.Size = New System.Drawing.Size(144, 22)
        Me.FindTool.Text = "Find"
        '
        'FindReplaceTool
        '
        Me.FindReplaceTool.Image = Global.Notepad__.My.Resources.Resource.Actions_find_replace_icon
        Me.FindReplaceTool.Name = "FindReplaceTool"
        Me.FindReplaceTool.Size = New System.Drawing.Size(144, 22)
        Me.FindReplaceTool.Text = "Find & Replace"
        '
        'helpToolStrip
        '
        Me.helpToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTool})
        Me.helpToolStrip.Name = "helpToolStrip"
        Me.helpToolStrip.Size = New System.Drawing.Size(24, 20)
        Me.helpToolStrip.Text = "?"
        '
        'AboutTool
        '
        Me.AboutTool.Image = Global.Notepad__.My.Resources.Resource.about_128
        Me.AboutTool.Name = "AboutTool"
        Me.AboutTool.Size = New System.Drawing.Size(107, 22)
        Me.AboutTool.Text = "About"
        '
        'texto
        '
        Me.texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.texto.Location = New System.Drawing.Point(0, 24)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(686, 545)
        Me.texto.TabIndex = 2
        Me.texto.Text = ""
        '
        'MyNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 569)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MyNotepad"
        Me.Text = "Notepadd++"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileTool As ToolStripMenuItem
    Friend WithEvents NewTool As ToolStripMenuItem
    Friend WithEvents OpenTool As ToolStripMenuItem
    Friend WithEvents SaveTool As ToolStripMenuItem
    Friend WithEvents SaveAsTool As ToolStripMenuItem
    Friend WithEvents CloseTool As ToolStripMenuItem
    Friend WithEvents EditTool As ToolStripMenuItem
    Friend WithEvents CutToolStrip As ToolStripMenuItem
    Friend WithEvents CopyToolStrip As ToolStripMenuItem
    Friend WithEvents PasteTool As ToolStripMenuItem
    Friend WithEvents DoTool As ToolStripMenuItem
    Friend WithEvents UndoTool As ToolStripMenuItem
    Friend WithEvents SearchTool As ToolStripMenuItem
    Friend WithEvents FindTool As ToolStripMenuItem
    Friend WithEvents FindReplaceTool As ToolStripMenuItem
    Friend WithEvents helpToolStrip As ToolStripMenuItem
    Friend WithEvents AboutTool As ToolStripMenuItem
    Friend WithEvents texto As RichTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
