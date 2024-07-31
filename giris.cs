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
using System.Data.OleDb;
using System.IO;
using DevExpress.XtraEditors;
using System.Net.Mail;

namespace YAZ_CIKART
{
    public partial class giris : UserControl
    {
        public giris()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter dat = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        OpenFileDialog dosya;

        private void button1_Click(object sender, EventArgs e)
        {
            string DURUM;
            string rsm;
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from profil WHERE KADI='" + textBox1.Text + "' AND SIFRE='" + textBox2.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DURUM = dr["DURUM"].ToString();
                label3.Text = DURUM;
                labelid.Text = dr["Id"].ToString();
                rsm = dr["RESIM"].ToString();
                //label7.Text= dr["RENK"].ToString();
                dr.Close();
                con.Close();
                if (toggleSwitch1.IsOn)
                {
                    Properties.Settings.Default.kadı = textBox1.Text;
                    Properties.Settings.Default.sifre = textBox2.Text;
                    Properties.Settings.Default.resim = label4.Text;
                    Properties.Settings.Default.toggle = 1;
                }
                else
                {
                    //Properties.Settings.Default[""] = textBox1.Text;
                    //Properties.Settings.Default[""] = textBox2.Text;
                    //Properties.Settings.Default[""] = "";
                    Properties.Settings.Default.kadı = "Kullanıcı Adı...";
                    Properties.Settings.Default.sifre = "Şifre...";
                    Properties.Settings.Default.toggle = 0;
                }
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
                con.Close();
            }
            dr.Close();
            con.Close();
        }

