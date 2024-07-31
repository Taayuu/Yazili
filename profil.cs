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
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Configuration;
using System.Windows.Documents;
using System.IO;

namespace YAZ_CIKART
{
    public partial class Profil : UserControl
    {
        public Profil()
        {
            InitializeComponent();
        }

        OpenFileDialog dosya;
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        private void Button1_Click(object sender, EventArgs e)
        {
            dosya = new OpenFileDialog
            {
                Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar |*.*"
            };
            dosya.ShowDialog();
            try
            {
                pictureBox3.Image = Image.FromFile(dosya.FileName);
            }
            catch (Exception)
            {

            }
        }
        string kadimuk;
        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            if (con2.State == ConnectionState.Closed)
            {
                con2.Open();
            }
            SqlCommand cmd3 = new SqlCommand("select KADI from profil WHERE KADI='" + textBox4.Text + "'", con2);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                kadimuk = dr3["KADI"].ToString();
            }
            dr3.Close(); con2.Close();

            if (textBox4.Text != kadimuk)
            {
                if (dosya != null)
                {
                    byte[] resim = System.IO.File.ReadAllBytes(dosya.FileName);
                    //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SqlCommand cmd = new SqlCommand("update profil set AD=@AD,BRANS=@BRANS,KADI=@KADI,RESIM=@RESIM where Id='" + label11.Text + "'", con);
                    cmd.Parameters.AddWithValue("@AD", textBox1.Text);
                    cmd.Parameters.AddWithValue("@BRANS", textBox3.Text);
                    cmd.Parameters.AddWithValue("@RESIM", resim);
                    cmd.Parameters.AddWithValue("@KADI", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Properties.Settings.Default.resim = label4.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SqlCommand cmd = new SqlCommand("update profil set AD=@AD,BRANS=@BRANS,KADI=@KADI where Id='" + label11.Text + "'", con);
                    cmd.Parameters.AddWithValue("@AD", textBox1.Text);
                    cmd.Parameters.AddWithValue("@BRANS", textBox3.Text);
                    cmd.Parameters.AddWithValue("@KADI", textBox4.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılmakta, lütfen farklı bir isim deneyiniz.");
                textBox4.Focus();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Location == new Point(409, 349))
            {
                button3.Location = new Point(449, 349);
                textBox6.Visible = true;
                textBox6.Focus();
            }
            else if (button3.Location == new Point(449, 349))
            {
                if (textBox6.Text != "")
                {
                    if (button4.Text == "")
                    {
                        button4.Visible = true;
                        button4.Text = textBox6.Text;
                    }
                    else if (button5.Text == "")
                    {
                        button5.Visible = true;
                        button5.Text = textBox6.Text;
                    }
                    else if (button6.Text == "")
                    {
                        button6.Visible = true;
                        button6.Text = textBox6.Text;
                    }
                    else if (button7.Text == "")
                    {
                        button7.Visible = true;
                        button7.Text = textBox6.Text;
                    }
                    else if (button8.Text == "")
                    {
                        button8.Visible = true;
                        button8.Text = textBox6.Text;
                    }
                    else if (button9.Text == "")
                    {
                        button9.Visible = true;
                        button9.Text = textBox6.Text;
                    }
                    else if (button10.Text == "")
                    {
                        button10.Visible = true;
                        button10.Text = textBox6.Text;
                    }
                    else if (button11.Text == "")
                    {
                        button11.Visible = true;
                        button11.Text = textBox6.Text;
                    }
                    else if (button12.Text == "")
                    {
                        button12.Visible = true;
                        button12.Text = textBox6.Text;
                    }
                    else if (button13.Text == "")
                    {
                        button13.Visible = true;
                        button13.Text = textBox6.Text;
                    }
                    textBox6.Clear();
                    Gncl();
                }
                else
                {
                    MessageBox.Show("Sınıf girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox6.Focus();
            }
        }
        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox6.TextLength == 0)
            {
                textBox6.Text += "/";
                timer1.Start();
            }

        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox6.Text != "")
                {
                    if (button4.Text == "")
                    {
                        button4.Visible = true;
                        button4.Text = textBox6.Text;
                    }
                    else if (button5.Text == "")
                    {
                        button5.Visible = true;
                        button5.Text = textBox6.Text;
                    }
                    else if (button6.Text == "")
                    {
                        button6.Visible = true;
                        button6.Text = textBox6.Text;
                    }
                    else if (button7.Text == "")
                    {
                        button7.Visible = true;
                        button7.Text = textBox6.Text;
                    }
                    else if (button8.Text == "")
                    {
                        button8.Visible = true;
                        button8.Text = textBox6.Text;
                    }
                    else if (button9.Text == "")
                    {
                        button9.Visible = true;
                        button9.Text = textBox6.Text;
                    }
                    else if (button10.Text == "")
                    {
                        button10.Visible = true;
                        button10.Text = textBox6.Text;
                    }
                    else if (button11.Text == "")
                    {
                        button11.Visible = true;
                        button11.Text = textBox6.Text;
                    }
                    else if (button12.Text == "")
                    {
                        button12.Visible = true;
                        button12.Text = textBox6.Text;
                    }
                    else if (button13.Text == "")
                    {
                        button13.Visible = true;
                        button13.Text = textBox6.Text;
                        textBox6.Clear();
                        Gncl();
                    }
                }
                else
                {
                    MessageBox.Show("Sınıf girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox6.Focus();
            }
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = null;
            button4.Text = label12.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button4.Text = "";
            Snf();
            button4.Visible = false;
        }
        void Gncl()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF=@SINIF,SINIF2=@SINIF2,SINIF3=@SINIF3,SINIF4=@SINIF4,SINIF5=@SINIF5,SINIF6=@SINIF6,SINIF7=@SINIF7,SINIF8=@SINIF8,SINIF9=@SINIF9,SINIF10=@SINIF10 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF", button4.Text);
            cmd.Parameters.AddWithValue("@SINIF2", button5.Text);
            cmd.Parameters.AddWithValue("@SINIF3", button6.Text);
            cmd.Parameters.AddWithValue("@SINIF4", button7.Text);
            cmd.Parameters.AddWithValue("@SINIF5", button8.Text);
            cmd.Parameters.AddWithValue("@SINIF6", button9.Text);
            cmd.Parameters.AddWithValue("@SINIF7", button10.Text);
            cmd.Parameters.AddWithValue("@SINIF8", button11.Text);
            cmd.Parameters.AddWithValue("@SINIF9", button12.Text);
            cmd.Parameters.AddWithValue("@SINIF10", button13.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Gnclokl()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set OKUL=@OKUL,OKUL2=@OKUL2,OKUL3=@OKUL3,OKUL4=@OKUL4,OKUL5=@OKUL5 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@OKUL", button15.Text);
            cmd.Parameters.AddWithValue("@OKUL2", button17.Text);
            cmd.Parameters.AddWithValue("@OKUL3", button18.Text);
            cmd.Parameters.AddWithValue("@OKUL4", button19.Text);
            cmd.Parameters.AddWithValue("@OKUL5", button20.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF=@SINIF where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF", button4.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            // MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void Snf2()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF2=@SINIF2 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF2", button5.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf3()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF3=@SINIF3 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF3", button6.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf4()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF4=@SINIF4 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF4", button7.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf5()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF5=@SINIF5 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF5", button8.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf6()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF6=@SINIF6 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF6", button9.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf7()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF7=@SINIF7 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF7", button10.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf8()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF8=@SINIF8 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF8", button11.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf9()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF9=@SINIF9 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF9", button12.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Snf10()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set SINIF10=@SINIF10 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@SINIF10", button13.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Okl()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set OKUL=@OKUL where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@OKUL", button15.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Okl2()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set OKUL2=@OKUL2 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@OKUL2", button17.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Okl3()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set OKUL3=@OKUL3 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@OKUL3", button18.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Okl4()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set OKUL4=@OKUL4 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@OKUL4", button19.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void Okl5()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand("update profil set OKUL5=@OKUL5 where Id='" + label11.Text + "'", con);
            cmd.Parameters.AddWithValue("@OKUL5", button20.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            button9.Text = "";
            Snf6();
            button9.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button5.Text = "";
            Snf2();
            button5.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.Text = "";
            Snf3();
            button6.Visible = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button7.Text = "";
            Snf4();
            button7.Visible = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button8.Text = "";
            Snf5();
            button8.Visible = false;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button10.Text = "";
            Snf7();
            button10.Visible = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button11.Text = "";
            Snf8();
            button11.Visible = false;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button12.Text = "";
            Snf9();
            button12.Visible = false;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button13.Text = "";
            Snf10();
            button13.Visible = false;
        }
        readonly ToolTip sil = new ToolTip();
        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button4, "Sil");
            label12.Text = button4.Text;
            button4.Text = " ";
            button4.Image = Properties.Resources.trash;
        }

        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button5, "Sil");
            label12.Text = button5.Text;
            button5.Text = " ";
            button5.Image = Properties.Resources.trash;
        }

