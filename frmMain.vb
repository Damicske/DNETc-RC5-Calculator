Public Class frmMain
    Private bStartup As Boolean = True
    Private dWuTime As Decimal = 10000
    Private ReadOnly sTmp(5) As String

    Private Sub BtnTeamPage_Click(sender As Object, e As EventArgs) Handles btnTeamPage.Click
        Process.Start("http://stats.distributed.net/team/tmsummary.php?project_id=8&team=10313")
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmInfo.Show()
    End Sub

    Private Sub BtnBuffIn_Click(sender As Object, e As EventArgs) Handles btnBuffIn.Click
        'show form or just make main bigger?
        If Width = 475 Then
            Width = 706
            btnBuffIn.Text = "<< Empty buff-in"
        Else
            Width = 475
            btnBuffIn.Text = "Empty buff-in >>"
        End If
    End Sub

    Private Sub BtnCalcBuffIn_Click(sender As Object, e As EventArgs) Handles btnCalcBuffIn.Click
        If bStartup Or Not CheckInputIsNumeric(txtUnits.Text) Then Exit Sub
        Try
            Dim lTmp As Long, cTime As Decimal, KeyRate As Decimal, sTxtTmp As String
            lTmp = Convert.ToInt64(txtUnits.Text)
            '-check/replace/change somethings
            If lTmp < 10000 Then
                lTmp = txtUnits.Text = 10000
            End If

            KeyRate = KeysPs()

            If KeyRate < 10000 Then
                txtKeysS.Text = 10000
                KeyRate = 10000
            End If
            cTime = (2 ^ 32 * lTmp) / KeyRate

            If chkCpu.Checked Then
                cTime /= (CLng(nupPuTime.Value) / 24)
                sTxtTmp = nupPuTime.Value & " hours a day!"
            Else
                sTxtTmp = "24 on 24"
            End If

            lblOut.Text = "It's going to take " & Clock(CLng(cTime), True, True, False, False) & " (or " & Clock(CLng(cTime), True, False, False, False) & ")" & " for " & lTmp & " SU's @ " & txtKeysS.Text & cbKeysps.Items(cbKeysps.SelectedIndex).ToString & ", if the pc is running " & sTxtTmp
            lblOut.Visible = True
        Catch ofl As OverflowException
            MessageBox.Show("Check you keys/s", "Buffer In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("BufferIn made an error: " & ex.ToString, "Buffer In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Btn2LineTxt_Click(sender As Object, e As EventArgs) Handles btn2LineTxt.Click
        '-information on 2 lines that's it :D
        Dim s As String = "With a rate of " & txtKeysS.Text
        Select Case cbKeysps.SelectedIndex
            Case 1 : s &= "k" 'kilo
            Case 2 : s &= "M" 'mega
            Case 3 : s &= "G" 'giga
            Case 4 : s &= "T" 'tera
            Case 5 : s &= "P" 'peta
        End Select

        s &= "keys/sec, it takes " & sTmp(0) & " for 1 SU, after a hour he/she's got " & sTmp(4) & " and after 24h " & sTmp(1) & "SU's. If the pc is running " & nupPuTime.Value & " hours/day then he/she got " & sTmp(2)
        s &= Environment.NewLine & "If he/she started on " & dtpStart.Value & ", ended on " & dtpStop.Value & If(chkDone.Checked, " and Buff-out contains " & txtSuBuffOut.Text & " SU's,", "") & " then he/she got " & sTmp(3)
        s &= " (if the pc is running " & If(chkCpu.Checked, nupPuTime.Value & " hours each day", "24/24") & ")"

        Clipboard.SetText(s, TextDataFormat.UnicodeText)
        MessageBox.Show("Copyed to clipboard, paste it where you like", "2Line text", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnStartNow_Click(sender As Object, e As EventArgs) Handles btnStartNow.Click
        dtpStart.Value = Date.Now
        dtpStart.Update()
        Calculate()
    End Sub

    Private Sub BtnDateStopNow90_Click(sender As Object, e As EventArgs) Handles btnDateStopNow90.Click
        dtpStop.Value = Date.Now.AddDays(90)
        dtpStop.Update()
        Calculate()
    End Sub

    Private Sub BtnDateStopNowStart90_Click(sender As Object, e As EventArgs) Handles btnDateStopNowStart90.Click
        dtpStop.Value = dtpStart.Value.AddDays(90)
        dtpStop.Update()
        Calculate()
    End Sub

    Private Sub ChkDone_CheckedChanged(sender As Object, e As EventArgs) Handles chkDone.CheckedChanged
        Calculate()
    End Sub

    Private Sub ChkCpu_CheckedChanged(sender As Object, e As EventArgs) Handles chkCpu.CheckedChanged
        Calculate()
    End Sub

    Private Sub DtpStart_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpStart.KeyDown
        If e.KeyCode = Keys.Enter Then Calculate()
    End Sub

    Private Sub DtpStop_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpStop.KeyDown
        If e.KeyCode = Keys.Enter Then Calculate()
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        With My.Settings
            .Use += 1
            .Save()
        End With
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With My.Settings
            If CBool(.MustUpgrade) Then
                .Upgrade()
                Application.DoEvents()
                .MustUpgrade = False
                .Save()
                .Reload()
            End If
        End With
        'BETA = True
        VersionType = 1

        Text = VersionX()

        With My.Settings
            Use = CLng(.Use)
            txtKeysS.Text = .Keyrate
            txtSuBuffOut.Text = .SuDone
            txtUnits.Text = .BuffTime
            chkCpu.Checked = CBool(.AddPuTime)
            chkDone.Checked = CBool(.AddSuDone)
            dtpStart.Value = If(CDate(.Startdate) < dtpStart.MinDate, Date.Now, CDate(.Startdate))
            dtpStop.Value = If(CDate(.EndDate) < dtpStart.MinDate, Date.Now.AddDays(10), CDate(.EndDate))
            nupPuTime.Value = If(CInt(.Putime) > 4 And CInt(.Putime) < 23, CInt(.Putime), 5)
            chkDateStartNow.Checked = CBool(.AddStartDate)
            chkDateStopNow.Checked = CBool(.AddStopDate)
            cbKeysps.SelectedIndex = If(CInt(.Keysps) > 0, CInt(.Keysps), 0)
        End With

        If chkDateStartNow.Checked Then btnStartNow_Click(Me, e)
        If chkDateStopNow.Checked Then btnDateStopNow90_Click(Me, e)

        Calculate()
    End Sub

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Width = 475
    End Sub
    Private Sub FrmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        bStartup = False
    End Sub

    Private Sub LblOut_Click(sender As Object, e As EventArgs) Handles lblOut.Click
        If MessageBox.Show("Copy to Clipboard?", "Clipboard", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then Exit Sub
        Clipboard.SetText(lblOut.Text, TextDataFormat.UnicodeText)
    End Sub

    Private Sub NupPuTime_ValueChanged(sender As Object, e As EventArgs) Handles nupPuTime.ValueChanged
        Calculate()
    End Sub

    Private Sub TxtKeysS_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKeysS.KeyDown
        If e.KeyCode = Keys.Enter Then Calculate()
    End Sub

    Private Sub TxtSuBuffOut_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSuBuffOut.KeyDown
        If e.KeyCode = Keys.Enter Then Calculate()
    End Sub

    Private Sub CbKeysps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKeysps.SelectedIndexChanged
        Calculate()
    End Sub

    Private Sub Calculate()
        If bStartup Or Not CheckInputIsNumeric(txtSuBuffOut.Text) Then Exit Sub 'Or Not CheckInputIsNumeric(txtKeysS.Text)
        Try
            dWuTime = 2 ^ 32 / KeysPs()

            sTmp(0) = Clock(CLng(dWuTime * 1000), False, False) 'time for 1 su
            sTmp(5) = Clock(CLng(dWuTime * 128 * 1000), False, False) 'time for 128 su
            lblSuTime.Text = "Time of 1 SU: " & sTmp(0) & Environment.NewLine & "Time of 128 SU: " & sTmp(5)

            sTmp(1) = (86400 / dWuTime).ToString("#,00") 'day
            lblSuADay.Text = "SU's a day: " & sTmp(1)

            sTmp(4) = (3600 / dWuTime).ToString("#,00") 'hour
            lblSuPerHour.Text = "SU's per hour: " & sTmp(4)
            If Not IsNumeric(txtSuBuffOut.Text) Then txtSuBuffOut.Text = 0

            sTmp(2) = (3600 / dWuTime * nupPuTime.Value).ToString("#,00") 'crunching hours
            lblPuSuTime.Text = "SU's in amount of CPU/GPU time:" & vbNewLine & sTmp(2)

            Dim lDays As Long = DateDiff(DateInterval.Day, dtpStart.Value, dtpStop.Value)
            sTmp(3) = Convert.ToInt64(86400 / dWuTime * lDays * If(chkCpu.Checked, nupPuTime.Value / 24, 1) _
                + If(chkDone.Checked, Convert.ToInt64(txtSuBuffOut.Text.Replace(".", "")), 0)).ToString("#,00")
            lblSuDays.Text = "SU's after " & lDays & " days: " & sTmp(3)

            With My.Settings
                .Keyrate = txtKeysS.Text
                .SuDone = txtSuBuffOut.Text
                .AddPuTime = chkCpu.Checked
                .AddSuDone = chkDone.Checked
                .Startdate = dtpStart.Value
                .EndDate = dtpStop.Value
                .Putime = nupPuTime.Value
                .AddStartDate = chkDateStartNow.Checked
                .AddStopDate = chkDateStopNow.Checked
                .BuffTime = txtUnits.Text
                .Keysps = cbKeysps.SelectedIndex
                .Save()
            End With

            btn2LineTxt.Enabled = True
        Catch ofl As OverflowException
            MessageBox.Show("Check you keys/s", "Calculate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Calculate made an error: " & ex.ToString, "Calculate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Function CheckInputIsNumeric(ByVal Input As String) As Boolean
        CheckInputIsNumeric = False
        If bStartup Then Exit Function
        If Not IsNumeric(Input) Then
            MessageBox.Show("Input is not numeric!", "Numeric Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End If
        CheckInputIsNumeric = True
    End Function

    Private Function KeysPs() As Decimal
        If Not IsNumeric(txtKeysS.Text) Then
            KeysPs = 0
            txtKeysS.Text = txtKeysS.Text.ToLower.Replace("sec", "s")

            If txtKeysS.Text.IndexOf(".") > 0 And txtKeysS.Text.IndexOf(",") > 0 Then
                txtKeysS.Text = txtKeysS.Text.Replace(",", "")
            End If

            txtKeysS.Text = txtKeysS.Text.Replace(".", ",").Replace(" ", "")

            '-auto select key rate
            If txtKeysS.Text.IndexOf("kkeys/s") > 0 Then
                txtKeysS.Text = txtKeysS.Text.Replace("kkeys/s", "")
                cbKeysps.SelectedIndex = 1
            ElseIf txtKeysS.Text.IndexOf("mkeys/s") > 0 Then
                txtKeysS.Text = txtKeysS.Text.Replace("mkeys/s", "")
                cbKeysps.SelectedIndex = 2
            ElseIf txtKeysS.Text.IndexOf("gkeys/s") > 0 Then
                txtKeysS.Text = txtKeysS.Text.Replace("gkeys/s", "")
                cbKeysps.SelectedIndex = 3
            ElseIf txtKeysS.Text.IndexOf("tkeys/s") > 0 Then
                txtKeysS.Text = txtKeysS.Text.Replace("tkeys/s", "")
                cbKeysps.SelectedIndex = 4
            ElseIf txtKeysS.Text.IndexOf("pkeys/s") > 0 Then
                txtKeysS.Text = txtKeysS.Text.Replace("pkeys/s", "")
                cbKeysps.SelectedIndex = 5
            Else
                txtKeysS.Text = txtKeysS.Text.Replace("keys/s", "")
                cbKeysps.SelectedIndex = 0
            End If

            If Not IsNumeric(txtKeysS.Text) Then
                '-where is the first not numeric char
                For i = 1 To txtKeysS.Text.Length - 1
                    If Not IsNumeric(txtKeysS.Text.Substring(0, i)) Then
                        KeysPs = Convert.ToDecimal(txtKeysS.Text.Substring(0, i - 1))
                        Exit For
                    End If
                Next
            Else
                KeysPs = Convert.ToDecimal(txtKeysS.Text)
            End If
        Else
            KeysPs = Convert.ToDecimal(txtKeysS.Text)
        End If

        Select Case cbKeysps.SelectedIndex
            Case 1 : KeysPs *= 1000 'kilo
            Case 2 : KeysPs *= 1000000 'mega
            Case 3 : KeysPs *= 1000000000 'giga
            Case 4 : KeysPs *= 1000000000000 'tera
            Case 5 : KeysPs *= 1000000000000000 'peta
            Case Else
        End Select
    End Function
End Class
