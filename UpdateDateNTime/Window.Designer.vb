<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Window))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        AutoStartCheckBox = New CheckBox()
        Label4 = New Label()
        githubLink = New LinkLabel()
        githubLogo = New PictureBox()
        NotifyIcon = New NotifyIcon(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(githubLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources._error
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(218, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(327, 15)
        Label2.TabIndex = 2
        Label2.Text = "Update your date and time just by clicking the button below!"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(119, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(404, 15)
        Label3.TabIndex = 3
        Label3.Text = "If you want to run the app when Windows starts, check de checkbox below."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(248, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 42)
        Button1.TabIndex = 4
        Button1.Text = "Update!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AutoStartCheckBox
        ' 
        AutoStartCheckBox.AutoSize = True
        AutoStartCheckBox.Location = New Point(196, 292)
        AutoStartCheckBox.Name = "AutoStartCheckBox"
        AutoStartCheckBox.Size = New Size(245, 19)
        AutoStartCheckBox.TabIndex = 5
        AutoStartCheckBox.Text = "Auto update time when Windows® starts"
        AutoStartCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(599, 293)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 8
        Label4.Text = "v1.0"
        Label4.TextAlign = ContentAlignment.BottomRight
        ' 
        ' githubLink
        ' 
        githubLink.AutoSize = True
        githubLink.Location = New Point(560, 307)
        githubLink.Name = "githubLink"
        githubLink.Size = New Size(73, 15)
        githubLink.TabIndex = 9
        githubLink.TabStop = True
        githubLink.Text = "retrozinndev"
        githubLink.TextAlign = ContentAlignment.BottomRight
        ' 
        ' githubLogo
        ' 
        githubLogo.Cursor = Cursors.Hand
        githubLogo.Image = CType(resources.GetObject("githubLogo.Image"), Image)
        githubLogo.Location = New Point(535, 303)
        githubLogo.Name = "githubLogo"
        githubLogo.Size = New Size(26, 22)
        githubLogo.SizeMode = PictureBoxSizeMode.Zoom
        githubLogo.TabIndex = 10
        githubLogo.TabStop = False
        ' 
        ' NotifyIcon
        ' 
        NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), Icon)
        NotifyIcon.Text = "UpDateNTime"
        ' 
        ' Window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(645, 331)
        Controls.Add(githubLogo)
        Controls.Add(githubLink)
        Controls.Add(Label4)
        Controls.Add(AutoStartCheckBox)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(661, 370)
        Name = "Window"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpDateN'Time!"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(githubLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AutoStartCheckBox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents githubLink As LinkLabel
    Friend WithEvents githubLogo As PictureBox
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
