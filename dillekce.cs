using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YAZ_CIKART
{
    public partial class Dillekce : UserControl
    {
        public Dillekce()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        readonly SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            //Font myFont = new Font("Arial", 20);
            SolidBrush sbrush = new SolidBrush(richTextBox1.ForeColor);
            //Pen myPen = new Pen(Color.Black);
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, sbrush, 40, 100);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Button11_Click(sender, e);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
        readonly giris grs = new giris();
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dll = new OpenFileDialog
            {
                Filter = "Resim Dosyası |*.jpeg;*.nef;*.png|Tüm Dosyalar |*.*"
            };
            dll.ShowDialog();
            string dosyayolu = dll.FileName;
            pictureBox1.BackgroundImage = Image.FromFile(dosyayolu);
            byte[] resim = System.IO.File.ReadAllBytes(dosyayolu);
            if (dll.FileName!="")
            {
                SqlCommand cmd = new SqlCommand("Insert Into dilekce(disim,dmetin,dresim,kıd) Values (@disim,@dmetin,@dresim,@kıd)", con);
                cmd.Parameters.AddWithValue("@disim", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@dmetin", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@dresim", resim);
                cmd.Parameters.AddWithValue("@kıd", grs.labelid.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); 
            }
            else
            {
                MessageBox.Show("Resim seçilmedi.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
