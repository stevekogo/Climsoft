<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHorizontalRule = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblClimsoftVersion = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(8, 50)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(278, 28)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Climate Database Management System"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(4, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 45)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "CLIMSOFT"
        '
        'lblHorizontalRule
        '
        Me.lblHorizontalRule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHorizontalRule.Location = New System.Drawing.Point(10, 77)
        Me.lblHorizontalRule.Name = "lblHorizontalRule"
        Me.lblHorizontalRule.Size = New System.Drawing.Size(262, 2)
        Me.lblHorizontalRule.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 16)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Climsoft"
        '
        'lblClimsoftVersion
        '
        Me.lblClimsoftVersion.AutoSize = True
        Me.lblClimsoftVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClimsoftVersion.Location = New System.Drawing.Point(12, 122)
        Me.lblClimsoftVersion.Name = "lblClimsoftVersion"
        Me.lblClimsoftVersion.Size = New System.Drawing.Size(64, 16)
        Me.lblClimsoftVersion.TabIndex = 6
        Me.lblClimsoftVersion.Text = "Version 4"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebsite.Location = New System.Drawing.Point(12, 232)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(106, 16)
        Me.lblWebsite.TabIndex = 7
        Me.lblWebsite.Text = "www.climsoft.org"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(11, 211)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(135, 16)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "support@climsoft.org"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(197, 225)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 9
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.lblClimsoftVersion)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHorizontalRule)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHorizontalRule As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblClimsoftVersion As Label
    Friend WithEvents lblWebsite As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents cmdOK As Button
End Class
