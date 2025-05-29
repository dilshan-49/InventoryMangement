Public Class Purchase_Rec

    Private Sub Purchase_Rec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        todate.Value = Today.Date()
        xGridview(dgvpurchase)
        xLoadDataToGridview("purchase_q", "SELECT * FROM purchase_q", dgvpurchase)

        dgvpurchase.Columns(0).HeaderText = "ID"
        dgvpurchase.Columns(1).HeaderText = "Product Name"
        dgvpurchase.Columns(2).HeaderText = "Supplier Name"
        dgvpurchase.Columns(3).HeaderText = "Unit Price (LKR)"
        dgvpurchase.Columns(4).HeaderText = "Quantity"
        dgvpurchase.Columns(5).HeaderText = "Total (LKR)"
        dgvpurchase.Columns(6).HeaderText = "Date of Transaction"
        dgvpurchase.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub frmdate_ValueChanged(sender As Object, e As EventArgs) Handles frmdate.ValueChanged
        Dim date1 As Date = frmdate.Value.ToShortDateString()
        Dim date2 As Date = todate.Value.ToShortDateString()
        xLoadDataToGridview("purchase_q", "SELECT * FROM purchase_q WHERE Date_of_Purchase BETWEEN #" & date1 & "# AND #" & date2 & "#", dgvpurchase)

    End Sub

    Private Sub todate_ValueChanged(sender As Object, e As EventArgs) Handles todate.ValueChanged
        Dim date1 As Date = frmdate.Value.ToShortDateString()
        Dim date2 As Date = todate.Value.ToShortDateString()
        xLoadDataToGridview("purchase_q", "SELECT * FROM purchase_q WHERE Date_of_Purchase BETWEEN #" & date1 & "# AND #" & date2 & "#", dgvpurchase)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvpurchase_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpurchase.CellContentClick

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim Com As String = "SELECT * FROM purchase_q WHERE "
        If radprod.Checked = True Then
            xLoadDataToGridview("purchase_q", Com + "Prod_Name LIKE '%" + txtsearch.Text + "%';", dgvpurchase)
        Else
            xLoadDataToGridview("purchase_q", Com + "Sup_Name LIKE '%" + txtsearch.Text + "%';", dgvpurchase)
        End If
    End Sub
End Class