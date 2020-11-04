Public Class StartSettings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.NoWelcome = 1
            My.Settings.Save()
        Else
            My.Settings.NoWelcome = 0
            My.Settings.Save()
        End If
        StartScreen.Show()
        Me.Close()
    End Sub

    Private Sub StartSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.NoWelcome = 1 Then
            StartScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If My.Settings.NoWelcome = 0 Then
            CheckBox1.Checked = True
        End If
    End Sub
End Class