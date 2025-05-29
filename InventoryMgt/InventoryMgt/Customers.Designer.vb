<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customers
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
        Me.txtcustaddr = New System.Windows.Forms.TextBox()
        Me.CustAddL = New System.Windows.Forms.Label()
        Me.txtcustcont = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.ReseSupBut = New System.Windows.Forms.Button()
        Me.SaveCustBut = New System.Windows.Forms.Button()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.CustContactL = New System.Windows.Forms.Label()
        Me.CustNameL = New System.Windows.Forms.Label()
        Me.CustIDL = New System.Windows.Forms.Label()
        Me.AddCustomer = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EditCustBut = New System.Windows.Forms.Button()
        Me.txtcustsearch = New System.Windows.Forms.TextBox()
        Me.dgvcust = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustTitleL = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblfooter = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtcustaddr)
        Me.Panel2.Controls.Add(Me.CustAddL)
        Me.Panel2.Controls.Add(Me.txtcustcont)
        Me.Panel2.Controls.Add(Me.txtcustname)
        Me.Panel2.Controls.Add(Me.ReseSupBut)
        Me.Panel2.Controls.Add(Me.SaveCustBut)
        Me.Panel2.Controls.Add(Me.txtcustid)
        Me.Panel2.Controls.Add(Me.CustContactL)
        Me.Panel2.Controls.Add(Me.CustNameL)
        Me.Panel2.Controls.Add(Me.CustIDL)
        Me.Panel2.Controls.Add(Me.AddCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 407)
        Me.Panel2.TabIndex = 4
        '
        'txtcustaddr
        '
        Me.txtcustaddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustaddr.Location = New System.Drawing.Point(153, 201)
        Me.txtcustaddr.Multiline = True
        Me.txtcustaddr.Name = "txtcustaddr"
        Me.txtcustaddr.Size = New System.Drawing.Size(188, 68)
        Me.txtcustaddr.TabIndex = 14
        '
        'CustAddL
        '
        Me.CustAddL.AutoSize = True
        Me.CustAddL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustAddL.Location = New System.Drawing.Point(27, 204)
        Me.CustAddL.Name = "CustAddL"
        Me.CustAddL.Size = New System.Drawing.Size(59, 16)
        Me.CustAddL.TabIndex = 13
        Me.CustAddL.Text = "Address"
        '
        'txtcustcont
        '
        Me.txtcustcont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustcont.Location = New System.Drawing.Point(153, 156)
        Me.txtcustcont.Name = "txtcustcont"
        Me.txtcustcont.Size = New System.Drawing.Size(188, 22)
        Me.txtcustcont.TabIndex = 12
        '
        'txtcustname
        '
        Me.txtcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(153, 110)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(188, 22)
        Me.txtcustname.TabIndex = 11
        '
        'ReseSupBut
        '
        Me.ReseSupBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReseSupBut.Location = New System.Drawing.Point(30, 316)
        Me.ReseSupBut.Name = "ReseSupBut"
        Me.ReseSupBut.Size = New System.Drawing.Size(75, 28)
        Me.ReseSupBut.TabIndex = 10
        Me.ReseSupBut.Text = "Reset"
        Me.ReseSupBut.UseVisualStyleBackColor = True
        '
        'SaveCustBut
        '
        Me.SaveCustBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCustBut.Location = New System.Drawing.Point(266, 316)
        Me.SaveCustBut.Name = "SaveCustBut"
        Me.SaveCustBut.Size = New System.Drawing.Size(75, 28)
        Me.SaveCustBut.TabIndex = 9
        Me.SaveCustBut.Text = "Save"
        Me.SaveCustBut.UseVisualStyleBackColor = True
        '
        'txtcustid
        '
        Me.txtcustid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustid.Location = New System.Drawing.Point(153, 68)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(188, 22)
        Me.txtcustid.TabIndex = 4
        '
        'CustContactL
        '
        Me.CustContactL.AutoSize = True
        Me.CustContactL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustContactL.Location = New System.Drawing.Point(27, 159)
        Me.CustContactL.Name = "CustContactL"
        Me.CustContactL.Size = New System.Drawing.Size(74, 16)
        Me.CustContactL.TabIndex = 3
        Me.CustContactL.Text = "Contact No"
        '
        'CustNameL
        '
        Me.CustNameL.AutoSize = True
        Me.CustNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustNameL.Location = New System.Drawing.Point(27, 113)
        Me.CustNameL.Name = "CustNameL"
        Me.CustNameL.Size = New System.Drawing.Size(105, 16)
        Me.CustNameL.TabIndex = 2
        Me.CustNameL.Text = "Customer Name"
        '
        'CustIDL
        '
        Me.CustIDL.AutoSize = True
        Me.CustIDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustIDL.Location = New System.Drawing.Point(27, 71)
        Me.CustIDL.Name = "CustIDL"
        Me.CustIDL.Size = New System.Drawing.Size(81, 16)
        Me.CustIDL.TabIndex = 1
        Me.CustIDL.Text = "Customer ID"
        '
        'AddCustomer
        '
        Me.AddCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddCustomer.AutoSize = True
        Me.AddCustomer.Font = New System.Drawing.Font("Palatino Linotype", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCustomer.Location = New System.Drawing.Point(26, 19)
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(223, 23)
        Me.AddCustomer.TabIndex = 0
        Me.AddCustomer.Text = "New Customer Registration"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.EditCustBut)
        Me.Panel3.Controls.Add(Me.txtcustsearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(607, 42)
        Me.Panel3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search Customers"
        '
        'EditCustBut
        '
        Me.EditCustBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditCustBut.BackgroundImage = Global.InventoryMgt.My.Resources.Resources.pencil
        Me.EditCustBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditCustBut.Location = New System.Drawing.Point(576, 9)
        Me.EditCustBut.Name = "EditCustBut"
        Me.EditCustBut.Size = New System.Drawing.Size(25, 25)
        Me.EditCustBut.TabIndex = 1
        Me.EditCustBut.UseVisualStyleBackColor = True
        '
        'txtcustsearch
        '
        Me.txtcustsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustsearch.Location = New System.Drawing.Point(151, 10)
        Me.txtcustsearch.Name = "txtcustsearch"
        Me.txtcustsearch.Size = New System.Drawing.Size(194, 22)
        Me.txtcustsearch.TabIndex = 0
        '
        'dgvcust
        '
        Me.dgvcust.AllowUserToAddRows = False
        Me.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcust.Location = New System.Drawing.Point(0, 42)
        Me.dgvcust.Name = "dgvcust"
        Me.dgvcust.RowHeadersVisible = False
        Me.dgvcust.Size = New System.Drawing.Size(607, 365)
        Me.dgvcust.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AXD STORES"
        '
        'CustTitleL
        '
        Me.CustTitleL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustTitleL.AutoSize = True
        Me.CustTitleL.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustTitleL.Location = New System.Drawing.Point(389, 64)
        Me.CustTitleL.Name = "CustTitleL"
        Me.CustTitleL.Size = New System.Drawing.Size(180, 26)
        Me.CustTitleL.TabIndex = 1
        Me.CustTitleL.Text = "Customer Registry"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.lblDateTime)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.CustTitleL)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 110)
        Me.Panel1.TabIndex = 3
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(856, 38)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(49, 16)
        Me.lblDateTime.TabIndex = 10
        Me.lblDateTime.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventoryMgt.My.Resources.Resources.left
        Me.PictureBox1.Location = New System.Drawing.Point(16, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblfooter)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 517)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1017, 37)
        Me.Panel5.TabIndex = 7
        '
        'lblfooter
        '
        Me.lblfooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblfooter.AutoSize = True
        Me.lblfooter.Location = New System.Drawing.Point(425, 15)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(39, 13)
        Me.lblfooter.TabIndex = 0
        Me.lblfooter.Text = "Label3"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(967, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(50, 407)
        Me.Panel4.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 110)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1017, 407)
        Me.Panel6.TabIndex = 9
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dgvcust)
        Me.Panel7.Controls.Add(Me.Panel3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(360, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(607, 407)
        Me.Panel7.TabIndex = 9
        '
        'Timer1
        '
        '
        'customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "customers"
        Me.Text = "customers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtcustaddr As System.Windows.Forms.TextBox
    Friend WithEvents CustAddL As System.Windows.Forms.Label
    Friend WithEvents txtcustcont As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents ReseSupBut As System.Windows.Forms.Button
    Friend WithEvents SaveCustBut As System.Windows.Forms.Button
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents CustContactL As System.Windows.Forms.Label
    Friend WithEvents CustNameL As System.Windows.Forms.Label
    Friend WithEvents CustIDL As System.Windows.Forms.Label
    Friend WithEvents AddCustomer As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents EditCustBut As System.Windows.Forms.Button
    Friend WithEvents txtcustsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvcust As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustTitleL As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblfooter As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
