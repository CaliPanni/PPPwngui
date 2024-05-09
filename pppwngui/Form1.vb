Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private WithEvents process As Process
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nic As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
            ComboBox2.Items.Add(nic.Description)
        Next
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
        If ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please fill in all the boxes.")
        Else
            sendpayload()
        End If
    End Sub
    Private Sub sendpayload()
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
End Class
