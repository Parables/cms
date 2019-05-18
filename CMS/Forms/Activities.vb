Imports Syncfusion.Windows.Forms
Imports CMS.Views
Imports CMS.Adapter
Imports LiteDB

Public Class Activities
    Inherits Office2007Form


    Private Sub Activities_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlUpcomingEventsList.Controls.Clear()
        initRecylerView(FetchData(EventsCollection), pnlTodaysEventsList, itemBuilderFor.Events)
    End Sub
    Private Sub ViewEventDetails(tag)
        ClearInputs()
        ID = New ObjectId(tag.ToString)
        Dim DT As DataTable = FetchData(EventsCollection, 3)
        With DT.Rows(0)
            ID = New ObjectId(.Item("_id").ToString)
            lblName.Text = .Item("EventName").ToString
            lblVenue.Text = .Item("Venue").ToString
            lblDate.Text = $"{Format(CDate(.Item("StartDate").ToString), "MMM dd")}{vbNewLine}-{vbNewLine}{Format(CDate(.Item("EndDate").ToString), "MMM dd")}"
            lblEventTime.Text = $"{ .Item("StartTime").ToString} - { .Item("EndTime").ToString}"
            lblEventDuration.Text = .Item("Duration").ToString
            txbEventName.Text = .Item("EventName").ToString
            txbDescription.Text = .Item("Description").ToString
            txbVenue.Text = .Item("Venue").ToString
            txbStartDate.Text = .Item("StartDate").ToString
            txbStartTime.Text = .Item("StartTime").ToString
            txbEndDate.Text = .Item("EndDate").ToString
            txbEndTime.Text = .Item("EndTime").ToString
            lblStatus.Text = GetEventStatus(.Item("StartDate"), .Item("StartTime"), .Item("EndDate"), .Item("Endtime"))
            With lblStatus
                If lblStatus.Text = "Happening Now" Then
                    btnSubmit.Visible = False
                    btnDelete.Visible = False
                    .BackColor = Color.Teal
                    pnlAttendance.Controls.Clear()
                    GetAttendance(FetchData(EventParticipantsCollection, 5), True, True)
                ElseIf lblStatus.Text = "Completed" Then
                    btnSubmit.Visible = False
                    btnDelete.Visible = False
                    .BackColor = Color.DimGray
                    pnlAttendance.Controls.Clear()
                    GetAttendance(FetchData(EventAttendanceCollection, 5), False, True)
                ElseIf lblStatus.Text = "Later in the day" Then
                    btnSubmit.Visible = True
                    btnDelete.Visible = True
                    .BackColor = Color.SteelBlue
                    pnlAttendance.Controls.Clear()
                    GetAttendance(FetchData(EventParticipantsCollection, 5), False, True)
                Else
                    btnSubmit.Visible = True
                    btnDelete.Visible = True
                    .BackColor = Color.Transparent
                    pnlAttendance.Controls.Clear()
                    GetAttendance(FetchData(EventParticipantsCollection, 5), False, True)
                End If
            End With
            chbxAllDay.Checked = CBool(.Item("AllDay").ToString)
            txbParticipants.Text = .Item("GroupName").ToString
            'GroupID = .Item("GroupID").ToString
            txbReminder.Text = .Item("Reminder").ToString
            chbxSendRemainder.Checked = CBool(.Item("SendReminder").ToString)
        End With

        btnSubmit.Image = My.Resources.Edit_Icon
        btnSubmit.BackColor = My.Settings.InAciveColor
        btnDelete.Visible = True
        DisableControls()
        btnSubmit.Tag = btnSubmitTags.EDIT
        TabControl1.SelectTab(1)


        '  dtC = CreateDummyDataTable()
        '  initRecylerView(dtC, pnlFamilyList, "Family")
    End Sub

    Private Sub GetAttendance(dt As DataTable, isEditable As Boolean, Optional LoadPrevious As Boolean = False)
        Try
            For i As Integer = 1 To dt.Rows.Count
                Dim id = dt.Rows(i).Item("Key")
                Dim mem As UserControl1 = New UserControl1
                With mem
                    .lblAttendeeName.Text = dt.Rows(i).Item("Value")
                    .lblAttendeeName.Tag = id
                    If isEditable Then .lblAttendeeName.Enabled = True : Else .lblAttendeeName.Enabled = False
                    .pbxAttendeePic.ImageLocation = $"{MembersPhotoDir}{id}.png"
                    .pbxAttendeePic.Tag = id
                    If isEditable Then .pbxAttendeePic.Enabled = True : Else .pbxAttendeePic.Enabled = False
                    .AttendedCheckBox.Visible = False
                    .AttendedCheckBox.Tag = id
                    If isEditable Then .AttendedCheckBox.Enabled = True : Else .AttendedCheckBox.Enabled = False
                    .Location = New Point(40, 40)
                    .Tag = id
                    If isEditable Then .Enabled = True : Else .Enabled = False
                End With
                pnlAttendance.Controls.Add(mem)
            Next
            If LoadPrevious Then
                Dim PreviousData As DataTable = FetchData(EventAttendanceCollection, 5)
                For i As Integer = 1 To PreviousData.Rows.Count
                    For Each attendee As UserControl1 In pnlAttendance.Controls
                        If PreviousData.Rows.Count > 0 Then
                            If attendee.Tag = PreviousData.Rows(i).Item("Key") Then
                                attendee.AttendedCheckBox.Visible = True
                            Else
                                attendee.AttendedCheckBox.Visible = False
                            End If
                        Else
                            attendee.AttendedCheckBox.Visible = False
                        End If
                    Next
                Next
            End If
            RelayRecyclerViewItems(pnlAttendance, 482, New Point(200, 256), 40, 40)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub itemClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewEventDetails(sender.Tag)
    End Sub

    Private Sub btnTabs_Click(sender As Object, e As EventArgs) Handles btnEvents.Click, btnOverView.Click, btnReports.Click
        btnSwitchTabs(TabControl1, sender.Tag, SplitContainer1, sender)
        Select Case sender.tag
            Case 0
                pnlUpcomingEventsList.Controls.Clear()
                initRecylerView(FetchData(EventsCollection), pnlTodaysEventsList, itemBuilderFor.Events)
            Case 3
                dgvGroups.DataSource = FetchData(EventAttendanceCollection)
            Case 4
                DataGridView1.DataSource = FetchData(EventParticipantsCollection)
        End Select

    End Sub
    Private Sub BtnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        ClearInputs()
        ID = ObjectId.NewObjectId
        lblName.Text = lblName.Tag : lblName.ForeColor = Color.Gray
        lblVenue.Text = lblVenue.Tag : lblVenue.ForeColor = Color.Gray
        lblDate.Text = lblDate.Tag : lblDate.ForeColor = Color.Gray
        lblEventTime.Text = lblEventTime.Tag : lblEventTime.ForeColor = Color.Gray
        lblEventDuration.Text = lblEventDuration.Tag : lblEventDuration.ForeColor = Color.Gray
        btnSubmit.Image = My.Resources.Save_Icon
        btnSubmit.BackColor = My.Settings.ActiveColor
        btnSubmit.Tag = btnSubmitTags.INSERT
        btnDelete.Visible = False
        EnableControls()
        TabControl1.SelectTab(1)
    End Sub

