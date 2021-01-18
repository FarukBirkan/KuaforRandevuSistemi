namespace KuaförRandevuSistemi
{
    partial class FrmAnaEkran
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblygnsd = new DevExpress.XtraEditors.LabelControl();
            this.lblbgrs = new DevExpress.XtraEditors.LabelControl();
            this.lblbons = new DevExpress.XtraEditors.LabelControl();
            this.lblygrs = new DevExpress.XtraEditors.LabelControl();
            this.lblygns = new DevExpress.XtraEditors.LabelControl();
            this.gridbugun = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridtoplamrandevuliste = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbugun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtoplamrandevuliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel4);
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1370, 193);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Randevu Detayları";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridbugun);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 193);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(646, 556);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Günlük Randevu Listesi";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridtoplamrandevuliste);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(646, 193);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(724, 556);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Randevu Listesi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.lblbgrs);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 171);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.lblbons);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(324, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 171);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.lblygrs);
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(646, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 171);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.lblygns);
            this.panel4.Controls.Add(this.lblygnsd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(968, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 171);
            this.panel4.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(262, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bugün Gerçekleşecek Randevu Sayısı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Lavender;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(210, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Bugün Onaylanacak Not Sayısı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Lavender;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(43, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(254, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Yarın Gerçekleşecek Randevu Sayısı";
            // 
            // lblygnsd
            // 
            this.lblygnsd.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygnsd.Appearance.ForeColor = System.Drawing.Color.Lavender;
            this.lblygnsd.Appearance.Options.UseFont = true;
            this.lblygnsd.Appearance.Options.UseForeColor = true;
            this.lblygnsd.Location = new System.Drawing.Point(111, 26);
            this.lblygnsd.Name = "lblygnsd";
            this.lblygnsd.Size = new System.Drawing.Size(202, 20);
            this.lblygnsd.TabIndex = 2;
            this.lblygnsd.Text = "Yarın Onaylanacak Not Sayısı";
            // 
            // lblbgrs
            // 
            this.lblbgrs.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbgrs.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.lblbgrs.Appearance.Options.UseFont = true;
            this.lblbgrs.Appearance.Options.UseForeColor = true;
            this.lblbgrs.Location = new System.Drawing.Point(97, 67);
            this.lblbgrs.Name = "lblbgrs";
            this.lblbgrs.Size = new System.Drawing.Size(126, 43);
            this.lblbgrs.TabIndex = 1;
            this.lblbgrs.Text = "125455";
            // 
            // lblbons
            // 
            this.lblbons.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbons.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.lblbons.Appearance.Options.UseFont = true;
            this.lblbons.Appearance.Options.UseForeColor = true;
            this.lblbons.Location = new System.Drawing.Point(97, 67);
            this.lblbons.Name = "lblbons";
            this.lblbons.Size = new System.Drawing.Size(126, 43);
            this.lblbons.TabIndex = 2;
            this.lblbons.Text = "125455";
            // 
            // lblygrs
            // 
            this.lblygrs.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygrs.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.lblygrs.Appearance.Options.UseFont = true;
            this.lblygrs.Appearance.Options.UseForeColor = true;
            this.lblygrs.Location = new System.Drawing.Point(99, 67);
            this.lblygrs.Name = "lblygrs";
            this.lblygrs.Size = new System.Drawing.Size(126, 43);
            this.lblygrs.TabIndex = 3;
            this.lblygrs.Text = "125455";
            // 
            // lblygns
            // 
            this.lblygns.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblygns.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.lblygns.Appearance.Options.UseFont = true;
            this.lblygns.Appearance.Options.UseForeColor = true;
            this.lblygns.Location = new System.Drawing.Point(145, 67);
            this.lblygns.Name = "lblygns";
            this.lblygns.Size = new System.Drawing.Size(126, 43);
            this.lblygns.TabIndex = 3;
            this.lblygns.Text = "125455";
            // 
            // gridbugun
            // 
            this.gridbugun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridbugun.Location = new System.Drawing.Point(2, 20);
            this.gridbugun.MainView = this.gridView1;
            this.gridbugun.Name = "gridbugun";
            this.gridbugun.Size = new System.Drawing.Size(642, 534);
            this.gridbugun.TabIndex = 0;
            this.gridbugun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(229)))), ((int)(((byte)(56)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridbugun;
            this.gridView1.Name = "gridView1";
            // 
            // gridtoplamrandevuliste
            // 
            this.gridtoplamrandevuliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridtoplamrandevuliste.Location = new System.Drawing.Point(2, 20);
            this.gridtoplamrandevuliste.MainView = this.gridView2;
            this.gridtoplamrandevuliste.Name = "gridtoplamrandevuliste";
            this.gridtoplamrandevuliste.Size = new System.Drawing.Size(720, 534);
            this.gridtoplamrandevuliste.TabIndex = 1;
            this.gridtoplamrandevuliste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.GridControl = this.gridtoplamrandevuliste;
            this.gridView2.Name = "gridView2";
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmAnaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbugun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtoplamrandevuliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblygns;
        private DevExpress.XtraEditors.LabelControl lblygnsd;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblygrs;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblbons;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblbgrs;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridbugun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridtoplamrandevuliste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}