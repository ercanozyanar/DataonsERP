Public Class masraf_girisi
    Sub New()
        InitializeComponent()
    End Sub

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    Private Sub masraf_girisi_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim RaitoHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RaitoWidth As Double = (Me.Width - CuRWidth) / CuRWidth
        For Each Ctrl As Control In Controls
            Ctrl.Width += Ctrl.Width * RaitoWidth
            Ctrl.Left += Ctrl.Left * RaitoWidth
            Ctrl.Top += Ctrl.Top * RaitoHeight
            Ctrl.Height += Ctrl.Height * RaitoHeight
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        masraf_fis_ekle.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class