﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrzyjęcieMagazynowe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrzyjęcieMagazynowe))
        Me.TXTNumerMagazynowy = New System.Windows.Forms.TextBox()
        Me.TxtMaterial = New System.Windows.Forms.TextBox()
        Me.TxtGrubosc = New System.Windows.Forms.TextBox()
        Me.TxtIloscDostepna = New System.Windows.Forms.TextBox()
        Me.TxtIloscRezerwacja = New System.Windows.Forms.TextBox()
        Me.TxtIloscZuzyta = New System.Windows.Forms.TextBox()
        Me.TxtX = New System.Windows.Forms.TextBox()
        Me.TxtY = New System.Windows.Forms.TextBox()
        Me.TxtPriorytet = New System.Windows.Forms.TextBox()
        Me.LblNrMag = New System.Windows.Forms.Label()
        Me.LblMaterial = New System.Windows.Forms.Label()
        Me.LblGrubosc = New System.Windows.Forms.Label()
        Me.LblIloscDostepna = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.LabelY = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtJednostki = New System.Windows.Forms.TextBox()
        Me.TxtPole_uzytkownika2 = New System.Windows.Forms.TextBox()
        Me.TxtKlient = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtWytop = New System.Windows.Forms.TextBox()
        Me.TxtAtest = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtWz = New System.Windows.Forms.TextBox()
        Me.TxtDataPrzyjecia = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TxtPowierzony = New System.Windows.Forms.ComboBox()
        Me.CBAdmin = New System.Windows.Forms.CheckBox()
        Me.TxtPoleUzytkownika = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtLokalizacja = New System.Windows.Forms.TextBox()
        Me.labelLokalizacja = New System.Windows.Forms.Label()
        Me.TxtSciezkaBarcode = New System.Windows.Forms.TextBox()
        Me.LblKatalogDoZapisuBarcodow = New System.Windows.Forms.Label()
        Me.CBNumerMagazynowy = New System.Windows.Forms.CheckBox()
        Me.CbMaterial = New System.Windows.Forms.CheckBox()
        Me.CBGrubosc = New System.Windows.Forms.CheckBox()
        Me.CBWymiar = New System.Windows.Forms.CheckBox()
        Me.LblUstawieniaKoduKreskowego = New System.Windows.Forms.Label()
        Me.Barcode1 = New BarcodeLib.Barcode.WinForms.QRCodeWinForm()
        Me.BtnGenerujKod = New System.Windows.Forms.Button()
        Me.CBZrobBarcody = New System.Windows.Forms.CheckBox()
        Me.BtnOtworzPlik = New System.Windows.Forms.Button()
        Me.BtnZatwierdzZuzyte = New System.Windows.Forms.Button()
        Me.LblDodajiloscZuzytych = New System.Windows.Forms.Label()
        Me.TxtDodajIloscZuzytych = New System.Windows.Forms.TextBox()
        Me.BtnZatwierdzEdycje = New System.Windows.Forms.Button()
        Me.TxtIDAkcji = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTNumerMagazynowy
        '
        Me.TXTNumerMagazynowy.Enabled = False
        Me.TXTNumerMagazynowy.Location = New System.Drawing.Point(117, 60)
        Me.TXTNumerMagazynowy.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTNumerMagazynowy.Name = "TXTNumerMagazynowy"
        Me.TXTNumerMagazynowy.Size = New System.Drawing.Size(204, 20)
        Me.TXTNumerMagazynowy.TabIndex = 0
        '
        'TxtMaterial
        '
        Me.TxtMaterial.Location = New System.Drawing.Point(117, 104)
        Me.TxtMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMaterial.Name = "TxtMaterial"
        Me.TxtMaterial.Size = New System.Drawing.Size(204, 20)
        Me.TxtMaterial.TabIndex = 1
        Me.TxtMaterial.Text = "Mild Steel"
        '
        'TxtGrubosc
        '
        Me.TxtGrubosc.Location = New System.Drawing.Point(117, 146)
        Me.TxtGrubosc.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtGrubosc.Name = "TxtGrubosc"
        Me.TxtGrubosc.Size = New System.Drawing.Size(204, 20)
        Me.TxtGrubosc.TabIndex = 2
        Me.TxtGrubosc.Text = "1"
        '
        'TxtIloscDostepna
        '
        Me.TxtIloscDostepna.Location = New System.Drawing.Point(117, 184)
        Me.TxtIloscDostepna.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIloscDostepna.Name = "TxtIloscDostepna"
        Me.TxtIloscDostepna.Size = New System.Drawing.Size(204, 20)
        Me.TxtIloscDostepna.TabIndex = 3
        Me.TxtIloscDostepna.Text = "100"
        '
        'TxtIloscRezerwacja
        '
        Me.TxtIloscRezerwacja.Enabled = False
        Me.TxtIloscRezerwacja.Location = New System.Drawing.Point(117, 223)
        Me.TxtIloscRezerwacja.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIloscRezerwacja.Name = "TxtIloscRezerwacja"
        Me.TxtIloscRezerwacja.Size = New System.Drawing.Size(204, 20)
        Me.TxtIloscRezerwacja.TabIndex = 4
        Me.TxtIloscRezerwacja.Text = "0"
        '
        'TxtIloscZuzyta
        '
        Me.TxtIloscZuzyta.Enabled = False
        Me.TxtIloscZuzyta.Location = New System.Drawing.Point(117, 262)
        Me.TxtIloscZuzyta.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIloscZuzyta.Name = "TxtIloscZuzyta"
        Me.TxtIloscZuzyta.Size = New System.Drawing.Size(204, 20)
        Me.TxtIloscZuzyta.TabIndex = 5
        Me.TxtIloscZuzyta.Text = "0"
        '
        'TxtX
        '
        Me.TxtX.Location = New System.Drawing.Point(388, 228)
        Me.TxtX.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtX.Name = "TxtX"
        Me.TxtX.Size = New System.Drawing.Size(76, 20)
        Me.TxtX.TabIndex = 6
        Me.TxtX.Text = "3000"
        '
        'TxtY
        '
        Me.TxtY.Location = New System.Drawing.Point(502, 228)
        Me.TxtY.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtY.Name = "TxtY"
        Me.TxtY.Size = New System.Drawing.Size(76, 20)
        Me.TxtY.TabIndex = 7
        Me.TxtY.Text = "1500"
        '
        'TxtPriorytet
        '
        Me.TxtPriorytet.Location = New System.Drawing.Point(22, 366)
        Me.TxtPriorytet.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPriorytet.Name = "TxtPriorytet"
        Me.TxtPriorytet.Size = New System.Drawing.Size(76, 20)
        Me.TxtPriorytet.TabIndex = 8
        Me.TxtPriorytet.Text = "5"
        '
        'LblNrMag
        '
        Me.LblNrMag.AutoSize = True
        Me.LblNrMag.BackColor = System.Drawing.Color.Transparent
        Me.LblNrMag.Location = New System.Drawing.Point(22, 60)
        Me.LblNrMag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNrMag.Name = "LblNrMag"
        Me.LblNrMag.Size = New System.Drawing.Size(83, 13)
        Me.LblNrMag.TabIndex = 10
        Me.LblNrMag.Text = "Nr Magazynowy"
        '
        'LblMaterial
        '
        Me.LblMaterial.AutoSize = True
        Me.LblMaterial.BackColor = System.Drawing.Color.Transparent
        Me.LblMaterial.Location = New System.Drawing.Point(22, 108)
        Me.LblMaterial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMaterial.Name = "LblMaterial"
        Me.LblMaterial.Size = New System.Drawing.Size(46, 13)
        Me.LblMaterial.TabIndex = 11
        Me.LblMaterial.Text = "Materiał"
        '
        'LblGrubosc
        '
        Me.LblGrubosc.AutoSize = True
        Me.LblGrubosc.BackColor = System.Drawing.Color.Transparent
        Me.LblGrubosc.Location = New System.Drawing.Point(22, 149)
        Me.LblGrubosc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblGrubosc.Name = "LblGrubosc"
        Me.LblGrubosc.Size = New System.Drawing.Size(47, 13)
        Me.LblGrubosc.TabIndex = 12
        Me.LblGrubosc.Text = "Grubość"
        '
        'LblIloscDostepna
        '
        Me.LblIloscDostepna.AutoSize = True
        Me.LblIloscDostepna.BackColor = System.Drawing.Color.Transparent
        Me.LblIloscDostepna.Location = New System.Drawing.Point(22, 184)
        Me.LblIloscDostepna.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblIloscDostepna.Name = "LblIloscDostepna"
        Me.LblIloscDostepna.Size = New System.Drawing.Size(78, 13)
        Me.LblIloscDostepna.TabIndex = 13
        Me.LblIloscDostepna.Text = "Ilość Dostępna"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(22, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ilość Rezerwacja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(22, 265)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ilość Zużyta"
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.BackColor = System.Drawing.Color.Transparent
        Me.LabelX.Location = New System.Drawing.Point(371, 226)
        Me.LabelX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(14, 13)
        Me.LabelX.TabIndex = 16
        Me.LabelX.Text = "X"
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.BackColor = System.Drawing.Color.Transparent
        Me.LabelY.Location = New System.Drawing.Point(484, 226)
        Me.LabelY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(14, 13)
        Me.LabelY.TabIndex = 17
        Me.LabelY.Text = "Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(22, 338)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Priorytet"
        '
        'TxtJednostki
        '
        Me.TxtJednostki.Location = New System.Drawing.Point(105, 366)
        Me.TxtJednostki.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtJednostki.Name = "TxtJednostki"
        Me.TxtJednostki.Size = New System.Drawing.Size(76, 20)
        Me.TxtJednostki.TabIndex = 19
        Me.TxtJednostki.Text = "mm"
        '
        'TxtPole_uzytkownika2
        '
        Me.TxtPole_uzytkownika2.Location = New System.Drawing.Point(356, 423)
        Me.TxtPole_uzytkownika2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPole_uzytkownika2.Name = "TxtPole_uzytkownika2"
        Me.TxtPole_uzytkownika2.Size = New System.Drawing.Size(76, 20)
        Me.TxtPole_uzytkownika2.TabIndex = 20
        '
        'TxtKlient
        '
        Me.TxtKlient.Location = New System.Drawing.Point(262, 366)
        Me.TxtKlient.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKlient.Name = "TxtKlient"
        Me.TxtKlient.Size = New System.Drawing.Size(87, 20)
        Me.TxtKlient.TabIndex = 21
        Me.TxtKlient.Text = "Verashape"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(105, 338)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Jednostki"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(356, 395)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Pole_uzytkownika2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(262, 338)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Klient"
        '
        'TxtWytop
        '
        Me.TxtWytop.Location = New System.Drawing.Point(356, 366)
        Me.TxtWytop.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtWytop.Name = "TxtWytop"
        Me.TxtWytop.Size = New System.Drawing.Size(76, 20)
        Me.TxtWytop.TabIndex = 25
        Me.TxtWytop.Text = "0123"
        '
        'TxtAtest
        '
        Me.TxtAtest.Location = New System.Drawing.Point(22, 423)
        Me.TxtAtest.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAtest.Name = "TxtAtest"
        Me.TxtAtest.Size = New System.Drawing.Size(76, 20)
        Me.TxtAtest.TabIndex = 26
        Me.TxtAtest.Text = "2.2 wg PN-EN 10204"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(356, 338)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Wytop"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(22, 395)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Atest"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(184, 395)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Wz"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(105, 395)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Data przyjęcia"
        '
        'TxtWz
        '
        Me.TxtWz.Location = New System.Drawing.Point(184, 423)
        Me.TxtWz.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtWz.Name = "TxtWz"
        Me.TxtWz.Size = New System.Drawing.Size(76, 20)
        Me.TxtWz.TabIndex = 30
        Me.TxtWz.Text = "WZ0001"
        '
        'TxtDataPrzyjecia
        '
        Me.TxtDataPrzyjecia.Enabled = False
        Me.TxtDataPrzyjecia.Location = New System.Drawing.Point(105, 423)
        Me.TxtDataPrzyjecia.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDataPrzyjecia.Name = "TxtDataPrzyjecia"
        Me.TxtDataPrzyjecia.Size = New System.Drawing.Size(76, 20)
        Me.TxtDataPrzyjecia.TabIndex = 29
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(374, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(184, 338)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Powierzony"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(25, 578)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(398, 79)
        Me.RichTextBox1.TabIndex = 36
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'TxtPowierzony
        '
        Me.TxtPowierzony.FormattingEnabled = True
        Me.TxtPowierzony.Items.AddRange(New Object() {"0", "1"})
        Me.TxtPowierzony.Location = New System.Drawing.Point(184, 366)
        Me.TxtPowierzony.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPowierzony.Name = "TxtPowierzony"
        Me.TxtPowierzony.Size = New System.Drawing.Size(74, 21)
        Me.TxtPowierzony.TabIndex = 37
        Me.TxtPowierzony.Text = "0"
        '
        'CBAdmin
        '
        Me.CBAdmin.AutoSize = True
        Me.CBAdmin.BackColor = System.Drawing.Color.Transparent
        Me.CBAdmin.Location = New System.Drawing.Point(25, 10)
        Me.CBAdmin.Margin = New System.Windows.Forms.Padding(2)
        Me.CBAdmin.Name = "CBAdmin"
        Me.CBAdmin.Size = New System.Drawing.Size(55, 17)
        Me.CBAdmin.TabIndex = 38
        Me.CBAdmin.Text = "Admin"
        Me.CBAdmin.UseVisualStyleBackColor = False
        '
        'TxtPoleUzytkownika
        '
        Me.TxtPoleUzytkownika.Location = New System.Drawing.Point(262, 423)
        Me.TxtPoleUzytkownika.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPoleUzytkownika.Name = "TxtPoleUzytkownika"
        Me.TxtPoleUzytkownika.Size = New System.Drawing.Size(87, 20)
        Me.TxtPoleUzytkownika.TabIndex = 39
        Me.TxtPoleUzytkownika.Text = "PN-EN 10143"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(262, 395)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Pole Użytkownika"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(455, 578)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(144, 91)
        Me.DataGridView1.TabIndex = 41
        Me.DataGridView1.Visible = False
        '
        'TxtLokalizacja
        '
        Me.TxtLokalizacja.Location = New System.Drawing.Point(388, 261)
        Me.TxtLokalizacja.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtLokalizacja.Name = "TxtLokalizacja"
        Me.TxtLokalizacja.Size = New System.Drawing.Size(76, 20)
        Me.TxtLokalizacja.TabIndex = 42
        '
        'labelLokalizacja
        '
        Me.labelLokalizacja.AutoSize = True
        Me.labelLokalizacja.BackColor = System.Drawing.Color.Transparent
        Me.labelLokalizacja.Location = New System.Drawing.Point(324, 262)
        Me.labelLokalizacja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelLokalizacja.Name = "labelLokalizacja"
        Me.labelLokalizacja.Size = New System.Drawing.Size(60, 13)
        Me.labelLokalizacja.TabIndex = 43
        Me.labelLokalizacja.Text = "Lokalizacja"
        '
        'TxtSciezkaBarcode
        '
        Me.TxtSciezkaBarcode.Location = New System.Drawing.Point(184, 544)
        Me.TxtSciezkaBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSciezkaBarcode.Name = "TxtSciezkaBarcode"
        Me.TxtSciezkaBarcode.Size = New System.Drawing.Size(213, 20)
        Me.TxtSciezkaBarcode.TabIndex = 47
        Me.TxtSciezkaBarcode.Text = "C:\Barcode"
        '
        'LblKatalogDoZapisuBarcodow
        '
        Me.LblKatalogDoZapisuBarcodow.AutoSize = True
        Me.LblKatalogDoZapisuBarcodow.BackColor = System.Drawing.Color.Transparent
        Me.LblKatalogDoZapisuBarcodow.Location = New System.Drawing.Point(22, 547)
        Me.LblKatalogDoZapisuBarcodow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKatalogDoZapisuBarcodow.Name = "LblKatalogDoZapisuBarcodow"
        Me.LblKatalogDoZapisuBarcodow.Size = New System.Drawing.Size(145, 13)
        Me.LblKatalogDoZapisuBarcodow.TabIndex = 48
        Me.LblKatalogDoZapisuBarcodow.Text = "Katalog do zapisu Barcodów:"
        '
        'CBNumerMagazynowy
        '
        Me.CBNumerMagazynowy.AutoSize = True
        Me.CBNumerMagazynowy.BackColor = System.Drawing.Color.Transparent
        Me.CBNumerMagazynowy.Checked = True
        Me.CBNumerMagazynowy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBNumerMagazynowy.Location = New System.Drawing.Point(22, 504)
        Me.CBNumerMagazynowy.Margin = New System.Windows.Forms.Padding(2)
        Me.CBNumerMagazynowy.Name = "CBNumerMagazynowy"
        Me.CBNumerMagazynowy.Size = New System.Drawing.Size(102, 17)
        Me.CBNumerMagazynowy.TabIndex = 49
        Me.CBNumerMagazynowy.Text = "Nr Magazynowy"
        Me.CBNumerMagazynowy.UseVisualStyleBackColor = False
        '
        'CbMaterial
        '
        Me.CbMaterial.AutoSize = True
        Me.CbMaterial.BackColor = System.Drawing.Color.Transparent
        Me.CbMaterial.Location = New System.Drawing.Point(120, 504)
        Me.CbMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.CbMaterial.Name = "CbMaterial"
        Me.CbMaterial.Size = New System.Drawing.Size(65, 17)
        Me.CbMaterial.TabIndex = 50
        Me.CbMaterial.Text = "Materiał"
        Me.CbMaterial.UseVisualStyleBackColor = False
        '
        'CBGrubosc
        '
        Me.CBGrubosc.AutoSize = True
        Me.CBGrubosc.BackColor = System.Drawing.Color.Transparent
        Me.CBGrubosc.Location = New System.Drawing.Point(184, 504)
        Me.CBGrubosc.Margin = New System.Windows.Forms.Padding(2)
        Me.CBGrubosc.Name = "CBGrubosc"
        Me.CBGrubosc.Size = New System.Drawing.Size(66, 17)
        Me.CBGrubosc.TabIndex = 51
        Me.CBGrubosc.Text = "Grubość"
        Me.CBGrubosc.UseVisualStyleBackColor = False
        '
        'CBWymiar
        '
        Me.CBWymiar.AutoSize = True
        Me.CBWymiar.BackColor = System.Drawing.Color.Transparent
        Me.CBWymiar.Location = New System.Drawing.Point(251, 504)
        Me.CBWymiar.Margin = New System.Windows.Forms.Padding(2)
        Me.CBWymiar.Name = "CBWymiar"
        Me.CBWymiar.Size = New System.Drawing.Size(61, 17)
        Me.CBWymiar.TabIndex = 52
        Me.CBWymiar.Text = "Wymiar"
        Me.CBWymiar.UseVisualStyleBackColor = False
        '
        'LblUstawieniaKoduKreskowego
        '
        Me.LblUstawieniaKoduKreskowego.AutoSize = True
        Me.LblUstawieniaKoduKreskowego.BackColor = System.Drawing.Color.Transparent
        Me.LblUstawieniaKoduKreskowego.Location = New System.Drawing.Point(23, 468)
        Me.LblUstawieniaKoduKreskowego.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUstawieniaKoduKreskowego.Name = "LblUstawieniaKoduKreskowego"
        Me.LblUstawieniaKoduKreskowego.Size = New System.Drawing.Size(150, 13)
        Me.LblUstawieniaKoduKreskowego.TabIndex = 53
        Me.LblUstawieniaKoduKreskowego.Text = "Ustawienia kodu kreskowego:"
        '
        'Barcode1
        '
        Me.Barcode1.BackgroundColor = System.Drawing.Color.White
        Me.Barcode1.BottomMargin = 0!
        Me.Barcode1.Data = "QR Code"
        Me.Barcode1.ECI = -1
        Me.Barcode1.ECL = BarcodeLib.Barcode.QRCodeErrorCorrectionLevel.L
        Me.Barcode1.EnableStructuredAppend = False
        Me.Barcode1.Encoding = BarcodeLib.Barcode.QRCodeEncoding.[Auto]
        Me.Barcode1.FNC1Mode = BarcodeLib.Barcode.QRCodeFNC1Mode.NotSupported
        Me.Barcode1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png
        Me.Barcode1.ImageHeight = 0!
        Me.Barcode1.ImageWidth = 0!
        Me.Barcode1.LeftMargin = 0!
        Me.Barcode1.Location = New System.Drawing.Point(578, 514)
        Me.Barcode1.Margin = New System.Windows.Forms.Padding(2)
        Me.Barcode1.ModuleColor = System.Drawing.Color.Black
        Me.Barcode1.ModuleSize = 2.0!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.ProcessTilde = True
        Me.Barcode1.ResizeImage = False
        Me.Barcode1.Resolution = 72
        Me.Barcode1.RightMargin = 0!
        Me.Barcode1.Rotate = BarcodeLib.Barcode.RotateOrientation.BottomFacingDown
        Me.Barcode1.Size = New System.Drawing.Size(42, 42)
        Me.Barcode1.StructuredAppendCount = 0
        Me.Barcode1.StructuredAppendIndex = 0
        Me.Barcode1.TabIndex = 55
        Me.Barcode1.TopMargin = 0!
        Me.Barcode1.UOM = BarcodeLib.Barcode.UnitOfMeasure.PIXEL
        Me.Barcode1.Version = BarcodeLib.Barcode.QRCodeVersion.V1
        Me.Barcode1.Visible = False
        '
        'BtnGenerujKod
        '
        Me.BtnGenerujKod.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnGenerujKod.BackgroundImage = CType(resources.GetObject("BtnGenerujKod.BackgroundImage"), System.Drawing.Image)
        Me.BtnGenerujKod.Location = New System.Drawing.Point(465, 514)
        Me.BtnGenerujKod.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGenerujKod.Name = "BtnGenerujKod"
        Me.BtnGenerujKod.Size = New System.Drawing.Size(108, 36)
        Me.BtnGenerujKod.TabIndex = 56
        Me.BtnGenerujKod.Text = "Generuj kod"
        Me.BtnGenerujKod.UseVisualStyleBackColor = False
        Me.BtnGenerujKod.Visible = False
        '
        'CBZrobBarcody
        '
        Me.CBZrobBarcody.AutoSize = True
        Me.CBZrobBarcody.BackColor = System.Drawing.Color.Transparent
        Me.CBZrobBarcody.Checked = True
        Me.CBZrobBarcody.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBZrobBarcody.Location = New System.Drawing.Point(184, 465)
        Me.CBZrobBarcody.Margin = New System.Windows.Forms.Padding(2)
        Me.CBZrobBarcody.Name = "CBZrobBarcody"
        Me.CBZrobBarcody.Size = New System.Drawing.Size(112, 17)
        Me.CBZrobBarcody.TabIndex = 62
        Me.CBZrobBarcody.Text = "Wł/Wył. Barcode"
        Me.CBZrobBarcody.UseVisualStyleBackColor = False
        '
        'BtnOtworzPlik
        '
        Me.BtnOtworzPlik.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnOtworzPlik.Location = New System.Drawing.Point(400, 544)
        Me.BtnOtworzPlik.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOtworzPlik.Name = "BtnOtworzPlik"
        Me.BtnOtworzPlik.Size = New System.Drawing.Size(24, 19)
        Me.BtnOtworzPlik.TabIndex = 73
        Me.BtnOtworzPlik.Text = "..."
        Me.BtnOtworzPlik.UseVisualStyleBackColor = False
        '
        'BtnZatwierdzZuzyte
        '
        Me.BtnZatwierdzZuzyte.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnZatwierdzZuzyte.BackgroundImage = CType(resources.GetObject("BtnZatwierdzZuzyte.BackgroundImage"), System.Drawing.Image)
        Me.BtnZatwierdzZuzyte.Location = New System.Drawing.Point(469, 358)
        Me.BtnZatwierdzZuzyte.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnZatwierdzZuzyte.Name = "BtnZatwierdzZuzyte"
        Me.BtnZatwierdzZuzyte.Size = New System.Drawing.Size(108, 35)
        Me.BtnZatwierdzZuzyte.TabIndex = 74
        Me.BtnZatwierdzZuzyte.Text = "Zatwierdź zmiany ilości zużytych"
        Me.BtnZatwierdzZuzyte.UseVisualStyleBackColor = False
        '
        'LblDodajiloscZuzytych
        '
        Me.LblDodajiloscZuzytych.AutoSize = True
        Me.LblDodajiloscZuzytych.BackColor = System.Drawing.Color.Transparent
        Me.LblDodajiloscZuzytych.Location = New System.Drawing.Point(22, 299)
        Me.LblDodajiloscZuzytych.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDodajiloscZuzytych.Name = "LblDodajiloscZuzytych"
        Me.LblDodajiloscZuzytych.Size = New System.Drawing.Size(81, 13)
        Me.LblDodajiloscZuzytych.TabIndex = 76
        Me.LblDodajiloscZuzytych.Text = "Dodaj ilość zuż."
        '
        'TxtDodajIloscZuzytych
        '
        Me.TxtDodajIloscZuzytych.Enabled = False
        Me.TxtDodajIloscZuzytych.Location = New System.Drawing.Point(117, 297)
        Me.TxtDodajIloscZuzytych.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDodajIloscZuzytych.Name = "TxtDodajIloscZuzytych"
        Me.TxtDodajIloscZuzytych.Size = New System.Drawing.Size(204, 20)
        Me.TxtDodajIloscZuzytych.TabIndex = 75
        Me.TxtDodajIloscZuzytych.Text = "0"
        '
        'BtnZatwierdzEdycje
        '
        Me.BtnZatwierdzEdycje.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnZatwierdzEdycje.BackgroundImage = CType(resources.GetObject("BtnZatwierdzEdycje.BackgroundImage"), System.Drawing.Image)
        Me.BtnZatwierdzEdycje.Location = New System.Drawing.Point(469, 408)
        Me.BtnZatwierdzEdycje.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnZatwierdzEdycje.Name = "BtnZatwierdzEdycje"
        Me.BtnZatwierdzEdycje.Size = New System.Drawing.Size(108, 40)
        Me.BtnZatwierdzEdycje.TabIndex = 77
        Me.BtnZatwierdzEdycje.Text = "Zatwierdź zmiany po edycji"
        Me.BtnZatwierdzEdycje.UseVisualStyleBackColor = False
        '
        'TxtIDAkcji
        '
        Me.TxtIDAkcji.Location = New System.Drawing.Point(117, 32)
        Me.TxtIDAkcji.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIDAkcji.Name = "TxtIDAkcji"
        Me.TxtIDAkcji.Size = New System.Drawing.Size(204, 20)
        Me.TxtIDAkcji.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(25, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "ID Akcji"
        '
        'PrzyjęcieMagazynowe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Radan_Magazyn_Blach_Moduł_Zarządzający.My.Resources.Resources._14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 666)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtIDAkcji)
        Me.Controls.Add(Me.BtnZatwierdzEdycje)
        Me.Controls.Add(Me.LblDodajiloscZuzytych)
        Me.Controls.Add(Me.TxtDodajIloscZuzytych)
        Me.Controls.Add(Me.BtnZatwierdzZuzyte)
        Me.Controls.Add(Me.BtnOtworzPlik)
        Me.Controls.Add(Me.CBZrobBarcody)
        Me.Controls.Add(Me.BtnGenerujKod)
        Me.Controls.Add(Me.Barcode1)
        Me.Controls.Add(Me.LblUstawieniaKoduKreskowego)
        Me.Controls.Add(Me.CBWymiar)
        Me.Controls.Add(Me.CBGrubosc)
        Me.Controls.Add(Me.CbMaterial)
        Me.Controls.Add(Me.CBNumerMagazynowy)
        Me.Controls.Add(Me.LblKatalogDoZapisuBarcodow)
        Me.Controls.Add(Me.TxtSciezkaBarcode)
        Me.Controls.Add(Me.labelLokalizacja)
        Me.Controls.Add(Me.TxtLokalizacja)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPoleUzytkownika)
        Me.Controls.Add(Me.CBAdmin)
        Me.Controls.Add(Me.TxtPowierzony)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtWz)
        Me.Controls.Add(Me.TxtDataPrzyjecia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtAtest)
        Me.Controls.Add(Me.TxtWytop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtKlient)
        Me.Controls.Add(Me.TxtPole_uzytkownika2)
        Me.Controls.Add(Me.TxtJednostki)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LabelY)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblIloscDostepna)
        Me.Controls.Add(Me.LblGrubosc)
        Me.Controls.Add(Me.LblMaterial)
        Me.Controls.Add(Me.LblNrMag)
        Me.Controls.Add(Me.TxtPriorytet)
        Me.Controls.Add(Me.TxtY)
        Me.Controls.Add(Me.TxtX)
        Me.Controls.Add(Me.TxtIloscZuzyta)
        Me.Controls.Add(Me.TxtIloscRezerwacja)
        Me.Controls.Add(Me.TxtIloscDostepna)
        Me.Controls.Add(Me.TxtGrubosc)
        Me.Controls.Add(Me.TxtMaterial)
        Me.Controls.Add(Me.TXTNumerMagazynowy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PrzyjęcieMagazynowe"
        Me.Text = "PrzyjęcieMagazynowe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTNumerMagazynowy As Windows.Forms.TextBox
    Friend WithEvents TxtMaterial As Windows.Forms.TextBox
    Friend WithEvents TxtGrubosc As Windows.Forms.TextBox
    Friend WithEvents TxtIloscDostepna As Windows.Forms.TextBox
    Friend WithEvents TxtIloscRezerwacja As Windows.Forms.TextBox
    Friend WithEvents TxtIloscZuzyta As Windows.Forms.TextBox
    Friend WithEvents TxtX As Windows.Forms.TextBox
    Friend WithEvents TxtY As Windows.Forms.TextBox
    Friend WithEvents TxtPriorytet As Windows.Forms.TextBox
    Friend WithEvents LblNrMag As Windows.Forms.Label
    Friend WithEvents LblMaterial As Windows.Forms.Label
    Friend WithEvents LblGrubosc As Windows.Forms.Label
    Friend WithEvents LblIloscDostepna As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents LabelX As Windows.Forms.Label
    Friend WithEvents LabelY As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtJednostki As Windows.Forms.TextBox
    Friend WithEvents TxtPole_uzytkownika2 As Windows.Forms.TextBox
    Friend WithEvents TxtKlient As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents TxtWytop As Windows.Forms.TextBox
    Friend WithEvents TxtAtest As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents TxtWz As Windows.Forms.TextBox
    Friend WithEvents TxtDataPrzyjecia As Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
    Friend WithEvents TxtPowierzony As Windows.Forms.ComboBox
    Friend WithEvents CBAdmin As Windows.Forms.CheckBox
    Friend WithEvents TxtPoleUzytkownika As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents TxtLokalizacja As Windows.Forms.TextBox
    Friend WithEvents labelLokalizacja As Windows.Forms.Label
    Friend WithEvents TxtSciezkaBarcode As Windows.Forms.TextBox
    Friend WithEvents LblKatalogDoZapisuBarcodow As Windows.Forms.Label
    Friend WithEvents CBNumerMagazynowy As Windows.Forms.CheckBox
    Friend WithEvents CbMaterial As Windows.Forms.CheckBox
    Friend WithEvents CBGrubosc As Windows.Forms.CheckBox
    Friend WithEvents CBWymiar As Windows.Forms.CheckBox
    Friend WithEvents LblUstawieniaKoduKreskowego As Windows.Forms.Label
    Friend WithEvents Barcode1 As BarcodeLib.Barcode.WinForms.QRCodeWinForm
    Friend WithEvents BtnGenerujKod As Windows.Forms.Button
    Friend WithEvents CBZrobBarcody As Windows.Forms.CheckBox
    Friend WithEvents BtnOtworzPlik As Windows.Forms.Button
    Friend WithEvents BtnZatwierdzZuzyte As Button
    Friend WithEvents LblDodajiloscZuzytych As Label
    Friend WithEvents TxtDodajIloscZuzytych As TextBox
    Friend WithEvents BtnZatwierdzEdycje As Button
    Friend WithEvents TxtIDAkcji As TextBox
    Friend WithEvents Label3 As Label
End Class
