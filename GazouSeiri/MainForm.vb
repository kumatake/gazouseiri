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

    '整理開始ボタンを押された時の処理
    Private Sub buttonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStart.Click

        Dim fileIndex As String()
        Dim image As System.Drawing.Bitmap
        Dim item As System.Drawing.Imaging.PropertyItem
        Dim fileName As String
        Dim val As String = ""
        Dim year As String
        Dim month As String
        Dim day As String
        Dim sakiPath As String
        Dim sakiFilePath As String

        Dim suc As Integer = 0
        Dim fai As Integer = 0
        Dim err As Integer = 0

        'パスをチェックしてエラーだったら終了
        If Me.pathCheck = False Then

            Return

        End If

        'jpgファイルの一覧取得
        fileIndex = System.IO.Directory.GetFiles(Me.textMoto.Text, "*.jpg", IO.SearchOption.TopDirectoryOnly)

        If fileIndex.Length > 0 Then

            For Each filePath As String In fileIndex

                Try

                    fileName = System.IO.Path.GetFileName(filePath)
                    image = New System.Drawing.Bitmap(filePath)

                Catch ex As ArgumentException

                    err += 1
                    Continue For

                End Try


                For Each item In image.PropertyItems

                    'Exif情報から撮影時間を取得する
                    If item.Id = &H9003 And item.Type = 2 Then

                        '文字列に変換する
                        val = System.Text.Encoding.ASCII.GetString(item.Value)
                        val = val.Trim(New Char() {ControlChars.NullChar})


                        Exit For

                    End If

                Next

                If val.Length = 0 Then

                    fai += 1
                    Continue For

                End If

                '日付を分割してパスを作成
                year = val.Substring(0, 4)
                month = val.Substring(5, 2)
                day = val.Substring(8, 2)

                sakiPath = textSaki.Text & "\" & year & "_" & month & "_" & day

                'sakiPathのフォルダが有るか確認し、ないなら作成
                If System.IO.Directory.Exists(sakiPath) Then

                    Try

                        System.IO.Directory.CreateDirectory(sakiPath)

                    Catch ex As Exception

                        MessageBox.Show("フォルダ作成でエラーが発生しました。" & vbCrLf & "処理を終了します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Exit Sub

                    End Try


                End If

                '移動先のファイルのパスを作成
                sakiFilePath = sakiPath & "\" & fileName

                '画像ファイルをコピーする
                Try

                    System.IO.File.Copy(filePath, sakiFilePath)

                Catch ex As IO.IOException

                    fai += 0

                    Continue For

                End Try


            Next

        End If

       




    End Sub

    'パスをチェックするメソッド
    Private Function pathCheck()

        'パスが入力されているかチェック
        If Me.textMoto.TextLength = 0 Then

            MessageBox.Show("整理元のパスを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Me.textSaki.TextLength = 0 Then

            MessageBox.Show("整理先のパスを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        End If

        '入力されているパスが開けるかチェック
        If System.IO.Directory.Exists(Me.textMoto.Text) = False Then

            MessageBox.Show("整理元のパスは存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf System.IO.Directory.Exists(Me.textMoto.Text) = False Then

            MessageBox.Show("整理先のパスは存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        End If

        Return True

    End Function

End Class
