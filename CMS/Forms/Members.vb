Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports LiteDB
Imports Syncfusion.WinForms.Controls

Public Class Members
    Inherits Office2007Form

    '/**** Me.Load - Initialize the First Page ****/
#Region "Members Load"
    Private Sub Members_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initRecylerView(FetchData(MembersCollection), pnlMembersList, itemBuilderFor.Members)
    End Sub
#End Region

    '/**** Switch tabs with MenuButtons or TabControl ****/
#Region "Switch Tabs"
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            For Each btn In SplitContainer1.Panel1.Controls
                btn.BackColor = My.Settings.NonActiveColor
            Next
            btnMenuDetails.BackColor = My.Settings.ActiveColor
        End If
    End Sub

    Private Sub btnMenuDetails_Click(sender As Object, e As EventArgs) Handles btnMenuDetails.Click, btnMenuGroups.Click, btnMenuFollowUps.Click
        btnSwitchTabs(TabControl1, sender.Tag, SplitContainer1, sender)
        Select Case sender.tag
            Case 0
                initRecylerView(FetchData(MembersCollection), pnlMembersList, itemBuilderFor.Members)
            Case 2

            Case 3
                initRecylerView(FetchData(GroupsCollection), pnlMembersList, itemBuilderFor.Members)
            Case 4
                FetchData(MembersCollection)
        End Select

    End Sub
#End Region

    '/**** Responsive Layout ****/
#Region "Responsive Layout"
    Private Sub Members_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        TabPage1SizeChanged()
    End Sub

    Private Sub TabPage1_SizeChanged(sender As Object, e As EventArgs) Handles tabMemberInfo.SizeChanged
        TabPage1SizeChanged()
    End Sub

    Private Sub TabPage1SizeChanged()
        Dim tabWidth As Integer = tabMemberInfo.Size.Width
        Dim midPoint As Integer = tabMemberInfo.Size.Width / 2
        Dim marginAll As Integer = midPoint - 480
        Dim marginRight As Integer = marginAll / 2
        Dim marginLeft As Integer = (marginAll / 2) + (marginRight / 2)
        pnlHeader.Location = New Point(pnlPersonal.Location.X, pnlHeader.Location.Y)
        If tabMemberInfo.Size.Width > 980 Then
            pnlPersonal.Location = New Point(marginLeft, pnlPersonal.Location.Y)
            pnlContacts.Location = New Point(midPoint, pnlPersonal.Location.Y)
            pnlWork.Location = New Point(pnlPersonal.Location.X, pnlPersonal.Location.Y + pnlPersonal.Size.Height + 20)
            pnlFamily.Location = New Point(midPoint, pnlContacts.Location.Y + pnlContacts.Height + 20)
            pnlFamily.Size = New Size(480, 587)
            pnlHeader.Size = New Size(pnlPersonal.Location.X + pnlPersonal.Width + pnlContacts.Location.X + pnlContacts.Width, 144)
        ElseIf tabMemberInfo.Size.Width < 990 Then
            pnlPersonal.Location = New Point(35, pnlPersonal.Location.Y)
            pnlContacts.Location = New Point(pnlPersonal.Location.X, pnlPersonal.Location.Y + pnlPersonal.Height + 20)
            pnlWork.Location = New Point(pnlPersonal.Location.X, pnlContacts.Location.Y + pnlContacts.Size.Height + 20)
            pnlFamily.Location = New Point(pnlPersonal.Location.X, pnlWork.Location.Y + pnlWork.Height + 20)
            pnlFamily.Size = New Size(480, 348)
            pnlHeader.Size = New Size(480, 144)
        End If

        If isShowingAddFamBox Then
            isShowingAddFamBox = False
            pnlNewFamily.Visible = False
            pnlNewFamily.SendToBack()
        End If

    End Sub
#End Region

    '/**** General Subs ****/
