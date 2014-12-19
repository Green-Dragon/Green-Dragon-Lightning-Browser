<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowserTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim WebPreferences1 As Awesomium.Core.WebPreferences = New Awesomium.Core.WebPreferences(True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserTab))
        Me.urlbar = New System.Windows.Forms.TextBox()
        Me.favbar = New System.Windows.Forms.ToolStrip()
        Me.menudrop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewTAbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeveloperToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSessionProvider1 = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.browser = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.FaviconGrabber = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.URLbarpanel = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fav = New System.Windows.Forms.PictureBox()
        Me.pageinfo = New System.Windows.Forms.PictureBox()
        Me.favicon = New System.Windows.Forms.PictureBox()
        Me.home = New System.Windows.Forms.PictureBox()
        Me.refreshpage = New System.Windows.Forms.PictureBox()
        Me.forward = New System.Windows.Forms.PictureBox()
        Me.back = New System.Windows.Forms.PictureBox()
        Me.menu = New System.Windows.Forms.PictureBox()
        Me.menudrop.SuspendLayout()
        Me.URLbarpanel.SuspendLayout()
        CType(Me.fav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pageinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshpage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'urlbar
        '
        Me.urlbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.urlbar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.urlbar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.urlbar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.urlbar.Location = New System.Drawing.Point(32, 4)
        Me.urlbar.Name = "urlbar"
        Me.urlbar.Size = New System.Drawing.Size(525, 20)
        Me.urlbar.TabIndex = 2
        '
        'favbar
        '
        Me.favbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.favbar.AutoSize = False
        Me.favbar.BackColor = System.Drawing.Color.White
        Me.favbar.Dock = System.Windows.Forms.DockStyle.None
        Me.favbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.favbar.Location = New System.Drawing.Point(0, 36)
        Me.favbar.Name = "favbar"
        Me.favbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.favbar.Size = New System.Drawing.Size(809, 25)
        Me.favbar.TabIndex = 3
        Me.favbar.Text = "ToolStrip1"
        '
        'menudrop
        '
        Me.menudrop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTAbToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.ToolStripSeparator1, Me.DeveloperToolsToolStripMenuItem, Me.PageInformationToolStripMenuItem, Me.ToolStripSeparator2, Me.HistoryToolStripMenuItem, Me.DownloadsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator3, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.menudrop.Name = "menudrop"
        Me.menudrop.Size = New System.Drawing.Size(167, 220)
        '
        'NewTAbToolStripMenuItem
        '
        Me.NewTAbToolStripMenuItem.Name = "NewTAbToolStripMenuItem"
        Me.NewTAbToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewTAbToolStripMenuItem.Text = "New Tab"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'DeveloperToolsToolStripMenuItem
        '
        Me.DeveloperToolsToolStripMenuItem.Name = "DeveloperToolsToolStripMenuItem"
        Me.DeveloperToolsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DeveloperToolsToolStripMenuItem.Text = "Developer Tools"
        '
        'PageInformationToolStripMenuItem
        '
        Me.PageInformationToolStripMenuItem.Name = "PageInformationToolStripMenuItem"
        Me.PageInformationToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PageInformationToolStripMenuItem.Text = "Page Information"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'DownloadsToolStripMenuItem
        '
        Me.DownloadsToolStripMenuItem.Name = "DownloadsToolStripMenuItem"
        Me.DownloadsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DownloadsToolStripMenuItem.Text = "Downloads"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(163, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WebSessionProvider1
        '
        Me.WebSessionProvider1.DataPath = "Cache"
        WebPreferences1.JavascriptViewChangeSource = False
        WebPreferences1.JavascriptViewEvents = False
        WebPreferences1.JavascriptViewExecute = False
        WebPreferences1.SmoothScrolling = True
        Me.WebSessionProvider1.Preferences = WebPreferences1
        Me.WebSessionProvider1.Views.Add(Me.browser)
        '
        'browser
        '
        Me.browser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.browser.Location = New System.Drawing.Point(0, 61)
        Me.browser.NavigationInfo = Awesomium.Core.NavigationInfo.None
        Me.browser.Size = New System.Drawing.Size(809, 423)
        Me.browser.TabIndex = 11
        '
        'FaviconGrabber
        '
        Me.FaviconGrabber.WorkerReportsProgress = True
        Me.FaviconGrabber.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(3, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 1)
        Me.Panel1.TabIndex = 9
        '
        'URLbarpanel
        '
        Me.URLbarpanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URLbarpanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.URLbarpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.URLbarpanel.Controls.Add(Me.fav)
        Me.URLbarpanel.Controls.Add(Me.pageinfo)
        Me.URLbarpanel.Controls.Add(Me.favicon)
        Me.URLbarpanel.Controls.Add(Me.urlbar)
        Me.URLbarpanel.Location = New System.Drawing.Point(147, 3)
        Me.URLbarpanel.Name = "URLbarpanel"
        Me.URLbarpanel.Size = New System.Drawing.Size(623, 30)
        Me.URLbarpanel.TabIndex = 10
        '
        'fav
        '
        Me.fav.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fav.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fav.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fav.Image = Global.GreenDragonLightning.My.Resources.Resources.NewStar
        Me.fav.Location = New System.Drawing.Point(592, 4)
        Me.fav.Name = "fav"
        Me.fav.Size = New System.Drawing.Size(26, 20)
        Me.fav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fav.TabIndex = 4
        Me.fav.TabStop = False
        Me.ToolTip1.SetToolTip(Me.fav, "Add or remove Favorite")
        '
        'pageinfo
        '
        Me.pageinfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pageinfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pageinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pageinfo.Image = CType(resources.GetObject("pageinfo.Image"), System.Drawing.Image)
        Me.pageinfo.Location = New System.Drawing.Point(563, 4)
        Me.pageinfo.Name = "pageinfo"
        Me.pageinfo.Size = New System.Drawing.Size(25, 20)
        Me.pageinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pageinfo.TabIndex = 6
        Me.pageinfo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pageinfo, "View page Security")
        '
        'favicon
        '
        Me.favicon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.favicon.BackColor = System.Drawing.Color.WhiteSmoke
        Me.favicon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.favicon.Image = Global.GreenDragonLightning.My.Resources.Resources.globe
        Me.favicon.Location = New System.Drawing.Point(3, 4)
        Me.favicon.Name = "favicon"
        Me.favicon.Size = New System.Drawing.Size(20, 20)
        Me.favicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.favicon.TabIndex = 8
        Me.favicon.TabStop = False
        '
        'home
        '
        Me.home.BackColor = System.Drawing.Color.White
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.Image = CType(resources.GetObject("home.Image"), System.Drawing.Image)
        Me.home.Location = New System.Drawing.Point(111, 3)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(30, 30)
        Me.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.home.TabIndex = 1
        Me.home.TabStop = False
        Me.ToolTip1.SetToolTip(Me.home, "Go to the Homepage")
        '
        'refreshpage
        '
        Me.refreshpage.BackColor = System.Drawing.Color.White
        Me.refreshpage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshpage.Image = CType(resources.GetObject("refreshpage.Image"), System.Drawing.Image)
        Me.refreshpage.Location = New System.Drawing.Point(75, 3)
        Me.refreshpage.Name = "refreshpage"
        Me.refreshpage.Size = New System.Drawing.Size(30, 30)
        Me.refreshpage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.refreshpage.TabIndex = 1
        Me.refreshpage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.refreshpage, "Refresh Page")
        '
        'forward
        '
        Me.forward.BackColor = System.Drawing.Color.White
        Me.forward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forward.Image = CType(resources.GetObject("forward.Image"), System.Drawing.Image)
        Me.forward.Location = New System.Drawing.Point(39, 3)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(30, 30)
        Me.forward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.forward.TabIndex = 1
        Me.forward.TabStop = False
        Me.ToolTip1.SetToolTip(Me.forward, "Go Forward")
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.White
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.Location = New System.Drawing.Point(3, 3)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(30, 30)
        Me.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.back.TabIndex = 1
        Me.back.TabStop = False
        Me.ToolTip1.SetToolTip(Me.back, "Go Back")
        '
        'menu
        '
        Me.menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu.BackColor = System.Drawing.Color.White
        Me.menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu.Image = CType(resources.GetObject("menu.Image"), System.Drawing.Image)
        Me.menu.Location = New System.Drawing.Point(776, 3)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(30, 30)
        Me.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.menu.TabIndex = 0
        Me.menu.TabStop = False
        Me.ToolTip1.SetToolTip(Me.menu, "Menu")
        '
        'BrowserTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.URLbarpanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.favbar)
        Me.Controls.Add(Me.home)
        Me.Controls.Add(Me.refreshpage)
        Me.Controls.Add(Me.forward)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.menu)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "BrowserTab"
        Me.Size = New System.Drawing.Size(809, 484)
        Me.menudrop.ResumeLayout(False)
        Me.URLbarpanel.ResumeLayout(False)
        Me.URLbarpanel.PerformLayout()
        CType(Me.fav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pageinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshpage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents menu As System.Windows.Forms.PictureBox
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents forward As System.Windows.Forms.PictureBox
    Friend WithEvents refreshpage As System.Windows.Forms.PictureBox
    Friend WithEvents home As System.Windows.Forms.PictureBox
    Friend WithEvents urlbar As System.Windows.Forms.TextBox
    Friend WithEvents favbar As System.Windows.Forms.ToolStrip
    Friend WithEvents fav As System.Windows.Forms.PictureBox
    Friend WithEvents menudrop As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewTAbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pageinfo As System.Windows.Forms.PictureBox
    Friend WithEvents WebSessionProvider1 As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents DeveloperToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaviconGrabber As System.ComponentModel.BackgroundWorker
    Friend WithEvents favicon As System.Windows.Forms.PictureBox
    Friend WithEvents PageInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents URLbarpanel As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents browser As Awesomium.Windows.Forms.WebControl

End Class
