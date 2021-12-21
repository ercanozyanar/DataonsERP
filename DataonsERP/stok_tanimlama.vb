Imports System.Data.OleDb
Public Class stok_tanimlama

    ' Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Ercan_OZYANAR_DATA\DataonsERP\DataonsERP\DataonsERP\dataons.accdb")

    Sub New()

        InitializeComponent()

    End Sub

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

    End Sub

    Private Sub stok_tanimlama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cn = New OleDb.OleDbConnection
        With cn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dataons.mdb"
        End With
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            cn.Open()
            sql = "SELECT kodlar.stokkodu, kodlar.türü, kodlar.cinsi, kodlar.özellik, kodlar.model, kodlar.stokadet, kodlar.giristarihi, kodlar.olcu, kodlar.minimum, kodlar.maksimum, kodlar.grup FROM kodlar;"
            cmd.Connection = cn
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()

        End Try
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
    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click

        Me.stokkodu.Text = CStr(Convert.ToString((Me.stokkodu)))
        If CBool(UCase(Convert.ToString(Me.stokkodu)) = "TL") Or (UCase(Convert.ToString(Me.stokkodu)) = "YTL") Then
            MsgBox("TL veya YTL kodunu kullanmanıza izin verilmiyor....Lütfen başka bir isimle tekrar deneyin...")
            Me.stokkodu.Select()
            Exit Sub
        End If
        If (Me.stokkodu.Text = "0") Then
            MsgBox("' 0 ' kodunu kullanmanıza izin verilmiyor... ", "Hata")
            Me.stokkodu.Text = vbNullString
            Me.stokkodu.Select()
            Exit Sub
        End If





        Dim cn = New OleDb.OleDbConnection
        With cn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dataons.mdb"
        End With
        Dim i
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            cn.Open()
            ' sql = "INSERT INTO KODLAR (kodlar.[sıra], kodlar.[kilit], kodlar.[stokkodu], kodlar.[kod2], kodlar.[türü], kodlar.[türü2], kodlar.[cinsi], kodlar.[özellik], kodlar.[model], kodlar.[stok], kodlar.[stokadet], kodlar.[hası], kodlar.[toplamis], kodlar.[milyem], kodlar.[milyem2], kodlar.[işkod], kodlar.[işgiriş], kodlar.[toptancı], kodlar.[giristarihi], kodlar.[olcu], kodlar.[banko], kodlar.[minimum], kodlar.[maksimum], kodlar.[grup], kodlar.[grup2], kodlar.[grup3], kodlar.[grup4], kodlar.[grup5], kodlar.[stgram], kodlar.[standartadet], kodlar.[gercekmaliyet], kodlar.[standart], kodlar.[stişkur], kodlar.[stiş], kodlar.[tutarseç], kodlar.[yüzde], kodlar.[isyuzde], kodlar.[ilkmev], kodlar.[ilkmevadet], kodlar.[girisyeri], kodlar.[stokkodukalafat], kodlar.[berraklik], kodlar.[renk], kodlar.[kesim], kodlar.[rstok], kodlar.[rhası], kodlar.[gstok], kodlar.[ghası], kodlar.[tümtop], kodlar.[tümhas], kodlar.[toplam], kodlar.[satılan], kodlar.[tophas], kodlar.[fark], kodlar.[hfark], kodlar.[dönembaşı], kodlar.[dönembaşıhası], kodlar.[dönembaşımaliyet], kodlar.[takozgram], kodlar.[takozadet], kodlar.[takozhası], kodlar.[takoz], kodlar.[sphası], kodlar.[ozelsira], kodlar.[yıl], kodlar.[stokkontrol], kodlar.[resim], kodlar.[gramaltin], kodlar.[user], kodlar.[belgeno], kodlar.[farklietiket], kodlar.[farklietiketsec], kodlar.[etikettutar], kodlar.[etiketoran], kodlar.[vezneizle], kodlar.[komisyon], kodlar.[Rstokkodu], kodlar.[Miattarih], kodlar.[konsinye], kodlar.[Miatay], kodlar.[topissatoran], kodlar.[webdeyayinla], kodlar.[sertifikafirma], kodlar.[sertifikano], kodlar.[etiketgram], kodlar.[hastl], kodlar.[usd], kodlar.[euro], kodlar.[tlbirimmaliyet], kodlar.[hasbirimmaliyet], kodlar.[usdbirimmaliyet], kodlar.[eurobirimmaliyet], kodlar.[standart2], kodlar.[standart3], kodlar.[yüzde2], kodlar.[yüzde3], kodlar.[stkkontyok], kodlar.[Hortalama], kodlar.[devirmaliyet], kodlar.[aktifmaliyet], kodlar.[pralkaryok], kodlar.[aciklama], kodlar.[odenentutar], kodlar.[RFID], kodlar.[barkodkaynakkod], kodlar.[subesi], kodlar.[minmakslist], kodlar.[barkod]) values ('" & amp; txtitemname.Text &amp; "', '" &amp; txtdescription.Text &amp; "'," &amp; Val(txtqty.Text) &amp; "," &amp; Val(txtprice.Text) &amp; ");"
            cmd.Connection = cn
            cmd.CommandText = sql
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
            Else
                MsgBox("No record has been inserted successfully!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()

        End Try
    End Sub

    Private Sub SimpleButton17_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class