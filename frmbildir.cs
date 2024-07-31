using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAZ_CIKART
{
    public partial class frmbildir : Form
    {
        public frmbildir()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        ToolTip tt = new ToolTip();
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button11,"Kapat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelrd.Text!="")
            {
                SqlCommand cmd = new SqlCommand("Insert Into bildir(baslik,aciklama,kid,durum,sid,etiket) Values (@baslik,@aciklama,@kid,@durum,@sid,@etiket)", con);
                cmd.Parameters.AddWithValue("@baslik", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@aciklama", richTextBox2.Text);
                cmd.Parameters.AddWithValue("@kid", labelid.Text);
                cmd.Parameters.AddWithValue("@sid", labelsid.Text);
                cmd.Parameters.AddWithValue("@etiket", labelrd.Text);
                cmd.Parameters.AddWithValue("@durum", 1);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Gönderildi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Şikayet türü seçilmedi.");
            }
        }
        int x, y, z;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton3.Text;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton4.Text;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton5.Text;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton7.Text;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                labelrd.Text = "";
                labelrd.Text = radioButton6.Text;
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kelsay = richTextBox2.TextLength;
            label3.Text = kelsay + "/150";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            this.BackColor = Color.FromArgb(x, y, z);
        }

        private void frmbildir_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
