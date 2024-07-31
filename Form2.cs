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
using System.Data.OleDb;
using System.CodeDom;
using System.Windows.Diagnostics;
using Microsoft.VisualBasic;
using System.Threading;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraEditors;

namespace YAZ_CIKART
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        readonly ToolTip tt = new ToolTip();
        public int s = 0;
        Frmsadi sadi = new Frmsadi();
        public string tasi;
        string smukerrer;
        giris giris1 = new giris();
        anasayfa anasayfa1 = new anasayfa();
        yzl yzl1 = new yzl();
        soruekle soruekle1 = new soruekle();
        Sorugoster sorugoster1 = new Sorugoster();
        hazirbelge hazirbelge1 = new hazirbelge();
        Dillekce dillekce1 = new Dillekce();
        Profil profil1 = new Profil();
        XtraReport1 rep = new XtraReport1();

        void Bldr()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select *from duyuru", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                anasayfa1.label1.Text = dr["b1"].ToString();
                anasayfa1.label2.Text = dr["b2"].ToString();
                anasayfa1.label3.Text = dr["b3"].ToString();
                anasayfa1.label4.Text = dr["b4"].ToString();
                anasayfa1.label5.Text = dr["b5"].ToString();
                anasayfa1.label6.Text = dr["b6"].ToString();
                anasayfa1.label7.Text = dr["b7"].ToString();
                anasayfa1.label8.Text = dr["b8"].ToString();
                anasayfa1.label9.Text = dr["b9"].ToString();
                anasayfa1.label10.Text = dr["b10"].ToString();
                anasayfa1.linkLabel1.Text = dr["l1"].ToString();
                anasayfa1.linkLabel2.Text = dr["l2"].ToString();
                anasayfa1.linkLabel3.Text = dr["l3"].ToString();
                anasayfa1.linkLabel4.Text = dr["l4"].ToString();
                anasayfa1.linkLabel5.Text = dr["l5"].ToString();
                anasayfa1.linkLabel6.Text = dr["l6"].ToString();
                anasayfa1.linkLabel7.Text = dr["l7"].ToString();
                anasayfa1.linkLabel8.Text = dr["l8"].ToString();
                anasayfa1.linkLabel9.Text = dr["l9"].ToString();
                anasayfa1.linkLabel10.Text = dr["l10"].ToString();
                anasayfa1.label11.Text = dr["ln1"].ToString();
                anasayfa1.label12.Text = dr["ln2"].ToString();
                anasayfa1.label13.Text = dr["ln3"].ToString();
                anasayfa1.label14.Text = dr["ln4"].ToString();
                anasayfa1.label15.Text = dr["ln5"].ToString();
                anasayfa1.label16.Text = dr["ln6"].ToString();
                anasayfa1.label17.Text = dr["ln7"].ToString();
                anasayfa1.label18.Text = dr["ln8"].ToString();
                anasayfa1.label19.Text = dr["ln9"].ToString();
                anasayfa1.label20.Text = dr["ln10"].ToString();
                dr.Close();
                con.Close();
            }
            if (anasayfa1.label1.Text == "")
            {
                anasayfa1.label1.Visible = false;
            }
            if (anasayfa1.label2.Text == "")
            {
                anasayfa1.label2.Visible = false;
            }
            if (anasayfa1.label3.Text == "")
            {
                anasayfa1.label3.Visible = false;
            }
            if (anasayfa1.label4.Text == "")
            {
                anasayfa1.label4.Visible = false;
            }
            if (anasayfa1.label5.Text == "")
            {
                anasayfa1.label5.Visible = false;
            }
            if (anasayfa1.label6.Text == "")
            {
                anasayfa1.label6.Visible = false;
            }
            if (anasayfa1.label7.Text == "")
            {
                anasayfa1.label7.Visible = false;
            }
            if (anasayfa1.label8.Text == "")
            {
                anasayfa1.label8.Visible = false;
            }
            if (anasayfa1.label9.Text == "")
            {
                anasayfa1.label9.Visible = false;
            }
            if (anasayfa1.label10.Text == "")
            {
                anasayfa1.label10.Visible = false;
            }
            if (anasayfa1.linkLabel1.Text == "")
            {
                anasayfa1.label10.Visible = false;
            }
            dr.Close();
        }

        void Htr()
        {
            giris1.textBox1.Text = Properties.Settings.Default.kadı.ToString();
            giris1.textBox2.Text = Properties.Settings.Default.sifre.ToString();
            giris1.label4.Text = Properties.Settings.Default.resim.ToString();
            if (Properties.Settings.Default.toggle == 0)
            {
                giris1.toggleSwitch1.IsOn = false;
            }
            else
            {
                giris1.toggleSwitch1.IsOn = true;
            }

            if (Properties.Settings.Default.kadı == "Kullanıcı Adı..." && Properties.Settings.Default.sifre == "Şifre...")
            {
                giris1.label4.Text = "";
            }
            timer5.Start();
        }
        public string donem;
        public void Genel()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select *from genel", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                donem = dr["donem"].ToString();
                yzl1.donemyzl = donem;
                dr.Close();
                con.Close();
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void girisil()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, sehir from iller", con);
            da.Fill(dt);
            giris1.lookUpEdit1.Properties.ValueMember = "id";
            giris1.lookUpEdit1.Properties.DisplayMember = "sehir";
            giris1.lookUpEdit1.Properties.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void girisbrans()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id, brans from brans", con);
            da.Fill(dt);
            giris1.lookUpEdit3.Properties.ValueMember = "id";
            giris1.lookUpEdit3.Properties.DisplayMember = "brans";
            giris1.lookUpEdit3.Properties.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void sgsinif()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from sinifler", con);
            da.Fill(dt);
            sorugoster1.lookUpEdit1.Properties.ValueMember = "id";
            sorugoster1.lookUpEdit1.Properties.DisplayMember = "sinif";
            sorugoster1.lookUpEdit1.Properties.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            sorugoster1.lookUpEdit1.Properties.PopulateColumns();
            sorugoster1.lookUpEdit1.Properties.Columns[0].Visible = false;
        }

        void sesinif()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from sinifler", con);
            da.Fill(dt);
            soruekle1.lookUpEdit1.Properties.ValueMember = "id";
            soruekle1.lookUpEdit1.Properties.DisplayMember = "sinif";
            soruekle1.lookUpEdit1.Properties.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            soruekle1.lookUpEdit1.Properties.PopulateColumns();
            soruekle1.lookUpEdit1.Properties.Columns[0].Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bldr();
            Thread.Sleep(20);
            this.Controls.Add(giris1);
            girisil();
            girisbrans();
            giris1.Dock = DockStyle.Fill;;
            giris1.BringToFront();
            Anasayfa_Click(sender, e);
            Yazili_Click(sender, e);
            Soruekle_Click(sender, e);
            Sorular_Click(sender, e);
            //Hazırblg_Click(sender, e);
            Profil_Click(sender, e);
            giris1.BringToFront();
            Htr();
            Genel();
            Anasayfa.Enabled = false;
            Yazili.Enabled = false;
            Sorubnk.Enabled = false;
            Hazirblg.Enabled = false;
            Profil.Enabled = false;
            sesinif();
            timer3.Start();
            timer6.Start();
            giris1.ActiveControl = giris1.textBox1;
            Eventss();
            button11.BringToFront();
            Application.Idle += new EventHandler(Link);
        }
        readonly string dlkc = @"                                       
                                      .................... AÇIK ÖĞRETİM LİSESİ MÜDÜRLÜĞÜNE


        …………………………………. Lisesi …..………………… numaralı öğrencisiyim. Öğrenci Belgemin düzenlenerek tarafıma verilmesi için,
       Gereğini arz ederim.


                                                                                                                                                                 ....07.2020
                                                                                                                                                                 Ad Soyad
