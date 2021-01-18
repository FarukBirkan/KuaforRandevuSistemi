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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void kaydet()
        {
            TblMusteri cari = new TblMusteri();
            cari.AdSoyad = txttras.Text;
            cari.Telefon = (txtucret.Text);
            cari.TcKimlikNo = txttcno.Text;
            db.TblMusteri.Add(cari);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Başarılı", "Durum");

        }
        void listele()
        {

            var listele = (from i in db.TblMusteri
                           select new
                           {
                               i.Id,
                               i.AdSoyad,
                               i.Telefon,
                               i.TcKimlikNo,

                           }).ToList();
            gridControl1.DataSource = listele.ToList();
            gridView1.Columns["Id"].Visible = false;
        }
        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
            listele();

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Musteri.FrmMusteriDuzenle duzenle = new FrmMusteriDuzenle ();

            duzenle.lblid.Text = (gridView1.GetFocusedRowCellValue("Id").ToString());
            duzenle.txttras.Text = gridView1.GetFocusedRowCellValue("AdSoyad").ToString();
            duzenle.txtucret.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            duzenle.txttckimlikno.Text = gridView1.GetFocusedRowCellValue("TcKimlikNo").ToString();
            duzenle.ShowDialog();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txttcno.Text = "00000000000";
            txttras.Text = "";
            txtucret.Text = "";
        }
    }
}
