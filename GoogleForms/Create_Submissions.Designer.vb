<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Submissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        TextBox5 = New TextBox()
        Button2 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(35, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(544, 28)
        Label1.TabIndex = 0
        Label1.Text = "Nilanjan Bhattacharya, Slidey Task 2 - Create New Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "E-mail"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 221)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 30)
        Label4.TabIndex = 3
        Label4.Text = "Phone" & vbCrLf & "Number" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 45)
        Label5.TabIndex = 4
        Label5.Text = "Github " & vbCrLf & "Link for" & vbCrLf & "Task 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(157, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(422, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(157, 165)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(422, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(157, 228)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(422, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(157, 303)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(422, 23)
        TextBox4.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Yellow
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(48, 381)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 67)
        Button1.TabIndex = 9
        Button1.Text = "Toggle Stopwatch ( Ctrl + T )"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(350, 404)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(229, 23)
        TextBox5.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSkyBlue
        Button2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(147, 493)
        Button2.Name = "Button2"
        Button2.Size = New Size(308, 73)
        Button2.TabIndex = 11
        Button2.Text = "Submit ( Ctrl + S )"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Create_Submissions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 646)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Create_Submissions"
        Text = "Create_Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
