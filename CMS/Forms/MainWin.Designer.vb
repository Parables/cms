<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWin
    Inherits Syncfusion.Windows.Forms.Office2007Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.btnEvents = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnContributions = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnMembers = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnDashboard = New Syncfusion.WinForms.Controls.SfButton()
        Me.Panel1.SuspendLayout()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBoxExt1)
        Me.Panel1.Controls.Add(Me.btnEvents)
        Me.Panel1.Controls.Add(Me.btnContributions)
        Me.Panel1.Controls.Add(Me.btnMembers)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 58)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxExt1.BeforeTouchSize = New System.Drawing.Size(287, 27)
        Me.TextBoxExt1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TextBoxExt1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxExt1.CornerRadius = 5
        Me.TextBoxExt1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBoxExt1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.TextBoxExt1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxExt1.Location = New System.Drawing.Point(11, 15)
        Me.TextBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt1.MinimumSize = New System.Drawing.Size(14, 10)
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.Size = New System.Drawing.Size(287, 27)
        Me.TextBoxExt1.TabIndex = 4
        Me.TextBoxExt1.Text = "Search members"
        '
        'btnEvents
        '
        Me.btnEvents.AccessibleName = "Button"
        Me.btnEvents.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvents.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnEvents.Location = New System.Drawing.Point(757, 14)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(96, 28)
        Me.btnEvents.TabIndex = 3
        Me.btnEvents.Tag = "4"
        Me.btnEvents.Text = "Events"
        '
        'btnContributions
        '
        Me.btnContributions.AccessibleName = "Button"
        Me.btnContributions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContributions.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnContributions.Location = New System.Drawing.Point(655, 14)
        Me.btnContributions.Name = "btnContributions"
        Me.btnContributions.Size = New System.Drawing.Size(96, 28)
        Me.btnContributions.TabIndex = 2
        Me.btnContributions.Tag = "3"
        Me.btnContributions.Text = "Contributions"
        '
        'btnMembers
        '
        Me.btnMembers.AccessibleName = "Button"
        Me.btnMembers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMembers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnMembers.Location = New System.Drawing.Point(553, 14)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(96, 28)
        Me.btnMembers.TabIndex = 1
        Me.btnMembers.Tag = "2"
        Me.btnMembers.Text = "Memberss"
        '
        'btnDashboard
        '
        Me.btnDashboard.AccessibleName = "Button"
        Me.btnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnDashboard.Location = New System.Drawing.Point(451, 14)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(96, 28)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Tag = "1"
        Me.btnDashboard.Text = "Dashboard"
        '
        'MainWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 494)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "MainWin"
        Me.Text = "Church Management System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents btnEvents As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnContributions As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnMembers As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnDashboard As Syncfusion.WinForms.Controls.SfButton
End Class
