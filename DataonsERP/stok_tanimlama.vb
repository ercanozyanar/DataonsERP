Public Class stok_tanimlama
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

    End Sub

    Private Sub stok_tanimlama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabPage6.PageVisible = False
        XtraTabPage7.PageVisible = False
    End Sub

    Private Sub stok_tanimlama_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        If ComboBoxEdit1.Text = "Altın" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = True
            LabelControl67.Visible = True
            ComboBoxEdit20.Visible = True
            LabelControl68.Visible = True
            ComboBoxEdit21.Visible = False
            LabelControl69.Visible = False
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = True
            LabelControl12.Visible = True
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = True ' - işçilik
            TextEdit25.Visible = True
            LabelControl36.Text = "Milyem"
            LabelControl37.Visible = True ' - E.işçilik
            TextEdit26.Visible = True
            LabelControl70.Visible = False ' - E.Birim
            TextEdit57.Visible = False
            LabelControl71.Visible = False ' - B.Maliyet
            TextEdit58.Visible = False

            CheckEdit1.Visible = True
            CheckEdit2.Visible = True
            RadioButton3.Visible = True
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = True
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = True
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = True
            LabelControl56.Visible = True
            TextEdit46.Visible = True
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False

        End If
        If ComboBoxEdit1.Text = "Gümüş" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = True
            LabelControl67.Visible = True
            ComboBoxEdit20.Visible = True
            LabelControl68.Visible = True
            ComboBoxEdit21.Visible = False
            LabelControl69.Visible = False
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = True
            LabelControl12.Visible = True
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = True ' - işçilik
            TextEdit25.Visible = True
            LabelControl36.Text = "TL"
            LabelControl37.Visible = True ' - E.işçilik
            TextEdit26.Visible = True
            LabelControl70.Visible = False ' - E.Birim
            TextEdit57.Visible = False
            LabelControl71.Visible = False ' - B.Maliyet
            TextEdit58.Visible = False

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = True
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = True
            LabelControl56.Visible = True
            TextEdit46.Visible = True
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False

        End If
        If ComboBoxEdit1.Text = "Hurda Altın" Then
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = False
            LabelControl69.Visible = False
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = True
            LabelControl12.Visible = True
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = false ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Visible = False
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = False ' - E.Birim
            TextEdit57.Visible = False
            LabelControl71.Visible = False ' - B.Maliyet
            TextEdit58.Visible = False

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = False
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = False
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Takoz Altın" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = False
            LabelControl69.Visible = False
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = True
            LabelControl12.Visible = True
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Visible = False
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = False ' - E.Birim
            TextEdit57.Visible = False
            LabelControl71.Visible = False ' - B.Maliyet
            TextEdit58.Visible = False

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = False
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = False
            LabelControl56.Visible = False
            TextEdit46.Visible = False

            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Takoz Gümüş" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = False
            LabelControl69.Visible = False
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = True
            LabelControl12.Visible = True
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Visible = False
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = False ' - E.Birim
            TextEdit57.Visible = False
            LabelControl71.Visible = False ' - B.Maliyet
            TextEdit58.Visible = False

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = False
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = False
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Döviz" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = False
            LabelControl69.Visible = False
            ComboBoxEdit3.Visible = False
            LabelControl6.Visible = False
            ComboBoxEdit9.Visible = False
            LabelControl12.Visible = False
            'TAB -2 -----------------------
            LabelControl33.Visible = False '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = False
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Visible = False
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = False ' - E.Birim
            TextEdit57.Visible = False
            LabelControl71.Visible = False ' - B.Maliyet
            TextEdit58.Visible = False

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = False
            TextEdit34.Visible = False
            LabelControl48.Visible = False
            TextEdit33.Visible = False
            RadioButton4.Visible = False
            RadioButton5.Visible = False
            TextEdit35.Visible = False
            LabelControl52.Visible = False
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = False
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = False
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Saat" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = True
            LabelControl69.Visible = True
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = False
            LabelControl12.Visible = False
            'TAB -2 -----------------------
            LabelControl33.Visible = False '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = False
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Text = "USD"
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = True ' - E.Birim
            TextEdit57.Visible = True
            LabelControl71.Visible = True ' - B.Maliyet
            TextEdit58.Visible = True

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Adet"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = False
            TextEdit33.Visible = False
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = True
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = True
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Pırlanta" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = True
            LabelControl69.Visible = True
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = False
            LabelControl12.Visible = False
            'TAB -2 -----------------------
            LabelControl33.Visible = False '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = False
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Text = "USD"
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = True ' - E.Birim
            TextEdit57.Visible = True
            LabelControl71.Visible = True ' - B.Maliyet
            TextEdit58.Visible = True
            'TAB -3 -----------------------
            LabelControl49.Text = "Adet"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = False
            TextEdit33.Visible = False
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = True
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = True
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = True
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Diğer" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = True
            LabelControl68.Visible = True
            ComboBoxEdit21.Visible = True
            LabelControl69.Visible = True
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = False
            LabelControl12.Visible = False
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "GRAM" '- GRAM
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Text = "TL"
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = True ' - E.Birim
            TextEdit57.Visible = True
            LabelControl71.Visible = True ' - B.Maliyet
            TextEdit58.Visible = True

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Gram"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = True
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = True
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = False
        End If
        If ComboBoxEdit1.Text = "Taş" Then
            'TAB -1 -----------------------
            ComboBoxEdit19.Visible = False
            LabelControl67.Visible = False
            ComboBoxEdit20.Visible = False
            LabelControl68.Visible = False
            ComboBoxEdit21.Visible = True
            LabelControl69.Visible = True
            ComboBoxEdit3.Visible = True
            LabelControl6.Visible = True
            ComboBoxEdit9.Visible = False
            LabelControl12.Visible = False
            'TAB -2 -----------------------
            LabelControl33.Visible = True '- Gram
            LabelControl33.Text = "CARAT" '- CARAT
            TextEdit23.Visible = True
            LabelControl34.Visible = True ' - Adet
            TextEdit24.Visible = True
            LabelControl35.Visible = False ' - işçilik
            TextEdit25.Visible = False
            LabelControl36.Text = "USD"
            LabelControl37.Visible = False ' - E.işçilik
            TextEdit26.Visible = False
            LabelControl70.Visible = True ' - E.Birim
            TextEdit57.Visible = True
            LabelControl71.Visible = True ' - B.Maliyet
            TextEdit58.Visible = True

            CheckEdit1.Visible = False
            CheckEdit2.Visible = True
            RadioButton3.Visible = False
            'TAB -3 -----------------------
            LabelControl49.Text = "Carat"
            LabelControl49.Visible = True
            TextEdit34.Visible = True
            LabelControl48.Visible = True
            TextEdit33.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            TextEdit35.Visible = True
            LabelControl52.Visible = True
            RadioButton6.Visible = False
            ComboBoxEdit16.Visible = False
            SimpleButton15.Visible = False
            TextEdit36.Visible = False
            TextEdit37.Visible = False
            TextEdit38.Visible = False
            TextEdit39.Visible = False
            TextEdit40.Visible = False
            RadioButton7.Visible = True
            ComboBoxEdit17.Visible = False
            SimpleButton16.Visible = False
            TextEdit45.Visible = False
            TextEdit44.Visible = False
            TextEdit43.Visible = False
            TextEdit42.Visible = False
            TextEdit41.Visible = False
            RadioButton8.Visible = True
            LabelControl56.Visible = False
            TextEdit46.Visible = False
            XtraTabPage6.PageVisible = False
            XtraTabPage7.PageVisible = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        ComboBoxEdit17.Visible = True
        SimpleButton16.Visible = True
        TextEdit45.Visible = True
        TextEdit44.Visible = True
        TextEdit43.Visible = True
        TextEdit42.Visible = True
        TextEdit41.Visible = True
        ComboBoxEdit16.Visible = False
        SimpleButton15.Visible = False
        TextEdit36.Visible = False
        TextEdit37.Visible = False
        TextEdit38.Visible = False
        TextEdit39.Visible = False
        TextEdit40.Visible = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ComboBoxEdit17.Visible = False
        SimpleButton16.Visible = False
        TextEdit45.Visible = False
        TextEdit44.Visible = False
        TextEdit43.Visible = False
        TextEdit42.Visible = False
        TextEdit41.Visible = False
        ComboBoxEdit16.Visible = True
        SimpleButton15.Visible = True
        TextEdit36.Visible = True
        TextEdit37.Visible = True
        TextEdit38.Visible = True
        TextEdit39.Visible = True
        TextEdit40.Visible = True
    End Sub
End Class