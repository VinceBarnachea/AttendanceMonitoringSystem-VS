Imports System.Data.OleDb
Public Class LoginForm
    Public passString As String
    Public fullName As String
    Dim user_level As String = ""
    Private temp As String
    Private temp2 As String
    Private expectedtimein As Date
    Private expectedtimeout As Date
    Private dayyesterday As String
    Private dateyesterday As String
    Private id As String
    Private idchecker As String
    Public gender As String
    Public yesterday As String

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

        If adminradiobtn.Checked = True Then
            user_level = "administrator"
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tbl_accounts WHERE Username = '" & usernamefieldx.Text & "' AND password = '" & passwordfieldx.Text & "' AND user_level = '" & user_level & "'", con)
            con.Open()
            Dim drlog As OleDbDataReader = cmd.ExecuteReader

            If usernamefieldx.Text = Nothing Or passwordfieldx.Text = Nothing Then
                MsgBox("Please enter credentials", MsgBoxStyle.Exclamation, "Error")
                con.Close()
            ElseIf (drlog.Read() = True) Then
                getGender()
                AdminForm.Show()
                Me.Hide()
                con.Close()
            Else
                MsgBox("Invalid ID or Password, Please try again...", MsgBoxStyle.Critical, "Error")
                usernamefieldx.Text = ""
                passwordfieldx.Text = ""
                adminradiobtn.Checked = False
                employeeradiobtn.Checked = False
                con.Close()
            End If


        ElseIf employeeradiobtn.Checked = True Then
            user_level = "employee"
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tbl_accounts WHERE Username = '" & usernamefieldx.Text & "' AND password = '" & passwordfieldx.Text & "' AND user_level = '" & user_level & "'", con)
            con.Open()
            Dim drlog As OleDbDataReader = cmd.ExecuteReader

            If usernamefieldx.Text = Nothing Or passwordfieldx.Text = Nothing Then
                MsgBox("Please enter credentials", MsgBoxStyle.Critical, "Error")
                con.Close()
            ElseIf (drlog.Read() = True) Then
                showItems()

                EmployeeForm.Show()
                Me.Hide()
                con.Close()
            Else
                MsgBox("Invalid ID or Password, Please try again...", MsgBoxStyle.Critical, "Error")
                usernamefieldx.Text = ""
                passwordfieldx.Text = ""
                adminradiobtn.Checked = False
                employeeradiobtn.Checked = False
                con.Close()
            End If
        Else
            MsgBox("Please choose user level", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub getGender()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT Gender FROM tbl_employee_records WHERE employeeID = '" & usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            gender = dt.Rows(0).Item(0)
        Catch ex As Exception
        End Try

        con.Close()
    End Sub

    Private Sub showItems()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE employeeID = '" & usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            passString = dt.Rows(0).Item(1)
            fullName = dt.Rows(0).Item(1) + " " + dt.Rows(0).Item(3)
        Catch ex As Exception
            idchecker = "empty"
        End Try

        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = loginbtn
        Timer1.Enabled = True
    End Sub



    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        usernamefield.Clear()
        passwordfield.Clear()
        usernamefieldx.Text = ""
        passwordfieldx.Text = ""
        adminradiobtn.Checked = False
        employeeradiobtn.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateandTime.Text = DateTime.Now.ToString("MMMM dd, dddd")
        timeinlogin.Text = TimeOfDay().ToString("hh:mm:ss tt")
    End Sub

    Private Sub DateandTime_Click(sender As Object, e As EventArgs) Handles DateandTime.Click

    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Do you want to close the System?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Exit")
        If ask = MsgBoxResult.Yes Then
            Me.Close()
            con.Close()
        Else
            If ask = MsgBoxResult.No Then

            End If
        End If

    End Sub


    Private Sub passwordfieldx_OnValueChanged(sender As Object, e As EventArgs) Handles passwordfieldx.OnValueChanged
        passwordfieldx.isPassword = True
    End Sub

    Private Sub showchecked()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT TimeIn FROM tbl_attendanceLogs WHERE Date = '" & datenow & "' AND EmployeeID = '" & usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            temp = dt.Rows(0).Item(0)
        Catch ex As Exception
            temp = ""
        End Try
        con.Close()
    End Sub

    Private Sub late()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT ExpectedTimein FROM tbl_employee_records WHERE EmployeeID = '" & usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            expectedtimein = dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub getyesterday()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        yesterday = Now().AddDays(-1).ToString("dd/MM/yyyy")
        dayyesterday = Now().AddDays(-1).ToString("dddd")
        Dim cmd As New OleDbCommand
        cmd = New OleDbCommand("SELECT * FROM tbl_attendanceLogs WHERE EmployeeID = '" & usernamefieldx.Text & "' AND Date = '" & yesterday & "'", con)
        Dim drlog As OleDbDataReader = cmd.ExecuteReader
        'samplelabel.Text = yesterday
        If (drlog.Read() = True) Then
            dateyesterday = "failed"
        Else
            dateyesterday = "empty"
        End If
        con.Close()
    End Sub

    Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        Dim datenow As String
        Dim timenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        timenow = TimeOfDay.ToString("hh:mm tt")
        showItems()
        getyesterday()
        late()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If Not idchecker = "empty" Then
            If temp = "" Then
                If dateyesterday = "empty" And Not dayyesterday = "sunday" Then
                    Dim cmda As OleDbCommand = New OleDbCommand("insert into tbl_attendancelogs([Date],[EmployeeID],[EmployeeName],[Remark]) values(?,?,?,?)", con)
                    cmda.Parameters.Add(New OleDbParameter("Date", CType(yesterday, String)))
                    cmda.Parameters.Add(New OleDbParameter("EmployeeID", CType(usernamefieldx.Text, String)))
                    cmda.Parameters.Add(New OleDbParameter("EmployeeName", CType(fullName, String)))
                    cmda.Parameters.Add(New OleDbParameter("Remark", CType("absent", String)))
                    cmda.ExecuteNonQuery()
                End If

                Dim cmd As OleDbCommand = New OleDbCommand("insert into tbl_attendancelogs([date],[employeeid],[employeename],[timein],[tardy],[remark],[loginchecker],[tardyminutes]) values(?,?,?,?,?,?,?,?)", con)
                cmd.Parameters.Add(New OleDbParameter("date", CType(datenow, String)))
                cmd.Parameters.Add(New OleDbParameter("employeeid", CType(usernamefieldx.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("employeename", CType(fullName, String)))
                cmd.Parameters.Add(New OleDbParameter("timein", CType(timenow, String)))
                Dim starttime As DateTime = expectedtimein
                Dim currenttime As DateTime = timenow
                Dim timediff As TimeSpan = currenttime.Subtract(starttime)
                If starttime.TimeOfDay < DateTime.Now.TimeOfDay Then

                    Dim result As Integer = timediff.TotalMinutes
                    Dim hour = result \ 60
                    Dim minute = result Mod 60
                    cmd.Parameters.Add(New OleDbParameter("tardy", CType(hour & "h " & minute & "m", String)))
                    cmd.Parameters.Add(New OleDbParameter("remark", CType("present", String)))
                    cmd.Parameters.Add(New OleDbParameter("loginchecker", CType("true", String)))
                    cmd.Parameters.Add(New OleDbParameter("tardyminutes", CType(result.ToString, String)))
                Else
                    cmd.Parameters.Add(New OleDbParameter("tardy", CType(DBNull.Value, Object)))
                    cmd.Parameters.Add(New OleDbParameter("remark", CType("present", String)))
                    cmd.Parameters.Add(New OleDbParameter("loginchecker", CType("true", String)))
                    cmd.Parameters.Add(New OleDbParameter("tardyminutes", CType(DBNull.Value, Object)))
                End If

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("time in successfully", MsgBoxStyle.Information, "Successful")
                timeinbtn.Enabled = False
                employeeradiobtn.Checked = False
                usernamefieldx.Text = Nothing
                passwordfieldx.Text = Nothing
            Else
                timeinbtn.Enabled = False
                MsgBox("can only time in once!", MsgBoxStyle.Exclamation, "Error")
            End If
        Else
            MsgBox("Account doesn't exists!", MsgBoxStyle.Critical, "Error")
            employeeradiobtn.Checked = False
            idchecker = Nothing
        End If
        
        con.Close()
    End Sub

    Private Sub showchecked2()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT TimeOut FROM tbl_attendanceLogs WHERE Date = '" & datenow & "' AND EmployeeID = '" & usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            temp2 = dt.Rows(0).Item(0)
        Catch ex As Exception
            temp2 = ""
        End Try
        con.Close()
    End Sub

    Private Sub undertime()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT ExpectedTimeout FROM tbl_employee_records WHERE EmployeeID = '" & usernamefieldx.Text & "'", con)
        da.Fill(dt)

        Try
            expectedtimeout = dt.Rows(0).Item(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timeoutbtn_Click(sender As Object, e As EventArgs) Handles timeoutbtn.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim datenow As String
        Dim timenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        timenow = TimeOfDay.ToString("hh:mm tt")
        'showchecked2()
        undertime()
        Dim StartTime As DateTime = expectedtimeout
        Dim currentTime As DateTime = timenow
        Dim TimeDiff As TimeSpan = StartTime.Subtract(currentTime)

        Dim result As Integer = TimeDiff.TotalMinutes
        Dim Hour = result \ 60
        Dim Minute = result Mod 60
        Dim under As String = Hour & "h " & Minute & "m"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If Not temp2 = "True" Then
            If StartTime.TimeOfDay < DateTime.Now.TimeOfDay Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET TimeOut = '" & timenow & "', Undertime = '', timeoutchecker = 'True' WHERE Date = '" & datenow & "' AND EmployeeID = '" & usernamefieldx.Text & "'", con)
                cmd.ExecuteNonQuery()

            ElseIf StartTime.TimeOfDay > DateTime.Now.TimeOfDay Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET TimeOut = '" & timenow & "', Undertime = '" & under & "', timeoutchecker = 'True' WHERE Date = '" & datenow & "' AND EmployeeID = '" & usernamefieldx.Text & "'", con)
                Dim cmd2 As OleDbCommand = New OleDbCommand("UPDATE tbl_attendanceLogs SET underTimeMinutes = '" & result.ToString & "' WHERE [EmployeeID] = '" & usernamefieldx.Text & "' AND Date = '" & datenow & "'", con)
                cmd.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
            End If
            MsgBox("Time Out Successfully", MsgBoxStyle.Information, "Time Out")
            timeoutbtn.Enabled = False
            timeoutbtn.BackgroundImage = My.Resources.timeoutdis
            employeeradiobtn.Checked = False
            usernamefieldx.Text = Nothing
            passwordfieldx.Text = Nothing
        Else
            MsgBox("Can only time out once!", MsgBoxStyle.Exclamation, "Time Out")
        End If
        con.Close()
    End Sub

    Private Sub getID()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim datenow As String
        datenow = Today().ToString("dd/MM/yyyy")
        da = New OleDbDataAdapter("SELECT EmployeeID FROM tbl_employee_records", con)
        da.Fill(dt)

        Try
            id = dt.Rows(0).Item(0)
        Catch ex As Exception
            id = "empty"
        End Try
        con.Close()
    End Sub

    Private Sub employeeradiobtn_CheckedChanged(sender As Object, e As EventArgs) Handles employeeradiobtn.CheckedChanged
        getGender()
        If employeeradiobtn.Checked = True Then
            timeinbtn.Show()
            timeoutbtn.Show()

            


            showchecked()

            If temp = "" Then
                timeinbtn.Enabled = True
                timeinbtn.BackgroundImage = My.Resources.timeinen
            Else
                timeinbtn.Enabled = False
                timeinbtn.BackgroundImage = My.Resources.timeindis
            End If

            showchecked2()
            late()
            Dim currenttime As DateTime = TimeOfDay.ToString("hh:mm tt")
            Dim timenow As Date = expectedtimein
            timenow = timenow.AddHours(3)

            If temp2 = "" Then
                If timeinbtn.Enabled = True Or currenttime < timenow Then
                    timeoutbtn.Enabled = False
                    timeoutbtn.BackgroundImage = My.Resources.timeoutdis
                Else
                    timeoutbtn.Enabled = True
                    timeoutbtn.BackgroundImage = My.Resources.timeouten
                End If
            Else
                timeoutbtn.Enabled = False
                timeoutbtn.BackgroundImage = My.Resources.timeoutdis
            End If
        Else
            timeinbtn.Hide()
            timeoutbtn.Hide()
        End If
    End Sub

    Private Sub forgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgotPass.LinkClicked
        Dim ask As MsgBoxResult

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If usernamefieldx.Text = Nothing Then
            MsgBox("Please Enter Your Username!", MsgBoxStyle.Critical, "Forgot Password")
        Else
            Dim ds1 As New DataSet
            Dim userName As New DataTable
            ds1.Tables.Add(userName)
            Dim da1 As New OleDbDataAdapter
            da1 = New OleDbDataAdapter("SELECT * FROM tbl_accounts WHERE Username = '" & usernamefieldx.Text & "'", con)
            da1.Fill(userName)

            Dim ds2 As New DataSet
            Dim defPass As New DataTable
            ds2.Tables.Add(defPass)
            Dim da2 As New OleDbDataAdapter
            da2 = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE EmployeeID = '" & usernamefieldx.Text & "'", con)
            da2.Fill(defPass)

            Dim ds3 As New DataSet
            Dim currPass As New DataTable
            ds3.Tables.Add(currPass)
            Dim da3 As New OleDbDataAdapter
            da3 = New OleDbDataAdapter("SELECT * FROM tbl_accounts WHERE Username = '" & usernamefieldx.Text & "'", con)
            da3.Fill(currPass)



            If currPass.Rows(0).Item(1) = defPass.Rows(0).Item(3) Then
                MsgBox("Invalid! Your Current Password is the Default Password!", MsgBoxStyle.Critical, "Forgot Password")
            Else
                ask = MsgBox("Do you want to Reset your Password?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Forgot Password")
                If ask = MsgBoxResult.Ok Then
                    Dim cmdUpdate As OleDbCommand = New OleDbCommand("UPDATE [tbl_accounts] SET [password] = '" & defPass.Rows(0).Item(3) & "' WHERE [Username] = '" & usernamefieldx.Text & "'", con)
                    cmdUpdate.ExecuteNonQuery()
                    MsgBox("Reset Password Successfully!", MsgBoxStyle.Information, "Forgot Password")
                Else
                    If ask = MsgBoxResult.Cancel Then
                        Me.Refresh()
                    End If
                End If
            End If
        End If

        


    End Sub


    Private Sub adminradiobtn_CheckedChanged(sender As Object, e As EventArgs) Handles adminradiobtn.CheckedChanged

    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
