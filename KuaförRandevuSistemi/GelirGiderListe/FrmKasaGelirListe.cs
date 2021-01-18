using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.GelirGiderListe
{
    public partial class FrmKasaGelirListe : Form
    {
        public FrmKasaGelirListe()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var bilgi = (from a in db.TblKasa

                         select new
                         {
                             a.Tarih,
                             a.Tutar,
                             a.Musteri,
                             // a.TblMusteri.AdSoyad,
                         }).ToList();
            gridControl1.DataSource = bilgi.ToList();

        }
        private void FrmKasaGelirListe_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
