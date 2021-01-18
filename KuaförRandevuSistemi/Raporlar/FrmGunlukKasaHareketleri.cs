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

namespace KuaförRandevuSistemi.Raporlar
{
    public partial class FrmGunlukKasaHareketleri : Form
    {
        public FrmGunlukKasaHareketleri()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void kasagiris()
        {
            //int yastoplami = db.Ogrencilertbls.Where(x => x.Sinif == "A").Sum(x => x.Yas);
        }
        // void randevukabul()
        //{
        //    var liste = (from a in db.TblRandevu
        //                 where (a.RandevuTarih == DateTime.Today || a.RandevuDurum=)
        //                 select a).ToList();
        //}
        void yapilanis()
        {
            //    var liste = (from a in db.TblRandevu
            //                 where (a.RandevuTarih == DateTime.Today)
            //                 orderby a.TrasTip
            //                 group a by a.TblTras.TblRandevu.Count() into tiras

            //                 select new
            //                 {
            //                     tiras.Key,

            //                 }).ToList();


            var liste = (from c in db.TblRandevu
                         where (c.RandevuTarih == DateTime.Today && c.RandevuDurum == true)

                         group c by c.TblTras.TrasTip into tip
                         orderby tip.Count() descending
                         select new
                         {
                             İşlem_Tip = tip.Key,
                             İşlemSayısı = tip.Count()
                         }).ToList();

            gridControl1.DataSource = liste.ToList();
            //  lblencokislem.Text = liste.ToList().ToString();




        }
        void müsteribilgi()
        {
            var bilgi = (from a in db.TblKasa
                         where (a.Tarih == DateTime.Today)
                         select new
                         {
                             a.Musteri,
                             İşlem = a.Tutar,
                             
                         }).ToList();
            gridControl2.DataSource = bilgi.ToList();
        }
        private void FrmGunlukKasaHareketleri_Load(object sender, EventArgs e)

        {
            try
            {
                decimal giris, cikis;
                müsteribilgi();
                yapilanis();
                textEdit1.Text = db.TblKasa.Where(x => x.Tarih == DateTime.Today).Sum(x => x.Tutar).ToString();
                lblrandevukabul.Text = db.TblRandevu.Where(x => x.RandevuDurum == true && x.RandevuTarih == DateTime.Today).Count().ToString();
                lblrandevured.Text = db.TblRandevu.Where(x => x.RandevuDurum == false && x.RandevuTarih == DateTime.Today).Count().ToString();
                txtkasacikis.Text = db.TblKasaCikis.Where(v => v.Tarih == DateTime.Today).Sum(x => x.Tutar).ToString();

                if (textEdit1.Text=="")
                {
                    giris = 0;

                  //  giris = decimal.Parse(textEdit1.Text);
                    cikis = decimal.Parse(txtkasacikis.Text);
                    decimal kasa = giris - cikis;
                    labelControl9.Text = kasa.ToString();



                }
                else if (txtkasacikis.Text=="")
                {
                    giris = decimal.Parse(textEdit1.Text);
                    cikis = 0;
                    // cikis = decimal.Parse(txtkasacikis.Text);
                    decimal kasa = giris - cikis;
                    labelControl9.Text = kasa.ToString();

                }
                else
                {
                    giris = decimal.Parse(textEdit1.Text);
                    cikis = decimal.Parse(txtkasacikis.Text);
                    decimal kasa = giris - cikis;
                    labelControl9.Text = kasa.ToString();

                }



            }
            catch (Exception)
            {
               // XtraMessageBox.Show("");
                //throw;
            }

            //try
            //{

            //}
            //catch (Exception)
            //{

            //    XtraMessageBox.Show("Bugün Gerçekleşen Bir Randevu Yok") ;
            //}

        }
    }
}
