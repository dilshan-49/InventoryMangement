Public Class prod
    Sub LoadProd()
        xGridview(dgvprod)
        xLoadDataToGridview("product_q", "SELECT Prod_Code,Prod_Name,Prod_Category,Sup_Name FROM product_q", dgvprod)
        dgvprod.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvprod.Columns(0).HeaderText = "Product Code"
        dgvprod.Columns(1).HeaderText = "Product Name"
        dgvprod.Columns(2).HeaderText = "Category"
        dgvprod.Columns(3).HeaderText = "Supplier Name"
        reset()
    End Sub
    Sub reset()
        prodsearchtb.Clear()
        prodsearchtb.Focus()
        ProdIDTB.Clear()
        ProdNameTB.Clear()
        prodcatcmb.SelectedValue = vbEmpty
        Supcmb.SelectedValue = vbEmpty
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Main_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProd()
        xSearchComboBox(Supcmb, "Supplier_tbl", "Sup_Name", "Sup_ID", "")
        xSearchComboBox(prodcatcmb, "categories", "cat", "ID", "")
        lblfooter.Text = ChrW(169) & " " & Now.Year & " All rights are reserved by CodeZ solutions"
        Timer1.Start()
    End Sub

    Private Sub StockBut_Click(sender As Object, e As EventArgs) Handles StockBut.Click
        stocks.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub prodsearchtb_TextChanged(sender As Object, e As EventArgs) Handles prodsearchtb.TextChanged
        Dim Com As String
        Com = "SELECT Prod_Code,Prod_Name,Prod_Category,Sup_Name FROM product_q WHERE Prod_Name LIKE '%" & prodsearchtb.Text & "%';"
        xLoadDataToGridview("product_q", Com, dgvprod)
    End Sub

    Private Sub EditProd_Click(sender As Object, e As EventArgs) Handles EditProd.Click
        Dim prodid As String
        prodid = dgvprod.Item(0, dgvprod.CurrentRow.Index).Value
        xDeleteDATA("Product_tbl", "Prod_Code=" & prodid)
        xLoadDataToGridview("product_q", "SELECT Prod_Code,Prod_Name,Prod_Category,Sup_Name FROM product_q", dgvprod)
    End Sub

    Private Sub ResetProdBut_Click(sender As Object, e As EventArgs) Handles ResetProdBut.Click
        reset()
    End Sub

    Private Sub SaveProdBut_Click(sender As Object, e As EventArgs) Handles SaveProdBut.Click
        If ProdIDTB.Text = "" Then
            MsgBox("Please Enter Product Code", MsgBoxStyle.Exclamation, "Invalid Input")
        ElseIf ProdNameTB.Text = "" Then
            MsgBox("Please Enter Product Name", MsgBoxStyle.Exclamation, "Invalid Input")
        ElseIf prodcatcmb.SelectedValue = vbEmpty Then
            MsgBox("Please Select Product Category", MsgBoxStyle.Exclamation, "Invalid Input")
        ElseIf Supcmb.SelectedValue = "" Then
            MsgBox("Please Select Supplier", MsgBoxStyle.Exclamation, "Invalid Input")
        ElseIf txtpricebuy.Text = "" Then
            MsgBox("Please Enter Buying Price", MsgBoxStyle.Exclamation, "Invalid Input")
        ElseIf txtpricesell.Text = "" Then
            MsgBox("Please Enter Selling Price", MsgBoxStyle.Exclamation, "Invalid Input")


        Else
            '  Dim prodids As List(Of String)
            '  For Each row As DataGridViewRow In dgvprod.Rows
            'prodids.Add(row.Cells(0).Value.ToString())
            '  Next
            ' If Not prodids.Contains(ProdIDTB.Text) Then
            Dim values1() As String = {ProdIDTB.Text, ProdNameTB.Text, prodcatcmb.SelectedValue, Supcmb.SelectedValue}
            xSaveDATA("Product_tbl", "Prod_Code,Prod_Name,Prod_Category,Sup_ID", values1)
            Dim values2() As String = {ProdIDTB.Text, txtpricebuy.Text, txtpricesell.Text}
            xSaveDATA("Price_tbl", "Prod_Code,Unit_Price_Buy,Unit_Price_Sell", values1)
            MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")
            LoadProd()
            ' Else
            ' MsgBox("Product ID already exists", MsgBoxStyle.Exclamation, "Invalid Input")

            ' End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.Date.ToString("yyyy-MM-dd") + " | " + TimeOfDay.ToString("h:mm:ss tt")
    End Sub
End Class