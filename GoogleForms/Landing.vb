Public Class Landing
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf ShortcutForm_KeyDown
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Directly cast the ParentForm property to the type of the parent form
        Dim parentForm As Form1 = DirectCast(Me.ParentForm, Form1)

        ' Call the parent form's function
        parentForm.switchPanel(View_Submissions)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Directly cast the ParentForm property to the type of the parent form
        Dim parentForm As Form1 = DirectCast(Me.ParentForm, Form1)

        ' Call the parent form's function
        parentForm.switchPanel(Create_Submissions)
    End Sub
    Private Sub ShortcutForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
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
End Class