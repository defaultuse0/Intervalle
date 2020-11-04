Public Class Quest
    Dim Picture As Integer
    Dim Score As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ConfirmQuit.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MessageBox.Show(Score)
        Me.Close()
    End Sub

    Private Sub Quest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile("Pictures\10.png")
        My.Settings.Score = 0
        Picture = 1
    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Randomize()
        Picture = CInt(Int((103 * Rnd()) + 1))
        Dim strPic As String = Str(Picture)
        PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("EasterEgg")
    End Sub

    Private Sub prim_Click(sender As Object, e As EventArgs) Handles prim.Click
        If Picture = "10" Or "11" Or "13" Or "14" Or "15" Or "16" Or "17" Or "18" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub klter_Click(sender As Object, e As EventArgs) Handles klter.Click
        If Picture = "4" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub klsek_Click(sender As Object, e As EventArgs) Handles klsek.Click
        If Picture = "20" Or "21" Or "22" Or "23" Or "24" Or "25" Or "27" Or "28" Or "29" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If

    End Sub

    Private Sub grter_Click(sender As Object, e As EventArgs) Handles grter.Click
        If Picture = "5" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub grsek_Click(sender As Object, e As EventArgs) Handles grsek.Click
        If Picture = "30" Or "31" Or "32" Or "33" Or "34" Or "35" Or "36" Or "37" Or "38" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub qua_Click(sender As Object, e As EventArgs) Handles qua.Click
        If Picture = "6" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub qui_Click(sender As Object, e As EventArgs) Handles qui.Click
        If Picture = "7" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub klsep_Click(sender As Object, e As EventArgs) Handles klsep.Click
        If Picture = "8" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub klsext_Click(sender As Object, e As EventArgs) Handles klsext.Click
        If Picture = "9" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub grsep_Click(sender As Object, e As EventArgs) Handles grsep.Click
        If Picture = "10" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub grsext_Click(sender As Object, e As EventArgs) Handles grsext.Click
        If Picture = "11" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub okt_Click(sender As Object, e As EventArgs) Handles okt.Click
        If Picture = "103" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub trito_Click(sender As Object, e As EventArgs) Handles trito.Click
        If Picture = "13" Then
            Score += 1
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        Else
            Score -= 1
            MessageBox.Show("Falsch! :(")
            Randomize()
            Picture = CInt(Int((103 * Rnd()) + 1))
            Dim strPic As String = Str(Picture)
            PictureBox1.Image = Image.FromFile("Pictures\" + Strings.Right(strPic, Len(strPic) - 1) + ".png")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = Score
    End Sub
End Class

