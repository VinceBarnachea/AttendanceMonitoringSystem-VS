Imports System.Data.OleDb
Public Class LoginForm
    Public passString As String
    Dim user_level As String = ""
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\AttendanceMonitoringSystem\Database2.accdb")

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If adminradiobtn.Checked = True Then
            user_level = "administrator"
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tbl_accounts WHERE EmployeeID = '" & usernamefield.Text & "' AND password = '" & passwordfield.Text & "' AND user_level = '" & user_level & "'", con)
            con.Open()
            Dim drlog As OleDbDataReader = cmd.ExecuteReader

            If usernamefield.Text = Nothing Or passwordfield.Text = Nothing Then
                MsgBox("Please enter credentials", MsgBoxStyle.Exclamation)
                con.Close()
            ElseIf (drlog.Read() = True) Then
                'MsgBox("Login Successful", MsgBoxStyle.Information)
                AdminForm.Show()
                Me.Hide()
                con.Close()
            Else
                MsgBox("Invalid ID or Password, Please try again...", MsgBoxStyle.Critical)
                usernamefield.Clear()
                passwordfield.Clear()
                adminradiobtn.Checked = False
                employeeradiobtn.Checked = False
                con.Close()
            End If


        ElseIf employeeradiobtn.Checked = True Then
            user_level = "employee"
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tbl_accounts WHERE EmployeeID = '" & usernamefield.Text & "' AND password = '" & passwordfield.Text & "' AND user_level = '" & user_level & "'", con)
            con.Open()
            Dim drlog As OleDbDataReader = cmd.ExecuteReader

            If usernamefield.Text = Nothing Or passwordfield.Text = Nothing Then
                MsgBox("Please enter credentials", MsgBoxStyle.Critical)
                con.Close()
            ElseIf (drlog.Read() = True) Then
                showItems()
                'MsgBox("Login Successful", MsgBoxStyle.Information)
                EmployeeForm2.Show()
                Me.Hide()
                con.Close()
            Else
                MsgBox("Invalid ID or Password, Please try again...", MsgBoxStyle.Critical)
                usernamefield.Clear()
                passwordfield.Clear()
                adminradiobtn.Checked = False
                employeeradiobtn.Checked = False
                con.Close()
            End If
        Else
            MsgBox("Please choose user level", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub showItems()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM tbl_employee_records WHERE employeeID = '" & Me.usernamefield.Text & "'", con)
        da.Fill(dt)

        passString = dt.Rows(0).Item(1) + " " + dt.Rows(0).Item(3)
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.FromArgb(110, Color.Black)
        Label1.BackColor = Color.FromArgb(110, Color.Black)
        Label2.BackColor = Color.FromArgb(110, Color.Black)
        adminradiobtn.BackColor = Color.FromArgb(110, Color.Black)
        employeeradiobtn.BackColor = Color.FromArgb(110, Color.Black)
        PictureBox2.BackColor = Color.FromArgb(110, Color.Black)
        Timer1.Enabled = True
        DateandTime.BackColor = Color.FromArgb(110, Color.Black)
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        usernamefield.Clear()
        passwordfield.Clear()
        adminradiobtn.Checked = False
        employeeradiobtn.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateandTime.Text = DateTime.Now.ToString("MMMM dd, dddd                                                              hh:mm:ss")
    End Sub

End Class
