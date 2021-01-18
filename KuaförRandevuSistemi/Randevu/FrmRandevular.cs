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
    public partial class FrmRandevular : Form
    {
        public FrmRandevular()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listeler()
        {
            var randevuler = (from a in db.TblRandevu
                              
                              orderby a.RandevuTarih ascending
                              select new
                              {

                                  Randevu_Zamanı = a.RandevuTarih.ToString() + " - " + a.RandevuSaat,
                                  Müşteri = a.TblMusteri.AdSoyad,
                                  Telefon = a.TblMusteri.Telefon,
                                  TcKimlikNo = a.TblMusteri.TcKimlikNo,
                                  İşlem = a.TblTras.TrasTip
                              }).ToList();
            gridControl1.DataSource = randevuler.ToList();

        }
        private void FrmRandevular_Load(object sender, EventArgs e)
        {
            listeler();
        }
    }



}
