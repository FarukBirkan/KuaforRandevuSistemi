using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi.Giderler
{
    public partial class FrmGiderDüzenle : Form
    {
        public FrmGiderDüzenle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void güncelle()
        {
            int id = int.Parse(lblid.Text);
            var kc = db.TblKasaCikis.Find(id);

            kc.Aciklama = memogider.Text;
            kc.Tarih =DateTime.Parse(datetarih.Text);
            kc.Tutar =decimal.Parse(txttutar.Text);

            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi", "Durum");

        }
        void sil()
        {
            int id = int.Parse(lblid.Text);
            var deger = db.TblKasaCikis.Find(id);
            db.TblKasaCikis.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Silindi", "Durum");

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sil();
            this.Close();
        }
    }
}
