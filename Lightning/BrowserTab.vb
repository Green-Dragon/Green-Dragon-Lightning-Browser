Imports Awesomium
Imports Awesomium.Core
Imports Awesomium.Windows.Forms
Imports System.IO
Imports System.Text
Imports System.Net

Public Class BrowserTab

    Public myfrm As Form1
    Public mytabcontrol As TabControl
    Public mytabpage As TabPage

    Public pginfo As WebPageInfo
    Public currentfavicon As Image = Nothing

#Region "Main Subs"

    Public Sub New()
        InitializeComponent()
        myfrm = Nothing
        mytabcontrol = Nothing
        Me.Enabled = False
    End Sub

    Public Sub New(frm As Form1, tc As TabControl, tp As TabPage)
        InitializeComponent()

        myfrm = frm
        mytabcontrol = tc
        mytabpage = tp

        mytabpage.Text = "Loading..."
        Try
            browser.Source = New Uri(My.Settings.Homepage)
            'Goes to homepage
        Catch ex As UriFormatException
            browser.Source = New Uri("http://" + My.Settings.Homepage)
            'If the setting doesn't contain http then we fix that
        End Try

    End Sub

    Public Sub New(frm As Form1, tc As TabControl, tp As TabPage, url As String)
        InitializeComponent()

        myfrm = frm
        mytabcontrol = tc
        mytabpage = tp

        mytabpage.Text = "Loading..."
        Try
            browser.Source = New Uri(url)
            'Goes to homepage
        Catch ex As UriFormatException
            browser.Source = New Uri("http://" + url)
            'If the setting doesn't contain http then we fix that
        End Try
    End Sub

    Private Sub BrowserTab_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshFavorites() 'back to this
        If urlbar.Text.StartsWith("http://") Then
            pageinfo.Image = My.Resources.lockyellow
        End If
    End Sub
#End Region

#Region "Favorites"

    Private Sub fav_Click(sender As Object, e As EventArgs) Handles fav.Click
        AddFav(browser.Source.ToString) 'thats what this does. the url is the browsers.Source.tostring property
    End Sub

    Public Sub AddFav(url As String) 'Adds a favorite by url and not title (yet)

        Dim infav As Boolean = False 'checks to see if the url is already in favorites
        Dim stringinfav As String = "" 'set to the item that is infavorites (if any)
        For i = 0 To My.Settings.Favorites.Count - 1
            If My.Settings.Favorites(i).Contains(url) Then
                infav = True
                stringinfav = My.Settings.Favorites(i)
            End If
        Next

        If Not infav Then 'Add favorite
            Dim title As String = InputBox("What do you want to name the favorite as? " + url + "?", "Favorites", mytabpage.Text) 'ask for title
            If title = "" Then
                Exit Sub
            End If
            My.Settings.Favorites.Add(title.Replace("@", "").Replace("|", "") + "@" + url) 'Add title(without @ or | ) + "@" + url 
            My.Settings.Save()
            fav.Image = My.Resources.NewStarYellow 'star is yellow because this is now a favorite
        Else 'Remove favorite
            Dim usure = MsgBox("Would you like to remove this site from your Favorites?", MsgBoxStyle.YesNo)
            If usure = MsgBoxResult.Yes Then 'self-explanatory
                My.Settings.Favorites.Remove(stringinfav)
                My.Settings.Save()
                fav.Image = My.Resources.NewStar
            End If
        End If
        For Each item As TabPage In myfrm.TabControl1.TabPages
            CType(item.Controls(0), BrowserTab).RefreshFavorites() 'Update favorites bar again
        Next
    End Sub

    Public Sub AddFav(title As String, url As String)
        If Not My.Settings.Favorites.Contains(title + "@" + url) Then 'checks favorites for duplicate
            My.Settings.Favorites.Add(title.Replace("@", "").Replace("|", "") + "@" + url)
            My.Settings.Save()
            fav.Image = My.Resources.NewStarYellow
        Else 'there is a duplicate :(
            Dim usure = MsgBox("Would you like to remove this site from your Favorites?", MsgBoxStyle.YesNo)
            If usure = MsgBoxResult.Yes Then
                My.Settings.Favorites.Remove(title.Replace("@", "").Replace("|", "") + "@" + url)
                My.Settings.Save()
                fav.Image = My.Resources.NewStar
            End If
        End If
        For Each item As TabPage In myfrm.TabControl1.TabPages
            CType(item.Controls(0), BrowserTab).RefreshFavorites()
        Next
    End Sub

    Public Sub RefreshFavorites()
        favbar.Items.Clear() 'clears favorites bar

        If My.Settings.Favorites.Count > 0 Then
            For i = 0 To My.Settings.Favorites.Count - 1
                'for each item in favorites, it creates a Favorite and adds it to the favbar
                Dim f As New Favorite(My.Settings.Favorites(i), myfrm, Me)
                favbar.Items.Add(f)
            Next
        Else
            'there are no favorites :(
            favbar.Items.Add(New ToolStripLabel("Add favorites by clicking the star button!", My.Resources.NewStarYellow))
        End If
    End Sub

