using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.Musteri
{
    public partial class FrmMusteriListe : Form
    {
        public FrmMusteriListe()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {

            var listele = (from i in db.TblMusteri
                           select new
                           {
                               i.TcKimlikNo,
                               i.AdSoyad,
                               i.Telefon,

                           }).ToList();
            gridControl1.DataSource = listele.ToList();
        }
        private void FrmMusteriListe_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
            {
                listele();
            }
        }
    }
}
