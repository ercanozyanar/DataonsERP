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
    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
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
        If (e.Node.Name = "Düğüm4") Then
            Dim NewMDIChild As New stok_tanimlama()
            'Set the Parent Form of the Child window.
            NewMDIChild.MdiParent = Me
            'Display the new form.
            NewMDIChild.Show()
        End If
        If (e.Node.Name = "Düğüm3") Then
            Dim NewMDIChild As New stok_tanim()
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
    End Sub
End Class
