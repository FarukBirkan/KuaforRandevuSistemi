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
    public partial class FrmNotEkle : Form
    {
        public FrmNotEkle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var listele = (from a in db.TblNotlar
                           select new
                           {   a.Id,
                               a.Tarih,
                               a.Baslik,
                               a.Icerik,
                               a.Durum
                           }).ToList();
            gridControl1.DataSource = listele.ToList();
            gridView1.Columns["Id"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

        }
        private void FrmNotEkle_Load(object sender, EventArgs e)
        {
         //   radiodurum.Checked = false;
            listele();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TblNotlar ntl = new TblNotlar();
            ntl.Tarih =DateTime.Parse(datetarih.Text);
            ntl.Durum = false;
            ntl.Icerik = txticerik.Text;
            ntl.Baslik = txtbaslik.Text;
            db.TblNotlar.Add(ntl);
            db.SaveChanges();
            XtraMessageBox.Show("Not Eklendi ","Durum");
            listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Notlar.FrmNotDüzenle nd = new FrmNotDüzenle();
            nd.datetarih.EditValue = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            nd.lblid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            nd.checkEdit1.Checked =bool.Parse(gridView1.GetFocusedRowCellValue("Durum").ToString());
            nd.txticerik.Text = gridView1.GetFocusedRowCellValue("Icerik").ToString();
            nd.txtbaslik.Text = gridView1.GetFocusedRowCellValue("Baslik").ToString();
            nd.ShowDialog();
        }
    }
}
