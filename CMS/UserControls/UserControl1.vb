Public Class UserControl1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles AttendedCheckBox.Click, pbxAttendeePic.Click, lblAttendeeName.Click, Me.Click
        If AttendedCheckBox.Visible = True Then
            AttendedCheckBox.Visible = False
            AttendanceList.Remove(sender.tag.ToString)
        Else
            AttendedCheckBox.Visible = True
            AttendanceList.Add(sender.tag.ToString, lblAttendeeName.Text)
        End If
        MsgBox(sender.tag.ToString & " : " & lblAttendeeName.Text)
    End Sub


    'Public Sub NewPanel(Picture As String, Name As String, State As Boolean, Location As Point)
    '    Label4.Text = Name
    '    PictureBox1.ImageLocation = Picture
    '    PictureBox2.Visible = State
    '    Me.Location = Location
    'End Sub

End Class
