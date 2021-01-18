using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace KuaförRandevuSistemi
{
    public partial class giris : SplashScreen
    {
        public giris()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        DbRandevuEntities3 db = new DbRandevuEntities3();
        //void sorgu()
        //{
        //    var sor = (from n in TblKullanici
        //               where(n.))
        //}
        public enum SplashScreenCommand
        {
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TblKullanici kk = new TblKullanici();
            TblKullanici durum = db.TblKullanici.Where(a => a.KullaniciAd == lookUpEdit1.Text && a.Sifre==txtsifre.Text).SingleOrDefault();
           
            if (durum==null)
            {
                XtraMessageBox.Show("KULLANICI ADI / ŞİFRE HATALI ","HATA");
            }
            else if(durum !=null)
            {
              //  RandevuSistem rs = new RandevuSistem();
               // rs.barStaticItem2.Caption = txtkullanici.Text;
                RandevuSistem ff = new RandevuSistem();
                lbldurum.Text = (durum.Yetki.ToString());
                ff.barStaticItem2.Caption ="Kullanıcı Adı ="+ lookUpEdit1.Text;
                ff.barStaticItem4.Caption = lbldurum.Text;
                ff.Show();
                this.Hide();
            }

            //this.Close();
           
        }
        void listele()
        {
            var liste = (from a in db.TblKullanici
                         select new
                         {
                             a.Id,
                             a.KullaniciAd
                         }).ToList();
            lookUpEdit1.Properties.DataSource = liste.ToList();
            // lookUpEdit1.Properties.ValueMember
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns["Id"].Visible = false;


        }
        private void giris_Load(object sender, EventArgs e)
        {

            lookUpEdit1.Properties.NullText = "Kullanıcı Seçiniz";
            listele();

          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Ayarlar.FrmLisanslama ll = new Ayarlar.FrmLisanslama();
            ll.ShowDialog();
        }
    }
}