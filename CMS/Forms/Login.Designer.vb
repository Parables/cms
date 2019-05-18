<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TextBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SfButton1 = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfButton3 = New Syncfusion.WinForms.Controls.SfButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxExt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(167, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parasoft CMS"
        '
        'TextBoxExt1
        '
        Me.TextBoxExt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxExt1.BeforeTouchSize = New System.Drawing.Size(287, 27)
        Me.TextBoxExt1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TextBoxExt1.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.TextBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxExt1.CornerRadius = 5
        Me.TextBoxExt1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBoxExt1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.TextBoxExt1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxExt1.Location = New System.Drawing.Point(38, 43)
        Me.TextBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt1.MinimumSize = New System.Drawing.Size(14, 10)
        Me.TextBoxExt1.Name = "TextBoxExt1"
        Me.TextBoxExt1.Size = New System.Drawing.Size(287, 27)
        Me.TextBoxExt1.TabIndex = 5
        Me.TextBoxExt1.Text = "Username"
        '
        'TextBoxExt2
        '
        Me.TextBoxExt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBoxExt2.BeforeTouchSize = New System.Drawing.Size(287, 27)
        Me.TextBoxExt2.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TextBoxExt2.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.TextBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxExt2.CornerRadius = 5
        Me.TextBoxExt2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBoxExt2.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.TextBoxExt2.ForeColor = System.Drawing.Color.DimGray
        Me.TextBoxExt2.Location = New System.Drawing.Point(38, 100)
        Me.TextBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TextBoxExt2.MinimumSize = New System.Drawing.Size(14, 10)
        Me.TextBoxExt2.Name = "TextBoxExt2"
        Me.TextBoxExt2.Size = New System.Drawing.Size(287, 27)
        Me.TextBoxExt2.TabIndex = 6
        Me.TextBoxExt2.Text = "Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SfButton1)
        Me.GroupBox1.Controls.Add(Me.SfButton3)
        Me.GroupBox1.Controls.Add(Me.TextBoxExt2)
        Me.GroupBox1.Controls.Add(Me.TextBoxExt1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(46, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 192)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'SfButton1
        '
        Me.SfButton1.AccessibleName = "Button"
        Me.SfButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SfButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SfButton1.Location = New System.Drawing.Point(125, 145)
        Me.SfButton1.Name = "SfButton1"
        Me.SfButton1.Size = New System.Drawing.Size(96, 28)
        Me.SfButton1.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SfButton1.Style.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SfButton1.TabIndex = 8
        Me.SfButton1.Text = "Cancel"
        Me.SfButton1.UseVisualStyleBackColor = False
        '
        'SfButton3
        '
        Me.SfButton3.AccessibleName = "Button"
        Me.SfButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.SfButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.SfButton3.Location = New System.Drawing.Point(229, 145)
        Me.SfButton3.Name = "SfButton3"
        Me.SfButton3.Size = New System.Drawing.Size(96, 28)
        Me.SfButton3.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.SfButton3.Style.ForeColor = System.Drawing.Color.White
        Me.SfButton3.TabIndex = 7
        Me.SfButton3.Text = "Login"
        Me.SfButton3.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(166, 273)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 20)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 314)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.TextBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxExt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TextBoxExt2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SfButton3 As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SfButton1 As Syncfusion.WinForms.Controls.SfButton
End Class
