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
    public partial class FrmRandevuEkle : Form
    {
        public FrmRandevuEkle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var liste = (from i in db.TblRandevu
                         select new
                         {
                             i.Id,
                             i.TblMusteri.AdSoyad,
                             i.TblMusteri.Telefon,
                             i.TblMusteri.TcKimlikNo,
                            İşlem= i.TblTras.TrasTip,
                             i.RandevuTarih,
                             i.RandevuSaat,

                         }).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["Id"].Visible = false;

        }
        void kaydet()
        {


            TblRandevu randevu = new TblRandevu();
            randevu.MusteriId = int.Parse(lookmusteri.EditValue.ToString());
            randevu.TrasTip = int.Parse(looktrastip.EditValue.ToString());
            randevu.RandevuTarih = DateTime.Parse(dateEdit1.Text);
            randevu.RandevuSaat = textsaat.Text;
         
           
            randevu.RandevuDurum = false;
          
            db.TblRandevu.Add(randevu);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Başarılı", "Durum");
            listele();

        }
        void musterilistele()
        {
            var musteri = (from a in db.TblMusteri
                           select new
                           {
                               a.AdSoyad,
                               a.Id,
                           }).ToList();
            lookmusteri.Properties.DataSource = musteri.ToList();
            lookmusteri.Properties.PopulateColumns();
            lookmusteri.Properties.Columns["Id"].Visible = false;

        }
        void tip()
        {
            var tip = (from a in db.TblTras
                           select new
                           {
                               a.Id,
                              İşlem= a.TrasTip,
                           }).ToList();
            looktrastip.Properties.DataSource =tip.ToList();
            looktrastip.Properties.PopulateColumns();
            looktrastip.Properties.Columns["Id"].Visible = false;

        }
        private void FrmRandevuEkle_Load(object sender, EventArgs e)
        {
            lookmusteri.Properties.NullText = "Müşteri Seçiniz";
            looktrastip.Properties.NullText = "İşlem Tipi Seçiniz";
            musterilistele();
            tip();
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                kaydet();
                listele();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Kayıt Sırasında Hata","DURUM");
            }
         
        }
    }
}
