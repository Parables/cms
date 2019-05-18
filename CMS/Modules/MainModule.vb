Imports LiteDB
Imports Syncfusion.Windows.Forms.Tools
Imports Zenoph.SMSLib
Imports Zenoph.SMSLib.Enums

Module MainModule

    Public Sub btnSwitchTabs(ByRef TabControl As TabControl, Index As Integer, SplitCont As SplitContainer, sender As Object)
        TabControl.SelectTab(Index)

        For Each btn In SplitCont.Panel1.Controls
            btn.BackColor = My.Settings.NonActiveColor
        Next
        sender.BackColor = My.Settings.ActiveColor
    End Sub

#Region "Database Procdures"
#Region "Public Constants"
    Public Const CMSDB As String = "CMSDB"
    Public Const MembersCollection As String = "MembersCollection"
    Public Const ContributionsCollection As String = "ContributionsCollection"
    Public Const GroupsCollection As String = "GroupsCollection"
    Public Const GroupMembersCollection As String = "GroupMembersCollection"
    Public Const EventsCollection As String = "EventsCollection"
    Public Const EventAttendanceCollection As String = "EventAttendanceCollection"
    Public Const EventParticipantsCollection As String = "EventParticipantsCollection"
    Public Const SMSOutBox As String = "OutBoxCollection"

    Public LocalDataDir As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData
    Public MembersPhotoDir = $"{LocalDataDir}\photos\members\"
    Public Const MembersPhotoStorage = "$/CMS/Members/Photos/"
#End Region

#Region "Public Variables"
    Public qry As Query = Nothing
    Public ID As ObjectId = Nothing
    Dim QryID As New ObjectId
    Public MembersDT As DataTable
    Public FamilyDT As DataTable
    Public AttendanceList As New Dictionary(Of String, String)
#End Region

    ' A Function to getthe DB
    Public Function getDB() As LiteDatabase
        Return New LiteDatabase(CMSDB)
    End Function

    ' A Function to get any Collection in the DB
    Public Function GetCollection(CollectionName As String) As LiteCollection(Of BsonDocument)
        Dim db As New LiteDatabase(CMSDB)
        Return db.GetCollection(CollectionName)
    End Function

    ' TODO : Work on the Update Sub and the Delete Sub
    Public Sub CUDData(CollectionName As String, Operation As Integer, Optional Docs As List(Of Field) = Nothing)
        Dim data As New BsonDocument
        Try
            For Each doc In Docs
                data.Add(doc.Key, doc.Value)
            Next
        Catch ex As Exception
        End Try

        Try
            Select Case Operation
                Case 1 ' Inserts a new document with a New ID
                    data.Add("_id", ID)
                    GetCollection(CollectionName).Insert(data)
                Case 2 ' Updates an existing document using the ID
                    GetCollection(CollectionName).Update(ID, data)
                Case 3 ' Deletes a docuent using the ID
                    GetCollection(CollectionName).Delete(ID)
                Case 4
                    GetCollection(CollectionName).Upsert(ID, data)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Function FetchData(CollectionName As String, Optional FindType As Integer = 1, Optional FetchID As ObjectId = Nothing) As DataTable
        Dim ConType As Integer
        Dim AllData As Object
        If FetchID = Nothing Then
            QryID = ID
        Else
            QryID = FetchID
        End If
        Select Case FindType
            Case 1 ' FindAll
                AllData = GetCollection(CollectionName).FindAll()
                ConType = 1
            Case 2 ' Find base on a query
                AllData = GetCollection(CollectionName).Find(qry)
                ConType = 1
            Case 3 ' Find by ID
                AllData = GetCollection(CollectionName).FindById(QryID)
                ConType = 2
            Case 4 ' Find a specific item
                AllData = GetCollection(CollectionName).FindOne(qry)
                ConType = 2
            Case 5
                AllData = GetCollection(CollectionName).FindById(QryID)
                ConType = 3
            Case Else ' FindAll
                AllData = GetCollection(CollectionName).FindAll()
                ConType = 1
        End Select
        qry = Nothing
        Return ConvertToDataTable(AllData, ConType)
    End Function
#End Region

