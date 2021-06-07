﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AccountLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim Account_TypeLabel As System.Windows.Forms.Label
        Dim Total_Credit_LimitLabel As System.Windows.Forms.Label
        Dim MonthIDLabel As System.Windows.Forms.Label
        Dim Pay_DateLabel As System.Windows.Forms.Label
        Dim Pay_PeriodLabel As System.Windows.Forms.Label
        Dim Tax_CodeLabel As System.Windows.Forms.Label
        Dim Basic_SalaryLabel As System.Windows.Forms.Label
        Dim Other_PayLabel As System.Windows.Forms.Label
        Dim PensionLabel As System.Windows.Forms.Label
        Dim TaxLabel As System.Windows.Forms.Label
        Dim NILabel As System.Windows.Forms.Label
        Dim Net_Pay_Label As System.Windows.Forms.Label
        Dim PredictedLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim SourceLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Day_of_PaymentLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabMonthView = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_MonthView_PaidStatus = New System.Windows.Forms.ComboBox()
        Me.ComboBox_MonthView_Month = New System.Windows.Forms.ComboBox()
        Me.Button_MonthView_Filter = New System.Windows.Forms.Button()
        Me.ComboBox_MonthView_Year = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Transaction_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.Transaction_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Money_Tool.DatabaseDataSet()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TabTransactions = New System.Windows.Forms.TabPage()
        Me.GroupBox_Transactions_Details = New System.Windows.Forms.GroupBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Day_of_PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox_Transactions = New System.Windows.Forms.GroupBox()
        Me.TransactionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabIncome = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IncomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.MonthIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PredictedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox_Income_Details = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SourceTextBox = New System.Windows.Forms.TextBox()
        Me.MonthIDTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.Pay_DateTextBox = New System.Windows.Forms.TextBox()
        Me.PredictedTextBox = New System.Windows.Forms.TextBox()
        Me.Pay_PeriodTextBox = New System.Windows.Forms.TextBox()
        Me.Net_Pay_TextBox = New System.Windows.Forms.TextBox()
        Me.Tax_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.NITextBox = New System.Windows.Forms.TextBox()
        Me.Basic_SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Other_PayTextBox = New System.Windows.Forms.TextBox()
        Me.PensionTextBox = New System.Windows.Forms.TextBox()
        Me.TabAccounts = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Accounts_Save = New System.Windows.Forms.Button()
        Me.Total_Credit_LimitTextBox = New System.Windows.Forms.TextBox()
        Me.Account_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.AccountTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.AccountsTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.AccountsTableAdapter()
        Me.TableAdapterManager = New Money_Tool.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.IncomeTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.IncomeTableAdapter()
        Me.TransactionsTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.TransactionsTableAdapter()
        Me.Transaction_ListTableAdapter = New Money_Tool.DatabaseDataSetTableAdapters.Transaction_ListTableAdapter()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        AccountLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        Account_TypeLabel = New System.Windows.Forms.Label()
        Total_Credit_LimitLabel = New System.Windows.Forms.Label()
        MonthIDLabel = New System.Windows.Forms.Label()
        Pay_DateLabel = New System.Windows.Forms.Label()
        Pay_PeriodLabel = New System.Windows.Forms.Label()
        Tax_CodeLabel = New System.Windows.Forms.Label()
        Basic_SalaryLabel = New System.Windows.Forms.Label()
        Other_PayLabel = New System.Windows.Forms.Label()
        PensionLabel = New System.Windows.Forms.Label()
        TaxLabel = New System.Windows.Forms.Label()
        NILabel = New System.Windows.Forms.Label()
        Net_Pay_Label = New System.Windows.Forms.Label()
        PredictedLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        SourceLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Day_of_PaymentLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabMonthView.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Transaction_ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTransactions.SuspendLayout()
        Me.GroupBox_Transactions_Details.SuspendLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Transactions.SuspendLayout()
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabIncome.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IncomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Income_Details.SuspendLayout()
        Me.TabAccounts.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountLabel
        '
        AccountLabel.AutoSize = True
        AccountLabel.Location = New System.Drawing.Point(6, 16)
        AccountLabel.Name = "AccountLabel"
        AccountLabel.Size = New System.Drawing.Size(50, 13)
        AccountLabel.TabIndex = 8
        AccountLabel.Text = "Account:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(6, 42)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(49, 13)
        BalanceLabel.TabIndex = 10
        BalanceLabel.Text = "Balance:"
        '
        'Account_TypeLabel
        '
        Account_TypeLabel.AutoSize = True
        Account_TypeLabel.Location = New System.Drawing.Point(6, 68)
        Account_TypeLabel.Name = "Account_TypeLabel"
        Account_TypeLabel.Size = New System.Drawing.Size(77, 13)
        Account_TypeLabel.TabIndex = 12
        Account_TypeLabel.Text = "Account Type:"
        '
        'Total_Credit_LimitLabel
        '
        Total_Credit_LimitLabel.AutoSize = True
        Total_Credit_LimitLabel.Location = New System.Drawing.Point(6, 94)
        Total_Credit_LimitLabel.Name = "Total_Credit_LimitLabel"
        Total_Credit_LimitLabel.Size = New System.Drawing.Size(88, 13)
        Total_Credit_LimitLabel.TabIndex = 14
        Total_Credit_LimitLabel.Text = "Total Credit Limit:"
        '
        'MonthIDLabel
        '
        MonthIDLabel.AutoSize = True
        MonthIDLabel.Location = New System.Drawing.Point(6, 16)
        MonthIDLabel.Name = "MonthIDLabel"
        MonthIDLabel.Size = New System.Drawing.Size(54, 13)
        MonthIDLabel.TabIndex = 9
        MonthIDLabel.Text = "Month ID:"
        '
        'Pay_DateLabel
        '
        Pay_DateLabel.AutoSize = True
        Pay_DateLabel.Location = New System.Drawing.Point(6, 42)
        Pay_DateLabel.Name = "Pay_DateLabel"
        Pay_DateLabel.Size = New System.Drawing.Size(54, 13)
        Pay_DateLabel.TabIndex = 11
        Pay_DateLabel.Text = "Pay Date:"
        '
        'Pay_PeriodLabel
        '
        Pay_PeriodLabel.AutoSize = True
        Pay_PeriodLabel.Location = New System.Drawing.Point(6, 68)
        Pay_PeriodLabel.Name = "Pay_PeriodLabel"
        Pay_PeriodLabel.Size = New System.Drawing.Size(61, 13)
        Pay_PeriodLabel.TabIndex = 13
        Pay_PeriodLabel.Text = "Pay Period:"
        '
        'Tax_CodeLabel
        '
        Tax_CodeLabel.AutoSize = True
        Tax_CodeLabel.Location = New System.Drawing.Point(6, 94)
        Tax_CodeLabel.Name = "Tax_CodeLabel"
        Tax_CodeLabel.Size = New System.Drawing.Size(56, 13)
        Tax_CodeLabel.TabIndex = 15
        Tax_CodeLabel.Text = "Tax Code:"
        '
        'Basic_SalaryLabel
        '
        Basic_SalaryLabel.AutoSize = True
        Basic_SalaryLabel.Location = New System.Drawing.Point(6, 120)
        Basic_SalaryLabel.Name = "Basic_SalaryLabel"
        Basic_SalaryLabel.Size = New System.Drawing.Size(68, 13)
        Basic_SalaryLabel.TabIndex = 17
        Basic_SalaryLabel.Text = "Basic Salary:"
        '
        'Other_PayLabel
        '
        Other_PayLabel.AutoSize = True
        Other_PayLabel.Location = New System.Drawing.Point(6, 146)
        Other_PayLabel.Name = "Other_PayLabel"
        Other_PayLabel.Size = New System.Drawing.Size(57, 13)
        Other_PayLabel.TabIndex = 19
        Other_PayLabel.Text = "Other Pay:"
        '
        'PensionLabel
        '
        PensionLabel.AutoSize = True
        PensionLabel.Location = New System.Drawing.Point(6, 172)
        PensionLabel.Name = "PensionLabel"
        PensionLabel.Size = New System.Drawing.Size(48, 13)
        PensionLabel.TabIndex = 21
        PensionLabel.Text = "Pension:"
        '
        'TaxLabel
        '
        TaxLabel.AutoSize = True
        TaxLabel.Location = New System.Drawing.Point(6, 198)
        TaxLabel.Name = "TaxLabel"
        TaxLabel.Size = New System.Drawing.Size(28, 13)
        TaxLabel.TabIndex = 23
        TaxLabel.Text = "Tax:"
        '
        'NILabel
        '
        NILabel.AutoSize = True
        NILabel.Location = New System.Drawing.Point(6, 224)
        NILabel.Name = "NILabel"
        NILabel.Size = New System.Drawing.Size(21, 13)
        NILabel.TabIndex = 25
        NILabel.Text = "NI:"
        '
        'Net_Pay_Label
        '
        Net_Pay_Label.AutoSize = True
        Net_Pay_Label.Location = New System.Drawing.Point(6, 250)
        Net_Pay_Label.Name = "Net_Pay_Label"
        Net_Pay_Label.Size = New System.Drawing.Size(51, 13)
        Net_Pay_Label.TabIndex = 27
        Net_Pay_Label.Text = "Net Pay :"
        '
        'PredictedLabel
        '
        PredictedLabel.AutoSize = True
        PredictedLabel.Location = New System.Drawing.Point(6, 276)
        PredictedLabel.Name = "PredictedLabel"
        PredictedLabel.Size = New System.Drawing.Size(55, 13)
        PredictedLabel.TabIndex = 29
        PredictedLabel.Text = "Predicted:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(6, 302)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(59, 13)
        CommentsLabel.TabIndex = 31
        CommentsLabel.Text = "Comments:"
        '
        'SourceLabel
        '
        SourceLabel.AutoSize = True
        SourceLabel.Location = New System.Drawing.Point(6, 328)
        SourceLabel.Name = "SourceLabel"
        SourceLabel.Size = New System.Drawing.Size(44, 13)
        SourceLabel.TabIndex = 33
        SourceLabel.Text = "Source:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 22)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 9
        NameLabel.Text = "Name:"
        '
        'Day_of_PaymentLabel
        '
        Day_of_PaymentLabel.AutoSize = True
        Day_of_PaymentLabel.Location = New System.Drawing.Point(6, 48)
        Day_of_PaymentLabel.Name = "Day_of_PaymentLabel"
        Day_of_PaymentLabel.Size = New System.Drawing.Size(85, 13)
        Day_of_PaymentLabel.TabIndex = 11
        Day_of_PaymentLabel.Text = "Day of Payment:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(6, 74)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 13
        DescriptionLabel.Text = "Description:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(6, 100)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 15
        CategoryLabel.Text = "Category:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(6, 126)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 17
        AmountLabel.Text = "Amount:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(6, 152)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 19
        TypeLabel.Text = "Type:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(6, 178)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 21
        StatusLabel.Text = "Status:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 8, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(846, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabMonthView)
        Me.TabControl1.Controls.Add(Me.TabTransactions)
        Me.TabControl1.Controls.Add(Me.TabIncome)
        Me.TabControl1.Controls.Add(Me.TabAccounts)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(846, 489)
        Me.TabControl1.TabIndex = 2
        '
        'TabMonthView
        '
        Me.TabMonthView.AutoScroll = True
        Me.TabMonthView.Controls.Add(Me.GroupBox6)
        Me.TabMonthView.Controls.Add(Me.GroupBox5)
        Me.TabMonthView.Controls.Add(Me.GroupBox4)
        Me.TabMonthView.Controls.Add(Me.ButtonSave)
        Me.TabMonthView.Location = New System.Drawing.Point(4, 22)
        Me.TabMonthView.Name = "TabMonthView"
        Me.TabMonthView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMonthView.Size = New System.Drawing.Size(838, 463)
        Me.TabMonthView.TabIndex = 0
        Me.TabMonthView.Text = "Month View"
        Me.TabMonthView.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.ComboBox_MonthView_PaidStatus)
        Me.GroupBox6.Controls.Add(Me.ComboBox_MonthView_Month)
        Me.GroupBox6.Controls.Add(Me.Button_MonthView_Filter)
        Me.GroupBox6.Controls.Add(Me.ComboBox_MonthView_Year)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(203, 130)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Month"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Year"
        '
        'ComboBox_MonthView_PaidStatus
        '
        Me.ComboBox_MonthView_PaidStatus.FormattingEnabled = True
        Me.ComboBox_MonthView_PaidStatus.Items.AddRange(New Object() {"All", "Paid", "Not Paid"})
        Me.ComboBox_MonthView_PaidStatus.Location = New System.Drawing.Point(74, 71)
        Me.ComboBox_MonthView_PaidStatus.Name = "ComboBox_MonthView_PaidStatus"
        Me.ComboBox_MonthView_PaidStatus.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_MonthView_PaidStatus.TabIndex = 0
        Me.ComboBox_MonthView_PaidStatus.Text = "All"
        '
        'ComboBox_MonthView_Month
        '
        Me.ComboBox_MonthView_Month.FormattingEnabled = True
        Me.ComboBox_MonthView_Month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox_MonthView_Month.Location = New System.Drawing.Point(74, 44)
        Me.ComboBox_MonthView_Month.Name = "ComboBox_MonthView_Month"
        Me.ComboBox_MonthView_Month.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_MonthView_Month.TabIndex = 0
        '
        'Button_MonthView_Filter
        '
        Me.Button_MonthView_Filter.Location = New System.Drawing.Point(120, 98)
        Me.Button_MonthView_Filter.Name = "Button_MonthView_Filter"
        Me.Button_MonthView_Filter.Size = New System.Drawing.Size(75, 23)
        Me.Button_MonthView_Filter.TabIndex = 5
        Me.Button_MonthView_Filter.Text = "Filter"
        Me.Button_MonthView_Filter.UseVisualStyleBackColor = True
        '
        'ComboBox_MonthView_Year
        '
        Me.ComboBox_MonthView_Year.FormattingEnabled = True
        Me.ComboBox_MonthView_Year.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031"})
        Me.ComboBox_MonthView_Year.Location = New System.Drawing.Point(74, 17)
        Me.ComboBox_MonthView_Year.Name = "ComboBox_MonthView_Year"
        Me.ComboBox_MonthView_Year.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_MonthView_Year.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(215, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(615, 130)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Details"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Transaction_ListDataGridView)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(824, 286)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data"
        '
        'Transaction_ListDataGridView
        '
        Me.Transaction_ListDataGridView.AutoGenerateColumns = False
        Me.Transaction_ListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Transaction_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Transaction_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.Transaction_ListDataGridView.DataSource = Me.Transaction_ListBindingSource
        Me.Transaction_ListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Transaction_ListDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.Transaction_ListDataGridView.Name = "Transaction_ListDataGridView"
        Me.Transaction_ListDataGridView.Size = New System.Drawing.Size(818, 267)
        Me.Transaction_ListDataGridView.TabIndex = 0
        '
        'Transaction_ListBindingSource
        '
        Me.Transaction_ListBindingSource.DataMember = "Transaction List"
        Me.Transaction_ListBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(755, 434)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'TabTransactions
        '
        Me.TabTransactions.AutoScroll = True
        Me.TabTransactions.Controls.Add(Me.GroupBox_Transactions_Details)
        Me.TabTransactions.Controls.Add(Me.GroupBox_Transactions)
        Me.TabTransactions.Location = New System.Drawing.Point(4, 22)
        Me.TabTransactions.Name = "TabTransactions"
        Me.TabTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTransactions.Size = New System.Drawing.Size(838, 463)
        Me.TabTransactions.TabIndex = 1
        Me.TabTransactions.Text = "Transactions"
        Me.TabTransactions.UseVisualStyleBackColor = True
        '
        'GroupBox_Transactions_Details
        '
        Me.GroupBox_Transactions_Details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.StatusTextBox)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.Button1)
        Me.GroupBox_Transactions_Details.Controls.Add(StatusLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.TypeTextBox)
        Me.GroupBox_Transactions_Details.Controls.Add(NameLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(TypeLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.NameTextBox)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.AmountTextBox)
        Me.GroupBox_Transactions_Details.Controls.Add(Day_of_PaymentLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(AmountLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.Day_of_PaymentTextBox)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.CategoryTextBox)
        Me.GroupBox_Transactions_Details.Controls.Add(DescriptionLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(CategoryLabel)
        Me.GroupBox_Transactions_Details.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox_Transactions_Details.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox_Transactions_Details.Name = "GroupBox_Transactions_Details"
        Me.GroupBox_Transactions_Details.Size = New System.Drawing.Size(234, 451)
        Me.GroupBox_Transactions_Details.TabIndex = 24
        Me.GroupBox_Transactions_Details.TabStop = False
        Me.GroupBox_Transactions_Details.Text = "Details"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(97, 175)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(131, 20)
        Me.StatusTextBox.TabIndex = 22
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(153, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(97, 149)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(131, 20)
        Me.TypeTextBox.TabIndex = 20
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(97, 19)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.NameTextBox.TabIndex = 10
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(97, 123)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(131, 20)
        Me.AmountTextBox.TabIndex = 18
        '
        'Day_of_PaymentTextBox
        '
        Me.Day_of_PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Day of Payment", True))
        Me.Day_of_PaymentTextBox.Location = New System.Drawing.Point(97, 45)
        Me.Day_of_PaymentTextBox.Name = "Day_of_PaymentTextBox"
        Me.Day_of_PaymentTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Day_of_PaymentTextBox.TabIndex = 12
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(97, 97)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(131, 20)
        Me.CategoryTextBox.TabIndex = 16
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(97, 71)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(131, 20)
        Me.DescriptionTextBox.TabIndex = 14
        '
        'GroupBox_Transactions
        '
        Me.GroupBox_Transactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Transactions.Controls.Add(Me.TransactionsDataGridView)
        Me.GroupBox_Transactions.Location = New System.Drawing.Point(246, 6)
        Me.GroupBox_Transactions.Name = "GroupBox_Transactions"
        Me.GroupBox_Transactions.Size = New System.Drawing.Size(589, 451)
        Me.GroupBox_Transactions.TabIndex = 23
        Me.GroupBox_Transactions.TabStop = False
        Me.GroupBox_Transactions.Text = "Data"
        '
        'TransactionsDataGridView
        '
        Me.TransactionsDataGridView.AutoGenerateColumns = False
        Me.TransactionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.TransactionsDataGridView.DataSource = Me.TransactionsBindingSource
        Me.TransactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionsDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.TransactionsDataGridView.Name = "TransactionsDataGridView"
        Me.TransactionsDataGridView.Size = New System.Drawing.Size(583, 432)
        Me.TransactionsDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Day of Payment"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Day of Payment"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 98
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 85
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 74
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 68
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 56
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 62
        '
        'TabIncome
        '
        Me.TabIncome.AutoScroll = True
        Me.TabIncome.Controls.Add(Me.GroupBox2)
        Me.TabIncome.Controls.Add(Me.GroupBox_Income_Details)
        Me.TabIncome.Location = New System.Drawing.Point(4, 22)
        Me.TabIncome.Name = "TabIncome"
        Me.TabIncome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIncome.Size = New System.Drawing.Size(838, 463)
        Me.TabIncome.TabIndex = 4
        Me.TabIncome.Text = "Income"
        Me.TabIncome.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.IncomeDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 451)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'IncomeDataGridView
        '
        Me.IncomeDataGridView.AutoGenerateColumns = False
        Me.IncomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.IncomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncomeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonthIDDataGridViewTextBoxColumn, Me.PayDateDataGridViewTextBoxColumn, Me.PayPeriodDataGridViewTextBoxColumn, Me.TaxCodeDataGridViewTextBoxColumn, Me.BasicSalaryDataGridViewTextBoxColumn, Me.OtherPayDataGridViewTextBoxColumn, Me.PensionDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.NIDataGridViewTextBoxColumn, Me.NetPayDataGridViewTextBoxColumn, Me.PredictedDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn})
        Me.IncomeDataGridView.DataSource = Me.IncomeBindingSource
        Me.IncomeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IncomeDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.IncomeDataGridView.Name = "IncomeDataGridView"
        Me.IncomeDataGridView.Size = New System.Drawing.Size(578, 432)
        Me.IncomeDataGridView.TabIndex = 34
        '
        'MonthIDDataGridViewTextBoxColumn
        '
        Me.MonthIDDataGridViewTextBoxColumn.DataPropertyName = "MonthID"
        Me.MonthIDDataGridViewTextBoxColumn.HeaderText = "MonthID"
        Me.MonthIDDataGridViewTextBoxColumn.Name = "MonthIDDataGridViewTextBoxColumn"
        Me.MonthIDDataGridViewTextBoxColumn.Width = 73
        '
        'PayDateDataGridViewTextBoxColumn
        '
        Me.PayDateDataGridViewTextBoxColumn.DataPropertyName = "Pay Date"
        Me.PayDateDataGridViewTextBoxColumn.HeaderText = "Pay Date"
        Me.PayDateDataGridViewTextBoxColumn.Name = "PayDateDataGridViewTextBoxColumn"
        Me.PayDateDataGridViewTextBoxColumn.Width = 76
        '
        'PayPeriodDataGridViewTextBoxColumn
        '
        Me.PayPeriodDataGridViewTextBoxColumn.DataPropertyName = "Pay Period"
        Me.PayPeriodDataGridViewTextBoxColumn.HeaderText = "Pay Period"
        Me.PayPeriodDataGridViewTextBoxColumn.Name = "PayPeriodDataGridViewTextBoxColumn"
        Me.PayPeriodDataGridViewTextBoxColumn.Width = 83
        '
        'TaxCodeDataGridViewTextBoxColumn
        '
        Me.TaxCodeDataGridViewTextBoxColumn.DataPropertyName = "Tax Code"
        Me.TaxCodeDataGridViewTextBoxColumn.HeaderText = "Tax Code"
        Me.TaxCodeDataGridViewTextBoxColumn.Name = "TaxCodeDataGridViewTextBoxColumn"
        Me.TaxCodeDataGridViewTextBoxColumn.Width = 78
        '
        'BasicSalaryDataGridViewTextBoxColumn
        '
        Me.BasicSalaryDataGridViewTextBoxColumn.DataPropertyName = "Basic Salary"
        Me.BasicSalaryDataGridViewTextBoxColumn.HeaderText = "Basic Salary"
        Me.BasicSalaryDataGridViewTextBoxColumn.Name = "BasicSalaryDataGridViewTextBoxColumn"
        Me.BasicSalaryDataGridViewTextBoxColumn.Width = 90
        '
        'OtherPayDataGridViewTextBoxColumn
        '
        Me.OtherPayDataGridViewTextBoxColumn.DataPropertyName = "Other Pay"
        Me.OtherPayDataGridViewTextBoxColumn.HeaderText = "Other Pay"
        Me.OtherPayDataGridViewTextBoxColumn.Name = "OtherPayDataGridViewTextBoxColumn"
        Me.OtherPayDataGridViewTextBoxColumn.Width = 79
        '
        'PensionDataGridViewTextBoxColumn
        '
        Me.PensionDataGridViewTextBoxColumn.DataPropertyName = "Pension"
        Me.PensionDataGridViewTextBoxColumn.HeaderText = "Pension"
        Me.PensionDataGridViewTextBoxColumn.Name = "PensionDataGridViewTextBoxColumn"
        Me.PensionDataGridViewTextBoxColumn.Width = 70
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "Tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "Tax"
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        Me.TaxDataGridViewTextBoxColumn.Width = 50
        '
        'NIDataGridViewTextBoxColumn
        '
        Me.NIDataGridViewTextBoxColumn.DataPropertyName = "NI"
        Me.NIDataGridViewTextBoxColumn.HeaderText = "NI"
        Me.NIDataGridViewTextBoxColumn.Name = "NIDataGridViewTextBoxColumn"
        Me.NIDataGridViewTextBoxColumn.Width = 43
        '
        'NetPayDataGridViewTextBoxColumn
        '
        Me.NetPayDataGridViewTextBoxColumn.DataPropertyName = "Net Pay "
        Me.NetPayDataGridViewTextBoxColumn.HeaderText = "Net Pay "
        Me.NetPayDataGridViewTextBoxColumn.Name = "NetPayDataGridViewTextBoxColumn"
        Me.NetPayDataGridViewTextBoxColumn.Width = 73
        '
        'PredictedDataGridViewTextBoxColumn
        '
        Me.PredictedDataGridViewTextBoxColumn.DataPropertyName = "Predicted"
        Me.PredictedDataGridViewTextBoxColumn.HeaderText = "Predicted"
        Me.PredictedDataGridViewTextBoxColumn.Name = "PredictedDataGridViewTextBoxColumn"
        Me.PredictedDataGridViewTextBoxColumn.Width = 77
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.Width = 81
        '
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        Me.SourceDataGridViewTextBoxColumn.Width = 66
        '
        'IncomeBindingSource
        '
        Me.IncomeBindingSource.DataMember = "Income"
        Me.IncomeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'GroupBox_Income_Details
        '
        Me.GroupBox_Income_Details.Controls.Add(MonthIDLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.Button2)
        Me.GroupBox_Income_Details.Controls.Add(Me.SourceTextBox)
        Me.GroupBox_Income_Details.Controls.Add(Me.MonthIDTextBox)
        Me.GroupBox_Income_Details.Controls.Add(SourceLabel)
        Me.GroupBox_Income_Details.Controls.Add(Pay_DateLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.CommentsTextBox)
        Me.GroupBox_Income_Details.Controls.Add(Me.Pay_DateTextBox)
        Me.GroupBox_Income_Details.Controls.Add(CommentsLabel)
        Me.GroupBox_Income_Details.Controls.Add(Pay_PeriodLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.PredictedTextBox)
        Me.GroupBox_Income_Details.Controls.Add(Me.Pay_PeriodTextBox)
        Me.GroupBox_Income_Details.Controls.Add(PredictedLabel)
        Me.GroupBox_Income_Details.Controls.Add(Tax_CodeLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.Net_Pay_TextBox)
        Me.GroupBox_Income_Details.Controls.Add(Me.Tax_CodeTextBox)
        Me.GroupBox_Income_Details.Controls.Add(Net_Pay_Label)
        Me.GroupBox_Income_Details.Controls.Add(Basic_SalaryLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.NITextBox)
        Me.GroupBox_Income_Details.Controls.Add(Me.Basic_SalaryTextBox)
        Me.GroupBox_Income_Details.Controls.Add(NILabel)
        Me.GroupBox_Income_Details.Controls.Add(Other_PayLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.TaxTextBox)
        Me.GroupBox_Income_Details.Controls.Add(Me.Other_PayTextBox)
        Me.GroupBox_Income_Details.Controls.Add(TaxLabel)
        Me.GroupBox_Income_Details.Controls.Add(PensionLabel)
        Me.GroupBox_Income_Details.Controls.Add(Me.PensionTextBox)
        Me.GroupBox_Income_Details.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox_Income_Details.Name = "GroupBox_Income_Details"
        Me.GroupBox_Income_Details.Size = New System.Drawing.Size(234, 451)
        Me.GroupBox_Income_Details.TabIndex = 35
        Me.GroupBox_Income_Details.TabStop = False
        Me.GroupBox_Income_Details.Text = "Details"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SourceTextBox
        '
        Me.SourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Source", True))
        Me.SourceTextBox.Location = New System.Drawing.Point(80, 325)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(148, 20)
        Me.SourceTextBox.TabIndex = 34
        '
        'MonthIDTextBox
        '
        Me.MonthIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "MonthID", True))
        Me.MonthIDTextBox.Location = New System.Drawing.Point(80, 13)
        Me.MonthIDTextBox.Name = "MonthIDTextBox"
        Me.MonthIDTextBox.Size = New System.Drawing.Size(148, 20)
        Me.MonthIDTextBox.TabIndex = 10
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(80, 299)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(148, 20)
        Me.CommentsTextBox.TabIndex = 32
        '
        'Pay_DateTextBox
        '
        Me.Pay_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Pay Date", True))
        Me.Pay_DateTextBox.Location = New System.Drawing.Point(80, 39)
        Me.Pay_DateTextBox.Name = "Pay_DateTextBox"
        Me.Pay_DateTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Pay_DateTextBox.TabIndex = 12
        '
        'PredictedTextBox
        '
        Me.PredictedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Predicted", True))
        Me.PredictedTextBox.Location = New System.Drawing.Point(80, 273)
        Me.PredictedTextBox.Name = "PredictedTextBox"
        Me.PredictedTextBox.Size = New System.Drawing.Size(148, 20)
        Me.PredictedTextBox.TabIndex = 30
        '
        'Pay_PeriodTextBox
        '
        Me.Pay_PeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Pay Period", True))
        Me.Pay_PeriodTextBox.Location = New System.Drawing.Point(80, 65)
        Me.Pay_PeriodTextBox.Name = "Pay_PeriodTextBox"
        Me.Pay_PeriodTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Pay_PeriodTextBox.TabIndex = 14
        '
        'Net_Pay_TextBox
        '
        Me.Net_Pay_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Net Pay ", True))
        Me.Net_Pay_TextBox.Location = New System.Drawing.Point(80, 247)
        Me.Net_Pay_TextBox.Name = "Net_Pay_TextBox"
        Me.Net_Pay_TextBox.Size = New System.Drawing.Size(148, 20)
        Me.Net_Pay_TextBox.TabIndex = 28
        '
        'Tax_CodeTextBox
        '
        Me.Tax_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Tax Code", True))
        Me.Tax_CodeTextBox.Location = New System.Drawing.Point(80, 91)
        Me.Tax_CodeTextBox.Name = "Tax_CodeTextBox"
        Me.Tax_CodeTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Tax_CodeTextBox.TabIndex = 16
        '
        'NITextBox
        '
        Me.NITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "NI", True))
        Me.NITextBox.Location = New System.Drawing.Point(80, 221)
        Me.NITextBox.Name = "NITextBox"
        Me.NITextBox.Size = New System.Drawing.Size(148, 20)
        Me.NITextBox.TabIndex = 26
        '
        'Basic_SalaryTextBox
        '
        Me.Basic_SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Basic Salary", True))
        Me.Basic_SalaryTextBox.Location = New System.Drawing.Point(80, 117)
        Me.Basic_SalaryTextBox.Name = "Basic_SalaryTextBox"
        Me.Basic_SalaryTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Basic_SalaryTextBox.TabIndex = 18
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Tax", True))
        Me.TaxTextBox.Location = New System.Drawing.Point(80, 195)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(148, 20)
        Me.TaxTextBox.TabIndex = 24
        '
        'Other_PayTextBox
        '
        Me.Other_PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Other Pay", True))
        Me.Other_PayTextBox.Location = New System.Drawing.Point(80, 143)
        Me.Other_PayTextBox.Name = "Other_PayTextBox"
        Me.Other_PayTextBox.Size = New System.Drawing.Size(148, 20)
        Me.Other_PayTextBox.TabIndex = 20
        '
        'PensionTextBox
        '
        Me.PensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeBindingSource, "Pension", True))
        Me.PensionTextBox.Location = New System.Drawing.Point(80, 169)
        Me.PensionTextBox.Name = "PensionTextBox"
        Me.PensionTextBox.Size = New System.Drawing.Size(148, 20)
        Me.PensionTextBox.TabIndex = 22
        '
        'TabAccounts
        '
        Me.TabAccounts.AutoScroll = True
        Me.TabAccounts.Controls.Add(Me.GroupBox3)
        Me.TabAccounts.Controls.Add(Me.GroupBox1)
        Me.TabAccounts.Location = New System.Drawing.Point(4, 22)
        Me.TabAccounts.Name = "TabAccounts"
        Me.TabAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAccounts.Size = New System.Drawing.Size(838, 463)
        Me.TabAccounts.TabIndex = 5
        Me.TabAccounts.Text = "Accounts"
        Me.TabAccounts.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.AccountsDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(246, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(584, 451)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data"
        '
        'AccountsDataGridView
        '
        Me.AccountsDataGridView.AutoGenerateColumns = False
        Me.AccountsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.AccountsDataGridView.DataSource = Me.AccountsBindingSource
        Me.AccountsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountsDataGridView.Location = New System.Drawing.Point(3, 16)
        Me.AccountsDataGridView.Name = "AccountsDataGridView"
        Me.AccountsDataGridView.Size = New System.Drawing.Size(578, 432)
        Me.AccountsDataGridView.TabIndex = 6
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.DatabaseDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Accounts_Save)
        Me.GroupBox1.Controls.Add(Me.Total_Credit_LimitTextBox)
        Me.GroupBox1.Controls.Add(Total_Credit_LimitLabel)
        Me.GroupBox1.Controls.Add(AccountLabel)
        Me.GroupBox1.Controls.Add(Me.Account_TypeTextBox)
        Me.GroupBox1.Controls.Add(Me.AccountTextBox)
        Me.GroupBox1.Controls.Add(Account_TypeLabel)
        Me.GroupBox1.Controls.Add(BalanceLabel)
        Me.GroupBox1.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 451)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Button_Accounts_Save
        '
        Me.Button_Accounts_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Accounts_Save.Location = New System.Drawing.Point(153, 422)
        Me.Button_Accounts_Save.Name = "Button_Accounts_Save"
        Me.Button_Accounts_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Accounts_Save.TabIndex = 6
        Me.Button_Accounts_Save.Text = "Save"
        Me.Button_Accounts_Save.UseVisualStyleBackColor = True
        '
        'Total_Credit_LimitTextBox
        '
        Me.Total_Credit_LimitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "Total Credit Limit", True))
        Me.Total_Credit_LimitTextBox.Location = New System.Drawing.Point(100, 91)
        Me.Total_Credit_LimitTextBox.Name = "Total_Credit_LimitTextBox"
        Me.Total_Credit_LimitTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Total_Credit_LimitTextBox.TabIndex = 15
        '
        'Account_TypeTextBox
        '
        Me.Account_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "Account Type", True))
        Me.Account_TypeTextBox.Location = New System.Drawing.Point(100, 65)
        Me.Account_TypeTextBox.Name = "Account_TypeTextBox"
        Me.Account_TypeTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Account_TypeTextBox.TabIndex = 13
        '
        'AccountTextBox
        '
        Me.AccountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "Account", True))
        Me.AccountTextBox.Location = New System.Drawing.Point(100, 13)
        Me.AccountTextBox.Name = "AccountTextBox"
        Me.AccountTextBox.Size = New System.Drawing.Size(128, 20)
        Me.AccountTextBox.TabIndex = 9
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(100, 39)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(128, 20)
        Me.BalanceTextBox.TabIndex = 11
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Me.AccountsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IncomeTableAdapter = Me.IncomeTableAdapter
        Me.TableAdapterManager.Transaction_ListTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Money_Tool.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'IncomeTableAdapter
        '
        Me.IncomeTableAdapter.ClearBeforeFill = True
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Transaction_ListTableAdapter
        '
        Me.Transaction_ListTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 60
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 68
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn16.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn16.Items.AddRange(New Object() {"Paid", "Not Paid"})
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.Width = 62
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 81
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "MonthID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "MonthID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Account"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Account"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Balance"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 71
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Account Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Account Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 99
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total Credit Limit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Credit Limit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Main Account Funds"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Month Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Month Paid"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Month Not Paid"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Month Income"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Main Account Left"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 535)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Main"
        Me.Text = "Money Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabMonthView.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Transaction_ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTransactions.ResumeLayout(False)
        Me.GroupBox_Transactions_Details.ResumeLayout(False)
        Me.GroupBox_Transactions_Details.PerformLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Transactions.ResumeLayout(False)
        CType(Me.TransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabIncome.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.IncomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Income_Details.ResumeLayout(False)
        Me.GroupBox_Income_Details.PerformLayout()
        Me.TabAccounts.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabMonthView As TabPage
    Friend WithEvents TabTransactions As TabPage
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TabIncome As TabPage
    Friend WithEvents TabAccounts As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button_Accounts_Save As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents AccountsTableAdapter As DatabaseDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountsDataGridView As DataGridView
    Friend WithEvents AccountTextBox As TextBox
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents Account_TypeTextBox As TextBox
    Friend WithEvents Total_Credit_LimitTextBox As TextBox
    Friend WithEvents IncomeTableAdapter As DatabaseDataSetTableAdapters.IncomeTableAdapter
    Friend WithEvents IncomeDataGridView As DataGridView
    Friend WithEvents MonthIDTextBox As TextBox
    Friend WithEvents Pay_DateTextBox As TextBox
    Friend WithEvents Pay_PeriodTextBox As TextBox
    Friend WithEvents Tax_CodeTextBox As TextBox
    Friend WithEvents Basic_SalaryTextBox As TextBox
    Friend WithEvents Other_PayTextBox As TextBox
    Friend WithEvents PensionTextBox As TextBox
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents NITextBox As TextBox
    Friend WithEvents Net_Pay_TextBox As TextBox
    Friend WithEvents PredictedTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents SourceTextBox As TextBox
    Friend WithEvents IncomeBindingSource As BindingSource
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As DatabaseDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents TransactionsDataGridView As DataGridView
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Day_of_PaymentTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents GroupBox_Transactions_Details As GroupBox
    Friend WithEvents GroupBox_Transactions As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MonthIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayPeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PensionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PredictedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox_Income_Details As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Transaction_ListBindingSource As BindingSource
    Friend WithEvents Transaction_ListTableAdapter As DatabaseDataSetTableAdapters.Transaction_ListTableAdapter
    Friend WithEvents Transaction_ListDataGridView As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_MonthView_PaidStatus As ComboBox
    Friend WithEvents ComboBox_MonthView_Month As ComboBox
    Friend WithEvents Button_MonthView_Filter As Button
    Friend WithEvents ComboBox_MonthView_Year As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
