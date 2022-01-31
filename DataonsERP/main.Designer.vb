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
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.DataonsERP.SplashScreen1), True, True)
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stoklar")
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Tanımı")
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Birim Tanımı")
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Depo/Ambar Tanımı")
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Grupları Tanımı")
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Tür Tanımı")
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Tanımları                                           ", New System.Windows.Forms.TreeNode() {TreeNode101, TreeNode102, TreeNode103, TreeNode104, TreeNode105, TreeNode106})
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Hareket Fişleri")
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Çıkış Fişi")
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Giriş Fişi")
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Transfer Fişi")
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok İşlemleri                                   ", New System.Windows.Forms.TreeNode() {TreeNode108, TreeNode109, TreeNode110, TreeNode111})
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Fiyat Listesi")
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kayıtlı Stok Listesi")
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Ekstresi")
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Giriş-Çıkış Raporu")
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Bazında Cari Hareketler")
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Hareketleri")
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Değer Raporu")
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Raporları                                    ", New System.Windows.Forms.TreeNode() {TreeNode113, TreeNode114, TreeNode115, TreeNode116, TreeNode117, TreeNode118, TreeNode119})
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap                                      ")
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Kartı Tanımı                              ")
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Müşteri Temsilcileri / Satış Elemanı Tanımlama")
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Türü Tanımı")
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Gruları Tanımı")
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Parametre Tanımları                              ", New System.Windows.Forms.TreeNode() {TreeNode123, TreeNode124, TreeNode125})
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap İşlem Fişi")
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap İşlemleri                                ", New System.Windows.Forms.TreeNode() {TreeNode127})
        Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kayıtlı Cari Hesap Listesi")
        Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Ekstresi")
        Dim TreeNode131 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap İşlem Listesi")
        Dim TreeNode132 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Borç / Alacak Listesi")
        Dim TreeNode133 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Borç Yaşlandırma Listesi")
        Dim TreeNode134 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Alacak Yaşlandırma Listesi")
        Dim TreeNode135 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Hesap Raporları                               ", New System.Windows.Forms.TreeNode() {TreeNode129, TreeNode130, TreeNode131, TreeNode132, TreeNode133, TreeNode134})
        Dim TreeNode136 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Döviz Türü Tanımlama     ")
        Dim TreeNode137 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Döviz Kur Girişi      ")
        Dim TreeNode138 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Döviz     ", New System.Windows.Forms.TreeNode() {TreeNode136, TreeNode137})
        Dim TreeNode139 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Tanımı    ")
        Dim TreeNode140 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Açılış İşlemleri")
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Virman Fişi")
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gelen Havale")
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gönderilen Havale")
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bankaya Yatırılan")
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bankadan Çekilen")
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka İşlemleri     ", New System.Windows.Forms.TreeNode() {TreeNode140, TreeNode141, TreeNode142, TreeNode143, TreeNode144, TreeNode145})
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Havale Listesi")
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Nakit Giriş Çıkış")
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Hesap Ekstresi")
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Bakiye Listesi")
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka Raporları", New System.Windows.Forms.TreeNode() {TreeNode147, TreeNode148, TreeNode149, TreeNode150})
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banka   ", New System.Windows.Forms.TreeNode() {TreeNode139, TreeNode146, TreeNode151})
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Tanımı")
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa İşlem Fişi               ")
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Virman Fişi               ")
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tahsilat Fişi                ")
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tediye Fişi                   ")
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kredi Kartlı Tahsilat Girişi                      ")
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kredi Kartlı Ödeme Çıkışı                      ")
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa İşlemleri", New System.Windows.Forms.TreeNode() {TreeNode154, TreeNode155, TreeNode156, TreeNode157, TreeNode158, TreeNode159})
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Hareketleri            ")
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kredi Kartlı İşlemler Listesi             ")
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Hesap Ekstresi         ")
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Bakiye Listesi            ")
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa Raporları", New System.Windows.Forms.TreeNode() {TreeNode161, TreeNode162, TreeNode163, TreeNode164})
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kasa   ", New System.Windows.Forms.TreeNode() {TreeNode153, TreeNode160, TreeNode165})
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alınan Emanet Girişi")
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Verilen Emanet Çıkışı")
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emanet Listesi")
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emanet Hesapları    ", New System.Windows.Forms.TreeNode() {TreeNode167, TreeNode168, TreeNode169})
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Grup Tanımı")
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Kartı Tanımı")
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tanımlar", New System.Windows.Forms.TreeNode() {TreeNode171, TreeNode172})
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Girişi")
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Grup Ekstresi")
        Dim TreeNode176 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Grup Bakiye Listesi")
        Dim TreeNode177 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Ekstresi")
        Dim TreeNode178 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Bakiye Listesi")
        Dim TreeNode179 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf Raporları", New System.Windows.Forms.TreeNode() {TreeNode175, TreeNode176, TreeNode177, TreeNode178})
        Dim TreeNode180 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Masraf İşlemleri     ", New System.Windows.Forms.TreeNode() {TreeNode173, TreeNode174, TreeNode179})
        Dim TreeNode181 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Alış İşlemleri                    ")
        Dim TreeNode182 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Alış                                   ")
        Dim TreeNode183 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Satış İşlemleri                                                 ")
        Dim TreeNode184 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toptan Satış                                 ")
        Dim TreeNode185 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alış Satış Raporu                    ")
        Dim TreeNode186 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Satış ve Alış Raporu               ")
        Dim TreeNode187 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perakende Satış Fişi                                   ")
        Dim TreeNode188 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perakende Alış Fişi                                    ")
        Dim TreeNode189 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perakende Satış Özeti   ")
        Dim TreeNode190 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gün Sonu Raporu  ")
        Dim TreeNode191 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat Girişi     ")
        Dim TreeNode192 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat Listesi    ")
        Dim TreeNode193 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat Raporları          ", New System.Windows.Forms.TreeNode() {TreeNode192})
        Dim TreeNode194 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tamirat İşlemleri                              ", New System.Windows.Forms.TreeNode() {TreeNode191, TreeNode193})
        Dim TreeNode195 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Garanti Sertifika Girişi             ")
        Dim TreeNode196 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Garanti Sertifika İşlemleri        ", New System.Windows.Forms.TreeNode() {TreeNode195})
        Dim TreeNode197 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stok Servis Kontrol                     ")
        Dim TreeNode198 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cari Servis Kontrol           ")
        Dim TreeNode199 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Silinen Kayıtlar         ")
        Dim TreeNode200 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Servis İşlemleri        ", New System.Windows.Forms.TreeNode() {TreeNode197, TreeNode198, TreeNode199})
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView5 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer5 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView6 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer6 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView4 = New System.Windows.Forms.TreeView()
        Me.NavBarGroupControlContainer7 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TreeView7 = New System.Windows.Forms.TreeView()
        Me.NavBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
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
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.NavBarGroupControlContainer3.SuspendLayout()
        Me.NavBarGroupControlContainer4.SuspendLayout()
        Me.NavBarGroupControlContainer5.SuspendLayout()
        Me.NavBarGroupControlContainer6.SuspendLayout()
        Me.NavBarGroupControlContainer7.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 10000
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
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup4
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
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "Ürün Yönetimi"
        Me.NavBarGroup4.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup4.Expanded = True
        Me.NavBarGroup4.GroupClientHeight = 289
        Me.NavBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup4.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.boproductgroup_32x32
        Me.NavBarGroup4.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.boproductgroup_16x16
        Me.NavBarGroup4.Name = "NavBarGroup4"
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
        TreeNode101.Name = "Düğüm3"
        TreeNode101.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode101.Text = "Stoklar"
        TreeNode102.Name = "Düğüm4"
        TreeNode102.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode102.Text = "Stok Tanımı"
        TreeNode103.Name = "Düğüm5"
        TreeNode103.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode103.Text = "Stok Birim Tanımı"
        TreeNode104.Name = "Düğüm6"
        TreeNode104.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode104.Text = "Depo/Ambar Tanımı"
        TreeNode105.Name = "Düğüm7"
        TreeNode105.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode105.Text = "Stok Grupları Tanımı"
        TreeNode106.Name = "Düğüm8"
        TreeNode106.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode106.Text = "Stok Tür Tanımı"
        TreeNode107.Name = "Düğüm1"
        TreeNode107.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode107.Text = "Stok Tanımları                                           "
        TreeNode108.Name = "Düğüm9"
        TreeNode108.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode108.Text = "Stok Hareket Fişleri"
        TreeNode109.Name = "Düğüm10"
        TreeNode109.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode109.Text = "Stok Çıkış Fişi"
        TreeNode110.Name = "Düğüm11"
        TreeNode110.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode110.Text = "Stok Giriş Fişi"
        TreeNode111.Name = "Düğüm12"
        TreeNode111.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode111.Text = "Stok Transfer Fişi"
        TreeNode112.Name = "Düğüm2"
        TreeNode112.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode112.Text = "Stok İşlemleri                                   "
        TreeNode113.Name = "Düğüm13"
        TreeNode113.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode113.Text = "Stok Fiyat Listesi"
        TreeNode114.Name = "Düğüm14"
        TreeNode114.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode114.Text = "Kayıtlı Stok Listesi"
        TreeNode115.Name = "Düğüm16"
        TreeNode115.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode115.Text = "Stok Ekstresi"
        TreeNode116.Name = "Düğüm17"
        TreeNode116.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode116.Text = "Stok Giriş-Çıkış Raporu"
        TreeNode117.Name = "Düğüm18"
        TreeNode117.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode117.Text = "Stok Bazında Cari Hareketler"
        TreeNode118.Name = "Düğüm19"
        TreeNode118.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode118.Text = "Stok Hareketleri"
        TreeNode119.Name = "Düğüm20"
        TreeNode119.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode119.Text = "Stok Değer Raporu"
        TreeNode120.Name = "Düğüm0"
        TreeNode120.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode120.Text = "Stok Raporları                                    "
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode107, TreeNode112, TreeNode120})
        Me.TreeView2.Size = New System.Drawing.Size(247, 325)
        Me.TreeView2.TabIndex = 65
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
        TreeNode121.ForeColor = System.Drawing.Color.Navy
        TreeNode121.Name = "Düğüm1"
        TreeNode121.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode121.Text = "Cari Hesap                                      "
        TreeNode122.ForeColor = System.Drawing.Color.Navy
        TreeNode122.Name = "Düğüm0"
        TreeNode122.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode122.Text = "Cari Hesap Kartı Tanımı                              "
        TreeNode123.ForeColor = System.Drawing.Color.Navy
        TreeNode123.Name = "Düğüm3"
        TreeNode123.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode123.Text = "Müşteri Temsilcileri / Satış Elemanı Tanımlama"
        TreeNode124.ForeColor = System.Drawing.Color.Navy
        TreeNode124.Name = "Düğüm4"
        TreeNode124.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode124.Text = "Cari Hesap Türü Tanımı"
        TreeNode125.ForeColor = System.Drawing.Color.Navy
        TreeNode125.Name = "Düğüm5"
        TreeNode125.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode125.Text = "Cari Hesap Gruları Tanımı"
        TreeNode126.ForeColor = System.Drawing.Color.Navy
        TreeNode126.Name = "Düğümc1"
        TreeNode126.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode126.Text = "Cari Hesap Parametre Tanımları                              "
        TreeNode127.ForeColor = System.Drawing.Color.Navy
        TreeNode127.Name = "Düğüm1"
        TreeNode127.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode127.Text = "Cari Hesap İşlem Fişi"
        TreeNode128.ForeColor = System.Drawing.Color.Navy
        TreeNode128.Name = "Düğüm2"
        TreeNode128.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode128.Text = "Cari Hesap İşlemleri                                "
        TreeNode129.ForeColor = System.Drawing.Color.Navy
        TreeNode129.Name = "Düğüm13"
        TreeNode129.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode129.Text = "Kayıtlı Cari Hesap Listesi"
        TreeNode130.ForeColor = System.Drawing.Color.Navy
        TreeNode130.Name = "Düğüm14"
        TreeNode130.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode130.Text = "Cari Hesap Ekstresi"
        TreeNode131.ForeColor = System.Drawing.Color.Navy
        TreeNode131.Name = "Düğüm15"
        TreeNode131.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode131.Text = "Cari Hesap İşlem Listesi"
        TreeNode132.ForeColor = System.Drawing.Color.Navy
        TreeNode132.Name = "Düğüm16"
        TreeNode132.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode132.Text = "Cari Hesap Borç / Alacak Listesi"
        TreeNode133.ForeColor = System.Drawing.Color.Navy
        TreeNode133.Name = "Düğüm17"
        TreeNode133.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode133.Text = "Cari Hesap Borç Yaşlandırma Listesi"
        TreeNode134.ForeColor = System.Drawing.Color.Navy
        TreeNode134.Name = "Düğüm18"
        TreeNode134.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode134.Text = "Cari Hesap Alacak Yaşlandırma Listesi"
        TreeNode135.ForeColor = System.Drawing.Color.Navy
        TreeNode135.Name = "Düğümc0"
        TreeNode135.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode135.Text = "Cari Hesap Raporları                               "
        TreeNode136.ForeColor = System.Drawing.Color.Navy
        TreeNode136.Name = "Düğüm20"
        TreeNode136.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode136.Text = "Döviz Türü Tanımlama     "
        TreeNode137.ForeColor = System.Drawing.Color.Navy
        TreeNode137.Name = "Düğüm21"
        TreeNode137.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode137.Text = "Döviz Kur Girişi      "
        TreeNode138.ForeColor = System.Drawing.Color.Navy
        TreeNode138.Name = "Düğüm18"
        TreeNode138.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode138.Text = "Döviz     "
        TreeNode139.ForeColor = System.Drawing.Color.Navy
        TreeNode139.Name = "Düğüm23"
        TreeNode139.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode139.Text = "Banka Tanımı    "
        TreeNode140.ForeColor = System.Drawing.Color.Navy
        TreeNode140.Name = "Düğüm25"
        TreeNode140.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode140.Text = "Banka Açılış İşlemleri"
        TreeNode141.ForeColor = System.Drawing.Color.Navy
        TreeNode141.Name = "Düğüm26"
        TreeNode141.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode141.Text = "Banka Virman Fişi"
        TreeNode142.ForeColor = System.Drawing.Color.Navy
        TreeNode142.Name = "Düğüm27"
        TreeNode142.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode142.Text = "Gelen Havale"
        TreeNode143.ForeColor = System.Drawing.Color.Navy
        TreeNode143.Name = "Düğüm28"
        TreeNode143.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode143.Text = "Gönderilen Havale"
        TreeNode144.ForeColor = System.Drawing.Color.Navy
        TreeNode144.Name = "Düğüm29"
        TreeNode144.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode144.Text = "Bankaya Yatırılan"
        TreeNode145.ForeColor = System.Drawing.Color.Navy
        TreeNode145.Name = "Düğüm30"
        TreeNode145.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode145.Text = "Bankadan Çekilen"
        TreeNode146.ForeColor = System.Drawing.Color.Navy
        TreeNode146.Name = "Düğüm24"
        TreeNode146.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode146.Text = "Banka İşlemleri     "
        TreeNode147.ForeColor = System.Drawing.Color.Navy
        TreeNode147.Name = "Düğüm32"
        TreeNode147.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode147.Text = "Banka Havale Listesi"
        TreeNode148.ForeColor = System.Drawing.Color.Navy
        TreeNode148.Name = "Düğüm33"
        TreeNode148.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode148.Text = "Banka Nakit Giriş Çıkış"
        TreeNode149.ForeColor = System.Drawing.Color.Navy
        TreeNode149.Name = "Düğüm34"
        TreeNode149.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode149.Text = "Banka Hesap Ekstresi"
        TreeNode150.ForeColor = System.Drawing.Color.Navy
        TreeNode150.Name = "Düğüm35"
        TreeNode150.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode150.Text = "Banka Bakiye Listesi"
        TreeNode151.ForeColor = System.Drawing.Color.Navy
        TreeNode151.Name = "Düğüm31"
        TreeNode151.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode151.Text = "Banka Raporları"
        TreeNode152.ForeColor = System.Drawing.Color.Navy
        TreeNode152.Name = "Düğüm22"
        TreeNode152.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode152.Text = "Banka   "
        TreeNode153.ForeColor = System.Drawing.Color.Navy
        TreeNode153.Name = "Düğüm37"
        TreeNode153.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode153.Text = "Kasa Tanımı"
        TreeNode154.ForeColor = System.Drawing.Color.Navy
        TreeNode154.Name = "Düğümk0"
        TreeNode154.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode154.Text = "Kasa İşlem Fişi               "
        TreeNode155.ForeColor = System.Drawing.Color.Navy
        TreeNode155.Name = "Düğümk3"
        TreeNode155.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode155.Text = "Kasa Virman Fişi               "
        TreeNode156.ForeColor = System.Drawing.Color.Navy
        TreeNode156.Name = "Düğümk4"
        TreeNode156.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode156.Text = "Tahsilat Fişi                "
        TreeNode157.ForeColor = System.Drawing.Color.Navy
        TreeNode157.Name = "Düğümk5"
        TreeNode157.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode157.Text = "Tediye Fişi                   "
        TreeNode158.ForeColor = System.Drawing.Color.Navy
        TreeNode158.Name = "Düğümk6"
        TreeNode158.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode158.Text = "Kredi Kartlı Tahsilat Girişi                      "
        TreeNode159.ForeColor = System.Drawing.Color.Navy
        TreeNode159.Name = "Düğümk7"
        TreeNode159.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode159.Text = "Kredi Kartlı Ödeme Çıkışı                      "
        TreeNode160.ForeColor = System.Drawing.Color.Navy
        TreeNode160.Name = "Düğüm38"
        TreeNode160.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode160.Text = "Kasa İşlemleri"
        TreeNode161.ForeColor = System.Drawing.Color.Navy
        TreeNode161.Name = "Düğüm0k"
        TreeNode161.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode161.Text = "Kasa Hareketleri            "
        TreeNode162.ForeColor = System.Drawing.Color.Navy
        TreeNode162.Name = "Düğüm1k"
        TreeNode162.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode162.Text = "Kredi Kartlı İşlemler Listesi             "
        TreeNode163.ForeColor = System.Drawing.Color.Navy
        TreeNode163.Name = "Düğüm2k"
        TreeNode163.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode163.Text = "Kasa Hesap Ekstresi         "
        TreeNode164.ForeColor = System.Drawing.Color.Navy
        TreeNode164.Name = "Düğüm3k"
        TreeNode164.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode164.Text = "Kasa Bakiye Listesi            "
        TreeNode165.ForeColor = System.Drawing.Color.Navy
        TreeNode165.Name = "Düğüm39"
        TreeNode165.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode165.Text = "Kasa Raporları"
        TreeNode166.ForeColor = System.Drawing.Color.Navy
        TreeNode166.Name = "Düğüm36"
        TreeNode166.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode166.Text = "Kasa   "
        TreeNode167.ForeColor = System.Drawing.Color.Navy
        TreeNode167.Name = "Düğüm41"
        TreeNode167.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode167.Text = "Alınan Emanet Girişi"
        TreeNode168.ForeColor = System.Drawing.Color.Navy
        TreeNode168.Name = "Düğüm42"
        TreeNode168.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode168.Text = "Verilen Emanet Çıkışı"
        TreeNode169.ForeColor = System.Drawing.Color.Navy
        TreeNode169.Name = "Düğüm43"
        TreeNode169.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode169.Text = "Emanet Listesi"
        TreeNode170.ForeColor = System.Drawing.Color.Navy
        TreeNode170.Name = "Düğüm40"
        TreeNode170.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode170.Text = "Emanet Hesapları    "
        TreeNode171.ForeColor = System.Drawing.Color.Navy
        TreeNode171.Name = "Düğüm49"
        TreeNode171.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode171.Text = "Masraf Grup Tanımı"
        TreeNode172.ForeColor = System.Drawing.Color.Navy
        TreeNode172.Name = "Düğüm51"
        TreeNode172.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode172.Text = "Masraf Kartı Tanımı"
        TreeNode173.ForeColor = System.Drawing.Color.Navy
        TreeNode173.Name = "Düğüm46"
        TreeNode173.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode173.Text = "Tanımlar"
        TreeNode174.ForeColor = System.Drawing.Color.Navy
        TreeNode174.Name = "Düğüm52"
        TreeNode174.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode174.Text = "Masraf Girişi"
        TreeNode175.ForeColor = System.Drawing.Color.Navy
        TreeNode175.Name = "Düğüm55"
        TreeNode175.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode175.Text = "Masraf Grup Ekstresi"
        TreeNode176.ForeColor = System.Drawing.Color.Navy
        TreeNode176.Name = "Düğüm56"
        TreeNode176.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode176.Text = "Masraf Grup Bakiye Listesi"
        TreeNode177.ForeColor = System.Drawing.Color.Navy
        TreeNode177.Name = "Düğüm57"
        TreeNode177.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode177.Text = "Masraf Ekstresi"
        TreeNode178.ForeColor = System.Drawing.Color.Navy
        TreeNode178.Name = "Düğüm58"
        TreeNode178.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode178.Text = "Masraf Bakiye Listesi"
        TreeNode179.ForeColor = System.Drawing.Color.Navy
        TreeNode179.Name = "Düğüm54"
        TreeNode179.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode179.Text = "Masraf Raporları"
        TreeNode180.ForeColor = System.Drawing.Color.Navy
        TreeNode180.Name = "Düğüm44"
        TreeNode180.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode180.Text = "Masraf İşlemleri     "
        Me.TreeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode121, TreeNode122, TreeNode126, TreeNode128, TreeNode135, TreeNode138, TreeNode152, TreeNode166, TreeNode170, TreeNode180})
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
        TreeNode181.ForeColor = System.Drawing.Color.Navy
        TreeNode181.Name = "Düğüm0"
        TreeNode181.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode181.Text = "Toptan Alış İşlemleri                    "
        TreeNode182.ForeColor = System.Drawing.Color.Navy
        TreeNode182.Name = "Düğüm1"
        TreeNode182.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode182.Text = "Toptan Alış                                   "
        Me.TreeView5.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode181, TreeNode182})
        Me.TreeView5.Size = New System.Drawing.Size(247, 412)
        Me.TreeView5.TabIndex = 68
        '
        'NavBarGroupControlContainer5
        '
        Me.NavBarGroupControlContainer5.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer5.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer5.Controls.Add(Me.TreeView6)
        Me.NavBarGroupControlContainer5.Name = "NavBarGroupControlContainer5"
        Me.NavBarGroupControlContainer5.Size = New System.Drawing.Size(247, 325)
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
        TreeNode183.ForeColor = System.Drawing.Color.Navy
        TreeNode183.Name = "Düğüm0"
        TreeNode183.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode183.Text = "Toptan Satış İşlemleri                                                 "
        TreeNode184.ForeColor = System.Drawing.Color.Navy
        TreeNode184.Name = "Düğüm1"
        TreeNode184.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode184.Text = "Toptan Satış                                 "
        TreeNode185.ForeColor = System.Drawing.Color.Navy
        TreeNode185.Name = "Düğüm2"
        TreeNode185.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode185.Text = "Alış Satış Raporu                    "
        TreeNode186.ForeColor = System.Drawing.Color.Navy
        TreeNode186.Name = "Düğüm3"
        TreeNode186.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode186.Text = "Satış ve Alış Raporu               "
        Me.TreeView6.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode183, TreeNode184, TreeNode185, TreeNode186})
        Me.TreeView6.ShowPlusMinus = False
        Me.TreeView6.Size = New System.Drawing.Size(247, 325)
        Me.TreeView6.TabIndex = 69
        '
        'NavBarGroupControlContainer6
        '
        Me.NavBarGroupControlContainer6.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer6.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer6.Controls.Add(Me.TreeView4)
        Me.NavBarGroupControlContainer6.Name = "NavBarGroupControlContainer6"
        Me.NavBarGroupControlContainer6.Size = New System.Drawing.Size(247, 325)
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
        TreeNode187.ForeColor = System.Drawing.Color.Navy
        TreeNode187.Name = "Düğüm0"
        TreeNode187.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TreeNode187.Text = "Perakende Satış Fişi                                   "
        TreeNode188.ForeColor = System.Drawing.Color.Navy
        TreeNode188.Name = "Düğüm1"
        TreeNode188.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode188.Text = "Perakende Alış Fişi                                    "
        TreeNode189.ForeColor = System.Drawing.Color.Navy
        TreeNode189.Name = "Düğüm2"
        TreeNode189.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode189.Text = "Perakende Satış Özeti   "
        TreeNode190.ForeColor = System.Drawing.Color.Navy
        TreeNode190.Name = "Düğüm3"
        TreeNode190.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode190.Text = "Gün Sonu Raporu  "
        Me.TreeView4.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode187, TreeNode188, TreeNode189, TreeNode190})
        Me.TreeView4.Size = New System.Drawing.Size(247, 325)
        Me.TreeView4.TabIndex = 67
        '
        'NavBarGroupControlContainer7
        '
        Me.NavBarGroupControlContainer7.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.NavBarGroupControlContainer7.Appearance.Options.UseBackColor = True
        Me.NavBarGroupControlContainer7.Controls.Add(Me.TreeView7)
        Me.NavBarGroupControlContainer7.Name = "NavBarGroupControlContainer7"
        Me.NavBarGroupControlContainer7.Size = New System.Drawing.Size(247, 325)
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
        TreeNode191.ForeColor = System.Drawing.Color.Navy
        TreeNode191.Name = "Düğüm0"
        TreeNode191.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode191.Text = "Tamirat Girişi     "
        TreeNode192.ForeColor = System.Drawing.Color.Navy
        TreeNode192.Name = "Düğüm3"
        TreeNode192.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode192.Text = "Tamirat Listesi    "
        TreeNode193.ForeColor = System.Drawing.Color.Navy
        TreeNode193.Name = "Düğüm2"
        TreeNode193.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode193.Text = "Tamirat Raporları          "
        TreeNode194.ForeColor = System.Drawing.Color.Navy
        TreeNode194.Name = "Düğüm1"
        TreeNode194.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode194.Text = "Tamirat İşlemleri                              "
        TreeNode195.ForeColor = System.Drawing.Color.Navy
        TreeNode195.Name = "Düğüm5"
        TreeNode195.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode195.Text = "Garanti Sertifika Girişi             "
        TreeNode196.ForeColor = System.Drawing.Color.Navy
        TreeNode196.Name = "Düğüm4"
        TreeNode196.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode196.Text = "Garanti Sertifika İşlemleri        "
        TreeNode197.ForeColor = System.Drawing.Color.Navy
        TreeNode197.Name = "Düğüm7"
        TreeNode197.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode197.Text = "Stok Servis Kontrol                     "
        TreeNode198.ForeColor = System.Drawing.Color.Navy
        TreeNode198.Name = "Düğüm8"
        TreeNode198.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode198.Text = "Cari Servis Kontrol           "
        TreeNode199.ForeColor = System.Drawing.Color.Navy
        TreeNode199.Name = "Düğüm9"
        TreeNode199.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode199.Text = "Silinen Kayıtlar         "
        TreeNode200.ForeColor = System.Drawing.Color.Navy
        TreeNode200.Name = "Düğüm6"
        TreeNode200.NodeFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        TreeNode200.Text = "Servis İşlemleri        "
        Me.TreeView7.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode194, TreeNode196, TreeNode200})
        Me.TreeView7.Size = New System.Drawing.Size(247, 325)
        Me.TreeView7.TabIndex = 70
        '
        'NavBarGroup6
        '
        Me.NavBarGroup6.Caption = "Finansman Yönetimi"
        Me.NavBarGroup6.ControlContainer = Me.NavBarGroupControlContainer3
        Me.NavBarGroup6.GroupClientHeight = 289
        Me.NavBarGroup6.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup6.ImageOptions.LargeImage = Global.DataonsERP.My.Resources.Resources.currency_32x32
        Me.NavBarGroup6.ImageOptions.SmallImage = Global.DataonsERP.My.Resources.Resources.currency_16x16
        Me.NavBarGroup6.Name = "NavBarGroup6"
        ToolTipItem2.Text = "Deneme"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.NavBarGroup6.SuperTip = SuperToolTip2
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
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer3.ResumeLayout(False)
        Me.NavBarGroupControlContainer4.ResumeLayout(False)
        Me.NavBarGroupControlContainer5.ResumeLayout(False)
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
