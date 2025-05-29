Public Class New_Transaction
    Sub xload()
        xGridview(dgvitemlist)
        If SellBut.Checked = True Then
            xLoadDataToGridview("itemlistsell_q", "SELECT * FROM itemlistsell_q", dgvitemlist)
        Else
            xLoadDataToGridview("itemlistbuy_q", "SELECT * FROM itemlistbuy_q", dgvitemlist)
        End If
        dgvitemlist.Columns(0).HeaderText = "Product Name"
        dgvitemlist.Columns(1).HeaderText = "Quantity"
        dgvitemlist.Columns(2).HeaderText = "Unit Price"
        dgvitemlist.Columns(3).HeaderText = "Total"
        dgvitemlist.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvitemlist.Columns(4).Visible = False
        dgvitemlist.Columns(5).Visible = False
        dgvitemlist.Columns(6).Visible = False

    End Sub

    Private datetrns As String = DateTime.Today.ToString("yyyy-MM-dd")

    Private Sub New_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xSearchComboBox(cmbitem, "Product_tbl", "Prod_Name", "Prod_Code", "")
        xSearchComboBox(cmbuser, "Customer_tbl", "Cust_Name", "Cust_ID", "")
        xDeleteDATA("itemlist_tbl", "Quantity>0")
        xload()

    End Sub

    Private Sub SellBut_CheckedChanged(sender As Object, e As EventArgs) Handles SellBut.CheckedChanged
        If SellBut.Checked = True Then
            xSearchComboBox(cmbuser, "Customer_tbl", "Cust_Name", "Cust_ID", "")
        Else
            xSearchComboBox(cmbuser, "Supplier_tbl", "Sup_Name", "Sup_ID", "")

        End If
    End Sub

    Private Sub cmduser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbuser.SelectedIndexChanged
        ' If SellBut.Checked = False Then
        'If cmbuser.SelectedValue = "" Then
        'xSearchComboBox(cmbitem, "Product_tbl", "Prod_Name", "Prod_Code", "")
        'Else
        'xSearchComboBox(cmbitem, "Product_tbl", "Prod_Name", "Prod_ID", "Sup_ID =" + cmbuser.SelectedValue)
        'End If
        'End If
    End Sub

    Private Sub butcancel_Click(sender As Object, e As EventArgs) Handles butcancel.Click
        cmbitem.SelectedValue = vbEmpty
        txtqty.Clear()
    End Sub

    Private Sub butadd_Click(sender As Object, e As EventArgs) Handles butadd.Click
        Dim values() As String = {cmbitem.SelectedValue, txtqty.Text}
        xSaveDATA("itemlist_tbl", "Prod_Code,Quantity", values)
        xload()
    End Sub

    Private Sub CancelBut_Click(sender As Object, e As EventArgs) Handles CancelBut.Click
        xDeleteDATA("itemlist_tbl", "Quantity>0")
        xload()
    End Sub

    Private Sub ConfBut_Click(sender As Object, e As EventArgs) Handles ConfBut.Click
        Dim userid As String = cmbuser.SelectedValue
        Dim billtot As Decimal = 0
        If Not cmbuser.SelectedIndex = -1 Then
            If SellBut.Checked = False Then

                Dim listOfvals As New List(Of String())
                Dim listOfStocks As New List(Of String())

                For Each row As DataGridViewRow In dgvitemlist.Rows
                    If Not row.IsNewRow Then

                        Dim prodname As String = row.Cells(0).Value.ToString()
                        Dim qty As String = row.Cells(1).Value.ToString()
                        Dim total As String = row.Cells(3).Value.ToString()
                        Dim prodcode As String = row.Cells(4).Value.ToString()
                        Dim stock As String = row.Cells(5).Value.ToString()
                        Dim id As String = row.Cells(6).Value.ToString()

                        'This Code is Added because old Access file format doesn't support Calculated fields
                        Dim totalasdecimal As Decimal = Integer.Parse(qty) * Decimal.Parse(row.Cells(2).Value.ToString())

                        Dim vals() As String = {prodcode, userid, qty, totalasdecimal.ToString(), datetrns}

                        If Integer.Parse(stock) > Integer.Parse(qty) Then
                            listOfvals.Add(vals)
                            Dim newstock As Integer = Integer.Parse(stock) - Integer.Parse(qty)
                            listOfStocks.Add({id, newstock})
                            billtot = billtot + totalasdecimal
                        Else
                            MsgBox(prodname & " is out of stock. Try after restock or lower the quantity", MsgBoxStyle.Exclamation, "No Stock")
                            Return
                        End If
                    End If
                Next
                For i As Integer = 0 To listOfvals.Count - 1
                    xSaveDATA("Purchase_tbl", "Prod_Code,Sup_ID,Quantity,Total,Date_of_Purchase", listOfvals(i))
                    xUpdateDATA("Price_tbl", {"Prod_Stock"}, {listOfStocks(i)(1)}, "ID=" & listOfStocks(i)(0))
                Next
                MsgBox("Transaction is Successfull. Total Bill is Rs." & billtot.ToString(), MsgBoxStyle.Information, "Success")
            Else
                For Each row As DataGridViewRow In dgvitemlist.Rows
                    If Not row.IsNewRow Then

                        Dim qty As String = row.Cells(1).Value.ToString()
                        Dim total As String = row.Cells(3).Value.ToString()
                        Dim prodcode As String = row.Cells(4).Value.ToString()
                        Dim stock As String = row.Cells(5).Value.ToString()
                        Dim id As String = row.Cells(6).Value.ToString()

                        Dim newstock As Integer = Integer.Parse(stock) + Integer.Parse(qty)

                        'This Code is Added because old Access file format doesn't support Calculated fields
                        Dim totalasdecimal As Decimal = Integer.Parse(qty) * Decimal.Parse(row.Cells(2).Value.ToString())

                        Dim salevals() As String = {prodcode, userid, qty, totalasdecimal.ToString(), datetrns}

                        xSaveDATA("Sales_tbl", "Prod_Code,Cust_ID,Quantity,Total,Date_of_Sale", salevals)
                        xUpdateDATA("Price_tbl", {"Prod_Stock"}, {newstock.ToString()}, "ID=" + id)
                        billtot = billtot + totalasdecimal

                    End If
                Next
                MsgBox("Transaction is Successfull. Total Bill is Rs." & billtot.ToString(), MsgBoxStyle.Information, "Success")
            End If
        Else
            MsgBox("Please Select Supplier/Customer", MsgBoxStyle.Exclamation, "Error")
        End If


    End Sub
End Class