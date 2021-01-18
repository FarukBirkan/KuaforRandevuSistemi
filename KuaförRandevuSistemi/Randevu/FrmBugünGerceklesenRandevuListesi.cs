using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.Randevu
{
    public partial class FrmBugünGerceklesenRandevuListesi : Form
    {
        public FrmBugünGerceklesenRandevuListesi()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var liste = (from a in db.TblRandevu
                         where (a.RandevuDurum == true && a.RandevuTarih==DateTime.Today)
                         orderby a.RandevuSaat ascending
                         select new
                         {
                             a.TblMusteri.AdSoyad,
                             a.TblMusteri.Telefon,
                             a.TblMusteri.TcKimlikNo,
                             a.RandevuTarih,
                             a.RandevuSaat,
                             İşlem = a.TblTras.TrasTip,
                             

                         }
                        ).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["İşlem"].Visible = false;

        }
        private void FrmBugünGerceklesenRandevuListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string path = "GünlükListe.pdf";
            gridControl1.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string pat = "GünlükListe.xlsx";
            gridControl1.ExportToXlsx(pat);
            Process.Start(pat);
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            Randevu.FrmMail mail = new FrmMail();
            mail.ShowDialog();
        }
    }
}
