Public Class customers
    Sub LoadCust()
        xGridview(dgvcust)
        xLoadDataToGridview("Customer_tbl", "SELECT * FROM Customer_tbl", dgvcust)
        dgvcust.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvcust.Columns(0).HeaderText = "Customer ID"
        dgvcust.Columns(1).HeaderText = "Customer Name"
        dgvcust.Columns(2).HeaderText = "Address"
        dgvcust.Columns(3).HeaderText = "Contact No."
        dgvcust.Columns(4).Visible = False
        reset()
    End Sub
    Private id As String

    Sub reset()
        txtcustid.ReadOnly = False
        txtcustsearch.Clear()
        txtcustsearch.Focus()
        txtcustaddr.Clear()
        txtcustid.Clear()
        txtcustname.Clear()
        txtcustcont.Clear()
        SaveCustBut.Text = "Save"
        id = ""
    End Sub

    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCust()
        Timer1.Start()
        lblfooter.Text = ChrW(169) & " " & Now.Year & " All rights are reserved by CodeZ solutions"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub EditCustBut_Click(sender As Object, e As EventArgs) Handles EditCustBut.Click
        SaveCustBut.Text = "Update"
        txtcustid.Text = dgvcust.Item(0, dgvcust.CurrentRow.Index).Value
        txtcustname.Text = dgvcust.Item(1, dgvcust.CurrentRow.Index).Value
        txtcustaddr.Text = dgvcust.Item(2, dgvcust.CurrentRow.Index).Value
        txtcustcont.Text = dgvcust.Item(3, dgvcust.CurrentRow.Index).Value
        id = dgvcust.Item(4, dgvcust.CurrentRow.Index).Value
        txtcustid.ReadOnly = True
    End Sub

    Private Sub ReseSupBut_Click(sender As Object, e As EventArgs) Handles ReseSupBut.Click
        reset()
    End Sub

    Private Sub SaveCustBut_Click(sender As Object, e As EventArgs) Handles SaveCustBut.Click
        If SaveCustBut.Text = "Update" Then
            If txtcustname.Text = "" Then
                MsgBox("Please Enter Customer Name", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf txtcustaddr.Text = "" Then
                MsgBox("Please Enter Customer Address", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf txtcustcont.Text = "" Then
                MsgBox("Please Enter Customer Contact Number", MsgBoxStyle.Exclamation, "Invalid Input")
            Else
                Dim values() As String = {txtcustname.Text, txtcustaddr.Text, txtcustcont.Text}
                xUpdateDATA("Customer_tbl", {"Cust_Name", "Cust_Address", "Cust_Contact"}, values, "ID =" + id)
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")


            End If
        Else
            If txtcustid.Text = "" Then
                MsgBox("Please Enter Customer ID", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf txtcustname.Text = "" Then
                MsgBox("Please Enter Customer Name", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf txtcustaddr.Text = "" Then
                MsgBox("Please Enter Customer Address", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf txtcustcont.Text = "" Then
                MsgBox("Please Enter Customer Contact Number", MsgBoxStyle.Exclamation, "Invalid Input")
            Else
                Dim values() As String = {txtcustid.Text, txtcustname.Text, txtcustaddr.Text, txtcustcont.Text}
                xSaveDATA("Customer_tbl", "Cust_ID,Cust_Name,Cust_Address,Cust_Contact", values)
                MsgBox("Saved Successfully", MsgBoxStyle.Information, "Success")
            End If
        End If
        LoadCust()
    End Sub

    Private Sub txtcustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtcustsearch.TextChanged
        Dim Com As String
        Com = "SELECT Cust_ID,Cust_Name,Cust_Address,Cust_Contact FROM Customer_tbl WHERE Cust_Name LIKE '%" & txtcustsearch.Text & "%';"
        xLoadDataToGridview("product_q", Com, dgvcust)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.Date.ToString("yyyy-MM-dd") + " | " + TimeOfDay.ToString("h:mm:ss tt")

    End Sub
End Class