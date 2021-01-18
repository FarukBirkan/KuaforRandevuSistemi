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

namespace KuaförRandevuSistemi.Ayarlar
{
    public partial class FrmKullaniciEkle : Form
    {
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        void listele()
        {
            var liste = (from a in db.TblKullanici
                         select new
                         {
                             a.Id,
                             a.KullaniciAd,
                            
                             a.Yetki
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["Id"].Visible = false;
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TblKullanici kk = new TblKullanici();
            kk.KullaniciAd = txtad.Text;
            kk.Sifre = txtpas.Text;
            kk.Yetki = checkEdit1.Checked;
            db.TblKullanici.Add(kk);
            db.SaveChanges();
            XtraMessageBox.Show("Kullanıcı Eklendi","Durum");
            listele();
        }

        private void FrmKullaniciEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void sil()
        {
            try
            {
                int id = int.Parse(lblid.Text);
                var deger = db.TblKullanici.Find(id);
                db.TblKullanici.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Kullanıcı Kayıt  Bilgileri Silindi", "Durum");

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Veri Silme Sırasında Hata"
                    , "Durum");
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lblid.Text==null)
            {
                XtraMessageBox.Show("Lütfen Kullanıcı Seçiniz Listeden ","Durum");
            }
            else
            {
                DialogResult dialog = new DialogResult();
                dialog = XtraMessageBox.Show("Kullanıcı Silinsin mi ?", "Durum", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    sil();
                    listele();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Silinmedi", "Durum");
                    listele();
                }
            }
          
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            TblKullanici rnd = new TblKullanici();
            lblid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
        }
    }
}
