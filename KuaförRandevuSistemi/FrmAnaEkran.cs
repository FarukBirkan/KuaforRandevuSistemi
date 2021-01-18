using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void bugün()
        {
            var bugün = (from a in db.TblRandevu
                         where (a.RandevuTarih == DateTime.Today)
                         orderby a.RandevuSaat ascending
                         select new
                         {
                             a.RandevuSaat,
                             a.TblMusteri.AdSoyad,
                             a.TblMusteri.Telefon
                         }).ToList();
            gridbugun.DataSource = bugün.ToList();
        }
        void liste()
        {
            var bugün = (from a in db.TblRandevu

                         orderby a.RandevuTarih ascending
                         select new
                         {
                             a.RandevuTarih,
                             a.RandevuSaat,
                             a.TblMusteri.AdSoyad,
                             a.TblMusteri.Telefon
                         }).ToList();
            gridtoplamrandevuliste.DataSource = bugün.ToList();
        }
        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            DateTime yarın =DateTime.Today.AddDays(1);
            lblbgrs.Text = db.TblRandevu.Where(a => a.RandevuTarih == DateTime.Today).Count().ToString();
            lblbons.Text = db.TblNotlar.Where(a => a.Tarih == DateTime.Today).Count().ToString();
            lblygrs.Text = db.TblRandevu.Where(a => a.RandevuTarih == yarın).Count().ToString();
            lblygns.Text = db.TblNotlar.Where(a => a.Tarih == yarın).Count().ToString();
            bugün();
            liste();
        }
    }
}
