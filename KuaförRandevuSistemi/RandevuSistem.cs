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

namespace KuaförRandevuSistemi
{
    public partial class RandevuSistem : Form
    {
        public RandevuSistem()
        {
            InitializeComponent();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Randevu.FrmGunlukRandevuListesi frmgrl = new Randevu.FrmGunlukRandevuListesi();
            frmgrl.MdiParent = this;
            frmgrl.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tip.FrmTrasTipEkle frmtrastip = new Tip.FrmTrasTipEkle();
            // frmtrastip.MdiParent = this;
            frmtrastip.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tip.FrmTarifeFiyatları fiyatlar = new Tip.FrmTarifeFiyatları();
            fiyatlar.MdiParent = this;
            fiyatlar.Show();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Musteri.FrmMusteriListe ml = new Musteri.FrmMusteriListe();
            ml.MdiParent = this;
            ml.Show();


        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Musteri.FrmMusteriEkle me = new Musteri.FrmMusteriEkle();
            me.MdiParent = this;

            me.Show();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Randevu.FrmRandevuEkle re = new Randevu.FrmRandevuEkle();
            re.MdiParent = this;
            re.Show();
        }

        DbRandevuEntities3 db = new DbRandevuEntities3();
        private void RandevuSistem_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.Kullanim==0)
            {
                if (Properties.Settings.Default.Deneme==0)
                {
                    XtraMessageBox.Show("Programı kullanmak için hakkınız Dolmuştur","Demo Süresi Dolmuştur");
                    Application.Exit();
                }
                else
                {
                    XtraMessageBox.Show("Demo Kullanım İçin Hakkınız : " + Properties.Settings.Default.Deneme);
                    Properties.Settings.Default.Deneme--;
                    Properties.Settings.Default.Save();
                }
            }
            

            FrmAnaEkran ae = new FrmAnaEkran();
            ae.MdiParent = this;
            ae.Show();
            //  barStaticItem1.Caption =DateTime.Now.ToString();
            timer1.Interval = 1000;
            timer1.Start();
            // barStaticItem1.Text = DateTime.Now.ToLongDateString();
            barStaticItem1.Caption = DateTime.Now.ToLongTimeString();
            barStaticItem5.Caption = DateTime.Now.ToLongDateString();

            var durum = (from a in db.TblRandevu
                         where a.RandevuSaat == barStaticItem1.Caption
                         select new
                         {
                             a.TblMusteri.AdSoyad,
                             //a.TblTras.TrasTip,
                             //a.TblMusteri.Telefon
                          
                         }).ToList();

            if (barStaticItem4.Caption=="True")
            {
                ribbonPage2.Visible = true;
                ribbonPage3.Visible = true;
               
            }
            else
            {
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem23.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                ribbonPageGroup3.Visible = false;
                ribbonPageGroup6.Visible = false;
                ribbonPageGroup8.Visible = false;
            }
            //string musteri = durum.ToList().ToString();
            //MessageBox.Show(""+musteri);
            //DevExpress.XtraBars.Alerter.AlertControl _Alert = new DevExpress.XtraBars.Alerter.AlertControl();
            //_Alert.Show(this, durum.ToList().ToString(),"Randevulu Müşteri");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label4.Text = DateTime.Now.ToLongDateString();
            barStaticItem1.Caption = DateTime.Now.ToLongTimeString();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Randevu.FrmRandevular rnd = new Randevu.FrmRandevular();
            rnd.MdiParent = this;
            rnd.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Randevu.FrmRandevuDuzenle rd = new Randevu.FrmRandevuDuzenle();
            rd.MdiParent = this;
            rd.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Randevu.FrmGerceklesenRandevularListesi grl = new Randevu.FrmGerceklesenRandevularListesi();
            grl.MdiParent = this;
            grl.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar.FrmGunlukKasaHareketleri gkh = new Raporlar.FrmGunlukKasaHareketleri();
            gkh.MdiParent = this;
            gkh.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaGiderlerListesi gl = new FrmKasaGiderlerListesi();
            gl.MdiParent = this;
            gl.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Giderler.FrmKasaCikisEkle ge = new Giderler.FrmKasaCikisEkle();
            ge.MdiParent = this;
            ge.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar.FrmKasaHareketleri kh = new Raporlar.FrmKasaHareketleri();
            kh.MdiParent = this;
            kh.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GelirGiderListe.FrmKasaGelirListe gl = new GelirGiderListe.FrmKasaGelirListe();
            gl.MdiParent = this;
            gl.Show();

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporlar.FrmMusteriHareketleri mh = new Raporlar.FrmMusteriHareketleri();
            mh.MdiParent = this;
            mh.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Randevu.FrmBugünGerceklesenRandevuListesi bgr = new Randevu.FrmBugünGerceklesenRandevuListesi();
            bgr.MdiParent = this;
            bgr.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notlar.FrmNotlarListesi nl = new Notlar.FrmNotlarListesi();
            nl.MdiParent = this;
            nl.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notlar.FrmNotEkle ne = new Notlar.FrmNotEkle();
            ne.MdiParent = this;
            ne.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAnaEkran ae = new FrmAnaEkran();
            ae.MdiParent = this;
            ae.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar.FrmKullaniciEkle ke = new Ayarlar.FrmKullaniciEkle();
            //ke.MdiParent = this;
            ke.ShowDialog();
        }

        private void RandevuSistem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void barStaticItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            giris gg = new giris();
            
            gg.Show();
            this.Hide();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notlar.FrmGünlükNotListesi nl = new Notlar.FrmGünlükNotListesi();
            nl.MdiParent = this;
            nl.Show();
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notlar.FrmOnaylıNotlarListesi onl = new Notlar.FrmOnaylıNotlarListesi();
            onl.MdiParent = this;
            onl.Show();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar.FrmSözlesme ss = new Ayarlar.FrmSözlesme();ss.ShowDialog();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ayarlar.FrmLisanslama ll = new Ayarlar.FrmLisanslama();
            ll.ShowDialog();
        }
    }
}
