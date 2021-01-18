namespace KuaförRandevuSistemi.Notlar
{
    partial class FrmNotDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotDüzenle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.datetarih = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txticerik = new DevExpress.XtraEditors.MemoEdit();
            this.txtbaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txticerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.datetarih);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txticerik);
            this.groupControl1.Controls.Add(this.txtbaslik);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 202);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Not İçerik";
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(15, 120);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(31, 13);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "Tarih :";
            this.lblid.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Enabled = false;
            this.pictureEdit1.Location = new System.Drawing.Point(205, 56);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(48, 44);
            this.pictureEdit1.TabIndex = 9;
            // 
            // datetarih
            // 
            this.datetarih.EditValue = null;
            this.datetarih.Location = new System.Drawing.Point(55, 31);
            this.datetarih.Name = "datetarih";
            this.datetarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetarih.Size = new System.Drawing.Size(261, 20);
            this.datetarih.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(15, 139);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(303, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txticerik
            // 
            this.txticerik.Location = new System.Drawing.Point(370, 66);
            this.txticerik.Name = "txticerik";
            this.txticerik.Properties.MaxLength = 200;
            this.txticerik.Size = new System.Drawing.Size(416, 96);
            this.txticerik.TabIndex = 5;
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(370, 31);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Properties.MaxLength = 150;
            this.txtbaslik.Size = new System.Drawing.Size(416, 20);
            this.txtbaslik.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(327, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "İçerik :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(327, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Başlık :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tarih :";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(55, 65);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "NOT ONAYLA";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style10;
            this.checkEdit1.Size = new System.Drawing.Size(161, 31);
            this.checkEdit1.TabIndex = 11;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(15, 167);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(303, 23);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Not Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmNotDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 202);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Onayla";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txticerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit datetarih;
        public DevExpress.XtraEditors.MemoEdit txticerik;
        public DevExpress.XtraEditors.TextEdit txtbaslik;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public DevExpress.XtraEditors.LabelControl lblid;
        public DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}