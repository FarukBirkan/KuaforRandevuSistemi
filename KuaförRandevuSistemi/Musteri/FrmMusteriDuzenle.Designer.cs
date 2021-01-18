namespace KuaförRandevuSistemi.Musteri
{
    partial class FrmMusteriDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriDuzenle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtucret = new DevExpress.XtraEditors.TextEdit();
            this.txttras = new DevExpress.XtraEditors.TextEdit();
            this.txt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txttckimlikno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtucret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttckimlikno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txttckimlikno);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtucret);
            this.groupControl1.Controls.Add(this.txttras);
            this.groupControl1.Controls.Add(this.txt);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(642, 116);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Bilgi";
            // 
            // lblid
            // 
            this.lblid.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Appearance.Options.UseFont = true;
            this.lblid.Location = new System.Drawing.Point(357, 60);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(37, 16);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "Traş :";
            this.lblid.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(460, 35);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(460, 64);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(127, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Temizle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(460, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(127, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Güncelle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtucret
            // 
            this.txtucret.Location = new System.Drawing.Point(158, 59);
            this.txtucret.Name = "txtucret";
            this.txtucret.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtucret.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtucret.Size = new System.Drawing.Size(168, 20);
            this.txtucret.TabIndex = 1;
            // 
            // txttras
            // 
            this.txttras.Location = new System.Drawing.Point(158, 12);
            this.txttras.Name = "txttras";
            this.txttras.Size = new System.Drawing.Size(236, 20);
            this.txttras.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt.Appearance.Options.UseFont = true;
            this.txt.Location = new System.Drawing.Point(72, 60);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(76, 16);
            this.txt.TabIndex = 0;
            this.txt.Text = "Telefon No :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri Adı - Soyadı :";
            // 
            // txttckimlikno
            // 
            this.txttckimlikno.EditValue = "00000000000";
            this.txttckimlikno.Location = new System.Drawing.Point(158, 94);
            this.txttckimlikno.Name = "txttckimlikno";
            this.txttckimlikno.Properties.MaxLength = 11;
            this.txttckimlikno.Size = new System.Drawing.Size(168, 20);
            this.txttckimlikno.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "TC Kimlik No :";
            // 
            // FrmMusteriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 117);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Düzenle";
            this.Load += new System.EventHandler(this.FrmMusteriDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtucret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttckimlikno.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl txt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.LabelControl lblid;
        public DevExpress.XtraEditors.TextEdit txtucret;
        public DevExpress.XtraEditors.TextEdit txttras;
        public DevExpress.XtraEditors.TextEdit txttckimlikno;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}