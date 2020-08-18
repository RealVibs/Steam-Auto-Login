<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SteamLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SteamLogin))
        Me.LblChooseAccount = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LbAccounts = New System.Windows.Forms.ListBox()
        Me.RbMains = New System.Windows.Forms.RadioButton()
        Me.RbAlts = New System.Windows.Forms.RadioButton()
        Me.RbVault = New System.Windows.Forms.RadioButton()
        Me.RbOthers = New System.Windows.Forms.RadioButton()
        Me.LlWebsite = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'LblChooseAccount
        '
        Me.LblChooseAccount.AutoSize = True
        Me.LblChooseAccount.BackColor = System.Drawing.Color.Transparent
        Me.LblChooseAccount.Font = New System.Drawing.Font("Caviar Dreams", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChooseAccount.ForeColor = System.Drawing.Color.Aqua
        Me.LblChooseAccount.Location = New System.Drawing.Point(12, 9)
        Me.LblChooseAccount.Name = "LblChooseAccount"
        Me.LblChooseAccount.Size = New System.Drawing.Size(164, 24)
        Me.LblChooseAccount.TabIndex = 0
        Me.LblChooseAccount.Text = "Choose Account"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Caviar Dreams", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnLogin.Location = New System.Drawing.Point(16, 177)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(160, 23)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LbAccounts
        '
        Me.LbAccounts.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LbAccounts.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbAccounts.Font = New System.Drawing.Font("Caviar Dreams", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAccounts.ForeColor = System.Drawing.Color.Red
        Me.LbAccounts.FormattingEnabled = True
        Me.LbAccounts.ItemHeight = 15
        Me.LbAccounts.Location = New System.Drawing.Point(16, 36)
        Me.LbAccounts.Name = "LbAccounts"
        Me.LbAccounts.Size = New System.Drawing.Size(160, 135)
        Me.LbAccounts.TabIndex = 2
        '
        'RbMains
        '
        Me.RbMains.AutoSize = True
        Me.RbMains.BackColor = System.Drawing.Color.Transparent
        Me.RbMains.Checked = True
        Me.RbMains.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RbMains.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.RbMains.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RbMains.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbMains.Location = New System.Drawing.Point(182, 36)
        Me.RbMains.Name = "RbMains"
        Me.RbMains.Size = New System.Drawing.Size(53, 17)
        Me.RbMains.TabIndex = 3
        Me.RbMains.TabStop = True
        Me.RbMains.Text = "Mains"
        Me.RbMains.UseVisualStyleBackColor = False
        '
        'RbAlts
        '
        Me.RbAlts.AutoSize = True
        Me.RbAlts.BackColor = System.Drawing.Color.Transparent
        Me.RbAlts.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RbAlts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.RbAlts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RbAlts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbAlts.Location = New System.Drawing.Point(182, 59)
        Me.RbAlts.Name = "RbAlts"
        Me.RbAlts.Size = New System.Drawing.Size(42, 17)
        Me.RbAlts.TabIndex = 4
        Me.RbAlts.Text = "Alts"
        Me.RbAlts.UseVisualStyleBackColor = False
        '
        'RbVault
        '
        Me.RbVault.AutoSize = True
        Me.RbVault.BackColor = System.Drawing.Color.Transparent
        Me.RbVault.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RbVault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.RbVault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RbVault.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbVault.Location = New System.Drawing.Point(182, 82)
        Me.RbVault.Name = "RbVault"
        Me.RbVault.Size = New System.Drawing.Size(85, 17)
        Me.RbVault.TabIndex = 5
        Me.RbVault.Text = "Game Vaults"
        Me.RbVault.UseVisualStyleBackColor = False
        '
        'RbOthers
        '
        Me.RbOthers.AutoSize = True
        Me.RbOthers.BackColor = System.Drawing.Color.Transparent
        Me.RbOthers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.RbOthers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.RbOthers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RbOthers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RbOthers.Location = New System.Drawing.Point(182, 154)
        Me.RbOthers.Name = "RbOthers"
        Me.RbOthers.Size = New System.Drawing.Size(56, 17)
        Me.RbOthers.TabIndex = 6
        Me.RbOthers.Text = "Others"
        Me.RbOthers.UseVisualStyleBackColor = False
        '
        'LlWebsite
        '
        Me.LlWebsite.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.LlWebsite.AutoSize = True
        Me.LlWebsite.BackColor = System.Drawing.Color.Transparent
        Me.LlWebsite.Font = New System.Drawing.Font("Caviar Dreams", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlWebsite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LlWebsite.LinkColor = System.Drawing.Color.Magenta
        Me.LlWebsite.Location = New System.Drawing.Point(12, 305)
        Me.LlWebsite.Name = "LlWebsite"
        Me.LlWebsite.Size = New System.Drawing.Size(88, 13)
        Me.LlWebsite.TabIndex = 7
        Me.LlWebsite.TabStop = True
        Me.LlWebsite.Text = "PolarDesigns.us"
        Me.LlWebsite.VisitedLinkColor = System.Drawing.Color.Magenta
        '
        'SteamLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 327)
        Me.Controls.Add(Me.LlWebsite)
        Me.Controls.Add(Me.RbOthers)
        Me.Controls.Add(Me.RbVault)
        Me.Controls.Add(Me.RbAlts)
        Me.Controls.Add(Me.RbMains)
        Me.Controls.Add(Me.LbAccounts)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblChooseAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(540, 366)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(540, 366)
        Me.Name = "SteamLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Steam Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblChooseAccount As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LbAccounts As ListBox
    Friend WithEvents RbMains As RadioButton
    Friend WithEvents RbAlts As RadioButton
    Friend WithEvents RbVault As RadioButton
    Friend WithEvents RbOthers As RadioButton
    Friend WithEvents LlWebsite As LinkLabel
End Class
