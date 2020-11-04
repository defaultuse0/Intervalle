Public Class StartScreen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Quest.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.NoWelcome = 0
            My.Settings.Save()
            My.Settings.Reload()
            StartSettings.Show()
            Me.Close()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Info.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.NoWelcome = 0 Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub
End Class
