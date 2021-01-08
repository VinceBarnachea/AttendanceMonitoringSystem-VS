Imports System.Data.OleDb

Public Class EmployeeForm
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")
    Dim ask As MsgBoxResult
    Dim dr As OleDbDataReader
    Dim name_ As String
    Dim counter As Integer = 0
    Private temp As String
    Private temp2 As String
    Private expectedtimein As Date
    Private expectedtimeout As Date
    Private dayyesterday As String
    Private dateyesterday As String
    Dim contact As String
    Dim email As String

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AssignValidation(Me.contactdisplay, ValidationType.Only_Numbers)
        Timer1.Enabled = True
        con.Open()
        Label7.Text = LoginForm.passString
        If LoginForm.gender = "Male" Then
            avatar.BackgroundImage = My.Resources.male
        ElseIf LoginForm.gender = "Female" Then
            avatar.BackgroundImage = My.Resources.female
        End If

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE employeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        employeeiddisplay.Text = dt.Rows(0).Item(0)
        fullnamedisplay.Text = dt.Rows(0).Item(1) + " " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
        addressdisplay.Text = dt.Rows(0).Item(4)
        contactdisplay.Text = dt.Rows(0).Item(5)
        departmentdisplay.Text = dt.Rows(0).Item(6)
        agedisplay.Text = dt.Rows(0).Item(8)
        genderdisplay.Text = dt.Rows(0).Item(9)
        birthdaydisplay.Text = dt.Rows(0).Item(10)
        statusdisplay.Text = dt.Rows(0).Item(11)
        datehireddisplay.Text = dt.Rows(0).Item(7)
        emaildisplay.Text = dt.Rows(0).Item(12)

        employeeiddisplay.BackColor = Color.White
        fullnamedisplay.BackColor = Color.White
        addressdisplay.BackColor = Color.White
        departmentdisplay.BackColor = Color.White
        agedisplay.BackColor = Color.White
        genderdisplay.BackColor = Color.White
        birthdaydisplay.BackColor = Color.White
        statusdisplay.BackColor = Color.White
        datehireddisplay.BackColor = Color.White
        contactdisplay.BackColor = Color.White
        emaildisplay.BackColor = Color.White

        GunaButton1.BackColor = Color.White
        GunaButton2.BackColor = Color.White
        GunaButton3.BackColor = Color.White
        GunaButton4.BackColor = Color.White
        GunaButton5.BackColor = Color.White
        GunaButton6.BackColor = Color.White
        GunaButton8.BackColor = Color.White
        GunaButton10.BackColor = Color.White
        GunaButton11.BackColor = Color.White
        GunaButton12.BackColor = Color.White
        GunaButton13.BackColor = Color.White

        name_ = dt.Rows(0).Item(1)

        savebtnprofile.Hide()
        cancelbtn.Hide()
        'timeintimeout()
        'showchecked()
        'showchecked2()
        'If temp = "" Then
        '    BunifuTileButton3.Enabled = True
        'Else
        '    BunifuTileButton3.Enabled = False
        'End If
        'If Not temp2 = "" Then
        '    BunifuTileButton2.Enabled = False
        'Else
        '    BunifuTileButton2.Enabled = True
        'End If
        'getyesterday()
    End Sub




    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        ask = MsgBox("Are you sure?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Logout")
        If ask = MsgBoxResult.Ok Then

            con.Close()
            LoginForm.usernamefieldx.Text = Nothing
            LoginForm.passwordfieldx.Text = Nothing
            LoginForm.adminradiobtn.Checked = False
            LoginForm.employeeradiobtn.Checked = False

            counter = 0
            'timeinbtn.Enabled = True
            'timeinbtn.BackColor = Color.Navy

            LoginForm.Show()
            Me.Close()
        Else
            Me.Refresh()
        End If

    End Sub


    Private Sub profilebtn_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        TabControl1.SelectTab(1)
        position(profilebtn)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE employeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        employeeiddisplay.Text = dt.Rows(0).Item(0)
        fullnamedisplay.Text = dt.Rows(0).Item(1) + " " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
        addressdisplay.Text = dt.Rows(0).Item(4)
        contactdisplay.Text = dt.Rows(0).Item(5)
        departmentdisplay.Text = dt.Rows(0).Item(6)
        agedisplay.Text = dt.Rows(0).Item(8)
        genderdisplay.Text = dt.Rows(0).Item(9)
        birthdaydisplay.Text = dt.Rows(0).Item(10)
        statusdisplay.Text = dt.Rows(0).Item(11)
        datehireddisplay.Text = dt.Rows(0).Item(7)
        emaildisplay.Text = dt.Rows(0).Item(12)
        'expectedtimeindisplay.Text = dt.Rows(0).Item(13)
        'expectedtimeoutdisplay.Text = dt.Rows(0).Item(14)

        name_ = dt.Rows(0).Item(1)


    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs)
        TabControl1.SelectTab(0)
    End Sub

    Private Sub attendancebtn_Click(sender As Object, e As EventArgs) Handles attendancebtn.Click
        TabControl1.SelectTab(2)
        position(attendancebtn)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim bsource As New BindingSource
        da = New OleDbDataAdapter("SELECT * FROM tbl_attendanceLogs WHERE employeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)
        bsource.DataSource = dt
        GunaDataGridView1.DataSource = bsource
        da.Update(dt)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        employeetime.Text = DateTime.Now.ToString("MMMM dd, dddd                                              hh:mm:ss tt ")
    End Sub

    Private Sub showchecked()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT TimeIn FROM tbl_attendanceLogs WHERE Date = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            temp = dt.Rows(0).Item(0)
        Catch ex As Exception
            temp = ""
        End Try




    End Sub

    Private Sub late()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT ExpectedTimein FROM tbl_employee_records WHERE EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            expectedtimein = dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub getyesterday()
        Dim yesterday As String = Now().AddDays(-1).ToString("dd/MM/yyyy")
        dayyesterday = Now().AddDays(-1).ToString("dddd")
        Dim cmd As New OleDbCommand
        cmd = New OleDbCommand("SELECT * FROM tbl_attendanceLogs WHERE EmployeeID = '" & LoginForm.usernamefieldx.Text & "' AND Date = '" & yesterday & "'", con)
        Dim drlog As OleDbDataReader = cmd.ExecuteReader

        If (drlog.Read() = True) Then
            dateyesterday = "failed"
        Else
            dateyesterday = "empty"
        End If
    End Sub

    'Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
    '    Dim datenow As String
    '    Dim timenow As String
    '    datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
    '    timenow = TimeOfDay.ToString("hh:mm:ss tt")
    '    showchecked()
    '    late()

    '    If temp = "" Then
    '        Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tbl_attendanceLogs([Date],[EmployeeID],[EmployeeName],[TimeIn],[Tardy],[loginchecker],[tardyMinutes]) VALUES(?,?,?,?,?,?,?)", LoginForm.con)
    '        cmd.Parameters.Add(New OleDbParameter("Date", CType(datenow, String)))
    '        cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(LoginForm.usernamefield.Text, String)))
    '        cmd.Parameters.Add(New OleDbParameter("EmployeeName", CType(LoginForm.passString, String)))
    '        cmd.Parameters.Add(New OleDbParameter("TimeIn", CType(timenow, String)))
    '        Dim StartTime As DateTime = expectedtimein
    '        Dim currentTime As DateTime = timenow
    '        Dim TimeDiff As TimeSpan = currentTime.Subtract(StartTime)
    '        If StartTime.TimeOfDay < DateTime.Now.TimeOfDay Then

    '            Dim result As Integer = TimeDiff.TotalMinutes
    '            Dim Hour = result \ 60
    '            Dim Minute = result Mod 60
    '            cmd.Parameters.Add(New OleDbParameter("Tardy", CType(Hour & "h " & Minute & "m", String)))
    '            cmd.Parameters.Add(New OleDbParameter("loginchecker", CType("True", String)))
    '            cmd.Parameters.Add(New OleDbParameter("tardyMinutes", CType(result.ToString, String)))
    '        Else
    '            cmd.Parameters.Add(New OleDbParameter("Tardy", CType("no", String)))
    '            cmd.Parameters.Add(New OleDbParameter("loginchecker", CType("True", String)))
    '        End If

    '        cmd.ExecuteNonQuery()
    '        MsgBox("Time In Successfully")
    '        timeinbtn.Enabled = False
    '    Else
    '        MsgBox("Can only time in once!")
    '    End If


    'End Sub

    Private Sub showchecked2()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT TimeOut FROM tbl_attendanceLogs WHERE Date = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            temp2 = dt.Rows(0).Item(0)
        Catch ex As Exception
            temp2 = ""
        End Try

    End Sub

    Private Sub undertime()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT ExpectedTimeout FROM tbl_employee_records WHERE EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            expectedtimeout = dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try

    End Sub

    'Private Sub timeoutbtn_Click(sender As Object, e As EventArgs) Handles timeoutbtn.Click
    '    Dim datenow As String
    '    Dim timenow As String
    '    datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
    '    timenow = TimeOfDay.ToString("hh:mm tt")
    '    showchecked2()
    '    undertime()
    '    Dim StartTime As DateTime = expectedtimeout
    '    Dim currentTime As DateTime = timenow
    '    Dim TimeDiff As TimeSpan = StartTime.Subtract(currentTime)

    '    Dim result As Integer = TimeDiff.TotalMinutes
    '    Dim Hour = result \ 60
    '    Dim Minute = result Mod 60
    '    Dim under As String = Hour & "h " & Minute & "m"
    '    Label8.Text = expectedtimeout
    '    If Not temp2 = "True" Then
    '        If StartTime.TimeOfDay < DateTime.Now.TimeOfDay Then
    '            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET TimeOut = '" & timenow & "', Undertime = '', timeoutchecker = 'True' WHERE Date = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", LoginForm.con)
    '            cmd.ExecuteNonQuery()

    '        ElseIf StartTime.TimeOfDay > DateTime.Now.TimeOfDay Then
    '            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET TimeOut = '" & timenow & "', Undertime = '" & under & "', timeoutchecker = 'True' WHERE Date = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", LoginForm.con)
    '            Dim cmd2 As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET underTimeMinutes = '" & result.ToString & "' WHERE [EmployeeID] = '" & LoginForm.usernamefieldx.Text & "' AND Date = '" & datenow & "'", LoginForm.con)
    '            cmd.ExecuteNonQuery()
    '            cmd2.ExecuteNonQuery()
    '        End If
    '        MsgBox("Time Out Successfully")
    '        timeoutbtn.Enabled = False
    '    Else
    '        MsgBox("Can only time out once!")
    '    End If

    'End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Do you want to close the System?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit")
        If ask = MsgBoxResult.Yes Then
            Me.Close()
        Else
            If ask = MsgBoxResult.No Then

            End If
        End If

    End Sub

    

    'Private Sub timeintimeout()
    'Dim ds As New DataSet
    'Dim dt As New DataTable
    '    ds.Tables.Add(dt)
    'Dim da As New OleDbDataAdapter
    '    da = New OleDbDataAdapter("SELECT ExpectedTimein, ExpectedTimeout FROM tbl_employee_records WHERE employeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
    '    da.Fill(dt)

    '    expectedtimeindisplay.Text = dt.Rows(0).Item(0)
    '    expectedtimeoutdisplay.Text = dt.Rows(0).Item(1)
    'End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        TabControl1.SelectTab(0)
        position(profilebtn)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE employeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        employeeiddisplay.Text = dt.Rows(0).Item(0)
        fullnamedisplay.Text = dt.Rows(0).Item(1) + " " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
        addressdisplay.Text = dt.Rows(0).Item(4)
        contactdisplay.Text = dt.Rows(0).Item(5)
        departmentdisplay.Text = dt.Rows(0).Item(6)
        agedisplay.Text = dt.Rows(0).Item(8)
        genderdisplay.Text = dt.Rows(0).Item(9)
        birthdaydisplay.Text = dt.Rows(0).Item(10)
        statusdisplay.Text = dt.Rows(0).Item(11)
        datehireddisplay.Text = dt.Rows(0).Item(7)
        emaildisplay.Text = dt.Rows(0).Item(12)

        name_ = dt.Rows(0).Item(1)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        TabControl1.SelectTab(1)
        position(attendancebtn)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim bsource As New BindingSource
        da = New OleDbDataAdapter("SELECT * FROM tbl_attendanceLogs WHERE employeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)
        bsource.DataSource = dt
        GunaDataGridView1.DataSource = bsource
        da.Update(dt)


        Dim cmdTardy As OleDbCommand = New OleDbCommand("Select SUM([tardyMinutes]) FROM [tbl_attendanceLogs] WHERE [EmployeeID] = '" & LoginForm.usernamefieldx.Text & "'", con)
        Dim cmdUnderTime As OleDbCommand = New OleDbCommand("Select SUM([underTimeMinutes]) FROM [tbl_attendanceLogs] WHERE [EmployeeID] = '" & LoginForm.usernamefieldx.Text & "'", con)
        Dim absent As String = "Absent"
        Dim cmdAbsent As OleDbCommand = New OleDbCommand("Select COUNT(Remark) FROM [tbl_attendanceLogs] WHERE [EmployeeID] = '" & LoginForm.usernamefieldx.Text & "' AND [Remark] = '" & absent & "'", con)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()


        If IsDBNull((cmdTardy.ExecuteScalar)) Then
            totalTardy1.Text = "No Tardy Time"
        Else
            Dim totalTardy = Convert.ToInt32(cmdTardy.ExecuteScalar)
            Dim tardyHour = totalTardy \ 60
            Dim tardyMinutes = totalTardy Mod 60
            totalTardy1.Text = tardyHour & "h " & tardyMinutes & "m"
        End If



        If IsDBNull((cmdUnderTime.ExecuteScalar)) Then
            totalUndertime1.Text = "No Undertime"
        Else
            Dim totalUnderTime = Convert.ToInt32(cmdUnderTime.ExecuteScalar)
            Dim underTimeHour = totalUnderTime \ 60
            Dim underTimeMinutes = totalUnderTime Mod 60
            totalUndertime1.Text = underTimeHour & "h " & underTimeMinutes & "m"
        End If

        If IsDBNull((cmdAbsent.ExecuteScalar)) Then
            totalAbsences1.Text = "No Absences"
        Else
            Dim totalAbsent = Convert.ToInt32(cmdAbsent.ExecuteScalar)
            If totalAbsent > 0 Then
                totalAbsences1.Text = totalAbsent.ToString & " Absences"
            Else
                totalAbsences1.Text = "No Absences"
            End If

        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    'Private Sub bunifutilebutton3_click_1(sender As Object, e As EventArgs)

    '    Dim datenow As String
    '    Dim timenow As String
    '    datenow = dateandtime.today.tostring("dd/mm/yyyy")
    '    timenow = timeofday.tostring("hh:mm:ss tt")
    '    Dim yesterday As String = now().adddays(-1).tostring("dd/mm/yyyy")
    '    getyesterday()
    '    late()

    '    If temp = "" Then
    '        If dateyesterday = "empty" And Not dayyesterday = "sunday" Then
    '            Dim cmda As oledbcommand = New oledbcommand("insert into tbl_attendancelogs([date],[employeeid],[employeename],[remark]) values(?,?,?,?)", con)
    '            cmda.parameters.add(New oledbparameter("date", CType(yesterday, String)))
    '            cmda.parameters.add(New oledbparameter("employeeid", CType(loginform.usernamefieldx.text, String)))
    '            cmda.parameters.add(New oledbparameter("employeename", CType(loginform.passstring, String)))
    '            cmda.parameters.add(New oledbparameter("remark", CType("absent", String)))
    '            cmda.executenonquery()
    '        End If

    '        Dim cmd As oledbcommand = New oledbcommand("insert into tbl_attendancelogs([date],[employeeid],[employeename],[timein],[tardy],[remark],[loginchecker],[tardyminutes]) values(?,?,?,?,?,?,?,?)", con)
    '        cmd.parameters.add(New oledbparameter("date", CType(datenow, String)))
    '        cmd.parameters.add(New oledbparameter("employeeid", CType(loginform.usernamefieldx.text, String)))
    '        cmd.parameters.add(New oledbparameter("employeename", CType(loginform.passstring, String)))
    '        cmd.parameters.add(New oledbparameter("timein", CType(timenow, String)))
    '        Dim starttime As datetime = expectedtimein
    '        Dim currenttime As datetime = timenow
    '        Dim timediff As timespan = currenttime.subtract(starttime)

    '        If starttime.timeofday < datetime.now.timeofday Then

    '            Dim result As Integer = timediff.totalminutes
    '            Dim hour = result \ 60
    '            Dim minute = result Mod 60
    '            cmd.parameters.add(New oledbparameter("tardy", CType(hour & "h " & minute & "m", String)))
    '            cmd.parameters.add(New oledbparameter("remark", CType("present", String)))
    '            cmd.parameters.add(New oledbparameter("loginchecker", CType("true", String)))
    '            cmd.parameters.add(New oledbparameter("tardyminutes", CType(result.tostring, String)))
    '        Else
    '            cmd.parameters.add(New oledbparameter("remark", CType("present", String)))
    '            cmd.parameters.add(New oledbparameter("loginchecker", CType("true", String)))
    '        End If

    '        cmd.executenonquery()
    '        cmd.dispose()
    '        msgbox("time in successfully")
    '        bunifutilebutton3.enabled = False
    '    Else
    '        bunifutilebutton3.enabled = False
    '        msgbox("can only time in once!")
    '    End If
    '    con.close()
    'End Sub

    'Private Sub BunifuTileButton2_Click_1(sender As Object, e As EventArgs)
    '    If con.State = ConnectionState.Closed Then
    '        con.Open()
    '    End If

    '    Dim datenow As String
    '    Dim timenow As String
    '    datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
    '    timenow = TimeOfDay.ToString("hh:mm tt")
    '    'showchecked2()
    '    undertime()
    '    Dim StartTime As DateTime = expectedtimeout
    '    Dim currentTime As DateTime = timenow
    '    Dim TimeDiff As TimeSpan = StartTime.Subtract(currentTime)

    '    Dim result As Integer = TimeDiff.TotalMinutes
    '    Dim Hour = result \ 60
    '    Dim Minute = result Mod 60
    '    Dim under As String = Hour & "h " & Minute & "m"
    '    Label8.Text = expectedtimeout
    '    If Not temp2 = "True" Then
    '        If StartTime.TimeOfDay < DateTime.Now.TimeOfDay Then
    '            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET TimeOut = '" & timenow & "', Undertime = '', timeoutchecker = 'True' WHERE Date = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
    '            cmd.ExecuteNonQuery()

    '        ElseIf StartTime.TimeOfDay > DateTime.Now.TimeOfDay Then
    '            Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET TimeOut = '" & timenow & "', Undertime = '" & under & "', timeoutchecker = 'True' WHERE Date = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
    '            Dim cmd2 As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET underTimeMinutes = '" & result.ToString & "' WHERE [EmployeeID] = '" & LoginForm.usernamefieldx.Text & "' AND Date = '" & datenow & "'", con)
    '            cmd.ExecuteNonQuery()
    '            cmd2.ExecuteNonQuery()
    '        End If
    '        MsgBox("Time Out Successfully")
    '        BunifuTileButton2.Enabled = False
    '    Else
    '        MsgBox("Can only time out once!")
    '    End If
    '    con.Close()
    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub changePass_Click(sender As Object, e As EventArgs) Handles changePass.Click
        TabControl1.SelectTab(2)
        position(change)

    End Sub

   
 
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Dim cmdRetrieve As OleDbCommand = New OleDbCommand("SELECT * FROM tbl_accounts WHERE Username = '" & LoginForm.usernamefieldx.Text & "'", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM tbl_accounts WHERE Username = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        If oldPassword.Text = Nothing Or newPassword.Text = Nothing Then
            MsgBox("Please Fillout the Fields!", MsgBoxStyle.Exclamation, "Invalid")
        Else
            If newPassword.Text = confirmPassword.Text Then
                If newPassword.Text.Length < 8 Then
                    MsgBox("Minimum of 8 Character Password!", MsgBoxStyle.Exclamation, "Invalid")
                Else
                    If newPassword.Text = oldPassword.Text Then
                        MsgBox("Old Password and New Password are still the Same!", MsgBoxStyle.Exclamation, "Invalid")
                    Else
                        If oldPassword.Text = dt.Rows(0).Item(1) Then
                            Dim cmdUpdate As OleDbCommand = New OleDbCommand("UPDATE [tbl_accounts] SET [password] = '" & newPassword.Text & "' WHERE [Username] = '" & LoginForm.usernamefieldx.Text & "'", con)
                            MsgBox("Password Changed Successfully!", MsgBoxStyle.Information)
                            cmdUpdate.ExecuteNonQuery()
                        Else
                            MsgBox("Incorrect Password", MsgBoxStyle.Exclamation, "Invalid")
                        End If
                    End If
                End If
            Else
                MsgBox("Password Mismatch!", MsgBoxStyle.Exclamation, "Invalid")
            End If
        End If




    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        newPassword.Text = Nothing
        oldPassword.Text = Nothing
        confirmPassword.Text = Nothing
    End Sub

    'Private Sub newPassword_TextChanged(sender As Object, e As EventArgs) Handles newPassword2.TextChanged
    '    If newPassword2.Text.Length > 6 And newPassword2.Text.Length < 10 Then
    '        passwordChar.Text = "Weak"
    '        passwordChar.Visible = True
    '    ElseIf newPassword2.Text.Length >= 10 And newPassword2.Text.Length < 14 Then
    '        passwordChar.Text = "Strong"
    '        passwordChar.Visible = True
    '    ElseIf newPassword2.Text.Length >= 14 And newPassword2.Text.Length < 18 Then
    '        passwordChar.Text = "Extremely Strong"
    '        passwordChar.Visible = True
    '    ElseIf newPassword2.Text.Length <= 6 Then
    '        passwordChar.Visible = False
    '    End If
    'End Sub


    Private Sub profileupdate_Click(sender As Object, e As EventArgs) Handles profileupdate.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Do you want to Update your Record", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Update Record")
        If ask = MsgBoxResult.Yes Then
            savebtnprofile.Show()
            savebtnprofile.BackColor = Color.MidnightBlue
            cancelbtn.Show()
            profileupdate.Enabled = False
            contactdisplay.Enabled = True
            emaildisplay.Enabled = True '
            profileupdate.BackColor = Color.DarkRed
        Else
            If ask = MsgBoxResult.No Then
                savebtnprofile.Hide()
                cancelbtn.Hide()
                profileupdate.Enabled = True
                profileupdate.BackColor = Color.MidnightBlue
                contactdisplay.Enabled = False
                emaildisplay.Enabled = False
            End If
        End If

        
    End Sub


    Private Sub newPassword_TextChanged_1(sender As Object, e As EventArgs) Handles newPassword.TextChanged
        If newPassword.Text.Length > 3 And newPassword.Text.Length < 10 Then
            passwordChar.Text = "Weak Password"
            passwordChar.ForeColor = Color.Red
            passwordChar.Visible = True
        ElseIf newPassword.Text.Length >= 10 And newPassword.Text.Length < 14 Then
            passwordChar.Text = "Strong Password"
            passwordChar.ForeColor = Color.Green
            passwordChar.Visible = True
        ElseIf newPassword.Text.Length >= 14 And newPassword.Text.Length < 18 Then
            passwordChar.Text = "Extremely Strong"
            passwordChar.ForeColor = Color.YellowGreen
            passwordChar.Visible = True
        ElseIf newPassword.Text.Length <= 3 Then
            passwordChar.Visible = False
        End If
    End Sub

    Private Sub employeetime_Click(sender As Object, e As EventArgs) Handles employeetime.Click

    End Sub

    Private Sub savebtnprofile_Click(sender As Object, e As EventArgs) Handles savebtnprofile.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT Contact_No, EmailAddress FROM tbl_employee_records WHERE EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            contact = dt.Rows(0).Item(0)
            email = dt.Rows(0).Item(1)
        Catch ex As Exception

        End Try

        If contactdisplay.Text = contact And emaildisplay.Text = email Then
            MsgBox("No changes are made", MsgBoxStyle.Exclamation, "Alert")
        ElseIf contactdisplay.TextLength < 13 Then
            MsgBox("Contact number must be filled correctly", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim cmd2 As OleDbCommand = New OleDbCommand("UPDATE tbl_employee_records SET [Contact_No] = '" & contactdisplay.Text & "', [EmailAddress] = '" & emaildisplay.Text & "' WHERE EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
            cmd2.ExecuteNonQuery()
            MsgBox("Update Successful!", MsgBoxStyle.Information)
            contactdisplay.Enabled = False
            emaildisplay.Enabled = False
            savebtnprofile.Hide()
            cancelbtn.Hide()
            profileupdate.Enabled = True
            profileupdate.BackColor = Color.MidnightBlue
        End If

        con.Close()
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT Contact_No, EmailAddress FROM tbl_employee_records WHERE EmployeeID = '" & LoginForm.usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            contactdisplay.Text = dt.Rows(0).Item(0)
            emaildisplay.Text = dt.Rows(0).Item(1)
        Catch ex As Exception

        End Try
        profileupdate.Enabled = True
        contactdisplay.Enabled = False
        emaildisplay.Enabled = False
        savebtnprofile.Hide()
        cancelbtn.Hide()
        profileupdate.BackColor = Color.MidnightBlue

        con.Close()
    End Sub

    Private Sub position(b As Button)
        locator.Location = New Point(b.Location.X, b.Location.Y)
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        position(change)
    End Sub

End Class