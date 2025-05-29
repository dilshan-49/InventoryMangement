Public Class Main_Window

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ProductBut_Click(sender As Object, e As EventArgs) Handles ProductBut.Click
        prod.Show()
    End Sub

    Private Sub SuppliersBut_Click(sender As Object, e As EventArgs) Handles SuppliersBut.Click
        suppliers.Show()
    End Sub

    Private Sub TransButt_Click(sender As Object, e As EventArgs) Handles TransButt.Click
        Transactions.Show()
    End Sub

    Private Sub CustomerBut_Click(sender As Object, e As EventArgs) Handles CustomerBut.Click
        customers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim D As String
        D = MsgBox("Are You Sure Want to Exit", vbYesNo + vbQuestion, "Exit")
        If D = vbYes Then
            Me.Close()
            Application.Exit()
        Else
            Exit Sub
        End If
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim F As String
        F = MsgBox("Are You Sure Want to Switch User", vbYesNo + vbQuestion, "Switch User")
        If F = vbYes Then
            Me.Hide()
            Login.Show()


        Else
            Exit Sub
        End If
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.Date.ToString("yyyy-MM-dd") + " | " + TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Main_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblfooter.Text = ChrW(169) & " " & Now.Year & " All rights are reserved by CodeZ solutions"
    End Sub

    Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click

    End Sub
End Class