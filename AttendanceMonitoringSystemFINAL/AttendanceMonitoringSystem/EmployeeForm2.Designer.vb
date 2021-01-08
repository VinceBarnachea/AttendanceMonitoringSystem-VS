<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeForm2))
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.employeetime = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.attendancebtn = New System.Windows.Forms.Button()
        Me.profilebtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.timeoutbtn = New System.Windows.Forms.Button()
        Me.timeinbtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.datedhireddisplay = New System.Windows.Forms.Label()
        Me.departmentdisplay = New System.Windows.Forms.Label()
        Me.contactdisplay = New System.Windows.Forms.Label()
        Me.addressdisplay = New System.Windows.Forms.Label()
        Me.fullnamedisplay = New System.Windows.Forms.Label()
        Me.employeeiddisplay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateLoggedInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblattendancelogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet1 = New AttendanceMonitoringSystem.Database2DataSet1()
        Me.Tbl_attendance_logsTableAdapter = New AttendanceMonitoringSystem.Database2DataSet1TableAdapters.tbl_attendance_logsTableAdapter()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblattendancelogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'avatar
        '
        Me.avatar.BackColor = System.Drawing.Color.White
        Me.avatar.BackgroundImage = CType(resources.GetObject("avatar.BackgroundImage"), System.Drawing.Image)
        Me.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.avatar.Location = New System.Drawing.Point(32, 24)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(151, 138)
        Me.avatar.TabIndex = 1
        Me.avatar.TabStop = False
        '
        'logoutbtn
        '
        Me.logoutbtn.BackColor = System.Drawing.Color.Navy
        Me.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.Color.White
        Me.logoutbtn.Location = New System.Drawing.Point(0, 325)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(215, 49)
        Me.logoutbtn.TabIndex = 15
        Me.logoutbtn.Text = "LOG OUT"
        Me.logoutbtn.UseVisualStyleBackColor = False
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.Navy
        Me.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.ForeColor = System.Drawing.Color.White
        Me.homebtn.Location = New System.Drawing.Point(0, 1)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(215, 54)
        Me.homebtn.TabIndex = 16
        Me.homebtn.Text = "HOME"
        Me.homebtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.employeetime)
        Me.Panel2.Location = New System.Drawing.Point(218, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 72)
        Me.Panel2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 31)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "dateandtime"
        '
        'employeetime
        '
        Me.employeetime.AutoSize = True
        Me.employeetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeetime.ForeColor = System.Drawing.Color.White
        Me.employeetime.Location = New System.Drawing.Point(510, 18)
        Me.employeetime.Name = "employeetime"
        Me.employeetime.Size = New System.Drawing.Size(163, 31)
        Me.employeetime.TabIndex = 0
        Me.employeetime.Text = "dateandtime"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 190)
        Me.Panel3.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Controls.Add(Me.homebtn)
        Me.Panel4.Controls.Add(Me.attendancebtn)
        Me.Panel4.Controls.Add(Me.logoutbtn)
        Me.Panel4.Controls.Add(Me.profilebtn)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Location = New System.Drawing.Point(0, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 375)
        Me.Panel4.TabIndex = 20
        '
        'attendancebtn
        '
        Me.attendancebtn.BackColor = System.Drawing.Color.Navy
        Me.attendancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.attendancebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendancebtn.ForeColor = System.Drawing.Color.White
        Me.attendancebtn.Location = New System.Drawing.Point(0, 107)
        Me.attendancebtn.Name = "attendancebtn"
        Me.attendancebtn.Size = New System.Drawing.Size(215, 54)
        Me.attendancebtn.TabIndex = 18
        Me.attendancebtn.Text = "ATTENDANCE LOGS"
        Me.attendancebtn.UseVisualStyleBackColor = False
        '
        'profilebtn
        '
        Me.profilebtn.BackColor = System.Drawing.Color.Navy
        Me.profilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profilebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profilebtn.ForeColor = System.Drawing.Color.White
        Me.profilebtn.Location = New System.Drawing.Point(0, 54)
        Me.profilebtn.Name = "profilebtn"
        Me.profilebtn.Size = New System.Drawing.Size(215, 54)
        Me.profilebtn.TabIndex = 17
        Me.profilebtn.Text = "PROFILE"
        Me.profilebtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(214, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(663, 511)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.timeoutbtn)
        Me.TabPage1.Controls.Add(Me.timeinbtn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(655, 485)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'timeoutbtn
        '
        Me.timeoutbtn.BackColor = System.Drawing.Color.Navy
        Me.timeoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timeoutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeoutbtn.ForeColor = System.Drawing.Color.White
        Me.timeoutbtn.Location = New System.Drawing.Point(394, 338)
        Me.timeoutbtn.Name = "timeoutbtn"
        Me.timeoutbtn.Size = New System.Drawing.Size(213, 88)
        Me.timeoutbtn.TabIndex = 1
        Me.timeoutbtn.Text = "TIME OUT"
        Me.timeoutbtn.UseVisualStyleBackColor = False
        '
        'timeinbtn
        '
        Me.timeinbtn.BackColor = System.Drawing.Color.Navy
        Me.timeinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timeinbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeinbtn.ForeColor = System.Drawing.Color.White
        Me.timeinbtn.Location = New System.Drawing.Point(42, 338)
        Me.timeinbtn.Name = "timeinbtn"
        Me.timeinbtn.Size = New System.Drawing.Size(213, 88)
        Me.timeinbtn.TabIndex = 0
        Me.timeinbtn.Text = "TIME IN"
        Me.timeinbtn.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.datedhireddisplay)
        Me.TabPage2.Controls.Add(Me.departmentdisplay)
        Me.TabPage2.Controls.Add(Me.contactdisplay)
        Me.TabPage2.Controls.Add(Me.addressdisplay)
        Me.TabPage2.Controls.Add(Me.fullnamedisplay)
        Me.TabPage2.Controls.Add(Me.employeeiddisplay)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(655, 485)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Profile"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'datedhireddisplay
        '
        Me.datedhireddisplay.AutoSize = True
        Me.datedhireddisplay.Location = New System.Drawing.Point(207, 328)
        Me.datedhireddisplay.Name = "datedhireddisplay"
        Me.datedhireddisplay.Size = New System.Drawing.Size(39, 13)
        Me.datedhireddisplay.TabIndex = 23
        Me.datedhireddisplay.Text = "Label8"
        '
        'departmentdisplay
        '
        Me.departmentdisplay.AutoSize = True
        Me.departmentdisplay.Location = New System.Drawing.Point(207, 264)
        Me.departmentdisplay.Name = "departmentdisplay"
        Me.departmentdisplay.Size = New System.Drawing.Size(39, 13)
        Me.departmentdisplay.TabIndex = 22
        Me.departmentdisplay.Text = "Label9"
        '
        'contactdisplay
        '
        Me.contactdisplay.AutoSize = True
        Me.contactdisplay.Location = New System.Drawing.Point(207, 208)
        Me.contactdisplay.Name = "contactdisplay"
        Me.contactdisplay.Size = New System.Drawing.Size(45, 13)
        Me.contactdisplay.TabIndex = 21
        Me.contactdisplay.Text = "Label10"
        '
        'addressdisplay
        '
        Me.addressdisplay.AutoSize = True
        Me.addressdisplay.Location = New System.Drawing.Point(207, 150)
        Me.addressdisplay.Name = "addressdisplay"
        Me.addressdisplay.Size = New System.Drawing.Size(45, 13)
        Me.addressdisplay.TabIndex = 20
        Me.addressdisplay.Text = "Label11"
        '
        'fullnamedisplay
        '
        Me.fullnamedisplay.AutoSize = True
        Me.fullnamedisplay.Location = New System.Drawing.Point(207, 95)
        Me.fullnamedisplay.Name = "fullnamedisplay"
        Me.fullnamedisplay.Size = New System.Drawing.Size(45, 13)
        Me.fullnamedisplay.TabIndex = 19
        Me.fullnamedisplay.Text = "Label12"
        '
        'employeeiddisplay
        '
        Me.employeeiddisplay.AutoSize = True
        Me.employeeiddisplay.Location = New System.Drawing.Point(207, 46)
        Me.employeeiddisplay.Name = "employeeiddisplay"
        Me.employeeiddisplay.Size = New System.Drawing.Size(45, 13)
        Me.employeeiddisplay.TabIndex = 18
        Me.employeeiddisplay.Text = "Label13"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Date Hired :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Contact Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Address : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Full Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Employee ID :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(655, 485)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Attendance Logs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateLoggedInDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.TimeInDataGridViewTextBoxColumn, Me.TimeOutDataGridViewTextBoxColumn, Me.LateDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblattendancelogsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(655, 485)
        Me.DataGridView1.TabIndex = 0
        '
        'DateLoggedInDataGridViewTextBoxColumn
        '
        Me.DateLoggedInDataGridViewTextBoxColumn.DataPropertyName = "DateLoggedIn"
        Me.DateLoggedInDataGridViewTextBoxColumn.HeaderText = "DateLoggedIn"
        Me.DateLoggedInDataGridViewTextBoxColumn.Name = "DateLoggedInDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'TimeInDataGridViewTextBoxColumn
        '
        Me.TimeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.HeaderText = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.Name = "TimeInDataGridViewTextBoxColumn"
        '
        'TimeOutDataGridViewTextBoxColumn
        '
        Me.TimeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.Name = "TimeOutDataGridViewTextBoxColumn"
        '
        'LateDataGridViewTextBoxColumn
        '
        Me.LateDataGridViewTextBoxColumn.DataPropertyName = "Late"
        Me.LateDataGridViewTextBoxColumn.HeaderText = "Late"
        Me.LateDataGridViewTextBoxColumn.Name = "LateDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'TblattendancelogsBindingSource
        '
        Me.TblattendancelogsBindingSource.DataMember = "tbl_attendance_logs"
        Me.TblattendancelogsBindingSource.DataSource = Me.Database2DataSet1
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_attendance_logsTableAdapter
        '
        Me.Tbl_attendance_logsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.avatar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeForm"
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblattendancelogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents avatar As System.Windows.Forms.PictureBox
    Friend WithEvents logoutbtn As System.Windows.Forms.Button
    Friend WithEvents homebtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents employeetime As System.Windows.Forms.Label
    Friend WithEvents attendancebtn As System.Windows.Forms.Button
    Friend WithEvents profilebtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datedhireddisplay As System.Windows.Forms.Label
    Friend WithEvents departmentdisplay As System.Windows.Forms.Label
    Friend WithEvents contactdisplay As System.Windows.Forms.Label
    Friend WithEvents addressdisplay As System.Windows.Forms.Label
    Friend WithEvents fullnamedisplay As System.Windows.Forms.Label
    Friend WithEvents employeeiddisplay As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents timeoutbtn As System.Windows.Forms.Button
    Friend WithEvents timeinbtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database2DataSet1 As AttendanceMonitoringSystem.Database2DataSet1
    Friend WithEvents TblattendancelogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_attendance_logsTableAdapter As AttendanceMonitoringSystem.Database2DataSet1TableAdapters.tbl_attendance_logsTableAdapter
    Friend WithEvents DateLoggedInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
