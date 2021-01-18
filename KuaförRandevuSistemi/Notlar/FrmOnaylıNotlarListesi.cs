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
    public partial class FrmOnaylıNotlarListesi : Form
    {
        public FrmOnaylıNotlarListesi()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void notlar()
        {
            var liste = (from a in db.TblNotlar
                         where (a.Durum == true)
                         select new
                         {
                             a.Tarih,
                             a.Baslik,
                             a.Icerik


                         }).ToList();
            gridControl1.DataSource = liste.ToList();
        }
        private void FrmOnaylıNotlarListesi_Load(object sender, EventArgs e)
        {
            notlar();
        }
    }
}
