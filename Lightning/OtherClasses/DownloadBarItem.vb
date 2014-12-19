Imports Awesomium.Core

Public Class DownloadBarItem
    Inherits ToolStripSplitButton


    Public WithEvents mydownload As DownloadItem

    Public WithEvents open As New ToolStripMenuItem("Open") With {.Enabled = False}
    Public WithEvents showfold As New ToolStripMenuItem("Show in Folder") With {.Enabled = False}
    Public WithEvents cancel As New ToolStripMenuItem("Cancel")



    Public Sub New(ditem As DownloadItem)
        Me.Image = My.Resources.throbber
        mydownload = ditem

        DropDownItems.AddRange(New ToolStripItem() {open, showfold, New ToolStripSeparator, cancel})
    End Sub

    Private Sub mydownload_Canceled(sender As Object, e As EventArgs) Handles mydownload.Canceled
        Me.Text = "Canceled - " + mydownload.FileName
    End Sub

    Private Sub mydownload_Completed(sender As Object, e As EventArgs) Handles mydownload.Completed
        Me.Text = mydownload.FileName
        open.Enabled = True
        showfold.Enabled = True
        cancel.Enabled = False

        Try
            Me.Image = Icon.ExtractAssociatedIcon(mydownload.SavePath).ToBitmap.Clone
        Catch ex As Exception
            Me.Image = My.Resources.globe
        End Try
    End Sub

    Private Sub mydownload_ProgressChanged(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mydownload.ProgressChanged 'progress changed
        Me.Text = mydownload.Progress.ToString + "% - " + mydownload.FileName
    End Sub

    Private Sub DownloadBarItem_ButtonClick(sender As Object, e As EventArgs) Handles Me.ButtonClick, open.Click 'button is clicked or open is clicked
        If mydownload.CanOpenDownloadedFile Then
            mydownload.OpenDownloadedFile()
        End If
    End Sub

    Private Sub showfold_Click(sender As Object, e As EventArgs) Handles showfold.Click 'openfolder is clicked
        If mydownload.CanOpenDownloadedFileFolder Then
            mydownload.OpenDownloadedFileFolder()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click 'cancel button is clicked
        If mydownload.CanCancel Then
            mydownload.Cancel()
        End If
    End Sub
End Class
