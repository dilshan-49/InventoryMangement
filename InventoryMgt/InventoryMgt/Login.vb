Public Class Login

    Private Sub butlogin_Click(sender As Object, e As EventArgs) Handles butlogin.Click
        Dim cond As String = "username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
        If xCheckPassword("username", cond) = True Then
            Main_Window.Show()
        Else
            MsgBox("Incorrect Username, Password Combination", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class
