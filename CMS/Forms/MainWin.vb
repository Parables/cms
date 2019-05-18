Imports LiteDB
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.Controls

Public Class MainWin
    Inherits Office2007Form
    Private Sub MainWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Members.MdiParent = Me
        Members.Show()
        Contributions.MdiParent = Me
        Contributions.Show()
        Activities.MdiParent = Me
        Activities.Show()
        Dashboard.MdiParent = Me
        Dashboard.Show()
        Try
            'If there are Unsent SMS, Send them
            Dim OutBoxDT As DataTable = FetchData(SMSOutBox)
            If My.Computer.Network.IsAvailable Then
                'TODO: Replace this message with a notification
                MessageBox.Show($"Sending {OutBoxDT.Rows.Count} unsent messages...", "Internet Connection Detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If OutBoxDT.Rows.Count > 0 Then
                    For Each row As DataRow In OutBoxDT.Rows
                        'TODO: Find a way to send SMS with the same message together as a batch to SMS COST
                        SendSMS(New List(Of Field) From {New Field With {.Key = row.Item("Name").ToString, .Value = row.Item("PhoneNumber")}}, row.Item("Message"), "CMS", False)
                    Next
                End If
            Else
                MsgBox("No Internet")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnMembers.Click, btnContributions.Click, btnEvents.Click
        For i As Integer = 1 To Panel1.Controls.Count - 1
            Dim btn = Panel1.Controls.Item(i)
            btn.BackColor = My.Settings.NonActiveColor
        Next
        sender.BackColor = My.Settings.ActiveColor

        Select Case sender.Tag
            Case 1
                Dashboard.Activate()
                sender.BackColor = My.Settings.ActiveColor
            Case 2
                Members.Activate()
            Case 3
                Contributions.Activate()
            Case 4
                Activities.Activate()
        End Select
    End Sub

End Class