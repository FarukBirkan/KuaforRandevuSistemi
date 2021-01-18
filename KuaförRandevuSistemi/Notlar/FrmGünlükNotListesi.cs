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
    public partial class FrmGünlükNotListesi : Form
    {
        public FrmGünlükNotListesi()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void notlar()
        {
            var liste = (from a in db.TblNotlar
                         where (a.Tarih == DateTime.Today
                         )
                         select new
                         {
                             a.Id,
                           Başlık= a.Baslik,
                            İçerik= a.Icerik,
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["Id"].Visible = false;
        }
        private void FrmGünlükNotListesi_Load(object sender, EventArgs e)
        {
            notlar();
        }
    }
}