#End Region

#Region "Toolbar Subs"

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Try
            browser.Source = New Uri(My.Settings.Homepage)
            'Goes to homepage
        Catch ex As UriFormatException
            browser.Source = New Uri("http://" + My.Settings.Homepage)
            'If the setting doesn't contain http then we fix that
        End Try
    End Sub


    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        browser.GoBack()
        'Navigates backward
    End Sub

    Private Sub forward_Click(sender As Object, e As EventArgs) Handles forward.Click
        browser.GoForward()
        'Navigates forward
    End Sub

    Private Sub refreshpage_Click(sender As Object, e As EventArgs) Handles refreshpage.Click
        If browser.IsLoading Then
            browser.Stop() 'if page is navigating
        Else
            browser.Reload(True)
        End If
    End Sub

    Private Sub urlbar_KeyUp(sender As Object, e As KeyEventArgs) Handles urlbar.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim t As String = urlbar.Text
            With t
                If Not (.Contains(" ") Or .Contains(".com") Or .Contains(".co") Or .Contains(".ca") Or .Contains(".tk") Or .Contains(".net") Or .Contains(".org") Or .Contains(".gov") Or
                              .Contains(".edu") Or .Contains(".mil") Or .Contains(".us") Or .Contains(".info") Or
                              .Contains(".tel") Or .Contains(".travel") Or .Contains(".k12") Or .Contains(".sc") Or .Contains("file:///") Or .StartsWith("http://") Or .StartsWith("https://") Or .StartsWith("file:///")) Then

                    Dim searchlink As String = GoogleSearchURL(t, My.Settings.SearchEngine)
                    browser.Source = New Uri(searchlink)
                Else
                    If .Contains("vb.net") Then
                        Dim searchlink As String = GoogleSearchURL(t, My.Settings.SearchEngine)
                        browser.Source = New Uri(searchlink)
                        Exit Sub
                    End If
                    Try
                        browser.Source = New Uri(t)
                    Catch ex As UriFormatException
                        Try
                            browser.Source = New Uri("http://" + t)
                        Catch ext As UriFormatException
                            browser.Source = New Uri(GoogleSearchURL(t, My.Settings.SearchEngine))
                        End Try
                    End Try
                End If
            End With
            e.SuppressKeyPress = True
        End If
    End Sub

    Public Function GoogleSearchURL(term As String, engine As String) As String
        Return engine + term
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pageinfo.Click
        OpenPageInfo()
    End Sub

    Public Sub OpenPageInfo()
        Dim p As New PageInfoDialog(browser.Title, browser.Source.ToString, pginfo, 0, currentfavicon)
        p.ShowDialog()
        p.BringToFront()
    End Sub
#End Region

#Region "Menu Subs"
    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click 'shows menu
        menudrop.Show(Control.MousePosition)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click 'Closes application
        WebCore.DestroyUnwrappedViews()
        Application.Exit()
    End Sub

    Private Sub NewTAbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTAbToolStripMenuItem.Click 'Adds tab
        myfrm.AddTab()
    End Sub
    Private Sub NewTAbToolStripMenuItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Control + Keys.T Then
            myfrm.AddTab()
        End If
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click 'Closes current tab
        mytabcontrol.TabPages.Remove(mytabpage)
        If mytabcontrol.TabPages.Count = 0 Then
            myfrm.AddTab()
        End If
        Me.Dispose()
    End Sub
    Private Sub CloseTabToolStripMenuItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Control + Keys.Q Then
            mytabcontrol.TabPages.Remove(mytabpage)
            If mytabcontrol.TabPages.Count = 0 Then
                myfrm.AddTab()
            End If
            Me.Dispose()
        End If
    End Sub

    Private Sub PageInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageInformationToolStripMenuItem.Click 'Opens page information window
        OpenPageInfo()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click 'Opens history window
        Dim h As New History
        h.ShowDialog()
        h.BringToFront()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click 'Opens settings window
        Dim s As New Settings
        s.ShowDialog()
        s.BringToFront()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click 'Opens about box
        Dim a As New About
        a.ShowDialog()
    End Sub

    Private Sub DownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadsToolStripMenuItem.Click 'Shows downloads bar
        If myfrm.Downloadsbar.Items.Count > 2 Then
            myfrm.Downloadsbar.Visible = True
        Else
            MsgBox("There are no downloads!")
        End If
    End Sub

    Private Sub DeveloperToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperToolsToolStripMenuItem.Click 'Opens devtools window
        Dim d As New DevTools(browser.Source.ToString)
        d.ShowDialog()
    End Sub