#Region "Convert AllData To DataTable"
    Private Function ConvertToDataTable(AllData, Type) As DataTable
        Dim DTable As New DataTable

        Try
            Select Case Type
                Case 1 ' Return For AllDocuments As BsonDocument, for looping through all the single documents in a ollection
                    'For the columns
                    For Each doc As BsonDocument In AllData
                        For Each field As KeyValuePair(Of String, BsonValue) In doc
                            DTable.Columns.Add(field.Key.ToString)
                        Next
                        Exit For
                    Next

                    'For the Rows
                    Dim rowData As New List(Of String)
                    Dim rowIndex As Integer = 0
                    'Take Each Document
                    For Each doc As BsonDocument In AllData
                        'Store all the values in that document into a List.
                        For Each field As KeyValuePair(Of String, BsonValue) In doc
                            Try
                                rowData.Add(field.Value.RawValue.ToString)
                            Catch ex As Exception
                            End Try
                        Next
                        'Create a new row in the DataTable.
                        DTable.Rows.Add()

                        'Loop through all the elements in the list and 
                        'add them to the New row at Index(rowIndex).
                        For i = 0 To rowData.Count - 1
                            DTable.Rows.Item(rowIndex).Item(i) = rowData.Item(i)
                        Next
                        'If there are more Documents, 
                        'Increase the rowIndex And 
                        'Clear the list for the New document.
                        rowIndex += 1
                        rowData.Clear()
                    Next
                Case 2 ' Return For SingleDocument As  KeyValuePair, where the keys are the columns
                    'For the columns
                    For Each field As KeyValuePair(Of String, BsonValue) In AllData
                        DTable.Columns.Add(field.Key.ToString)
                    Next

                    'For the Rows
                    Dim rowData As New List(Of String)
                    Dim rowIndex As Integer = 0
                    'Take Each Document
                    'Store all the values in that document into a List.
                    For Each field As KeyValuePair(Of String, BsonValue) In AllData
                        Try
                            rowData.Add(field.Value.RawValue.ToString)
                        Catch ex As Exception
                        End Try
                    Next
                    'Create a new row in the DataTable.
                    DTable.Rows.Add()

                    'Loop through all the elements in the list and 
                    'add them to the New row at Index(rowIndex).
                    For i = 0 To rowData.Count - 1
                        DTable.Rows.Item(rowIndex).Item(i) = rowData.Item(i)
                    Next
                    'If there are more Documents, 
                    'Increase the rowIndex And 
                    'Clear the list for the New document.
                    rowIndex += 1
                    rowData.Clear()
                Case 3 ' For subDocuments where we need both the key and values,for cases where the keys are not columns but are rows
                    DTable.Columns.Add("Key")
                    DTable.Columns.Add("Value")

                    For Each field As KeyValuePair(Of String, BsonValue) In AllData
                        Try
                            DTable.Rows.Add(field.Key.ToString, field.Value.RawValue.ToString)
                        Catch ex As Exception
                        End Try
                    Next


            End Select


            Members.DataGridView1.DataSource = DTable
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return DTable
    End Function

