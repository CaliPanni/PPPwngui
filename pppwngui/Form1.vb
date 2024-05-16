Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



' PPPwn Gui Coded by CaliPanni
' https://github.com/CaliPanni/PPPwngui/
' Build 250 ver. 2.7 based on PPPwn C++
' 16/05/2024 19:43


Public Class Form1
    Private times As String
    Private lan As String
    Private WithEvents process As Process
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Left = Me.ClientSize.Width
        Timer1.Interval = 100
        times = 2
        Timer1.Start()

        For Each nic As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            ComboBox2.Items.Add(nic.Description)
        Next
        CheckBox1.Checked = My.Settings.saves
        If CheckBox1.Checked = True Then
            ComboBox1.SelectedItem = My.Settings.firmware
            ComboBox2.SelectedItem = My.Settings.ethernet
            TextBox2.Text = My.Settings.stage2
            CheckBox2.Checked = My.Settings.autoretry
        End If
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
        Dim pproc() As Process = Process.GetProcessesByName("pppwn.exe")
        For Each proc As Process In pproc
            proc.Kill()
        Next
        My.Settings.firmware = ComboBox1.SelectedItem
        My.Settings.ethernet = ComboBox2.SelectedItem
        My.Settings.stage2 = TextBox2.Text
        My.Settings.saves = CheckBox1.Checked
        My.Settings.autoretry = CheckBox2.Checked
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
            Dim selectedNic As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()(selectedNicIndex)
            Dim interfaceid As String = selectedNic.Id
            lan = "\Device\NPF_" + selectedNic.Id
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
            writer.Write(lan)
        End Using
        Using writer As New StreamWriter("var3.temp") 'stage2 dir
            writer.Write(TextBox2.Text)
        End Using
        Using writer As New StreamWriter("var4.temp") 'auto retry
            writer.Write(CheckBox2.Checked)
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LinkLabel1.Left -= 5
        If LinkLabel1.Right < 0 Then
            If times = 1 Then
                LinkLabel1.Text = "Made In Italy By Peppe Meow (CaliPanni)"
                times = 2
            Else
                LinkLabel1.Text = "https://github.com/CaliPanni/PPPwngui"
                times = 1
            End If
            LinkLabel1.Left = Me.ClientSize.Width
        End If
    End Sub
End Class

