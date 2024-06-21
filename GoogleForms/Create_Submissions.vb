Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks


Public Class Create_Submissions
    Dim mm As Integer
    Dim ss As Integer
    Dim ms As Integer

    Private ReadOnly _client As HttpClient

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf ShortcutForm_KeyDown
        AddHandler Form1.SwitchToNextFormRequested, AddressOf SwitchToNextForm
        Me.Focus()
        _client = New HttpClient()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ms += 1
        If ms = 10 Then
            ms = 0
            ss += 1
            If ss = 60 Then
                ss = 0
                mm += 1
            End If
        End If
        TextBox5.Text = mm & ":" & ss & ":" & ms
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub
    Private Sub ShortcutForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    ' Ctrl + V pressed
                    Button1.PerformClick()
                    e.Handled = True
                Case Keys.S
                    ' Ctrl + N pressed
                    Button2.PerformClick()
                    e.Handled = True
            End Select
        End If
    End Sub
    Private Sub SwitchToNextForm()
        Me.Show()
        Me.BringToFront()
        Me.Focus()
    End Sub
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox("Submit")
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phone As String = TextBox3.Text
        Dim github_link As String = TextBox4.Text
        Dim stopwatch_time As String = TextBox5.Text

        ' Convert the dictionary to a JSON string
        Dim jsonContent As String = $"{{""name"":""{name}"",""email"":""{email}"",""phone"":""{phone}"",""github_link"":""{github_link}"",""stopwatch_time"":""{stopwatch_time}""}}"
        Dim httpContent As New StringContent(jsonContent, Encoding.UTF8, "application/json")

        ' Send the HTTP POST request
        Dim response As String = Await PostRequestAsync("http://localhost:3000/submit", httpContent)
        If Not String.IsNullOrEmpty(response) Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            MsgBox("Form Submitted Successfully!")
        End If
    End Sub

    Public Async Function PostRequestAsync(ByVal url As String, ByVal content As HttpContent) As Task(Of String)
        Dim response As HttpResponseMessage = Await _client.PostAsync(url, content)
        If response.IsSuccessStatusCode() Then
            Return Await response.Content.ReadAsStringAsync()
        Else
            MsgBox(Await response.Content.ReadAsStringAsync())
            Return String.Empty
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Directly cast the ParentForm property to the type of the parent form
        Dim parentForm As Form1 = DirectCast(Me.ParentForm, Form1)

        ' Call the parent form's function
        parentForm.switchPanel(Landing)
    End Sub
End Class