#Region "Input Controls"
#Region "Clear, Enable, Disable Inputs"
    Private Sub ClearInputs()
        Try
            lblName.Text = lblName.Tag : lblName.ForeColor = Color.Gray
            lblVenue.Text = lblVenue.Tag : lblVenue.ForeColor = Color.Gray
            lblDate.Text = lblDate.Tag : lblDate.ForeColor = Color.Gray
            lblEventTime.Text = lblEventTime.Tag : lblEventTime.ForeColor = Color.Gray
            lblEventDuration.Text = lblEventDuration.Tag : lblEventDuration.ForeColor = Color.Gray
            btnSubmit.Tag = btnSubmitTags.ADD
            btnSubmit.Image = My.Resources.Add_User
            btnSubmit.BackColor = My.Settings.InAciveColor
            For Each contrl In pnlEventControls.Controls
                With contrl
                    If .GetType().Name = "TextBoxExt" Then ' if the control is a TextBoxExt
                        .Text = .Tag
                        .ForeColor = Color.Gray
                        .BorderColor = Color.DeepSkyBlue
                    ElseIf .GetType().Name = "CheckBoxAdv" Then ' Else if the control is a CheckboxAdv
                        .Checked = False
                        .ForeColor = Color.Gray
                    ElseIf .GetType().Name = "GroupBox" Then
                        For Each cont In contrl.Controls
                            If .GetType().Name = "TextBoxExt" Then ' if the control is a TextBoxExt
                                .Text = .Tag
                                .ForeColor = Color.Gray
                                .BorderColor = Color.DeepSkyBlue
                            ElseIf .GetType().Name = "CheckBoxAdv" Then ' Else if the control is a CheckboxAdv
                                .Checked = False
                                .ForeColor = Color.Gray
                            End If
                        Next
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EnableControls()
        For Each contrl As Control In pnlEventControls.Controls
            contrl.Enabled = True
        Next
    End Sub

    Private Sub DisableControls()
        For Each contrl As Control In pnlEventControls.Controls
            contrl.Enabled = False
        Next
    End Sub
