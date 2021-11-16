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

    Private Sub SidePanel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitterControl1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub AccordionControlElement54_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NavBarControl2_Click(sender As Object, e As EventArgs) Handles NavBarControl2.Click

    End Sub

    Private Sub NavBarItem18_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItem18.LinkClicked

    End Sub

    Private Sub NavBarItem17_LinkPressed(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItem17.LinkPressed

    End Sub

    Private Sub NavBarItem17_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavBarItem17.LinkClicked
        stok_tanimlama.MdiParent = Me
        stok_tanimlama.Show()
    End Sub
End Class
