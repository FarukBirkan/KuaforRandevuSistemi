using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.Raporlar
{
    public partial class FrmMusteriHareketleri : Form
    {
        public FrmMusteriHareketleri()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void liste()
        {
            var bilgi = (from a in db.TblRandevu
                         where (a.RandevuDurum == true)
                         select new
                         {
                             a.RandevuTarih,
                             a.TblMusteri.AdSoyad,
                            İşlem= a.TblTras.TrasTip,
                             
                             
                         }).ToList();
            gridControl1.DataSource = bilgi.ToList();

        }
        private void FrmMusteriHareketleri_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