Adres :
Telefon:
Eposta:
TC Kimlik No:";
        private void Eventss()
        {
            hazirbelge1.btn1.Click += Btn1_Click;
            hazirbelge1.buttondll.Click += Buttondll_Click;
            sorugoster1.button9.Click += Button9_Click1;
            sadi.button1.Click += Button1_Click1;
            sadi.listView1.Click += ListView1_Click;
            yzl1.Tool7.Click += Tool7_Click;
            sorugoster1.button10.Click += Button10_Click1;
            yzl1.button10.Click += Button10_Click2;
            profil1.button22.Click += Button22_Click;
            yzl1.button6.Click += Button6_Click;
            yzl1.button8.Click += Button8_Click;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Tool7_Click(sender, e);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            rep = new XtraReport1
            {
                FilterString = "[kid] ='" + yzl1.labelkid.Text + "'and [sadi]='" + yzl1.yzlsinavadi + "'"
            };

            rep.Parameters["bas1"].Value = yzl1.richTextBox2.Text;
            rep.RequestParameters = false;
            ReportPrintTool pt = new ReportPrintTool(rep);
            pt.AutoShowParametersPanel = false;
            pt.ShowPreview();
            yzl1.panel1.Visible = false;
        }

        string test;

        private void Button22_Click(object sender, EventArgs e)
        {
            if (profil1.comboBox6.Items.Count > 0)
            {
                tasi = profil1.comboBox6.Text;
                sadi.Labelkid.Text = giris1.labelid.Text;
                sadi.richTextBox1.Text = tasi;
                sadi.ActiveControl = sadi.richTextBox1;
                nere = "yzl";
                sadi.ShowDialog();
                if (test == "tiklandi")
                {
                    sinavadi = sadi.richTextBox1.Text;
                    sorugoster1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                    sorugoster1.sinav = sinavadi;
                    yzl1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                    yzl1.yzlsinavadi = sinavadi;
                    try
                    {
                        if (Convert.ToInt32(sadi.maskedTextBox1.Text) > 20)
                        {
                            sadi.maskedTextBox1.Text = "20";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sınav Sayısı Girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    yzl1.Tool6_Click(sender, e);
                    yzl1.ssayi = Convert.ToInt32(sadi.maskedTextBox1.Text);
                    yzl1.Syap();
                    this.Show();
                    sadi.Hide();
                    Yazili_Click(sender, e);
                    Sonoku();
                    yzl1.llbls.Click += Llbls_Click;
                    test = "";
                    yzl1.button5.Visible = true;
                    yzl1.button8.Visible = false;
                }
            }
            else
            {
                nere = "yzl";
                sadi.Labelkid.Text = giris1.labelid.Text;
                sadi.ActiveControl = sadi.richTextBox1;
                sadi.ShowDialog();
                if (test == "tiklandi")
                {
                    sinavadi = sadi.richTextBox1.Text;
                    sorugoster1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                    sorugoster1.sinav = sinavadi;
                    yzl1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                    yzl1.yzlsinavadi = sinavadi;
                    try
                    {
                        if (Convert.ToInt32(sadi.maskedTextBox1.Text) > 20)
                        {
                            sadi.maskedTextBox1.Text = "20";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Soru Sayısı Girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    yzl1.Tool6_Click(sender, e);
                    yzl1.ssayi = Convert.ToInt32(sadi.maskedTextBox1.Text);
                    yzl1.Syap();
                    this.Show();
                    sadi.Hide();
                    Sorular_Click(sender, e);
                    Sonoku();
                    yzl1.llbls.Click += Llbls_Click;
                    test = "";
                    yzl1.button5.Visible = true;
                    yzl1.button8.Visible = false;
                }
            }
        }

        private void Button10_Click2(object sender, EventArgs e)
        {
            Button10_Click1(sender, e);
        }

        private void Button10_Click1(object sender, EventArgs e)
        {
            test = "tiklandi";
            nere = "yzl";
            sadi.Labelkid.Text = giris1.labelid.Text;
            sadi.ShowDialog();
            if (test == "tiklandi")
            {
                sinavadi = sadi.richTextBox1.Text;
                sorugoster1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                sorugoster1.sinav = sinavadi;
                yzl1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                yzl1.yzlsinavadi = sinavadi;
                try
                {
                    if (Convert.ToInt32(sadi.maskedTextBox1.Text) > 20)
                    {
                        sadi.maskedTextBox1.Text = "20";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sınav Sayısı Girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                yzl1.Tool6_Click(sender, e);
                yzl1.ssayi = Convert.ToInt32(sadi.maskedTextBox1.Text);
                yzl1.Syap();
                this.Show();
                sadi.Hide();
                nere = "sorugoster";
                Sonoku();
                test = "";
                yzl1.button5.Visible = true;
                yzl1.button8.Visible = false;
            }
        }

        private void Tool7_Click(object sender, EventArgs e)
        {
            sadi.Labelkid.Text = giris1.labelid.Text;
            sadi.ShowDialog();
            sadi.richTextBox1.Focus();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            try
            {
                sadi.richTextBox1.Text = sadi.listView1.SelectedItems[0].Text;
                sadi.maskedTextBox1.Focus();
            }
            catch (Exception)
            {
            }
        }
        public string nere;
        public string sinavadi;
        public string sisayi;

        private void Button1_Click1(object sender, EventArgs e)
        {
            test = "tiklandi";
            if (nere == "sorugoster")
            {
                sinavadi = sadi.richTextBox1.Text;
                sisayi = sadi.maskedTextBox1.Text;
                sorugoster1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                sorugoster1.sinav = sinavadi;
                yzl1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                yzl1.yzlsinavadi = sinavadi;
                try
                {
                    if (Convert.ToInt32(sadi.maskedTextBox1.Text) > 20)
                    {
                        sadi.maskedTextBox1.Text = "20";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Soru Sayısı Girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                yzl1.ssayi = Convert.ToInt32(sadi.maskedTextBox1.Text);
                yzl1.Syap();
                this.Show();
                sadi.Hide();
                Sonoku();
                yzl1.button5.Visible = true;
                Sinavkayit();
                yzl1.llbls.Click += Llbls_Click;
                yzl1.button8.Visible = false;
            }
            else if (nere == "yzl")
            {
                sinavadi = sadi.richTextBox1.Text;
                sisayi = sadi.maskedTextBox1.Text;
                sorugoster1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                sorugoster1.sinav = sinavadi;
                yzl1.labelsinav.Text = "Sınav Adı: " + sinavadi;
                yzl1.yzlsinavadi = sinavadi;
                try
                {
                    if (Convert.ToInt32(sadi.maskedTextBox1.Text) > 20)
                    {
                        sadi.maskedTextBox1.Text = "20";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Soru Sayısı Girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                yzl1.Tool6_Click(sender, e);
                yzl1.ssayi = Convert.ToInt32(sadi.maskedTextBox1.Text);
                yzl1.Syap();
                this.Show();
                sadi.Hide();
                Sonoku();
                yzl1.llbls.Click += Llbls_Click;
                yzl1.button5.Visible = true;
                yzl1.button8.Visible = false;
            }
        }

        private void Llbls_Click(object sender, EventArgs e)
        {
            yzl1.panel1.Visible = true;
            yzl1.panel1.BringToFront();
            yzl1.richTextBox2.Focus();
        }

        public void Link(object sender, EventArgs e)
        {
            var llbl = yzl1.flowLayoutPanel1.Controls.OfType<LinkLabel>().Count();
            sorugoster1.LabelLink.Text = llbl.ToString();
        }

        void sorusil()
        {
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("DELETE FROM sinav where kid='" + giris1.labelid.Text + "' and sadi='" + sorugoster1.sinav + "' and sid='" + sorugoster1.labelsid.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            yzl1.llbl[Convert.ToInt32(sorugoster1.mid) - 1].LinkColor = Color.Red;
            yzl1.grp[Convert.ToInt32(sorugoster1.mid) - 1].Controls.Clear();
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 1000;
            args.Caption = "Tamamlandı";
            args.Text = "Soru Sınavdan Çıkartıldı.";
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.DefaultButtonIndex = 1;
            args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            XtraMessageBox.Show(args).ToString();
        }

        private void Button9_Click1(object sender, EventArgs e)
        {
            test = "tiklandi";
            if (sorugoster1.btn9drm == "+")
            {
                if (Convert.ToInt32(sorugoster1.LabelLink.Text) < 1)
                {
                    sadi.Labelkid.Text = giris1.labelid.Text;
                    sadi.ShowDialog();
                    Sonoku();
                    this.Show();
                    sadi.Hide();
                }
                else
                {
                    if (sorugoster1.labelsinav.Text != "")
                    {
                        if (test == "tiklandi")
                        {
                            Sinavkayit();
                            yzl1.button5.Visible = true;
                            yzl1.button8.Visible = false;
                            test = "tiklandi";
                        }
                    }
                    else
                    {
                        sadi.Labelkid.Text = giris1.labelid.Text;
                        sadi.maskedTextBox1.Visible = false;
                        sadi.Labelsorusayi.Visible = false;
                        sadi.label3.Visible = false;
                        sadi.ShowDialog();
                        this.Show();
                        Sinavkayit();
                        yzl1.button5.Visible = true;
                        yzl1.button8.Visible = false;
                        sadi.Hide();
                    }
                }
            }
            else if (sorugoster1.btn9drm == "-")
            {
                if (test == "tiklandi")
                {
                    sorusil();
                    test = "tiklandi";
                }
            }
            sorugoster1.Artieksi();
            test = "";
        }

        void mukerrer()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select *from sinav WHERE kid='" + giris1.labelid.Text + "' AND sadi='" + sinavadi + "' AND sid='" + sorugoster1.labelsid.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                smukerrer = dr["sid"].ToString();
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void Sinavkayit()
        {
            mukerrer();
            if (smukerrer != sorugoster1.labelsid.Text)
            {
                eksik();
                if (eksikk < 1)
                {
                    Sonoku();
                    if (sinavadi != null)
                    {
                        SqlCommand cmd = new SqlCommand("Insert Into sinav(sid,kid,durum,stur,sinif,ders,konu,mid,sadi,sisayi) Values (@sid,@kid,@durum,@stur,@sinif,@ders,@konu,@mid,@sadi,@sisayi)", con);
                        cmd.Parameters.AddWithValue("@sid", sorugoster1.labelsid.Text);
                        cmd.Parameters.AddWithValue("@kid", sorugoster1.labelid.Text);
                        cmd.Parameters.AddWithValue("@durum", 0);
                        cmd.Parameters.AddWithValue("@stur", sorugoster1.labeltur.Text);
                        cmd.Parameters.AddWithValue("@sinif", sorugoster1.lookUpEdit1.Text);
                        cmd.Parameters.AddWithValue("@ders", sorugoster1.lookUpEdit2.Text);
                        cmd.Parameters.AddWithValue("@konu", sorugoster1.lookUpEdit3.Text);
                        cmd.Parameters.AddWithValue("@mid", s + 1);
                        cmd.Parameters.AddWithValue("@sadi", sinavadi);
                        cmd.Parameters.AddWithValue("@sisayi", sisayi);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        //MessageBox.Show("Soru Sınava Eklendi","Kayıt Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                        args.AutoCloseOptions.Delay = 1000;
                        args.Caption = "Tamamlandı";
                        args.Text = "Soru Sınava Eklendi";
                        args.Buttons = new DialogResult[] { DialogResult.OK };
                        args.DefaultButtonIndex = 1;
                        args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        XtraMessageBox.Show(args).ToString();
                        s += 1;
                        yzl1.button5.Visible = true;
                        yzl1.button8.Visible = false;
                    }
                }
                else
                {
                    if (sinavadi != null)
                    {
                        SqlCommand cmd = new SqlCommand("Insert Into sinav(sid,kid,durum,stur,sinif,ders,konu,mid,sadi,sisayi) Values (@sid,@kid,@durum,@stur,@sinif,@ders,@konu,@mid,@sadi,@sisayi)", con);
                        cmd.Parameters.AddWithValue("@sid", sorugoster1.labelsid.Text);
                        cmd.Parameters.AddWithValue("@kid", sorugoster1.labelid.Text);
                        cmd.Parameters.AddWithValue("@durum", 0);
                        cmd.Parameters.AddWithValue("@stur", sorugoster1.labeltur.Text);
                        cmd.Parameters.AddWithValue("@sinif", sorugoster1.lookUpEdit1.Text);
                        cmd.Parameters.AddWithValue("@ders", sorugoster1.lookUpEdit2.Text);
                        cmd.Parameters.AddWithValue("@konu", sorugoster1.lookUpEdit3.Text);
                        cmd.Parameters.AddWithValue("@mid", eksikk);
                        cmd.Parameters.AddWithValue("@sadi", sinavadi);
                        cmd.Parameters.AddWithValue("@sisayi", sisayi);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        //MessageBox.Show("Soru Sınava Eklendi.");
                        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                        args.AutoCloseOptions.Delay = 1000;
                        args.Caption = "Tamamlandı";
                        args.Text = "Soru Sınava Eklendi";
                        args.Buttons = new DialogResult[] { DialogResult.OK };
                        args.DefaultButtonIndex = 1;
                        args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        XtraMessageBox.Show(args).ToString();
                        yzl1.button5.Visible = true;
                        yzl1.button8.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu Soru Sınavınızda Mevcut");
            }
        }

        void Sonoku()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT mid FROM sinav WHERE kid='" + giris1.labelid.Text + "' and sadi='" + sinavadi + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                s = Convert.ToInt32(dr["mid"]);
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        int eksikk;
        int sayi;

        void eksik()
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("with tally (eksik) AS (SELECT TOP (SELECT MAX(mid) FROM sinav where kid='" + giris1.labelid.Text + "' and sadi='" + sinavadi + "' ) ROW_NUMBER() OVER (ORDER BY t1.Object_ID) AS eksik FROM Yusuf.sys.All_Columns t1 CROSS JOIN Yusuf.sys.All_Columns t2)SELECT eksik FROM tally WHERE NOT EXISTS (SELECT * FROM sinav WHERE kid='" + giris1.labelid.Text + "' and sadi='" + sinavadi + "' and mid = eksik)", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    eksikk = Convert.ToInt32(dr["eksik"]);
                }
                dr.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Buttondll_Click(object sender, EventArgs e)
        {
            dillekce1.BringToFront();
            dillekce1.richTextBox1.Clear();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            dillekce1.BringToFront();
            dillekce1.richTextBox1.Text = dlkc;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (giris1.label3.Text == "0" || giris1.label3.Text == "1" || giris1.label3.Text == "2")
            {
                Anasayfa.Enabled = true;
                Yazili.Enabled = true;
                Sorubnk.Enabled = true;
                Hazirblg.Enabled = true;
                Profil.Enabled = true;
                Oturum.Enabled = true;
                Giris.Visible = false;
                anasayfa1.BringToFront();
                cikis.Text = "Oturum Kapat";
            }
            if (giris1.labelid.Text != "")
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd3 = new SqlCommand("Select count (*) as sayi From soru WHERE KID like '" + giris1.labelid.Text + "%'", con);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    profil1.label15.Text = profil1.label15.Text + " " + dr3["sayi"].ToString(); ;
                }
                dr3.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd2 = new SqlCommand("Select count (*) as onay From soru WHERE KID like '" + giris1.labelid.Text + "%' and durum='" + 2 + "'", con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    profil1.label16.Text = profil1.label16.Text + " " + dr2["onay"].ToString(); ;
                }
                dr2.Close();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select *from profil WHERE Id='" + giris1.labelid.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    profil1.textBox1.Text = dr["AD"].ToString();
                    profil1.textBox3.Text = dr["BRANS"].ToString();
                    profil1.textBox5.Text = dr["MAIL"].ToString();
                    profil1.textBox4.Text = dr["KADI"].ToString();
                    profil1.label1.Text = dr["KADI"].ToString();
                    profil1.label10.Text = dr["RESIM"].ToString();
                    profil1.label11.Text = dr["Id"].ToString();
                    profil1.button4.Text = dr["SINIF"].ToString();
                    profil1.button5.Text = dr["SINIF2"].ToString();
                    profil1.button6.Text = dr["SINIF3"].ToString();
                    profil1.button7.Text = dr["SINIF4"].ToString();
                    profil1.button8.Text = dr["SINIF5"].ToString();
                    profil1.button9.Text = dr["SINIF6"].ToString();
                    profil1.button10.Text = dr["SINIF7"].ToString();
                    profil1.button11.Text = dr["SINIF8"].ToString();
                    profil1.button12.Text = dr["SINIF9"].ToString();
                    profil1.button13.Text = dr["SINIF10"].ToString();
                    profil1.button15.Text = dr["OKUL"].ToString();
                    profil1.button17.Text = dr["OKUL2"].ToString();
                    profil1.button18.Text = dr["OKUL3"].ToString();
                    profil1.button19.Text = dr["OKUL4"].ToString();
                    profil1.button20.Text = dr["OKUL5"].ToString();
                    profil1.label17.Text = profil1.label17.Text + " " + Convert.ToDateTime((dr["KTARIHI"])).ToString("MMM" + " " + "yyyy");
                    dr.Close();
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                if (profil1.button4.Text != "")
                {
                    profil1.button4.Visible = true;
                }
                if (profil1.button5.Text != "")
                {
                    profil1.button5.Visible = true;
                }
                if (profil1.button6.Text != "")
                {
                    profil1.button6.Visible = true;
                }
                if (profil1.button7.Text != "")
                {
                    profil1.button7.Visible = true;
                }
                if (profil1.button8.Text != "")
                {
                    profil1.button8.Visible = true;
                }
                if (profil1.button9.Text != "")
                {
                    profil1.button9.Visible = true;
                }
                if (profil1.button10.Text != "")
                {
                    profil1.button10.Visible = true;
                }
                if (profil1.button11.Text != "")
                {
                    profil1.button11.Visible = true;
                }
                if (profil1.button12.Text != "")
                {
                    profil1.button12.Visible = true;
                }
                if (profil1.button13.Text != "")
                {
                    profil1.button13.Visible = true;
                }
                if (profil1.button15.Text != "")
                {
                    profil1.button15.Visible = true;
                }
                if (profil1.button17.Text != "")
                {
                    profil1.button17.Visible = true;
                }
                if (profil1.button18.Text != "")
                {
                    profil1.button18.Visible = true;
                }
                if (profil1.button19.Text != "")
                {
                    profil1.button19.Visible = true;
                }
                if (profil1.button20.Text != "")
                {
                    profil1.button20.Visible = true;
                }
                timer3.Stop();
                dr.Close();
                profil1.Oku();
            }
        }

        public void Button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button11_Enter(object sender, EventArgs e)
        {
        }
        public Form1 frm1 = new Form1();

        public void Button12_Click(object sender, EventArgs e)
        {
            frm1.ShowDialog();
        }

        //Dark Mode
        private void Timer5_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.renk == "1")
            {
                foreach (var item in profil1.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).BackColor = Color.Black;
                        ((TextBox)item).ForeColor = Color.White;
                        profil1.BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(Label))
                    {
                        ((Label)item).ForeColor = Color.White;
                        profil1.panel1.BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).ForeColor = Color.White;
                        ((Button)item).BackColor = Color.Black;
                    }
                }
                foreach (var item in this.Controls)
                {
                    if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).BackColor = Color.Black;
                        this.BackColor = Color.Black;
                    }
                }
                foreach (var item in giris1.groupBox2.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).BackColor = Color.Black;
                        ((TextBox)item).ForeColor = Color.White;
                        giris1.BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(Label))
                    {
                        ((Label)item).ForeColor = Color.White;
                    }
                    if (item.GetType() == typeof(LinkLabel))
                    {
                        ((LinkLabel)item).LinkColor = Color.White;
                    }
                    if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).ForeColor = Color.White;
                        ((Button)item).BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(PictureBox))
                    {
                        ((PictureBox)item).BackColor = Color.White;
                    }
                    if (item.GetType() == typeof(Panel))
                    {
                        ((Panel)item).BackColor = Color.White;
                    }
                    if (item.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)item).BackColor = Color.Black;
                        ((CheckBox)item).ForeColor = Color.White;
                    }
                }
                foreach (var item in giris1.groupBox1.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).BackColor = Color.Black;
                        ((TextBox)item).ForeColor = Color.White;
                        giris1.BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(Label))
                    {
                        ((Label)item).ForeColor = Color.White;
                    }
                    if (item.GetType() == typeof(LinkLabel))
                    {
                        ((LinkLabel)item).LinkColor = Color.White;
                    }
                    if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).ForeColor = Color.White;
                        ((Button)item).BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(PictureBox))
                    {
                        ((PictureBox)item).BackColor = Color.White;
                    }
                    if (item.GetType() == typeof(Panel))
                    {
                        ((Panel)item).BackColor = Color.White;
                    }
                    if (item.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)item).BackColor = Color.Black;
                        ((CheckBox)item).ForeColor = Color.White;
                    }
                }
                foreach (var item in hazirbelge1.Controls)
                {
                    if (item.GetType() == typeof(FlowLayoutPanel))
                    {
                        ((FlowLayoutPanel)item).BackColor = Color.Black;
                        ((FlowLayoutPanel)item).ForeColor = Color.White;
                        hazirbelge1.BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(Label))
                    {
                        ((Label)item).ForeColor = Color.White;
                    }
                    if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).ForeColor = Color.White;
                        ((Button)item).BackColor = Color.Black;
                    }
                }

                foreach (var item in dillekce1.panel1.Controls)
                {
                    if (item.GetType() == typeof(Panel))
                    {
                        ((Panel)item).BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).ForeColor = Color.White;
                        ((Button)item).BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(RichTextBox))
                    {
                        ((RichTextBox)item).ForeColor = Color.White;
                        ((RichTextBox)item).BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(MaskedTextBox))
                    {
                        ((MaskedTextBox)item).ForeColor = Color.White;
                        ((MaskedTextBox)item).BackColor = Color.Black;
                    }
                    if (item.GetType() == typeof(PictureBox))
                    {
                        ((PictureBox)item).BackColor = Color.DarkGray;
                    }
                }
                foreach (var item in dillekce1.Controls)
                {
                    if (item.GetType() == typeof(Panel))
                    {
                        ((Panel)item).BackColor = Color.Black;
                        dillekce1.BackColor = Color.Black;
                    }
                }
            }
            timer5.Stop();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
        }

        private void Button11_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button11, "Kapat");
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            if (profil1.label11.Text != "")
            {
                Properties.Settings.Default.resim = profil1.label11.Text;
                Properties.Settings.Default.Save();
                timer6.Stop();
            }
        }

        private void menugiris_Click(object sender, EventArgs e)
        {
        }
        int cta = 0;
        private void Anasayfa_Click(object sender, EventArgs e)
        {
            if (cta != 1)
            {
                anasayfa1.Dock = DockStyle.Fill;
                this.Controls.Add(anasayfa1);
            }
            anasayfa1.BringToFront();
            cta = 1;
        }
        int cty = 0;
        private void Yazili_Click(object sender, EventArgs e)
        {
            if (cty != 1)
            {
                yzl1.Dock = DockStyle.Fill;
                this.Controls.Add(yzl1);
            }
            yzl1.BringToFront();
            yzl1.labelkid.Text = giris1.labelid.Text;
            nere = "yzl";
            cty = 1;
        }
        int ctse = 0;
        private void Soruekle_Click(object sender, EventArgs e)
        {
            if (ctse != 1)
            {
                soruekle1.Dock = DockStyle.Fill;
                this.Controls.Add(soruekle1);
            }
            soruekle1.labelid.Text = giris1.labelid.Text;
            soruekle1.BringToFront();
            ctse = 1;
        }

        int ctsg = 0;

        private void Sorular_Click(object sender, EventArgs e)
        {
            if (ctsg != 1)
            {
                this.Controls.Add(sorugoster1);
                sorugoster1.Dock = DockStyle.Fill;
                sgsinif();              
                sorugoster1.Gridonay();
                var count = sorugoster1.dataGridView1.Rows.Count;
                if (count! > 1)
                {
                    sorugoster1.Txtgec();
                }

            }

            if (giris1.label3.Text == "0" || giris1.label3.Text == "1")
            {
                sorugoster1.comboBox4.Visible = false;
                sorugoster1.button3.Visible = false;
                sorugoster1.button4.Visible = false;
                sorugoster1.button5.Visible = false;
            }
            else if (giris1.label3.Text == "2")
            {
                sorugoster1.comboBox4.Visible = true;
                sorugoster1.button3.Visible = true;
                sorugoster1.button4.Visible = true;
                sorugoster1.button5.Visible = true;
            }
            sorugoster1.labelid.Text = giris1.labelid.Text;
            sorugoster1.BringToFront();
            sorugoster1.panel1.Focus();
            nere = "sorugoster";
            ctsg = 1;
            sorugoster1.Artieksi();
        }

        private void Hazırblg_Click(object sender, EventArgs e)
        {
            if (giris1.label3.Text == "0" || giris1.label3.Text == "1")
            {
                dillekce1.button1.Visible = false;
                dillekce1.maskedTextBox1.Visible = false;
                dillekce1.pictureBox1.Visible = false;
            }
            hazirbelge1.BringToFront();
        }
        int ctp = 0;
        private void Profil_Click(object sender, EventArgs e)
        {
            if (ctp != 1)
            {
                profil1.Dock = DockStyle.Fill;
                this.Controls.Add(profil1);
                profil1.textBox7.Visible = false;
                profil1.button21.Location = new Point(409, 275);
                profil1.textBox6.Visible = false;
                profil1.button3.Location = new Point(409, 349);
                profil1.Oku();
            }
            nere = "yzl";
            profil1.BringToFront();
            ctp = 1;
        }

        private void accordionControl1_StateChanged(object sender, EventArgs e)
        {
            //menü aç kapa
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.kadı = "Kullanıcı Adı...";
            Properties.Settings.Default.sifre = "Şifre...";
            Properties.Settings.Default.resim = "";
            Properties.Settings.Default.Save();

            Application.Restart();
        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {
            //frm1.ShowDialog();
            dene dn = new dene();
            dn.ShowDialog();
        }

        Point İlkkonum;
        bool durum = false;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            İlkkonum = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                tt.SetToolTip(button1, "Aşağı Geri Getir");
            }
            else
            {
                tt.SetToolTip(button1, "Ekranı Kapla");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button2, "Simge Durumuna Küçült");
        }
    }
}
