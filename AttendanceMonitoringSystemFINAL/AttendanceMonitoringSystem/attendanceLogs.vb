Public Class attendanceLogs

    Private Sub attendanceLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeIDLabel.Hide()
        crystalReport.Text = "Get " + " Report"

    End Sub
   

    Private Sub Tbl_attendanceLogsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_attendanceLogsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub crystalReport_Click(sender As Object, e As EventArgs) Handles crystalReport.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Do you want to open Crystal Report", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Crystal Report")
        If ask = MsgBoxResult.Yes Then
            CrystalReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport1.rpt"
            CrystalReportViewer.CrystalReportViewer1.SelectionFormula = "{tbl_attendanceLogs.EmployeeID} = '" & EmployeeIDLabel.Text & "'"
            CrystalReportViewer.CrystalReportViewer1.Refresh()
            CrystalReportViewer.CrystalReportViewer1.RefreshReport()
            CrystalReportViewer.Show()
        Else
            If ask = MsgBoxResult.No Then

            End If
        End If
    End Sub


    Private Sub Tbl_attendanceLogsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_attendanceLogsDataGridView.CellContentClick

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick
        Me.Validate()
        Me.Tbl_attendanceLogsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)
    End Sub

    Private Sub totalTardy_Click(sender As Object, e As EventArgs) Handles totalTardy.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

   
    Private Sub getAllReport_Click(sender As Object, e As EventArgs) Handles getAllReport.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Do you want to open Crystal Report", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Crystal Report")
        If ask = MsgBoxResult.Yes Then
            CrystalReportViewer.CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport3.rpt"
            CrystalReportViewer.CrystalReportViewer1.Refresh()
            CrystalReportViewer.CrystalReportViewer1.RefreshReport()
            CrystalReportViewer.Show()
        Else
            If ask = MsgBoxResult.No Then

            End If
        End If
    End Sub
End Class
