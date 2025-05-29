Public Class stocks
    Sub xreset()
        txtname.ReadOnly = False
        txtbuy.ReadOnly = False
        txtsell.ReadOnly = False
        txtname.Text = ""
        txtbuy.Text = ""
        txtsell.Text = ""
        txtname.ReadOnly = True
        txtbuy.ReadOnly = True
        txtsell.ReadOnly = True
    End Sub
    Private stockstxt As String
    Private id As String
    Private Sub stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xGridview(dgvstocks)
        xLoadDataToGridview("Stocks", "SELECT * FROM Stocks", dgvstocks)
        dgvstocks.Columns(0).HeaderText = "Product Name"
        dgvstocks.Columns(1).HeaderText = "Buying Price (LKR)"
        dgvstocks.Columns(2).HeaderText = "Selling Price (LKR)"
        dgvstocks.Columns(3).HeaderText = "Current Stock"
        dgvstocks.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvstocks.Columns(4).Visible = False
    End Sub

    Private Sub EditStockBut_Click(sender As Object, e As EventArgs) Handles EditStockBut.Click
        txtname.ReadOnly = False
        txtbuy.ReadOnly = False
        txtsell.ReadOnly = False
        txtname.Text = dgvstocks.Item(0, dgvstocks.CurrentRow.Index).Value
        txtbuy.Text = dgvstocks.Item(1, dgvstocks.CurrentRow.Index).Value
        txtsell.Text = dgvstocks.Item(2, dgvstocks.CurrentRow.Index).Value
        txtname.ReadOnly = True
        stockstxt = dgvstocks.Item(3, dgvstocks.CurrentRow.Index).Value.ToString()
        id = dgvstocks.Item(4, dgvstocks.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim Com As String
        Com = "SELECT * FROM Stocks WHERE Prod_Name LIKE '%" & txtsearch.Text & "%';"
        xLoadDataToGridview("Stocks", Com, dgvstocks)
    End Sub

    Private Sub butcancel_Click(sender As Object, e As EventArgs) Handles butcancel.Click
        xreset()

    End Sub

    Private Sub butsave_Click(sender As Object, e As EventArgs) Handles butsave.Click
        If Not txtname.Text = "" Then
            If txtbuy.Text = "" Then
                MsgBox("Please Enter Buying Price", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf txtsell.Text = "" Then
                MsgBox("Please Enter Selling Price", MsgBoxStyle.Exclamation, "Invalid Input")
            Else
                Dim values() As String = {txtbuy.Text, txtsell.Text, stockstxt}
                xUpdateDATA("Price_tbl", {"Unit_Price_Buy", "Unit_Price_Sell"}, values, "ID=" + id)
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")
                xLoadDataToGridview("Stocks", "SELECT * FROM Stocks", dgvstocks)
                xreset()
            End If
        End If
    End Sub
End Class