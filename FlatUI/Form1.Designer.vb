<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.exitLbl = New System.Windows.Forms.Label()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.ContactBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.MinBtn = New System.Windows.Forms.Label()
        Me.FormControlPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FormControlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.FormControlPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 56)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.LogoutBtn)
        Me.Panel2.Controls.Add(Me.ContactBtn)
        Me.Panel2.Controls.Add(Me.AboutBtn)
        Me.Panel2.Controls.Add(Me.HomeBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 446)
        Me.Panel2.TabIndex = 1
        '
        'exitLbl
        '
        Me.exitLbl.AutoSize = True
        Me.exitLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.exitLbl.Location = New System.Drawing.Point(60, 15)
        Me.exitLbl.Name = "exitLbl"
        Me.exitLbl.Size = New System.Drawing.Size(26, 25)
        Me.exitLbl.TabIndex = 0
        Me.exitLbl.Text = "X"
        '
        'HomeBtn
        '
        Me.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Location = New System.Drawing.Point(0, 31)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(250, 61)
        Me.HomeBtn.TabIndex = 0
        Me.HomeBtn.Text = "HOME"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'AboutBtn
        '
        Me.AboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutBtn.Location = New System.Drawing.Point(0, 89)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(250, 61)
        Me.AboutBtn.TabIndex = 1
        Me.AboutBtn.Text = "ABOUT"
        Me.AboutBtn.UseVisualStyleBackColor = True
        '
        'ContactBtn
        '
        Me.ContactBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContactBtn.Location = New System.Drawing.Point(0, 146)
        Me.ContactBtn.Name = "ContactBtn"
        Me.ContactBtn.Size = New System.Drawing.Size(250, 61)
        Me.ContactBtn.TabIndex = 2
        Me.ContactBtn.Text = "CONTACT"
        Me.ContactBtn.UseVisualStyleBackColor = True
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Location = New System.Drawing.Point(0, 204)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(250, 61)
        Me.LogoutBtn.TabIndex = 3
        Me.LogoutBtn.Text = "LOGOUT"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'MinBtn
        '
        Me.MinBtn.AutoSize = True
        Me.MinBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MinBtn.Location = New System.Drawing.Point(29, 13)
        Me.MinBtn.Name = "MinBtn"
        Me.MinBtn.Size = New System.Drawing.Size(19, 25)
        Me.MinBtn.TabIndex = 1
        Me.MinBtn.Text = "-"
        '
        'FormControlPanel
        '
        Me.FormControlPanel.Controls.Add(Me.exitLbl)
        Me.FormControlPanel.Controls.Add(Me.MinBtn)
        Me.FormControlPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlPanel.Location = New System.Drawing.Point(934, 0)
        Me.FormControlPanel.Name = "FormControlPanel"
        Me.FormControlPanel.Size = New System.Drawing.Size(93, 56)
        Me.FormControlPanel.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 502)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "p"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FormControlPanel.ResumeLayout(False)
        Me.FormControlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents exitLbl As System.Windows.Forms.Label
    Friend WithEvents MinBtn As System.Windows.Forms.Label
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents ContactBtn As System.Windows.Forms.Button
    Friend WithEvents AboutBtn As System.Windows.Forms.Button
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents FormControlPanel As System.Windows.Forms.Panel

End Class
