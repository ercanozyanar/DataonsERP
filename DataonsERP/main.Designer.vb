<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits DevExpress.XtraEditors.XtraForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap                                      ")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Kartı Tanımı                              ")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Müşteri Temsilcileri / Satış Elemanı Tanımlama")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Türü Tanımı")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Gruları Tanımı")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Parametre Tanımları                              ", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap İşlem Fişi")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap İşlemleri                                ", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kayıtlı Cari Hesap Listesi")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Ekstresi")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap İşlem Listesi")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Borç / Alacak Listesi")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Borç Yaşlandırma Listesi")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Alacak Yaşlandırma Listesi")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Raporları                               ", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Döviz Türü Tanımlama     ")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Döviz Kur Girişi      ")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Döviz     ", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Tanımı    ")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Açılış İşlemleri")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Virman Fişi")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gelen Havale")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gönderilen Havale")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bankaya Yatırılan")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bankadan Çekilen")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka İşlemleri     ", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Havale Listesi")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Nakit Giriş Çıkış")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Hesap Ekstresi")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Bakiye Listesi")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Raporları", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka   ", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode26, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Tanımı")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa İşlem Fişi               ")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Virman Fişi               ")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tahsilat Fişi                ")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tediye Fişi                   ")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kredi Kartlı Tahsilat Girişi                      ")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kredi Kartlı Ödeme Çıkışı                      ")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa İşlemleri", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Hareketleri            ")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kredi Kartlı İşlemler Listesi             ")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Hesap Ekstresi         ")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Bakiye Listesi            ")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Raporları", New System.Windows.Forms.TreeNode() {TreeNode41, TreeNode42, TreeNode43, TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa   ", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode40, TreeNode45})
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alınan Emanet Girişi")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Verilen Emanet Çıkışı")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emanet Listesi")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emanet Hesapları    ", New System.Windows.Forms.TreeNode() {TreeNode47, TreeNode48, TreeNode49})
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Grup Tanımı")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Kartı Tanımı")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tanımlar", New System.Windows.Forms.TreeNode() {TreeNode51, TreeNode52})
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Girişi")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Grup Ekstresi")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Grup Bakiye Listesi")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Ekstresi")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Bakiye Listesi")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Raporları", New System.Windows.Forms.TreeNode() {TreeNode55, TreeNode56, TreeNode57, TreeNode58})
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf İşlemleri     ", New System.Windows.Forms.TreeNode() {TreeNode53, TreeNode54, TreeNode59})
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Alış İşlemleri                    ")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Alış                                   ")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Satış İşlemleri                                                 ")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Satış                                 ")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alış Satış Raporu                    ")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Satış ve Alış Raporu               ")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Genel Analiz Raporları                   ")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stoklar")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Tanımı")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Birim Tanımı")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Depo/Ambar Tanımı")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Grupları Tanımı")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Tür Tanımı")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Tanımları                                           ", New System.Windows.Forms.TreeNode() {TreeNode68, TreeNode69, TreeNode70, TreeNode71, TreeNode72, TreeNode73})
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Hareket Fişleri")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Çıkış Fişi")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Giriş Fişi")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Transfer Fişi")
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok İşlemleri                                   ", New System.Windows.Forms.TreeNode() {TreeNode75, TreeNode76, TreeNode77, TreeNode78})
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Fiyat Listesi")
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kayıtlı Stok Listesi")
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Ekstresi")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Giriş-Çıkış Raporu")
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Bazında Cari Hareketler")
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Hareketleri")
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Değer Raporu")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Raporları                                    ", New System.Windows.Forms.TreeNode() {TreeNode80, TreeNode81, TreeNode82, TreeNode83, TreeNode84, TreeNode85, TreeNode86})
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perakende Satış Fişi                                   ")
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perakende Alış Fişi                                    ")
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perakende Satış Özeti   ")
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gün Sonu Raporu  ")
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat Girişi     ")
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat Listesi    ")
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat Raporları          ", New System.Windows.Forms.TreeNode() {TreeNode93})
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat İşlemleri                              ", New System.Windows.Forms.TreeNode() {TreeNode92, TreeNode94})
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Garanti Sertifika Girişi             ")
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Garanti Sertifika İşlemleri        ", New System.Windows.Forms.TreeNode() {TreeNode96})
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Servis Kontrol                     ")
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Servis Kontrol           ")
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Silinen Kayıtlar         ")
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servis İşlemleri        ", New System.Windows.Forms.TreeNode() {TreeNode98, TreeNode99, TreeNode100})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.AccordionControlElement53 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.DefaultBarAndDockingController1 = New DevExpress.XtraBars.DefaultBarAndDockingController(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView5 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer5 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView6 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer6 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView4 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer7 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView7 = New System.Windows.Forms.TreeView()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup12 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup7 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.ımageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.TreeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.TreeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        Me.TreeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultBarAndDockingController1.Controller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl2.SuspendLayout()
        Me.NavBarGroupControlContainer3.SuspendLayout()
        Me.NavBarGroupControlContainer4.SuspendLayout()
        Me.NavBarGroupControlContainer5.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.NavBarGroupControlContainer6.SuspendLayout()
        Me.NavBarGroupControlContainer7.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccordionControlElement53
        '
        Me.AccordionControlElement53.Name = "AccordionControlElement53"
        Me.AccordionControlElement53.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement53.Text = "Satış Kar  Raporu"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'DefaultBarAndDockingController1
        '
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Cari Raporlar", New System.Guid("15704279-4d80-4e63-9998-436a1d9ef6f2")), New DevExpress.XtraBars.BarManagerCategory("Cari İşlemler", New System.Guid("53fbe5a1-7a9a-41aa-9289-80c25046a5bc")), New DevExpress.XtraBars.BarManagerCategory("Stok İşlemleri", New System.Guid("3c785215-2781-46c0-9d62-a6678371f179"))})
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem12, Me.barButtonItem13, Me.barButtonItem14, Me.barButtonItem15, Me.barButtonItem16, Me.barButtonItem17})
        Me.BarManager1.MaxItemId = 22
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(291, 135)
        Me.Bar1.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barDockControlTop.Appearance.Options.UseFont = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1368, 25)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 677)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1368, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 25)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 652)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1368, 25)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 652)
        '
        'barButtonItem1
        '
        Me.barButtonItem1.Caption = "Altın Ürün Barkodlama"
        Me.barButtonItem1.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem1.Id = 5
        Me.barButtonItem1.Name = "barButtonItem1"
        '
        'barButtonItem2
        '
        Me.barButtonItem2.Caption = "Banka Değişikliği"
        Me.barButtonItem2.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem2.Id = 6
        Me.barButtonItem2.Name = "barButtonItem2"
        '
        'barButtonItem3
        '
        Me.barButtonItem3.Caption = "Özel Ürün Barkodlama"
        Me.barButtonItem3.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem3.Id = 7
        Me.barButtonItem3.Name = "barButtonItem3"
        '
        'barButtonItem4
        '
        Me.barButtonItem4.Caption = "Banko Değişikliği Merkez"
        Me.barButtonItem4.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem4.Id = 8
        Me.barButtonItem4.Name = "barButtonItem4"
        '
        'barButtonItem5
        '
        Me.barButtonItem5.Caption = "Banko Değişikliği Şube"
        Me.barButtonItem5.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem5.Id = 9
        Me.barButtonItem5.Name = "barButtonItem5"
        '
        'barButtonItem6
        '
        Me.barButtonItem6.Caption = "Çoklu Resim"
        Me.barButtonItem6.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem6.Id = 10
        Me.barButtonItem6.Name = "barButtonItem6"
        '
        'barButtonItem7
        '
        Me.barButtonItem7.Caption = "Tüm Stok İşlemleri"
        Me.barButtonItem7.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem7.Id = 11
        Me.barButtonItem7.Name = "barButtonItem7"
        '
        'barButtonItem8
        '
        Me.barButtonItem8.Caption = "Sayım İşlemleri"
        Me.barButtonItem8.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem8.Id = 12
        Me.barButtonItem8.Name = "barButtonItem8"
        '
        'barButtonItem9
        '
        Me.barButtonItem9.Caption = "Ürün Sil"
        Me.barButtonItem9.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem9.Id = 13
        Me.barButtonItem9.Name = "barButtonItem9"
        '
        'barButtonItem10
        '
        Me.barButtonItem10.Caption = "Slayt"
        Me.barButtonItem10.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem10.Id = 14
        Me.barButtonItem10.Name = "barButtonItem10"
        '
        'barButtonItem11
        '
        Me.barButtonItem11.Caption = "RFID Sayım"
        Me.barButtonItem11.CategoryGuid = New System.Guid("3c785215-2781-46c0-9d62-a6678371f179")
        Me.barButtonItem11.Id = 15
        Me.barButtonItem11.Name = "barButtonItem11"
        '
        'barButtonItem12
        '
        Me.barButtonItem12.Caption = "Cari Hesap İşlemleri"
        Me.barButtonItem12.CategoryGuid = New System.Guid("53fbe5a1-7a9a-41aa-9289-80c25046a5bc")
        Me.barButtonItem12.Id = 16
        Me.barButtonItem12.Name = "barButtonItem12"
        '
        'barButtonItem13
        '
        Me.barButtonItem13.Caption = "Satış İşlemleri"
        Me.barButtonItem13.CategoryGuid = New System.Guid("53fbe5a1-7a9a-41aa-9289-80c25046a5bc")
        Me.barButtonItem13.Id = 17
        Me.barButtonItem13.Name = "barButtonItem13"
        '
        'barButtonItem14
        '
        Me.barButtonItem14.Caption = "Kur Girişleri"
        Me.barButtonItem14.CategoryGuid = New System.Guid("53fbe5a1-7a9a-41aa-9289-80c25046a5bc")
        Me.barButtonItem14.Id = 18
        Me.barButtonItem14.Name = "barButtonItem14"
        '
        'barButtonItem15
        '
        Me.barButtonItem15.Caption = "Satış Raporu Genel"
        Me.barButtonItem15.CategoryGuid = New System.Guid("15704279-4d80-4e63-9998-436a1d9ef6f2")
        Me.barButtonItem15.Id = 19
        Me.barButtonItem15.Name = "barButtonItem15"
        '
        'barButtonItem16
        '
        Me.barButtonItem16.Caption = "Satış Raporu Detay"
        Me.barButtonItem16.CategoryGuid = New System.Guid("15704279-4d80-4e63-9998-436a1d9ef6f2")
        Me.barButtonItem16.Id = 20
        Me.barButtonItem16.Name = "barButtonItem16"
        '
        'barButtonItem17
        '
        Me.barButtonItem17.Caption = "Satış Raporu Özet"
        Me.barButtonItem17.CategoryGuid = New System.Guid("15704279-4d80-4e63-9998-436a1d9ef6f2")
        Me.barButtonItem17.Id = 21
        Me.barButtonItem17.Name = "barButtonItem17"
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup6
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer3)
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer4)
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer5)
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer6)
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer7)
        Me.NavBarControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup4, Me.NavBarGroup6, Me.NavBarGroup12, Me.NavBarGroup7, Me.NavBarGroup2, Me.NavBarGroup3, Me.NavBarGroup8, Me.NavBarGroup5, Me.NavBarGroup1})
        Me.NavBarControl2.LargeImages = Me.ımageList1
        Me.NavBarControl2.Location = New System.Drawing.Point(0, 25)
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 249
        Me.NavBarControl2.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.NavBarControl2.Size = New System.Drawing.Size(249, 652)
        Me.NavBarControl2.StoreDefaultPaintStyleName = True
        Me.NavBarControl2.TabIndex = 53
        Me.NavBarControl2.Text = "NavBarControl2"
        '
        'NavBarGroup6
        '
        Me.NavBarGroup6.Caption = "Finansman Yönetimi"
        Me.NavBarGroup6.ControlContainer = Me.NavBarGroupControlContainer3
        Me.NavBarGroup6.Expanded = True
        Me.NavBarGroup6.GroupClientHeight = 289
        Me.NavBarGroup6.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup6.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.currency_32x32
        Me.NavBarGroup6.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.currency_16x16
        Me.NavBarGroup6.Name = "NavBarGroup6"
        ToolTipItem1.Text = "Deneme"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.NavBarGroup6.SuperTip = SuperToolTip1
        '
        'NavBarGroupControlContainer3
        '
        Me.NavBarGroupControlContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer3.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer3.Controls.Add(Me.TreeView3)
        Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
        Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(247, 325)
        Me.NavBarGroupControlContainer3.TabIndex = 2
        '
        'TreeView3
        '
        Me.TreeView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TreeView3.FullRowSelect = True
        Me.TreeView3.HideSelection = False
        Me.TreeView3.ItemHeight = 16
        Me.TreeView3.Location = New System.Drawing.Point(0, 0)
        Me.TreeView3.Name = "TreeView3"
        TreeNode1.ForeColor = System.Drawing.Color.Navy
        TreeNode1.Name = "Düğüm1"
        TreeNode1.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode1.Text = "Cari Hesap                                      "
        TreeNode2.ForeColor = System.Drawing.Color.Navy
        TreeNode2.Name = "Düğüm0"
        TreeNode2.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode2.Text = "Cari Hesap Kartı Tanımı                              "
        TreeNode3.ForeColor = System.Drawing.Color.Navy
        TreeNode3.Name = "Düğüm3"
        TreeNode3.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode3.Text = "Müşteri Temsilcileri / Satış Elemanı Tanımlama"
        TreeNode4.ForeColor = System.Drawing.Color.Navy
        TreeNode4.Name = "Düğüm4"
        TreeNode4.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode4.Text = "Cari Hesap Türü Tanımı"
        TreeNode5.ForeColor = System.Drawing.Color.Navy
        TreeNode5.Name = "Düğüm5"
        TreeNode5.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode5.Text = "Cari Hesap Gruları Tanımı"
        TreeNode6.ForeColor = System.Drawing.Color.Navy
        TreeNode6.Name = "Düğümc1"
        TreeNode6.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode6.Text = "Cari Hesap Parametre Tanımları                              "
        TreeNode7.ForeColor = System.Drawing.Color.Navy
        TreeNode7.Name = "Düğüm1"
        TreeNode7.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode7.Text = "Cari Hesap İşlem Fişi"
        TreeNode8.ForeColor = System.Drawing.Color.Navy
        TreeNode8.Name = "Düğüm2"
        TreeNode8.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode8.Text = "Cari Hesap İşlemleri                                "
        TreeNode9.ForeColor = System.Drawing.Color.Navy
        TreeNode9.Name = "Düğüm13"
        TreeNode9.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode9.Text = "Kayıtlı Cari Hesap Listesi"
        TreeNode10.ForeColor = System.Drawing.Color.Navy
        TreeNode10.Name = "Düğüm14"
        TreeNode10.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode10.Text = "Cari Hesap Ekstresi"
        TreeNode11.ForeColor = System.Drawing.Color.Navy
        TreeNode11.Name = "Düğüm15"
        TreeNode11.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode11.Text = "Cari Hesap İşlem Listesi"
        TreeNode12.ForeColor = System.Drawing.Color.Navy
        TreeNode12.Name = "Düğüm16"
        TreeNode12.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode12.Text = "Cari Hesap Borç / Alacak Listesi"
        TreeNode13.ForeColor = System.Drawing.Color.Navy
        TreeNode13.Name = "Düğüm17"
        TreeNode13.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode13.Text = "Cari Hesap Borç Yaşlandırma Listesi"
        TreeNode14.ForeColor = System.Drawing.Color.Navy
        TreeNode14.Name = "Düğüm18"
        TreeNode14.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode14.Text = "Cari Hesap Alacak Yaşlandırma Listesi"
        TreeNode15.ForeColor = System.Drawing.Color.Navy
        TreeNode15.Name = "Düğümc0"
        TreeNode15.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode15.Text = "Cari Hesap Raporları                               "
        TreeNode16.ForeColor = System.Drawing.Color.Navy
        TreeNode16.Name = "Düğüm20"
        TreeNode16.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode16.Text = "Döviz Türü Tanımlama     "
        TreeNode17.ForeColor = System.Drawing.Color.Navy
        TreeNode17.Name = "Düğüm21"
        TreeNode17.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode17.Text = "Döviz Kur Girişi      "
        TreeNode18.ForeColor = System.Drawing.Color.Navy
        TreeNode18.Name = "Düğüm18"
        TreeNode18.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode18.Text = "Döviz     "
        TreeNode19.ForeColor = System.Drawing.Color.Navy
        TreeNode19.Name = "Düğüm23"
        TreeNode19.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode19.Text = "Banka Tanımı    "
        TreeNode20.ForeColor = System.Drawing.Color.Navy
        TreeNode20.Name = "Düğüm25"
        TreeNode20.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode20.Text = "Banka Açılış İşlemleri"
        TreeNode21.ForeColor = System.Drawing.Color.Navy
        TreeNode21.Name = "Düğüm26"
        TreeNode21.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode21.Text = "Banka Virman Fişi"
        TreeNode22.ForeColor = System.Drawing.Color.Navy
        TreeNode22.Name = "Düğüm27"
        TreeNode22.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode22.Text = "Gelen Havale"
        TreeNode23.ForeColor = System.Drawing.Color.Navy
        TreeNode23.Name = "Düğüm28"
        TreeNode23.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode23.Text = "Gönderilen Havale"
        TreeNode24.ForeColor = System.Drawing.Color.Navy
        TreeNode24.Name = "Düğüm29"
        TreeNode24.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode24.Text = "Bankaya Yatırılan"
        TreeNode25.ForeColor = System.Drawing.Color.Navy
        TreeNode25.Name = "Düğüm30"
        TreeNode25.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode25.Text = "Bankadan Çekilen"
        TreeNode26.ForeColor = System.Drawing.Color.Navy
        TreeNode26.Name = "Düğüm24"
        TreeNode26.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode26.Text = "Banka İşlemleri     "
        TreeNode27.ForeColor = System.Drawing.Color.Navy
        TreeNode27.Name = "Düğüm32"
        TreeNode27.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode27.Text = "Banka Havale Listesi"
        TreeNode28.ForeColor = System.Drawing.Color.Navy
        TreeNode28.Name = "Düğüm33"
        TreeNode28.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode28.Text = "Banka Nakit Giriş Çıkış"
        TreeNode29.ForeColor = System.Drawing.Color.Navy
        TreeNode29.Name = "Düğüm34"
        TreeNode29.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode29.Text = "Banka Hesap Ekstresi"
        TreeNode30.ForeColor = System.Drawing.Color.Navy
        TreeNode30.Name = "Düğüm35"
        TreeNode30.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode30.Text = "Banka Bakiye Listesi"
        TreeNode31.ForeColor = System.Drawing.Color.Navy
        TreeNode31.Name = "Düğüm31"
        TreeNode31.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode31.Text = "Banka Raporları"
        TreeNode32.ForeColor = System.Drawing.Color.Navy
        TreeNode32.Name = "Düğüm22"
        TreeNode32.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode32.Text = "Banka   "
        TreeNode33.ForeColor = System.Drawing.Color.Navy
        TreeNode33.Name = "Düğüm37"
        TreeNode33.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode33.Text = "Kasa Tanımı"
        TreeNode34.ForeColor = System.Drawing.Color.Navy
        TreeNode34.Name = "Düğümk0"
        TreeNode34.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode34.Text = "Kasa İşlem Fişi               "
        TreeNode35.ForeColor = System.Drawing.Color.Navy
        TreeNode35.Name = "Düğümk3"
        TreeNode35.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode35.Text = "Kasa Virman Fişi               "
        TreeNode36.ForeColor = System.Drawing.Color.Navy
        TreeNode36.Name = "Düğümk4"
        TreeNode36.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode36.Text = "Tahsilat Fişi                "
        TreeNode37.ForeColor = System.Drawing.Color.Navy
        TreeNode37.Name = "Düğümk5"
        TreeNode37.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode37.Text = "Tediye Fişi                   "
        TreeNode38.ForeColor = System.Drawing.Color.Navy
        TreeNode38.Name = "Düğümk6"
        TreeNode38.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode38.Text = "Kredi Kartlı Tahsilat Girişi                      "
        TreeNode39.ForeColor = System.Drawing.Color.Navy
        TreeNode39.Name = "Düğümk7"
        TreeNode39.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode39.Text = "Kredi Kartlı Ödeme Çıkışı                      "
        TreeNode40.ForeColor = System.Drawing.Color.Navy
        TreeNode40.Name = "Düğüm38"
        TreeNode40.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode40.Text = "Kasa İşlemleri"
        TreeNode41.ForeColor = System.Drawing.Color.Navy
        TreeNode41.Name = "Düğüm0k"
        TreeNode41.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode41.Text = "Kasa Hareketleri            "
        TreeNode42.ForeColor = System.Drawing.Color.Navy
        TreeNode42.Name = "Düğüm1k"
        TreeNode42.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode42.Text = "Kredi Kartlı İşlemler Listesi             "
        TreeNode43.ForeColor = System.Drawing.Color.Navy
        TreeNode43.Name = "Düğüm2k"
        TreeNode43.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode43.Text = "Kasa Hesap Ekstresi         "
        TreeNode44.ForeColor = System.Drawing.Color.Navy
        TreeNode44.Name = "Düğüm3k"
        TreeNode44.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode44.Text = "Kasa Bakiye Listesi            "
        TreeNode45.ForeColor = System.Drawing.Color.Navy
        TreeNode45.Name = "Düğüm39"
        TreeNode45.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode45.Text = "Kasa Raporları"
        TreeNode46.ForeColor = System.Drawing.Color.Navy
        TreeNode46.Name = "Düğüm36"
        TreeNode46.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode46.Text = "Kasa   "
        TreeNode47.ForeColor = System.Drawing.Color.Navy
        TreeNode47.Name = "Düğüm41"
        TreeNode47.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode47.Text = "Alınan Emanet Girişi"
        TreeNode48.ForeColor = System.Drawing.Color.Navy
        TreeNode48.Name = "Düğüm42"
        TreeNode48.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode48.Text = "Verilen Emanet Çıkışı"
        TreeNode49.ForeColor = System.Drawing.Color.Navy
        TreeNode49.Name = "Düğüm43"
        TreeNode49.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode49.Text = "Emanet Listesi"
        TreeNode50.ForeColor = System.Drawing.Color.Navy
        TreeNode50.Name = "Düğüm40"
        TreeNode50.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode50.Text = "Emanet Hesapları    "
        TreeNode51.ForeColor = System.Drawing.Color.Navy
        TreeNode51.Name = "Düğüm49"
        TreeNode51.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode51.Text = "Masraf Grup Tanımı"
        TreeNode52.ForeColor = System.Drawing.Color.Navy
        TreeNode52.Name = "Düğüm51"
        TreeNode52.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode52.Text = "Masraf Kartı Tanımı"
        TreeNode53.ForeColor = System.Drawing.Color.Navy
        TreeNode53.Name = "Düğüm46"
        TreeNode53.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode53.Text = "Tanımlar"
        TreeNode54.ForeColor = System.Drawing.Color.Navy
        TreeNode54.Name = "Düğüm52"
        TreeNode54.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode54.Text = "Masraf Girişi"
        TreeNode55.ForeColor = System.Drawing.Color.Navy
        TreeNode55.Name = "Düğüm55"
        TreeNode55.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode55.Text = "Masraf Grup Ekstresi"
        TreeNode56.ForeColor = System.Drawing.Color.Navy
        TreeNode56.Name = "Düğüm56"
        TreeNode56.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode56.Text = "Masraf Grup Bakiye Listesi"
        TreeNode57.ForeColor = System.Drawing.Color.Navy
        TreeNode57.Name = "Düğüm57"
        TreeNode57.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode57.Text = "Masraf Ekstresi"
        TreeNode58.ForeColor = System.Drawing.Color.Navy
        TreeNode58.Name = "Düğüm58"
        TreeNode58.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode58.Text = "Masraf Bakiye Listesi"
        TreeNode59.ForeColor = System.Drawing.Color.Navy
        TreeNode59.Name = "Düğüm54"
        TreeNode59.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode59.Text = "Masraf Raporları"
        TreeNode60.ForeColor = System.Drawing.Color.Navy
        TreeNode60.Name = "Düğüm44"
        TreeNode60.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode60.Text = "Masraf İşlemleri     "
        Me.TreeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode6, TreeNode8, TreeNode15, TreeNode18, TreeNode32, TreeNode46, TreeNode50, TreeNode60})
        Me.TreeView3.Size = New System.Drawing.Size(247, 325)
        Me.TreeView3.TabIndex = 66
        '
        'NavBarGroupControlContainer4
        '
        Me.NavBarGroupControlContainer4.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer4.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer4.Controls.Add(Me.TreeView5)
        Me.NavBarGroupControlContainer4.Name = "NavBarGroupControlContainer4"
        Me.NavBarGroupControlContainer4.Size = New System.Drawing.Size(247, 412)
        Me.NavBarGroupControlContainer4.TabIndex = 3
        '
        'TreeView5
        '
        Me.TreeView5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView5.ForeColor = System.Drawing.Color.Navy
        Me.TreeView5.HideSelection = False
        Me.TreeView5.ItemHeight = 16
        Me.TreeView5.Location = New System.Drawing.Point(0, 0)
        Me.TreeView5.Name = "TreeView5"
        TreeNode61.ForeColor = System.Drawing.Color.Navy
        TreeNode61.Name = "Düğüm0"
        TreeNode61.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode61.Text = "Toptan Alış İşlemleri                    "
        TreeNode62.ForeColor = System.Drawing.Color.Navy
        TreeNode62.Name = "Düğüm1"
        TreeNode62.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode62.Text = "Toptan Alış                                   "
        Me.TreeView5.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode61, TreeNode62})
        Me.TreeView5.Size = New System.Drawing.Size(247, 412)
        Me.TreeView5.TabIndex = 68
        '
        'NavBarGroupControlContainer5
        '
        Me.NavBarGroupControlContainer5.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer5.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer5.Controls.Add(Me.TreeView6)
        Me.NavBarGroupControlContainer5.Name = "NavBarGroupControlContainer5"
        Me.NavBarGroupControlContainer5.Size = New System.Drawing.Size(247, 412)
        Me.NavBarGroupControlContainer5.TabIndex = 4
        '
        'TreeView6
        '
        Me.TreeView6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView6.ForeColor = System.Drawing.Color.Navy
        Me.TreeView6.HideSelection = False
        Me.TreeView6.ItemHeight = 16
        Me.TreeView6.Location = New System.Drawing.Point(0, 0)
        Me.TreeView6.Name = "TreeView6"
        TreeNode63.ForeColor = System.Drawing.Color.Navy
        TreeNode63.Name = "Düğüm0"
        TreeNode63.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode63.Text = "Toptan Satış İşlemleri                                                 "
        TreeNode64.ForeColor = System.Drawing.Color.Navy
        TreeNode64.Name = "Düğüm1"
        TreeNode64.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode64.Text = "Toptan Satış                                 "
        TreeNode65.ForeColor = System.Drawing.Color.Navy
        TreeNode65.Name = "Düğüm2"
        TreeNode65.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode65.Text = "Alış Satış Raporu                    "
        TreeNode66.ForeColor = System.Drawing.Color.Navy
        TreeNode66.Name = "Düğüm3"
        TreeNode66.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode66.Text = "Satış ve Alış Raporu               "
        TreeNode67.ForeColor = System.Drawing.Color.Navy
        TreeNode67.Name = "Düğüm4"
        TreeNode67.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode67.Text = "Genel Analiz Raporları                   "
        Me.TreeView6.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode63, TreeNode64, TreeNode65, TreeNode66, TreeNode67})
        Me.TreeView6.ShowPlusMinus = False
        Me.TreeView6.Size = New System.Drawing.Size(247, 412)
        Me.TreeView6.TabIndex = 69
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer2.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer2.Controls.Add(Me.TreeView2)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(247, 325)
        Me.NavBarGroupControlContainer2.TabIndex = 6
        '
        'TreeView2
        '
        Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView2.ForeColor = System.Drawing.Color.Navy
        Me.TreeView2.FullRowSelect = True
        Me.TreeView2.ItemHeight = 16
        Me.TreeView2.Location = New System.Drawing.Point(0, 0)
        Me.TreeView2.Name = "TreeView2"
        TreeNode68.Name = "Düğüm3"
        TreeNode68.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode68.Text = "Stoklar"
        TreeNode69.Name = "Düğüm4"
        TreeNode69.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode69.Text = "Stok Tanımı"
        TreeNode70.Name = "Düğüm5"
        TreeNode70.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode70.Text = "Stok Birim Tanımı"
        TreeNode71.Name = "Düğüm6"
        TreeNode71.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode71.Text = "Depo/Ambar Tanımı"
        TreeNode72.Name = "Düğüm7"
        TreeNode72.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode72.Text = "Stok Grupları Tanımı"
        TreeNode73.Name = "Düğüm8"
        TreeNode73.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode73.Text = "Stok Tür Tanımı"
        TreeNode74.Name = "Düğüm1"
        TreeNode74.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode74.Text = "Stok Tanımları                                           "
        TreeNode75.Name = "Düğüm9"
        TreeNode75.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode75.Text = "Stok Hareket Fişleri"
        TreeNode76.Name = "Düğüm10"
        TreeNode76.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode76.Text = "Stok Çıkış Fişi"
        TreeNode77.Name = "Düğüm11"
        TreeNode77.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode77.Text = "Stok Giriş Fişi"
        TreeNode78.Name = "Düğüm12"
        TreeNode78.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode78.Text = "Stok Transfer Fişi"
        TreeNode79.Name = "Düğüm2"
        TreeNode79.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode79.Text = "Stok İşlemleri                                   "
        TreeNode80.Name = "Düğüm13"
        TreeNode80.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode80.Text = "Stok Fiyat Listesi"
        TreeNode81.Name = "Düğüm14"
        TreeNode81.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode81.Text = "Kayıtlı Stok Listesi"
        TreeNode82.Name = "Düğüm16"
        TreeNode82.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode82.Text = "Stok Ekstresi"
        TreeNode83.Name = "Düğüm17"
        TreeNode83.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode83.Text = "Stok Giriş-Çıkış Raporu"
        TreeNode84.Name = "Düğüm18"
        TreeNode84.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode84.Text = "Stok Bazında Cari Hareketler"
        TreeNode85.Name = "Düğüm19"
        TreeNode85.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode85.Text = "Stok Hareketleri"
        TreeNode86.Name = "Düğüm20"
        TreeNode86.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode86.Text = "Stok Değer Raporu"
        TreeNode87.Name = "Düğüm0"
        TreeNode87.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode87.Text = "Stok Raporları                                    "
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode74, TreeNode79, TreeNode87})
        Me.TreeView2.Size = New System.Drawing.Size(247, 325)
        Me.TreeView2.TabIndex = 65
        '
        'NavBarGroupControlContainer6
        '
        Me.NavBarGroupControlContainer6.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer6.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer6.Controls.Add(Me.TreeView4)
        Me.NavBarGroupControlContainer6.Name = "NavBarGroupControlContainer6"
        Me.NavBarGroupControlContainer6.Size = New System.Drawing.Size(247, 412)
        Me.NavBarGroupControlContainer6.TabIndex = 7
        '
        'TreeView4
        '
        Me.TreeView4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TreeView4.ForeColor = System.Drawing.Color.Navy
        Me.TreeView4.HideSelection = False
        Me.TreeView4.ItemHeight = 16
        Me.TreeView4.Location = New System.Drawing.Point(0, 0)
        Me.TreeView4.Name = "TreeView4"
        TreeNode88.ForeColor = System.Drawing.Color.Navy
        TreeNode88.Name = "Düğüm0"
        TreeNode88.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode88.Text = "Perakende Satış Fişi                                   "
        TreeNode89.ForeColor = System.Drawing.Color.Navy
        TreeNode89.Name = "Düğüm1"
        TreeNode89.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode89.Text = "Perakende Alış Fişi                                    "
        TreeNode90.ForeColor = System.Drawing.Color.Navy
        TreeNode90.Name = "Düğüm2"
        TreeNode90.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode90.Text = "Perakende Satış Özeti   "
        TreeNode91.ForeColor = System.Drawing.Color.Navy
        TreeNode91.Name = "Düğüm3"
        TreeNode91.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode91.Text = "Gün Sonu Raporu  "
        Me.TreeView4.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode88, TreeNode89, TreeNode90, TreeNode91})
        Me.TreeView4.Size = New System.Drawing.Size(247, 412)
        Me.TreeView4.TabIndex = 67
        '
        'NavBarGroupControlContainer7
        '
        Me.NavBarGroupControlContainer7.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer7.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer7.Controls.Add(Me.TreeView7)
        Me.NavBarGroupControlContainer7.Name = "NavBarGroupControlContainer7"
        Me.NavBarGroupControlContainer7.Size = New System.Drawing.Size(247, 385)
        Me.NavBarGroupControlContainer7.TabIndex = 8
        '
        'TreeView7
        '
        Me.TreeView7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView7.ForeColor = System.Drawing.Color.Navy
        Me.TreeView7.HideSelection = False
        Me.TreeView7.ItemHeight = 16
        Me.TreeView7.Location = New System.Drawing.Point(0, 0)
        Me.TreeView7.Name = "TreeView7"
        TreeNode92.ForeColor = System.Drawing.Color.Navy
        TreeNode92.Name = "Düğüm0"
        TreeNode92.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode92.Text = "Tamirat Girişi     "
        TreeNode93.ForeColor = System.Drawing.Color.Navy
        TreeNode93.Name = "Düğüm3"
        TreeNode93.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode93.Text = "Tamirat Listesi    "
        TreeNode94.ForeColor = System.Drawing.Color.Navy
        TreeNode94.Name = "Düğüm2"
        TreeNode94.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode94.Text = "Tamirat Raporları          "
        TreeNode95.ForeColor = System.Drawing.Color.Navy
        TreeNode95.Name = "Düğüm1"
        TreeNode95.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode95.Text = "Tamirat İşlemleri                              "
        TreeNode96.ForeColor = System.Drawing.Color.Navy
        TreeNode96.Name = "Düğüm5"
        TreeNode96.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode96.Text = "Garanti Sertifika Girişi             "
        TreeNode97.ForeColor = System.Drawing.Color.Navy
        TreeNode97.Name = "Düğüm4"
        TreeNode97.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode97.Text = "Garanti Sertifika İşlemleri        "
        TreeNode98.ForeColor = System.Drawing.Color.Navy
        TreeNode98.Name = "Düğüm7"
        TreeNode98.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode98.Text = "Stok Servis Kontrol                     "
        TreeNode99.ForeColor = System.Drawing.Color.Navy
        TreeNode99.Name = "Düğüm8"
        TreeNode99.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode99.Text = "Cari Servis Kontrol           "
        TreeNode100.ForeColor = System.Drawing.Color.Navy
        TreeNode100.Name = "Düğüm9"
        TreeNode100.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode100.Text = "Silinen Kayıtlar         "
        TreeNode101.ForeColor = System.Drawing.Color.Navy
        TreeNode101.Name = "Düğüm6"
        TreeNode101.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode101.Text = "Servis İşlemleri        "
        Me.TreeView7.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode95, TreeNode97, TreeNode101})
        Me.TreeView7.Size = New System.Drawing.Size(247, 385)
        Me.TreeView7.TabIndex = 70
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "Ürün Yönetimi"
        Me.NavBarGroup4.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup4.GroupClientHeight = 289
        Me.NavBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup4.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.boproductgroup_32x32
        Me.NavBarGroup4.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.boproductgroup_16x16
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'NavBarGroup12
        '
        Me.NavBarGroup12.Caption = "Perakende Satış"
        Me.NavBarGroup12.ControlContainer = Me.NavBarGroupControlContainer6
        Me.NavBarGroup12.GroupClientHeight = 262
        Me.NavBarGroup12.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup12.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.boorderitem_32x32
        Me.NavBarGroup12.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.boorderitem_16x16
        Me.NavBarGroup12.Name = "NavBarGroup12"
        '
        'NavBarGroup7
        '
        Me.NavBarGroup7.Caption = "Satın Alma"
        Me.NavBarGroup7.ControlContainer = Me.NavBarGroupControlContainer4
        Me.NavBarGroup7.GroupClientHeight = 262
        Me.NavBarGroup7.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup7.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.boposition2_32x32
        Me.NavBarGroup7.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.boposition2_16x16
        Me.NavBarGroup7.Name = "NavBarGroup7"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Üretim Yönetimi"
        Me.NavBarGroup2.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.bopivotchart_32x32
        Me.NavBarGroup2.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.bopivotchart_16x16
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "İnsan Kaynakları"
        Me.NavBarGroup3.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.usergroup_32x32
        Me.NavBarGroup3.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.usergroup_16x16
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'NavBarGroup8
        '
        Me.NavBarGroup8.Caption = "Satış Pazarlama"
        Me.NavBarGroup8.ControlContainer = Me.NavBarGroupControlContainer5
        Me.NavBarGroup8.GroupClientHeight = 262
        Me.NavBarGroup8.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup8.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.bosaleitem_32x32
        Me.NavBarGroup8.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.bosaleitem_16x16
        Me.NavBarGroup8.Name = "NavBarGroup8"
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Caption = "Genel Muhasebe"
        Me.NavBarGroup5.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.accounting_32x32
        Me.NavBarGroup5.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.accounting_16x16
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Servis Destek"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer7
        Me.NavBarGroup1.GroupClientHeight = 262
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.bodepartment_32x32
        Me.NavBarGroup1.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.bodepartment_16x16
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'ımageList1
        '
        Me.ımageList1.ImageStream = CType(resources.GetObject("ımageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList1.Images.SetKeyName(0, "Logo.jpg")
        '
        'TreeListColumn3
        '
        Me.TreeListColumn3.Name = "TreeListColumn3"
        Me.TreeListColumn3.Visible = True
        Me.TreeListColumn3.VisibleIndex = 0
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "Tanımlar"
        Me.TreeListColumn1.FieldName = "Tanımlar"
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.Visible = True
        Me.TreeListColumn1.VisibleIndex = 0
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Expanded = True
        Me.AccordionControlElement2.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "Cari Hesap İşlemleri"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Controller = Me.BarAndDockingController1
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(249, 25)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 652)
        Me.SplitterControl1.TabIndex = 55
        Me.SplitterControl1.TabStop = False
        '
        'TreeListBand1
        '
        Me.TreeListBand1.Caption = "TreeListBand1"
        Me.TreeListBand1.Name = "TreeListBand1"
        '
        'TreeListBand2
        '
        Me.TreeListBand2.Caption = "TreeListBand2"
        Me.TreeListBand2.Name = "TreeListBand2"
        '
        'TreeListBand3
        '
        Me.TreeListBand3.Caption = "TreeListBand3"
        Me.TreeListBand3.Name = "TreeListBand3"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 700)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.NavBarControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dataons ERP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultBarAndDockingController1.Controller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl2.ResumeLayout(False)
        Me.NavBarGroupControlContainer3.ResumeLayout(False)
        Me.NavBarGroupControlContainer4.ResumeLayout(False)
        Me.NavBarGroupControlContainer5.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer6.ResumeLayout(False)
        Me.NavBarGroupControlContainer7.ResumeLayout(False)
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents AccordionControlElement53 As DevExpress.XtraBars.Navigation.AccordionControlElement
    'Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    'Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    'Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    'Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents DefaultBarAndDockingController1 As DevExpress.XtraBars.DefaultBarAndDockingController
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup7 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup8 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer4 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer5 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeListBand1 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents TreeListBand2 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents TreeListBand3 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents ımageList1 As ImageList
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents TreeView3 As TreeView
    Friend WithEvents TreeView5 As TreeView
    Friend WithEvents TreeView6 As TreeView
    Friend WithEvents NavBarGroupControlContainer6 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents TreeView4 As TreeView
    Friend WithEvents NavBarGroupControlContainer7 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents TreeView7 As TreeView
    Friend WithEvents NavBarGroup12 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
End Class
