Imports DevExpress.XtraNavBar
Imports DataonsERP.SearcHelper
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Xml
Imports System.Threading
Public Class main
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New()
        InitializeComponent()
        SearchHelper.CreateSearchPanel(NavBarControl2, SearchCriteria.Contains)

        'InitNavBar()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BarManager1.RestoreLayoutFromXml("c:\XtraBars_SaveToXML.xml")
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim fileName As String = "c:\XtraBars_SaveToXML.xml"
        BarManager1.SaveLayoutToXml(fileName)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim rdr As XmlTextReader = New XmlTextReader(" http://www.tcmb.gov.tr/kurlar/today.xml")
        'Dim ds As DataSet = New DataSet()
        'ds.ReadXml(rdr)
        'DataGridView1.DataSource = ds.Tables("Currency")
        'Thread.Sleep(2000)
        'For x = 0 To DataGridView1.Rows.Count - 1
        '    If Not String.IsNullOrEmpty(DataGridView1.Rows(x).Cells(10).Value) Then
        '        If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("USD") Then
        '            'Label5.Text = "USD SATIŞ : " + DataGridView1.Rows(x).Cells(4).Value.ToString()
        '            'Label8.Text = "USD ALIŞ : " + DataGridView1.Rows(x).Cells(3).Value.ToString()
        '            Exit For
        '        End If
        '    End If
        'Next
        'For x = 0 To DataGridView1.Rows.Count - 1
        '    If Not String.IsNullOrEmpty(DataGridView1.Rows(x).Cells(10).Value) Then
        '        If DataGridView1.Rows(x).Cells(10).Value.ToString().Contains("EUR") Then
        '            'Label9.Text = "EUR SATIŞ : " + DataGridView1.Rows(x).Cells(4).Value.ToString()
        '            'Label10.Text = "EUR ALIŞ : " + DataGridView1.Rows(x).Cells(3).Value.ToString()
        '            Exit For
        '        End If
        '    End If
        'Next


    End Sub
    Private Sub NavBarItem17_LinkClicked(sender As Object, e As NavBarLinkEventArgs)
        stok_tanimlama.MdiParent = Me
        stok_tanimlama.Show()
    End Sub
    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        If (e.Node.Name = "Düğüm1") Then
            Dim frm As doviz_tanim
            frm = New doviz_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm2") Then
            Dim NewMDIChild As New dovizkur_girisi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
    End Sub

    Private Sub TreeView2_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView2.NodeMouseClick
        If (e.Node.Name = "Düğüm3") Then
            Dim NewMDIChild As New stok_tanim()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm4") Then
            Dim NewMDIChild As New stok_tanimlama()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm5") Then
            Dim frm As stok_birim
            frm = New stok_birim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm6") Then
            Dim frm As vezne_tanim
            frm = New vezne_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm7") Then
            Dim frm As stokgrup_tanim
            frm = New stokgrup_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm8") Then
            Dim frm As stoktur_tanim
            frm = New stoktur_tanim()
            frm.Show()
        End If
        '===================================================
        If (e.Node.Name = "Düğüm9") Then
            Dim NewMDIChild As New stok_hareketlist()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm10") Then
            Dim NewMDIChild As New stok_cikisfis()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm11") Then
            Dim NewMDIChild As New stok_girisfis()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm12") Then
            Dim NewMDIChild As New stok_transferfisi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        '===================================================
        If (e.Node.Name = "Düğüm13") Then
            Dim NewMDIChild As New stok_fiyatlist()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm14") Then
            Dim NewMDIChild As New stok_kayitlist()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm16") Then
            Dim NewMDIChild As New stok_ekstresi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm17") Then
            Dim NewMDIChild As New stok_giriscikisrapor()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm18") Then
            Dim NewMDIChild As New stok_carihareketrapor()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm19") Then
            Dim NewMDIChild As New stok_hareketrapor()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm20") Then
            Dim NewMDIChild As New stok_degerrapor()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
    End Sub

    Private Sub TreeView3_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView3.NodeMouseClick
        If (e.Node.Name = "Düğüm0") Then
            Dim NewMDIChild As New cari_tanim()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm3") Then
            Dim frm As musteritemsil_tanim
            frm = New musteritemsil_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm4") Then
            Dim frm As carihesap_tanimi
            frm = New carihesap_tanimi()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm5") Then
            Dim frm As carihesapgrup_tanimi
            frm = New carihesapgrup_tanimi()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm1") Then
            Dim NewMDIChild As New carihesap_islem()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm20") Then
            Dim frm As doviz_tanim
            frm = New doviz_tanim()
            frm.Show()
        End If



        If (e.Node.Name = "Düğüm13") Then
            Dim NewMDIChild As New kayitli_cari_liste()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm14") Then
            Dim NewMDIChild As New cari_hesap_ekstre()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm15") Then
            Dim NewMDIChild As New cari_hesap_islem()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm16") Then
            Dim NewMDIChild As New cari_borc_alacak()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm17") Then
            Dim NewMDIChild As New cari_hesap_borc()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm18") Then
            Dim NewMDIChild As New cari_hesap_alacak()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If






        If (e.Node.Name = "Düğüm21") Then
            Dim NewMDIChild As New dovizkur_girisi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm23") Then
            Dim NewMDIChild As New banka_tanim()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm25") Then
            Dim NewMDIChild As New banka_acilis_islem()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm26") Then
            Dim NewMDIChild As New banka_virman_fisi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm27") Then
            Dim NewMDIChild As New gelen_havale()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm28") Then
            Dim NewMDIChild As New giden_havale()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm29") Then
            Dim NewMDIChild As New banka_yatirilan()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm30") Then
            Dim NewMDIChild As New bankadan_cekilen()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm32") Then
            Dim NewMDIChild As New banka_havale_list()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm33") Then
            Dim NewMDIChild As New banka_nakit()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm34") Then
            Dim NewMDIChild As New banka_hesap_ekstresi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm35") Then
            Dim NewMDIChild As New banka_bakiye_liste()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If

        If (e.Node.Name = "Düğüm37") Then
            Dim frm As kasa_tanim
            frm = New kasa_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğümk0") Then
            Dim frm As kasa_giriscikis
            frm = New kasa_giriscikis()
            frm.Show()
        End If
        If (e.Node.Name = "Düğümk3") Then
            Dim NewMDIChild As New kasa_virman_fisi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğümk4") Then
            Dim frm As tahsilat_fisi
            frm = New tahsilat_fisi()
            frm.Show()
        End If
        If (e.Node.Name = "Düğümk5") Then
            Dim frm As tediye_fisi
            frm = New tediye_fisi()
            frm.Show()
        End If
        If (e.Node.Name = "Düğümk6") Then
            Dim NewMDIChild As New kkartli_tahsil()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğümk7") Then
            Dim NewMDIChild As New kkartli_odeme()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm0k") Then
            Dim NewMDIChild As New kasa_hareket()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm1k") Then
            Dim NewMDIChild As New kkart_islem_rapor()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm2k") Then
            Dim NewMDIChild As New kasa_hesap_ekstre()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm3k") Then
            Dim NewMDIChild As New kasa_bakiye_liste()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If







        If (e.Node.Name = "Düğüm41") Then
            Dim NewMDIChild As New alinan_emanet()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm42") Then
            Dim NewMDIChild As New verilen_emanet()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm43") Then
            Dim NewMDIChild As New emanet_liste()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If

        If (e.Node.Name = "Düğüm49") Then
            Dim frm As masraf_grup_tanim
            frm = New masraf_grup_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm51") Then
            Dim frm As masraf_kart_tanim
            frm = New masraf_kart_tanim()
            frm.Show()
        End If
        If (e.Node.Name = "Düğüm52") Then
            Dim NewMDIChild As New masraf_girisi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If

        If (e.Node.Name = "Düğüm55") Then
            Dim NewMDIChild As New masraf_grupkart_ekstre()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm56") Then
            Dim NewMDIChild As New masraf_grupkart_liste()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm57") Then
            Dim NewMDIChild As New masraf_grup_ekstresi()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm58") Then
            Dim NewMDIChild As New masraf_bakiye_list()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
    End Sub

    Private Sub TreeView4_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView4.NodeMouseClick
        If (e.Node.Name = "Düğüm0") Then
            Dim NewMDIChild As New perakende_satis()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm1") Then
            Dim NewMDIChild As New perakende_alis()

            NewMDIChild.MdiParent = Me

            NewMDIChild.Show()
        End If
        'If (e.Node.Name = "Düğüm2") Then
        '    Dim NewMDIChild As New emanet_liste()
        '      NewMDIChild.MdiParent = Me
        '    NewMDIChild.Show()
        'End If
        'If (e.Node.Name = "Düğüm3") Then
        '    Dim NewMDIChild As New eee()
        '    
        '    NewMDIChild.MdiParent = Me
        '   
        '    NewMDIChild.Show()
        'End If
    End Sub

    Private Sub TreeView5_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView5.AfterSelect

    End Sub

    Private Sub TreeView5_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView5.NodeMouseClick
        If (e.Node.Name = "Düğüm0") Then
            Dim NewMDIChild As New toptan_alis_islemler()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm1") Then
            Dim NewMDIChild As New toptan_satis()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm2") Then
            Dim NewMDIChild As New alis_satis_rapor()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm3") Then
            Dim NewMDIChild As New satis_alis_rapor()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
        End If
    End Sub
    Private Sub TreeView6_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView6.NodeMouseClick
        'If (e.Node.Name = "Düğüm0") Then
        '    Dim NewMDIChild As New top()
        '    NewMDIChild.MdiParent = Me
        '    NewMDIChild.Show()
        'End If
        If (e.Node.Name = "Düğüm1") Then
            Dim NewMDIChild As New toptan_satis()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm2") Then
            Dim NewMDIChild As New alis_satis_rapor()
            NewMDIChild.MdiParent = Me
            NewMDIChild.Show()
        End If
        'If (e.Node.Name = "Düğüm3") Then
        '    Dim NewMDIChild As New toptan_alis_islemler()
        '    NewMDIChild.MdiParent = Me
        '    NewMDIChild.Show()
        'End If
        'If (e.Node.Name = "Düğüm4") Then
        '    Dim NewMDIChild As New toptan_alis_islemler()
        '    NewMDIChild.MdiParent = Me
        '    NewMDIChild.Show()
        'End If
    End Sub

    Private Sub TreeView4_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView4.AfterSelect

    End Sub

    Private Sub TreeView6_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView6.AfterSelect

    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect

    End Sub
End Class
