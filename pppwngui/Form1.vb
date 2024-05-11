Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



' PPPwn Gui Coded by CaliPanni
' https://github.com/CaliPanni/PPPwngui/
' Build 125 ver. 2.0
' 11/05/2024 15:47


Public Class Form1
    Private WithEvents process As Process
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nic As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            ComboBox2.Items.Add(nic.Description)
        Next
        ComboBox1.SelectedItem = My.Settings.firmware
        ComboBox2.SelectedItem = My.Settings.ethernet
        TextBox2.Text = My.Settings.stage2
        Dim iniziobat As String = "home.bat"
        Dim ProcessInfo As New ProcessStartInfo(iniziobat)
        ProcessInfo.CreateNoWindow = True
        ProcessInfo.UseShellExecute = False
        ProcessInfo.RedirectStandardOutput = True
        Dim process2 As Process = Process.Start(ProcessInfo)
        Dim output As String = process2.StandardOutput.ReadToEnd()
        RichTextBox1.Text = output
        process2.Start()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.firmware = ComboBox1.SelectedItem
        My.Settings.ethernet = ComboBox2.SelectedItem
        My.Settings.stage2 = TextBox2.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = openFileDialog1.FileName
        End If
    End Sub


    Private Sub Process_OutputDataReceived(sender As Object, e As DataReceivedEventArgs) Handles process.OutputDataReceived
        If e.Data IsNot Nothing Then
            UpdateTextBox(e.Data)
        End If
    End Sub

    Private Sub Process_ErrorDataReceived(sender As Object, e As DataReceivedEventArgs) Handles process.ErrorDataReceived
        If e.Data IsNot Nothing Then
            UpdateTextBox(e.Data)
        End If
    End Sub

    Private Sub UpdateTextBox(ByVal text As String)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() UpdateTextBox(text))
        Else
            RichTextBox1.AppendText(text & Environment.NewLine)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectedNicIndex As Integer = ComboBox2.SelectedIndex
        Dim selectedFwIndex As Integer = ComboBox1.SelectedIndex
        If ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Please fill in all the boxes.")
        Else
            If TextBox2.Text = "Open/Drop Stage2 payload" Then
                TextBox2.Text = "goldhen\1100\stage2.bin"
                sendpayload()
            Else
                sendpayload()
            End If
        End If
    End Sub
    Private Sub sendpayload()
        If TextBox2.Text = "goldhen\1100\stage2.bin" Or TextBox2.Text = "goldhen\900\stage2.bin" Then
            If ComboBox1.SelectedItem = "900" Then
                TextBox2.Text = "goldhen\900\stage2.bin"
                sendpayload1()
            Else
                If ComboBox1.SelectedItem = "1100" Then
                    TextBox2.Text = "goldhen\1100\stage2.bin"
                    sendpayload1()
                Else
                    MessageBox.Show("This firmware does not support GoldHEN.")
                End If
            End If
        Else
            sendpayload1()
        End If

    End Sub
    Private Sub sendpayload1()
        Using writer As New StreamWriter("var1.temp") 'Fw
            writer.Write(ComboBox1.SelectedItem)
        End Using
        Using writer As New StreamWriter("var2.temp") 'LAN interface
            writer.Write(ComboBox2.SelectedItem)
        End Using
        Using writer As New StreamWriter("var3.temp") 'stage2 dir
            writer.Write(TextBox2.Text)
        End Using
        RichTextBox1.Text = ""
        process = New Process()
        process.StartInfo.FileName = "send.bat"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.Start()
        process.BeginOutputReadLine()
        process.BeginErrorReadLine()
    End Sub
    Private Sub TextBox2_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each file In files
                Dim extension As String = Path.GetExtension(file)
                If extension = ".bin" OrElse extension = ".elf" Then
                    e.Effect = DragDropEffects.Copy
                    Exit Sub
                End If
            Next
        End If
        e.Effect = DragDropEffects.None
    End Sub

    Private Sub TextBox2_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox2.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        TextBox2.Text = files(0)
    End Sub
End Class

