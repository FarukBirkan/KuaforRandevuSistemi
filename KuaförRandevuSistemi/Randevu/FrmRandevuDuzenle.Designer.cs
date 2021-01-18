namespace KuaförRandevuSistemi.Randevu
{
    partial class FrmRandevuDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuDuzenle));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblucret = new DevExpress.XtraEditors.TextEdit();
            this.d = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.looktrastip = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lookmusteri = new DevExpress.XtraEditors.LookUpEdit();
            this.textsaat = new DevExpress.XtraEditors.TimeEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblucret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.looktrastip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookmusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(60, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "İşlem Tipi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(70, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Randevu Tarihi :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(290, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Saati :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblucret);
            this.groupControl1.Controls.Add(this.d);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.looktrastip);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.lookmusteri);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textsaat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1370, 193);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Randevu Bilgi";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lblucret
            // 
            this.lblucret.Location = new System.Drawing.Point(134, 154);
            this.lblucret.Name = "lblucret";
            this.lblucret.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblucret.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblucret.Properties.Appearance.Options.UseFont = true;
            this.lblucret.Properties.Appearance.Options.UseForeColor = true;
            this.lblucret.Properties.Mask.EditMask = "c";
            this.lblucret.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.lblucret.Size = new System.Drawing.Size(113, 26);
            this.lblucret.TabIndex = 16;
            // 
            // d
            // 
            this.d.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.d.Appearance.Options.UseFont = true;
            this.d.Location = new System.Drawing.Point(42, 161);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(85, 16);
            this.d.TabIndex = 15;
            this.d.Text = "İşlem Ücreti :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(742, 29);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(250, 151);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Randevu İptal";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(486, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(250, 151);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Randevu Gerçekleşti";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // lblid
            // 
            this.lblid.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Appearance.Options.UseFont = true;
            this.lblid.Location = new System.Drawing.Point(5, 32);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(58, 16);
            this.lblid.TabIndex = 13;
            this.lblid.Text = "Müşteri :";
            this.lblid.Visible = false;
            // 
            // looktrastip
            // 
            this.looktrastip.Enabled = false;
            this.looktrastip.Location = new System.Drawing.Point(134, 118);
            this.looktrastip.Name = "looktrastip";
            this.looktrastip.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.looktrastip.Properties.Appearance.Options.UseFont = true;
            this.looktrastip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.looktrastip.Properties.DisplayMember = "işlem";
            this.looktrastip.Properties.ValueMember = "Id";
            this.looktrastip.Size = new System.Drawing.Size(347, 26);
            this.looktrastip.TabIndex = 4;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Enabled = false;
            this.dateEdit1.Location = new System.Drawing.Point(132, 72);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(141, 26);
            this.dateEdit1.TabIndex = 2;
            // 
            // lookmusteri
            // 
            this.lookmusteri.Enabled = false;
            this.lookmusteri.Location = new System.Drawing.Point(132, 29);
            this.lookmusteri.Name = "lookmusteri";
            this.lookmusteri.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.lookmusteri.Properties.Appearance.Options.UseFont = true;
            this.lookmusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookmusteri.Properties.DisplayMember = "AdSoyad";
            this.lookmusteri.Properties.ValueMember = "Id";
            this.lookmusteri.Size = new System.Drawing.Size(347, 26);
            this.lookmusteri.TabIndex = 1;
            this.lookmusteri.EditValueChanged += new System.EventHandler(this.lookmusteri_EditValueChanged);
            // 
            // textsaat
            // 
            this.textsaat.EditValue = null;
            this.textsaat.Enabled = false;
            this.textsaat.Location = new System.Drawing.Point(338, 72);
            this.textsaat.Name = "textsaat";
            this.textsaat.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.textsaat.Properties.Appearance.Options.UseFont = true;
            this.textsaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textsaat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textsaat.Properties.Mask.EditMask = "t";
            this.textsaat.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.textsaat.Size = new System.Drawing.Size(141, 26);
            this.textsaat.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 193);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(1370, 5);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 198);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1370, 551);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FrmRandevuDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmRandevuDuzenle";
            this.Text = "Randevu Düzenle";
            this.Load += new System.EventHandler(this.FrmRandevuDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblucret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.looktrastip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookmusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit looktrastip;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookmusteri;
        private DevExpress.XtraEditors.TimeEdit textsaat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl d;
        private DevExpress.XtraEditors.TextEdit lblucret;
    }
}