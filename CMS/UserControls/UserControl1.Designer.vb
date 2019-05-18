<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.AttendedCheckBox = New System.Windows.Forms.PictureBox()
        Me.pbxAttendeePic = New System.Windows.Forms.PictureBox()
        Me.lblAttendeeName = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        CType(Me.AttendedCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAttendeePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.AttendedCheckBox)
        Me.Panel7.Controls.Add(Me.pbxAttendeePic)
        Me.Panel7.Controls.Add(Me.lblAttendeeName)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 257)
        Me.Panel7.TabIndex = 1
        '
        'PictureBox2
        '
        Me.AttendedCheckBox.BackColor = System.Drawing.Color.SlateGray
        Me.AttendedCheckBox.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.AttendedCheckBox.Location = New System.Drawing.Point(151, 0)
        Me.AttendedCheckBox.Name = "PictureBox2"
        Me.AttendedCheckBox.Size = New System.Drawing.Size(48, 48)
        Me.AttendedCheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AttendedCheckBox.TabIndex = 2
        Me.AttendedCheckBox.TabStop = False
        '
        'PictureBox1
        '
        Me.pbxAttendeePic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxAttendeePic.Image = Global.CMS.My.Resources.Resources.user_big
        Me.pbxAttendeePic.Location = New System.Drawing.Point(0, 0)
        Me.pbxAttendeePic.Name = "PictureBox1"
        Me.pbxAttendeePic.Size = New System.Drawing.Size(198, 212)
        Me.pbxAttendeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAttendeePic.TabIndex = 1
        Me.pbxAttendeePic.TabStop = False
        '
        'Label4
        '
        Me.lblAttendeeName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAttendeeName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendeeName.ForeColor = System.Drawing.Color.White
        Me.lblAttendeeName.Location = New System.Drawing.Point(0, 212)
        Me.lblAttendeeName.Name = "Label4"
        Me.lblAttendeeName.Size = New System.Drawing.Size(198, 43)
        Me.lblAttendeeName.TabIndex = 0
        Me.lblAttendeeName.Text = "Richard Emmanuel Francis Kweku Mensaah Osei Tutu Amponsah"
        Me.lblAttendeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Controls.Add(Me.Panel7)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(200, 257)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.AttendedCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAttendeePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents AttendedCheckBox As PictureBox
    Friend WithEvents pbxAttendeePic As PictureBox
    Friend WithEvents lblAttendeeName As Label
End Class
