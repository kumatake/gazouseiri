<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.textMoto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonMoto = New System.Windows.Forms.Button()
        Me.buttonSaki = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textSaki = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.buttonStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        '
        'textMoto
        '
        Me.textMoto.Location = New System.Drawing.Point(94, 21)
        Me.textMoto.Name = "textMoto"
        Me.textMoto.Size = New System.Drawing.Size(409, 19)
        Me.textMoto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "整理元フォルダ"
        '
        'buttonMoto
        '
        Me.buttonMoto.Location = New System.Drawing.Point(509, 19)
        Me.buttonMoto.Name = "buttonMoto"
        Me.buttonMoto.Size = New System.Drawing.Size(103, 23)
        Me.buttonMoto.TabIndex = 2
        Me.buttonMoto.Text = "参照"
        Me.buttonMoto.UseVisualStyleBackColor = True
        '
        'buttonSaki
        '
        Me.buttonSaki.Location = New System.Drawing.Point(509, 44)
        Me.buttonSaki.Name = "buttonSaki"
        Me.buttonSaki.Size = New System.Drawing.Size(103, 23)
        Me.buttonSaki.TabIndex = 5
        Me.buttonSaki.Text = "参照"
        Me.buttonSaki.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "整理先フォルダ"
        '
        'textSaki
        '
        Me.textSaki.Location = New System.Drawing.Point(94, 46)
        Me.textSaki.Name = "textSaki"
        Me.textSaki.Size = New System.Drawing.Size(409, 19)
        Me.textSaki.TabIndex = 3
        '
        'buttonStart
        '
        Me.buttonStart.Location = New System.Drawing.Point(12, 82)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Size = New System.Drawing.Size(600, 49)
        Me.buttonStart.TabIndex = 6
        Me.buttonStart.Text = "整理開始"
        Me.buttonStart.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 150)
        Me.Controls.Add(Me.buttonStart)
        Me.Controls.Add(Me.buttonSaki)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textSaki)
        Me.Controls.Add(Me.buttonMoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textMoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "画像整理くん"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents textMoto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonMoto As System.Windows.Forms.Button
    Friend WithEvents buttonSaki As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textSaki As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents buttonStart As System.Windows.Forms.Button

End Class
