Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Zenoph.SMSLib
Imports Zenoph.SMSLib.Enums

Public Class Contributions
    Inherits Office2007Form

#Region "Dummy Data"
    Private Function GetDummyData(listFor As String)
        Dim dataList As New List(Of String)
        With dataList
            Select Case listFor
                Case "Person"
                    MembersDT = FetchData(MembersCollection, 1)
                    For Each row As DataRow In MembersDT.Rows
                        .Add(row.Item(2).ToString)
                    Next
                    PopupControlContainer1.Width = 320
                    ListBox1.Dock = DockStyle.Fill
                Case "Fund"
                    .Add("Tithe")
                    .Add("sunday Giving")
                    .Add("Mission Support")
                    .Add("Orphange Foundation")
                    .Add("Helpless Support")
                    .Add("Church Project Funds")
                    .Add("Youth Funds")
                    .Add("2019 Conference Fund")
                Case "PaymentMethod"
                    .Add("Cash")
                    .Add("Mobile Money")
                    .Add("AirtelTigo Cash")
                    .Add("VodaCash")
                    .Add("Bank Transfer/Deposit")
                    .Add("Cheque")
                    .Add("Paypal")
                    .Add("Crytocurrency")
            End Select
            ListBox1.Tag = listFor
        End With
        Return dataList
    End Function

    Private Sub LoadListBox(listFor As String)
        ListBox1.Items.Clear()
        Dim data = GetDummyData(listFor)
        For Each item In data
            ListBox1.Items.Add(item)
        Next
    End Sub
#End Region

#Region "Custom Drop Down"
    'TODO: Optimize the CustomDropdown codes in the Main Module
    Private Sub txbPerson_Click(sender As Object, e As EventArgs) Handles txbPerson.MouseClick
        If PopupControlContainer1.IsShowing And ListBox1.Tag = "Person" Then
            PopupControlContainer1.HidePopup()
        Else
            PopupControlContainer1.CloseOnTab = True
            PopupControlContainer1.ParentControl = txbPerson
            LoadListBox("Person")
            PopupControlContainer1.ShowPopup(Point.Empty)
        End If
    End Sub

    Private Sub txbFund_Click(sender As Object, e As EventArgs) Handles txbFund.MouseClick
        If PopupControlContainer1.IsShowing And ListBox1.Tag = "Fund" Then
            PopupControlContainer1.HidePopup()
        Else
            txbFund.ReadOnly = True
            PopupControlContainer1.CloseOnTab = True
            PopupControlContainer1.ParentControl = txbFund
            LoadListBox("Fund")
            PopupControlContainer1.ShowPopup(Point.Empty)
        End If
    End Sub

    Private Sub txbPaymentMethod_Click(sender As Object, e As EventArgs) Handles txbPaymentMethod.MouseClick
        If PopupControlContainer1.IsShowing And ListBox1.Tag = "PaymentMethod" Then
            PopupControlContainer1.HidePopup()
        Else
            txbPaymentMethod.ReadOnly = True
            PopupControlContainer1.CloseOnTab = True
            PopupControlContainer1.ParentControl = txbPaymentMethod
            LoadListBox("PaymentMethod")
            PopupControlContainer1.ShowPopup(Point.Empty)
        End If
    End Sub
    Dim PhoneNumber As String
    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        If ListBox1.Tag = "Person" Then
            txbPerson.Text = ListBox1.SelectedItem.ToString
            PhoneNumber = MembersDT.Rows(ListBox1.SelectedIndex).Item("MobileNumber").ToString
        ElseIf ListBox1.Tag = "Fund" Then
            txbFund.Text = ListBox1.SelectedItem.ToString
        ElseIf ListBox1.Tag = "PaymentMethod" Then
            txbPaymentMethod.Text = ListBox1.SelectedItem.ToString
        End If
        PopupControlContainer1.HidePopup()
    End Sub

    Private Sub PopupTextbox_Leave(sender As Object, e As EventArgs) Handles txbPerson.Leave, txbFund.Leave, txbPaymentMethod.Leave
        PopupControlContainer1.HidePopup()
    End Sub

#End Region

#Region "Switch Tabs"
    Private Sub btnMenuDetails_Click(sender As Object, e As EventArgs) Handles btnMenuNewContribution.Click, btnMenuOverview.Click, btnMenuFunds.Click, btnMenuReport.Click
        btnSwitchTabs(TabControl1, sender.Tag, SplitContainer1, sender)
        Select Case sender.Tag
            Case 0
            Case 1
                DataGridView1.DataSource = FetchData(ContributionsCollection)
        End Select
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If VerifyRequiredTxb(txbPerson) And VerifyRequiredTxb(txbAmount) And VerifyRequiredTxb(txbFund) And VerifyRequiredTxb(txbPaymentMethod) Then
            Dim data As New List(Of Field) From {
                New Field With {.Key = "Contributor", .Value = txbPerson.Text},
                New Field With {.Key = "Amount", .Value = txbAmount.Text},
                New Field With {.Key = "Fund", .Value = txbFund.Text},
                New Field With {.Key = "Date", .Value = Today.Date},
                New Field With {.Key = "Note", .Value = txbNote.Text}
            }
            CUDData(ContributionsCollection, 1, data)
            Dim Message As String = $"Greetings Beloved, Your Contribution of {txbAmount.Text} into the {txbFund} Fund has been recieved. 
            God Richly bless you for investing into His business and may you continually abound in greater works. Amen {vbNewLine}  {vbNewLine}Sent by: Treasurer"
            Dim reciepients As New List(Of Field) From {New Field With {.Key = txbPerson.Text, .Value = PhoneNumber}}
            MsgBox($"Contribution from{txbPerson.Text} has been recorded...{vbNewLine}{vbNewLine} SMS message will be sent to phone number: {PhoneNumber} to acknowledge that the contribution has been recorded")
            SendSMS(reciepients, Message, "CMS")
        End If
    End Sub


    Private Sub ListBox1_MouseHover(sender As Object, e As EventArgs) Handles ListBox1.MouseHover
        'Todo: Addd a mouse hover effect
        'MsgBox($"{MousePosition.ToString} {PopupControlContainer1.Parent.Location.ToString}")
    End Sub

#End Region

End Class
