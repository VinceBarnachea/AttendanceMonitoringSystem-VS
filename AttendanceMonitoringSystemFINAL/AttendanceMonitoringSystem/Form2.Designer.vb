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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.usernamefield = New System.Windows.Forms.TextBox()
        Me.passwordfield = New System.Windows.Forms.TextBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.adminradiobtn = New System.Windows.Forms.RadioButton()
        Me.employeeradiobtn = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateandTime = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(626, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 444)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(655, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(655, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'loginbtn
        '
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.Location = New System.Drawing.Point(682, 359)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(94, 30)
        Me.loginbtn.TabIndex = 3
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'usernamefield
        '
        Me.usernamefield.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamefield.Location = New System.Drawing.Point(748, 148)
        Me.usernamefield.Name = "usernamefield"
        Me.usernamefield.Size = New System.Drawing.Size(187, 27)
        Me.usernamefield.TabIndex = 4
        '
        'passwordfield
        '
        Me.passwordfield.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordfield.Location = New System.Drawing.Point(748, 200)
        Me.passwordfield.Name = "passwordfield"
        Me.passwordfield.Size = New System.Drawing.Size(187, 27)
        Me.passwordfield.TabIndex = 5
        '
        'clearbtn
        '
        Me.clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.Location = New System.Drawing.Point(820, 359)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(94, 30)
        Me.clearbtn.TabIndex = 6
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'adminradiobtn
        '
        Me.adminradiobtn.AutoSize = True
        Me.adminradiobtn.BackColor = System.Drawing.Color.Transparent
        Me.adminradiobtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminradiobtn.ForeColor = System.Drawing.Color.White
        Me.adminradiobtn.Location = New System.Drawing.Point(658, 267)
        Me.adminradiobtn.Name = "adminradiobtn"
        Me.adminradiobtn.Size = New System.Drawing.Size(97, 19)
        Me.adminradiobtn.TabIndex = 7
        Me.adminradiobtn.TabStop = True
        Me.adminradiobtn.Text = "Administrator"
        Me.adminradiobtn.UseVisualStyleBackColor = False
        '
        'employeeradiobtn
        '
        Me.employeeradiobtn.AutoSize = True
        Me.employeeradiobtn.BackColor = System.Drawing.Color.Transparent
        Me.employeeradiobtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeradiobtn.ForeColor = System.Drawing.Color.White
        Me.employeeradiobtn.Location = New System.Drawing.Point(658, 293)
        Me.employeeradiobtn.Name = "employeeradiobtn"
        Me.employeeradiobtn.Size = New System.Drawing.Size(80, 19)
        Me.employeeradiobtn.TabIndex = 8
        Me.employeeradiobtn.TabStop = True
        Me.employeeradiobtn.Text = "Employee"
        Me.employeeradiobtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(987, 50)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'DateandTime
        '
        Me.DateandTime.AutoSize = True
        Me.DateandTime.BackColor = System.Drawing.SystemColors.Control
        Me.DateandTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateandTime.ForeColor = System.Drawing.Color.White
        Me.DateandTime.Location = New System.Drawing.Point(12, 28)
        Me.DateandTime.Name = "DateandTime"
        Me.DateandTime.Size = New System.Drawing.Size(140, 36)
        Me.DateandTime.TabIndex = 10
        Me.DateandTime.Text = "DateTime"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 568)
        Me.Controls.Add(Me.DateandTime)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.employeeradiobtn)
        Me.Controls.Add(Me.adminradiobtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.passwordfield)
        Me.Controls.Add(Me.usernamefield)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateandTime As System.Windows.Forms.Label

End Class
