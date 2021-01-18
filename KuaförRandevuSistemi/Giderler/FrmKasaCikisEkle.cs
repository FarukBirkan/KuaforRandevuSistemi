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

namespace KuaförRandevuSistemi.Giderler
{
    public partial class FrmKasaCikisEkle : Form
    {
        public FrmKasaCikisEkle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        void listele()
        {
            var liste = (from a in db.TblKasaCikis
                         select new
                         {
                             a.Id,
                             Gider = a.Aciklama,
                             a.Tarih,
                             a.Tutar
                         }).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["Id"].Visible=false;
        }

        private void FrmKasaCikisEkle_Load(object sender, EventArgs e)
        {
            listele();
        }
        void kaydet()
        {
            TblKasaCikis kc = new TblKasaCikis();
            kc.Aciklama = memogider.Text;
            kc.Tarih =DateTime.Parse(datetarih.EditValue.ToString());
            kc.Tutar =decimal.Parse(txttutar.Text);
            db.TblKasaCikis.Add(kc);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Başarılı", "Durum");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Giderler.FrmGiderDüzenle gd = new FrmGiderDüzenle();
            gd.memogider.Text = gridView1.GetFocusedRowCellValue("Gider").ToString();
            gd.txttutar.EditValue = gridView1.GetFocusedRowCellValue("Tutar").ToString();
            gd.datetarih.EditValue = gridView1.GetFocusedRowCellValue("Tarih").ToString();
            gd.lblid.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            gd.ShowDialog();
        }
    }
}
