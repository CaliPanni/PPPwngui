<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Button3 = New Button()
        Label5 = New Label()
        Label7 = New Label()
        RichTextBox1 = New RichTextBox()
        OpenFileDialog1 = New OpenFileDialog()
        ComboBox2 = New ComboBox()
        LinkLabel1 = New LinkLabel()
        GroupBox1 = New GroupBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Location = New Point(219, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 29)
        Button1.TabIndex = 1
        Button1.Text = "Open"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 3
        Label1.Text = "Stage2 File:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Black
        ComboBox1.ForeColor = Color.White
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1100", "1071", "1070", "1050", "1001", "1000", "960", "950", "904", "903", "900", "850"})
        ComboBox1.Location = New Point(219, 60)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(89, 28)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Firmware"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(46, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(236, 46)
        Label4.TabIndex = 7
        Label4.Text = "PPPwn GUI"
        ' 
        ' TextBox2
        ' 
        TextBox2.AllowDrop = True
        TextBox2.BackColor = Color.Black
        TextBox2.ForeColor = Color.White
        TextBox2.Location = New Point(9, 26)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(206, 27)
        TextBox2.TabIndex = 9
        TextBox2.Text = "Open/Drop Stage2 payload"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(12, 419)
        Button3.Name = "Button3"
        Button3.Size = New Size(321, 37)
        Button3.TabIndex = 10
        Button3.Text = "Send Payload"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.White
        Label5.Location = New Point(269, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 11
        Label5.Text = "v. 2.7"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 20)
        Label7.TabIndex = 13
        Label7.Text = "LOG:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Black
        RichTextBox1.ForeColor = Color.Green
        RichTextBox1.Location = New Point(12, 197)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(320, 210)
        RichTextBox1.TabIndex = 14
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Payload|*.bin *.elf"
        OpenFileDialog1.Title = "Select Stage 2 payload."
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Black
        ComboBox2.ForeColor = Color.White
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(9, 60)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(206, 28)
        ComboBox2.TabIndex = 15
        ComboBox2.Text = "Ethernet Adapter"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Semilight", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Cyan
        LinkLabel1.Location = New Point(12, 459)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(235, 17)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Made In Italy By Peppe Meow (CaliPanni)"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Black
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(321, 123)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "Options"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(9, 93)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(101, 24)
        CheckBox2.TabIndex = 20
        CheckBox2.Text = "Auto Retry"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(190, 93)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(118, 24)
        CheckBox1.TabIndex = 19
        CheckBox1.Text = "Save Options"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(346, 481)
        Controls.Add(Label7)
        Controls.Add(RichTextBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Button3)
        Controls.Add(LinkLabel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "PPPwn GUI ver. 2.7"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox1 As RichTextBox



    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
