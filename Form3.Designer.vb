<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        SIGNUPbtn = New Button()
        usernametextbox = New TextBox()
        passwordtextbox = New TextBox()
        signuplabel = New Label()
        Usernamelabel = New Label()
        Passwordlabel = New Label()
        SuspendLayout()
        ' 
        ' SIGNUPbtn
        ' 
        SIGNUPbtn.Location = New Point(250, 210)
        SIGNUPbtn.Name = "SIGNUPbtn"
        SIGNUPbtn.Size = New Size(148, 52)
        SIGNUPbtn.TabIndex = 0
        SIGNUPbtn.Text = "Sign Up"
        SIGNUPbtn.UseVisualStyleBackColor = True
        ' 
        ' usernametextbox
        ' 
        usernametextbox.ForeColor = SystemColors.InactiveCaption
        usernametextbox.Location = New Point(271, 52)
        usernametextbox.Name = "usernametextbox"
        usernametextbox.Size = New Size(99, 23)
        usernametextbox.TabIndex = 1
        usernametextbox.Text = "username"
        ' 
        ' passwordtextbox
        ' 
        passwordtextbox.ForeColor = SystemColors.InactiveCaption
        passwordtextbox.Location = New Point(270, 118)
        passwordtextbox.Name = "passwordtextbox"
        passwordtextbox.Size = New Size(100, 23)
        passwordtextbox.TabIndex = 3
        passwordtextbox.Text = "password"
        ' 
        ' signuplabel
        ' 
        signuplabel.AutoSize = True
        signuplabel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signuplabel.Location = New Point(305, 18)
        signuplabel.Name = "signuplabel"
        signuplabel.Size = New Size(46, 15)
        signuplabel.TabIndex = 4
        signuplabel.Text = "sign up"
        ' 
        ' Usernamelabel
        ' 
        Usernamelabel.AutoSize = True
        Usernamelabel.Location = New Point(185, 60)
        Usernamelabel.Name = "Usernamelabel"
        Usernamelabel.Size = New Size(68, 15)
        Usernamelabel.TabIndex = 5
        Usernamelabel.Text = "User Name:"
        ' 
        ' Passwordlabel
        ' 
        Passwordlabel.AutoSize = True
        Passwordlabel.Location = New Point(185, 126)
        Passwordlabel.Name = "Passwordlabel"
        Passwordlabel.Size = New Size(60, 15)
        Passwordlabel.TabIndex = 7
        Passwordlabel.Text = "Password:"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Passwordlabel)
        Controls.Add(Usernamelabel)
        Controls.Add(signuplabel)
        Controls.Add(passwordtextbox)
        Controls.Add(usernametextbox)
        Controls.Add(SIGNUPbtn)
        Name = "Form3"
        Text = "Sign Up Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SIGNUPbtn As Button
    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents passwordtextbox As TextBox
    Friend WithEvents signuplabel As Label
    Friend WithEvents Usernamelabel As Label
    Friend WithEvents Passwordlabel As Label
End Class
