Imports System.ComponentModel

Public Class RSODvb
    Private Sub RSODvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
    End Sub

    Private Sub RSODvb_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Close()
    End Sub
End Class