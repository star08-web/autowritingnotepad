Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loader_Tick(sender As Object, e As EventArgs) Handles loader.Tick
        If ProgressBar1.Value = 28 Then
            loader.Stop()
            ProgressBar1.Value = 0
            Me.Hide()
            RSODvb.Show()
        End If
        If ProgressBar1.Value = 1 Then
            RichTextBox1.Text = "i"
        End If
        If ProgressBar1.Value = 2 Then
            RichTextBox1.Text = "il"
        End If
        If ProgressBar1.Value = 3 Then
            RichTextBox1.Text = "il t"
        End If
        If ProgressBar1.Value = 4 Then
            RichTextBox1.Text = "il tu"
        End If
        If ProgressBar1.Value = 5 Then
            RichTextBox1.Text = "il tuo"
        End If
        If ProgressBar1.Value = 6 Then
            RichTextBox1.Text = "il tuo c"
        End If
        If ProgressBar1.Value = 7 Then
            RichTextBox1.Text = "il tuo co"
        End If
        If ProgressBar1.Value = 8 Then
            RichTextBox1.Text = "il tuo com"
        End If
        If ProgressBar1.Value = 9 Then
            RichTextBox1.Text = "il tuo comp"
        End If
        If ProgressBar1.Value = 10 Then
            RichTextBox1.Text = "il tuo compu"
        End If
        If ProgressBar1.Value = 11 Then
            RichTextBox1.Text = "il tuo comput"
        End If
        If ProgressBar1.Value = 12 Then
            RichTextBox1.Text = "il tuo compute"
        End If
        If ProgressBar1.Value = 13 Then
            RichTextBox1.Text = "il tuo computer"
        End If
        If ProgressBar1.Value = 14 Then
            RichTextBox1.Text = "il tuo computer è"
        End If
        If ProgressBar1.Value = 15 Then
            RichTextBox1.Text = "il tuo computer è h"
        End If
        If ProgressBar1.Value = 16 Then
            RichTextBox1.Text = "il tuo computer è ha"
        End If
        If ProgressBar1.Value = 17 Then
            RichTextBox1.Text = "il tuo computer è hac"
        End If
        If ProgressBar1.Value = 18 Then
            RichTextBox1.Text = "il tuo computer è hack"
        End If
        If ProgressBar1.Value = 19 Then
            RichTextBox1.Text = "il tuo computer è hacke"
        End If
        If ProgressBar1.Value = 20 Then
            RichTextBox1.Text = "il tuo computer è hacker"
        End If
        If ProgressBar1.Value = 21 Then
            RichTextBox1.Text = "il tuo computer è hackera"
        End If
        If ProgressBar1.Value = 22 Then
            RichTextBox1.Text = "il tuo computer è hackerat"
        End If
        If ProgressBar1.Value = 23 Then
            RichTextBox1.Text = "il tuo computer è hackerato"
        End If
        ProgressBar1.Value = ProgressBar1.Value + 1
    End Sub
End Class