        void grid()
        {
            if (label4.Text != "")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                da = new SqlDataAdapter("Select RESIM From profil where Id='" + label4.Text + "'", con);
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
                try
                {
                    byte[] resim1 = (byte[])dataGridView1.Rows[0].Cells[0].Value;
                    MemoryStream ms = new MemoryStream(resim1);
                    pictureBox3.Image = Image.FromStream(ms);
                }
                catch (Exception hata)
                {
                    timer2.Stop();
                    //MessageBox.Show("Resim Yüklenemedi" + hata.Message);
                    pictureBox3.Image = Properties.Resources.Profil;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        byte[] resimm;
        byte[] resim;
        string kadimuk;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "Ad Soyad..." && textBox4.Text != "Kullanıcı Adı..." && textBox5.Text != "Şifre Tekrar..." && textBox3.Text != "Şifre..." && textBox4.Text != "Kullanıcı Adı..." && textEdit1.Text != "Mail Adresi..." && lookUpEdit3.Text != "Branş Seçiniz..." && textBox9.Text != "Okul..." && textBox6.Text != " " && textBox4.Text != " " && textBox5.Text != " " && textBox3.Text != " " && textBox4.Text != " " && textEdit1.Text != " " && lookUpEdit3.Text != " " && textBox9.Text != " ")
            {
                if (label5.Text == "" && label6.Text == "")
                {
                    if (dosya != null)
                    {
                        resimm = System.IO.File.ReadAllBytes(dosya.FileName);
                        SqlCommand cmd = new SqlCommand("Insert Into profil(AD,OKUL,BRANS,KADI,SIFRE,RESIM,DURUM,MAIL,RENK) Values (@AD,@OKUL,@BRANS,@KADI,@SIFRE,@RESIM,@DURUM,@MAIL,@RENK)", con);
                        cmd.Parameters.AddWithValue("@AD", textBox6.Text);
                        cmd.Parameters.AddWithValue("@OKUL", textBox9.Text);
                        cmd.Parameters.AddWithValue("@BRANS", lookUpEdit3.Text);
                        cmd.Parameters.AddWithValue("@RESIM", resimm);
                        cmd.Parameters.AddWithValue("@KADI", textBox4.Text);
                        cmd.Parameters.AddWithValue("@SIFRE", textBox3.Text);
                        cmd.Parameters.AddWithValue("@MAIL", textEdit1.Text);
                        cmd.Parameters.AddWithValue("@DURUM", 0);
                        cmd.Parameters.AddWithValue("@RENK", 0);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        Properties.Settings.Default.resim = label4.Text;
                        Properties.Settings.Default.Save();
                        //MessageBox.Show("Kayıt tamamlandı. Yönlendiriliyorsunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                        args.AutoCloseOptions.Delay = 3000;
                        args.Caption = "Kayıt tamamlandı";
                        args.Text = "Kayıt tamamlandı. Yönlendiriliyorsunuz... 👍";
                        args.Buttons = new DialogResult[] { DialogResult.OK };
                        args.DefaultButtonIndex = 1;
                        args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        XtraMessageBox.Show(args).ToString();
                        string DURUM;
                        string rsm;
                        SqlCommand cmd2 = new SqlCommand("select *from profil WHERE KADI='" + textBox4.Text + "' AND SIFRE='" + textBox3.Text + "'", con);
                        SqlDataReader dr = cmd2.ExecuteReader();
                        if (dr.Read())
                        {
                            DURUM = dr["DURUM"].ToString();
                            label3.Text = DURUM;
                            labelid.Text = dr["Id"].ToString();
                            rsm = dr["RESIM"].ToString();
                            dr.Close();
                            con.Close();
                            Properties.Settings.Default.kadı = textBox4.Text;
                            Properties.Settings.Default.sifre = textBox3.Text;
                            Properties.Settings.Default.resim = label4.Text;
                            Properties.Settings.Default.Save();
                        }
                        dr.Close();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("Insert Into profil(AD,OKUL,BRANS,KADI,SIFRE,DURUM,MAIL,RENK) Values (@AD,@OKUL,@BRANS,@KADI,@SIFRE,@DURUM,@MAIL,@RENK)", con);
                        cmd.Parameters.AddWithValue("@AD", textBox6.Text);
                        cmd.Parameters.AddWithValue("@OKUL", textBox9.Text);
                        cmd.Parameters.AddWithValue("@BRANS", lookUpEdit3.Text);
                        cmd.Parameters.AddWithValue("@KADI", textBox4.Text);
                        cmd.Parameters.AddWithValue("@SIFRE", textBox3.Text);
                        cmd.Parameters.AddWithValue("@MAIL", textEdit1.Text);
                        cmd.Parameters.AddWithValue("@DURUM", 0);
                        cmd.Parameters.AddWithValue("@RENK", 0);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        Properties.Settings.Default.resim = label4.Text;
                        Properties.Settings.Default.Save();
                        //MessageBox.Show("Kayıt tamamlandı. Yönlendiriliyorsunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                        args.AutoCloseOptions.Delay = 3000;
                        args.Caption = "Kayıt tamamlandı";
                        args.Text = "Kayıt tamamlandı. Yönlendiriliyorsunuz... 👍";
                        args.Buttons = new DialogResult[] { DialogResult.OK };
                        args.DefaultButtonIndex = 1;
                        args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        XtraMessageBox.Show(args).ToString();
                        string DURUM;
                        string rsm;
                        SqlCommand cmd2 = new SqlCommand("select *from profil WHERE KADI='" + textBox4.Text + "' AND SIFRE='" + textBox3.Text + "'", con);
                        SqlDataReader dr = cmd2.ExecuteReader();
                        if (dr.Read())
                        {
                            DURUM = dr["DURUM"].ToString();
                            label3.Text = DURUM;
                            labelid.Text = dr["Id"].ToString();
                            rsm = dr["RESIM"].ToString();
                            dr.Close();
                            con.Close();
                            Properties.Settings.Default.kadı = textBox4.Text;
                            Properties.Settings.Default.sifre = textBox3.Text;
                            Properties.Settings.Default.resim = label4.Text;
                            Properties.Settings.Default.Save();
                        }
                        dr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen uyarıları dikkate alarak bilgilerinizi düzenleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            this.ActiveControl = textBox6;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Form2 frm2;
            //if (frm2.panel1.Left <= -229)
            //{
            //    groupBox1.Left -= 10;
            //}
            //else
            //{
            //    groupBox1.Left -= 10;
            //}
            //if (groupBox1.Left <= +70)
            //{
            //    timer1.Stop();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            this.ActiveControl = textBox6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpeg;*.nef;*.png| Tüm Dosyalar |*.*";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox9.Image = Image.FromFile(dosya.FileName);
                }
                catch (Exception)
                {

                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı Adı...")
            {
                textBox1.Clear();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre...")
            {
                textBox2.Clear();
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Ad Soyad...")
            {
                textBox6.Clear();
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Şifre...")
            {
                textBox3.Clear();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Kullanıcı Adı...")
            {
                textBox4.Clear();
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Şifre Tekrar...")
            {
                textBox5.Clear();
            }
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "Okul...")
            {
                textBox9.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı...";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre...";
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Ad Soyad...";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Kullanıcı Adı...";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Şifre...";
                if (textBox3.PasswordChar == '*')
                {
                    textBox3.PasswordChar = '\0';
                }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Şifre Tekrar...";
                if (textBox5.PasswordChar == '*')
                {
                    textBox5.PasswordChar = '\0';
                }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Okul...";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                button1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textEdit1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textEdit1.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textEdit1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox9.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox9.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox5.Focus();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox9.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                button2.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox3.Text == "" || textBox3.Text == "Şifre..." || textBox5.Text == "Şifre Tekrar...")
            {
                label5.Text = "";
                pictureBox5.Image = Properties.Resources.check;
            }
            if (textBox3.Text != "Şifre...")
            {
                pictureBox5.Image = Properties.Resources.foursquare_check_in;
            }
            if (textBox3.Text == "Şifre..." || textBox3.Text == "" || textBox3.Text == " ")
            {
                pictureBox5.Image = Properties.Resources.check;
            }
            textBox3.UseSystemPasswordChar = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox3.Text)
            {
                label5.Text = "*Şifreler aynı değil.";
                pictureBox6.Image = Properties.Resources.check;
            }
            else
            {
                pictureBox6.Image = Properties.Resources.foursquare_check_in;
                label5.Text = "";
            }
            if (textBox5.Text == "" || textBox3.Text == "" || textBox5.Text == "Şifre..." || textBox3.Text == "Şifre Tekrar...")
            {
                label5.Text = "";
            }
            if (textBox5.Text == "Şifre Tekrar..." || textBox5.Text == "" || textBox5.Text == " ")
            {
                pictureBox6.Image = Properties.Resources.check;
            }
            textBox5.UseSystemPasswordChar = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox9.Text != "Mail Adresi...")
            {
                pictureBox10.Image = Properties.Resources.foursquare_check_in;
            }
            if (textBox9.Text == "Mail Adresi..." || textBox9.Text == "" || textBox9.Text == " ")
            {
                pictureBox10.Image = Properties.Resources.check;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.foursquare_check_in;
        }

        private void giris_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            grid();
            timer2.Stop();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id,ilce from ilceler where sehir = '" + lookUpEdit1.EditValue + "'", con);
            da.Fill(dt);
            lookUpEdit2.Properties.ValueMember = "id";
            lookUpEdit2.Properties.DisplayMember = "ilce";
            lookUpEdit2.Properties.DataSource = dt;
            lookUpEdit2.Visible = true;
            lookUpEdit2.Properties.PopulateColumns();
            lookUpEdit2.Properties.Columns[0].Visible = false;
        }

        private void lookUpEdit2_Click(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.Columns[0].Visible = false;
        }

        private void lookUpEdit2_MouseClick(object sender, MouseEventArgs e)
        {
            lookUpEdit2.Properties.Columns[0].Visible = false;
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.foursquare_check_in;
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textEdit1.Text != "Mail Adresi...")
            {
                //pictureBox8.Image = Properties.Resources.foursquare_check_in;
            }
            if (textEdit1.Text == "Mail Adresi..." || textEdit1.Text == "" || textEdit1.Text == " ")
            {
                //pictureBox8.Image = Properties.Resources.check;
            }
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                textEdit1.Text = "Mail";
            }
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "MailAdresi...@ _____")
            {
                textEdit1.Text = "";
            }
        }

        private void lookUpEdit1_MouseEnter(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns[0].Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit3_MouseEnter(object sender, EventArgs e)
        {
            lookUpEdit3.Properties.PopulateColumns();
            lookUpEdit3.Properties.Columns[0].Visible = false;
            lookUpEdit3.Properties.SortColumnIndex = 1;
            lookUpEdit3.Properties.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd3 = new SqlCommand("select KADI from profil WHERE KADI='" + textBox4.Text + "'", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                kadimuk = dr3["KADI"].ToString();
            }
            dr3.Close(); con.Close();

            if (textBox4.Text == kadimuk)
            {
                label6.Text = "*Bu kullanıcı adı kullanılmaktadır.";
                pictureBox4.Image = Properties.Resources.check;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.foursquare_check_in;
                label6.Text = "";
            }
            if (textBox4.Text == "Kullanıcı Adı..." || textBox4.Text == "" || textBox4.Text == " ")
            {
                label6.Text = "";
            }
            if (textBox4.Text == "Kullanıcı Adı..." || textBox4.Text == "" || textBox4.Text == " ")
            {
                pictureBox4.Image = Properties.Resources.check;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "Ad Soyad...")
            {
                pictureBox7.Image = Properties.Resources.foursquare_check_in;
            }
            if (textBox6.Text == "Ad Soyad..." || textBox6.Text == "" || textBox6.Text == " ")
            {
                pictureBox7.Image = Properties.Resources.check;
            }
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.foursquare_check_in;
        }
    }
}
