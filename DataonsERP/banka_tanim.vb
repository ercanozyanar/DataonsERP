Imports System.Data.SqlClient
Public Class banka_tanim
    Dim SqlConnStr As String = "Data Source=EGEMM001\EGEMLOCAL;Initial Catalog=dataons;Integrated Security=True;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)

    Sub New()
        InitializeComponent()
    End Sub
    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub banka_tanim_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    Private Sub banka_tanim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=EGEMM001\EGEMLOCAL;Initial Catalog=dataons;Integrated Security=True;"
        Dim sql As String = "SELECT ID,BANKA_ADI,SUBE_KODU,SUBE_ADI,HESAP_NO,IBAN_NO,HESAP_TURU,TEK_CEKIM_KESINTI FROM BANKA_TANIM ORDER BY ID DESC"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        conn1.ConnectionString = "server=EGEMM001\EGEMLOCAL;database=dataons;Integrated Security=True;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO BANKA_TANIM (KODU,BANKA_ADI,SUBE_KODU,SUBE_ADI,HESAP_NO,IBAN_NO,HESAP_TURU,TEK_CEKIM_KESINTI) VALUES ( '" & TextEdit2.Text & "','" & TextEdit1.Text & "','" & TextEdit4.Text & "','" & TextEdit3.Text & "','" & TextEdit5.Text & "','" & TextEdit6.Text & "','" & ComboBoxEdit2.Text & "','" & Replace(TextEdit7.Text, ",", ".") & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        TextEdit4.Text = ""
        TextEdit5.Text = ""
        TextEdit6.Text = ""
        TextEdit7.Text = ""
        ComboBoxEdit2.Text = ""
        '--------------------------------------------------------------------------------
        Dim connectionString As String = "Data Source=EGEMM001\EGEMLOCAL;Initial Catalog=dataons;Integrated Security=True;"
        Dim sql As String = "SELECT ID,BANKA_ADI,SUBE_KODU,SUBE_ADI,HESAP_NO,IBAN_NO,HESAP_TURU,TEK_CEKIM_KESINTI FROM BANKA_TANIM ORDER BY ID DESC"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
        '--------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim silid
        silid = ""
        'silid = GridControl1.CurrentRow.Cells(0).Value.ToString
        'silid = GridControl1.Select()
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=EGEMM001\EGEMLOCAL;database=dataons;Integrated Security=True;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From BANKA_TANIM where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        Dim connectionString As String = "Data Source=EGEMM001\EGEMLOCAL;Initial Catalog=dataons;Integrated Security=True;"
        Dim sql As String = "SELECT ID,BANKA_ADI,SUBE_KODU,SUBE_ADI,HESAP_NO,IBAN_NO,HESAP_TURU,TEK_CEKIM_KESINTI FROM BANKA_TANIM ORDER BY ID DESC"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
        '______________________________________________________________________________________________________________________________
        Exit Sub
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        TextEdit4.Text = ""
        TextEdit5.Text = ""
        TextEdit6.Text = ""
        TextEdit7.Text = ""
        ComboBoxEdit2.Text = ""
    End Sub
End Class