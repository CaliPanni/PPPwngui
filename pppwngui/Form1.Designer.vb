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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
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
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(224, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Open"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 3
        Label1.Text = "Stage2 File:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 4
        Label2.Text = "Ethernet Adapter:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 5
        Label3.Text = "Firmware:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1100", "1071", "1070", "1050", "1001", "1000", "960", "950", "904", "903", "900", "850"})
        ComboBox1.Location = New Point(82, 115)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(86, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(236, 46)
        Label4.TabIndex = 7
        Label4.Text = "PPPwn GUI"
        ' 
        ' TextBox2
        ' 
        TextBox2.AllowDrop = True
        TextBox2.Location = New Point(93, 48)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(254, 86)
        Button3.Name = "Button3"
        Button3.Size = New Size(73, 67)
        Button3.TabIndex = 10
        Button3.Text = "Send Payload"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(235, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 11
        Label5.Text = "v. 1.0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 20)
        Label7.TabIndex = 13
        Label7.Text = "LOG:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 159)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(315, 229)
        RichTextBox1.TabIndex = 14
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "BIN FIle|*.bin"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(136, 81)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(112, 28)
        ComboBox2.TabIndex = 15
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Semilight", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(12, 391)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(235, 17)
        LinkLabel1.TabIndex = 17
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Made In Italy By Peppe Meow (CaliPanni)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(339, 410)
        Controls.Add(LinkLabel1)
        Controls.Add(ComboBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "PPPwn GUI ver. 1.0"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
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
End Class
