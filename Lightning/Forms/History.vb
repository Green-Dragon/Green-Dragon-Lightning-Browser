Public Class History

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        My.Settings.History.Clear() 'self explanatory
        My.Settings.Save()
        GetHistory()
    End Sub

    Public Sub GetHistory() Handles MyBase.Load
        ListBox1.Items.Clear()
        For i = 0 To My.Settings.History.Count - 1
            ListBox1.Items.Add(My.Settings.History(i))
        Next
    End Sub


End Class