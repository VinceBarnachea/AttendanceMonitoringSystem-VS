Imports System.Data.OleDb
Public Class AdminForm
    Dim ask As MsgBoxResult
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")


    Dim countLastIndex As Integer
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim user As String = "employee"
        da = New OleDbDataAdapter("SELECT Username FROM tbl_accounts WHERE user_level = '" & user & "'", con)
        da.Fill(dt)


        Dim ds2 As New DataSet
        Dim dt2 As New DataTable
        ds2.Tables.Add(dt2)
        Dim da2 As New OleDbDataAdapter
        da2 = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
        da2.Fill(dt2)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmdCount1 As OleDbCommand = New OleDbCommand("SELECT COUNT([EmployeeID]) FROM tbl_employee_records", con)

        If IsDBNull((cmdCount1.ExecuteScalar)) Then
            AttendanceLogs1.totalTardy.Text = "No Absences"
        Else
            Dim totalEmployee = Convert.ToInt32(cmdCount1.ExecuteScalar)
            If totalEmployee > 0 Then
                Dim num As Integer = 0
                countLastIndex = dt.Rows.Count
                For num = 0 To dt.Rows.Count - 1
                    Dim newButton As Button = New Button
                    AddHandler newButton.Click, AddressOf clickME
                    newButton.Name = dt.Rows(num).Item(0).ToString
                    newButton.Text = dt2.Rows(num).Item(1).ToString + " " + dt2.Rows(num).Item(3)
                    newButton.Width = 262
                    newButton.Height = 52
                    newButton.BackColor = Color.FromArgb(0, 51, 102)
                    newButton.ForeColor = Color.White
                    newButton.FlatStyle = FlatStyle.Flat
                    newButton.Font = New Font(newButton.Font, FontStyle.Bold)
                    newButton.Font = New Font("Courier New", 12.0)
                    AttendanceLogs1.FlowLayoutPanel1.Controls.Add(newButton)
                Next

            Else

            End If

        End If

       

        AddEmployeeBox1.Hide()
        AttendanceLogs1.Hide()
        Home1.Hide()
        'connection.Open()


        Dim dss = New DataSet
        Dim adapter = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
        adapter.Fill(dss)
        Home1.GunaDataGridView1.DataSource = dss.Tables(0)

        Dim cmdCount As OleDbCommand = New OleDbCommand("SELECT COUNT([EmployeeID]) FROM tbl_employee_records", con)

        If IsDBNull((cmdCount.ExecuteScalar)) Then
            AttendanceLogs1.totalTardy.Text = "No Absences"
        Else
            Dim totalEmployee = Convert.ToInt32(cmdCount.ExecuteScalar)
            If totalEmployee > 0 Then
                BunifuTileButton2.LabelText = totalEmployee.ToString + " Employees"
            Else
                AttendanceLogs1.totalAbsent.Text = "No Employees"
            End If

        End If

        Timer1.Enabled = True


    End Sub
    Private Sub position(b As Button)
        locator.Location = New Point(b.Location.X, b.Location.Y)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        AcceptButton = Home1.updateBtn
        position(btnHome)
        Dim ds = New DataSet
        Dim adapter = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
        adapter.Fill(ds)
        con.Close()
        Home1.GunaDataGridView1.DataSource = ds.Tables(0)
        AddEmployeeBox1.Hide()
        AttendanceLogs1.Hide()
        Home1.Show()



    End Sub

    ' Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
    '    AcceptButton = AddEmployeeBox1.saveBtn
    '    position(btnAddEmployee)
    '    AddEmployeeBox1.Show()
    '    AttendanceLogs1.Hide()
    '    Home1.Hide()

    'End Sub


    Public Sub clickME(ByVal Sender As Object, ByVal e As EventArgs)



        Dim dss = New DataSet
        Dim adapters = New OleDbDataAdapter("SELECT * FROM tbl_attendanceLogs WHERE EmployeeID = '" + DirectCast(Sender, Button).Name + "'", con)
        adapters.Fill(dss)
        AttendanceLogs1.GunaDataGridView1.DataSource = dss.Tables(0)
        Dim cmdTardy As OleDbCommand = New OleDbCommand("Select SUM([tardyMinutes]) FROM [tbl_attendanceLogs] WHERE [EmployeeID] = '" & DirectCast(Sender, Button).Name & "'", con)
        Dim cmdUnderTime As OleDbCommand = New OleDbCommand("Select SUM([underTimeMinutes]) FROM [tbl_attendanceLogs] WHERE [EmployeeID] = '" & DirectCast(Sender, Button).Name & "'", con)
        Dim absent As String = "Absent"


        'Ito yung kung paano magcount sa Database 
        Dim cmdAbsent As OleDbCommand = New OleDbCommand("Select COUNT(Remark) FROM [tbl_attendanceLogs] WHERE [EmployeeID] = '" & DirectCast(Sender, Button).Name & "' AND [Remark] = '" & absent & "'", con)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        AttendanceLogs1.EmployeeIDLabel.Text = DirectCast(Sender, Button).Name
        If IsDBNull((cmdTardy.ExecuteScalar)) Then
            AttendanceLogs1.totalTardy.Text = "No Tardy Time"
        Else
            Dim totalTardy = Convert.ToInt32(cmdTardy.ExecuteScalar)
            Dim tardyHour = totalTardy \ 60
            Dim tardyMinutes = totalTardy Mod 60
            AttendanceLogs1.totalTardy.Text = tardyHour & "h " & tardyMinutes & "m"
        End If



        If IsDBNull((cmdUnderTime.ExecuteScalar)) Then
            AttendanceLogs1.totalUnderTime.Text = "No Undertime"
        Else
            Dim totalUnderTime = Convert.ToInt32(cmdUnderTime.ExecuteScalar)
            Dim underTimeHour = totalUnderTime \ 60
            Dim underTimeMinutes = totalUnderTime Mod 60
            AttendanceLogs1.totalUnderTime.Text = underTimeHour & "h " & underTimeMinutes & "m"
        End If

        If IsDBNull((cmdAbsent.ExecuteScalar)) Then
            AttendanceLogs1.totalTardy.Text = "No Absences"
        Else
            Dim totalAbsent = Convert.ToInt32(cmdAbsent.ExecuteScalar)
            If totalAbsent > 0 Then
                AttendanceLogs1.totalAbsent.Text = totalAbsent.ToString & " Absences"
            Else
                AttendanceLogs1.totalAbsent.Text = "No Absences"
            End If

        End If

        AcceptButton = AttendanceLogs1.crystalReport

    End Sub

    Private Sub btnAttendanceLogs_Click(sender As Object, e As EventArgs) Handles btnAttendanceLogs.Click
        AcceptButton = AttendanceLogs1.crystalReport
        position(btnAttendanceLogs)
        AddEmployeeBox1.Hide()
        AttendanceLogs1.Show()
        Home1.Hide()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim user As String = "employee"
        da = New OleDbDataAdapter("SELECT Username FROM tbl_accounts WHERE user_level = '" & user & "'", con)
        da.Fill(dt)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim num As Integer = 0
        For num = countLastIndex To dt.Rows.Count - 1
            Dim newButton As Button = New Button
            AddHandler newButton.Click, AddressOf clickME
            newButton.Name = dt.Rows(num).Item(0).ToString
            newButton.Text = dt.Rows(num).Item(1).ToString + dt.Rows(num).Item(3).ToString
            newButton.Width = 262
            newButton.Height = 52
            newButton.BackColor = Color.FromArgb(41, 128, 185)
            newButton.ForeColor = Color.White
            newButton.FlatStyle = FlatStyle.Flat
            newButton.Font = New Font(newButton.Font, FontStyle.Bold)
            newButton.Font = New Font("Courier New", 12.0)
            AttendanceLogs1.FlowLayoutPanel1.Controls.Add(newButton)




        Next


        'For Each names As String In drlogs.GetString(drlogs.FieldCount - 1).ToString
        'Dim newButton As Button = New Button
        'newButton.Name = names
        'newButton.Text = names
        'AttendanceLogs1.FlowLayoutPanel1.Controls.Add(newButton)

        'Next





    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BunifuFlatButton3.Enabled = True
        ask = MsgBox("Are you sure?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Signout")
        If ask = MsgBoxResult.Ok Then
            con.Close()
            LoginForm.usernamefieldx.Text = Nothing
            LoginForm.passwordfieldx.Text = Nothing
            LoginForm.adminradiobtn.Checked = False
            LoginForm.employeeradiobtn.Checked = False
            Me.Close()
            LoginForm.Show()
            con.Close()
        Else
            Me.Refresh()
        End If



    End Sub


    Private Sub AttendanceLogs1_Load(sender As Object, e As EventArgs) Handles AttendanceLogs1.Load

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuFlatButton3.Enabled = True
        position(btnHome)
        'background.Show()
        AddEmployeeBox1.Hide()
        AttendanceLogs1.Hide()
        Home1.Hide()
        Label4.Show()
        Panel4.Show()
        BunifuTileButton2.Show()
        BunifuTileButton3.Show()
        BunifuTileButton4.Show()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmdCount As OleDbCommand = New OleDbCommand("SELECT COUNT([EmployeeID]) FROM tbl_employee_records", con)

        If IsDBNull((cmdCount.ExecuteScalar)) Then
            AttendanceLogs1.totalTardy.Text = "No Absences"
        Else
            Dim totalEmployee = Convert.ToInt32(cmdCount.ExecuteScalar)
            If totalEmployee > 0 Then
                BunifuTileButton2.LabelText = totalEmployee.ToString + " Employees"
            Else
                AttendanceLogs1.totalAbsent.Text = "No Employees"
            End If

        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        BunifuFlatButton3.Enabled = True
        AcceptButton = AddEmployeeBox1.saveBtn
        'background.Hide()
        position(btnAddEmployee)
        AddEmployeeBox1.Show()
        AttendanceLogs1.Hide()
        BunifuTileButton2.Hide()
        BunifuTileButton3.Hide()
        BunifuTileButton4.Hide()
        Home1.Hide()
        Label4.Hide()
        Panel4.Hide()

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        AcceptButton = AttendanceLogs1.crystalReport
        position(btnAttendanceLogs)
        ' background.Hide()
        AddEmployeeBox1.Hide()
        AttendanceLogs1.Show()
        Home1.Hide()
        BunifuTileButton2.Hide()
        BunifuTileButton3.Hide()
        BunifuTileButton4.Hide()
        Label4.Hide()
        Panel4.Hide()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim user As String = "employee"
        da = New OleDbDataAdapter("SELECT Username FROM tbl_accounts WHERE user_level = '" & user & "'", con)
        da.Fill(dt)


        'Dim ds2 As New DataSet
        'Dim dt2 As New DataTable
        'ds2.Tables.Add(dt2)
        'Dim da2 As New OleDbDataAdapter
        'da2 = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
        'da2.Fill(dt2)
        'If con.State = ConnectionState.Closed Then
        '    con.Open()
        'End If
        'Dim num As Integer = 0
        'countLastIndex = dt.Rows.Count
        'For num = 0 To dt.Rows.Count - 1
        '    Dim newButton As Button = New Button
        '    AddHandler newButton.Click, AddressOf clickME
        '    newButton.Name = dt.Rows(num).Item(0).ToString
        '    newButton.Text = dt2.Rows(num).Item(1).ToString + " " + dt2.Rows(num).Item(3)
        '    newButton.Width = 262
        '    newButton.Height = 52
        '    newButton.BackColor = Color.FromArgb(41, 128, 185)
        '    newButton.ForeColor = Color.White
        '    newButton.FlatStyle = FlatStyle.Flat
        '    newButton.Font = New Font(newButton.Font, FontStyle.Bold)
        '    newButton.Font = New Font("Century Gothic", 12.0)
        '    AttendanceLogs1.FlowLayoutPanel1.Controls.Add(newButton)
        'Next

        'BunifuFlatButton3.Enabled = False

        'con.Close()
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

    Private Sub Label4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        BunifuFlatButton3.Enabled = True
        Home1.Show()
        AcceptButton = Home1.updateBtn
        BunifuTileButton2.Hide()
        'background.Hide()
        BunifuTileButton3.Hide()
        BunifuTileButton4.Hide()
        Label4.Hide()
        Panel4.Hide()
        
        Dim ds = New DataSet
        Dim adapter = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
        adapter.Fill(ds)
        con.Close()
        Home1.GunaDataGridView1.DataSource = ds.Tables(0)


    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        BunifuFlatButton3.Enabled = True
        position(btnAddEmployee)
        AddEmployeeBox1.Show()
        BunifuTileButton2.Hide()
        BunifuTileButton3.Hide()
        BunifuTileButton4.Hide()
        Label4.Hide()
        Panel4.Hide()
        'background.Hide()
        AcceptButton = AddEmployeeBox1.saveBtn
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        BunifuFlatButton3.Enabled = True
        position(btnAttendanceLogs)
        AttendanceLogs1.Show()
        BunifuTileButton2.Hide()
        BunifuTileButton3.Hide()
        BunifuTileButton4.Hide()
        Label4.Hide()
        Panel4.Hide()
        'background.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeshow.Text = DateTime.Now().ToString("hh:mm:ss tt")
    End Sub

End Class