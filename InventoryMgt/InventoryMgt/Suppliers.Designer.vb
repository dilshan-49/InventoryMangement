<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suppliers
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SupTitleL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.SupContactTB = New System.Windows.Forms.TextBox()
        Me.SupNameTB = New System.Windows.Forms.TextBox()
        Me.ReseSupBut = New System.Windows.Forms.Button()
        Me.SaveSupBut = New System.Windows.Forms.Button()
        Me.SupIDTB = New System.Windows.Forms.TextBox()
        Me.SupContactL = New System.Windows.Forms.Label()
        Me.SupNameL = New System.Windows.Forms.Label()
        Me.SupIDL = New System.Windows.Forms.Label()
        Me.AddSupplier = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EditSubBut = New System.Windows.Forms.Button()
        Me.SupSearchTB = New System.Windows.Forms.TextBox()
        Me.dgvsup = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblfooter = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvsup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.lblDateTime)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.SupTitleL)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 110)
        Me.Panel1.TabIndex = 2
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(719, 27)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(49, 16)
        Me.lblDateTime.TabIndex = 8
        Me.lblDateTime.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InventoryMgt.My.Resources.Resources.left
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'SupTitleL
        '
        Me.SupTitleL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SupTitleL.AutoSize = True
        Me.SupTitleL.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupTitleL.Location = New System.Drawing.Point(340, 59)
        Me.SupTitleL.Name = "SupTitleL"
        Me.SupTitleL.Size = New System.Drawing.Size(170, 26)
        Me.SupTitleL.TabIndex = 1
        Me.SupTitleL.Text = "Supplier Registry"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AXD STORES"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtid)
        Me.Panel2.Controls.Add(Me.SupContactTB)
        Me.Panel2.Controls.Add(Me.SupNameTB)
        Me.Panel2.Controls.Add(Me.ReseSupBut)
        Me.Panel2.Controls.Add(Me.SaveSupBut)
        Me.Panel2.Controls.Add(Me.SupIDTB)
        Me.Panel2.Controls.Add(Me.SupContactL)
        Me.Panel2.Controls.Add(Me.SupNameL)
        Me.Panel2.Controls.Add(Me.SupIDL)
        Me.Panel2.Controls.Add(Me.AddSupplier)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 489)
        Me.Panel2.TabIndex = 3
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(79, 373)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 13
        Me.txtid.Visible = False
        '
        'SupContactTB
        '
        Me.SupContactTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupContactTB.Location = New System.Drawing.Point(150, 156)
        Me.SupContactTB.Name = "SupContactTB"
        Me.SupContactTB.Size = New System.Drawing.Size(184, 22)
        Me.SupContactTB.TabIndex = 12
        '
        'SupNameTB
        '
        Me.SupNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupNameTB.Location = New System.Drawing.Point(150, 110)
        Me.SupNameTB.Name = "SupNameTB"
        Me.SupNameTB.Size = New System.Drawing.Size(184, 22)
        Me.SupNameTB.TabIndex = 11
        '
        'ReseSupBut
        '
        Me.ReseSupBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReseSupBut.Location = New System.Drawing.Point(49, 233)
        Me.ReseSupBut.Name = "ReseSupBut"
        Me.ReseSupBut.Size = New System.Drawing.Size(75, 28)
        Me.ReseSupBut.TabIndex = 10
        Me.ReseSupBut.Text = "Reset"
        Me.ReseSupBut.UseVisualStyleBackColor = True
        '
        'SaveSupBut
        '
        Me.SaveSupBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSupBut.Location = New System.Drawing.Point(259, 233)
        Me.SaveSupBut.Name = "SaveSupBut"
        Me.SaveSupBut.Size = New System.Drawing.Size(75, 28)
        Me.SaveSupBut.TabIndex = 9
        Me.SaveSupBut.Text = "Save"
        Me.SaveSupBut.UseVisualStyleBackColor = True
        '
        'SupIDTB
        '
        Me.SupIDTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupIDTB.Location = New System.Drawing.Point(150, 68)
        Me.SupIDTB.Name = "SupIDTB"
        Me.SupIDTB.Size = New System.Drawing.Size(184, 22)
        Me.SupIDTB.TabIndex = 4
        '
        'SupContactL
        '
        Me.SupContactL.AutoSize = True
        Me.SupContactL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupContactL.Location = New System.Drawing.Point(46, 159)
        Me.SupContactL.Name = "SupContactL"
        Me.SupContactL.Size = New System.Drawing.Size(74, 16)
        Me.SupContactL.TabIndex = 3
        Me.SupContactL.Text = "Contact No"
        '
        'SupNameL
        '
        Me.SupNameL.AutoSize = True
        Me.SupNameL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupNameL.Location = New System.Drawing.Point(46, 113)
        Me.SupNameL.Name = "SupNameL"
        Me.SupNameL.Size = New System.Drawing.Size(98, 16)
        Me.SupNameL.TabIndex = 2
        Me.SupNameL.Text = "Supplier Name"
        '
        'SupIDL
        '
        Me.SupIDL.AutoSize = True
        Me.SupIDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupIDL.Location = New System.Drawing.Point(46, 68)
        Me.SupIDL.Name = "SupIDL"
        Me.SupIDL.Size = New System.Drawing.Size(74, 16)
        Me.SupIDL.TabIndex = 1
        Me.SupIDL.Text = "Supplier ID"
        '
        'AddSupplier
        '
        Me.AddSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSupplier.AutoSize = True
        Me.AddSupplier.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSupplier.Location = New System.Drawing.Point(21, 14)
        Me.AddSupplier.Name = "AddSupplier"
        Me.AddSupplier.Size = New System.Drawing.Size(199, 21)
        Me.AddSupplier.TabIndex = 0
        Me.AddSupplier.Text = "New Supplier Registration"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.EditSubBut)
        Me.Panel3.Controls.Add(Me.SupSearchTB)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(360, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(530, 42)
        Me.Panel3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search Suppliers "
        '
        'EditSubBut
        '
        Me.EditSubBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditSubBut.BackgroundImage = Global.InventoryMgt.My.Resources.Resources.pencil
        Me.EditSubBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditSubBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSubBut.Location = New System.Drawing.Point(454, 8)
        Me.EditSubBut.Name = "EditSubBut"
        Me.EditSubBut.Size = New System.Drawing.Size(25, 25)
        Me.EditSubBut.TabIndex = 1
        Me.EditSubBut.UseVisualStyleBackColor = True
        '
        'SupSearchTB
        '
        Me.SupSearchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupSearchTB.Location = New System.Drawing.Point(126, 11)
        Me.SupSearchTB.Name = "SupSearchTB"
        Me.SupSearchTB.Size = New System.Drawing.Size(283, 22)
        Me.SupSearchTB.TabIndex = 0
        '
        'dgvsup
        '
        Me.dgvsup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsup.Location = New System.Drawing.Point(0, 0)
        Me.dgvsup.Name = "dgvsup"
        Me.dgvsup.Size = New System.Drawing.Size(480, 447)
        Me.dgvsup.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblfooter)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 599)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(890, 36)
        Me.Panel4.TabIndex = 6
        '
        'lblfooter
        '
        Me.lblfooter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblfooter.AutoSize = True
        Me.lblfooter.Location = New System.Drawing.Point(393, 14)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(39, 13)
        Me.lblfooter.TabIndex = 1
        Me.lblfooter.Text = "Label3"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 110)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(890, 489)
        Me.Panel5.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dgvsup)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(360, 42)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(480, 447)
        Me.Panel7.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(840, 42)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(50, 447)
        Me.Panel6.TabIndex = 6
        '
        'Timer1
        '
        '
        'suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 635)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "suppliers"
        Me.Text = "suppliers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvsup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SupContactTB As System.Windows.Forms.TextBox
    Friend WithEvents SupNameTB As System.Windows.Forms.TextBox
    Friend WithEvents ReseSupBut As System.Windows.Forms.Button
    Friend WithEvents SaveSupBut As System.Windows.Forms.Button
    Friend WithEvents SupIDTB As System.Windows.Forms.TextBox
    Friend WithEvents SupContactL As System.Windows.Forms.Label
    Friend WithEvents SupNameL As System.Windows.Forms.Label
    Friend WithEvents SupIDL As System.Windows.Forms.Label
    Friend WithEvents AddSupplier As System.Windows.Forms.Label
    Friend WithEvents SupTitleL As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents EditSubBut As System.Windows.Forms.Button
    Friend WithEvents SupSearchTB As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvsup As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblfooter As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
