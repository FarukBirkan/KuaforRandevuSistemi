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

namespace KuaförRandevuSistemi.Musteri
{
    public partial class FrmMusteriDuzenle : Form
    {
        public FrmMusteriDuzenle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();

        private void FrmMusteriDuzenle_Load(object sender, EventArgs e)
        {

        }
        void güncelle()
        {
            int id = int.Parse(lblid.Text);
            var tip = db.TblMusteri.Find(id);

            tip.AdSoyad = txttras.Text;
            tip.Telefon = txtucret.Text;
            tip.TcKimlikNo = txttckimlikno.Text;

            db.SaveChanges();
            XtraMessageBox.Show("Güncellendi", "Durum");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            güncelle();
            

        }
        void sil()
        {
            int id = int.Parse(lblid.Text);
            var deger = db.TblMusteri.Find(id);
            db.TblMusteri.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Silindi", "Durum");

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txttckimlikno.Text = "00000000000";
            txttras.Text = null;
            txtucret.Text = null;
        }
    }
}