#End Region

#Region "Browser Events"

    Private Sub browser_AddressChanged(sender As Object, e As UrlEventArgs) Handles browser.AddressChanged
        If Not urlbar.Focused Then
            urlbar.Text = e.Url.ToString 'Change urlbar text
        End If
    End Sub

    Private Sub browser_Crashed(sender As Object, e As CrashedEventArgs) Handles browser.Crashed
        browser.Reload(True)  'Reload the crashed browser
    End Sub

    Private Sub browser_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles browser.LoadingFrame
        favicon.Image = My.Resources.throbber
        refreshpage.Image = My.Resources.Stop_Icon
    End Sub

    Private Sub browser_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles browser.LoadingFrameComplete
        LoadingAction()

    End Sub


    Public Sub LoadingAction()
        mytabpage.Text = browser.Title 'Change tab text to title
        urlbar.Text = browser.Source.ToString 'Change urlbar text to URL

        refreshpage.Image = My.Resources.Refresh_Icon

        back.Enabled = browser.CanGoBack
        forward.Enabled = browser.CanGoForward

        If My.Settings.History.Count > 0 Then
            If Not My.Settings.History(0) = browser.Source.ToString Then 'Prevent adding multiple history for multiple event firings
                My.Settings.History.Insert(0, browser.Source.ToString)
            End If
        Else
            My.Settings.History.Insert(0, browser.Source.ToString)
        End If


        For i = 0 To My.Settings.Favorites.Count - 1
            If My.Settings.Favorites(i).Contains(browser.Source.ToString) Then
                fav.Image = My.Resources.NewStarYellow 'URL is in favorites, so show yellow star
            Else
                fav.Image = My.Resources.NewStar 'URL is not in favorites, so show blank star
            End If
        Next

        If Not FaviconGrabber.IsBusy Then
            FaviconGrabber.RunWorkerAsync(browser.Source.ToString)
        End If
        browser.RequestPageInfo() 'Handled in browser_ShowPageInfo
        If back.Enabled = False Then
            back.Image = My.Resources.back_grey
        End If
        If forward.Enabled = False Then
            forward.Image = My.Resources.forward_grey
        End If
        If back.Enabled = True Then
            back.Image = My.Resources.Back_Icon
        End If
        If forward.Enabled = True Then
            forward.Image = My.Resources.Forward_Icon
        End If
        If urlbar.Text.StartsWith("http://") Then
            pageinfo.Image = My.Resources.lockyellow
        End If
        If urlbar.Text.StartsWith("https://") Then
            pageinfo.Image = My.Resources.secure
        End If
    End Sub

    Private Sub browser_ShowCreatedWebView(sender As Object, e As ShowCreatedWebViewEventArgs) Handles browser.ShowCreatedWebView
        myfrm.AddTab(e.TargetURL.ToString) 'Opens a new tab with the popup url
    End Sub

#Region "Page Info"
    Private Sub browser_ShowPageInfo(sender As Object, e As PageInfoEventArgs) Handles browser.ShowPageInfo
        pginfo = e.Info
    End Sub
#End Region

    Private Sub browser_TitleChanged(sender As Object, e As TitleChangedEventArgs) Handles browser.TitleChanged
        mytabpage.Text = e.Title ' Changes text on tab
    End Sub
#End Region

#Region "Async Operations"

    Public Function GetFavicon(url As String) As Image
        Dim fav As Image = Nothing
        If My.Computer.Network.IsAvailable Then
            Dim request As HttpWebRequest = WebRequest.Create("http://www.google.com/s2/favicons?domain=" + url)
            request.Timeout = 2000
            Dim response As HttpWebResponse = request.GetResponse
            Dim stream As Stream = response.GetResponseStream
            fav = Image.FromStream(stream)
            If fav Is Nothing Then
                fav = My.Resources.globe
            End If
        Else
            fav = My.Resources.globe
        End If
        Return fav
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FaviconGrabber.DoWork
        e.Result = GetFavicon(e.Argument) ' when it is told to start
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles FaviconGrabber.RunWorkerCompleted
        currentfavicon = e.Result ' from DoWork event
        favicon.Image = currentfavicon
    End Sub

#End Region









    Private Sub urlbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles urlbar.Click
        urlbar.SelectAll()
    End Sub


End Class
