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
    public partial class FrmKasaGiderlerListesi : Form
    {
        public FrmKasaGiderlerListesi()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var liste = (from a in db.TblKasaCikis
                         select new
                         {
                             Gider= a.Aciklama,
                             a.Tarih,
                             a.Tutar
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
        }
        private void FrmKasaGiderlerListesi_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
