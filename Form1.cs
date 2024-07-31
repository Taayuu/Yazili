using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YAZ_CIKART
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
        public Form2 frm2;
        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public giris grs;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Properties.Settings.Default.renk = "1";
                //SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                //SqlCommand cmd = new SqlCommand("update profil set RENK=@RENK where Id='" + grs.label4.Text + "'", con);
                //cmd.Parameters.AddWithValue("@RENK", 1);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //foreach (var forms in Application.OpenForms)
                //{
                //    Form2 frm2 = forms as Form2;

                //    if (frm2 != null)
                //        frm2.timer5.Start();
                //}
            }
            if (comboBox1.SelectedIndex == 0)
            {
                Properties.Settings.Default.renk = "0";
                //SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                //SqlCommand cmd = new SqlCommand("update profil set RENK=@RENK where Id='" + grs.label4.Text + "'", con);
                //cmd.Parameters.AddWithValue("@RENK", 0);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //foreach (var forms in Application.OpenForms)
                //{
                //    Form2 frm2 = forms as Form2;

                //    if (frm2 != null)
                //        frm2.timer5.Start();
                //}
            }
            if (MessageBox.Show("Uygulama yeniden başlatılacak. Emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }
        int x, y, z;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            this.BackColor = Color.FromArgb(x, y, z);
        }
    }
}
