Imports System.Runtime.InteropServices
Imports Awesomium.Core

Public Class Form1

#Region "Glass"

    Public Sub ShowGlass()
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 0
        margins.cxRightWidth = 0
        margins.cyTopHeight = 28
        margins.cyBottomHeight = 0
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
    End Sub

    Public Sub HideGlass()
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = 0
        margins.cxRightWidth = 0
        margins.cyTopHeight = 0
        margins.cyBottomHeight = 0
        Dim hwnd As IntPtr = Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)
    End Sub

    Private mExtendedFrameMargins As MARGINS

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure

    <DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

#End Region

#Region "Tabs and Startup"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowGlass()
        AddTab()

        If Not WebCore.IsInitialized Then
            WebCore.Initialize(New WebConfig With {.RemoteDebuggingPort = "9300"})

        End If

        AddHandler WebCore.Initialized, AddressOf OnInitWebCore
        AddHandler WebCore.Download, AddressOf OnDownload
        AddHandler WebCore.DownloadBegin, AddressOf OnDownloadBegin
    End Sub

    Public Sub AddTab()
        Dim tab As New TabPage
        Dim tabcntrl As New BrowserTab(Me, TabControl1, tab)
        tabcntrl.Dock = DockStyle.Fill

        tab.Controls.Add(tabcntrl)

        TabControl1.TabPages.Add(tab)
        TabControl1.SelectedTab = tab
    End Sub

    Public Sub AddTab(url As String)
        Dim tab As New TabPage
        Dim tabcntrl As New BrowserTab(Me, TabControl1, tab, url)
        tabcntrl.Dock = DockStyle.Fill

        tab.Controls.Add(tabcntrl)

        TabControl1.TabPages.Add(tab)
        TabControl1.SelectedTab = tab
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AddTab()
    End Sub

    Public Sub Me_Formclosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        WebCore.DestroyUnwrappedViews() 'Kill background views to shutdown properly
    End Sub
#End Region

#Region "Downloads"
    Public Sub OnInitWebCore()
        'empty, remember?
    End Sub

    Public Sub OnDownload(sender As Object, e As DownloadEventArgs)
        If Not My.Settings.AskDownload Then 'if you want to be asked where to save the file, this is skipped.
            e.Handled = True 'cancels savefiledialog
            e.SelectedFile = My.Settings.DownloadsPath + "\" + e.SuggestedFileName 'sets the filepath to the Setting and the download's name
        End If
    End Sub


    Public Sub OnDownloadBegin(sender As Object, e As DownloadBeginEventArgs)
        AddDownload(e.Info) 'e.info is a DownloadItem. we pass this into AddDownload.
    End Sub

    Public Sub AddDownload(item As DownloadItem)
        Dim d As New DownloadBarItem(item) 'this passes the item into a DownloadBarItem 
        Downloadsbar.Items.Add(d) 'Adds the item to the download bar
        Downloadsbar.Visible = True 'shows the downloads bar
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Downloadsbar.Visible = False 'little x-button closes the downloads bar
    End Sub

#End Region

End Class
