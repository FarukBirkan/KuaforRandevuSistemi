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

namespace KuaförRandevuSistemi.Tip
{
    public partial class FrmTrasTipEkle : Form
    {
        public FrmTrasTipEkle()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        int id;
        void listele()
        {
            var liste = (from a in db.TblTras
                         select new
                         {
                             a.Id,
                           İşlem =a.TrasTip,
                           Ücret=a.Ucret

                         }).ToList();
            gridControl1.DataSource = liste.ToList();
            gridView1.Columns["Id"].Visible = false ;

        }
       
        void kaydet()
        {
            TblTras tras = new TblTras();
            tras.TrasTip = txttras.Text;
            tras.Ucret = decimal.Parse(txtucret.Text);
            db.TblTras.Add(tras);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Başarılı","Durum");

        }
        private void FrmTrasTipEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            kaydet();
            // kaydet();
            listele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Tip.FrmTrasTipDuzenle duzenle = new FrmTrasTipDuzenle();

         duzenle.lblid.Text=(gridView1.GetFocusedRowCellValue("Id").ToString());
          duzenle.txttras.Text =gridView1.GetFocusedRowCellValue("İşlem").ToString();
         duzenle.txtucret.Text = gridView1.GetFocusedRowCellValue("Ücret").ToString();
            duzenle.ShowDialog();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
