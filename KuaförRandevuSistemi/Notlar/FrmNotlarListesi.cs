using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.Notlar
{
    public partial class FrmNotlarListesi : Form
    {
        public FrmNotlarListesi()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var listele = (from a in db.TblNotlar
                           select new
                           {
                               a.Tarih,
                               a.Baslik,
                               a.Icerik
                           }).ToList();
            gridControl1.DataSource = listele.ToList();
        }
        private void FrmNotlarListesi_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
