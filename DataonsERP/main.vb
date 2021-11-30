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

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        ' Determine by checking the Node property of the TreeViewEventArgs.  
        MessageBox.Show(e.Node.Text)
    End Sub

    'Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
    '    If (e.Node.Name = "Rapor1") Then
    '        Dim frm As Form2
    '        frm = New Form2()
    '        frm.Show()
    '    End If
    'End Sub
End Class
