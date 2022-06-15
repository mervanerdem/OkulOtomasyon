namespace OkulOtomasyon
{
    partial class FrmTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeachers));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.okulDataSet = new OkulOtomasyon.OkulDataSet();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CmbxBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbxilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.Cmbxil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.PctResim = new DevExpress.XtraEditors.PictureEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.okulDataSet1 = new OkulOtomasyon.OkulDataSet1();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new OkulOtomasyon.OkulDataSet1TableAdapters.TeachersTableAdapter();
            this.colTeachID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachBrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeachFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbxBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbxilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbxil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctResim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.teachersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1023, 527);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTeachID,
            this.colTeachName,
            this.colTeachSurName,
            this.colTeachTC,
            this.colTeachTel,
            this.colTeachMail,
            this.colTeachIL,
            this.colTeachILCE,
            this.colTeachAdress,
            this.colTeachBrans,
            this.colTeachFoto});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // okulDataSet
            // 
            this.okulDataSet.DataSetName = "OkulDataSet";
            this.okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1028, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(330, 565);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(328, 521);
            this.xtraTabPage1.Text = "Öğretmen Bilgi 1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CmbxBrans);
            this.groupControl1.Controls.Add(this.Cmbxilce);
            this.groupControl1.Controls.Add(this.MskTel);
            this.groupControl1.Controls.Add(this.MskTc);
            this.groupControl1.Controls.Add(this.Cmbxil);
            this.groupControl1.Controls.Add(this.TxtSoyad);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(322, 520);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // CmbxBrans
            // 
            this.CmbxBrans.Location = new System.Drawing.Point(90, 399);
            this.CmbxBrans.Name = "CmbxBrans";
            this.CmbxBrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CmbxBrans.Properties.Appearance.Options.UseFont = true;
            this.CmbxBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbxBrans.Size = new System.Drawing.Size(198, 24);
            this.CmbxBrans.TabIndex = 15;
            // 
            // Cmbxilce
            // 
            this.Cmbxilce.Location = new System.Drawing.Point(90, 349);
            this.Cmbxilce.Name = "Cmbxilce";
            this.Cmbxilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Cmbxilce.Properties.Appearance.Options.UseFont = true;
            this.Cmbxilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbxilce.Size = new System.Drawing.Size(198, 24);
            this.Cmbxilce.TabIndex = 14;
            // 
            // MskTel
            // 
            this.MskTel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTel.Location = new System.Drawing.Point(90, 248);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(198, 25);
            this.MskTel.TabIndex = 13;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTc.Location = new System.Drawing.Point(90, 197);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(198, 25);
            this.MskTc.TabIndex = 12;
            // 
            // Cmbxil
            // 
            this.Cmbxil.Location = new System.Drawing.Point(90, 299);
            this.Cmbxil.Name = "Cmbxil";
            this.Cmbxil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Cmbxil.Properties.Appearance.Options.UseFont = true;
            this.Cmbxil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbxil.Size = new System.Drawing.Size(198, 24);
            this.Cmbxil.TabIndex = 11;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(90, 147);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Size = new System.Drawing.Size(198, 24);
            this.TxtSoyad.TabIndex = 10;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(90, 97);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(198, 24);
            this.TxtAd.TabIndex = 9;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(90, 47);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(198, 24);
            this.TxtID.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(37, 402);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 18);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Branş:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(51, 352);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 18);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İlçe:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(66, 302);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İl:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(54, 255);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Tel:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(55, 200);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "TC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Soyad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ad:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(328, 521);
            this.xtraTabPage2.Text = "Öğretmen Bilgi 2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.BtnKaydet);
            this.groupControl2.Controls.Add(this.BtnGuncelle);
            this.groupControl2.Controls.Add(this.BtnSil);
            this.groupControl2.Controls.Add(this.BtnTemizle);
            this.groupControl2.Controls.Add(this.BtnResimSec);
            this.groupControl2.Controls.Add(this.PctResim);
            this.groupControl2.Controls.Add(this.richTextBox1);
            this.groupControl2.Controls.Add(this.textEdit2);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(322, 481);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKaydet.ImageOptions.SvgImage")));
            this.BtnKaydet.Location = new System.Drawing.Point(81, 296);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(198, 36);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "Kaydet";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnGuncelle.ImageOptions.SvgImage")));
            this.BtnGuncelle.Location = new System.Drawing.Point(81, 332);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(198, 36);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "Güncelle";
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSil.ImageOptions.SvgImage")));
            this.BtnSil.Location = new System.Drawing.Point(81, 368);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(198, 36);
            this.BtnSil.TabIndex = 17;
            this.BtnSil.Text = "Sil";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnTemizle.ImageOptions.SvgImage")));
            this.BtnTemizle.Location = new System.Drawing.Point(81, 404);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(198, 36);
            this.BtnTemizle.TabIndex = 16;
            this.BtnTemizle.Text = "Temizle";
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnResimSec.ImageOptions.SvgImage")));
            this.BtnResimSec.Location = new System.Drawing.Point(81, 260);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(198, 36);
            this.BtnResimSec.TabIndex = 15;
            this.BtnResimSec.Text = "Resim Seç";
            // 
            // PctResim
            // 
            this.PctResim.Location = new System.Drawing.Point(188, 5);
            this.PctResim.Name = "PctResim";
            this.PctResim.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PctResim.Size = new System.Drawing.Size(91, 95);
            this.PctResim.TabIndex = 14;
            this.PctResim.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(81, 143);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 110);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(81, 106);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(198, 24);
            this.textEdit2.TabIndex = 12;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(33, 143);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 18);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Adres:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(46, 109);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(29, 18);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Mail:";
            // 
            // okulDataSet1
            // 
            this.okulDataSet1.DataSetName = "OkulDataSet1";
            this.okulDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.okulDataSet1;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // colTeachID
            // 
            this.colTeachID.FieldName = "TeachID";
            this.colTeachID.Name = "colTeachID";
            this.colTeachID.Visible = true;
            this.colTeachID.VisibleIndex = 0;
            // 
            // colTeachName
            // 
            this.colTeachName.FieldName = "TeachName";
            this.colTeachName.Name = "colTeachName";
            this.colTeachName.Visible = true;
            this.colTeachName.VisibleIndex = 1;
            // 
            // colTeachSurName
            // 
            this.colTeachSurName.FieldName = "TeachSurName";
            this.colTeachSurName.Name = "colTeachSurName";
            this.colTeachSurName.Visible = true;
            this.colTeachSurName.VisibleIndex = 2;
            // 
            // colTeachTC
            // 
            this.colTeachTC.FieldName = "TeachTC";
            this.colTeachTC.Name = "colTeachTC";
            this.colTeachTC.Visible = true;
            this.colTeachTC.VisibleIndex = 3;
            // 
            // colTeachTel
            // 
            this.colTeachTel.FieldName = "TeachTel";
            this.colTeachTel.Name = "colTeachTel";
            this.colTeachTel.Visible = true;
            this.colTeachTel.VisibleIndex = 4;
            // 
            // colTeachMail
            // 
            this.colTeachMail.FieldName = "TeachMail";
            this.colTeachMail.Name = "colTeachMail";
            this.colTeachMail.Visible = true;
            this.colTeachMail.VisibleIndex = 5;
            // 
            // colTeachIL
            // 
            this.colTeachIL.FieldName = "TeachIL";
            this.colTeachIL.Name = "colTeachIL";
            this.colTeachIL.Visible = true;
            this.colTeachIL.VisibleIndex = 6;
            // 
            // colTeachILCE
            // 
            this.colTeachILCE.FieldName = "TeachILCE";
            this.colTeachILCE.Name = "colTeachILCE";
            this.colTeachILCE.Visible = true;
            this.colTeachILCE.VisibleIndex = 7;
            // 
            // colTeachAdress
            // 
            this.colTeachAdress.FieldName = "TeachAdress";
            this.colTeachAdress.Name = "colTeachAdress";
            this.colTeachAdress.Visible = true;
            this.colTeachAdress.VisibleIndex = 8;
            // 
            // colTeachBrans
            // 
            this.colTeachBrans.FieldName = "TeachBrans";
            this.colTeachBrans.Name = "colTeachBrans";
            this.colTeachBrans.Visible = true;
            this.colTeachBrans.VisibleIndex = 9;
            // 
            // colTeachFoto
            // 
            this.colTeachFoto.FieldName = "TeachFoto";
            this.colTeachFoto.Name = "colTeachFoto";
            this.colTeachFoto.Visible = true;
            this.colTeachFoto.VisibleIndex = 10;
            // 
            // FrmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 527);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmTeachers";
            this.Text = "FrmTeachers";
            this.Load += new System.EventHandler(this.FrmTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbxBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbxilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbxil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctResim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private OkulDataSet okulDataSet;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbxBrans;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbxilce;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbxil;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PictureEdit PctResim;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnResimSec;
        private OkulDataSet1 okulDataSet1;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private OkulDataSet1TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachID;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachName;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachSurName;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachTel;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachMail;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachIL;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachILCE;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachBrans;
        private DevExpress.XtraGrid.Columns.GridColumn colTeachFoto;
    }
}