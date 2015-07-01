Public Class frmMain
    Private Time As Double

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click '
        If Timer.Enabled = True Then    '타이머 정지
            Timer.Enabled = False
            btnStart.Text = "시작"
            btnRecord.Enabled = False
            btnReset.Enabled = True
        Else                            '타이머 시작
            Timer.Enabled = True
            btnStart.Text = "정지"
            btnRecord.Enabled = True
            btnReset.Enabled = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Time = 0.00
        txtTime.Text = Format(Time, "f")
        btnReset.Enabled = False
        btnStart.Focus()
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        txtRecord.AppendText(txtTime.Text + vbCrLf)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Time += 0.01
        txtTime.Text = Format(Time, "f")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Time = 0.00
        txtTime.Text = Format(Time, "f")
        btnReset.Enabled = False
    End Sub
End Class
