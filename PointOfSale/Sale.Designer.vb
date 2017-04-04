<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale
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
        Me.mnuSale = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPedicure = New System.Windows.Forms.Button()
        Me.btnManicure = New System.Windows.Forms.Button()
        Me.btnPedicureDeluxe1 = New System.Windows.Forms.Button()
        Me.btnPedicureDeluxe2 = New System.Windows.Forms.Button()
        Me.btnFillin = New System.Windows.Forms.Button()
        Me.btnFullSet = New System.Windows.Forms.Button()
        Me.btnGelManicure = New System.Windows.Forms.Button()
        Me.btnGelPolishChange = New System.Windows.Forms.Button()
        Me.btnGelPedicure = New System.Windows.Forms.Button()
        Me.btnPinkAndWhite = New System.Windows.Forms.Button()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.grpSales = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtSalesNo = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblSalesNo = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.mnuSale.SuspendLayout()
        Me.grpSales.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuSale
        '
        Me.mnuSale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuSale.Location = New System.Drawing.Point(0, 0)
        Me.mnuSale.Name = "mnuSale"
        Me.mnuSale.Size = New System.Drawing.Size(1428, 24)
        Me.mnuSale.TabIndex = 0
        Me.mnuSale.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuClose.Text = "Close"
        '
        'btnPedicure
        '
        Me.btnPedicure.Location = New System.Drawing.Point(313, 59)
        Me.btnPedicure.Name = "btnPedicure"
        Me.btnPedicure.Size = New System.Drawing.Size(117, 112)
        Me.btnPedicure.TabIndex = 1
        Me.btnPedicure.Text = "Pedicure"
        Me.btnPedicure.UseVisualStyleBackColor = True
        '
        'btnManicure
        '
        Me.btnManicure.Location = New System.Drawing.Point(501, 59)
        Me.btnManicure.Name = "btnManicure"
        Me.btnManicure.Size = New System.Drawing.Size(120, 112)
        Me.btnManicure.TabIndex = 2
        Me.btnManicure.Text = "Manicure"
        Me.btnManicure.UseVisualStyleBackColor = True
        '
        'btnPedicureDeluxe1
        '
        Me.btnPedicureDeluxe1.Location = New System.Drawing.Point(692, 59)
        Me.btnPedicureDeluxe1.Name = "btnPedicureDeluxe1"
        Me.btnPedicureDeluxe1.Size = New System.Drawing.Size(120, 112)
        Me.btnPedicureDeluxe1.TabIndex = 3
        Me.btnPedicureDeluxe1.Text = "Pedicure Deluxe 1"
        Me.btnPedicureDeluxe1.UseVisualStyleBackColor = True
        '
        'btnPedicureDeluxe2
        '
        Me.btnPedicureDeluxe2.Location = New System.Drawing.Point(883, 59)
        Me.btnPedicureDeluxe2.Name = "btnPedicureDeluxe2"
        Me.btnPedicureDeluxe2.Size = New System.Drawing.Size(120, 112)
        Me.btnPedicureDeluxe2.TabIndex = 4
        Me.btnPedicureDeluxe2.Text = "Pedicure Deluxe 2"
        Me.btnPedicureDeluxe2.UseVisualStyleBackColor = True
        '
        'btnFillin
        '
        Me.btnFillin.Location = New System.Drawing.Point(1074, 59)
        Me.btnFillin.Name = "btnFillin"
        Me.btnFillin.Size = New System.Drawing.Size(120, 112)
        Me.btnFillin.TabIndex = 5
        Me.btnFillin.Text = "Fill-in"
        Me.btnFillin.UseVisualStyleBackColor = True
        '
        'btnFullSet
        '
        Me.btnFullSet.Location = New System.Drawing.Point(1265, 59)
        Me.btnFullSet.Name = "btnFullSet"
        Me.btnFullSet.Size = New System.Drawing.Size(120, 112)
        Me.btnFullSet.TabIndex = 6
        Me.btnFullSet.Text = "Full-Set"
        Me.btnFullSet.UseVisualStyleBackColor = True
        '
        'btnGelManicure
        '
        Me.btnGelManicure.Location = New System.Drawing.Point(501, 207)
        Me.btnGelManicure.Name = "btnGelManicure"
        Me.btnGelManicure.Size = New System.Drawing.Size(120, 112)
        Me.btnGelManicure.TabIndex = 7
        Me.btnGelManicure.Text = "Gel-Manicure"
        Me.btnGelManicure.UseVisualStyleBackColor = True
        '
        'btnGelPolishChange
        '
        Me.btnGelPolishChange.Location = New System.Drawing.Point(692, 207)
        Me.btnGelPolishChange.Name = "btnGelPolishChange"
        Me.btnGelPolishChange.Size = New System.Drawing.Size(120, 112)
        Me.btnGelPolishChange.TabIndex = 8
        Me.btnGelPolishChange.Text = "Gel-Polish Change"
        Me.btnGelPolishChange.UseVisualStyleBackColor = True
        '
        'btnGelPedicure
        '
        Me.btnGelPedicure.Location = New System.Drawing.Point(313, 207)
        Me.btnGelPedicure.Name = "btnGelPedicure"
        Me.btnGelPedicure.Size = New System.Drawing.Size(120, 112)
        Me.btnGelPedicure.TabIndex = 9
        Me.btnGelPedicure.Text = "Gel Pedicure"
        Me.btnGelPedicure.UseVisualStyleBackColor = True
        '
        'btnPinkAndWhite
        '
        Me.btnPinkAndWhite.Location = New System.Drawing.Point(883, 207)
        Me.btnPinkAndWhite.Name = "btnPinkAndWhite"
        Me.btnPinkAndWhite.Size = New System.Drawing.Size(120, 112)
        Me.btnPinkAndWhite.TabIndex = 10
        Me.btnPinkAndWhite.Text = "Pink And White"
        Me.btnPinkAndWhite.UseVisualStyleBackColor = True
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.Location = New System.Drawing.Point(6, 26)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(123, 24)
        Me.lblEmployeeID.TabIndex = 11
        Me.lblEmployeeID.Text = "Employee ID:"
        '
        'grpSales
        '
        Me.grpSales.Controls.Add(Me.txtTotal)
        Me.grpSales.Controls.Add(Me.txtAmount)
        Me.grpSales.Controls.Add(Me.txtSalesNo)
        Me.grpSales.Controls.Add(Me.txtEmployeeID)
        Me.grpSales.Controls.Add(Me.lblTotal)
        Me.grpSales.Controls.Add(Me.lblAmount)
        Me.grpSales.Controls.Add(Me.lblSalesNo)
        Me.grpSales.Controls.Add(Me.lblEmployeeID)
        Me.grpSales.Location = New System.Drawing.Point(13, 59)
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Size = New System.Drawing.Size(264, 260)
        Me.grpSales.TabIndex = 12
        Me.grpSales.TabStop = False
        Me.grpSales.Text = "Sales"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(135, 212)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtTotal.TabIndex = 18
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(135, 149)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 29)
        Me.txtAmount.TabIndex = 17
        '
        'txtSalesNo
        '
        Me.txtSalesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesNo.Location = New System.Drawing.Point(135, 86)
        Me.txtSalesNo.Name = "txtSalesNo"
        Me.txtSalesNo.Size = New System.Drawing.Size(100, 29)
        Me.txtSalesNo.TabIndex = 16
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(135, 23)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(100, 29)
        Me.txtEmployeeID.TabIndex = 15
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(10, 215)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 24)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "Total:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(7, 152)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(81, 24)
        Me.lblAmount.TabIndex = 13
        Me.lblAmount.Text = "Amount:"
        '
        'lblSalesNo
        '
        Me.lblSalesNo.AutoSize = True
        Me.lblSalesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesNo.Location = New System.Drawing.Point(10, 89)
        Me.lblSalesNo.Name = "lblSalesNo"
        Me.lblSalesNo.Size = New System.Drawing.Size(91, 24)
        Me.lblSalesNo.TabIndex = 12
        Me.lblSalesNo.Text = "Sales No:"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(24, 511)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(264, 113)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(313, 347)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1103, 277)
        Me.DataGridView1.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(24, 359)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(264, 113)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 865)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.grpSales)
        Me.Controls.Add(Me.btnPinkAndWhite)
        Me.Controls.Add(Me.btnGelPedicure)
        Me.Controls.Add(Me.btnGelPolishChange)
        Me.Controls.Add(Me.btnGelManicure)
        Me.Controls.Add(Me.btnFullSet)
        Me.Controls.Add(Me.btnFillin)
        Me.Controls.Add(Me.btnPedicureDeluxe2)
        Me.Controls.Add(Me.btnPedicureDeluxe1)
        Me.Controls.Add(Me.btnManicure)
        Me.Controls.Add(Me.btnPedicure)
        Me.Controls.Add(Me.mnuSale)
        Me.MainMenuStrip = Me.mnuSale
        Me.Name = "frmSale"
        Me.Text = "Sales"
        Me.mnuSale.ResumeLayout(False)
        Me.mnuSale.PerformLayout()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuSale As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents btnPedicure As Button
    Friend WithEvents btnManicure As Button
    Friend WithEvents btnPedicureDeluxe1 As Button
    Friend WithEvents btnPedicureDeluxe2 As Button
    Friend WithEvents btnFillin As Button
    Friend WithEvents btnFullSet As Button
    Friend WithEvents btnGelManicure As Button
    Friend WithEvents btnGelPolishChange As Button
    Friend WithEvents btnGelPedicure As Button
    Friend WithEvents btnPinkAndWhite As Button
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents grpSales As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtSalesNo As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblSalesNo As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
End Class
