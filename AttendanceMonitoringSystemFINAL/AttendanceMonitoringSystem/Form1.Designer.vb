<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.usernamefield = New System.Windows.Forms.TextBox()
        Me.passwordfield = New System.Windows.Forms.TextBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.adminradiobtn = New System.Windows.Forms.RadioButton()
        Me.employeeradiobtn = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateandTime = New System.Windows.Forms.Label()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.usernamefieldx = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.passwordfieldx = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.timeinlogin = New System.Windows.Forms.Label()
        Me.forgotPass = New System.Windows.Forms.LinkLabel()
        Me.timeoutbtn = New System.Windows.Forms.Button()
        Me.timeinbtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(786, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(786, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(790, 448)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(120, 51)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'usernamefield
        '
        Me.usernamefield.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamefield.Location = New System.Drawing.Point(790, 192)
        Me.usernamefield.Name = "usernamefield"
        Me.usernamefield.Size = New System.Drawing.Size(274, 27)
        Me.usernamefield.TabIndex = 4
        '
        'passwordfield
        '
        Me.passwordfield.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordfield.Location = New System.Drawing.Point(790, 288)
        Me.passwordfield.Name = "passwordfield"
        Me.passwordfield.Size = New System.Drawing.Size(274, 27)
        Me.passwordfield.TabIndex = 5
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.DarkRed
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(945, 448)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(120, 51)
        Me.clearbtn.TabIndex = 6
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'adminradiobtn
        '
        Me.adminradiobtn.AutoSize = True
        Me.adminradiobtn.BackColor = System.Drawing.Color.Transparent
        Me.adminradiobtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminradiobtn.ForeColor = System.Drawing.Color.Black
        Me.adminradiobtn.Location = New System.Drawing.Point(790, 378)
        Me.adminradiobtn.Name = "adminradiobtn"
        Me.adminradiobtn.Size = New System.Drawing.Size(129, 23)
        Me.adminradiobtn.TabIndex = 3
        Me.adminradiobtn.TabStop = True
        Me.adminradiobtn.Text = "Administrator"
        Me.adminradiobtn.UseVisualStyleBackColor = False
        '
        'employeeradiobtn
        '
        Me.employeeradiobtn.AutoSize = True
        Me.employeeradiobtn.BackColor = System.Drawing.Color.Transparent
        Me.employeeradiobtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeradiobtn.ForeColor = System.Drawing.Color.Black
        Me.employeeradiobtn.Location = New System.Drawing.Point(959, 378)
        Me.employeeradiobtn.Name = "employeeradiobtn"
        Me.employeeradiobtn.Size = New System.Drawing.Size(105, 23)
        Me.employeeradiobtn.TabIndex = 4
        Me.employeeradiobtn.TabStop = True
        Me.employeeradiobtn.Text = "Employee"
        Me.employeeradiobtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'DateandTime
        '
        Me.DateandTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateandTime.BackColor = System.Drawing.Color.MidnightBlue
        Me.DateandTime.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateandTime.ForeColor = System.Drawing.Color.White
        Me.DateandTime.Location = New System.Drawing.Point(631, 65)
        Me.DateandTime.Name = "DateandTime"
        Me.DateandTime.Size = New System.Drawing.Size(488, 36)
        Me.DateandTime.TabIndex = 10
        Me.DateandTime.Text = "DateTime"
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.MidnightBlue
        Me.BunifuTileButton1.color = System.Drawing.Color.MidnightBlue
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.SlateGray
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Nothing
        Me.BunifuTileButton1.ImagePosition = 25
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 38
        Me.BunifuTileButton1.LabelText = "x"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(1097, -1)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(48, 45)
        Me.BunifuTileButton1.TabIndex = 11
        '
        'usernamefieldx
        '
        Me.usernamefieldx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernamefieldx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.usernamefieldx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usernamefieldx.HintForeColor = System.Drawing.Color.Empty
        Me.usernamefieldx.HintText = ""
        Me.usernamefieldx.isPassword = False
        Me.usernamefieldx.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.usernamefieldx.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.usernamefieldx.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen
        Me.usernamefieldx.LineThickness = 3
        Me.usernamefieldx.Location = New System.Drawing.Point(790, 181)
        Me.usernamefieldx.Margin = New System.Windows.Forms.Padding(4)
        Me.usernamefieldx.Name = "usernamefieldx"
        Me.usernamefieldx.Size = New System.Drawing.Size(274, 44)
        Me.usernamefieldx.TabIndex = 1
        Me.usernamefieldx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'passwordfieldx
        '
        Me.passwordfieldx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordfieldx.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.passwordfieldx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passwordfieldx.HintForeColor = System.Drawing.Color.Empty
        Me.passwordfieldx.HintText = ""
        Me.passwordfieldx.isPassword = False
        Me.passwordfieldx.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.passwordfieldx.LineIdleColor = System.Drawing.Color.MidnightBlue
        Me.passwordfieldx.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen
        Me.passwordfieldx.LineThickness = 3
        Me.passwordfieldx.Location = New System.Drawing.Point(790, 288)
        Me.passwordfieldx.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordfieldx.Name = "passwordfieldx"
        Me.passwordfieldx.Size = New System.Drawing.Size(274, 44)
        Me.passwordfieldx.TabIndex = 2
        Me.passwordfieldx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'timeinlogin
        '
        Me.timeinlogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeinlogin.BackColor = System.Drawing.Color.SlateGray
        Me.timeinlogin.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeinlogin.ForeColor = System.Drawing.Color.White
        Me.timeinlogin.Location = New System.Drawing.Point(959, 65)
        Me.timeinlogin.Name = "timeinlogin"
        Me.timeinlogin.Size = New System.Drawing.Size(344, 36)
        Me.timeinlogin.TabIndex = 17
        Me.timeinlogin.Text = "DateTime"
        '
        'forgotPass
        '
        Me.forgotPass.AutoSize = True
        Me.forgotPass.Location = New System.Drawing.Point(973, 346)
        Me.forgotPass.Name = "forgotPass"
        Me.forgotPass.Size = New System.Drawing.Size(92, 13)
        Me.forgotPass.TabIndex = 18
        Me.forgotPass.TabStop = True
        Me.forgotPass.Text = "Forgot Password?"
        '
        'timeoutbtn
        '
        Me.timeoutbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.timeoutbtn.BackgroundImage = Global.AttendanceMonitoringSystem.My.Resources.Resources.timeouten
        Me.timeoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.timeoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.timeoutbtn.FlatAppearance.BorderSize = 2
        Me.timeoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timeoutbtn.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeoutbtn.ForeColor = System.Drawing.Color.Black
        Me.timeoutbtn.Location = New System.Drawing.Point(383, 137)
        Me.timeoutbtn.Name = "timeoutbtn"
        Me.timeoutbtn.Size = New System.Drawing.Size(226, 222)
        Me.timeoutbtn.TabIndex = 15
        Me.timeoutbtn.UseVisualStyleBackColor = False
        Me.timeoutbtn.Visible = False
        '
        'timeinbtn
        '
        Me.timeinbtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.timeinbtn.BackgroundImage = Global.AttendanceMonitoringSystem.My.Resources.Resources.timeinen
        Me.timeinbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.timeinbtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.timeinbtn.FlatAppearance.BorderSize = 2
        Me.timeinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timeinbtn.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeinbtn.ForeColor = System.Drawing.Color.Black
        Me.timeinbtn.Location = New System.Drawing.Point(86, 137)
        Me.timeinbtn.Name = "timeinbtn"
        Me.timeinbtn.Size = New System.Drawing.Size(226, 222)
        Me.timeinbtn.TabIndex = 14
        Me.timeinbtn.UseVisualStyleBackColor = False
        Me.timeinbtn.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1045, 304)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1045, 199)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(702, 602)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Instruction:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(600, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "■ To view your Profile and Attendance log, enter your username, password and sele" & _
    "ct employee radiobutton."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(415, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "■ If you forgot you password, click the Forgot Password link for assistance."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(536, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "■ For Employee, specify your username and select radiobutton employee to time in " & _
    "and time out."
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1143, 568)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.forgotPass)
        Me.Controls.Add(Me.timeinlogin)
        Me.Controls.Add(Me.timeoutbtn)
        Me.Controls.Add(Me.timeinbtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.passwordfieldx)
        Me.Controls.Add(Me.usernamefieldx)
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.Controls.Add(Me.DateandTime)
        Me.Controls.Add(Me.employeeradiobtn)
        Me.Controls.Add(Me.adminradiobtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.passwordfield)
        Me.Controls.Add(Me.usernamefield)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents loginbtn As System.Windows.Forms.Button
    Friend WithEvents usernamefield As System.Windows.Forms.TextBox
    Friend WithEvents passwordfield As System.Windows.Forms.TextBox
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents adminradiobtn As System.Windows.Forms.RadioButton
    Friend WithEvents employeeradiobtn As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateandTime As System.Windows.Forms.Label
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents usernamefieldx As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents passwordfieldx As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents timeoutbtn As System.Windows.Forms.Button
    Friend WithEvents timeinlogin As System.Windows.Forms.Label
    Friend WithEvents timeinbtn As System.Windows.Forms.Button
    Friend WithEvents forgotPass As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
