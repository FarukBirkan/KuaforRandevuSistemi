namespace KuaförRandevuSistemi.Ayarlar
{
    partial class FrmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciEkle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtpas = new DevExpress.XtraEditors.TextEdit();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtpas);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(506, 244);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Kullanıcı Bilgileri";
            // 
            // lblid
            // 
            this.lblid.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblid.Appearance.Options.UseFont = true;
            this.lblid.Location = new System.Drawing.Point(289, 166);
            this.lblid.Margin = new System.Windows.Forms.Padding(4);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 18);
            this.lblid.TabIndex = 10;
            this.lblid.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(289, 191);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(187, 35);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(298, 124);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Yetkili Mi ?";
            this.checkEdit1.Size = new System.Drawing.Size(178, 31);
            this.checkEdit1.TabIndex = 8;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(13, 191);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(187, 35);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtpas
            // 
            this.txtpas.Location = new System.Drawing.Point(13, 135);
            this.txtpas.Name = "txtpas";
            this.txtpas.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpas.Properties.Appearance.Options.UseFont = true;
            this.txtpas.Properties.MaxLength = 10;
            this.txtpas.Properties.PasswordChar = '*';
            this.txtpas.Size = new System.Drawing.Size(187, 24);
            this.txtpas.TabIndex = 4;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(13, 59);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Properties.MaxLength = 50;
            this.txtad.Size = new System.Drawing.Size(463, 24);
            this.txtad.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 110);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şifre :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 244);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(506, 379);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(56)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FrmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 623);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle";
            this.Load += new System.EventHandler(this.FrmKullaniciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtpas;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}