<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        pnlMain = New Panel()
        btnSend = New Button()
        txtMessage = New TextBox()
        rtbMessage = New RichTextBox()
        pnlHeader = New Panel()
        txtServerIP = New TextBox()
        btnConnect = New Button()
        txtUser = New TextBox()
        lblUserName = New Label()
        Timer1 = New Timer(components)
        pnlMain.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(46), CByte(26), CByte(53))
        pnlMain.Controls.Add(btnSend)
        pnlMain.Controls.Add(txtMessage)
        pnlMain.Controls.Add(rtbMessage)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(944, 586)
        pnlMain.TabIndex = 0
        ' 
        ' btnSend
        ' 
        btnSend.BackColor = Color.FromArgb(CByte(255), CByte(89), CByte(117))
        btnSend.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(247), CByte(250))
        btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(41), CByte(200))
        btnSend.FlatStyle = FlatStyle.Flat
        btnSend.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSend.ForeColor = Color.FromArgb(CByte(255), CByte(247), CByte(250))
        btnSend.Location = New Point(789, 544)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(139, 32)
        btnSend.TabIndex = 3
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = False
        ' 
        ' txtMessage
        ' 
        txtMessage.Location = New Point(16, 548)
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(757, 23)
        txtMessage.TabIndex = 2
        ' 
        ' rtbMessage
        ' 
        rtbMessage.BackColor = Color.FromArgb(CByte(254), CByte(218), CByte(218))
        rtbMessage.Location = New Point(16, 88)
        rtbMessage.Name = "rtbMessage"
        rtbMessage.Size = New Size(912, 450)
        rtbMessage.TabIndex = 1
        rtbMessage.Text = ""
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(255), CByte(41), CByte(117))
        pnlHeader.Controls.Add(txtServerIP)
        pnlHeader.Controls.Add(btnConnect)
        pnlHeader.Controls.Add(txtUser)
        pnlHeader.Controls.Add(lblUserName)
        pnlHeader.Location = New Point(12, 12)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(920, 61)
        pnlHeader.TabIndex = 0
        ' 
        ' txtServerIP
        ' 
        txtServerIP.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtServerIP.Location = New Point(17, 11)
        txtServerIP.Name = "txtServerIP"
        txtServerIP.Size = New Size(277, 36)
        txtServerIP.TabIndex = 3
        ' 
        ' btnConnect
        ' 
        btnConnect.BackColor = Color.FromArgb(CByte(255), CByte(89), CByte(117))
        btnConnect.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(247), CByte(250))
        btnConnect.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(41), CByte(200))
        btnConnect.FlatStyle = FlatStyle.Flat
        btnConnect.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnConnect.ForeColor = Color.FromArgb(CByte(255), CByte(247), CByte(250))
        btnConnect.Location = New Point(313, 10)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(165, 37)
        btnConnect.TabIndex = 2
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtUser.Location = New Point(687, 11)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(208, 36)
        txtUser.TabIndex = 1
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserName.ForeColor = Color.FromArgb(CByte(255), CByte(247), CByte(250))
        lblUserName.Location = New Point(552, 14)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(129, 28)
        lblUserName.TabIndex = 0
        lblUserName.Text = "Username:"
        ' 
        ' Timer1
        ' 
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 586)
        Controls.Add(pnlMain)
        Name = "frmMain"
        Text = "Chat App"
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents rtbMessage As RichTextBox
    Friend WithEvents txtServerIP As TextBox
    Friend WithEvents Timer1 As Timer
End Class
