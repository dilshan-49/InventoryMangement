Public Class Main_Window

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSales.CellContentClick

    End Sub

    Private Sub Main_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xLoadDataToGridview("Product_tbl", " ", dgvSales)
    End Sub
End Class