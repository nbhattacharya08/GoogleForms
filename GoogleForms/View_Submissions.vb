﻿Imports System.Net
Imports System.Net.Http
Imports System.Text.Json


Public Class View_Submissions
    Private ReadOnly _client As HttpClient

    Dim count As Integer

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

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As String = Await GetRequestAsync($"http://localhost:3000/read?index={count - 1}")
        If Not String.IsNullOrEmpty(response) Then
            count = count - 1
            ShowResponse(response)
        End If
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As String = Await GetRequestAsync($"http://localhost:3000/read?index={count + 1}")
        If Not String.IsNullOrEmpty(response) Then
            count = count + 1
            ShowResponse(response)
        End If
    End Sub

    Private Sub ShortcutForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    ' Ctrl + V pressed
                    Button1.PerformClick()
                    e.Handled = True
                Case Keys.N
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

    Public Async Function GetRequestAsync(ByVal url As String) As Task(Of String)
        Dim response As HttpResponseMessage = Await _client.GetAsync(url)
        Dim responseBody As String = Await response.Content.ReadAsStringAsync()

        If response.IsSuccessStatusCode Then
            Return responseBody
        Else
            Dim jsonResponse = JsonDocument.Parse(responseBody)
            Dim root = jsonResponse.RootElement
            If root.GetProperty("error").GetString() = "Invalid index." Then
                MsgBox("No Previous or Next")
            Else
                MsgBox(root.GetProperty("error").GetString())
            End If
            Return String.Empty
        End If
    End Function

    Private Async Sub View_Submissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        count = 0
        Dim response As String = Await GetRequestAsync($"http://localhost:3000/read?index={count}")
        ShowResponse(response)
    End Sub

    Private Sub ShowResponse(responseBody As String)
        ' Parse the JSON response using System.Text.Json
        Dim jsonResponse = JsonDocument.Parse(responseBody)

        ' Assuming the response contains the following fields:
        ' name, email, phone, github_link, stopwatch_time
        Dim root = jsonResponse.RootElement
        TextBox1.Text = root.GetProperty("name").GetString()
        TextBox2.Text = root.GetProperty("email").GetString()
        TextBox3.Text = root.GetProperty("phone").GetString()
        TextBox4.Text = root.GetProperty("github_link").GetString()
        TextBox5.Text = root.GetProperty("stopwatch_time").GetString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Directly cast the ParentForm property to the type of the parent form
        Dim parentForm As Form1 = DirectCast(Me.ParentForm, Form1)

        ' Call the parent form's function
        parentForm.switchPanel(Landing)
    End Sub
End Class