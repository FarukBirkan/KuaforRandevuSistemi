using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.Randevu
{
    public partial class FrmGerceklesenRandevularListesi : Form
    {
        public FrmGerceklesenRandevularListesi()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var liste = (from a in db.TblRandevu
                         where  a.RandevuDurum == true
                         orderby a.RandevuSaat ascending
                         select new
                         {
                             a.RandevuTarih,
                             a.RandevuSaat,
                             a.TblMusteri.AdSoyad,
                             a.TblMusteri.Telefon,
                             a.TblMusteri.TcKimlikNo,
                             İşlem = a.TblTras.TrasTip,
                             a.RandevuDurum,

                         }
                        ).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["RandevuDurum"].Visible = false;

        }
        private void FrmGerceklesenRandevularListesi_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
