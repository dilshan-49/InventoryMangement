Public Class Transactions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Transaction.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Purchase_Rec.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Selling_Rec.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.Date.ToString("yyyy-MM-dd") + " | " + TimeOfDay.ToString("h:mm:ss tt")

    End Sub

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblfooter.Text = ChrW(169) & " " & Now.Year & " All rights are reserved by CodeZ solutions"

    End Sub
End Class