#End Region

    Dim ToolTip1 As New ToolTip

    ' SMS Function
    Public Sub SendSMS(Receipients As List(Of Field), Message As String, SenderID As String, Optional AddtoOutBox As Boolean = True)
        ' TODO: Add more functionalities from the docs
        Try
            Dim sms As New ZenophSMS
            With sms
                .setUser("parables95@gmail.com")
                .setPassword("AlphaBolt32")
                .authenticate()
                .setMessage(Message)
                .setSenderId(SenderID)
                .setMessageType(MSGTYPE.TEXT)
                For Each keyVal As Field In Receipients
                    .addRecipient(keyVal.Value, True)
                Next
                .submit()
            End With
        Catch ex As Exception
            MessageBox.Show($"{ex.Message} {vbNewLine}{vbNewLine}Please check your internet connection and your balance. 
            Once these two issue are resolved the SMS will be  sent automatically", "Failed to send SMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If AddtoOutBox Then
                For Each receipient In Receipients
                    Dim data As New List(Of Field) From {
                    New Field With {.Key = "Name", .Value = receipient.Key},
                    New Field With {.Key = "Message", .Value = Message},
                    New Field With {.Key = "PhoneNumber", .Value = receipient.Value}
    }
                    CUDData(SMSOutBox, 1, data)
                Next
            End If
        End Try
    End Sub

    ' Select a RDB using the tag
    Public Sub SelectRDB(gbx As GroupBox, Value As Integer)
        For i As Integer = 0 To gbx.Controls.Count - 1
            Dim rdb As RadioButtonAdv = gbx.Controls.Item(i)
            If rdb.Tag = Value Then
                rdb.Checked = True
                rdb.ForeColor = Color.White
            Else : rdb.ForeColor = Color.Gray
            End If
        Next
    End Sub

#Region "Required Inputs"
    Public Function VerifyRequiredTxb(txbName) As Boolean
        If String.IsNullOrWhiteSpace(txbName.Text) Or txbName.Text = txbName.Tag Then
            txbName.BorderColor = Color.Red
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txbName, "Invalid or Empty Data: " & vbNewLine & "This field is a required fied ... Please provide this data")
        Else
            txbName.BorderColor = Color.Lime
            ToolTip1.Hide(txbName)
            Return True
        End If
        Return False
    End Function

    Public Function VerifyRequiredCmb(cmbName) As Boolean
        If String.IsNullOrWhiteSpace(cmbName.Text) Or cmbName.Text = cmbName.Tag Then
            cmbName.FlatBorderColor = Color.Red
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(cmbName, "Invalid or Empty Data: " & vbNewLine & "This field is a required fied ... Please enter this data or select from the option from the drop down")
        Else
            cmbName.FlatBorderColor = Color.Lime
            ToolTip1.Hide(cmbName)
            Return True
        End If
        Return False
    End Function

    Public Function VerifyRequiredDtp(dtpName) As Boolean
        If IsDate(dtpName.Text) Then
            dtpName.FlatBorderColor = Color.Lime
            ToolTip1.Hide(dtpName)
            Return True
        Else
            dtpName.FlatBorderColor = Color.Red
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(dtpName, "Invalid or Empty Data: " & vbNewLine & " This field is a required fied ... Please enter a vaid date or simply choose from the calendar below")
        End If
        Return False
    End Function
#End Region

#Region "Non Required Inputs"
    Public Function VerifyNonRequiredTxb(txbName) As Boolean
        If String.IsNullOrWhiteSpace(txbName.Text) Then
            txbName.BorderColor = Color.Yellow
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(txbName, "Invalid or Empty Data: " & vbNewLine & "This field is not a required fied but it is necessary that you supply this  field with valid  data")
        Else
            txbName.BorderColor = Color.Lime
            ToolTip1.Hide(txbName)
            Return True
        End If
        Return False
    End Function

    Public Function VerifyNonRequiredCmb(cmbName) As Boolean
        If String.IsNullOrWhiteSpace(cmbName.Text) Then
            cmbName.FlatBorderColor = Color.Yellow
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(cmbName, "Invalid or Empty Data: " & vbNewLine & "This field is not a required fied but it is necessary that you supply this field with valid  data" & vbNewLine & vbNewLine & "Please enter this data or select from the option from the drop down")
        Else
            cmbName.FlatBorderColor = Color.Lime
            ToolTip1.Hide(cmbName)
            Return True
        End If
        Return False
    End Function

    Public Function VerifyNonRequiredDtp(dtpName) As Boolean
        If IsDate(dtpName.Text) Then
            dtpName.FlatBorderColor = Color.Lime
            ToolTip1.Hide(dtpName)
            Return True
        Else
            dtpName.FlatBorderColor = Color.Yellow
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(dtpName, "Invalid or Empty Data: " & vbNewLine & "This field is not a required fied but it is necessary that you supply this field with valid data" & vbNewLine & vbNewLine & "Please enter a valid date or simply choose from the calendar below")
        End If
        Return False
    End Function
#End Region


#Region "Hard Coded Strings"
    Public Enum itemBuilderFor
        Members
        Family
        Events
    End Enum

    Public Enum btnSubmitTags
        ADD
        INSERT
        EDIT
        UPDATE
    End Enum



#End Region

End Module

Public Class Field
    Public Property Key As String
    Public Property Value As BsonValue
End Class