Public Class frmMain
    Private Time As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Time = "" Then
            Timer.Enabled = True
        ElseIf Timer.Enabled = True Then
            MsgBox("이미 스톱워치가 작동 중 입니다.", vbOKOnly + vbExclamation, "오류")
        Else
            MsgBox("계속 버튼을 눌러주십시오.", vbOKOnly + vbExclamation, "오류")
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If Timer.Enabled = False Then
            MsgBox("이미 타이머가 정지상태 입니다.", vbOKOnly + vbExclamation, "오류")
        Else
            Timer.Enabled = False
        End If
    End Sub

    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click
        If Time = "" Then
            MsgBox("시작 버튼을 먼저 눌러주십시오.", vbOKOnly + vbExclamation, "오류")
        ElseIf Timer.Enabled = True Then
            MsgBox("이미 스톱워치가 작동 중 입니다.", vbOKOnly + vbExclamation, "오류")
        Else
            Timer.Enabled = True
        End If
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        txtRecord.Text += Time + vbCrLf
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        txtTime.Text = Time
        Time = Time + 0.01
    End Sub
End Class
