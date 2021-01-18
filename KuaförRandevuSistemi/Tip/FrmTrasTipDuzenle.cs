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

namespace KuaförRandevuSistemi.Tip
{
    public partial class FrmTrasTipDuzenle : Form
    {
        public FrmTrasTipDuzenle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void güncelle()
        {
            try
            {
                int id = int.Parse(lblid.Text);
                var tip = db.TblTras.Find(id);

                tip.TrasTip = txttras.Text;
                tip.Ucret = decimal.Parse(txtucret.Text);

                db.SaveChanges();
                XtraMessageBox.Show("Güncellendi", "Durum");
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Veri Güncelleme Hatası ...","Durum");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            güncelle();

        }
        void sil()
        {
            try
            {
                int id = int.Parse(lblid.Text);
                var deger = db.TblTras.Find(id);
                db.TblTras.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Silindi", "Durum");
            }
            catch (Exception)
            {

                XtraMessageBox.Show("İşlem Tipi Kullanıldı ... ","Durum");
            }

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
