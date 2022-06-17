namespace OkulOtomasyon
{
    partial class FrmKimlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKimlik));
            this.LblTC = new DevExpress.XtraEditors.LabelControl();
            this.LblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.LblAd = new DevExpress.XtraEditors.LabelControl();
            this.LblDogumT = new DevExpress.XtraEditors.LabelControl();
            this.LblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTC
            // 
            this.LblTC.Location = new System.Drawing.Point(12, 67);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(63, 13);
            this.LblTC.TabIndex = 0;
            this.LblTC.Text = "labelControl1";
            // 
            // LblSoyad
            // 
            this.LblSoyad.Location = new System.Drawing.Point(124, 67);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(63, 13);
            this.LblSoyad.TabIndex = 1;
            this.LblSoyad.Text = "labelControl2";
            // 
            // LblAd
            // 
            this.LblAd.Location = new System.Drawing.Point(124, 101);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(63, 13);
            this.LblAd.TabIndex = 2;
            this.LblAd.Text = "labelControl3";
            // 
            // LblDogumT
            // 
            this.LblDogumT.Location = new System.Drawing.Point(124, 134);
            this.LblDogumT.Name = "LblDogumT";
            this.LblDogumT.Size = new System.Drawing.Size(63, 13);
            this.LblDogumT.TabIndex = 3;
            this.LblDogumT.Text = "labelControl4";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.Location = new System.Drawing.Point(210, 134);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.ShowLineShadow = false;
            this.LblCinsiyet.Size = new System.Drawing.Size(63, 13);
            this.LblCinsiyet.TabIndex = 4;
            this.LblCinsiyet.Text = "labelControl5";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(23, 82);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(83, 95);
            this.pictureEdit1.TabIndex = 6;
            // 
            // FrmKimlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(350, 218);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.LblDogumT);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblTC);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmKimlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kimlik Kartı";
            this.Load += new System.EventHandler(this.FrmKimlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblTC;
        private DevExpress.XtraEditors.LabelControl LblSoyad;
        private DevExpress.XtraEditors.LabelControl LblAd;
        private DevExpress.XtraEditors.LabelControl LblDogumT;
        private DevExpress.XtraEditors.LabelControl LblCinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}