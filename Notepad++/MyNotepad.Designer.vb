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
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PestañasTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.GalicianTool = New System.Windows.Forms.ToolStripMenuItem()
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
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTool, Me.EditTool, Me.SearchTool, Me.VentanaToolStripMenuItem, Me.LanguageTool, Me.helpToolStrip})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileTool
        '
        resources.ApplyResources(Me.FileTool, "FileTool")
        Me.FileTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTool, Me.OpenTool, Me.SaveTool, Me.SaveAsTool, Me.CloseTool})
        Me.FileTool.Name = "FileTool"
        '
        'NewTool
        '
        resources.ApplyResources(Me.NewTool, "NewTool")
        Me.NewTool.Image = Global.Notepad__.My.Resources.Resource.nuevo
        Me.NewTool.Name = "NewTool"
        '
        'OpenTool
        '
        resources.ApplyResources(Me.OpenTool, "OpenTool")
        Me.OpenTool.Image = Global.Notepad__.My.Resources.Resource.abrir
        Me.OpenTool.Name = "OpenTool"
        '
        'SaveTool
        '
        resources.ApplyResources(Me.SaveTool, "SaveTool")
        Me.SaveTool.Image = Global.Notepad__.My.Resources.Resource.save_14949
        Me.SaveTool.Name = "SaveTool"
        '
        'SaveAsTool
        '
        resources.ApplyResources(Me.SaveAsTool, "SaveAsTool")
        Me.SaveAsTool.Image = Global.Notepad__.My.Resources.Resource.diskette_save_saveas_1514
        Me.SaveAsTool.Name = "SaveAsTool"
        '
        'CloseTool
        '
        resources.ApplyResources(Me.CloseTool, "CloseTool")
        Me.CloseTool.Image = Global.Notepad__.My.Resources.Resource.Logout_37127
        Me.CloseTool.Name = "CloseTool"
        '
        'EditTool
        '
        resources.ApplyResources(Me.EditTool, "EditTool")
        Me.EditTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoTool, Me.UndoTool, Me.ToolStripSeparator1, Me.CutToolStrip, Me.CopyToolStrip, Me.PasteTool})
        Me.EditTool.Name = "EditTool"
        '
        'DoTool
        '
        resources.ApplyResources(Me.DoTool, "DoTool")
        Me.DoTool.Image = Global.Notepad__.My.Resources.Resource.redo_128
        Me.DoTool.Name = "DoTool"
        '
        'UndoTool
        '
        resources.ApplyResources(Me.UndoTool, "UndoTool")
        Me.UndoTool.Image = Global.Notepad__.My.Resources.Resource.undo_1_icon_icons_com_62895
        Me.UndoTool.Name = "UndoTool"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'CutToolStrip
        '
        resources.ApplyResources(Me.CutToolStrip, "CutToolStrip")
        Me.CutToolStrip.Image = Global.Notepad__.My.Resources.Resource.cortar_icono_9536_128
        Me.CutToolStrip.Name = "CutToolStrip"
        '
        'CopyToolStrip
        '
        resources.ApplyResources(Me.CopyToolStrip, "CopyToolStrip")
        Me.CopyToolStrip.Image = Global.Notepad__.My.Resources.Resource.copy_two_paper_sheets_interface_symbol_icon_icons_com_73283
        Me.CopyToolStrip.Name = "CopyToolStrip"
        '
        'PasteTool
        '
        resources.ApplyResources(Me.PasteTool, "PasteTool")
        Me.PasteTool.Image = Global.Notepad__.My.Resources.Resource.clipboard_paste_button_icon_icons_com_72805
        Me.PasteTool.Name = "PasteTool"
        '
        'SearchTool
        '
        resources.ApplyResources(Me.SearchTool, "SearchTool")
        Me.SearchTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindTool, Me.FindReplaceTool})
        Me.SearchTool.Name = "SearchTool"
        '
        'FindTool
        '
        resources.ApplyResources(Me.FindTool, "FindTool")
        Me.FindTool.Image = Global.Notepad__.My.Resources.Resource.find
        Me.FindTool.Name = "FindTool"
        '
        'FindReplaceTool
        '
        resources.ApplyResources(Me.FindReplaceTool, "FindReplaceTool")
        Me.FindReplaceTool.Image = Global.Notepad__.My.Resources.Resource.Actions_find_replace_icon
        Me.FindReplaceTool.Name = "FindReplaceTool"
        '
        'VentanaToolStripMenuItem
        '
        resources.ApplyResources(Me.VentanaToolStripMenuItem, "VentanaToolStripMenuItem")
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PestañasTool, Me.VentanasTool})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        '
        'PestañasTool
        '
        resources.ApplyResources(Me.PestañasTool, "PestañasTool")
        Me.PestañasTool.Name = "PestañasTool"
        '
        'VentanasTool
        '
        resources.ApplyResources(Me.VentanasTool, "VentanasTool")
        Me.VentanasTool.Name = "VentanasTool"
        '
        'LanguageTool
        '
        resources.ApplyResources(Me.LanguageTool, "LanguageTool")
        Me.LanguageTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishTool, Me.GalicianTool})
        Me.LanguageTool.Name = "LanguageTool"
        '
        'EnglishTool
        '
        resources.ApplyResources(Me.EnglishTool, "EnglishTool")
        Me.EnglishTool.Name = "EnglishTool"
        '
        'GalicianTool
        '
        resources.ApplyResources(Me.GalicianTool, "GalicianTool")
        Me.GalicianTool.Name = "GalicianTool"
        '
        'helpToolStrip
        '
        resources.ApplyResources(Me.helpToolStrip, "helpToolStrip")
        Me.helpToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTool})
        Me.helpToolStrip.Name = "helpToolStrip"
        '
        'AboutTool
        '
        resources.ApplyResources(Me.AboutTool, "AboutTool")
        Me.AboutTool.Image = Global.Notepad__.My.Resources.Resource.about_128
        Me.AboutTool.Name = "AboutTool"
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator2, Me.ToolStripundo, Me.ToolStripredo})
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'NewToolStripButton
        '
        resources.ApplyResources(Me.NewToolStripButton, "NewToolStripButton")
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Name = "NewToolStripButton"
        '
        'OpenToolStripButton
        '
        resources.ApplyResources(Me.OpenToolStripButton, "OpenToolStripButton")
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        '
        'SaveToolStripButton
        '
        resources.ApplyResources(Me.SaveToolStripButton, "SaveToolStripButton")
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        '
        'toolStripSeparator
        '
        resources.ApplyResources(Me.toolStripSeparator, "toolStripSeparator")
        Me.toolStripSeparator.Name = "toolStripSeparator"
        '
        'CutToolStripButton
        '
        resources.ApplyResources(Me.CutToolStripButton, "CutToolStripButton")
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Name = "CutToolStripButton"
        '
        'CopyToolStripButton
        '
        resources.ApplyResources(Me.CopyToolStripButton, "CopyToolStripButton")
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        '
        'PasteToolStripButton
        '
        resources.ApplyResources(Me.PasteToolStripButton, "PasteToolStripButton")
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        '
        'toolStripSeparator2
        '
        resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        '
        'ToolStripundo
        '
        resources.ApplyResources(Me.ToolStripundo, "ToolStripundo")
        Me.ToolStripundo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripundo.Image = Global.Notepad__.My.Resources.Resource.undo_1_icon_icons_com_62895
        Me.ToolStripundo.Name = "ToolStripundo"
        '
        'ToolStripredo
        '
        resources.ApplyResources(Me.ToolStripredo, "ToolStripredo")
        Me.ToolStripredo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripredo.Image = Global.Notepad__.My.Resources.Resource.redo_128
        Me.ToolStripredo.Name = "ToolStripredo"
        '
        'TabControl
        '
        resources.ApplyResources(Me.TabControl, "TabControl")
        Me.TabControl.Controls.Add(Me.tpMas)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        '
        'tpMas
        '
        resources.ApplyResources(Me.tpMas, "tpMas")
        Me.tpMas.Name = "tpMas"
        Me.tpMas.UseVisualStyleBackColor = True
        '
        'MyNotepad
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MyNotepad"
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
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PestañasTool As ToolStripMenuItem
    Friend WithEvents VentanasTool As ToolStripMenuItem
    Friend WithEvents LanguageTool As ToolStripMenuItem
    Friend WithEvents EnglishTool As ToolStripMenuItem
    Friend WithEvents GalicianTool As ToolStripMenuItem
End Class
