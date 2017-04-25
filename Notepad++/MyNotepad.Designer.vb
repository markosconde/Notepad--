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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyNotepad))
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripundo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripredo = New System.Windows.Forms.ToolStripButton()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tpMas = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl.SuspendLayout()
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator2, Me.ToolStripundo, Me.ToolStripredo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(686, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripundo
        '
        Me.ToolStripundo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripundo.Image = Global.Notepad__.My.Resources.Resource.undo_1_icon_icons_com_62895
        Me.ToolStripundo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripundo.Name = "ToolStripundo"
        Me.ToolStripundo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripundo.Text = "ToolStripButton1"
        '
        'ToolStripredo
        '
        Me.ToolStripredo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripredo.Image = Global.Notepad__.My.Resources.Resource.redo_128
        Me.ToolStripredo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripredo.Name = "ToolStripredo"
        Me.ToolStripredo.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripredo.Text = "ToolStripButton2"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.tpMas)
        Me.TabControl.Location = New System.Drawing.Point(0, 49)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(686, 522)
        Me.TabControl.TabIndex = 4
        '
        'tpMas
        '
        Me.tpMas.Location = New System.Drawing.Point(4, 22)
        Me.tpMas.Name = "tpMas"
        Me.tpMas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMas.Size = New System.Drawing.Size(678, 496)
        Me.tpMas.TabIndex = 1
        Me.tpMas.Text = "    +"
        Me.tpMas.UseVisualStyleBackColor = True
        '
        'MyNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 569)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MyNotepad"
        Me.Text = "Notepadd++"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
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
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripundo As ToolStripButton
    Friend WithEvents ToolStripredo As ToolStripButton
    Friend WithEvents tpMas As TabPage
    Friend WithEvents TabControl As TabControl
End Class
