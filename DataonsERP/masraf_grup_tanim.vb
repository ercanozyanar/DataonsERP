Imports System.Data.SqlClient
Public Class masraf_grup_tanim
    Private Sub masraf_grup_tanim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        conn1.ConnectionString = "server=EGEMM001\EGEMLOCAL;database=dataons;Integrated Security=True;"
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM HIZMET_GRUP_TANIM"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()
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
        cmd1.CommandText = "INSERT INTO HIZMET_GRUP_TANIM (GRUPKODU,GRUPCINSI) VALUES ( '" & grupkodu.Text & "','" & grupadi.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        grupkodu.Text = ""
        grupadi.Text = ""
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM HIZMET_GRUP_TANIM"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)

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
        silid = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=EGEMM001\EGEMLOCAL;database=dataons;Integrated Security=True;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From HIZMET_GRUP_TANIM where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM HIZMET_GRUP_TANIM"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '______________________________________________________________________________________________________________________________
        Exit Sub
        grupkodu.Text = ""
        grupadi.Text = ""
    End Sub
End Class