        private void Button6_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button6, "Sil");
            label12.Text = button6.Text;
            button6.Text = " ";
            button6.Image = Properties.Resources.trash;
        }

        private void Button7_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button7, "Sil");
            label12.Text = button7.Text;
            button7.Text = " ";
            button7.Image = Properties.Resources.trash;
        }

        private void Button8_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button8, "Sil");
            label12.Text = button8.Text;
            button8.Text = " ";
            button8.Image = Properties.Resources.trash;
        }

        private void Button9_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button9, "Sil");
            label12.Text = button9.Text;
            button9.Text = " ";
            button9.Image = Properties.Resources.trash;
        }

        private void Button10_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button10, "Sil");
            label12.Text = button10.Text;
            button10.Text = " ";
            button10.Image = Properties.Resources.trash;
        }

        private void Button11_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button11, "Sil");
            label12.Text = button11.Text;
            button11.Text = " ";
            button11.Image = Properties.Resources.trash;
        }

        private void Button12_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button12, "Sil");
            label12.Text = button12.Text;
            button12.Text = " ";
            button12.Image = Properties.Resources.trash;
        }

        private void Button13_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button13, "Sil");
            label12.Text = button13.Text;
            button13.Text = " ";
            button13.Image = Properties.Resources.trash;
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Image = null;
            button5.Text = label12.Text;
        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Image = null;
            button6.Text = label12.Text;
        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Image = null;
            button7.Text = label12.Text;
        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Image = null;
            button8.Text = label12.Text;
        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Image = null;
            button9.Text = label12.Text;
        }

        private void Button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Image = null;
            button10.Text = label12.Text;
        }

        private void Button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Image = null;
            button11.Text = label12.Text;
        }

        private void Button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Image = null;
            button12.Text = label12.Text;
        }

        private void Button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Image = null;
            button13.Text = label12.Text;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox6.SelectionStart++;
            timer1.Stop();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Button11_Click(sender, e);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
        public int oklbtn = 0;
        private void Button21_Click(object sender, EventArgs e)
        {
            if (button21.Location == new Point(409, 275))
            {
                button21.Location = new Point(631, 275);
                textBox7.Visible = true;
                textBox7.Focus();
            }
            else if (button21.Location == new Point(631, 275))
            {
                if (textBox7.Text != "")
                {
                    if (button15.Text == "")
                    {
                        button15.Visible = true;
                        button15.Text = textBox7.Text;
                    }
                    else if (button17.Text == "")
                    {
                        button17.Visible = true;
                        button17.Text = textBox7.Text;
                    }
                    else if (button18.Text == "")
                    {
                        button18.Visible = true;
                        button18.Text = textBox7.Text;
                    }
                    else if (button19.Text == "")
                    {
                        button19.Visible = true;
                        button19.Text = textBox7.Text;
                    }
                    else if (button20.Text == "")
                    {
                        button20.Visible = true;
                        button20.Text = textBox7.Text;
                    }
                    textBox7.Clear();
                    textBox7.Focus();
                    Gnclokl();
                }
                else
                {
                    MessageBox.Show("Okul girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void TextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox7.Text != "")
                {
                    if (button15.Text == "")
                    {
                        button15.Visible = true;
                        button15.Text = textBox7.Text;
                    }
                    else if (button17.Text == "")
                    {
                        button17.Visible = true;
                        button17.Text = textBox7.Text;
                    }
                    else if (button18.Text == "")
                    {
                        button18.Visible = true;
                        button18.Text = textBox7.Text;
                    }
                    else if (button19.Text == "")
                    {
                        button19.Visible = true;
                        button19.Text = textBox7.Text;
                    }
                    else if (button20.Text == "")
                    {
                        button20.Visible = true;
                        button20.Text = textBox7.Text;
                    }
                    textBox7.Clear();
                    textBox7.Focus();
                    Gnclokl();
                }
                else
                {
                    MessageBox.Show("Okul girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Button15_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button15, "Sil");
            label12.Text = button15.Text;
            button15.Text = " ";
            button15.Image = Properties.Resources.trash;
        }

        private void Button17_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button17, "Sil");
            label12.Text = button17.Text;
            button17.Text = " ";
            button17.Image = Properties.Resources.trash;
        }

        private void Button18_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button18, "Sil");
            label12.Text = button18.Text;
            button18.Text = " ";
            button18.Image = Properties.Resources.trash;
        }

        private void Button19_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button19, "Sil");
            label12.Text = button19.Text;
            button19.Text = " ";
            button19.Image = Properties.Resources.trash;
        }

        private void Button20_MouseEnter(object sender, EventArgs e)
        {
            sil.SetToolTip(button20, "Sil");
            label12.Text = button20.Text;
            button20.Text = " ";
            button20.Image = Properties.Resources.trash;
        }

        private void Button15_MouseLeave(object sender, EventArgs e)
        {
            button15.Image = null;
            button15.Text = label12.Text;
        }

        private void Button17_MouseLeave(object sender, EventArgs e)
        {
            button17.Image = null;
            button17.Text = label12.Text;
        }

        private void Button18_MouseLeave(object sender, EventArgs e)
        {
            button18.Image = null;
            button18.Text = label12.Text;
        }

        private void Button19_MouseLeave(object sender, EventArgs e)
        {
            button19.Image = null;
            button19.Text = label12.Text;
        }

        private void Button20_MouseLeave(object sender, EventArgs e)
        {
            button20.Image = null;
            button20.Text = label12.Text;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button15.Text = "";
            Okl();
            button15.Visible = false;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button17.Text = "";
            Okl2();
            button17.Visible = false;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button18.Text = "";
            Okl3();
            button18.Visible = false;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button19.Text = "";
            Okl4();
            button19.Visible = false;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button20.Text = "";
            Okl5();
            button20.Visible = false;
        }
        void Grid()
        {
            if (label4.Text != "")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                da = new SqlDataAdapter("Select * From profil where Id='" + label11.Text + "'", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "profil");
                dataGridView1.DataSource = ds.Tables["profil"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (dataGridView1.Rows[0].Cells[24].Value!=DBNull.Value)
                {
                    byte[] resim1 = (byte[])dataGridView1.Rows[0].Cells[24].Value;
                    MemoryStream ms = new MemoryStream(resim1);
                    pictureBox3.Image = Image.FromStream(ms); 
                }
                else
                {
                    pictureBox3.Image = Properties.Resources.Profil;
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (label11.Text != "")
            {
                Grid();
                timer2.Stop();
            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            timer2.Start();
            Oku();
        }

        public void Oku()
        {
            comboBox6.Items.Clear();
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select distinct sadi from sinav where kid='" + label11.Text + "'", con)
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
                comboBox6.Items.Add(dr["sadi"].ToString());
            }
            dr.Close();
            if (comboBox6.Items.Count > 0)
            {
                comboBox6.SelectedIndex = 0;
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void comboBox6_Click(object sender, EventArgs e)
        {
            Oku();
        }
    }
}

