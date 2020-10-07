Public Class Form1

    Dim x As String
    Dim 判别 As Boolean
    Dim 总字符串 As String
    Dim 迭代字符串1 As String
    Dim 迭代字符串2 As String
    Dim 主文件目录 As String
    Dim 主文件目录引导 As String

    Private Property 访问密钥 As String
    Private Function Boo_FileExist(ByVal Str_File As String) As Boolean

        Boo_FileExist = System.IO.File.Exists(Str_File)

    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Windows.Forms.Clipboard.Clear()
        System.Windows.Forms.Clipboard.SetText(Text3.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If List1.Text = "清空§r" Then
            Text3.Text = "§r"
        Else
            x = List1.Text
            If Text1.Text = "" Then
                Text3.Text = "请您输入一些文字后再按生成键"
            Else
                Select Case x

                    Case "黑色§0"
                        Text2.Text = "§0"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "深蓝§1"
                        Text2.Text = "§1"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "绿色§2"
                        Text2.Text = "§2"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "碧绿§3"
                        Text2.Text = "§3"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "暗红§4"
                        Text2.Text = "§4"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "紫色§5"
                        Text2.Text = "§5"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "橙色§6"
                        Text2.Text = "§6"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "灰色§7"
                        Text2.Text = "§7"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "深灰§8"
                        Text2.Text = "§0"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "淡蓝§9"
                        Text2.Text = "§9"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "亮绿§a"
                        Text2.Text = "§a"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "亮蓝§b"
                        Text2.Text = "§b"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "橘红§c"
                        Text2.Text = "§c"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "水红§d"
                        Text2.Text = "§d"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "黄色§e"
                        Text2.Text = "§e"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text

                    Case "白色§f"
                        Text2.Text = "§f"
                        If Check1.Checked = True Then
                            Text2.Text = (Text2.Text + "§k")
                        End If
                        If Check2.Checked = True Then
                            Text2.Text = (Text2.Text + "§l")
                        End If
                        If Check3.Checked = True Then
                            Text2.Text = (Text2.Text + "§n")
                        End If
                        If Check4.Checked = True Then
                            Text2.Text = (Text2.Text + "§m")
                        End If
                        If Check5.Checked = True Then
                            Text2.Text = (Text2.Text + "§o")
                        End If
                        Text2.Text = Text2.Text + Text1.Text
                    Case Else
                        Text2.Text = "请您选择一个颜色样式后再按生成键"
                End Select
                If Text2.Text = "请您选择一个颜色样式后再按生成键" Then
                    Text3.Text = "请您选择一个颜色样式后再按生成键"
                Else
                    Text3.Text = "§r" + Text2.Text
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Button3.Visible = False
        Me.Button4.Visible = True
        Me.Button5.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Button4.Visible = False
        Me.Button5.Visible = False
        Me.Button3.Visible = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        Else
            TextBox4.Text = OpenFileDialog1.FileName
            SaveFileDialog1.ShowDialog()
            总字符串 = Len(OpenFileDialog1.FileName)
            迭代字符串1 = 总字符串 - Len(OpenFileDialog1.SafeFileName)
            迭代字符串2 = Strings.Left(OpenFileDialog1.FileName, 迭代字符串1 - 1)
            TextBox5.Text = "保存文件名：" + SaveFileDialog1.FileName + vbCrLf + "文件源头：" + 迭代字符串2
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Button4.Visible = False
        Me.Button5.Visible = False
        Me.Button3.Visible = True
        OpenFileDialog2.ShowDialog()
        If OpenFileDialog2.FileName = "" Then
            Exit Sub
        Else
            TextBox4.Text = OpenFileDialog2.FileName
            总字符串 = Len(OpenFileDialog2.FileName)
            迭代字符串1 = 总字符串 - Len(OpenFileDialog2.SafeFileName)
            迭代字符串2 = Strings.Left(OpenFileDialog2.FileName, 迭代字符串1 - 1)
            TextBox5.Text = "文件源头：" + 迭代字符串2 + "文件释放目录：" + vbCrLf + TimeOfDay + "备份放出"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer.exe https://www.natfrp.com/")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Shell("frpc.exe -f " + MaskedTextBox1.Text + ":" + MaskedTextBox2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaskedTextBox1.Text = 访问密钥
        OpenFileDialog1.Title = "目标存档，存档位置存在在您的.minecraft\saves中"
        OpenFileDialog1.Filter = "存档加密文件|session.lock"
        OpenFileDialog2.Title = "存档文件"
        OpenFileDialog2.Filter = "内部完全拷贝文件|*.TOWIIBackup;*.LCTeamTOWIIFlies|外部存档格式|*.zip;*.7z"
        SaveFileDialog1.Filter = "内部完全拷贝文件|*.TOWIIBackup"
        SaveFileDialog1.FileName = Application.StartupPath + "\Exp.TOWIIBackup"
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "备份存档" Then
            判别 = False
            Button9.Text = "开始备份"
        Else
            判别 = True
            Button9.Text = "开始还原"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox5.Text <> "" Then
            If 判别 = False Then
                Shell("7z.exe a -t7z " + 迭代字符串2 + " " + SaveFileDialog1.FileName + _
                      "-mx=9 -ms=200m -mf -mhc -mhcf -m0=LZMA:a=2:d=25:mf=bt4b:fb=64 -mmt -r")
            Else
                主文件目录引导 = Len(Application.StartupPath)
                主文件目录 = Strings.Left(Application.StartupPath, 主文件目录引导 - 8)
                Shell("7z.exe  x -y -aos -o" + 主文件目录 + " \.minecraft\saves\ " + TimeOfDay + "备份放出 " + OpenFileDialog2.FileName)
            End If
        End If
    End Sub
End Class
