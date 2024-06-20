Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        switchPanel(Landing)

    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
        RaiseEvent SwitchToNextFormRequested()
    End Sub

    Public Event SwitchToNextFormRequested()
End Class
