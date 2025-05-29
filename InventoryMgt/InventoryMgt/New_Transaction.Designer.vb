<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Transaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.New_Tran_Tile = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransType = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PurchaseBut = New System.Windows.Forms.RadioButton()
        Me.SellBut = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvitemlist = New System.Windows.Forms.DataGridView()
        Me.QuantityL = New System.Windows.Forms.Label()
        Me.ItemL = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.cmbitem = New System.Windows.Forms.ComboBox()
        Me.ConfBut = New System.Windows.Forms.Button()
        Me.CancelBut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbuser = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.butcancel = New System.Windows.Forms.Button()
        Me.butadd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvitemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.New_Tran_Tile)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 75)
        Me.Panel1.TabIndex = 4
        '
        'New_Tran_Tile
        '
        Me.New_Tran_Tile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.New_Tran_Tile.AutoSize = True
        Me.New_Tran_Tile.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Tran_Tile.Location = New System.Drawing.Point(287, 40)
        Me.New_Tran_Tile.Name = "New_Tran_Tile"
        Me.New_Tran_Tile.Size = New System.Drawing.Size(164, 26)
        Me.New_Tran_Tile.TabIndex = 1
        Me.New_Tran_Tile.Text = "New Transaction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AXD STORES"
        '
        'TransType
        '
        Me.TransType.AutoSize = True
        Me.TransType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransType.Location = New System.Drawing.Point(3, 7)
        Me.TransType.Name = "TransType"
        Me.TransType.Size = New System.Drawing.Size(100, 15)
        Me.TransType.TabIndex = 5
        Me.TransType.Text = "Transaction Type"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PurchaseBut)
        Me.Panel2.Controls.Add(Me.SellBut)
        Me.Panel2.Controls.Add(Me.TransType)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(63, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 35)
        Me.Panel2.TabIndex = 6
        '
        'PurchaseBut
        '
        Me.PurchaseBut.AutoSize = True
        Me.PurchaseBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseBut.Location = New System.Drawing.Point(239, 8)
        Me.PurchaseBut.Name = "PurchaseBut"
        Me.PurchaseBut.Size = New System.Drawing.Size(77, 19)
        Me.PurchaseBut.TabIndex = 1
        Me.PurchaseBut.Text = "Purchase"
        Me.PurchaseBut.UseVisualStyleBackColor = True
        '
        'SellBut
        '
        Me.SellBut.AutoSize = True
        Me.SellBut.Checked = True
        Me.SellBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellBut.Location = New System.Drawing.Point(152, 8)
        Me.SellBut.Name = "SellBut"
        Me.SellBut.Size = New System.Drawing.Size(46, 19)
        Me.SellBut.TabIndex = 0
        Me.SellBut.TabStop = True
        Me.SellBut.Text = "Sell"
        Me.SellBut.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvitemlist)
        Me.Panel3.Location = New System.Drawing.Point(358, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(426, 232)
        Me.Panel3.TabIndex = 7
        '
        'dgvitemlist
        '
        Me.dgvitemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvitemlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvitemlist.Location = New System.Drawing.Point(0, 0)
        Me.dgvitemlist.Name = "dgvitemlist"
        Me.dgvitemlist.Size = New System.Drawing.Size(426, 232)
        Me.dgvitemlist.TabIndex = 0
        '
        'QuantityL
        '
        Me.QuantityL.AutoSize = True
        Me.QuantityL.Location = New System.Drawing.Point(228, 18)
        Me.QuantityL.Name = "QuantityL"
        Me.QuantityL.Size = New System.Drawing.Size(51, 15)
        Me.QuantityL.TabIndex = 3
        Me.QuantityL.Text = "Quantity"
        '
        'ItemL
        '
        Me.ItemL.AutoSize = True
        Me.ItemL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemL.Location = New System.Drawing.Point(26, 18)
        Me.ItemL.Name = "ItemL"
        Me.ItemL.Size = New System.Drawing.Size(31, 15)
        Me.ItemL.TabIndex = 2
        Me.ItemL.Text = "Item"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(231, 58)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(43, 21)
        Me.txtqty.TabIndex = 1
        Me.txtqty.Text = "1"
        Me.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbitem
        '
        Me.cmbitem.FormattingEnabled = True
        Me.cmbitem.Location = New System.Drawing.Point(18, 57)
        Me.cmbitem.Name = "cmbitem"
        Me.cmbitem.Size = New System.Drawing.Size(155, 23)
        Me.cmbitem.TabIndex = 0
        '
        'ConfBut
        '
        Me.ConfBut.Location = New System.Drawing.Point(622, 407)
        Me.ConfBut.Name = "ConfBut"
        Me.ConfBut.Size = New System.Drawing.Size(75, 23)
        Me.ConfBut.TabIndex = 8
        Me.ConfBut.Text = "Checkout"
        Me.ConfBut.UseVisualStyleBackColor = True
        '
        'CancelBut
        '
        Me.CancelBut.Location = New System.Drawing.Point(487, 407)
        Me.CancelBut.Name = "CancelBut"
        Me.CancelBut.Size = New System.Drawing.Size(75, 23)
        Me.CancelBut.TabIndex = 9
        Me.CancelBut.Text = "Clear List"
        Me.CancelBut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "*if Supplier/Customer/product is not available," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " please make sure the relevant r" & _
    "egistries are up to date"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.cmbuser)
        Me.Panel4.Location = New System.Drawing.Point(431, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(353, 35)
        Me.Panel4.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Supplier/Customer Name"
        '
        'cmbuser
        '
        Me.cmbuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbuser.FormattingEnabled = True
        Me.cmbuser.Location = New System.Drawing.Point(174, 7)
        Me.cmbuser.Name = "cmbuser"
        Me.cmbuser.Size = New System.Drawing.Size(144, 23)
        Me.cmbuser.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.butcancel)
        Me.Panel5.Controls.Add(Me.butadd)
        Me.Panel5.Controls.Add(Me.cmbitem)
        Me.Panel5.Controls.Add(Me.ItemL)
        Me.Panel5.Controls.Add(Me.QuantityL)
        Me.Panel5.Controls.Add(Me.txtqty)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(34, 198)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(299, 142)
        Me.Panel5.TabIndex = 12
        '
        'butcancel
        '
        Me.butcancel.Location = New System.Drawing.Point(39, 107)
        Me.butcancel.Name = "butcancel"
        Me.butcancel.Size = New System.Drawing.Size(75, 25)
        Me.butcancel.TabIndex = 1
        Me.butcancel.Text = "Cancel"
        Me.butcancel.UseVisualStyleBackColor = True
        '
        'butadd
        '
        Me.butadd.Location = New System.Drawing.Point(209, 105)
        Me.butadd.Name = "butadd"
        Me.butadd.Size = New System.Drawing.Size(75, 25)
        Me.butadd.TabIndex = 0
        Me.butadd.Text = "Add to List"
        Me.butadd.UseVisualStyleBackColor = True
        '
        'New_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 463)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelBut)
        Me.Controls.Add(Me.ConfBut)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "New_Transaction"
        Me.Text = "New_Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvitemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents New_Tran_Tile As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransType As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PurchaseBut As System.Windows.Forms.RadioButton
    Friend WithEvents SellBut As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents QuantityL As System.Windows.Forms.Label
    Friend WithEvents ItemL As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents cmbitem As System.Windows.Forms.ComboBox
    Friend WithEvents ConfBut As System.Windows.Forms.Button
    Friend WithEvents CancelBut As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbuser As System.Windows.Forms.ComboBox
    Friend WithEvents dgvitemlist As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents butcancel As System.Windows.Forms.Button
    Friend WithEvents butadd As System.Windows.Forms.Button
End Class
