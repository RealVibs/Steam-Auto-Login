Imports System.IO
Imports System.Diagnostics

Public Class SteamLogin
    '=================Set Main Account Array======
    Dim MainAccounts() As String = {"MainAccount1", "MainAccount2"} 'List of account names
    '=============================================

    '=================Set Alt Account Array=======
    Dim AltAccounts() As String = {"AltAccount1", "AltAccount2"} 'List of account names
    '=============================================

    '=================Set Vault Account Array=====
    Dim vaultAccounts() As String = {"VaultAccount1", "VaultAccount2"} 'List of account names
    '=============================================

    '=================Set Others Account Array====
    Dim OtherAccounts() As String = {"OtherAccount1", "OtherAccount2"} 'List of account names
    '=============================================

    '=================Set Steam Process===========
    Dim steamprocess() As Process = Process.GetProcessesByName("steam")
    '=============================================

    Private Sub SteamLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '=================Kill Steam If Open==========
        If steamprocess.Count > 0 Then
            steamprocess(0).Kill()
        End If
        '=============================================
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        '=================Get Chosen Account==========
        Dim AccountPicked As String

        If LbAccounts.SelectedItems.Count = 0 Then
            '=================Defining MsgBox=============
            Dim Msg, Style, Title, Response
            Msg = "You did not select an account." ' Define message.
            Style = vbOKOnly + vbCritical          ' Define buttons.
            Title = "Account Not Selected"         ' Define title.
            Response = MsgBox(Msg, Style, Title)   ' Display MsgBox
            '=============================================
            Exit Sub
        End If
        For i = 0 To (LbAccounts.Items.Count - 1)
            If LbAccounts.GetSelected(i) Then
                AccountPicked = LbAccounts.Items.Item(i)
            End If
        Next i
        '=============================================

        '=================Set/Get Account=============
        My.Computer.Registry.CurrentUser.CreateSubKey("AutoLoginUser")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Valve\Steam", "AutoLoginUser", AccountPicked)

        My.Computer.Registry.CurrentUser.CreateSubKey("RememberPassword")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Valve\Steam", "RememberPassword", 1)
        '=============================================

        '=================Start Steam=================
        Process.Start("steam://open/main")
        '=============================================

        '=================Close Program===============
        Me.Close()
        '=============================================
    End Sub

    Private Sub RbLabels_CheckedChanged(sender As Object, e As EventArgs) Handles RbMains.CheckedChanged
        '=================Reset Accounts List=========
        LbAccounts.Items.Clear()
        '=============================================

        '=================List Accounts===============
        For a As Integer = 0 To MainAccounts.IsFixedSize + MainAccounts.Count
            LbAccounts.Items.Add(MainAccounts(a))
        Next
        '=============================================
    End Sub

    Private Sub RbAlts_CheckedChanged(sender As Object, e As EventArgs) Handles RbAlts.CheckedChanged
        '=================Reset Accounts List=========
        LbAccounts.Items.Clear()
        '=============================================

        '=================List Accounts===============
        For a As Integer = 0 To AltAccounts.IsFixedSize + AltAccounts.Count
            LbAccounts.Items.Add(AltAccounts(a))
        Next
        '=============================================
    End Sub

    Private Sub RbVault_CheckedChanged(sender As Object, e As EventArgs) Handles RbVault.CheckedChanged
        '=================Reset Accounts List=========
        LbAccounts.Items.Clear()
        '=============================================

        '=================List Accounts===============
        For a As Integer = 0 To vaultAccounts.IsFixedSize + vaultAccounts.Count
            LbAccounts.Items.Add(vaultAccounts(a))
        Next
        '=============================================
    End Sub

    Private Sub RbOthers_CheckedChanged(sender As Object, e As EventArgs) Handles RbOthers.CheckedChanged
        '=================Reset Accounts List=========
        LbAccounts.Items.Clear()
        '=============================================

        '=================List Accounts===============
        For a As Integer = 0 To OtherAccounts.IsFixedSize + OtherAccounts.Count
            LbAccounts.Items.Add(OtherAccounts(a))
        Next
        '=============================================
    End Sub

    Private Sub LlWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlWebsite.LinkClicked
        '=================Setting URL================
        Dim url As String = “https://polardesigns.us“
        '=============================================

        '=================Launching Browser===========
        Process.Start(url)
        '=============================================
    End Sub
End Class
