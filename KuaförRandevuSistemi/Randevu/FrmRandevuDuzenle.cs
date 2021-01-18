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

namespace KuaförRandevuSistemi.Randevu
{
    public partial class FrmRandevuDuzenle : Form
    {
        public FrmRandevuDuzenle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var liste = (from v in db.TblRandevu
                         where v.RandevuTarih == DateTime.Today && v.RandevuDurum == false
                         orderby v.RandevuSaat ascending
                        
                         select new
                         {
                             v.Id,
                             v.RandevuDurum,
                             v.TblMusteri.AdSoyad,
                             v.TblMusteri.Telefon,
                             v.TblMusteri.TcKimlikNo,
                             v.RandevuTarih,
                             v.RandevuSaat,
                             işlem=v.TblTras.TrasTip,
                             v.TblTras.Ucret,
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["Id"].Visible = false;
            gridView1.Columns["Ucret"].Visible = false;
        }
        void trastipliste()
        {
            var tip = (from k in db.TblTras
                       select new
                       {
                           k.Id,
                          işlem= k.TrasTip
                       }).ToList();
            looktrastip.Properties.DataSource = tip.ToList();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void FrmRandevuDuzenle_Load(object sender, EventArgs e)
        {
            listele();
            musterilistele();
            trastipliste();

        }
        void güncelle()
        {
            try
            {
                int id = int.Parse(lblid.Text);
                var randevu = db.TblRandevu.Find(id);

                randevu.MusteriId = int.Parse(lookmusteri.EditValue.ToString());
                randevu.TrasTip = int.Parse(looktrastip.EditValue.ToString());
                randevu.RandevuTarih = DateTime.Parse(dateEdit1.Text);
                randevu.RandevuSaat = textsaat.Text;

                randevu.RandevuDurum = true;

                db.SaveChanges();
                XtraMessageBox.Show("RANDEVU GERÇEKLEŞTİ ...", "Durum");
                lookmusteri.EditValue = null;
                looktrastip.EditValue = null;
                dateEdit1.EditValue = null;
                textsaat.EditValue = null;

            }
            catch (Exception)
            {

                XtraMessageBox.Show("iŞLEM SIRASINDA HATA","Durum") ;
            }
                 }
        void kasagiris()
        {
            try
            {
                TblKasa kasa = new TblKasa();
                kasa.Tutar = decimal.Parse(lblucret.Text);
                kasa.Tarih = DateTime.Now;
                kasa.Musteri = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
                db.TblKasa.Add(kasa);
                db.SaveChanges();
                XtraMessageBox.Show("KASA BİLGİLERİNE TUTAR AKTARILDI ...", "Durum");
                lblucret.Text = null;
            }
            catch (Exception)
            {

                XtraMessageBox.Show("KASA iŞLEMLERİ SIRASINDA HATA", "Durum");
            }
          
        }
        void musterilistele()
        {
            var musteriler = (from a in db.TblMusteri
                              select new
                              {
                                  a.Id,
                                  a.AdSoyad,
                                  a.Telefon
                              }).ToList();
            lookmusteri.Properties.DataSource = musteriler.ToList();
        }
        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
            lookmusteri.Text = null;
            looktrastip.Text = null;
            dateEdit1.Text = null; textsaat.Text = null;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TblRandevu rnd = new TblRandevu();
                lblid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
                lookmusteri.Text = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
                looktrastip.Text = gridView1.GetFocusedRowCellValue("işlem").ToString();
                dateEdit1.EditValue = gridView1.GetFocusedRowCellValue("RandevuTarih").ToString();
                textsaat.EditValue = gridView1.GetFocusedRowCellValue("RandevuSaat").ToString();
                lblucret.Text = gridView1.GetFocusedRowCellValue("Ucret").ToString();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hata","Hata");
            }
       
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            güncelle();
            kasagiris();
            listele();
        }
        void sil()
        {
            try
            {
                int id = int.Parse(lblid.Text);
                var deger = db.TblRandevu.Find(id);
                db.TblRandevu.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Randevu Kayıt  Bilgileri Silindi", "Durum");

            }
            catch (Exception)
            {

                XtraMessageBox.Show("Veri Silme Sırasında Hata"
                    ,"Durum") ;
            }
          
        }
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Randevu Silinsin mi ?", "Durum", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sil();
                listele();
            }
            else
            {
                MessageBox.Show("Randevu Silinmedi","Durum");
                listele();
            }
        }

        private void lookmusteri_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
