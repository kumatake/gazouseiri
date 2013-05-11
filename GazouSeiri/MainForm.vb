Public Class MainForm

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    '整理元の参照ボタンがクリックされた時の処理
    Private Sub buttonMoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonMoto.Click

        If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.textMoto.Text = Me.FolderBrowserDialog1.SelectedPath

        End If



    End Sub

    'フォームロード時の処理
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '各FolderBrowserDialogの初期設定を行う。
        Me.FolderBrowserDialog1.Description = "整理元のフォルダを選択してください"
        Me.FolderBrowserDialog2.Description = "整理先のフォルダを選択してください"

        Me.FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyPictures
        Me.FolderBrowserDialog2.RootFolder = Environment.SpecialFolder.MyPictures

        Me.textMoto.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        Me.textSaki.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)



    End Sub

    '整理先の参照ボタンがクリックされた時の処理
    Private Sub buttonSaki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSaki.Click

        If Me.FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.textMoto.Text = Me.FolderBrowserDialog2.SelectedPath

        End If

    End Sub
End Class
