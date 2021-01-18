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
    public partial class FrmKasaHareketleri : Form
    {
        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            lblkasagiris.Text = db.TblKasa.Sum(x => x.Tutar).ToString();
            lblkasacikis.Text = db.TblKasaCikis.Sum(x => x.Tutar).ToString();
            //  decimal giris, cikis, tutar;
            // giris = decimal.Parse(lblkasagiris.ToString());
            // cikis= decimal.Parse(lblkasacikis.ToString());
            //   tutar = giris - cikis;

            lbltoplam.Text =(db.TblKasa.Sum(x => x.Tutar) - db.TblKasaCikis.Sum(x => x.Tutar)).ToString();

            dateEdit1.EditValue = DateTime.Today.Date.ToString();
            dateEdit2.EditValue = DateTime.Today.Date.ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            lblhesapgiris.Text = db.TblKasa.Where(x => x.Tarih == DateTime.Today).Sum(z => z.Tutar).ToString();
            lblhesapcikis.Text = db.TblKasaCikis.Where(x => x.Tarih == DateTime.Today).Sum(z => z.Tutar).ToString();

            lblhesaptoplam.Text = (db.TblKasa.Where(x => x.Tarih == DateTime.Today).Sum(z => z.Tutar) - db.TblKasaCikis.Where(x => x.Tarih == DateTime.Today).Sum(z => z.Tutar)).ToString();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //DateTime gecenhafta = DateTime.Now.AddDays(-7).Date;
            //MessageBox.Show(gecenhafta.ToString());

            //lblhesapgiris.Text = db.TblKasa.Where( x => x.Tarih >=DateTime.Today.Date && x.Tarih <= gecenhafta).Sum(z => z.Tutar).ToString();
            //lblhesapcikis.Text = db.TblKasaCikis.Where(x => x.Tarih >= DateTime.Today.Date && x.Tarih <= gecenhafta).Sum(z => z.Tutar).ToString();
            //lblhesaptoplam.Text= (db.TblKasa.Where(x => x.Tarih >= DateTime.Today.Date && x.Tarih <= gecenhafta).Sum(z => z.Tutar)- db.TblKasaCikis.Where(x => x.Tarih >= DateTime.Today.Date && x.Tarih <= gecenhafta).Sum(z => z.Tutar)).ToString();

            ////lblhesaptoplam.Text = (db.TblKasa.Where(x => x.Tarih == DateTime.Today.AddDays(-7)).Sum(z => z.Tutar) - db.TblKasaCikis.Where(x => x.Tarih == DateTime.Today.AddDays(-7)).Sum(z => z.Tutar)).ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dateEdit1.Text==null && dateEdit2.Text==null)
            {
                XtraMessageBox.Show("Lüften Tarihleri Seçiniz");
            }
            else
            {
                try
                {
                    DateTime tarih1 = DateTime.Parse(dateEdit1.EditValue.ToString());
                    DateTime tarih2 = DateTime.Parse(dateEdit2.EditValue.ToString());

                    lblhesapgiris.Text = db.TblKasa.Where(x => x.Tarih >= tarih1 && x.Tarih <= tarih2).Sum(z => z.Tutar).ToString();
                    lblhesapcikis.Text = db.TblKasaCikis.Where(x => x.Tarih >= tarih1 && x.Tarih <= tarih2).Sum(z => z.Tutar).ToString();

                    
                    lblhesaptoplam.Text = (db.TblKasa.Where(x => x.Tarih >= tarih1 && x.Tarih <= tarih2).Sum(z => z.Tutar) - db.TblKasaCikis.Where(x => x.Tarih >= tarih1 && x.Tarih <= tarih2).Sum(z => z.Tutar)).ToString();

                }
                catch (Exception)
                {

                    XtraMessageBox.Show("Sorgu Hatası Tekrar Deneyiniz ","Durum");
                }
            }
           

        }
    }
}
