<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prod
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtpricesell = New System.Windows.Forms.TextBox()
        Me.txtpricebuy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdIDTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResetProdBut = New System.Windows.Forms.Button()
        Me.SaveProdBut = New System.Windows.Forms.Button()
        Me.Supcmb = New System.Windows.Forms.ComboBox()
        Me.prodcatcmb = New System.Windows.Forms.ComboBox()
        Me.ProdNameTB = New System.Windows.Forms.TextBox()
        Me.SupL = New System.Windows.Forms.Label()
        Me.ProdCatL = New System.Windows.Forms.Label()
        Me.ProdNameL = New System.Windows.Forms.Label()
        Me.AddItem = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EditProd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StockBut = New System.Windows.Forms.Button()
        Me.prodsearchtb = New System.Windows.Forms.TextBox()
        Me.dgvprod = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProdTitleL = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblfooter = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtpricesell)
        Me.Panel2.Controls.Add(Me.txtpricebuy)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ProdIDTB)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ResetProdBut)
        Me.Panel2.Controls.Add(Me.SaveProdBut)
        Me.Panel2.Controls.Add(Me.Supcmb)
        Me.Panel2.Controls.Add(Me.prodcatcmb)
        Me.Panel2.Controls.Add(Me.ProdNameTB)
        Me.Panel2.Controls.Add(Me.SupL)
        Me.Panel2.Controls.Add(Me.ProdCatL)
        Me.Panel2.Controls.Add(Me.ProdNameL)
        Me.Panel2.Controls.Add(Me.AddItem)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 488)
        Me.Panel2.TabIndex = 2
        '
        'txtpricesell
        '
        Me.txtpricesell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpricesell.Location = New System.Drawing.Point(152, 277)
        Me.txtpricesell.Name = "txtpricesell"
        Me.txtpricesell.Size = New System.Drawing.Size(177, 22)
        Me.txtpricesell.TabIndex = 18
        '
        'txtpricebuy
        '
        Me.txtpricebuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpricebuy.Location = New System.Drawing.Point(152, 252)
        Me.txtpricebuy.Name = "txtpricebuy"
        Me.txtpricebuy.Size = New System.Drawing.Size(177, 22)
        Me.txtpricebuy.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sell"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Buy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "**If supplier is not available," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  make sure supplier registry is up to date."
        '
        'ProdIDTB
        '
        Me.ProdIDTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdIDTB.Location = New System.Drawing.Point(152, 70)
        Me.ProdIDTB.Name = "ProdIDTB"
        Me.ProdIDTB.Size = New System.Drawing.Size(177, 22)
        Me.ProdIDTB.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Product Code"
        '
        'ResetProdBut
        '
        Me.ResetProdBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetProdBut.Location = New System.Drawing.Point(37, 333)
        Me.ResetProdBut.Name = "ResetProdBut"
        Me.ResetProdBut.Size = New System.Drawing.Size(75, 28)
        Me.ResetProdBut.TabIndex = 10
        Me.ResetProdBut.Text = "Reset"
        Me.ResetProdBut.UseVisualStyleBackColor = True
        '
        'SaveProdBut
        '
        Me.SaveProdBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveProdBut.Location = New System.Drawing.Point(240, 333)
        Me.SaveProdBut.Name = "SaveProdBut"
        Me.SaveProdBut.Size = New System.Drawing.Size(75, 28)
        Me.SaveProdBut.TabIndex = 9
        Me.SaveProdBut.Text = "Save"
        Me.SaveProdBut.UseVisualStyleBackColor = True
        '
        'Supcmb
        '
        Me.Supcmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supcmb.FormattingEnabled = True
        Me.Supcmb.Location = New System.Drawing.Point(152, 182)
        Me.Supcmb.Name = "Supcmb"
        Me.Supcmb.Size = New System.Drawing.Size(177, 24)
        Me.Supcmb.TabIndex = 8
        '
        'prodcatcmb
        '
        Me.prodcatcmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodcatcmb.FormattingEnabled = True
        Me.prodcatcmb.Location = New System.Drawing.Point(152, 144)
        Me.prodcatcmb.Name = "prodcatcmb"
        Me.prodcatcmb.Size = New System.Drawing.Size(177, 24)
        Me.prodcatcmb.TabIndex = 7
        '
        'ProdNameTB
        '
        Me.ProdNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNameTB.Location = New System.Drawing.Point(152, 106)
        Me.ProdNameTB.Name = "ProdNameTB"
        Me.ProdNameTB.Size = New System.Drawing.Size(177, 22)
        Me.ProdNameTB.TabIndex = 4
        '
        'SupL
        '
        Me.SupL.AutoSize = True
        Me.SupL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupL.Location = New System.Drawing.Point(34, 183)
        Me.SupL.Name = "SupL"
        Me.SupL.Size = New System.Drawing.Size(58, 16)
        Me.SupL.TabIndex = 3
        Me.SupL.Text = "Supplier"
        '
        'ProdCatL
        '
        Me.ProdCatL.AutoSize = True
        Me.ProdCatL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdCatL.Location = New System.Drawing.Point(34, 145)
        Me.ProdCatL.Name = "ProdCatL"
        Me.ProdCatL.Size = New System.Drawing.Size(112, 16)
        Me.ProdCatL.TabIndex = 2
        Me.ProdCatL.Text = "Product Category"
        '
        'ProdNameL
        '
        Me.ProdNameL.AutoSize = True
        Me.ProdNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNameL.Location = New System.Drawing.Point(34, 107)
        Me.ProdNameL.Name = "ProdNameL"
        Me.ProdNameL.Size = New System.Drawing.Size(94, 16)
        Me.ProdNameL.TabIndex = 1
        Me.ProdNameL.Text = "Product Name"
        '
        'AddItem
        '
        Me.AddItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddItem.AutoSize = True
        Me.AddItem.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItem.Location = New System.Drawing.Point(36, 21)
        Me.AddItem.Name = "AddItem"
        Me.AddItem.Size = New System.Drawing.Size(147, 23)
        Me.AddItem.TabIndex = 0
        Me.AddItem.Text = "Add New Product"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EditProd)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.StockBut)
        Me.Panel3.Controls.Add(Me.prodsearchtb)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 52)
        Me.Panel3.TabIndex = 3
        '
        'EditProd
        '
        Me.EditProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditProd.BackgroundImage = Global.InventoryMgt.My.Resources.Resources.trash__1_
        Me.EditProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditProd.Location = New System.Drawing.Point(431, 8)
        Me.EditProd.Name = "EditProd"
        Me.EditProd.Size = New System.Drawing.Size(31, 28)
        Me.EditProd.TabIndex = 5
        Me.EditProd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Search Products"
        '
        'StockBut
        '
        Me.StockBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockBut.Location = New System.Drawing.Point(528, 11)
        Me.StockBut.Name = "StockBut"
        Me.StockBut.Size = New System.Drawing.Size(219, 23)
        Me.StockBut.TabIndex = 2
        Me.StockBut.Text = "Check Availability and Price"
        Me.StockBut.UseVisualStyleBackColor = True
        '
        'prodsearchtb
        '
        Me.prodsearchtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodsearchtb.Location = New System.Drawing.Point(128, 18)
        Me.prodsearchtb.Name = "prodsearchtb"
        Me.prodsearchtb.Size = New System.Drawing.Size(217, 22)
        Me.prodsearchtb.TabIndex = 0
        '
        'dgvprod
        '
        Me.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvprod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvprod.Location = New System.Drawing.Point(0, 52)
        Me.dgvprod.Name = "dgvprod"
        Me.dgvprod.Size = New System.Drawing.Size(480, 436)
        Me.dgvprod.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AXD STORES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.lblDateTime)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ProdTitleL)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 110)
        Me.Panel1.TabIndex = 1
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(698, 32)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(49, 16)
        Me.lblDateTime.TabIndex = 7
        Me.lblDateTime.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventoryMgt.My.Resources.Resources.left
        Me.PictureBox1.Location = New System.Drawing.Point(10, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ProdTitleL
        '
        Me.ProdTitleL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProdTitleL.AutoSize = True
        Me.ProdTitleL.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdTitleL.Location = New System.Drawing.Point(289, 65)
        Me.ProdTitleL.Name = "ProdTitleL"
        Me.ProdTitleL.Size = New System.Drawing.Size(162, 26)
        Me.ProdTitleL.TabIndex = 2
        Me.ProdTitleL.Text = "Product Registry"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblfooter)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 598)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(890, 37)
        Me.Panel5.TabIndex = 6
        '
        'lblfooter
        '
        Me.lblfooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblfooter.AutoSize = True
        Me.lblfooter.Location = New System.Drawing.Point(357, 15)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(39, 13)
        Me.lblfooter.TabIndex = 0
        Me.lblfooter.Text = "Label3"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 110)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(890, 488)
        Me.Panel6.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(360, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(530, 488)
        Me.Panel4.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dgvprod)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(480, 488)
        Me.Panel8.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(480, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(50, 488)
        Me.Panel7.TabIndex = 1
        '
        'Timer1
        '
        '
        'prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 635)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "prod"
        Me.Text = "MainWindow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProdNameTB As System.Windows.Forms.TextBox
    Friend WithEvents SupL As System.Windows.Forms.Label
    Friend WithEvents ProdCatL As System.Windows.Forms.Label
    Friend WithEvents ProdNameL As System.Windows.Forms.Label
    Friend WithEvents AddItem As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents prodcatcmb As System.Windows.Forms.ComboBox
    Friend WithEvents Supcmb As System.Windows.Forms.ComboBox
    Friend WithEvents prodsearchtb As System.Windows.Forms.TextBox
    Friend WithEvents ResetProdBut As System.Windows.Forms.Button
    Friend WithEvents SaveProdBut As System.Windows.Forms.Button
    Friend WithEvents dgvprod As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProdTitleL As System.Windows.Forms.Label
    Friend WithEvents StockBut As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProdIDTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EditProd As System.Windows.Forms.Button
    Friend WithEvents txtpricesell As System.Windows.Forms.TextBox
    Friend WithEvents txtpricebuy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblfooter As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
End Class
