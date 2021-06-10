﻿Imports System.IO

Public Class Form_Main
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Try
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'fill datatables from dataset
            Me.Transaction_ListTableAdapter.Fill(Me.DatabaseDataSet.Transaction_List)
            Me.TransactionsTableAdapter.Fill(Me.DatabaseDataSet.Transactions)
            Me.IncomeTableAdapter.Fill(Me.DatabaseDataSet.Income)
            Me.AccountsTableAdapter.Fill(Me.DatabaseDataSet.Accounts)

            'fill comboboxes with default current info
            ComboBox_MonthView_Month.SelectedIndex = Month(Now) - 1
            ComboBox_MonthView_Year.Text = Year(Now)

            'Auto Filter
            Button_MonthView_Filter.PerformClick()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            Me.Validate()
            Me.Transaction_ListBindingSource.EndEdit()
            Me.Transaction_ListTableAdapter.Update(Me.DatabaseDataSet)

            'refresh
            Call Button_MonthView_Refresh.PerformClick()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_Accounts_Save.Click
        Try
            Me.Validate()
            Me.AccountsBindingSource.EndEdit()
            Me.AccountsTableAdapter.Update(Me.DatabaseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AccountsBindingSource.EndEdit()
        Me.AccountsTableAdapter.Update(Me.DatabaseDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.IncomeBindingSource.EndEdit()
            Me.IncomeTableAdapter.Update(Me.DatabaseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_MonthView_Filter_Click(sender As Object, e As EventArgs) Handles Button_MonthView_Filter.Click
        Try
            Dim Month As String = ComboBox_MonthView_Month.Text
            Dim Year As String = ComboBox_MonthView_Year.Text
            Dim mCode As String = Month & Year



            Dim Filter As String = ""

            If ComboBox_MonthView_PaidStatus.Text = "All" Then Filter = "MonthID = '" & mCode & "'"
            If ComboBox_MonthView_PaidStatus.Text = "Paid" Then Filter = "MonthID = '" & mCode & "'" & " AND Status = 'Paid'"
            If ComboBox_MonthView_PaidStatus.Text = "Not Paid" Then Filter = "MonthID = '" & mCode & "'" & " AND Status = 'Not Paid'"


            Me.Transaction_ListTableAdapter.Fill(Me.DatabaseDataSet.Transaction_List)
            Transaction_ListBindingSource.Filter = Filter
            Transaction_ListDataGridView.DataSource = Nothing
            Transaction_ListDataGridView.DataSource = Transaction_ListBindingSource

            'refresh button click
            Button_MonthView_Refresh.PerformClick()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem.Click
        Try
            Me.Validate()

            Me.AccountsBindingSource.EndEdit()
            Me.IncomeBindingSource.EndEdit()
            Me.TransactionsBindingSource.EndEdit()
            Me.Transaction_ListBindingSource.EndEdit()

            Me.AccountsTableAdapter.Update(Me.DatabaseDataSet)
            Me.IncomeTableAdapter.Update(Me.DatabaseDataSet)
            Me.TransactionsTableAdapter.Update(Me.DatabaseDataSet)
            Me.Transaction_ListTableAdapter.Update(Me.DatabaseDataSet)

            MsgBox("Data Saved", vbOKOnly)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExportDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            'getting error: database file is in use so cannot be copied,

            Dim xfile As String = Application.StartupPath & "\database.mdf"
            Dim FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()

            Dim NewFolder As String = FolderBrowserDialog.ShowDialog()

            File.Copy(xfile, NewFolder & "\database.mdf")

            Debug.Print(xfile)
            Debug.Print(NewFolder & "\database.mdf")

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Button_MonthView_Refresh_Click(sender As Object, e As EventArgs) Handles Button_MonthView_Refresh.Click

        Dim MonthID As String = ComboBox_MonthView_Month.Text & ComboBox_MonthView_Year.Text

        On Error Resume Next

        'month income
        TextBox_MonthView_MonthIncome.Text = IncomeTableAdapter.Get_FiltersMonthID_NetPay(MonthID)

        'month total
        TextBox_MonthView_MonthTotal.Text = Transaction_ListTableAdapter.Get_MonthTotal(MonthID)

        'month paid
        TextBox_MonthView_MonthPaid.Text = Transaction_ListTableAdapter.Get_Paid_or_Unpaid(MonthID, "Paid")

        'month not paid
        TextBox_MonthView_MonthNotPaid.Text = Transaction_ListTableAdapter.Get_Paid_or_Unpaid(MonthID, "Not Paid")

        'main account funds
        TextBox_MonthView_MainAccountFunds.Text = AccountsTableAdapter.IncomeQuery_Get_MainAccountBalance

        'main account left
        TextBox_MonthView_MainAccountLeft.Text = TextBox_MonthView_MainAccountFunds.Text - TextBox_MonthView_MonthNotPaid.Text

    End Sub

    Private Sub Button_MonthView_AddTransaction_Click(sender As Object, e As EventArgs) Handles Button_MonthView_AddTransaction.Click
        Try
            Form_Add.Show()

        Catch ex As Exception

        End Try
    End Sub
End Class
