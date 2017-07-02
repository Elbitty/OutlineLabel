<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OutlineLabel2 = New Karaoke0.OutlineLabel()
        Me.OutlineLabel1 = New Karaoke0.OutlineLabel()
        Me.OutlineLabel3 = New Karaoke0.OutlineLabel()
        Me.SuspendLayout()
        '
        'OutlineLabel2
        '
        Me.OutlineLabel2.AutoSize = True
        Me.OutlineLabel2.BackColor = System.Drawing.Color.Transparent
        Me.OutlineLabel2.Font = New System.Drawing.Font("Noto Sans CJK JP Bold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OutlineLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.OutlineLabel2.Location = New System.Drawing.Point(254, 387)
        Me.OutlineLabel2.Name = "OutlineLabel2"
        Me.OutlineLabel2.OutlineForeColor = System.Drawing.Color.Black
        Me.OutlineLabel2.OutlineWidth = 6.0!
        Me.OutlineLabel2.Size = New System.Drawing.Size(693, 95)
        Me.OutlineLabel2.TabIndex = 1
        Me.OutlineLabel2.Text = "#### #### #### ####"
        Me.OutlineLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel
        '
        'OutlineLabel1
        '
        Me.OutlineLabel1.AutoSize = True
        Me.OutlineLabel1.BackColor = System.Drawing.Color.Transparent
        Me.OutlineLabel1.Font = New System.Drawing.Font("Noto Sans CJK JP Bold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OutlineLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.OutlineLabel1.Location = New System.Drawing.Point(91, 197)
        Me.OutlineLabel1.Name = "OutlineLabel1"
        Me.OutlineLabel1.OutlineForeColor = System.Drawing.Color.Black
        Me.OutlineLabel1.OutlineWidth = 6.0!
        Me.OutlineLabel1.Size = New System.Drawing.Size(693, 95)
        Me.OutlineLabel1.TabIndex = 2
        Me.OutlineLabel1.Text = "#### #### #### ####"
        Me.OutlineLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel
        '
        'OutlineLabel3
        '
        Me.OutlineLabel3.AutoSize = True
        Me.OutlineLabel3.BackColor = System.Drawing.Color.Transparent
        Me.OutlineLabel3.Font = New System.Drawing.Font("Noto Sans CJK JP Bold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OutlineLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OutlineLabel3.Location = New System.Drawing.Point(91, 292)
        Me.OutlineLabel3.Name = "OutlineLabel3"
        Me.OutlineLabel3.OutlineForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.OutlineLabel3.OutlineWidth = 6.0!
        Me.OutlineLabel3.Size = New System.Drawing.Size(693, 95)
        Me.OutlineLabel3.TabIndex = 3
        Me.OutlineLabel3.Text = "#### #### #### ####"
        Me.OutlineLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1081, 535)
        Me.Controls.Add(Me.OutlineLabel3)
        Me.Controls.Add(Me.OutlineLabel1)
        Me.Controls.Add(Me.OutlineLabel2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutlineLabel2 As OutlineLabel
    Friend WithEvents OutlineLabel1 As OutlineLabel
    Friend WithEvents OutlineLabel3 As OutlineLabel
End Class
