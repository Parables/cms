<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contributions
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contributions))
        Me.BarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
        Me.tabOverview = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabFunds = New System.Windows.Forms.TabPage()
        Me.lblSorry2 = New System.Windows.Forms.Label()
        Me.tabReport = New System.Windows.Forms.TabPage()
        Me.lblSorry3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabContribution = New System.Windows.Forms.TabPage()
        Me.PopupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.pnlNewContribution = New System.Windows.Forms.Panel()
        Me.CheckBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.txbNote = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txbPaymentMethod = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txbAmount = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txbPerson = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.txbFund = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSubmit = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pccDate = New Syncfusion.Windows.Forms.PopupControlContainer(Me.components)
        Me.MonthCalendarAdv1 = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv()
        Me.btnMenuOverview = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnMenuNewContribution = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnMenuReport = New Syncfusion.WinForms.Controls.SfButton()
        Me.btnMenuFunds = New Syncfusion.WinForms.Controls.SfButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tabOverview.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFunds.SuspendLayout()
        Me.tabReport.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabContribution.SuspendLayout()
        Me.PopupControlContainer1.SuspendLayout()
        Me.pnlNewContribution.SuspendLayout()
        CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbPaymentMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbFund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pccDate.SuspendLayout()
        CType(Me.MonthCalendarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarItem1
        '
        Me.BarItem1.BarName = "BarItem1"
        Me.BarItem1.Enabled = False
        Me.BarItem1.ID = "Personal Details"
        Me.BarItem1.ShowToolTipInPopUp = False
        Me.BarItem1.SizeToFit = True
        Me.BarItem1.Text = "Personal Details"
        '
        'tabOverview
        '
        Me.tabOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.tabOverview.Controls.Add(Me.DataGridView1)
        Me.tabOverview.Location = New System.Drawing.Point(4, 5)
        Me.tabOverview.Name = "tabOverview"
        Me.tabOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverview.Size = New System.Drawing.Size(492, 526)
        Me.tabOverview.TabIndex = 1
        Me.tabOverview.Text = "TabPage2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(486, 520)
        Me.DataGridView1.TabIndex = 1
        '
        'tabFunds
        '
        Me.tabFunds.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.tabFunds.Controls.Add(Me.lblSorry2)
        Me.tabFunds.Location = New System.Drawing.Point(4, 5)
        Me.tabFunds.Name = "tabFunds"
        Me.tabFunds.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFunds.Size = New System.Drawing.Size(492, 526)
        Me.tabFunds.TabIndex = 2
        Me.tabFunds.Text = "TabPage3"
        '
        'lblSorry2
        '
        Me.lblSorry2.AutoSize = True
        Me.lblSorry2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorry2.ForeColor = System.Drawing.Color.White
        Me.lblSorry2.Location = New System.Drawing.Point(82, 220)
        Me.lblSorry2.Name = "lblSorry2"
        Me.lblSorry2.Size = New System.Drawing.Size(300, 63)
        Me.lblSorry2.TabIndex = 1
        Me.lblSorry2.Text = "Sorry, Funds is still under construction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please come back later."
        Me.lblSorry2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabReport
        '
        Me.tabReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.tabReport.Controls.Add(Me.lblSorry3)
        Me.tabReport.Location = New System.Drawing.Point(4, 5)
        Me.tabReport.Name = "tabReport"
        Me.tabReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReport.Size = New System.Drawing.Size(492, 526)
        Me.tabReport.TabIndex = 3
        Me.tabReport.Text = "TabPage4"
        '
        'lblSorry3
        '
        Me.lblSorry3.AutoSize = True
        Me.lblSorry3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorry3.ForeColor = System.Drawing.Color.White
        Me.lblSorry3.Location = New System.Drawing.Point(82, 220)
        Me.lblSorry3.Name = "lblSorry3"
        Me.lblSorry3.Size = New System.Drawing.Size(306, 63)
        Me.lblSorry3.TabIndex = 1
        Me.lblSorry3.Text = "Sorry, Report is still under construction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please come back later."
        Me.lblSorry3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabContribution)
        Me.TabControl1.Controls.Add(Me.tabOverview)
        Me.TabControl1.Controls.Add(Me.tabFunds)
        Me.TabControl1.Controls.Add(Me.tabReport)
        Me.TabControl1.ItemSize = New System.Drawing.Size(62, 1)
        Me.TabControl1.Location = New System.Drawing.Point(-6, -32)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 535)
        Me.TabControl1.TabIndex = 0
        '
        'tabContribution
        '
        Me.tabContribution.AutoScroll = True
        Me.tabContribution.AutoScrollMargin = New System.Drawing.Size(0, 40)
        Me.tabContribution.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.tabContribution.Controls.Add(Me.pnlNewContribution)
        Me.tabContribution.Controls.Add(Me.pccDate)
        Me.tabContribution.Controls.Add(Me.PopupControlContainer1)
        Me.tabContribution.Location = New System.Drawing.Point(4, 5)
        Me.tabContribution.Margin = New System.Windows.Forms.Padding(35, 3, 3, 3)
        Me.tabContribution.Name = "tabContribution"
        Me.tabContribution.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContribution.Size = New System.Drawing.Size(492, 526)
        Me.tabContribution.TabIndex = 0
        Me.tabContribution.Text = "TabPage1"
        '
        'PopupControlContainer1
        '
        Me.PopupControlContainer1.AutoSize = True
        Me.PopupControlContainer1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PopupControlContainer1.Controls.Add(Me.ListBox1)
        Me.PopupControlContainer1.Location = New System.Drawing.Point(87, 29)
        Me.PopupControlContainer1.Name = "PopupControlContainer1"
        Me.PopupControlContainer1.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.PopupControlContainer1.Size = New System.Drawing.Size(208, 181)
        Me.PopupControlContainer1.TabIndex = 19
        Me.PopupControlContainer1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Gray
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Cash", "Mobile Money", "AirtelTigoCash", "VodaCash", "Bank Deposit/Transfer", "Cheque", "PayPal", "Other"})
        Me.ListBox1.Location = New System.Drawing.Point(1, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(206, 180)
        Me.ListBox1.TabIndex = 18
        '
        'pnlNewContribution
        '
        Me.pnlNewContribution.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlNewContribution.AutoScroll = True
        Me.pnlNewContribution.AutoSize = True
        Me.pnlNewContribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNewContribution.Controls.Add(Me.CheckBoxAdv1)
        Me.pnlNewContribution.Controls.Add(Me.txbNote)
        Me.pnlNewContribution.Controls.Add(Me.txbPaymentMethod)
        Me.pnlNewContribution.Controls.Add(Me.txbAmount)
        Me.pnlNewContribution.Controls.Add(Me.txbPerson)
        Me.pnlNewContribution.Controls.Add(Me.txbFund)
        Me.pnlNewContribution.Controls.Add(Me.Panel3)
        Me.pnlNewContribution.Location = New System.Drawing.Point(24, 70)
        Me.pnlNewContribution.Name = "pnlNewContribution"
        Me.pnlNewContribution.Size = New System.Drawing.Size(444, 403)
        Me.pnlNewContribution.TabIndex = 23
        '
        'CheckBoxAdv1
        '
        Me.CheckBoxAdv1.AutoSize = True
        Me.CheckBoxAdv1.BeforeTouchSize = New System.Drawing.Size(102, 23)
        Me.CheckBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.CheckBoxAdv1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
        Me.CheckBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAdv1.ForeColor = System.Drawing.Color.Gray
        Me.CheckBoxAdv1.Location = New System.Drawing.Point(53, 103)
        Me.CheckBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.CheckBoxAdv1.Name = "CheckBoxAdv1"
        Me.CheckBoxAdv1.Size = New System.Drawing.Size(102, 23)
        Me.CheckBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2010
        Me.CheckBoxAdv1.TabIndex = 20
        Me.CheckBoxAdv1.Text = "Anonymous"
        Me.CheckBoxAdv1.ThemeName = "Office2010"
        Me.CheckBoxAdv1.ThemesEnabled = False
        '
        'txbNote
        '
        Me.txbNote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txbNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbNote.BeforeTouchSize = New System.Drawing.Size(337, 27)
        Me.txbNote.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.txbNote.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.txbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbNote.CornerRadius = 5
        Me.txbNote.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txbNote.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNote.ForeColor = System.Drawing.Color.Gray
        Me.txbNote.Location = New System.Drawing.Point(53, 282)
        Me.txbNote.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txbNote.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txbNote.Multiline = True
        Me.txbNote.Name = "txbNote"
        Me.txbNote.NearImage = CType(resources.GetObject("txbNote.NearImage"), System.Drawing.Image)
        Me.txbNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txbNote.Size = New System.Drawing.Size(337, 82)
        Me.txbNote.TabIndex = 19
        Me.txbNote.Tag = "Note"
        Me.txbNote.Text = "Note"
        '
        'txbPaymentMethod
        '
        Me.txbPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txbPaymentMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbPaymentMethod.BeforeTouchSize = New System.Drawing.Size(337, 27)
        Me.txbPaymentMethod.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.txbPaymentMethod.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.txbPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbPaymentMethod.CornerRadius = 5
        Me.txbPaymentMethod.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txbPaymentMethod.FarImage = CType(resources.GetObject("txbPaymentMethod.FarImage"), System.Drawing.Image)
        Me.txbPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPaymentMethod.ForeColor = System.Drawing.Color.Gray
        Me.txbPaymentMethod.Location = New System.Drawing.Point(53, 234)
        Me.txbPaymentMethod.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txbPaymentMethod.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txbPaymentMethod.Name = "txbPaymentMethod"
        Me.txbPaymentMethod.NearImage = CType(resources.GetObject("txbPaymentMethod.NearImage"), System.Drawing.Image)
        Me.txbPaymentMethod.ReadOnly = True
        Me.txbPaymentMethod.Size = New System.Drawing.Size(337, 27)
        Me.txbPaymentMethod.TabIndex = 17
        Me.txbPaymentMethod.Tag = "Payment Method"
        Me.txbPaymentMethod.Text = "Payment Method"
        '
        'txbAmount
        '
        Me.txbAmount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txbAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbAmount.BeforeTouchSize = New System.Drawing.Size(337, 27)
        Me.txbAmount.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.txbAmount.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.txbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbAmount.CornerRadius = 5
        Me.txbAmount.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txbAmount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbAmount.ForeColor = System.Drawing.Color.Gray
        Me.txbAmount.Location = New System.Drawing.Point(53, 142)
        Me.txbAmount.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txbAmount.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txbAmount.Name = "txbAmount"
        Me.txbAmount.NearImage = CType(resources.GetObject("txbAmount.NearImage"), System.Drawing.Image)
        Me.txbAmount.Size = New System.Drawing.Size(337, 27)
        Me.txbAmount.TabIndex = 15
        Me.txbAmount.Tag = "Enter Amount"
        Me.txbAmount.Text = "Enter Amount"
        '
        'txbPerson
        '
        Me.txbPerson.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txbPerson.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbPerson.BeforeTouchSize = New System.Drawing.Size(337, 27)
        Me.txbPerson.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.txbPerson.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.txbPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbPerson.CornerRadius = 5
        Me.txbPerson.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txbPerson.FarImage = CType(resources.GetObject("txbPerson.FarImage"), System.Drawing.Image)
        Me.txbPerson.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPerson.ForeColor = System.Drawing.Color.Gray
        Me.txbPerson.Location = New System.Drawing.Point(53, 70)
        Me.txbPerson.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txbPerson.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txbPerson.Name = "txbPerson"
        Me.txbPerson.NearImage = CType(resources.GetObject("txbPerson.NearImage"), System.Drawing.Image)
        Me.txbPerson.Size = New System.Drawing.Size(337, 27)
        Me.txbPerson.TabIndex = 13
        Me.txbPerson.Tag = "Contributor"
        Me.txbPerson.Text = "Contributor"
        '
        'txbFund
        '
        Me.txbFund.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txbFund.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbFund.BeforeTouchSize = New System.Drawing.Size(337, 27)
        Me.txbFund.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.txbFund.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.txbFund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbFund.CornerRadius = 5
        Me.txbFund.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txbFund.FarImage = CType(resources.GetObject("txbFund.FarImage"), System.Drawing.Image)
        Me.txbFund.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFund.ForeColor = System.Drawing.Color.Gray
        Me.txbFund.Location = New System.Drawing.Point(53, 188)
        Me.txbFund.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txbFund.MinimumSize = New System.Drawing.Size(24, 20)
        Me.txbFund.Name = "txbFund"
        Me.txbFund.NearImage = CType(resources.GetObject("txbFund.NearImage"), System.Drawing.Image)
        Me.txbFund.Size = New System.Drawing.Size(337, 27)
        Me.txbFund.TabIndex = 16
        Me.txbFund.Tag = "Fund"
        Me.txbFund.Text = "Fund"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnSubmit)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(442, 49)
        Me.Panel3.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.AutoSize = False
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSubmit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSubmit.Image = Global.CMS.My.Resources.Resources.Save_Icon
        Me.btnSubmit.Location = New System.Drawing.Point(387, -1)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(54, 49)
        Me.btnSubmit.Style = Syncfusion.Windows.Forms.Tools.AutoLabelStyle.Office2016Black
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.ThemeName = "Office2016Black"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "New Contribution"
        '
        'pccDate
        '
        Me.pccDate.AutoSize = True
        Me.pccDate.Controls.Add(Me.MonthCalendarAdv1)
        Me.pccDate.Location = New System.Drawing.Point(53, 109)
        Me.pccDate.Name = "pccDate"
        Me.pccDate.Size = New System.Drawing.Size(264, 313)
        Me.pccDate.TabIndex = 21
        Me.pccDate.Visible = False
        '
        'MonthCalendarAdv1
        '
        Me.MonthCalendarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.MonthCalendarAdv1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.MonthCalendarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MonthCalendarAdv1.BottomHeight = 32
        Me.MonthCalendarAdv1.Culture = New System.Globalization.CultureInfo("")
        Me.MonthCalendarAdv1.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MonthCalendarAdv1.DayNamesFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendarAdv1.DaysColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonthCalendarAdv1.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer)))
        Me.MonthCalendarAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthCalendarAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MonthCalendarAdv1.GridBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MonthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
        Me.MonthCalendarAdv1.HeaderHeight = 34
        Me.MonthCalendarAdv1.HeaderStartColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MonthCalendarAdv1.HeadForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonthCalendarAdv1.HighlightColor = System.Drawing.Color.Black
        Me.MonthCalendarAdv1.InactiveMonthColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonthCalendarAdv1.Iso8601CalenderFormat = False
        Me.MonthCalendarAdv1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendarAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MonthCalendarAdv1.Name = "MonthCalendarAdv1"
        Me.MonthCalendarAdv1.NoneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MonthCalendarAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Silver
        Me.MonthCalendarAdv1.Office2010Theme = Syncfusion.Windows.Forms.Office2010Theme.Black
        Me.MonthCalendarAdv1.ScrollButtonSize = New System.Drawing.Size(24, 24)
        Me.MonthCalendarAdv1.Size = New System.Drawing.Size(264, 313)
        Me.MonthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black
        Me.MonthCalendarAdv1.TabIndex = 20
        Me.MonthCalendarAdv1.TodayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MonthCalendarAdv1.UseShortestDayNames = False
        Me.MonthCalendarAdv1.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        '
        '
        '
        Me.MonthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.MonthCalendarAdv1.NoneButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MonthCalendarAdv1.NoneButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.MonthCalendarAdv1.NoneButton.Dock = System.Windows.Forms.DockStyle.None
        Me.MonthCalendarAdv1.NoneButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonthCalendarAdv1.NoneButton.IsBackStageButton = False
        Me.MonthCalendarAdv1.NoneButton.KeepFocusRectangle = False
        Me.MonthCalendarAdv1.NoneButton.Location = New System.Drawing.Point(107, 0)
        Me.MonthCalendarAdv1.NoneButton.MetroColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MonthCalendarAdv1.NoneButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
        Me.MonthCalendarAdv1.NoneButton.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black
        Me.MonthCalendarAdv1.NoneButton.Size = New System.Drawing.Size(132, 20)
        Me.MonthCalendarAdv1.NoneButton.Text = "None"
        Me.MonthCalendarAdv1.NoneButton.ThemeName = "Metro"
        Me.MonthCalendarAdv1.NoneButton.UseVisualStyle = True
        Me.MonthCalendarAdv1.NoneButton.Visible = False
        '
        '
        '
        Me.MonthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.MonthCalendarAdv1.TodayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.MonthCalendarAdv1.TodayButton.BeforeTouchSize = New System.Drawing.Size(75, 23)
        Me.MonthCalendarAdv1.TodayButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None
        Me.MonthCalendarAdv1.TodayButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MonthCalendarAdv1.TodayButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonthCalendarAdv1.TodayButton.IsBackStageButton = False
        Me.MonthCalendarAdv1.TodayButton.KeepFocusRectangle = False
        Me.MonthCalendarAdv1.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendarAdv1.TodayButton.MetroColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MonthCalendarAdv1.TodayButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
        Me.MonthCalendarAdv1.TodayButton.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black
        Me.MonthCalendarAdv1.TodayButton.Size = New System.Drawing.Size(264, 30)
        Me.MonthCalendarAdv1.TodayButton.Text = "Today"
        Me.MonthCalendarAdv1.TodayButton.ThemeName = "Metro"
        Me.MonthCalendarAdv1.TodayButton.UseVisualStyle = True
        '
        'btnMenuOverview
        '
        Me.btnMenuOverview.AccessibleName = "Button"
        Me.btnMenuOverview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuOverview.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnMenuOverview.Location = New System.Drawing.Point(3, 48)
        Me.btnMenuOverview.Name = "btnMenuOverview"
        Me.btnMenuOverview.Size = New System.Drawing.Size(190, 45)
        Me.btnMenuOverview.Style.FocusedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuOverview.Style.FocusedForeColor = System.Drawing.Color.White
        Me.btnMenuOverview.Style.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuOverview.TabIndex = 1
        Me.btnMenuOverview.Tag = "1"
        Me.btnMenuOverview.Text = "Overvieww"
        '
        'btnMenuNewContribution
        '
        Me.btnMenuNewContribution.AccessibleName = "Button"
        Me.btnMenuNewContribution.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuNewContribution.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnMenuNewContribution.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnMenuNewContribution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnMenuNewContribution.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnMenuNewContribution.Location = New System.Drawing.Point(3, 3)
        Me.btnMenuNewContribution.Name = "btnMenuNewContribution"
        Me.btnMenuNewContribution.Size = New System.Drawing.Size(190, 45)
        Me.btnMenuNewContribution.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnMenuNewContribution.Style.FocusedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuNewContribution.Style.FocusedForeColor = System.Drawing.Color.White
        Me.btnMenuNewContribution.Style.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnMenuNewContribution.Style.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuNewContribution.TabIndex = 0
        Me.btnMenuNewContribution.Tag = "0"
        Me.btnMenuNewContribution.Text = "New Contribution"
        Me.btnMenuNewContribution.UseVisualStyleBackColor = False
        '
        'btnMenuReport
        '
        Me.btnMenuReport.AccessibleName = "Button"
        Me.btnMenuReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuReport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnMenuReport.Location = New System.Drawing.Point(3, 138)
        Me.btnMenuReport.Name = "btnMenuReport"
        Me.btnMenuReport.Size = New System.Drawing.Size(190, 45)
        Me.btnMenuReport.Style.FocusedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuReport.Style.FocusedForeColor = System.Drawing.Color.White
        Me.btnMenuReport.Style.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuReport.TabIndex = 3
        Me.btnMenuReport.Tag = "3"
        Me.btnMenuReport.Text = "Reportt"
        '
        'btnMenuFunds
        '
        Me.btnMenuFunds.AccessibleName = "Button"
        Me.btnMenuFunds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuFunds.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnMenuFunds.Location = New System.Drawing.Point(3, 93)
        Me.btnMenuFunds.Name = "btnMenuFunds"
        Me.btnMenuFunds.Size = New System.Drawing.Size(190, 45)
        Me.btnMenuFunds.Style.FocusedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuFunds.Style.FocusedForeColor = System.Drawing.Color.White
        Me.btnMenuFunds.Style.PressedBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnMenuFunds.TabIndex = 2
        Me.btnMenuFunds.Tag = "2"
        Me.btnMenuFunds.Text = "Funds"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMenuReport)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMenuFunds)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMenuOverview)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMenuNewContribution)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(692, 497)
        Me.SplitContainer1.SplitterDistance = 198
        Me.SplitContainer1.TabIndex = 1
        '
        'Contributions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Contributions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabOverview.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFunds.ResumeLayout(False)
        Me.tabFunds.PerformLayout()
        Me.tabReport.ResumeLayout(False)
        Me.tabReport.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabContribution.ResumeLayout(False)
        Me.tabContribution.PerformLayout()
        Me.PopupControlContainer1.ResumeLayout(False)
        Me.pnlNewContribution.ResumeLayout(False)
        Me.pnlNewContribution.PerformLayout()
        CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbPaymentMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbFund, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pccDate.ResumeLayout(False)
        CType(Me.MonthCalendarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents tabOverview As TabPage
    Friend WithEvents tabFunds As TabPage
    Friend WithEvents tabReport As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabContribution As TabPage
    Friend WithEvents btnMenuOverview As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnMenuNewContribution As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnMenuReport As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents btnMenuFunds As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PopupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents pccDate As Syncfusion.Windows.Forms.PopupControlContainer
    Friend WithEvents MonthCalendarAdv1 As Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
    Friend WithEvents pnlNewContribution As Panel
    Friend WithEvents txbNote As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txbPaymentMethod As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txbAmount As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txbPerson As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents txbFund As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Friend WithEvents btnSubmit As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents lblSorry2 As Label
    Friend WithEvents lblSorry3 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