#End Region

#Region "Set/Remove Hints"

    Private Sub RemoveHint(sender As Object, e As EventArgs)
        If sender.Text = sender.Tag Then
            sender.Clear()
            sender.ForeColor = Color.White
        End If
    End Sub

    Private Sub SetHint(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(sender.Text) Then
            sender.Text = sender.Tag
            sender.ForeColor = Color.Gray
        End If
    End Sub
#End Region

#Region "Custom Textbox Drop Down"
    Private Sub dropdowns_Click(sender As Object, e As EventArgs)
        Select Case sender.Tag
            Case "Start Date"
                displayDropDown(sender, pccDate)
                pccDate.Tag = "Start Date"
                MonthCalendarAdv1.Tag = "Start Date"
            Case "End Date"
                displayDropDown(sender, pccDate)
                pccDate.Tag = "End Date"
                MonthCalendarAdv1.Tag = "End Date"
            Case "Participants"
                displayDropDown(sender, pccCheckedListBox, True, "Participants")
            Case "Reminder"
                displayDropDown(sender, pccList, True, "Reminder")
        End Select

    End Sub

    Private Sub displayDropDown(sender As Object, pcc As PopupControlContainer, Optional shouldFillListBox As Boolean = False, Optional loadListBoxWith As String = "")
        If pcc.IsShowing Then
            pcc.HidePopup()
        Else
            sender.ReadOnly = True
            pcc.CloseOnTab = True
            pcc.ParentControl = sender
            pcc.ShowPopup(Point.Empty)
        End If
        If shouldFillListBox Then
            LoadListBox(loadListBoxWith)
        End If
    End Sub

    Dim GroupDT As DataTable
    Private Sub LoadListBox(listFor As String)

        Select Case listFor
            Case "Participants"
                With chlstbxParticipants.Items
                    .Clear()
                    .Add("Whole Congregation")
                    GroupDT = FetchData(GroupsCollection)
                    For Each row As DataRow In GroupDT.Rows
                        .Add(row.Item("GroupName"))
                    Next
                End With
            Case "Reminder"
                With ListBox1.Items
                    .Clear()
                    .Add("10 minutes before Event")
                    .Add("30 minutes before Event")
                    .Add("50 minutes before Event")
                    .Add("1 hour before Event")
                    .Add("5 hours before Event")
                    .Add("10 hours before Event")
                    .Add("1 day before Event")
                    .Add("5 days before Event")
                    .Add("1 week before Event")
                    .Add("1 month before Event")
                End With
        End Select

    End Sub

    Private Sub MonthCalendarAdv1_DateSelected(sender As Object, e As EventArgs) Handles MonthCalendarAdv1.DateChanged, MonthCalendarAdv1.DateSelected
        If sender.tag = "Start Date" Then
            txbStartDate.Text = Format(sender.Value, "MMMM dd, yyyy")
        ElseIf sender.tag = "End Date" Then
            txbEndDate.Text = Format(sender.Value, "MMMM dd, yyyy")
        End If
    End Sub

    Private Sub MonthCalendarAdv1_DoneButtonClick(sender As Object, e As EventArgs) Handles MonthCalendarAdv1.NoneButtonClick
        If sender.tag = "Start Date" Then
            txbStartDate.Text = Format(sender.Value, "MMMM dd, yyyy")
            pccDate.HidePopup(PopupCloseType.Done)
        ElseIf sender.tag = "End Date" Then
            txbEndDate.Text = Format(sender.Value, "MMMM dd, yyyy")
            pccDate.HidePopup(PopupCloseType.Done)
        End If
    End Sub

    Dim GroupID As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txbReminder.Text = ListBox1.SelectedItem
    End Sub


    Private Sub BtnSaveParticipants_Click(sender As Object, e As EventArgs) Handles btnSaveParticipants.Click
        Dim ParticipantsList As New List(Of Field)

        'TODO: Find all the members of each group and save it in EventParticipantsCollection
        For Each indx In chlstbxParticipants.CheckedIndices
            Dim grpID As ObjectId = New ObjectId(GroupDT.Rows(indx).Item("_id").ToString)
            Dim GroupMembersDT As DataTable = FetchData(GroupMembersCollection, 5, grpID)
            'Option 1
            For Each row As DataRow In GroupMembersDT.Rows
                ParticipantsList.Add(New Field With {.Key = row.Item("Key"), .Value = row.Item("Value")})
            Next
            CUDData(EventParticipantsCollection, 4, ParticipantsList)

            'Option 2
            'Dim dtReader As DataTableReader = GroupMembersDT.CreateDataReader
            'While dtReader.Read
            '    ParticipantsDT.Load(dtReader)
            'End While

        Next
    End Sub

#End Region

#Region "Mouse Effects"
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnAddEvent.MouseEnter
        sender.BackColor = My.Settings.ActiveColor
    End Sub
    Private Sub btn_Mouseleave(sender As Object, e As EventArgs) Handles btnAddEvent.MouseLeave
        sender.BackColor = Color.Transparent
    End Sub

#End Region

#End Region

#Region "Verify DateTime and calc Duration"

#Region "Set AM PM or AllDay"

    Dim StartTime, EndTime As String
    Private Sub SetAMPM_Click(sender As Object, e As EventArgs)
        If sender.text = "am" Then sender.text = "pm" : Else sender.Text = "am"
    End Sub

    Private Sub chbxAllDay_CheckStateChanged(sender As Object, e As EventArgs)
        If chbxAllDay.Checked = True Then
            txbStartTime.Text = "12:00"
            txbStartTime.Enabled = False
            txbEndTime.Text = "12:00"
            txbEndTime.Enabled = False
        Else
            txbStartTime.Enabled = True
            txbEndTime.Enabled = True
        End If
    End Sub

#End Region

    Dim ToolTip1 As New ToolTip
    Private Sub txbEndDate_Validated(sender As Object, e As EventArgs)
        VerifyDates()
    End Sub

    Private Sub txbStartTime_Validated(sender As Object, e As EventArgs)
        VerifyTime()
    End Sub

    Public Function VerifyDates() As Boolean
        Try
            ' Checks for valid Start date
            If IsDate(txbStartDate.Text) Then
                txbStartDate.BorderColor = Color.Lime
                ToolTip1.Hide(txbStartDate)
            Else
                txbStartDate.BorderColor = Color.Red
                ToolTip1.IsBalloon = True
                ToolTip1.SetToolTip(txbStartDate, "Invalid or Empty Data: " & vbNewLine & "This field is a required fied ... Please provide this data")
                Return False
            End If

            ' Checks for valid End date
            If IsDate(txbEndDate.Text) Then
                txbEndDate.BorderColor = Color.Lime
                ToolTip1.Hide(txbEndDate)
            Else
                txbEndDate.BorderColor = Color.Red
                ToolTip1.IsBalloon = True
                ToolTip1.SetToolTip(txbEndDate, "Invalid or Empty Data: " & vbNewLine & "This field is a required fied ... Please provide this data")
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Function VerifyTime() As Boolean '3 Steps
        Try
            If chbxAllDay.Checked = True Then
                Return True
            Else
                ' Step 01 : Checks if Start Time is Empty( : ) or the hour value > 12 or the minute value >59 
                If txbStartTime.Text = "  :  " Or Val(txbStartTime.Text.Substring(0, 2)) > 12 Or Val(txbStartTime.Text.Substring(3, 2)) > 59 Then
                    txbStartTime.BorderColor = Color.Red
                    ToolTip1.IsBalloon = True
                    ToolTip1.SetToolTip(txbStartTime, "Invalid or Empty Data: " & vbNewLine & "The Start Time should be in 12 hour format and should be before the End time")
                    Return False
                Else
                    'Step 02 : convert Start Time to 24hours local time
                    'If the time is in pm, adding 12 to the 12hour format date gives you the 24 format
                    If lblStartTimeAMPM.Text = "pm" Then
                        StartTime = TimeValue(txbStartTime.Text).AddHours(12).ToShortTimeString
                    Else ' Leave it unchanged since it is already in am
                        StartTime = TimeValue(txbStartTime.Text).ToShortTimeString
                    End If
                    txbStartTime.BorderColor = Color.Lime
                    ToolTip1.Hide(txbStartTime)
                End If

                ' Step 03 : Checks if End Time is Empty( : ) or the hour value > 12 or the minute value >59
                If txbEndTime.Text = "  :  " Or Val(txbEndTime.Text.Substring(0, 2)) > 12 Or Val(txbEndTime.Text.Substring(3, 2)) > 59 Then
                    txbEndTime.BorderColor = Color.Red
                    ToolTip1.IsBalloon = True
                    ToolTip1.SetToolTip(txbEndTime, "Invalid or Empty Data: " & vbNewLine & "The End Time should be in 12 hour format and should be after the Start Time")
                    Return False
                Else
                    'Step 04 : convert End Time to 24hours local time
                    'If the time is in pm, adding 12 to the 12hour format date gives you the 24 format
                    If lblEndTimeAMPM.Text = "pm" Then
                        EndTime = TimeValue(txbEndTime.Text).AddHours(12).ToShortTimeString
                    Else ' Leave it unchanged since it is already in am
                        EndTime = TimeValue(txbEndTime.Text).ToShortTimeString
                    End If
                    txbEndTime.BorderColor = Color.Lime
                    ToolTip1.Hide(txbEndTime)
                End If
            End If
        Catch ex As Exception
            Return False ' Because there was a failure during onversion to 24hours due to invalid time
        End Try
        Return True ' if the Start Time and the End time are correct
    End Function

    Public Function VerifyDateTime() As Boolean
        Try
            If VerifyDates() And VerifyTime() Then
                Dim bigDate As Integer = Date.Compare(txbEndDate.Text, txbStartDate.Text)
                Dim bigTime As Integer = Date.Compare(EndTime, StartTime)

                If bigDate = 1 Then ' if the End Date is after or greater than the Start Date
                    txbEndDate.BorderColor = Color.Lime
                    ToolTip1.Hide(txbEndDate)
                    txbEndTime.BorderColor = Color.Lime
                    ToolTip1.Hide(txbEndTime)
                    txbStartDate.BorderColor = Color.Lime
                    ToolTip1.Hide(txbStartDate)
                    txbStartTime.BorderColor = Color.Lime
                    ToolTip1.Hide(txbStartTime)
                    Return True
                ElseIf bigDate = -1 Then ' if the End Date is before or smaller than the Start Date, then error
                    'Set only the end date to Error (Red)
                    txbEndDate.BorderColor = Color.Red
                    ToolTip1.IsBalloon = True
                    ToolTip1.SetToolTip(txbEndDate, "Invalid Or Empty Data:      " & vbNewLine & "The End Date should be greater than Start Date")
                    'Set the other dates and time to neutral (blue)
                    txbEndTime.BorderColor = Color.DeepSkyBlue
                    ToolTip1.Hide(txbEndTime)
                    txbStartDate.BorderColor = Color.DeepSkyBlue
                    ToolTip1.Hide(txbStartDate)
                    txbStartTime.BorderColor = Color.DeepSkyBlue
                    ToolTip1.Hide(txbStartTime)
                    Return False

                    ' if the End Date is the same as the Start Date, then compare the time
                ElseIf bigDate = 0 Then
                    If bigTime = 1 Then ' if the End Time is after or greater than the Start Time
                        txbEndDate.BorderColor = Color.Lime
                        ToolTip1.Hide(txbEndDate)
                        txbEndTime.BorderColor = Color.Lime
                        ToolTip1.Hide(txbEndTime)
                        txbStartDate.BorderColor = Color.Lime
                        ToolTip1.Hide(txbStartDate)
                        txbStartTime.BorderColor = Color.Lime
                        ToolTip1.Hide(txbStartTime)
                        Return True
                    ElseIf bigTime = -1 Or bigTime = 0 Then ' if the End Time is before or smaller than the Start Time or the same as the Start Time, then error
                        txbEndTime.BorderColor = Color.Red
                        ToolTip1.IsBalloon = True
                        ToolTip1.SetToolTip(txbEndTime, "Invalid Or Empty Data:      " & vbNewLine & "The End Time should be greater than Start Time")
                        'Set the other dates and time to neutral (blue)
                        txbEndDate.BorderColor = Color.DeepSkyBlue
                        ToolTip1.Hide(txbEndDate)
                        txbStartDate.BorderColor = Color.DeepSkyBlue
                        ToolTip1.Hide(txbStartDate)
                        txbStartTime.BorderColor = Color.DeepSkyBlue
                        ToolTip1.Hide(txbStartTime)
                        Return False
                    End If
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Private Function GetDuration() As String
        Dim Duration As String = ""
        If VerifyDateTime() Then
            Dim getMonths As Integer = DateDiff(DateInterval.Month, CDate(txbStartDate.Text), CDate(txbEndDate.Text))
            If getMonths = 0 Then
                Dim getDays As Integer = DateDiff(DateInterval.Day, CDate(txbStartDate.Text), CDate(txbEndDate.Text))
                If getDays = 0 Then
                    Dim getHours As Integer = DateDiff(DateInterval.Hour, CDate(txbStartTime.Text), CDate(txbEndTime.Text))
                    If getHours = 0 Then
                        Dim getMinutes As Integer = DateDiff(DateInterval.Minute, CDate(txbStartTime.Text), CDate(txbEndTime.Text))
                        If getMinutes = 1 Then Duration = "1 minute" : Else Duration = $"{getMinutes} minutes"
                    ElseIf getHours = 1 Then
                        Duration = "1 hour"
                    Else
                        Duration = $"{getHours} hours"
                    End If
                ElseIf getDays = 1 Then
                    Duration = "1 day"
                Else
                    Duration = $"{getDays} days"
                End If
            ElseIf getMonths = 1 Then
                Duration = "1 month"
            Else
                Duration = $"{getMonths} months"
            End If
        End If
        Return Duration
    End Function

#End Region

    Private Function PutData()
        If VerifyRequiredTxb(txbEventName) And VerifyRequiredTxb(txbDescription) And VerifyRequiredTxb(txbVenue) And VerifyDateTime() And VerifyRequiredTxb(txbParticipants) And VerifyRequiredTxb(txbReminder) Then
            Dim data As New List(Of Field) From {
                New Field With {.Key = "EventName", .Value = txbEventName.Text},
                New Field With {.Key = "Description", .Value = txbDescription.Text},
                New Field With {.Key = "Venue", .Value = txbVenue.Text},
                New Field With {.Key = "StartDate", .Value = txbStartDate.Text},
                New Field With {.Key = "EndDate", .Value = txbEndDate.Text},
                New Field With {.Key = "StartTime", .Value = StartTime},
                New Field With {.Key = "EndTime", .Value = EndTime},
                New Field With {.Key = "AllDay", .Value = chbxAllDay.Checked},
                New Field With {.Key = "Duration", .Value = GetDuration()},
                New Field With {.Key = "GroupID", .Value = ID},
                New Field With {.Key = "GroupName", .Value = txbParticipants.Text},
                New Field With {.Key = "Reminder", .Value = txbReminder.Text},
                New Field With {.Key = "SendReminder", .Value = chbxSendRemainder.Checked}
            }
            Dim str As String = ""

            For Each foeld As Field In data
                str &= $"{foeld.Key} : {foeld.Value.RawValue} {vbNewLine}"
            Next
            MessageBox.Show(str)
            Return data
        End If
        Throw New Exception("The fileds in red are required.  Please resolve them before you can proceed to Save Event")
        Return Nothing
    End Function


#Region "Insert, Update And Delete Buttons"
    Private Sub SubmitButton_Clicked(sender As Object, e As EventArgs)
        Dim prompt As String = ""
        Dim operation As Integer = 0
        Dim eventName As String = ""
        Try
            If btnSubmit.Tag = btnSubmitTags.ADD Then
                btnSubmit.Tag = btnSubmitTags.INSERT
                btnSubmit.Image = My.Resources.Save_Icon
                btnSubmit.BackColor = My.Settings.ActiveColor
                ID = ObjectId.NewObjectId
                MsgBox("New entry mode")
                EnableControls()
            ElseIf btnSubmit.Tag = btnSubmitTags.EDIT Then
                btnSubmit.Tag = btnSubmitTags.UPDATE
                btnSubmit.Image = My.Resources.Save_Icon
                btnSubmit.BackColor = My.Settings.ActiveColor
                MsgBox("Edit mode")
                EnableControls()
            ElseIf btnSubmit.Tag = btnSubmitTags.INSERT Then
                operation = 1
                CUDData(EventsCollection, 1, PutData)
                btnSubmit.Tag = btnSubmitTags.ADD
                btnSubmit.Image = My.Resources.Add_User
                btnSubmit.BackColor = My.Settings.InAciveColor
                btnDelete.Visible = False
                ClearInputs()
                DisableControls()
            ElseIf btnSubmit.Tag = btnSubmitTags.UPDATE Then
                operation = 2
                CUDData(EventsCollection, 2, PutData)
                eventName = lblName.Text
                btnSubmit.Tag = btnSubmitTags.ADD
                btnSubmit.Image = My.Resources.Add_User
                btnSubmit.BackColor = My.Settings.InAciveColor
                btnDelete.Visible = False
                ClearInputs()
                DisableControls()
            End If
        Catch ex As Exception
            prompt = ex.Message
            MsgBox(prompt)
        End Try
        If prompt = "" Then
            If operation = 1 Then
                MsgBox("New Event has been added successfully", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
            ElseIf operation = 2 Then
                MsgBox(eventName & "'s info has been updated successfully", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

        If MessageBox.Show("Are you sure you want to DELETE this Event: " & lblName.Text & "?",
                           "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CUDData(EventsCollection, 3)
            btnDelete.Visible = False
            btnSubmit.Image = My.Resources.Add_User
            ClearInputs()
            DisableControls()
        End If
    End Sub
#End Region


    Private Sub Label3_Click(sender As Object, e As EventArgs)
        VerifyDateTime()
        GetDuration()
    End Sub


    Private Sub AutoLabel1_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Dim strID As String = ""
        Dim data As New List(Of Field)
        For Each attendee As KeyValuePair(Of String, String) In AttendanceList
            strID &= attendee.Value & vbNewLine & " : " & attendee.Key
            data.Add(New Field With {.Key = attendee.Key, .Value = attendee.Value})
        Next
        CUDData(EventAttendanceCollection, 4, data)
        MsgBox(strID)
    End Sub



    Private Sub Activities_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If TabControl1.SelectedIndex = 1 Then
            RelayRecyclerViewItems(pnlAttendance, 482, New Point(200, 256), 40, 40)
        End If
    End Sub
End Class