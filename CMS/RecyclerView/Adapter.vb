Imports CMS.Views
Module Adapter
    Private isEventToday As Boolean = False
    Public Sub initRecylerView(DataTB As DataTable, pnlList As Panel, itemBuilderFor As Integer)
        Try
            pnlList.Controls.Clear()
            pnlList.AutoScroll = True
            pnlList.AutoScrollMargin = New Point(0, 40)
            Dim dt As DataTable = DataTB
            For index As Integer = 0 To dt.Rows.Count - 1
                With dt.Rows(index)
                    Select Case itemBuilderFor
                        Case 0
                        '   addMemberListItem(.Item("_id").ToString, .Item("FullName").ToString, .Item("MobileNumber").ToString, .Item("Picture"), i, pnlList)
                     '   RelayRecyclerViewItems(pnlList, 980, New Size(480, 71), 38, 38)
                        Case 1
                   '     addFamilyListItem(dt.Rows(i).Item("FullName").ToString, dt.Rows(i).Item("Relation").ToString, .Item("Picture"), i)
                        Case 2
                            ItemBuilder(itemBuilderFor, .Item("_id"), index, $"{ .Item("EventName")} @ { .Item("Venue")}",,,
                                        GetEventStatus(.Item("StartDate"), .Item("StartTime"), .Item("EndDate"), .Item("Endtime")),
                                        $"{ .Item("StartTime")} - { .Item("Endtime")}", .Item("Duration"), pnlList, 114)
                    End Select
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetEventStatus(StartDate, StartTime, EndDate, EndTime)
        Dim status As String = ""
        'If the Event is Starting Today ....
        Dim EventDate As Integer = Date.Compare(DateValue(StartDate), Now.Date)
        If EventDate = 0 Then
            isEventToday = True
            'Find whether it Happening Now, it has been Completed or will happen Later
            Dim inProgress As Integer = Date.Compare(TimeOfDay, TimeValue(StartTime))
            Dim isCompleted As Integer = Date.Compare(TimeOfDay, TimeValue(EndTime))
            If inProgress = 1 And isCompleted = -1 Then
                status = "Happening Now"
            ElseIf isCompleted = 1 Then
                status = "Completed"
            ElseIf inProgress = -1 Then
                status = "Later in the day"
            End If
            MsgBox(status)
            'if the Event is starting tomorrow ... 
            'Get the Start snd End Date in the Format of MMM dd. E.g Dec 21 - Jan 5
        ElseIf EventDate = 1 Then
            isEventToday = False
            Dim dateStart = Format(CDate(StartDate), "MMM dd")
            Dim dateEnd = Format(CDate(EndDate), "MMM dd")
            status = dateStart & " - " & dateEnd
        ElseIf EventDate = -1 Then
            status = "Past"
        End If
        Return status
    End Function

    Public Sub RelayRecyclerViewItems(pnlList As Panel, pnlMinWidth As Integer, itemSize As Size, locY1 As Integer, locY2 As Integer)
        Dim midWidth As Integer = pnlList.Width / 2
        Dim marginAll As Integer = midWidth - itemSize.Width
        Dim marginStart As Integer = marginAll / 2

        If pnlList.Width >= pnlMinWidth Then
            For i As Integer = 0 To pnlList.Controls.Count - 1
                If i = 0 Then locY1 = 40
                If i = 0 Then locY2 = 40
                Dim contrl = pnlList.Controls.Item(i)
                If i Mod 2 = 0 Then
                    contrl.Location = New Point(marginStart, locY1)
                    locY1 = locY1 + (itemSize.Height + 20)
                Else
                    contrl.Location = New Point(midWidth, locY2)
                    locY2 = locY2 + (itemSize.Height + 20)
                End If
            Next
        Else
            For i As Integer = 0 To pnlList.Controls.Count - 1
                If i = 0 Then locY1 = 40
                Dim contrl = pnlList.Controls.Item(i)
                contrl.Location = New Point(40, locY1)
                locY1 = locY1 + (itemSize.Height + 20)
            Next
        End If
    End Sub

    Private Sub ItemBuilder(itemBuilderFor As Integer,
                           Optional id As String = "",
                            Optional index As Integer = 0,
                            Optional title As String = "",
                            Optional subtitle As String = "",
                            Optional image As String = "",
                            Optional status As String = "",
                            Optional time As String = "",
                            Optional duration As String = "",
                            Optional pnlList As Panel = Nothing,
                            Optional itemHeight As Integer = 0)



        Select Case itemBuilderFor
            Case 0

            Case 1

            Case 2 'Add to Event Lists
                AddNewEventItem(id, title, status, time, duration, isEventToday, index)
        End Select



    End Sub

End Module
