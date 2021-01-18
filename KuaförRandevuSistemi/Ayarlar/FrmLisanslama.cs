using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace KuaförRandevuSistemi.Ayarlar
{
    public partial class FrmLisanslama : Form
    {
        public FrmLisanslama()
        {
            InitializeComponent();
        }
        


        static string Mac()
        {
            ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj in manager.GetInstances())
            {
                if ((bool)obj["IPEnabled"])
                {
                    return obj["MacAddress"].ToString();
                }
            }

            return String.Empty;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txtlisansKey.Text==Properties.Settings.Default.Keys+ "3c7607ee6")
            {
                Properties.Settings.Default.Kullanim = 1;
                Properties.Settings.Default.Save();
                XtraMessageBox.Show("Lisanslama Başarılı","Durum" );
            }
            else
            {
                XtraMessageBox.Show("Lisanslama Geçersiz", "Durum");
            }


        }
        string HDDserialNo = string.Empty;
        private void button2_Click(object sender, EventArgs e) //HDD Seri No
        {
          
        }

        public static List<string> HDDSeriNoCek()
        {
            List<string> serials = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection disks = searcher.Get();
            foreach (ManagementObject disk in disks)
            {
                if (disk["SerialNumber"] == null)
                    serials.Add("");
                else
                    serials.Add(disk["SerialNumber"].ToString());
            }
            return serials;
        }
        private void FrmLisanslama_Load(object sender, EventArgs e)
        {
            
            //List<string> serialsList = HDDSeriNoCek();
            //foreach (string s in serialsList)
            //{
            //    HDDserialNo = HDDserialNo + s;
            //}
            //HDDserialNo = HDDserialNo.TrimStart(); //Baştaki Boşluğu Kaldırıyoruz.
            //lblhdd.Text = HDDserialNo;

            //string bilgisayarAdi = Dns.GetHostName();
            //lblpc.Text = bilgisayarAdi;
            //string mac = Mac();

            //if (String.IsNullOrEmpty(mac))
            //{
            //    XtraMessageBox.Show("Biglisayarınızda bir ağ bağdaştırıcısı bulunamadı.");
            //    lblmac.Text = "0";
            //    //label1.ForeColor = Color.Red;

            //}
            //else
            //{
            //    lblmac.Text = mac;
            //    // labelControl7. ForeColor = Color.Green;
            //}
            //var webClient = new WebClient();

            //string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            //dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;

            //webClient.Dispose();

            //lblıp.Text = dnsString;
         //   Registry.CurrentUser.CreateSubKey("RTS2020");
           // Registry.CurrentUser.SetValue("Key", "05");
          //   Registry.CurrentUser.CreateSubKey("RTS2020").SetValue("Keys", "2147483000");
            // Registry.CurrentUser.CreateSubKey("RTS2020").SetValue(lblpc.Text, "25");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Kullanim = 0;
            Properties.Settings.Default.Save();
            XtraMessageBox.Show("Lisans Anahtarı Silinmiştir","Durum");
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            Ayarlar.FrmSözlesme SS = new FrmSözlesme();
            SS.ShowDialog();
        }
    }
}