#Region "General Subs"
    Private Sub initRecylerView(DataTB As DataTable, pnlList As Panel, itemBuilderFor As Integer)
        pnlList.Controls.Clear()
        pnlList.AutoScroll = True
        pnlList.AutoScrollMargin = New Point(0, 20)
        Dim dt As DataTable = DataTB
        MembersDT = DataTB
        For i As Integer = 0 To dt.Rows.Count - 1
            With dt.Rows(i)
                Select Case itemBuilderFor
                    Case 0
                        addMemberListItem(.Item("_id").ToString, .Item("FullName").ToString, .Item("MobileNumber").ToString, .Item("Picture"), i, pnlList)
                        RelayRecyclerViewItems(pnlList, 980, New Size(480, 71), 38, 38)
                    Case 1
                        addFamilyListItem(dt.Rows(i).Item("FullName").ToString, dt.Rows(i).Item("Relation").ToString, .Item("Picture"), i)
                End Select
            End With
        Next
    End Sub

    Private Sub RelayRecyclerViewItems(pnlList As Panel, pnlMinWidth As Integer, itemSize As Size, locY1 As Integer, locY2 As Integer)
        Dim midWidth As Integer = pnlList.Width / 2
        Dim marginAll As Integer = midWidth - itemSize.Width
        Dim marginStart As Integer = marginAll / 2

        If pnlList.Width >= pnlMinWidth Then
            For i As Integer = 0 To pnlList.Controls.Count - 1
                If i = 0 Then locY1 = 38
                If i = 0 Then locY2 = 38
                Dim pnl As Panel = pnlList.Controls.Item(i)
                If i Mod 2 = 0 Then
                    pnl.Location = New Point(marginStart, locY1)
                    locY1 = locY1 + (itemSize.Height + 10)
                Else
                    pnl.Location = New Point(midWidth, locY2)
                    locY2 = locY2 + (itemSize.Height + 10)
                End If
            Next
        Else
            For i As Integer = 0 To pnlList.Controls.Count - 1
                If i = 0 Then locY1 = 38
                Dim pnl As Panel = pnlList.Controls.Item(i)
                pnl.Location = New Point(38, locY1)
                locY1 = locY1 + (itemSize.Height + 10)
            Next
        End If
    End Sub

    Private Sub ViewMemberItemDetails(tag)
        ClearInputs()
        ID = New ObjectId(tag.ToString)
        Dim DT As DataTable = FetchData(MembersCollection, 3)
        With DT.Rows(0)
            'if no picture, use the default
            If .Item("Picture").ToString = "" Then
                pbxPicture.Image = My.Resources.user_big
                downloadURL = ""
            Else
                pbxPicture.ImageLocation = .Item("Picture").ToString
                downloadURL = .Item("Picture").ToString
            End If
            lblName.Text = .Item("FullName").ToString
            lblPhoneNumber.Text = .Item("MobileNumber").ToString
            lblWorkNumber.Text = .Item("WorkNumber").ToString
            lblEmail.Text = .Item("Role").ToString
            lblLocation.Text = .Item("PrimaryAddress").ToString
            txbFirstName.Text = .Item("FirstName").ToString
            txbLastName.Text = .Item("LastName").ToString
            txbMiddleName.Text = .Item("MiddleName").ToString
            If txbMiddleName.Text <> txbMiddleName.Tag Then btnShowMiddleName.Visible = False : Else btnShowMiddleName.Visible = True
            txbMaidenName.Text = .Item("MaidenName").ToString
            If txbMaidenName.Text <> txbMaidenName.Tag Then btnShowMaidenName.Visible = False : Else btnShowMaidenName.Visible = True
            txbDate.Text = .Item("DOB").ToString
            SelectRDB(gbxGender, .Item("Gender"))
            Gender = .Item("Gender")
            SelectRDB(gbxMembership, .Item("Membership"))
            Membership = .Item("Membership")
            SelectRDB(gbxMaritalStatus, .Item("MaritalStatus"))
            MaritalStatus = .Item("MaritalStatus")
            txbMobileNumber.Text = .Item("MobileNumber").ToString
            txbEmail.Text = .Item("Email").ToString
            txbWorkNumber.Text = .Item("WorkNumber").ToString
            If txbWorkNumber.Text <> txbWorkNumber.Tag Then btnShowWorkNumber.Visible = False : Else btnShowWorkNumber.Visible = True
            txbHomeNumber.Text = .Item("HomeNumber").ToString
            If txbHomeNumber.Text <> txbHomeNumber.Tag Then btnShowHomeNumber.Visible = False : Else btnShowHomeNumber.Visible = True
            txbPrimAddress.Text = .Item("PrimaryAddress").ToString
            txbSecAddress.Text = .Item("SecondaryAddress").ToString
            If txbSecAddress.Text <> txbSecAddress.Tag Then btnShowSecAddress.Visible = False : Else btnShowSecAddress.Visible = True
            txbRole.Text = .Item("Role").ToString
            txbOrganisation.Text = .Item("Company").ToString
            txbEduLevel.Text = .Item("EducationalLevel").ToString
            txbInstitution.Text = .Item("School").ToString
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

    Private Sub EnableControls()
        pbxPicture.Enabled = True
        If lblName.Text <> lblName.Tag Then lblName.ForeColor = Color.White
        If lblPhoneNumber.Text <> lblPhoneNumber.Tag Then lblPhoneNumber.ForeColor = Color.White
        If lblWorkNumber.Text <> lblWorkNumber.Tag Then lblWorkNumber.ForeColor = Color.White
        If lblEmail.Text <> lblEmail.Tag Then lblEmail.ForeColor = Color.White
        If lblLocation.Text <> lblLocation.Tag Then lblLocation.ForeColor = Color.White
        For Each pnl In tabMemberInfo.Controls ' Loops trhough all the controls on the tabMembersInfo
            If pnl.GetType().Name = "Panel" Then ' if the control is a Panel then
                For Each gpbx In pnl.Controls ' Loops trhough all the controls of the Panel
                    If gpbx.GetType().Name = "GroupBox" Then ' if the control is a GroupBox
                        For Each contrl In gpbx.Controls ' Loops through all the controls of the GroupBox
                            If contrl.GetType().Name = "TextBoxExt" Then ' if the control is a TextBoxExt
                                If contrl.Text <> contrl.Tag Then contrl.ForeColor = Color.White
                            ElseIf contrl.GetType().Name = "RadioButtonAdv" Then ' Else if the control is a RadioButton
                                If contrl.Checked = True Then contrl.ForeColor = Color.White
                            End If
                            contrl.Enabled = True
                        Next
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub DisableControls()
        pbxPicture.Enabled = False
        For Each pnl In tabMemberInfo.Controls ' Loops trhough all the controls on the tabMembersInfo
            If pnl.GetType().Name = "Panel" Then ' if the control is a Panel then
                For Each gpbx In pnl.Controls ' Loops trhough all the controls of the Panel
                    If gpbx.GetType().Name = "GroupBox" Then ' if the control is a GroupBox
                        For Each contrl In gpbx.Controls ' Loops through all the controls of the GroupBox
                            With contrl ' Set cntrl Enabled=False and ForeColor to Gray for all
                                .Enabled = False
                                If contrl.GetType().Name <> "SfButton" Then .ForeColor = Color.Gray
                            End With
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ClearInputs()
        pbxPicture.Image = New Bitmap(My.Resources.user_big)
        lblName.Text = lblName.Tag : lblName.ForeColor = Color.Gray
        lblPhoneNumber.Text = lblPhoneNumber.Tag : lblPhoneNumber.ForeColor = Color.Gray
        lblWorkNumber.Text = lblWorkNumber.Tag : lblWorkNumber.ForeColor = Color.Gray
        lblEmail.Text = lblEmail.Tag : lblEmail.ForeColor = Color.Gray
        lblLocation.Text = lblLocation.Tag : lblLocation.ForeColor = Color.Gray
        btnSubmit.Tag = btnSubmitTags.ADD
        btnSubmit.Image = My.Resources.Add_User
        btnSubmit.BackColor = My.Settings.InAciveColor
        For Each pnl In tabMemberInfo.Controls ' Loops trhough all the controls on the tabMembersInfo
            If pnl.GetType().Name = "Panel" Then ' if the control is a Panel then
                For Each gpbx In pnl.Controls ' Loops trhough all the controls of the Panel
                    If gpbx.GetType().Name = "GroupBox" Then ' if the control is a GroupBox
                        For Each contrl In gpbx.Controls ' Loops through all the controls of the GroupBox
                            With contrl
                                If .GetType().Name = "TextBoxExt" Then ' if the control is a TextBoxExt
                                    .Text = .Tag
                                    .ForeColor = Color.Gray
                                    .BorderColor = Color.DeepSkyBlue
                                ElseIf .GetType().Name = "RadioButtonAdv" Then ' Else if the control is a RadioButton
                                    .Checked = False
                                    .ForeColor = Color.Gray
                                ElseIf .GetType().Name = "SfButton" Then 'Else if the control is a SfButton
                                    .Visible = True
                                End If
                            End With
                        Next
                    End If
                Next
            End If
        Next
    End Sub
