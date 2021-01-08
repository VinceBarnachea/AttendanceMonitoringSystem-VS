Imports System.Data.OleDb

Public Class EmployeeForm2
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AttendanceMonitoringSystem\Database2.accdb")
    Dim ask As MsgBoxResult
    Dim dr As OleDbDataReader
    Dim name_ As String
    Dim counter As Integer = 0
    Private temp As String
    Private temp2 As String

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet1.tbl_attendance_logs' table. You can move, or remove it, as needed.
        'Me.Tbl_attendance_logsTableAdapter.Fill(Me.Database2DataSet1.tbl_attendance_logs)
        Timer1.Enabled = True
        con.Open()
        Label7.Text = "Welcome, " + LoginForm.passString
    End Sub




    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        ask = MsgBox("Are you sure?", MsgBoxStyle.OkCancel, "Logout")
        If ask = MsgBoxResult.Ok Then

            con.Close()
            LoginForm.usernamefield.Clear()
            LoginForm.passwordfield.Clear()
            LoginForm.adminradiobtn.Checked = False
            LoginForm.employeeradiobtn.Checked = False

            counter = 0
            timeinbtn.Enabled = True
            timeinbtn.BackColor = Color.Navy

            LoginForm.Show()
            Me.Close()
        Else
            Me.Refresh()
        End If

    End Sub


    Private Sub profilebtn_Click(sender As Object, e As EventArgs) Handles profilebtn.Click
        TabControl1.SelectTab(1)
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE employeeID = '" & LoginForm.usernamefield.Text & "'", con)
        da.Fill(dt)

        employeeiddisplay.Text = dt.Rows(0).Item(0)
        fullnamedisplay.Text = dt.Rows(0).Item(1) + " " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
        addressdisplay.Text = dt.Rows(0).Item(4)
        contactdisplay.Text = dt.Rows(0).Item(5)
        departmentdisplay.Text = dt.Rows(0).Item(6)
        datedhireddisplay.Text = dt.Rows(0).Item(7)

        name_ = dt.Rows(0).Item(1)


    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub attendancebtn_Click(sender As Object, e As EventArgs) Handles attendancebtn.Click
        TabControl1.SelectTab(2)

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim bsource As New BindingSource
        da = New OleDbDataAdapter("SELECT * FROM tbl_attendance_logs WHERE employeeID = '" & LoginForm.usernamefield.Text & "'", con)
        da.Fill(dt)
        bsource.DataSource = dt
        DataGridView1.DataSource = bsource
        da.Update(dt)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        employeetime.Text = DateAndTime.Now.ToShortTimeString
    End Sub

    Private Sub showchecked()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT loginchecker FROM tbl_attendance_logs WHERE DateLoggedIn = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefield.Text & "'", con)
        da.Fill(dt)

        Try
            temp = dt.Rows(0).Item(0)
        Catch ex As Exception
            temp = "False"
        End Try

    End Sub


    Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        Dim datenow As String
        Dim timenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        timenow = TimeOfDay.ToString("hh:mm tt")
        showchecked()

        If Not temp = "True" Then
            Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tbl_attendance_logs([DateLoggedIn],[EmployeeID],[EmployeeName],[TimeIn],[Late],[loginchecker]) VALUES(?,?,?,?,?,?)", con)
            cmd.Parameters.Add(New OleDbParameter("DateLoggedIn", CType(datenow, String)))
            cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(LoginForm.usernamefield.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("EmployeeName", CType(LoginForm.passString, String)))
            cmd.Parameters.Add(New OleDbParameter("TimeIn", CType(timenow, String)))
            Dim TimeStart As DateTime = #7:00:00 AM#
            If TimeStart.TimeOfDay < DateTime.Now.TimeOfDay Then
                cmd.Parameters.Add(New OleDbParameter("Late", CType("yes", String)))
                cmd.Parameters.Add(New OleDbParameter("loginchecker", CType("True", String)))
            Else
                cmd.Parameters.Add(New OleDbParameter("Late", CType("no", String)))
                cmd.Parameters.Add(New OleDbParameter("loginchecker", CType("True", String)))
            End If

            cmd.ExecuteNonQuery()
            MsgBox("Time In Successfully")
        Else
            MsgBox("Can only time in once!")
        End If


    End Sub

    Private Sub showchecked2()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT timeoutchecker FROM tbl_attendance_logs WHERE DateLoggedIn = '" & datenow & "' AND EmployeeID = '" & LoginForm.usernamefield.Text & "'", con)
        da.Fill(dt)

        Try
            temp2 = dt.Rows(0).Item(0)
        Catch ex As Exception
            temp2 = "False"
        End Try

    End Sub

    Private Sub timeoutbtn_Click(sender As Object, e As EventArgs) Handles timeoutbtn.Click
        Dim datenow As String
        Dim timenow As String
        datenow = DateAndTime.Today.ToString("dd/MM/yyyy")
        timenow = TimeOfDay.ToString("hh:mm tt")
        Dim TimeEnd As DateTime = #5:00:00 PM#
        showchecked2()
        If Not temp2 = "True" Then
            If TimeEnd.TimeOfDay < DateTime.Now.TimeOfDay Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendance_logs SET TimeOut = '" & timenow & "', Remarks = 'Overtime', timeoutchecker = 'True' WHERE DateLoggedIn = '" & datenow & "'", con)
                cmd.ExecuteNonQuery()
            ElseIf TimeEnd.TimeOfDay > DateTime.Now.TimeOfDay Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendance_logs SET TimeOut = '" & timenow & "', Remarks = 'Undertime', timeoutchecker = 'True' WHERE DateLoggedIn = '" & datenow & "'", con)
                cmd.ExecuteNonQuery()
            End If
            MsgBox("Time Out Successfully")
        Else
            MsgBox("Can only time out once!")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TblattendancelogsBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TblattendancelogsBindingSource.CurrentChanged

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub fullnamedisplay_Click(sender As Object, e As EventArgs) Handles fullnamedisplay.Click

    End Sub

    Private Sub addressdisplay_Click(sender As Object, e As EventArgs) Handles addressdisplay.Click

    End Sub

    Private Sub contactdisplay_Click(sender As Object, e As EventArgs) Handles contactdisplay.Click

    End Sub

    Private Sub departmentdisplay_Click(sender As Object, e As EventArgs) Handles departmentdisplay.Click

    End Sub

    Private Sub datedhireddisplay_Click(sender As Object, e As EventArgs) Handles datedhireddisplay.Click

    End Sub

    Private Sub employeeiddisplay_Click(sender As Object, e As EventArgs) Handles employeeiddisplay.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub employeetime_Click(sender As Object, e As EventArgs) Handles employeetime.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub avatar_Click(sender As Object, e As EventArgs) Handles avatar.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class