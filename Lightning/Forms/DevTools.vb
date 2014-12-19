Imports System.Net
Imports System.IO

Public Class DevTools

    Public myurl As String = ""

    Public Sub New(url As String)
        InitializeComponent()
        myurl = url

        GetSource()
        GetResources()

    End Sub

    Public Sub GetSource()
        If My.Computer.Network.IsAvailable Then ' if you have internet

            Try
                Dim request As HttpWebRequest = WebRequest.Create(myurl)
                request.Timeout = 5000
                Dim response As HttpWebResponse = request.GetResponse
                Dim stream As Stream = response.GetResponseStream
                Dim sr As New StreamReader(stream)

                FastColoredTextBox1.Text = sr.ReadToEnd 'put code in textbox
            Catch ex As Exception
                FastColoredTextBox1.Text = "Could not retrieve source!"
            End Try
        Else
            FastColoredTextBox1.Text = "Could not retrieve source!"
        End If
    End Sub

    Dim b As WebBrowser
    Public Sub GetResources()
        b = New WebBrowser
        b.ScriptErrorsSuppressed = True

        AddHandler b.DocumentCompleted, AddressOf PageDone

        b.Navigate(myurl)

    End Sub

    Public Sub PageDone()
        Try
            imglistbox.Items.Clear()
            linklistbox.Items.Clear()
            Try
                For Each item As HtmlElement In b.Document.Links
                    linklistbox.Items.Add(item.GetAttribute("href"))
                Next
            Catch ex As Exception
                linklistbox.Items.Add("Couldn't get links")
            End Try


            Try
                For Each item As HtmlElement In b.Document.Images
                    imglistbox.Items.Add(item.GetAttribute("src"))
                Next

            Catch ex As Exception
                imglistbox.Items.Add("Couldn't get images")
            End Try

        Catch ex As Exception
            Console.WriteLine("Error getting resources")
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imglistbox.SelectedIndexChanged
        PictureBox1.ImageLocation = imglistbox.SelectedItem 'sets pb image to the image from the selected link
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles linklistbox.SelectedIndexChanged
        TextBox1.Text = linklistbox.SelectedItem 'changes textbox text to selected link
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each frm As Form In Application.OpenForms
            If frm.Name = "Form1" Then
                CType(frm, Form1).AddTab(TextBox1.Text) 'adds tab with current textbox text
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(FastColoredTextBox1.Text) 'copies source to clipboard
    End Sub
End Class