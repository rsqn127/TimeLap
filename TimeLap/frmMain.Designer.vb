<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(332, 129)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 25)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "다시 시작"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(332, 27)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(64, 25)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "시작"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(22, 70)
        Me.txtRecord.Multiline = True
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.ReadOnly = True
        Me.txtRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecord.Size = New System.Drawing.Size(265, 187)
        Me.txtRecord.TabIndex = 6
        Me.txtRecord.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(332, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 25)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(332, 180)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(64, 25)
        Me.btnRecord.TabIndex = 2
        Me.btnRecord.Text = "기록"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Time :"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(78, 29)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(209, 20)
        Me.txtTime.TabIndex = 5
        Me.txtTime.TabStop = False
        '
        'Timer
        '
        Me.Timer.Interval = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 284)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtRecord)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "TimeLap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtRecord As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
End Class
