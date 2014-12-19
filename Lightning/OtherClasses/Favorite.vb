Imports System.ComponentModel
Imports System.Net
Imports System.IO

Public Class Favorite
    Inherits ToolStripSplitButton

    Public myfrm As Form1
    Public mytab As BrowserTab

    Public mytitle As String
    Public myurl As String
    Public myimg As Image

    Public WithEvents FavGrabber As New BackgroundWorker 'Same concept as BrowserTab - asyncronous favicon loading.


    Public WithEvents open As New ToolStripMenuItem("Open") 'Open dropdown item 
    Public WithEvents remove As New ToolStripMenuItem("Remove") 'Remove dropdown item

    Public Sub New(favitem As String, frm As Form1, tab As BrowserTab)
        mytitle = favitem.Split("@")(0)
        myurl = favitem.Split("@")(1)

        Me.Text = mytitle
        Me.ToolTipText = mytitle + Environment.NewLine + myurl

        myfrm = frm
        mytab = tab

        DropDownItems.AddRange(New ToolStripItem() {open, New ToolStripSeparator, remove})

        FavGrabber.RunWorkerAsync() 'starts favicon grabber
    End Sub

    Public Function GetFavicon(url As String) As Image
        Dim fav As Image = Nothing
        Try
            If My.Computer.Network.IsAvailable Then
                Dim request As HttpWebRequest = WebRequest.Create("http://www.google.com/s2/favicons?domain=" + url)
                request.Timeout = 2000
                Dim response As HttpWebResponse = request.GetResponse
                Dim stream As Stream = response.GetResponseStream
                fav = Drawing.Image.FromStream(stream)
                If fav Is Nothing Then
                    fav = My.Resources.globe
                End If
            Else
                fav = My.Resources.globe
            End If
        Catch ex As Exception
            fav = My.Resources.globe
        End Try
        Return fav
    End Function

    Private Sub FavGrabber_DoWork(sender As Object, e As DoWorkEventArgs) Handles FavGrabber.DoWork
        e.Result = GetFavicon(myurl)
    End Sub

    Private Sub FavGrabber_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles FavGrabber.RunWorkerCompleted
        Me.Image = e.Result
    End Sub

    Private Sub Favorite_Click(sender As Object, e As EventArgs) Handles Me.ButtonClick 'item is clicked
        If mytab.browser.IsLive Then
            mytab.browser.Source = New Uri(myurl)
        End If
    End Sub

    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click  'open is clicked
        mytab.browser.Source = New Uri(myurl)
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click 'remove is clicked
        My.Settings.Favorites.Remove(mytitle + "@" + myurl)
        My.Settings.Save()

        For Each item As TabPage In myfrm.TabControl1.TabPages
            CType(item.Controls(0), BrowserTab).RefreshFavorites()
        Next
    End Sub
End Class
