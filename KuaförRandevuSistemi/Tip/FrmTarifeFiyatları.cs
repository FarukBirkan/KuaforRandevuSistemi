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
    public partial class FrmTarifeFiyatları : Form
    {
        public FrmTarifeFiyatları()
        {
            InitializeComponent();
        }
        DbRandevuEntities3 db = new DbRandevuEntities3();
        private void FrmTarifeFiyatları_Load(object sender, EventArgs e)
        {
            var listele = (from i in db.TblTras
                           select new
                           {
                             İşlem = i.TrasTip,
                               Ücret = i.Ucret
                           }).ToList();
            gridControl1.DataSource = listele.ToList();
        }
    }
}
