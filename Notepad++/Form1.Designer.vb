﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoTool = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.texto = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.NewTool.Name = "NewTool"
        Me.NewTool.Size = New System.Drawing.Size(152, 22)
        Me.NewTool.Text = "New"
        '
        'OpenTool
        '
        Me.OpenTool.Name = "OpenTool"
        Me.OpenTool.Size = New System.Drawing.Size(152, 22)
        Me.OpenTool.Text = "Open"
        '
        'SaveTool
        '
        Me.SaveTool.Name = "SaveTool"
        Me.SaveTool.Size = New System.Drawing.Size(152, 22)
        Me.SaveTool.Text = "Save"
        '
        'SaveAsTool
        '
        Me.SaveAsTool.Name = "SaveAsTool"
        Me.SaveAsTool.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsTool.Text = "Save As"
        '
        'CloseTool
        '
        Me.CloseTool.Name = "CloseTool"
        Me.CloseTool.Size = New System.Drawing.Size(152, 22)
        Me.CloseTool.Text = "Close"
        '
        'EditTool
        '
        Me.EditTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStrip, Me.CopyToolStrip, Me.PasteTool, Me.DoTool, Me.UndoTool})
        Me.EditTool.Name = "EditTool"
        Me.EditTool.Size = New System.Drawing.Size(39, 20)
        Me.EditTool.Text = "Edit"
        '
        'CutToolStrip
        '
        Me.CutToolStrip.Name = "CutToolStrip"
        Me.CutToolStrip.Size = New System.Drawing.Size(103, 22)
        Me.CutToolStrip.Text = "Cut"
        '
        'CopyToolStrip
        '
        Me.CopyToolStrip.Name = "CopyToolStrip"
        Me.CopyToolStrip.Size = New System.Drawing.Size(103, 22)
        Me.CopyToolStrip.Text = "Copy"
        '
        'PasteTool
        '
        Me.PasteTool.Name = "PasteTool"
        Me.PasteTool.Size = New System.Drawing.Size(103, 22)
        Me.PasteTool.Text = "Paste"
        '
        'DoTool
        '
        Me.DoTool.Name = "DoTool"
        Me.DoTool.Size = New System.Drawing.Size(103, 22)
        Me.DoTool.Text = "Do"
        '
        'UndoTool
        '
        Me.UndoTool.Name = "UndoTool"
        Me.UndoTool.Size = New System.Drawing.Size(103, 22)
        Me.UndoTool.Text = "Undo"
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
        Me.FindTool.Name = "FindTool"
        Me.FindTool.Size = New System.Drawing.Size(144, 22)
        Me.FindTool.Text = "Find"
        '
        'FindReplaceTool
        '
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
        Me.AboutTool.Name = "AboutTool"
        Me.AboutTool.Size = New System.Drawing.Size(107, 22)
        Me.AboutTool.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(686, 25)
        Me.ToolStrip1.TabIndex = 1
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
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'texto
        '
        Me.texto.Location = New System.Drawing.Point(0, 52)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(685, 516)
        Me.texto.TabIndex = 2
        Me.texto.Text = ""
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 569)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Notepadd++"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents texto As RichTextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
