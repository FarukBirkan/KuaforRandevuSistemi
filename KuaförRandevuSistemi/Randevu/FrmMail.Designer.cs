namespace KuaförRandevuSistemi.Randevu
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtmailadres = new DevExpress.XtraEditors.TextEdit();
            this.txtmailsifre = new DevExpress.XtraEditors.TextEdit();
            this.txtaliciadres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailsifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaliciadres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(119, 129);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(262, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Mail Gönder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mail Adres :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre :";
            // 
            // txtmailadres
            // 
            this.txtmailadres.Location = new System.Drawing.Point(119, 15);
            this.txtmailadres.Name = "txtmailadres";
            this.txtmailadres.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmailadres.Properties.Appearance.Options.UseFont = true;
            this.txtmailadres.Size = new System.Drawing.Size(262, 22);
            this.txtmailadres.TabIndex = 3;
            // 
            // txtmailsifre
            // 
            this.txtmailsifre.Location = new System.Drawing.Point(119, 48);
            this.txtmailsifre.Name = "txtmailsifre";
            this.txtmailsifre.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmailsifre.Properties.Appearance.Options.UseFont = true;
            this.txtmailsifre.Properties.PasswordChar = '*';
            this.txtmailsifre.Size = new System.Drawing.Size(262, 22);
            this.txtmailsifre.TabIndex = 4;
            // 
            // txtaliciadres
            // 
            this.txtaliciadres.Location = new System.Drawing.Point(119, 101);
            this.txtaliciadres.Name = "txtaliciadres";
            this.txtaliciadres.Properties.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaliciadres.Properties.Appearance.Options.UseFont = true;
            this.txtaliciadres.Size = new System.Drawing.Size(262, 22);
            this.txtaliciadres.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Alıcı Mail Adres :";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 184);
            this.Controls.Add(this.txtaliciadres);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtmailsifre);
            this.Controls.Add(this.txtmailadres);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönder";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmailadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailsifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaliciadres.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtmailadres;
        private DevExpress.XtraEditors.TextEdit txtmailsifre;
        private DevExpress.XtraEditors.TextEdit txtaliciadres;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}