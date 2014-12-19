<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Downloadsbar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1 = New System.Windows.Forms.CustomTabControl()
        Me.Downloadsbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Downloadsbar
        '
        Me.Downloadsbar.BackColor = System.Drawing.SystemColors.Control
        Me.Downloadsbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Downloadsbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Downloadsbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1})
        Me.Downloadsbar.Location = New System.Drawing.Point(0, 536)
        Me.Downloadsbar.Name = "Downloadsbar"
        Me.Downloadsbar.Size = New System.Drawing.Size(734, 25)
        Me.Downloadsbar.TabIndex = 1
        Me.Downloadsbar.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.GreenDragonLightning.My.Resources.Resources.Stop_Icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TabControl1
        '
        Me.TabControl1.DisplayStyle = System.Windows.Forms.TabStyle.Chrome
        '
        '
        '
        Me.TabControl1.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.TabControl1.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark
        Me.TabControl1.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.TabControl1.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray
        Me.TabControl1.DisplayStyleProvider.CloserColorActive = System.Drawing.Color.White
        Me.TabControl1.DisplayStyleProvider.FocusTrack = False
        Me.TabControl1.DisplayStyleProvider.HotTrack = True
        Me.TabControl1.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TabControl1.DisplayStyleProvider.Opacity = 1.0!
        Me.TabControl1.DisplayStyleProvider.Overlap = 16
        Me.TabControl1.DisplayStyleProvider.Padding = New System.Drawing.Point(7, 5)
        Me.TabControl1.DisplayStyleProvider.Radius = 16
        Me.TabControl1.DisplayStyleProvider.ShowTabCloser = True
        Me.TabControl1.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText
        Me.TabControl1.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark
        Me.TabControl1.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ItemSize = New System.Drawing.Size(150, 22)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(734, 561)
        Me.TabControl1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Downloadsbar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "Form1"
        Me.Text = "Green Dragon Lightning"
        Me.Downloadsbar.ResumeLayout(False)
        Me.Downloadsbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Downloadsbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControl1 As System.Windows.Forms.CustomTabControl

End Class
