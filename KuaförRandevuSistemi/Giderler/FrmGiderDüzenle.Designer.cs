namespace KuaförRandevuSistemi.Giderler
{
    partial class FrmGiderDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderDüzenle));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.datetarih = new DevExpress.XtraEditors.DateEdit();
            this.txttutar = new DevExpress.XtraEditors.TextEdit();
            this.memogider = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memogider.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblid);
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 100);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(800, 40);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "groupControl3";
            // 
            // lblid
            // 
            this.lblid.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Appearance.Options.UseFont = true;
            this.lblid.Location = new System.Drawing.Point(173, 10);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(43, 18);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "Gider :";
            this.lblid.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(92, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(11, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Düzenle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.datetarih);
            this.groupControl1.Controls.Add(this.txttutar);
            this.groupControl1.Controls.Add(this.memogider);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Gider Bilgileri";
            // 
            // datetarih
            // 
            this.datetarih.EditValue = null;
            this.datetarih.Location = new System.Drawing.Point(436, 38);
            this.datetarih.Name = "datetarih";
            this.datetarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetarih.Properties.Mask.EditMask = "";
            this.datetarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.datetarih.Size = new System.Drawing.Size(165, 20);
            this.datetarih.TabIndex = 5;
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(663, 38);
            this.txttutar.Name = "txttutar";
            this.txttutar.Properties.Mask.EditMask = "c";
            this.txttutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttutar.Size = new System.Drawing.Size(100, 20);
            this.txttutar.TabIndex = 4;
            // 
            // memogider
            // 
            this.memogider.Location = new System.Drawing.Point(61, 32);
            this.memogider.Name = "memogider";
            this.memogider.Size = new System.Drawing.Size(316, 53);
            this.memogider.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(614, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tutar :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(383, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tarih :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Gider :";
            // 
            // FrmGiderDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 140);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memogider.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit datetarih;
        public DevExpress.XtraEditors.TextEdit txttutar;
        public DevExpress.XtraEditors.MemoEdit memogider;
        public DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}