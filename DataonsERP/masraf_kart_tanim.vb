Imports System.Data.SqlClient
Public Class masraf_kart_tanim
    Private Sub masraf_kart_tanim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        conn1.ConnectionString = "server=EGEMM001\EGEMLOCAL;database=dataons;Integrated Security=True;"
        '---------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT ODA FROM HIZMET_GRUP_TANIM GROUP BY GRUPTANIM;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            grupadi.Items.Add(reader1("GRUPTANIM"))
        End While
        reader1.Close()
        conn1.Close()
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM MASRAF_KARTI_TANIM"
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
        cmd1.CommandText = "INSERT INTO MASRAF_KARTI_TANIM (GRUPTANIM,MASRAF_KODU,MASRAF_TANIM) VALUES ( '" & grupadi.Text & "','" & masrafkodu.Text & "','" & masrafadi.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        grupadi.Text = ""
        masrafkodu.Text = ""
        masrafadi.Text = ""
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM MASRAF_KARTI_TANIM"
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
        cmd1.CommandText = "Delete From MASRAF_KARTI_TANIM where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM MASRAF_KARTI_TANIM"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '______________________________________________________________________________________________________________________________
        Exit Sub
        grupadi.Text = ""
        masrafkodu.Text = ""
        masrafadi.Text = ""
    End Sub
End Class