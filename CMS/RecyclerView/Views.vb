Module Views


#Region "Events Single Item"
    Dim itemSpaceY As Integer = 30
    Public Sub AddNewEventItem(id As String, name As String, status As String, time As String, duration As String, isEventToday As Boolean, index As Integer)
        Try
            Dim pnlEventHolder, pnlStatusTimeDay As New Panel
            Dim lblEventNameVenue, lblDuration, lblTime, lblStatus As New Label

            If isEventToday Then
                Dim contCount As Integer = Activities.pnlTodaysEventsList.Controls.Count
                If contCount = 0 Then
                    itemSpaceY = 30
                Else
                    itemSpaceY += 30 + (contCount * 114)
                End If
            Else
                Dim contCount As Integer = Activities.pnlUpcomingEventsList.Controls.Count
                If contCount = 0 Then
                    itemSpaceY = 30
                Else
                    itemSpaceY += (contCount * 114)
                End If

            End If

            With lblEventNameVenue
                .AutoEllipsis = True
                .BorderStyle = BorderStyle.FixedSingle
                .Dock = DockStyle.Fill
                .Font = New Font("Segoe UI Semibold", 14.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .ForeColor = Color.White
                .Location = New Point(200, 0)
                .Size = New Size(330, 112)
                .TabIndex = 10
                .Text = name
                .TextAlign = ContentAlignment.MiddleCenter
                .Tag = id
                AddHandler .Click, AddressOf Activities.itemClicked
            End With

            With lblDuration
                .AutoEllipsis = True
                .Dock = DockStyle.Bottom
                .Font = New Font("Segoe UI", 12.0!)
                .ForeColor = Color.White
                .Location = New Point(0, 67)
                .Size = New Size(198, 43)
                .TabIndex = 10
                .Text = duration
                .TextAlign = ContentAlignment.TopCenter
                .Tag = id
                AddHandler .Click, AddressOf Activities.itemClicked
            End With

            With lblTime
                .AutoEllipsis = True
                .Dock = DockStyle.Fill
                .Font = New Font("Segoe UI", 12.0!)
                .ForeColor = Color.White
                .Location = New Point(0, 43)
                .Size = New Size(198, 67)
                .TabIndex = 10
                .Text = time
                .TextAlign = ContentAlignment.TopCenter
                .Tag = id
                AddHandler .Click, AddressOf Activities.itemClicked
            End With

            With lblStatus
                .AutoEllipsis = True
                .Dock = DockStyle.Top
                .Font = New Font("Segoe UI Semibold", 14.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .ForeColor = Color.White
                .Location = New Point(0, 0)
                .Padding = New Padding(0, 15, 0, 0)
                .Size = New Size(198, 43)
                .TabIndex = 10
                .Text = status
                .TextAlign = ContentAlignment.BottomCenter
                .Tag = id
                AddHandler .Click, AddressOf Activities.itemClicked
            End With

            With pnlStatusTimeDay
                If status = "Happening Now" Then
                    .BackColor = Color.Teal
                ElseIf status = "Completed" Then
                    .BackColor = Color.DimGray
                ElseIf status = "Later in the day" Then
                    .BackColor = Color.SteelBlue
                End If
                .BorderStyle = BorderStyle.FixedSingle
                .Controls.Add(lblDuration)
                .Controls.Add(lblTime)
                .Controls.Add(lblStatus)
                .Dock = DockStyle.Left
                .Location = New Point(0, 0)
                .Size = New Size(200, 112)
                .TabIndex = 0
                .Tag = id
                AddHandler .Click, AddressOf Activities.itemClicked
            End With

            With pnlEventHolder
                .Anchor = AnchorStyles.Top
                .BorderStyle = BorderStyle.FixedSingle
                .Controls.Add(lblEventNameVenue)
                .Controls.Add(pnlStatusTimeDay)
                .Location = New Point(23, itemSpaceY)
                .Size = New Size(532, 114)
                .Tag = id
                AddHandler .Click, AddressOf Activities.itemClicked
            End With

            If isEventToday Then
                Activities.pnlTodaysEventsList.Controls.Add(pnlEventHolder)
            Else
                Activities.pnlUpcomingEventsList.Controls.Add(pnlEventHolder)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region

End Module
