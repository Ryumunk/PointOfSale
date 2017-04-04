<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSales = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mnuPOS = New System.Windows.Forms.MenuStrip()
        Me.mnuFIle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(12, 53)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(106, 77)
        Me.btnSales.TabIndex = 0
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(141, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 77)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mnuPOS
        '
        Me.mnuPOS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFIle, Me.mnuAbout, Me.mnuHelp})
        Me.mnuPOS.Location = New System.Drawing.Point(0, 0)
        Me.mnuPOS.Name = "mnuPOS"
        Me.mnuPOS.Size = New System.Drawing.Size(555, 24)
        Me.mnuPOS.TabIndex = 2
        Me.mnuPOS.Text = "MenuStrip1"
        '
        'mnuFIle
        '
        Me.mnuFIle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFIle.Name = "mnuFIle"
        Me.mnuFIle.Size = New System.Drawing.Size(37, 20)
        Me.mnuFIle.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 498)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.mnuPOS)
        Me.MainMenuStrip = Me.mnuPOS
        Me.Name = "frmMain"
        Me.Text = "Point of Sale"
        Me.mnuPOS.ResumeLayout(False)
        Me.mnuPOS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSales As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents mnuPOS As MenuStrip
    Friend WithEvents mnuFIle As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
End Class
