Imports System.Data.OleDb
Public Class home
    Dim selectedIndex As Integer
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AssignValidation(Me.Contact_NoTextBox, ValidationType.Only_Numbers)
        updateBtn.Enabled = False

        TextBox1.Text = "Search Employee"
        TextBox1.ForeColor = Color.Gray

        GunaDataGridView1.Columns(0).HeaderText = "EMPLOYEE ID"
        GunaDataGridView1.Columns(1).HeaderText = "FIRST NAME"
        GunaDataGridView1.Columns(2).HeaderText = "MIDDLE NAME"
        GunaDataGridView1.Columns(3).HeaderText = "LAST NAME"
        GunaDataGridView1.Columns(4).HeaderText = "ADDRESS"
        GunaDataGridView1.Columns(5).HeaderText = "CONTACT NO"
        GunaDataGridView1.Columns(6).HeaderText = "DEPARTMENT"
        GunaDataGridView1.Columns(7).HeaderText = "DATE HIRED"
        GunaDataGridView1.Columns(8).HeaderText = "AGE"
        GunaDataGridView1.Columns(9).HeaderText = "GENDER"
        GunaDataGridView1.Columns(10).HeaderText = "BIRTHDAY"
        GunaDataGridView1.Columns(11).HeaderText = "CIVIL STATUS"
        GunaDataGridView1.Columns(12).HeaderText = "EMAIL ADDRESS"
    End Sub

    Private Sub Tbl_employee_recordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_employee_recordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet1)

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Search Employee" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Search Employee"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub



    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    If TextBox1.Text = "Search Employee" Then
    '    Else
    '        If con.State = ConnectionState.Closed Then
    '            con.Open()
    '        End If
    '        Dim cmd As New OleDbCommand("SELECT * FROM tbl_employee_records WHERE LastName LIKE '%" + TextBox1.Text + "%' OR FirstName LIKE '%" + TextBox1.Text + "%' OR  MiddleName LIKE '%" + TextBox1.Text + "%' OR EmployeeID LIKE '%" + TextBox1.Text + "%'", con)
    '        Dim adapter As New OleDbDataAdapter
    '        Dim dataTable As New DataTable

    '        adapter.SelectCommand = cmd
    '        dataTable.Clear()
    '        adapter.Fill(dataTable)

    '        Tbl_employee_recordsDataGridView.DataSource = dataTable

    '        Tbl_employee_recordsDataGridView.Columns(0).HeaderText = "EMPLOYEE ID"
    '        Tbl_employee_recordsDataGridView.Columns(1).HeaderText = "FIRST NAME"
    '        Tbl_employee_recordsDataGridView.Columns(2).HeaderText = "MIDDLE NAME"
    '        Tbl_employee_recordsDataGridView.Columns(3).HeaderText = "LAST NAME"
    '        Tbl_employee_recordsDataGridView.Columns(4).HeaderText = "ADDRESS"
    '        Tbl_employee_recordsDataGridView.Columns(5).HeaderText = "CONTACT NO"
    '        Tbl_employee_recordsDataGridView.Columns(6).HeaderText = "DEPARTMENT"
    '        Tbl_employee_recordsDataGridView.Columns(7).HeaderText = "DATE HIRED"
    '        Tbl_employee_recordsDataGridView.Columns(8).HeaderText = "AGE"
    '        Tbl_employee_recordsDataGridView.Columns(9).HeaderText = "GENDER"
    '        Tbl_employee_recordsDataGridView.Columns(10).HeaderText = "BIRTHDAY"
    '        Tbl_employee_recordsDataGridView.Columns(11).HeaderText = "CIVIL STATUS"
    '        Tbl_employee_recordsDataGridView.Columns(12).HeaderText = "EMAIL ADDRESS"
    '    End If




    'End Sub

   

    'Private Sub Tbl_employee_recordsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    selectedIndex = e.RowIndex

    '    Dim row As New DataGridViewRow()
    '    row = Tbl_employee_recordsDataGridView.Rows(selectedIndex)

    '    EmployeeIDTextBox.Text = row.Cells(0).Value.ToString
    '    FirstNameTextBox.Text = row.Cells(1).Value.ToString
    '    MiddleNameTextBox.Text = row.Cells(2).Value.ToString
    '    LastNameTextBox.Text = row.Cells(3).Value.ToString
    '    AddressTextBox.Text = row.Cells(4).Value.ToString
    '    Contact_NoTextBox.Text = row.Cells(5).Value.ToString
    '    DepartmentTextBox.Text = row.Cells(6).Value.ToString
    '    Date_HiredTextBox.Text = row.Cells(7).Value.ToString
    '    AgeTextBox.Text = row.Cells(8).Value.ToString
    '    GenderTextBox.Text = row.Cells(9).Value.ToString
    '    BirthdayTextBox.Text = row.Cells(10).Value.ToString
    '    CivilStatusTextBox.Text = row.Cells(11).Value.ToString
    '    EmailAddressTextBox.Text = row.Cells(12).Value.ToString





    'End Sub

    
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        'Dim cons = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\Folders\redesignAMS\redesignAMS\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")
        Dim ask As MsgBoxResult

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim command As String
        Dim command2 As String
        command = "update [tbl_employee_records] set [FirstName] = '" & FirstNameTextBox.Text & "', [MiddleName] = '" & MiddleNameTextBox.Text & "',[LastName] = '" & LastNameTextBox.Text & "',[Contact_No] = '" & Contact_NoTextBox.Text & "',[Department] = '" & DepartmentTextBox.Text & "',[EmailAddress] = '" & EmailAddressTextBox.Text & "' WHERE [EmployeeID] = '" & EmployeeIDTextBox.Text & "'"
        command2 = "Update [tbl_accounts] set [password] = '" & LastNameTextBox.Text & "' WHERE [Username] = '" & EmployeeIDTextBox.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(command, con)
        Dim cmd2 As OleDbCommand = New OleDbCommand(command2, con)
        ask = MsgBox("Save Changes?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Update Record")
        If ask = MsgBoxResult.Ok Then
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            cmd.Dispose()
            cmd2.Dispose()
            MsgBox("Data Successfully Updated!", MsgBoxStyle.Information, "Successful")
            Dim ds = New DataSet
            Dim adapter = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
            adapter.Fill(ds)

            GunaDataGridView1.DataSource = ds.Tables(0)
        Else
            If ask = MsgBoxResult.Cancel Then
                Me.Refresh()
            End If
        End If

        
      


    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        'Dim cons = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Vince\Desktop\Folders\redesignAMS\redesignAMS\AttendanceMonitoringSystemFINAL\AttendanceMonitoringSystem\Database2.accdb")
        Dim ask As MsgBoxResult
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        ask = MsgBox("Are you sure do you want to delete it?", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical, "Delete Record")
        Dim cmds As OleDbCommand = New OleDbCommand("DELETE FROM tbl_employee_records WHERE EmployeeID = '" & EmployeeIDTextBox.Text & "'", con)
        Dim cmd2 As OleDbCommand = New OleDbCommand("DELETE FROM tbl_accounts WHERE Username = '" & EmployeeIDTextBox.Text & "'", con)
        Dim cmd3 As OleDbCommand = New OleDbCommand("DELETE FROM tbl_attendanceLogs WHERE EmployeeID = '" & EmployeeIDTextBox.Text & "'", con)
      
        Try
            If ask = MsgBoxResult.Ok Then
                cmds.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                cmd3.ExecuteNonQuery()
                cmd3.Dispose()
                cmd2.Dispose()
                cmds.Dispose()
                MsgBox("Data Successfully Deleted!", MsgBoxStyle.Information, "Successful")
                 Dim ds = New DataSet
                Dim adapter = New OleDbDataAdapter("SELECT * FROM tbl_employee_records", con)
                adapter.Fill(ds)

                GunaDataGridView1.DataSource = ds.Tables(0)
            Else
                If ask = MsgBoxResult.Cancel Then
                    Me.Refresh()
                End If
            End If
           

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles Textboxbtn.OnTextChange
        If Textboxbtn.text = "Search Employee" Then
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim cmd As New OleDbCommand("SELECT * FROM tbl_employee_records WHERE LastName LIKE '%" + Textboxbtn.text + "%' OR FirstName LIKE '%" + Textboxbtn.text + "%' OR  MiddleName LIKE '%" + Textboxbtn.text + "%' OR EmployeeID LIKE '%" + Textboxbtn.text + "%' OR Address LIKE '%" + Textboxbtn.text + "%'", con)
            Dim adapter As New OleDbDataAdapter
            Dim dataTable As New DataTable

            adapter.SelectCommand = cmd
            dataTable.Clear()
            adapter.Fill(dataTable)

            GunaDataGridView1.DataSource = dataTable

        End If

    End Sub



    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Do you want to open Crystal Report", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Crystal Report")
        If ask = MsgBoxResult.Yes Then
            CrystalReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport2.rpt"
            CrystalReportViewer.CrystalReportViewer1.Refresh()

            CrystalReportViewer.CrystalReportViewer1.RefreshReport()
            CrystalReportViewer.Show()
        Else
            If ask = MsgBoxResult.No Then

            End If
        End If
    End Sub

    Private Sub Contact_NoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Contact_NoTextBox.TextChanged
        updateBtn.Enabled = True
    End Sub

    Private Sub EmailAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailAddressTextBox.TextChanged
        updateBtn.Enabled = True
    End Sub



    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick, GunaDataGridView1.CellClick
        selectedIndex = e.RowIndex

        Dim row As New DataGridViewRow()
        row = GunaDataGridView1.Rows(selectedIndex)

        EmployeeIDTextBox.Text = row.Cells(0).Value.ToString
        FirstNameTextBox.Text = row.Cells(1).Value.ToString
        MiddleNameTextBox.Text = row.Cells(2).Value.ToString
        LastNameTextBox.Text = row.Cells(3).Value.ToString
        AddressTextBox.Text = row.Cells(4).Value.ToString
        Contact_NoTextBox.Text = row.Cells(5).Value.ToString
        DepartmentTextBox.Text = row.Cells(6).Value.ToString
        Date_HiredTextBox.Text = row.Cells(7).Value.ToString
        AgeTextBox.Text = row.Cells(8).Value.ToString
        GenderTextBox.Text = row.Cells(9).Value.ToString
        BirthdayTextBox.Text = row.Cells(10).Value.ToString
        CivilStatusTextBox.Text = row.Cells(11).Value.ToString
        EmailAddressTextBox.Text = row.Cells(12).Value.ToString


        updateBtn.Enabled = False
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Dim row As New DataGridViewRow()
        row = GunaDataGridView1.Rows(selectedIndex)
        EmployeeIDTextBox.Text = row.Cells(0).Value.ToString
        FirstNameTextBox.Text = row.Cells(1).Value.ToString
        MiddleNameTextBox.Text = row.Cells(2).Value.ToString
        LastNameTextBox.Text = row.Cells(3).Value.ToString
        AddressTextBox.Text = row.Cells(4).Value.ToString
        Contact_NoTextBox.Text = row.Cells(5).Value.ToString
        DepartmentTextBox.Text = row.Cells(6).Value.ToString
        Date_HiredTextBox.Text = row.Cells(7).Value.ToString
        AgeTextBox.Text = row.Cells(8).Value.ToString
        GenderTextBox.Text = row.Cells(9).Value.ToString
        BirthdayTextBox.Text = row.Cells(10).Value.ToString
        CivilStatusTextBox.Text = row.Cells(11).Value.ToString
        EmailAddressTextBox.Text = row.Cells(12).Value.ToString

        updateBtn.Enabled = False
    End Sub
End Class
