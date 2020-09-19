<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRand
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
    Public WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents btnFindAvg As System.Windows.Forms.Button
    Public WithEvents btnFindMax As System.Windows.Forms.Button
    Public WithEvents btnCreate As System.Windows.Forms.Button
    Public WithEvents lstRand As System.Windows.Forms.ListBox
    Public WithEvents lblAvg As System.Windows.Forms.Label
    Public WithEvents lblMax As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFindAvg = New System.Windows.Forms.Button()
        Me.btnFindMax = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lstRand = New System.Windows.Forms.ListBox()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(418, 24)
        Me.MainMenu1.TabIndex = 7
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(103, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(114, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'btnFindAvg
        '
        Me.btnFindAvg.BackColor = System.Drawing.SystemColors.Control
        Me.btnFindAvg.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFindAvg.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFindAvg.Location = New System.Drawing.Point(146, 152)
        Me.btnFindAvg.Name = "btnFindAvg"
        Me.btnFindAvg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFindAvg.Size = New System.Drawing.Size(95, 57)
        Me.btnFindAvg.TabIndex = 4
        Me.btnFindAvg.Text = "Find Avg"
        Me.btnFindAvg.UseVisualStyleBackColor = False
        '
        'btnFindMax
        '
        Me.btnFindMax.BackColor = System.Drawing.SystemColors.Control
        Me.btnFindMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFindMax.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindMax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFindMax.Location = New System.Drawing.Point(146, 248)
        Me.btnFindMax.Name = "btnFindMax"
        Me.btnFindMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFindMax.Size = New System.Drawing.Size(95, 57)
        Me.btnFindMax.TabIndex = 3
        Me.btnFindMax.Text = "Find Max"
        Me.btnFindMax.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCreate.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCreate.Location = New System.Drawing.Point(146, 56)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCreate.Size = New System.Drawing.Size(95, 57)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create List"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'lstRand
        '
        Me.lstRand.BackColor = System.Drawing.SystemColors.Window
        Me.lstRand.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstRand.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstRand.ItemHeight = 21
        Me.lstRand.Location = New System.Drawing.Point(32, 112)
        Me.lstRand.Name = "lstRand"
        Me.lstRand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstRand.Size = New System.Drawing.Size(65, 256)
        Me.lstRand.TabIndex = 0
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAvg.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAvg.Location = New System.Drawing.Point(256, 152)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAvg.Size = New System.Drawing.Size(97, 57)
        Me.lblAvg.TabIndex = 6
        Me.lblAvg.Text = "show avg here"
        '
        'lblMax
        '
        Me.lblMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMax.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMax.Location = New System.Drawing.Point(256, 248)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMax.Size = New System.Drawing.Size(97, 57)
        Me.lblMax.TabIndex = 5
        Me.lblMax.Text = "show max here"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 73)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "List of Random Numbers"
        '
        'frmRand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(418, 426)
        Me.Controls.Add(Me.btnFindAvg)
        Me.Controls.Add(Me.btnFindMax)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lstRand)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(46, 59)
        Me.Name = "frmRand"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lab Demo for Random Lists - .net"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class