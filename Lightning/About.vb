Public Class About

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.dropbox.com/s/102dhrnwvcxuxxy/GDAutoUpdate.txt?dl=0")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            Label4.Text = ("You have the current version!")
        Else
            Dim programPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "setup.exe"
            IO.File.Delete("setup.exe")
            Label4.Text = ("    New version available!")
            My.Computer.Network.DownloadFile("https://spideroak.com/share/IVWWS3C7KNQXSYLINE/LightningShareroom/c%3A/Users/emils_000/Documents/SpiderOak%20Hive/LightningShareroom/Setup.exe", "setup.exe")
            Shell("setup.exe")
        End If
        If FileInUse("setup.exe") Then

        Else : IO.File.Delete("setup.exe")


        End If

    End Sub
    Public Function FileInUse(ByVal sFile As String) As Boolean
        If System.IO.File.Exists(sFile) Then
            Try
                Dim F As Short = FreeFile()
                FileOpen(F, sFile, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
                FileClose(F)
            Catch
                Return True

            End Try
        End If
    End Function

End Class