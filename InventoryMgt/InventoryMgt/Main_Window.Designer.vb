<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Window
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TransButt = New System.Windows.Forms.Button()
        Me.ProductBut = New System.Windows.Forms.Button()
        Me.CustomerBut = New System.Windows.Forms.Button()
        Me.SuppliersBut = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblfooter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblDateTime)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 148)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = Global.InventoryMgt.My.Resources.Resources.power_button_off
        Me.Label2.Location = New System.Drawing.Point(498, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Image = Global.InventoryMgt.My.Resources.Resources.switch
        Me.Button2.Location = New System.Drawing.Point(612, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.InventoryMgt.My.Resources.Resources.power_button_off
        Me.Button1.Location = New System.Drawing.Point(689, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AXD STORES"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TransButt)
        Me.Panel2.Controls.Add(Me.ProductBut)
        Me.Panel2.Controls.Add(Me.CustomerBut)
        Me.Panel2.Controls.Add(Me.SuppliersBut)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 275)
        Me.Panel2.TabIndex = 3
        '
        'TransButt
        '
        Me.TransButt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TransButt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransButt.Image = Global.InventoryMgt.My.Resources.Resources.money_exchange__1_
        Me.TransButt.Location = New System.Drawing.Point(292, 147)
        Me.TransButt.Name = "TransButt"
        Me.TransButt.Size = New System.Drawing.Size(158, 76)
        Me.TransButt.TabIndex = 4
        Me.TransButt.Text = "Transactions"
        Me.TransButt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TransButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransButt.UseVisualStyleBackColor = True
        '
        'ProductBut
        '
        Me.ProductBut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProductBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBut.Image = Global.InventoryMgt.My.Resources.Resources.supply_chain
        Me.ProductBut.Location = New System.Drawing.Point(292, 8)
        Me.ProductBut.Name = "ProductBut"
        Me.ProductBut.Size = New System.Drawing.Size(158, 76)
        Me.ProductBut.TabIndex = 2
        Me.ProductBut.Text = "Products"
        Me.ProductBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductBut.UseVisualStyleBackColor = True
        '
        'CustomerBut
        '
        Me.CustomerBut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustomerBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerBut.Image = Global.InventoryMgt.My.Resources.Resources.buyer
        Me.CustomerBut.Location = New System.Drawing.Point(533, 8)
        Me.CustomerBut.Name = "CustomerBut"
        Me.CustomerBut.Size = New System.Drawing.Size(158, 76)
        Me.CustomerBut.TabIndex = 3
        Me.CustomerBut.Text = "Customers"
        Me.CustomerBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CustomerBut.UseVisualStyleBackColor = True
        '
        'SuppliersBut
        '
        Me.SuppliersBut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SuppliersBut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersBut.Image = Global.InventoryMgt.My.Resources.Resources.logistics1
        Me.SuppliersBut.Location = New System.Drawing.Point(53, 8)
        Me.SuppliersBut.Name = "SuppliersBut"
        Me.SuppliersBut.Size = New System.Drawing.Size(158, 76)
        Me.SuppliersBut.TabIndex = 1
        Me.SuppliersBut.Text = "Suppliers"
        Me.SuppliersBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SuppliersBut.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(609, 41)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(49, 16)
        Me.lblDateTime.TabIndex = 4
        Me.lblDateTime.Text = "Label3"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblfooter)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 238)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 37)
        Me.Panel3.TabIndex = 5
        '
        'lblfooter
        '
        Me.lblfooter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblfooter.AutoSize = True
        Me.lblfooter.Location = New System.Drawing.Point(264, 15)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(39, 13)
        Me.lblfooter.TabIndex = 0
        Me.lblfooter.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Welcome to AXD Stores"
        '
        'Main_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 423)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_Window"
        Me.Text = "Main_Window"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CustomerBut As System.Windows.Forms.Button
    Friend WithEvents ProductBut As System.Windows.Forms.Button
    Friend WithEvents SuppliersBut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TransButt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblfooter As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
