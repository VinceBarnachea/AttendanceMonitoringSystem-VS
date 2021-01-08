<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEmployeeBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addEmployeeBox))
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.singles = New System.Windows.Forms.RadioButton()
        Me.married = New System.Windows.Forms.RadioButton()
        Me.widowed = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.dateHired = New System.Windows.Forms.DateTimePicker()
        Me.department = New System.Windows.Forms.ComboBox()
        Me.expectedTimein = New System.Windows.Forms.ComboBox()
        Me.expectedTimeout = New System.Windows.Forms.ComboBox()
        Me.Database2DataSet1 = New AttendanceMonitoringSystem.Database2DataSet1()
        Me.Tbl_employee_recordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_employee_recordsTableAdapter = New AttendanceMonitoringSystem.Database2DataSet1TableAdapters.tbl_employee_recordsTableAdapter()
        Me.TableAdapterManager = New AttendanceMonitoringSystem.Database2DataSet1TableAdapters.TableAdapterManager()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.mName = New System.Windows.Forms.TextBox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.address = New System.Windows.Forms.TextBox()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.age = New System.Windows.Forms.TextBox()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.contactNo = New System.Windows.Forms.MaskedTextBox()
        Me.emailAddress = New System.Windows.Forms.TextBox()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
        Me.employeeID = New System.Windows.Forms.TextBox()
        Me.GunaButton8 = New Guna.UI.WinForms.GunaButton()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_employee_recordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female.Location = New System.Drawing.Point(3, 27)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(64, 19)
        Me.Female.TabIndex = 11
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.male.Location = New System.Drawing.Point(3, 6)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(52, 19)
        Me.male.TabIndex = 10
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(411, 427)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Birthday:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(588, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Contact No:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 500)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 20)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Department:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(587, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Gender:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(283, 427)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Age:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Middle Initial:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(284, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Last Name(Extension Name):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(254, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Employee Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 36)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Add New Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Date Hired:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(717, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Civil Status:"
        '
        'singles
        '
        Me.singles.AutoSize = True
        Me.singles.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.singles.Location = New System.Drawing.Point(3, 3)
        Me.singles.Name = "singles"
        Me.singles.Size = New System.Drawing.Size(58, 19)
        Me.singles.TabIndex = 13
        Me.singles.TabStop = True
        Me.singles.Text = "Single"
        Me.singles.UseVisualStyleBackColor = True
        '
        'married
        '
        Me.married.AutoSize = True
        Me.married.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.married.Location = New System.Drawing.Point(3, 21)
        Me.married.Name = "married"
        Me.married.Size = New System.Drawing.Size(67, 19)
        Me.married.TabIndex = 14
        Me.married.TabStop = True
        Me.married.Text = "Married"
        Me.married.UseVisualStyleBackColor = True
        '
        'widowed
        '
        Me.widowed.AutoSize = True
        Me.widowed.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widowed.Location = New System.Drawing.Point(3, 40)
        Me.widowed.Name = "widowed"
        Me.widowed.Size = New System.Drawing.Size(75, 19)
        Me.widowed.TabIndex = 15
        Me.widowed.TabStop = True
        Me.widowed.Text = "Widowed"
        Me.widowed.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.singles)
        Me.Panel1.Controls.Add(Me.widowed)
        Me.Panel1.Controls.Add(Me.married)
        Me.Panel1.Location = New System.Drawing.Point(731, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(90, 61)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.male)
        Me.Panel2.Controls.Add(Me.Female)
        Me.Panel2.Location = New System.Drawing.Point(603, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(89, 61)
        Me.Panel2.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(589, 321)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 20)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Email Address:"
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.saveBtn.FlatAppearance.BorderSize = 0
        Me.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveBtn.Location = New System.Drawing.Point(599, 549)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(104, 46)
        Me.saveBtn.TabIndex = 17
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(589, 399)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Expected Time In:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(589, 458)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(149, 20)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Expected Time Out:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SlateGray
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(858, 45)
        Me.Panel3.TabIndex = 62
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.Turquoise
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.MediumAquamarine
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.Enabled = False
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(0, 43)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Size = New System.Drawing.Size(237, 576)
        Me.GunaGradientButton1.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 584)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'birthday
        '
        Me.birthday.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthday.Location = New System.Drawing.Point(411, 457)
        Me.birthday.MaxDate = New Date(2001, 12, 31, 0, 0, 0, 0)
        Me.birthday.MinDate = New Date(1960, 1, 1, 0, 0, 0, 0)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(98, 23)
        Me.birthday.TabIndex = 8
        Me.birthday.Value = New Date(2001, 1, 1, 0, 0, 0, 0)
        '
        'dateHired
        '
        Me.dateHired.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateHired.Location = New System.Drawing.Point(591, 221)
        Me.dateHired.MaxDate = New Date(2021, 12, 31, 0, 0, 0, 0)
        Me.dateHired.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dateHired.Name = "dateHired"
        Me.dateHired.Size = New System.Drawing.Size(99, 23)
        Me.dateHired.TabIndex = 9
        '
        'department
        '
        Me.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.department.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.department.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department.FormattingEnabled = True
        Me.department.Items.AddRange(New Object() {"CAS", "CITE", "CMA", "CEA", "CHS", "CSS", "SHS", "High School Department", "HR", "Marketing", "Finance", "ITS", "GSD", "CSDL", "Registrar"})
        Me.department.Location = New System.Drawing.Point(288, 525)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(218, 25)
        Me.department.TabIndex = 5
        '
        'expectedTimein
        '
        Me.expectedTimein.BackColor = System.Drawing.Color.White
        Me.expectedTimein.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.expectedTimein.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expectedTimein.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expectedTimein.FormattingEnabled = True
        Me.expectedTimein.Items.AddRange(New Object() {"7:00 AM", "7:30 AM", "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM", "7:30 PM"})
        Me.expectedTimein.Location = New System.Drawing.Point(592, 424)
        Me.expectedTimein.Name = "expectedTimein"
        Me.expectedTimein.Size = New System.Drawing.Size(121, 25)
        Me.expectedTimein.TabIndex = 14
        '
        'expectedTimeout
        '
        Me.expectedTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.expectedTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expectedTimeout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expectedTimeout.FormattingEnabled = True
        Me.expectedTimeout.Items.AddRange(New Object() {"7:00 AM", "7:30 AM", "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM", "7:30 PM"})
        Me.expectedTimeout.Location = New System.Drawing.Point(592, 483)
        Me.expectedTimeout.Name = "expectedTimeout"
        Me.expectedTimeout.Size = New System.Drawing.Size(121, 25)
        Me.expectedTimeout.TabIndex = 15
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_employee_recordsBindingSource
        '
        Me.Tbl_employee_recordsBindingSource.DataMember = "tbl_employee_records"
        Me.Tbl_employee_recordsBindingSource.DataSource = Me.Database2DataSet1
        '
        'Tbl_employee_recordsTableAdapter
        '
        Me.Tbl_employee_recordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_accountsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_attendanceLogsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_employee_recordsTableAdapter = Me.Tbl_employee_recordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = AttendanceMonitoringSystem.Database2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lName
        '
        Me.lName.BackColor = System.Drawing.Color.White
        Me.lName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lName.ForeColor = System.Drawing.Color.Gray
        Me.lName.Location = New System.Drawing.Point(299, 201)
        Me.lName.MaxLength = 30
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(207, 16)
        Me.lName.TabIndex = 2
        Me.lName.Text = "e.g. Dela Cruz Jr."
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(285, 191)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton1.TabIndex = 21
        '
        'fName
        '
        Me.fName.BackColor = System.Drawing.Color.White
        Me.fName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fName.Location = New System.Drawing.Point(299, 266)
        Me.fName.MaxLength = 30
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(207, 16)
        Me.fName.TabIndex = 3
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton2.BorderSize = 1
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(285, 256)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton2.Radius = 15
        Me.GunaButton2.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton2.TabIndex = 22
        '
        'mName
        '
        Me.mName.BackColor = System.Drawing.Color.White
        Me.mName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mName.Location = New System.Drawing.Point(299, 334)
        Me.mName.MaxLength = 3
        Me.mName.Name = "mName"
        Me.mName.Size = New System.Drawing.Size(207, 16)
        Me.mName.TabIndex = 4
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.White
        Me.GunaButton3.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton3.BorderSize = 1
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(285, 324)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton3.Radius = 15
        Me.GunaButton3.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton3.TabIndex = 23
        '
        'address
        '
        Me.address.BackColor = System.Drawing.Color.White
        Me.address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.address.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(297, 398)
        Me.address.MaxLength = 100
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(207, 16)
        Me.address.TabIndex = 6
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.White
        Me.GunaButton4.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton4.BorderSize = 1
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(283, 388)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton4.Radius = 15
        Me.GunaButton4.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton4.TabIndex = 24
        '
        'age
        '
        Me.age.BackColor = System.Drawing.Color.White
        Me.age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.age.Enabled = False
        Me.age.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(287, 458)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(56, 16)
        Me.age.TabIndex = 7
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.White
        Me.GunaButton5.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton5.BorderSize = 1
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton5.ForeColor = System.Drawing.Color.White
        Me.GunaButton5.Image = Nothing
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(284, 450)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton5.Radius = 15
        Me.GunaButton5.Size = New System.Drawing.Size(103, 36)
        Me.GunaButton5.TabIndex = 25
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BaseColor = System.Drawing.Color.White
        Me.GunaButton6.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton6.BorderSize = 1
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton6.ForeColor = System.Drawing.Color.White
        Me.GunaButton6.Image = Nothing
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(592, 280)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton6.Radius = 15
        Me.GunaButton6.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton6.TabIndex = 26
        '
        'contactNo
        '
        Me.contactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.contactNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.Location = New System.Drawing.Point(604, 290)
        Me.contactNo.Mask = "0000-000-0000"
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(208, 16)
        Me.contactNo.TabIndex = 12
        '
        'emailAddress
        '
        Me.emailAddress.BackColor = System.Drawing.Color.White
        Me.emailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailAddress.Location = New System.Drawing.Point(605, 356)
        Me.emailAddress.MaxLength = 50
        Me.emailAddress.Name = "emailAddress"
        Me.emailAddress.Size = New System.Drawing.Size(207, 16)
        Me.emailAddress.TabIndex = 13
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton7.BaseColor = System.Drawing.Color.White
        Me.GunaButton7.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton7.BorderSize = 1
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton7.ForeColor = System.Drawing.Color.White
        Me.GunaButton7.Image = Nothing
        Me.GunaButton7.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton7.Location = New System.Drawing.Point(591, 346)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton7.Radius = 15
        Me.GunaButton7.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton7.TabIndex = 27
        '
        'employeeID
        '
        Me.employeeID.BackColor = System.Drawing.Color.White
        Me.employeeID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.employeeID.Enabled = False
        Me.employeeID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeID.Location = New System.Drawing.Point(299, 135)
        Me.employeeID.Name = "employeeID"
        Me.employeeID.ReadOnly = True
        Me.employeeID.Size = New System.Drawing.Size(207, 16)
        Me.employeeID.TabIndex = 1
        '
        'GunaButton8
        '
        Me.GunaButton8.AnimationHoverSpeed = 0.07!
        Me.GunaButton8.AnimationSpeed = 0.03!
        Me.GunaButton8.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton8.BaseColor = System.Drawing.Color.White
        Me.GunaButton8.BorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton8.BorderSize = 1
        Me.GunaButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton8.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton8.ForeColor = System.Drawing.Color.White
        Me.GunaButton8.Image = Nothing
        Me.GunaButton8.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton8.Location = New System.Drawing.Point(285, 125)
        Me.GunaButton8.Name = "GunaButton8"
        Me.GunaButton8.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton8.OnHoverBorderColor = System.Drawing.Color.SeaGreen
        Me.GunaButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton8.OnHoverImage = Nothing
        Me.GunaButton8.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton8.Radius = 15
        Me.GunaButton8.Size = New System.Drawing.Size(233, 36)
        Me.GunaButton8.TabIndex = 1
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.Crimson
        Me.clearBtn.FlatAppearance.BorderSize = 0
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clearBtn.Location = New System.Drawing.Point(720, 549)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(104, 46)
        Me.clearBtn.TabIndex = 16
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'addEmployeeBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.employeeID)
        Me.Controls.Add(Me.GunaButton8)
        Me.Controls.Add(Me.emailAddress)
        Me.Controls.Add(Me.GunaButton7)
        Me.Controls.Add(Me.contactNo)
        Me.Controls.Add(Me.GunaButton6)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.GunaButton5)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.mName)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.expectedTimeout)
        Me.Controls.Add(Me.expectedTimein)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.dateHired)
        Me.Controls.Add(Me.birthday)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GunaGradientButton1)
        Me.Name = "addEmployeeBox"
        Me.Size = New System.Drawing.Size(858, 621)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_employee_recordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Female As System.Windows.Forms.RadioButton
    Friend WithEvents male As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents singles As System.Windows.Forms.RadioButton
    Friend WithEvents married As System.Windows.Forms.RadioButton
    Friend WithEvents widowed As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents birthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents department As System.Windows.Forms.ComboBox
    Friend WithEvents expectedTimein As System.Windows.Forms.ComboBox
    Friend WithEvents expectedTimeout As System.Windows.Forms.ComboBox
    Friend WithEvents Database2DataSet1 As AttendanceMonitoringSystem.Database2DataSet1
    Friend WithEvents Tbl_employee_recordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_employee_recordsTableAdapter As AttendanceMonitoringSystem.Database2DataSet1TableAdapters.tbl_employee_recordsTableAdapter
    Friend WithEvents TableAdapterManager As AttendanceMonitoringSystem.Database2DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents lName As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents fName As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents mName As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents age As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents contactNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents emailAddress As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents employeeID As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents clearBtn As System.Windows.Forms.Button

End Class
