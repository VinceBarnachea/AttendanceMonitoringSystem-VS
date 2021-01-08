Imports System.Data.OleDb
Public Class addEmployeeBox
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")


    Private Sub addEmployeeBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AssignValidation(Me.lName, ValidationType.Only_Characters)
        AssignValidation(Me.mName, ValidationType.Only_Characters)
        AssignValidation(Me.fName, ValidationType.no_Symbol)

        birthday.Value = "01/01/2001"

    Dim last As String
    Dim present As Integer

    Dim userType As String = "employee"
    Dim ds As New DataSet
    Dim dt As New DataTable
        ds.Tables.Add(dt)
    Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT [LastID] FROM tbl_accounts WHERE user_level = '" & userType & "'", con)
        da.Fill(dt)
    Dim cmdCountLastID As OleDbCommand = New OleDbCommand("SELECT COUNT([LastID]) FROM tbl_accounts", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If IsDBNull((cmdCountLastID.ExecuteScalar)) Then
            MsgBox("Employee ID Already Exist!", MsgBoxStyle.Exclamation, "Error")
        Else
    Dim count = Convert.ToInt32(cmdCountLastID.ExecuteScalar)
            If count > 0 Then
                last = dt.Rows(dt.Rows.Count - 1).Item(0)
                present = Integer.Parse(last) + 1
                last = present.ToString("000000").Substring(1, 5)
                employeeID.Text = "01-1920-" + last
            Else
                last = "00001"
                employeeID.Text = "01-1920-" + last
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        'Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\Folders\redesignAMS\redesignAMS\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")





    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim last As String
        Dim nextLast

        Dim userType As String = "employee"
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT [LastID] FROM tbl_accounts WHERE user_level = '" & userType & "'", con)
        da.Fill(dt)
        Dim cmdCountLastID As OleDbCommand = New OleDbCommand("SELECT COUNT([LastID]) FROM tbl_accounts", con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If IsDBNull((cmdCountLastID.ExecuteScalar)) Then
            MsgBox("Employee ID Already Exist!", MsgBoxStyle.Exclamation, "Error")
        Else
            Dim count = Convert.ToInt32(cmdCountLastID.ExecuteScalar)
            If count > 0 Then
                last = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim present = Integer.Parse(last) + 1
                last = present.ToString("000000").Substring(1, 5)
                employeeID.Text = "01-1920-" + last

                nextLast = last
                Dim nextPresent = Integer.Parse(nextLast) + 1
                nextLast = nextPresent.ToString("000000").Substring(1, 5)
            Else
                last = "00001"
                employeeID.Text = "01-1920-" + last

                nextLast = last
                Dim nextPresent = Integer.Parse(nextLast) + 1
                nextLast = nextPresent.ToString("000000").Substring(1, 5)
            End If
        End If




        'Paggeget ng Last ID


        'Try
        '    last = dt.Rows(dt.Rows.Count - 1).Item(0)
        'Catch ex As Exception
        '    last = dt.Rows(dt.Rows.Count).Item(0)
        'End Try

        'present = Integer.Parse(last) + 1
        'last = present.ToString("000000").Substring(1, 5)
        'employeeID.Text = "01-1920-" + last

        'nextLast = last
        'nextPresent = Integer.Parse(nextLast) + 1
        'nextLast = nextPresent.ToString("000000").Substring(1, 5)





        Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO tbl_employee_records([EmployeeID],[FirstName],[MiddleName],[LastName],[Address],[Contact_No],[Department],[Age],[Gender],[Birthday],[CivilStatus],[Date_Hired],[EmailAddress],[ExpectedTimein],[ExpectedTimeout]) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", con)

        Dim cmdID As OleDbCommand = New OleDbCommand("SELECT COUNT([EmployeeID]) FROM tbl_employee_records WHERE [EmployeeID] = '" & employeeID.Text & "'", con)

        If fName.Text = Nothing Or mName.Text = Nothing Or lName.Text = Nothing Or expectedTimein.SelectedItem = Nothing Or expectedTimeout.SelectedItem = Nothing Then
            MsgBox("Please Fillout the Fields!", MsgBoxStyle.Exclamation, "Empty Fields!")
        Else
            Dim expectedTimein1 As DateTime = DateTime.Parse(expectedTimein.Text)
            Dim expectedTimeout1 As DateTime = DateTime.Parse(expectedTimeout.Text)
            If expectedTimein1.TimeOfDay > expectedTimeout1.TimeOfDay Then
                MsgBox("The Expected Timeout should be less than Expected Timein!", MsgBoxStyle.Exclamation, "INVALID Expected Timeout")
            Else
                If IsDBNull((cmdID.ExecuteScalar)) Then
                    MsgBox("Employee ID Already Exist!", MsgBoxStyle.Exclamation, "Error")
                Else
                    Dim totalEmployee = Convert.ToInt32(cmdID.ExecuteScalar)
                    If totalEmployee > 0 Then
                        MsgBox("Employee ID Already Exist!", MsgBoxStyle.Exclamation, "Error")
                    Else
                        cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(employeeID.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(fName.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("MiddleName", CType(mName.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("LastName", CType(lName.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("Address", CType(address.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("Contact_No", CType(contactNo.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("Department", CType(department.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("Age", CType(age.Text, String)))
                        If male.Checked = True Then
                            cmd.Parameters.Add(New OleDbParameter("Gender", CType("Male", String)))
                        Else
                            cmd.Parameters.Add(New OleDbParameter("Gender", CType("Female", String)))
                        End If


                        cmd.Parameters.Add(New OleDbParameter("Birthday", CType(birthday.Text, String)))
                        If singles.Checked = True Then
                            cmd.Parameters.Add(New OleDbParameter("CivilStatus", CType("Single", String)))
                        ElseIf married.Checked = True Then
                            cmd.Parameters.Add(New OleDbParameter("CivilStatus", CType("Married", String)))
                        Else
                            cmd.Parameters.Add(New OleDbParameter("CivilStatus", CType("Widowed", String)))
                        End If
                        cmd.Parameters.Add(New OleDbParameter("Date_Hired", CType(dateHired.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("EmailAddress", CType(emailAddress.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("ExpectedTimein", CType(expectedTimein.Text, String)))
                        cmd.Parameters.Add(New OleDbParameter("ExpectedTimeout", CType(expectedTimeout.Text, String)))


                        Dim cmd2 As OleDbCommand = New OleDbCommand("INSERT INTO tbl_accounts([Username],[password],[user_level],[LastID]) VALUES(?,?,?,?)", con)


                        cmd2.Parameters.Add(New OleDbParameter("Username", CType(employeeID.Text, String)))
                        cmd2.Parameters.Add(New OleDbParameter("password", CType(lName.Text, String)))
                        cmd2.Parameters.Add(New OleDbParameter("user_level", CType("employee", String)))
                        cmd2.Parameters.Add(New OleDbParameter("LastID", CType(last, String)))


                        Try

                            cmd.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()

                            con.Close()
                            con.Dispose()
                            employeeID.Text = "01-1920-" + nextLast
                            lName.Clear()
                            fName.Clear()
                            mName.Clear()
                            department.SelectedItem = Nothing
                            address.Clear()
                            age.Clear()
                            birthday.ResetText()
                            dateHired.ResetText()
                            male.Checked = False
                            Female.Checked = False
                            singles.Checked = False
                            married.Checked = False
                            widowed.Checked = False
                            contactNo.Clear()
                            emailAddress.Clear()

                            expectedTimein.SelectedItem = Nothing
                            expectedTimeout.SelectedItem = Nothing
                            MsgBox("Account Successfuly Registered!", MsgBoxStyle.Information, "Register Account")

                            Me.Refresh()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try



                    End If

                End If
            End If


        End If


    End Sub

    Private Sub birthday_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        With birthday.Value
            Dim bday As DateTime = New DateTime(Now.Year, .Month, .Day)
            Dim aged As Integer = Now.Year - .Year
            If bday > Now Then
                aged -= 1
                age.Text = aged
            End If
        End With

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub expectedTimeout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles expectedTimeout.SelectedIndexChanged


        If expectedTimein.SelectedItem = Nothing Then
            expectedTimeout.SelectedItem = Nothing
        Else
            Dim expectedTimein1 As DateTime = DateTime.Parse(expectedTimein.Text)
            Dim expectedTimeout1 As DateTime = DateTime.Parse(expectedTimeout.Text)
            If expectedTimein1.TimeOfDay > expectedTimeout1.TimeOfDay Then
                MsgBox("The Expected Timeout should be less than Expected Timein!", MsgBoxStyle.Exclamation, "INVALID Expected Timeout")

            End If
        End If

    End Sub

    Private Sub employeeID_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Tbl_employee_recordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_employee_recordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet1)

    End Sub


    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        lName.Text = "e.g. Dela Cruz Jr."
        lName.ForeColor = Color.Gray
        fName.Clear()
        mName.Clear()
        department.SelectedItem = Nothing
        address.Clear()
        age.Clear()
        birthday.ResetText()
        dateHired.ResetText()
        male.Checked = False
        Female.Checked = False
        singles.Checked = False
        married.Checked = False
        widowed.Checked = False
        contactNo.Clear()
        emailAddress.Clear()

        expectedTimein.SelectedItem = Nothing
        expectedTimeout.SelectedItem = Nothing
    End Sub
    Private Sub lName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lName.GotFocus
        If lName.Text = "e.g. Dela Cruz Jr." Then
            lName.Text = ""
            lName.ForeColor = Color.Black
        End If
    End Sub
    Private Sub lName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lName.LostFocus
        If lName.Text = "" Then
            lName.ForeColor = Color.Gray
            lName.Text = "e.g. Dela Cruz Jr."
        End If
    End Sub

    Private Sub department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department.SelectedIndexChanged

    End Sub
End Class
