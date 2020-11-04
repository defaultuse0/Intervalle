Public Class Info
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Label3.Text = "v0.2 Beta" Then
            Label3.Text = "Nope. immer noch die gleiche Version"
        Else
            Label3.Text = "v0.2 Beta"
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://github.com/defaultuse0/Intervalle")
    End Sub
End Class