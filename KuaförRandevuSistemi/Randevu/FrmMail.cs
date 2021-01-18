using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace KuaförRandevuSistemi.Randevu
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {

        }
        Randevu.FrmBugünGerceklesenRandevuListesi gr = new FrmBugünGerceklesenRandevuListesi();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential(txtmailadres.Text, txtmailsifre.Text);

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(txtmailadres.Text,txtmailadres.Text);

            mail.To.Add(txtaliciadres.Text);
           // mail.To.Add("alici2@mail.com");

         //   mail.CC.Add("alici3@mail.com");
          //  mail.CC.Add("alici4@mail.com");

            mail.Subject = "Günlük Randevu Listesi"; mail.IsBodyHtml = true; mail.Body = "Randevu Listesi";

            string pat = "GünlükListe.xlsx";
           gr. gridControl1.ExportToXlsx(pat);
           //Process.Start(pat);
            mail.Attachments.Add(new Attachment(@"C:\Rapor.xlsx"));
            mail.Attachments.Add(new Attachment(pat));
       //     mail.Attachments.Add(new Attachment(@"C:\Sonuc.pptx"));

            sc.Send(mail);
        }
    }
}
