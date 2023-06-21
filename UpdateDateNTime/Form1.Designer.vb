<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        AutoStartCheckBox = New CheckBox()
        RestartServiceButton = New Button()
        RepairServiceButton = New Button()
        Label4 = New Label()
        githubLink = New LinkLabel()
        githubLogo = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(githubLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.BackColor = Color.Transparent
        Label1.Name = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources._error
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.Name = "Label3"
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AutoStartCheckBox
        ' 
        resources.ApplyResources(AutoStartCheckBox, "AutoStartCheckBox")
        AutoStartCheckBox.Name = "AutoStartCheckBox"
        AutoStartCheckBox.UseVisualStyleBackColor = True
        ' 
        ' RestartServiceButton
        ' 
        resources.ApplyResources(RestartServiceButton, "RestartServiceButton")
        RestartServiceButton.Name = "RestartServiceButton"
        RestartServiceButton.UseVisualStyleBackColor = True
        ' 
        ' RepairServiceButton
        ' 
        resources.ApplyResources(RepairServiceButton, "RepairServiceButton")
        RepairServiceButton.Name = "RepairServiceButton"
        RepairServiceButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.BackColor = Color.Transparent
        Label4.Name = "Label4"
        ' 
        ' githubLink
        ' 
        resources.ApplyResources(githubLink, "githubLink")
        githubLink.Name = "githubLink"
        githubLink.TabStop = True
        ' 
        ' githubLogo
        ' 
        githubLogo.Cursor = Cursors.Hand
        resources.ApplyResources(githubLogo, "githubLogo")
        githubLogo.Name = "githubLogo"
        githubLogo.TabStop = False
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(githubLink)
        Controls.Add(Label4)
        Controls.Add(RepairServiceButton)
        Controls.Add(RestartServiceButton)
        Controls.Add(AutoStartCheckBox)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(githubLogo)
        Name = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(githubLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AutoStartCheckBox As CheckBox
    Friend WithEvents RestartServiceButton As Button
    Friend WithEvents RepairServiceButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents githubLink As LinkLabel
    Friend WithEvents githubLogo As PictureBox
End Class