#End Region

    '/**** Customer Recyclerview ****/
#Region "Custom RecyclerView"

#Region "Family RecyclerView"
    Private Sub FamilyItemClickEventHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TODO: Display Warning beefore delete
        Dim prompt = MessageBoxAdv.Show("Are you sure you want to remove this person from the Family?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Delete from Table and reload the RecyclerView
        ' dtC.Rows.RemoveAt(sender.tag)
        ' initRecylerView(dtC, pnlFamilyList, "Family")
    End Sub
#End Region

#Region "GroupMembersRecyclerView"
    Private Sub pnlGroupList_SizeChanged(sender As Object, e As EventArgs) 
        RelayRecyclerViewItems(pnlGroupList, 980, New Size(480, 71), 38, 38)
    End Sub
#End Region

#Region "Members Recyclerview"
    Private Sub MemberListItemClickEventHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewMemberItemDetails(sender.Tag)
    End Sub

    Private Sub pnlMembersList_SizeChanged(sender As Object, e As EventArgs) Handles pnlMembersList.SizeChanged
        RelayRecyclerViewItems(pnlMembersList, 980, New Size(480, 71), 38, 38)
    End Sub
#End Region

#End Region

    '/**** Item Builder for ReyclerViews ****/
#Region "Item Builders"
    Dim locMY As Integer = 0
    Private Sub addMemberListItem(ID As String, Name As String, Role As String, Picture As String, i As Integer, pnlList As Panel)
        Dim itemContainer As New Panel
        Dim picBox As New PictureBox
        Dim lblName As New Label
        Dim lblRole As New Label

        If i = 0 Then
            locMY = 38
        Else
            locMY = locMY + (71 + 10)
        End If

        With lblName
            .AutoSize = True
            .Font = New Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.White
            .Location = New Point(86, 13)
            .Size = New Size(235, 25)
            .TabIndex = 1
            .Text = Name
            .Tag = ID
        End With

        With lblRole
            .AutoSize = True
            .Font = New Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.White
            .ImageAlign = ContentAlignment.MiddleLeft
            .Location = New Point(86, 38)
            .Size = New Size(65, 20)
            .TabIndex = 1
            .Text = Role
            .TextAlign = ContentAlignment.MiddleCenter
            .Tag = ID
        End With

        With picBox
            If Picture = "" Then
                .Image = New Bitmap(My.Resources.user_small)
            Else
                .ImageLocation = Picture
            End If
            .Location = New System.Drawing.Point(0, -1)
            .Name = "vmPic"
            .Size = New Size(70, 70)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .TabIndex = 0
            .TabStop = False
            .Tag = ID
        End With

        With itemContainer
            .Anchor = AnchorStyles.Top
            .BorderStyle = BorderStyle.FixedSingle
            .Controls.Add(lblName)
            .Controls.Add(lblRole)
            .Controls.Add(picBox)
            .Location = New Point(38, locMY)
            .Size = New Size(480, 71)
            .Tag = ID
        End With

        pnlList.Controls.Add(itemContainer)
        AddHandler itemContainer.Click, AddressOf MemberListItemClickEventHandler
        AddHandler lblName.Click, AddressOf MemberListItemClickEventHandler
        AddHandler lblRole.Click, AddressOf MemberListItemClickEventHandler
        AddHandler picBox.Click, AddressOf MemberListItemClickEventHandler
    End Sub

    Dim locFY As Integer = 0
    ' Dim dtC As DataTable = CreateDummyDataTable()
    Private Sub addFamilyListItem(Name As String, Relation As String, Picture As String, i As Integer)
        Dim itemContainer As New Panel
        Dim picBox As New PictureBox
        Dim lblName As New Label
        Dim lblRelation As New Label
        Dim locFX As Integer = (pnlFamilyList.Width - 244) / 2
        If i = 0 Then
            locFY = 38
        Else
            locFY = locFY + (251 + 20)
        End If

        With lblName
            .AutoEllipsis = True
            .Font = New Font("Segoe UI", 11.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.White
            .Location = New Point(0, 189)
            .Name = "famName" & i
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(242, 32)
            .TabIndex = 1
            .Text = Name
            .TextAlign = ContentAlignment.MiddleCenter
            .Tag = i
        End With

        With lblRelation
            .AutoEllipsis = True
            .Font = New Font("Segoe UI", 10.0!)
            .ForeColor = Color.White
            .Dock = DockStyle.Bottom
            .ImageAlign = ContentAlignment.MiddleLeft
            .Location = New Point(0, 224)
            .Name = "famRelation" & i
            .Padding = New Padding(0, 0, 0, 5)
            .Size = New Size(242, 25)
            .TabIndex = 1
            .Text = Relation
            .TextAlign = ContentAlignment.MiddleCenter
            .Tag = i
        End With

        With picBox
            If Picture = "" Then
                .Image = New Bitmap(My.Resources.user_big)
            Else
                .ImageLocation = Picture
            End If
            .BorderStyle = BorderStyle.FixedSingle
            .Dock = DockStyle.Top
            .Location = New Point(0, -1)
            .Name = "fmPic"
            .Size = New Size(242, 189)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .TabIndex = 0
            .TabStop = False
            .Tag = i
        End With


        With itemContainer
            .BorderStyle = BorderStyle.FixedSingle
            .Controls.Add(lblName)
            .Controls.Add(lblRelation)
            .Controls.Add(picBox)
            .Location = New Point(locFX, locFY)
            .Margin = New Padding(3, 3, 3, 10)
            .Name = "itemContainer" & i
            .Size = New Size(244, 251)
            .TabIndex = i
            .Tag = i
        End With

        pnlFamilyList.Controls.Add(itemContainer)
        AddHandler itemContainer.Click, AddressOf FamilyItemClickEventHandler
        AddHandler lblName.Click, AddressOf FamilyItemClickEventHandler
        AddHandler lblRelation.Click, AddressOf FamilyItemClickEventHandler
        AddHandler picBox.Click, AddressOf FamilyItemClickEventHandler
    End Sub
#End Region

    '/**** TabPages Codes ****/
#Region "TabPages Codes"

#Region "tabAllMembers - Index 0"
    Private Sub AddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        ClearInputs()
        ID = ObjectId.NewObjectId
        pbxPicture.Image = My.Resources.user_big
        downloadURL = ""
        lblName.Text = lblName.Tag : lblName.ForeColor = Color.Gray
        lblPhoneNumber.Text = lblPhoneNumber.Tag : lblPhoneNumber.ForeColor = Color.Gray
        lblWorkNumber.Text = lblWorkNumber.Tag : lblWorkNumber.ForeColor = Color.Gray
        lblEmail.Text = lblEmail.Tag : lblEmail.ForeColor = Color.Gray
        lblLocation.Text = lblLocation.Tag : lblLocation.ForeColor = Color.Gray
        btnSubmit.Image = My.Resources.Save_Icon
        btnSubmit.BackColor = My.Settings.ActiveColor
        btnSubmit.Tag = btnSubmitTags.INSERT
        btnDelete.Visible = False
        EnableControls()
        TabControl1.SelectTab(1)
    End Sub
#End Region

#Region "tabMembersInfo - Index 1"
#Region "Set Profile Picture"
    Private Sub pbxPicture_Click(sender As Object, e As EventArgs) Handles pbxPicture.Click
        With OpenFileDialog1
            .AddExtension = True
            .CheckFileExists = True
            .CheckPathExists = True
            .Multiselect = False
            .ShowDialog()
            .Title = "Select a picture for the Member"
        End With
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim ofdFileName As String = OpenFileDialog1.FileName.ToString
        Try
            FindPhoto(UploadImage(ofdFileName))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' DeleteUploadedImage(picName)
    End Sub
#End Region

#Region "Picture Upload, Find and Delete"
    Dim uploadURL As String = ""
    Dim downloadURL As String = ""
    Private Function UploadImage(fileName) As String
        Try
            Dim db As New LiteDatabase(CMSDB)
            uploadURL = $"{MembersPhotoStorage}{ID}"
            db.FileStorage.Upload(uploadURL, fileName)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return uploadURL
    End Function

    Private Function FindPhoto(FileID As String) As String
        Dim File As LiteFileInfo = Nothing
        Try
            Dim db As New LiteDatabase(CMSDB)
            File = db.FileStorage.FindById(FileID)
            My.Computer.FileSystem.CreateDirectory(MembersPhotoDir)
            downloadURL = $"{MembersPhotoDir}{ID}.png"
            File.SaveAs(downloadURL, True)
            pbxPicture.ImageLocation = downloadURL
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return downloadURL
    End Function

    Private Sub DeleteUploadedImage()
        Try
            Dim db As New LiteDatabase(CMSDB)
            db.FileStorage.Delete($"{MembersPhotoStorage}{ID}")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Gather data"
#Region "Radio Buttons Selected Item"
    Dim Gender As Integer = 0, MaritalStatus As Integer = 0, Membership As Integer = 0
    Private Sub Gender_MouseClick(sender As Object, e As EventArgs) Handles rdbMale.MouseClick, rdbFemale.MouseClick
        Gender = sender.Tag
    End Sub

    Private Sub Membership_MouseClick(sender As Object, e As EventArgs) Handles rdbMember.MouseClick, rdbNotMember.MouseClick, rdbAttender.MouseClick, rdbVisitor.MouseClick
        Membership = sender.Tag
    End Sub

    Private Sub MaritalStatus_MouseClick(sender As Object, e As EventArgs) Handles rdbWidowed.MouseClick, rdbSingle.MouseClick, rdbSeparated.MouseClick, rdbMarried.MouseClick, rdbEngaged.MouseClick, rdbDivorced.MouseClick
        MaritalStatus = sender.Tag
    End Sub
#End Region

    Private Function PutData()
        If VerifyRequiredTxb(txbFirstName) And VerifyRequiredTxb(txbLastName) Then
            Dim data As New List(Of Field) From {
            New Field With {.Key = "Picture", .Value = downloadURL},
            New Field With {.Key = "FullName", .Value = $"{txbFirstName.Text} {If(txbMiddleName.Text <> txbMiddleName.Tag, txbMiddleName.Text, "")} {txbLastName.Text} {If(txbMaidenName.Text <> txbMaidenName.Tag, txbMaidenName.Text, "")}"},
            New Field With {.Key = "FirstName", .Value = txbFirstName.Text},
            New Field With {.Key = "LastName", .Value = txbLastName.Text},
            New Field With {.Key = "MiddleName", .Value = txbMiddleName.Text},
            New Field With {.Key = "MaidenName", .Value = txbMaidenName.Text},
            New Field With {.Key = "DOB", .Value = txbDate.Text},
            New Field With {.Key = "Gender", .Value = Gender},
            New Field With {.Key = "Membership", .Value = Membership},
            New Field With {.Key = "MaritalStatus", .Value = MaritalStatus},
            New Field With {.Key = "MobileNumber", .Value = txbMobileNumber.Text},
            New Field With {.Key = "Email", .Value = txbEmail.Text},
            New Field With {.Key = "WorkNumber", .Value = txbWorkNumber.Text},
            New Field With {.Key = "HomeNumber", .Value = txbHomeNumber.Text},
            New Field With {.Key = "PrimaryAddress", .Value = txbPrimAddress.Text},
            New Field With {.Key = "SecondaryAddress", .Value = txbSecAddress.Text},
            New Field With {.Key = "Role", .Value = txbRole.Text},
            New Field With {.Key = "Company", .Value = txbOrganisation.Text},
            New Field With {.Key = "EducationalLevel", .Value = txbEduLevel.Text},
            New Field With {.Key = "School", .Value = txbInstitution.Text}
        }
            Return data
        End If
        '  Throw New NullReferenceException
        Return Nothing
    End Function

#End Region

#Region "Insert, Update and Delete Buttons"
    Private Sub SubmitButton_Clicked(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If btnSubmit.Tag = btnSubmitTags.ADD Then
                btnSubmit.Tag = btnSubmitTags.INSERT
                btnSubmit.Image = My.Resources.Save_Icon
                btnSubmit.BackColor = My.Settings.ActiveColor
                ID = ObjectId.NewObjectId
                downloadURL = ""
                MsgBox("New entry mode")
                EnableControls()
            ElseIf btnSubmit.Tag = btnSubmitTags.EDIT Then
                btnSubmit.Tag = btnSubmitTags.UPDATE
                btnSubmit.Image = My.Resources.Save_Icon
                btnSubmit.BackColor = My.Settings.ActiveColor
                MsgBox("Edit mode")
                EnableControls()
            ElseIf btnSubmit.Tag = btnSubmitTags.INSERT Then
                CUDData(MembersCollection, 1, PutData)
                MsgBox("New member has been added successfully")
                btnSubmit.Tag = btnSubmitTags.ADD
                btnSubmit.Image = My.Resources.Add_User
                btnSubmit.BackColor = My.Settings.InAciveColor
                btnDelete.Visible = False
                ClearInputs()
                DisableControls()
            ElseIf btnSubmit.Tag = btnSubmitTags.UPDATE Then
                CUDData(MembersCollection, 2, PutData)
                MsgBox(lblName.Text & "'s info has been updated successfully")
                btnSubmit.Tag = btnSubmitTags.ADD
                btnSubmit.Image = My.Resources.Add_User
                btnSubmit.BackColor = My.Settings.InAciveColor
                btnDelete.Visible = False
                ClearInputs()
                DisableControls()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If MessageBox.Show("Are you sure you want to DELETE this Member: " & lblName.Text & "?",
                           "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CUDData(MembersCollection, 3)
            DeleteUploadedImage()
            My.Computer.FileSystem.DeleteFile($"{MembersPhotoDir}{ID}.png", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
            btnDelete.Visible = False
            btnSubmit.Image = My.Resources.Add_User
            ClearInputs()
            DisableControls()
        End If
    End Sub
#End Region

#Region "Set/Remove Hints & btnsAddExtra"
    Private Sub RemoveHint(sender As Object, e As EventArgs) Handles txbFirstName.Enter, txbLastName.Enter, txbMiddleName.Enter, txbMaidenName.Enter,
          txbDate.Enter, txbMobileNumber.Enter, txbEmail.Enter, txbWorkNumber.Enter, txbHomeNumber.Enter, txbPrimAddress.Enter, txbSecAddress.Enter,
              txbEduLevel.Enter, txbInstitution.Enter, txbRole.Enter, txbOrganisation.Enter
        If sender.Text = sender.Tag Then
            sender.Clear()
            sender.ForeColor = Color.White
        End If
    End Sub

    Private Sub SetHint(sender As Object, e As EventArgs) Handles txbFirstName.Leave, txbLastName.Leave, txbMiddleName.Leave, txbMaidenName.Leave,
          txbDate.Leave, txbMobileNumber.Leave, txbEmail.Leave, txbWorkNumber.Leave, txbHomeNumber.Leave, txbPrimAddress.Leave, txbSecAddress.Leave,
              txbEduLevel.Leave, txbInstitution.Leave, txbRole.Leave, txbOrganisation.Leave

        If String.IsNullOrWhiteSpace(sender.Text) Then
            sender.Text = sender.Tag
            sender.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnsAddExtra_Click(sender As Object, e As EventArgs) Handles btnShowWorkNumber.Click, btnShowHomeNumber.Click, btnShowSecAddress.Click, btnShowMiddleName.Click, btnShowMaidenName.Click
        sender.Visible = False
    End Sub
#End Region

#Region " Add Family Memebers"
    Dim isShowingAddFamBox As Boolean
    Private Sub btnAddFamilyMember_Click(sender As Object, e As EventArgs) Handles btnAddFamilyMember.Click
        Dim parentWidth As Integer = pnlFamily.Width
        Dim midWidth = parentWidth / 2
        Dim marginStart = midWidth - (289 / 2)
        Dim locY As Integer = pnlFamilyList.Location.Y + 20
        pnlNewFamily.Location = New Point(marginStart + pnlFamily.Location.X, locY)
        isShowingAddFamBox = True
        pnlNewFamily.Visible = True
        pnlNewFamily.BringToFront()
    End Sub

    Private Sub btnNewFamilyDone_Click(sender As Object, e As EventArgs) Handles btnNewFamilyDone.Click
        ' dtC.Rows.Add(txbPerson.Text, txbRelation.Text, "NULL")
        ' initRecylerView(dtC, pnlFamilyList, "Family")
    End Sub

    Private Sub btnNewFamilyCancel_Click(sender As Object, e As EventArgs) Handles btnNewFamilyCancel.Click
        isShowingAddFamBox = False
        pnlNewFamily.Visible = False
        pnlNewFamily.SendToBack()
    End Sub
#End Region

#Region "Custom Textbox Drop Down"

    Private Sub txbPerson_Click(sender As Object, e As EventArgs) Handles txbPerson.Click, txbRelation.Click, txbDate.Click
        Select Case sender.Tag
            Case "Person"
                displayDropDown(sender, pccList, True, "Person")
            Case "Relation"
                displayDropDown(sender, pccList, True, "Relation")
            Case "Date of Birth"
                displayDropDown(sender, pccDate)
        End Select

    End Sub

    Private Sub displayDropDown(sender As Object, pcc As PopupControlContainer, Optional shouldFillListBox As Boolean = False, Optional loadListBoxWith As String = "")
        If pcc.IsShowing And ListBox1.Tag = loadListBoxWith Then
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

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        If ListBox1.Tag = "Person" Then
            txbPerson.Text = ListBox1.SelectedItem.ToString
        ElseIf ListBox1.Tag = "Relation" Then
            txbRelation.Text = ListBox1.SelectedItem.ToString
        End If
        pccList.HidePopup()
    End Sub

    Private Sub LoadListBox(listFor As String)
        ListBox1.Items.Clear()
        Dim data = CreateDummyList(listFor)
        For Each item In data
            ListBox1.Items.Add(item)
        Next
    End Sub

    Private Sub PopupTextbox_Leave(sender As Object, e As EventArgs) Handles txbPerson.Leave, txbRelation.Leave
        pccList.HidePopup()
    End Sub

    Private Sub MonthCalendarAdv1_DateSelected(sender As Object, e As EventArgs) Handles MonthCalendarAdv1.DateSelected
        txbDate.Text = Format(sender.Value, "MMMM dd, yyyy")
    End Sub

    Private Sub MonthCalendarAdv1_DoneButtonClick(sender As Object, e As EventArgs) Handles MonthCalendarAdv1.NoneButtonClick
        txbDate.Text = Format(sender.Value, "MMMM dd, yyyy")
        pccDate.HidePopup(PopupCloseType.Done)
    End Sub

    Private Sub txbDate_Leave(sender As Object, e As EventArgs) Handles txbDate.Leave
        pccDate.HidePopup(PopupCloseType.Done)
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btnAddMember.MouseEnter, btnDelete.MouseEnter, btnSubmit.MouseEnter, pbxPicture.MouseEnter
        sender.BackColor = My.Settings.ActiveColor
    End Sub
    Private Sub btn_Mouseleave(sender As Object, e As EventArgs) Handles btnAddMember.MouseLeave, btnDelete.MouseLeave, btnSubmit.MouseLeave, pbxPicture.MouseLeave
        sender.BackColor = Color.Transparent
    End Sub
#End Region
#End Region

#Region "tabGroups - Index 2"
    Private Sub dgvGroups_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroups.CellDoubleClick
        TabControl1.SelectTab(3)
        initRecylerView(FetchData(MembersCollection), pnlMembersList, "Members")
    End Sub


#End Region

#End Region

    '/**** Dummy Data ****/
#Region "Dummy Data"
    Private Function CreateDummyList(listFor As String)
        Dim dataList As New List(Of String)
        With dataList
            Select Case listFor
                Case "Person"
                    .Add("Emmanuel Botchey Junior(Parables)")
                    .Add("Richard Osei Tutu Amponsah(Constable)")
                    .Add("Frederick Amedonu(Rob kid)")
                    .Add("Emmanuel Tawiah(Short Man)")
                    .Add("Stephen Boakye(Mr. West)")
                    .Add("Bernard Saim(Span Knight)")
                    .Add("Gifty Assarewaa")
                    .Add("Portia Boateng(Secretary 1)")
                    .Add("Sarah Adepoti")
                    .Add("Hakim")
                    .Add("Nuhu Watarah Yakubu")
                Case "Relation"
                    .Add("Father")
                    .Add("Mother")
                    .Add("Brother")
                    .Add("Sister")
                    .Add("Uncle")
                    .Add("Aunty")
                    .Add("Newphew")
                    .Add("Niece")
                    .Add("Grandpa")
                    .Add("Grandma")
            End Select
            ListBox1.Tag = listFor
        End With
        Return dataList
    End Function




#End Region

End Class

