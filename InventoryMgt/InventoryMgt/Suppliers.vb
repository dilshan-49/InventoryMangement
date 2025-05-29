Public Class suppliers
    Sub loadsup(SQL As String)
        xGridview(dgvsup)
        xLoadDataToGridview("Supplier_tbl", SQL, dgvsup)
        dgvsup.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvsup.Columns(0).HeaderText = "Supplier ID"
        dgvsup.Columns(1).HeaderText = "Supplier Name"
        dgvsup.Columns(2).HeaderText = "Contact No."
        dgvsup.Columns(3).Visible = False
        reset()
    End Sub
    Sub reset()
        SupIDTB.ReadOnly = False
        SupSearchTB.Clear()
        SupSearchTB.Focus()
        SupIDTB.Clear()
        SupNameTB.Clear()
        SupContactTB.Clear()
        txtid.Clear()
        SaveSupBut.Text = "Save"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsup("SELECT * FROM Supplier_tbl")
        Timer1.Start()
        lblfooter.Text = ChrW(169) & " " & Now.Year & " All rights are reserved by CodeZ solutions"

    End Sub

    Private Sub ReseSupBut_Click(sender As Object, e As EventArgs) Handles ReseSupBut.Click
        reset()
    End Sub

    Private Sub SupSearchTB_TextChanged(sender As Object, e As EventArgs) Handles SupSearchTB.TextChanged
        Dim Com As String
        Com = "SELECT * FROM Supplier_tbl WHERE Sup_Name LIKE '%" & SupSearchTB.Text & "%';"
        xLoadDataToGridview("Supplier_tbl", Com, dgvsup)
    End Sub

    Private Sub EditSubBut_Click(sender As Object, e As EventArgs) Handles EditSubBut.Click
        SaveSupBut.Text = "Update"
        SupIDTB.Text = dgvsup.Item(0, dgvsup.CurrentRow.Index).Value
        SupNameTB.Text = dgvsup.Item(1, dgvsup.CurrentRow.Index).Value
        SupContactTB.Text = dgvsup.Item(2, dgvsup.CurrentRow.Index).Value
        txtid.Text = dgvsup.Item(3, dgvsup.CurrentRow.Index).Value
        SupIDTB.ReadOnly = True
    End Sub

    Private Sub SaveSupBut_Click(sender As Object, e As EventArgs) Handles SaveSupBut.Click
        If SaveSupBut.Text = "Update" Then
            If SupIDTB.Text = "" Then
                MsgBox("Please Enter Supplier ID", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf SupNameTB.Text = "" Then
                MsgBox("Please Enter Supplier Name", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf SupContactTB.Text = "" Then
                MsgBox("Please Enter Supplier Contact Number", MsgBoxStyle.Exclamation, "Invalid Input")
            Else
                Dim values() As String = {SupNameTB.Text, SupContactTB.Text}
                xUpdateDATA("Supplier_tbl", {"Sup_Name", "Sup_Contact"}, values, "ID =" + txtid.Text)
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Success")
            End If
        Else
            If SupIDTB.Text = "" Then
                MsgBox("Please Enter Supplier ID", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf SupNameTB.Text = "" Then
                MsgBox("Please Enter Supplier Name", MsgBoxStyle.Exclamation, "Invalid Input")
            ElseIf SupContactTB.Text = "" Then
                MsgBox("Please Enter Supplier Contact Number", MsgBoxStyle.Exclamation, "Invalid Input")
            Else
                Dim values() As String = {SupIDTB.Text, SupNameTB.Text, SupContactTB.Text}
                xSaveDATA("Supplier_tbl", "Sup_ID,Sup_Name,Sup_Contact", values)
                MsgBox("Saved Successfully", MsgBoxStyle.Information, "Success")
            End If
        End If
        loadsup("SELECT * FROM Supplier_tbl")
    End Sub

    Private Sub dgvsup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsup.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.Date.ToString("yyyy-MM-dd") + " | " + TimeOfDay.ToString("h:mm:ss tt")

    End Sub
End Class