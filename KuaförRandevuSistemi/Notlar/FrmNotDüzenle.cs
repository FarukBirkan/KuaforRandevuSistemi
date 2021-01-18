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

namespace KuaförRandevuSistemi.Notlar
{
    public partial class FrmNotDüzenle : Form
    {
        public FrmNotDüzenle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(lblid.Text);
                var notlar = db.TblNotlar.Find(id);
                notlar.Baslik = txtbaslik.Text;
                notlar.Icerik = txticerik.Text;
                notlar.Tarih = DateTime.Parse(datetarih.EditValue.ToString());
                notlar.Durum = checkEdit1.Checked;





                db.SaveChanges();
                XtraMessageBox.Show("Not Düzenlendi", "Durum");
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Not Düzenlemede Hata", "Durum");
            }
           

        }
        void sil()
        {
            try
            {
                int id = int.Parse(lblid.Text);
                var deger = db.TblNotlar.Find(id);
                db.TblNotlar.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Not Bilgileri Silindi", "Durum");

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Veri Silme Sırasında Hata"
                    , "Durum");
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Not Bilgileri Silinsin mi ?", "Durum", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sil();
              //  listele();
            }
            else
            {
                MessageBox.Show("Not Silinmedi", "Durum");
             //   listele();
            }
           
        }
    }
}
