Public Class Selling_Rec

    Private Sub Selling_Rec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        todate.Value = Today.Date()

        xGridview(dgvsell)
        xLoadDataToGridview("sales_q", "SELECT * FROM sales_q", dgvsell)

        dgvsell.Columns(0).HeaderText = "ID"
        dgvsell.Columns(1).HeaderText = "Product Name"
        dgvsell.Columns(2).HeaderText = "Customer Name"
        dgvsell.Columns(3).HeaderText = "Unit Price (LKR)"
        dgvsell.Columns(4).HeaderText = "Quantity"
        dgvsell.Columns(5).HeaderText = "Total (LKR)"
        dgvsell.Columns(6).HeaderText = "Date of Transaction"
        dgvsell.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim Com As String = "SELECT * FROM sales_q WHERE "
        If radprod.Checked = True Then
            xLoadDataToGridview("sales_q", Com + "Prod_Name LIKE '%" + txtsearch.Text + "%';", dgvsell)
        Else
            xLoadDataToGridview("sales_q", Com + "Cust_Name LIKE '%" + txtsearch.Text + "%';", dgvsell)
        End If
    End Sub

    Private Sub frmdate_ValueChanged(sender As Object, e As EventArgs) Handles frmdate.ValueChanged
        Dim date1 As Date = frmdate.Value.ToShortDateString()
        Dim date2 As Date = todate.Value.ToShortDateString()
        xLoadDataToGridview("sales_q", "SELECT * FROM sales_q WHERE Date_of_Sale BETWEEN #" & date1 & "# AND #" & date2 & "#", dgvsell)
    End Sub

    Private Sub todate_ValueChanged(sender As Object, e As EventArgs) Handles todate.ValueChanged
        Dim date1 As Date = frmdate.Value.ToShortDateString()
        Dim date2 As Date = todate.Value.ToShortDateString()
        xLoadDataToGridview("sales_q", "SELECT * FROM sales_q WHERE Date_of_Sale BETWEEN #" & date1 & "# AND #" & date2 & "#", dgvsell)
    End Sub
End Class