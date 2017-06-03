Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Management
Imports System.Text
Imports NativeWifi

Public Class Form1

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.remember_me = True Then
            TextBox_ID.Text = My.Settings.remember_ID
            TextBox_PW.Text = My.Settings.remember_PW
            CheckBox_remember.CheckState = CheckState.Checked
        End If
        '       System.Windows.Forms.NotifyIcon.ContextMenuStrip = ContextMenuStrip_n

    End Sub

    Sub run_click()
        CycleCounter.Start()
        Button_run.Enabled = False
        Button_stop.Enabled = True
        NotifyIcon.Visible = True
        TextBox_ID.Enabled = False
        TextBox_PW.Enabled = False
    End Sub

    Sub stop_click()
        CycleCounter.Stop()
        Button_stop.Enabled = False
        Button_run.Enabled = True
        NotifyIcon.Visible = False
        TextBox_ID.Enabled = True
        TextBox_PW.Enabled = True
    End Sub

    Private Sub Button_run_Click(sender As Object, e As EventArgs) Handles Button_run.Click
        run_click()
    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        stop_click()
    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        My.Settings.remember_me = CheckBox_remember.CheckState
        If CheckBox_remember.CheckState = CheckState.Checked Then
            My.Settings.remember_ID = TextBox_ID.Text
            My.Settings.remember_PW = TextBox_PW.Text
        End If
        If Button_run.Enabled = False Then
            Visible = False
            With NotifyIcon
                .BalloonTipTitle = "バックグラウンドで動作中"
                .BalloonTipText = "バックグラウンドで動作中"
                .BalloonTipIcon = ToolTipIcon.Info
                .ShowBalloonTip(5000)
            End With
        Else

            Application.Exit()
        End If
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Visible = True
    End Sub

    Private Sub Menu_option_Click(sender As Object, e As EventArgs) Handles Menu_option.Click
        Visible = True
    End Sub

    Private Sub Menu_exit_Click(sender As Object, e As EventArgs) Handles Menu_exit.Click
        Application.Exit()
    End Sub

    Dim counter As Integer = 0
    Private Sub BackGroundBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles BackGroundBrowser.DocumentCompleted

        '    MsgBox("AAA")
        Dim a As Object = SubmitProcedure()

    End Sub

    Dim SP_judge As Boolean = False

    Private Function SubmitProcedure()
        SP_judge = False
        Try
            Dim all As HtmlElementCollection = BackGroundBrowser.Document.All
            Dim UserNameForm As HtmlElementCollection = all.GetElementsByName("username")
            Dim PassWordForm As HtmlElementCollection = all.GetElementsByName("password")
            Dim SubmitButton As HtmlElementCollection = all.GetElementsByName("Submit")
            UserNameForm(0).InnerText = TextBox_ID.Text
            PassWordForm(0).InnerText = TextBox_PW.Text
            'MsgBox(SubmitButton.Count)
            SubmitButton(0).InvokeMember("click")
            'BackGroundBrowser.Document.InvokeScript("submitAction")
            SP_judge = True

        Catch ex As System.ArgumentOutOfRangeException
            If SP_judge <> False Then
                SP_judge = False
            End If
        End Try
    End Function

    Private Function LogoutProcedure()

        Dim all As HtmlElementCollection = BackGroundBrowser.Document.All
        Dim LogoutButton As HtmlElementCollection = all.GetElementsByName("Logout")
        LogoutButton(0).InvokeMember("click")
    End Function

    Dim Info_num As Integer = -1

    Private Sub CycleCounter_Tick(sender As Object, e As EventArgs) Handles CycleCounter.Tick

        Dim AP_judge As Boolean = False
        Dim WI_judge As Boolean = False
        Try
            Dim wlan = New WlanClient()
            For Each wlanInterface As WlanClient.WlanInterface In wlan.Interfaces
                Dim ssid As Wlan.Dot11Ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid
                If "kctwa".Equals(New [String](Encoding.ASCII.GetChars(ssid.SSID, 0, CInt(ssid.SSIDLength)))) Then
                    AP_judge = True
                End If
            Next
            WI_judge = True
        Catch ex As System.ComponentModel.Win32Exception
            AP_judge = True
            If WI_judge <> False Then
                WI_judge = False
                Info_num = 2
            End If
        End Try

        If (Not AP_judge) Then 'kctwaに繋がってない
            If (Info_num <> 0) Then
                Info_num = 0
                With NotifyIcon
                    .BalloonTipTitle = "ステータス：　kctwa未接続"
                    .BalloonTipText = "繋がってない"
                    .BalloonTipIcon = ToolTipIcon.Error
                    .ShowBalloonTip(5000)

                End With
            End If
        Else 'kctwaにつながってる
            Try
                Dim p As New System.Net.NetworkInformation.Ping()
                Dim reply As System.Net.NetworkInformation.PingReply = p.Send("1.1.1.1", 1000)
                If (reply.Status <> System.Net.NetworkInformation.IPStatus.Success) Then
                    'ここにログイン処理書く
                    If (Info_num <> 1) Then
                        Info_num = 1
                        With NotifyIcon
                            .BalloonTipTitle = "ステータス：　未ログイン状態"
                            .BalloonTipText = "kctwaのログイン処理をしています..."
                            .BalloonTipIcon = ToolTipIcon.Info
                            .ShowBalloonTip(300)
                        End With
                        SP_judge = False
                    End If
                    If SP_judge = False Then
                        SP_judge = True
                        BackGroundBrowser.Navigate("https://1.1.1.1/login.html", False)
                    End If
                Else
                    'ここはログイン後
                    If (Info_num <> 2) Then
                        Info_num = 2
                        With NotifyIcon
                            .BalloonTipTitle = "ステータス：　ログイン成功"
                            .BalloonTipText = "kctwaにログインしました"
                            .BalloonTipIcon = ToolTipIcon.Info
                            .ShowBalloonTip(300)
                        End With
                    End If
                End If

            Catch ex As System.Net.NetworkInformation.PingException
            End Try
        End If
    End Sub

    Private Sub NotifyIcon_BallonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon.BalloonTipClicked
        Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SystemEvents.PowerModeChanged, AddressOf SystemEvents_PowerModeChanged
    End Sub

    Private Sub SystemEvents_PowerModeChanged(ByVal sender As Object, ByVal e As PowerModeChangedEventArgs)
        Select Case e.Mode
            Case PowerModes.Suspend
                stop_click()
            Case PowerModes.Resume
                run_click()
        End Select

    End Sub

    Private Sub BackGroundBrowser_NewWindow(sender As Object, e As CancelEventArgs) Handles BackGroundBrowser.NewWindow
        'MsgBox("YOYO")
        e.Cancel = True
    End Sub

End Class

Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Shutdown(ByVal sender As Object,
            ByVal e As EventArgs) Handles Me.Shutdown

            MsgBox("アプリケーションが終了します。")
            Form1.NotifyIcon.Visible = False
        End Sub

    End Class

End Namespace
