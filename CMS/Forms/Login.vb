Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports LiteDB

Public Class Login
    Inherits Office2007Form

    Private Sub SfButton3_Click(sender As Object, e As EventArgs) Handles SfButton3.Click
        MainWin.Show()
        Me.Hide()
    End Sub

    Private Sub SfButton1_Click(sender As Object, e As EventArgs) Handles SfButton1.Click
        getDB.DropCollection(EventsCollection)

    End Sub
End Class