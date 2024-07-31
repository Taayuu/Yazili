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
    public partial class Frmsadi : Form
    {
        public Frmsadi()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
#pragma warning disable IDE0052 // Okunmamış özel üyeleri kaldır
        readonly SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
#pragma warning restore IDE0052 // Okunmamış özel üyeleri kaldır
        private void Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmsadi_Load(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            Oku();
        }

        public void Oku()
        {
            listView1.Items.Clear();
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select distinct sadi,sisayi from sinav where kid='" + Labelkid.Text + "'", con)
            {
                CommandType = CommandType.Text
            };

            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //listView1.Items.Add(dr["sadi"].ToString() +" ("+ dr["sisayi"].ToString()+")");
                listView1.Items.Add(dr["sadi"].ToString());
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void MaskedTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(maskedTextBox1.Text) > 20)
                {
                    maskedTextBox1.Text = "20";
                }
            }
            catch (Exception)
            {
                //maskedTextBox1.Text = "01";
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = listView1.SelectedItems[0].Text;
                maskedTextBox1.Focus();
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("select distinct sadi,sisayi from sinav where kid='" + Labelkid.Text + "'", con)
                {
                    CommandType = CommandType.Text
                };
                SqlDataReader dr;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    maskedTextBox1.Text = dr["sisayi"].ToString();
                }
                dr.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                maskedTextBox1.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            maskedTextBox1.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select distinct sadi,sisayi from sinav where kid='" + Labelkid.Text + "'", con)
            {
                CommandType = CommandType.Text
            };
            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (richTextBox1.Text == dr["sadi"].ToString())
                {
                    maskedTextBox1.Text = dr["sisayi"].ToString();
                    maskedTextBox1.Enabled = false;
                }
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select distinct sadi,sisayi from sinav where kid='" + Labelkid.Text + "'", con)
            {
                CommandType = CommandType.Text
            };
            SqlDataReader dr;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (richTextBox1.Text == dr["sadi"].ToString())
                {
                    maskedTextBox1.Text = dr["sisayi"].ToString();
                    maskedTextBox1.Enabled = false;
                }
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
