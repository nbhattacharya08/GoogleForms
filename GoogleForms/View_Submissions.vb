Imports System.Net

Public Class View_Submissions
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf ShortcutForm_KeyDown
        AddHandler Form1.SwitchToNextFormRequested, AddressOf SwitchToNextForm
        Me.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Prev")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Next")
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

End Class