Imports System.Windows.Forms
Imports Awesomium.Core

Public Class PageInfoDialog

    Public Sub New(pagetitle As String, pageurl As String, pageinfo As WebPageInfo, historycount As Integer, img As Image)
        InitializeComponent()

        title.Text = pagetitle
        url.Text = pageurl

        Select Case pageinfo.SecurityStatus
            Case SecurityStatus.Authenticated
                securitystat.Text = "This page is securly connected with HTTPS and its identity has been verified by " + pageinfo.CertIssuer + "."
            Case SecurityStatus.AuthenticationBroken
                securitystat.Text = "This page is supposed to be secure, but there were errors in HTTPS transfer."
            Case SecurityStatus.Unauthenticated
                securitystat.Text = "This page has not been authenticated using HTTPS."
            Case SecurityStatus.Unknown
                securitystat.Text = "The identity of this page is unknown!"

        End Select

        Select Case pageinfo.ContentStatus
            Case ContentStatusFlags.Normal
                contentstat.Text = "This page contains no insecure content."
            Case ContentStatusFlags.DisplayedInsecureContent
                contentstat.Text = "This page is connected with HTTPS but has displayed HTTP resources."
            Case ContentStatusFlags.RanInsecureContent
                contentstat.Text = "This page is connected with HTTPS but has ran HTTP scripts. Be careful!"
        End Select

        favicon.Image = img
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
