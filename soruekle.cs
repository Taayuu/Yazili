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
using Microsoft.VisualBasic;
using DevExpress.DXTemplateGallery;
using DevExpress.XtraEditors;
using DevExpress.Accessibility;

namespace YAZ_CIKART
{
    public partial class soruekle : UserControl
    {
        public soruekle()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        readonly SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int sols = 0;
        int yuks = 0;
        GroupBox grb;
        RichTextBox[] rcbs;
        Label[] lbl;
        RichTextBox rc1;
        RichTextBox rc2;
        RichTextBox rc3;
        RichTextBox rc4;
        RichTextBox rc5;
        RichTextBox rc6;
        OpenFileDialog dll;
        readonly ToolTip tt = new ToolTip();
        string sec1;
        string sec2;
        string sec3;
        string sec4;
        string sec5;
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (label1.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    if (labeltur.Text != "dy")
                    {
                        labeltur.Text = "cs";
                    }
                    if (labeltur.Text != "dy")
                    {
                        comboBox4.Visible = false;
                        grb = new GroupBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 792,
                            Height = 530,
                            Text = "Soru",
                            Font = new Font("Arial Black", 11),
                            Name = "grp ",
                            BackColor = Color.Transparent
                        };
                        groupBox3.Controls.Add(grb);
                        grb.Location = new Point(sols, yuks);
                        rc1 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 750,
                            Height = 300,//109
                            Font = new Font("Arial Black", 11),
                            Name = "Soru ",
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc1);
                        rc1.Location = new Point(sols + 8, yuks + 25);
                        button3.Enabled = true;
                        i = 1;
                    }
                }
            }
        }
        char alfb;
        int i = 0;
        int l;
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (label1.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    if (labeltur.Text != "dy")
                    {
                        labeltur.Text = "cs";
                    }
                    if (labeltur.Text == "cs")
                    {
                        comboBox4.Visible = true;
                        grb = new GroupBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 792,
                            Height = 530,
                            Text = "Soru",
                            Font = new Font("Arial Black", 11),
                            Name = "grp ",
                            BackColor = Color.Transparent
                        };
                        groupBox3.Controls.Add(grb);
                        grb.Location = new Point(sols, yuks);
                        rc1 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 750,
                            Height = 109,
                            Font = new Font("Arial Black", 11),
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc1);
                        rc1.Location = new Point(sols + 8, yuks + 25);
                        rc2 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec1,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc2);
                        rc2.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc3 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec2,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc3);
                        rc3.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc4 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec3,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc4);
                        rc4.Location = new Point(sols + 28, yuks + 150);
                        lbl = new Label[4];
                        for (alfb = 'A'; alfb <= 'C'; alfb++)
                        {
                            lbl[l] = new Label
                            {
                                Text = alfb.ToString() + ") ",
                                Font = new Font("Arial Black", 11)
                            };
                            grb.Controls.Add(lbl[l]);
                            lbl[l].Location = new Point(sols + 4, yuks + 20);
                            yuks += 70;
                            l += 1;
                        }
                        comboBox4.SelectedIndex = 0;
                        yuks += 70;
                        button3.Enabled = true;
                        i = 1;
                    }
                }
            }
        }
        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (label1.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    if (labeltur.Text != "dy")
                    {
                        labeltur.Text = "cs";
                    }
                    if (labeltur.Text != "dy")
                    {
                        comboBox4.Visible = true;
                        grb = new GroupBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 792,
                            Height = 530,
                            Text = "Soru",
                            Font = new Font("Arial Black", 11),
                            Name = "grp ",
                            BackColor = Color.Transparent
                        };
                        groupBox3.Controls.Add(grb);
                        grb.Location = new Point(sols, yuks);
                        rc1 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 109,
                            Font = new Font("Arial Black", 11),
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc1);
                        rc1.Location = new Point(sols + 28, yuks + 25);
                        rc2 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec1,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc2);
                        rc2.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc3 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec2,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc3);
                        rc3.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc4 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec3,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc4);
                        rc4.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc5 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec4,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc5);
                        rc5.Location = new Point(sols + 28, yuks + 150);
                        lbl = new Label[4];
                        for (alfb = 'A'; alfb <= 'D'; alfb++)
                        {
                            lbl[l] = new Label
                            {
                                Text = alfb.ToString() + ") ",
                                Font = new Font("Arial Black", 11)
                            };
                            grb.Controls.Add(lbl[l]);
                            lbl[l].Location = new Point(sols + 4, yuks - 50);
                            yuks += 70;
                            l += 1;
                        }
                        comboBox4.SelectedIndex = 0;
                        yuks += 70;
                        button3.Enabled = true;
                        i = 1;
                    }
                }
            }
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                if (label1.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    if (labeltur.Text != "dy")
                    {
                        labeltur.Text = "cs";
                    }
                    if (labeltur.Text != "dy")
                    {
                        comboBox4.Visible = true;
                        grb = new GroupBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 792,
                            Height = 530,
                            Text = "Soru",
                            Font = new Font("Arial Black", 11),
                            Name = "grp ",
                            BackColor = Color.Transparent
                        };
                        groupBox3.Controls.Add(grb);
                        grb.Location = new Point(sols, yuks);
                        rc1 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 109,
                            Font = new Font("Arial Black", 11),
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc1);
                        rc1.Location = new Point(sols + 28, yuks + 20);
                        rc2 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec1,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc2);
                        rc2.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc3 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec2,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc3);
                        rc3.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc4 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec3,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc4);
                        rc4.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc5 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec4,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc5);
                        rc5.Location = new Point(sols + 28, yuks + 150);
                        yuks += 70;
                        rc6 = new RichTextBox
                        {
                            Top = 150,
                            Left = 10,
                            Width = 730,
                            Height = 50,
                            Font = new Font("Arial Black", 11),
                            Text = sec5,
                            BackColor = Color.LightGray
                        };
                        grb.Controls.Add(rc6);
                        rc6.Location = new Point(sols + 28, yuks + 150);
                        lbl = new Label[5];
                        for (alfb = 'A'; alfb <= 'E'; alfb++)
                        {
                            lbl[l] = new Label
                            {
                                Text = alfb.ToString() + ") ",
                                Font = new Font("Arial Black", 11)
                            };
                            grb.Controls.Add(lbl[l]);
                            lbl[l].Location = new Point(sols + 4, yuks - 120);
                            yuks += 70;
                            l += 1;
                        }
                        comboBox4.SelectedIndex = 0;
                        yuks += 70;
                        button3.Enabled = true;
                        i = 1;
                    }
                }
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            groupBox3.Controls.Clear();
            labeltur.Text = "";
            label1.Text = "";
            sols = 0; yuks = 0;
            button3.Enabled = false;
            labeltur.Text = "";
            l = 0;
            i = 0;
            comboBox4.Visible = true;
            ToolText1.Clear();
            ToolText2.Clear();
            pictureBox1.Image = null;
            lookUpEdit1.Text = "Sınıf Seçiniz...";
            lookUpEdit2.Text = "Ders Seçiniz...";
            lookUpEdit3.Text = "Konu Seçiniz...";
        }

        private void KlasikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem3_Click(sender, e);
        }

        int s;
        void Sonoku()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT mid FROM soru WHERE durum ='" + 2 + "'", con);
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
        void eksik()
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("with tally (eksik) AS (SELECT TOP (SELECT MAX(mid) FROM soru where durum='" + 1 + "' ) ROW_NUMBER() OVER (ORDER BY t1.Object_ID) AS eksik FROM Yusuf.sys.All_Columns t1 CROSS JOIN Yusuf.sys.All_Columns t2)SELECT eksik FROM tally WHERE NOT EXISTS (SELECT * FROM soru WHERE durum='" + 1 + "' and mid = eksik)", con);
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

        string dogru;
        private void Button3_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.Text != "Sınıf Seçiniz...")
            {
                eksik();
                if (eksikk < 1)
                {
                    Sonoku();
                    if (labeltur.Text == "cs")
                    {
                        var rcsayi = grb.Controls.OfType<RichTextBox>().Count();
                        dogru = Interaction.InputBox("Doğru Şık Giriniz", "Şık Girişi", "A", 600, 200);
                        if (dogru.Length == 1)
                        {
                            if (rcsayi == 4)
                            {
                                if (rc1.Text != "" && rc2.Text != "" && rc3.Text != "" && rc4.Text != "")
                                {
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SORESIM,KID,sinif,ders,konu,durum,dogru,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SORESIM,@KID,@sinif,@ders,@konu,@durum,@dogru,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                            else if (rcsayi == 5)
                            {
                                if (rc1.Text != "" && rc2.Text != "" && rc3.Text != "" && rc4.Text != "" && rc5.Text != "")
                                {
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,SORESIM,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@SORESIM,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                            else if (rcsayi == 6)
                            {
                                if (rc1.Text != "" && rc2.Text != "" && rc3.Text != "" && rc4.Text != "" && rc5.Text != "" && rc6.Text != "")
                                {
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,SIK5,SORESIM,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@SIK5,@SORESIM,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@SIK5", lbl[4].Text + rc6.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,SIK5,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@SIK5,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@SIK5", lbl[4].Text + rc6.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                            if (rcsayi == 1)
                            {
                                if (rc1.Text != "")
                                {
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SORESIM,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SORESIM,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", s + 1);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Sadece Tek şık Giriniz. Örnek A", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                    if (labeltur.Text == "dy" || labeltur.Text == "bd")
                    {
                        var rcbssayi = groupBox3.Controls.OfType<RichTextBox>().Count();
                        if (rcbssayi == 1)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@KID,@sinif,@ders,@konu,@durum,@sturi@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 2)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 3)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 4)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 5)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 6)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 7)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 8)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,dy8,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@dy8,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd1.Parameters.AddWithValue("dy8", lbl[7].Text + rcbs[7].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 9)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,dy8,dy9,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@dy8,@dy9,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd1.Parameters.AddWithValue("dy8", lbl[7].Text + rcbs[7].Text);
                            cmd1.Parameters.AddWithValue("dy9", lbl[8].Text + rcbs[8].Text);
                            cmd1.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 10)
                        {
                            SqlCommand cmd = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,dy8,dy9,dy10,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@dy8,@dy9,@dy10,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd.Parameters.AddWithValue("@durum", 1);
                            cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd.Parameters.AddWithValue("dy8", lbl[7].Text + rcbs[7].Text);
                            cmd.Parameters.AddWithValue("dy9", lbl[8].Text + rcbs[8].Text);
                            cmd.Parameters.AddWithValue("dy10", lbl[9].Text + rcbs[9].Text);
                            cmd.Parameters.AddWithValue("@mid", s + 1);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                    }
                }
                else
                {
                    if (labeltur.Text == "cs")
                    {
                        var rcsayi = grb.Controls.OfType<RichTextBox>().Count();
                        dogru = Interaction.InputBox("Doğru Şık Giriniz", "Şık Girişi", "A", 600, 200);
                        if (dogru.Length == 1)
                        {
                            if (rcsayi == 4)
                            {
                                if (rc1.Text != "" && rc2.Text != "" && rc3.Text != "" && rc4.Text != "")
                                {
                                    if (dll != null || rc1.Text != "")
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SORESIM,KID,sinif,ders,konu,durum,dogru,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SORESIM,@KID,@sinif,@ders,@konu,@durum,@dogru,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                            else if (rcsayi == 5)
                            {
                                if (rc1.Text != "" && rc2.Text != "" && rc3.Text != "" && rc4.Text != "" && rc5.Text!= "")
                                { 
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,SORESIM,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@SORESIM,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                            else if (rcsayi == 6)
                            {
                                if (rc1.Text != "" && rc2.Text != "" && rc3.Text != "" && rc4.Text != "" && rc5.Text != "" && rc6.Text != "")
                                {
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,SIK5,SORESIM,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@SIK5,@SORESIM,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@SIK5", lbl[4].Text + rc6.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SIK1,SIK2,SIK3,SIK4,SIK5,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SIK1,@SIK2,@SIK3,@SIK4,@SIK5,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SIK1", lbl[0].Text + rc2.Text);
                                        cmd.Parameters.AddWithValue("@SIK2", lbl[1].Text + rc3.Text);
                                        cmd.Parameters.AddWithValue("@SIK3", lbl[2].Text + rc4.Text);
                                        cmd.Parameters.AddWithValue("@SIK4", lbl[3].Text + rc5.Text);
                                        cmd.Parameters.AddWithValue("@SIK5", lbl[4].Text + rc6.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                                }
                            }
                            if (rcsayi == 1)
                            {
                                if (rc1.Text != "")
                                {
                                    if (dll != null)
                                    {
                                        byte[] resim = System.IO.File.ReadAllBytes(dll.FileName);
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,SORESIM,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@SORESIM,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@SORESIM", resim);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    }
                                    else if (dll == null)
                                    {
                                        SqlCommand cmd = new SqlCommand("Insert Into soru(SORU,KID,sinif,ders,konu,dogru,durum,stur,mid) Values (@SORU,@KID,@sinif,@ders,@konu,@dogru,@durum,@stur,@mid)", con);
                                        cmd.Parameters.AddWithValue("@SORU", rc1.Text);
                                        cmd.Parameters.AddWithValue("@KID", labelid.Text);
                                        cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                                        cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                                        cmd.Parameters.AddWithValue("@dogru", dogru);
                                        cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                                        cmd.Parameters.AddWithValue("@durum", 1);
                                        cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                                        cmd.Parameters.AddWithValue("@mid", eksikk);
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                                        ToolStripMenuItem2_Click(sender, e);
                                    } 
                                }
                            }
                            else
                            {
                                MessageBox.Show("Boş soru veya şık eklenemez.", "Uyarı", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Sadece Tek şık Giriniz. Örnek A", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (labeltur.Text == "dy" || labeltur.Text == "bd")
                    {
                        var rcbssayi = groupBox3.Controls.OfType<RichTextBox>().Count();
                        if (rcbssayi == 1)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@KID,@sinif,@ders,@konu,@durum,@sturi@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 2)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 3)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 4)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 5)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 6)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 7)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 8)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,dy8,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@dy8,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd1.Parameters.AddWithValue("dy8", lbl[7].Text + rcbs[7].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 9)
                        {
                            SqlCommand cmd1 = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,dy8,dy9,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@dy8,@dy9,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd1.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd1.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd1.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd1.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd1.Parameters.AddWithValue("@durum", 1);
                            cmd1.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd1.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd1.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd1.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd1.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd1.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd1.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd1.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd1.Parameters.AddWithValue("dy8", lbl[7].Text + rcbs[7].Text);
                            cmd1.Parameters.AddWithValue("dy9", lbl[8].Text + rcbs[8].Text);
                            cmd1.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                        if (rcbssayi == 10)
                        {
                            SqlCommand cmd = new SqlCommand("Insert Into soru(dy1,dy2,dy3,dy4,dy5,dy6,dy7,dy8,dy9,dy10,KID,sinif,ders,konu,durum,stur,mid) Values (@dy1,@dy2,@dy3,@dy4,@dy5,@dy6,@dy7,@dy8,@dy9,@dy10,@KID,@sinif,@ders,@konu,@durum,@stur,@mid)", con);
                            cmd.Parameters.AddWithValue("@KID", labelid.Text);
                            cmd.Parameters.AddWithValue("@sinif", lookUpEdit1.Text);
                            cmd.Parameters.AddWithValue("@ders", lookUpEdit2.Text);
                            cmd.Parameters.AddWithValue("@konu", lookUpEdit3.Text);
                            cmd.Parameters.AddWithValue("@durum", 1);
                            cmd.Parameters.AddWithValue("@stur", labeltur.Text);
                            cmd.Parameters.AddWithValue("dy1", lbl[0].Text + rcbs[0].Text);
                            cmd.Parameters.AddWithValue("dy2", lbl[1].Text + rcbs[1].Text);
                            cmd.Parameters.AddWithValue("dy3", lbl[2].Text + rcbs[2].Text);
                            cmd.Parameters.AddWithValue("dy4", lbl[3].Text + rcbs[3].Text);
                            cmd.Parameters.AddWithValue("dy5", lbl[4].Text + rcbs[4].Text);
                            cmd.Parameters.AddWithValue("dy6", lbl[5].Text + rcbs[5].Text);
                            cmd.Parameters.AddWithValue("dy7", lbl[6].Text + rcbs[6].Text);
                            cmd.Parameters.AddWithValue("dy8", lbl[7].Text + rcbs[7].Text);
                            cmd.Parameters.AddWithValue("dy9", lbl[8].Text + rcbs[8].Text);
                            cmd.Parameters.AddWithValue("dy10", lbl[9].Text + rcbs[9].Text);
                            cmd.Parameters.AddWithValue("@mid", eksikk);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Soru Eklendi", "Bilgi", MessageBoxButtons.OK);
                            ToolStripMenuItem2_Click(sender, e);
                        }
                    }
                }
                pictureBox1.Visible = false;
                groupBox3.Visible = true;
                button2.BackColor = Color.Navy;
                button2.Text = "Resim Önz.";
                b2 = 0;
            }
            else
            {
                XtraMessageBox.Show("Lütfen Soru Bilgilerini Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            dll = new OpenFileDialog
            {
                Filter = "Resim Dosyası |*.jpeg;*.nef;*.png|Tüm Dosyalar |*.*"
            };
            dll.ShowDialog();
            try
            {
                pictureBox1.Image = Image.FromFile(dll.FileName);
            }
            catch (Exception)
            {
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Button11_Click(sender, e);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.ShowDialog();
            radial();
        }
        int b2 = 0;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Seçilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (b2 == 0)
                {
                    pictureBox1.Visible = true;
                    groupBox3.Visible = false;
                    button2.BackColor = Color.Red;
                    button2.Text = "Geri";
                    b2 = 1;
                }
                else if (b2 == 1)
                {
                    pictureBox1.Visible = false;
                    groupBox3.Visible = true;
                    button2.BackColor = Color.Navy;
                    button2.Text = "Resim Önz.";
                    b2 = 0;
                }
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void radial()
        {
            Point p = Cursor.Position;
            //p.Offset(groupBox3.Width / 2, groupBox3.Height / 2);
            radialMenu1.ShowPopup(p);
        }

        private void Soruekle_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rcbssayi = grb.Controls.OfType<RichTextBox>().Count();
            if (comboBox4.SelectedIndex == 0)
            {
                if (rcbssayi > 1)
                {
                    lbl[0].Text = "A) ";
                    if (rcbssayi > 2)
                    {
                        lbl[1].Text = "B) ";
                        if (rcbssayi > 3)
                        {
                            lbl[2].Text = "C) ";
                            if (rcbssayi > 4)
                            {
                                lbl[3].Text = "D) ";
                                if (rcbssayi > 5)
                                {
                                    lbl[4].Text = "E) ";
                                }
                            }
                        }
                    }
                }
            }
            /*---------------------------------------------*/
            if (comboBox4.SelectedIndex == 1)
            {
                if (rcbssayi > 1)
                {
                    lbl[0].Text = "I- ";
                    if (rcbssayi > 2)
                    {
                        lbl[1].Text = "II- ";
                        if (rcbssayi > 3)
                        {
                            lbl[2].Text = "III- ";
                            if (rcbssayi > 4)
                            {
                                lbl[3].Text = "IV- ";
                                if (rcbssayi > 5)
                                {
                                    lbl[4].Text = "V- ";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ComboBox3_Click(object sender, EventArgs e)
        {

        }
        private void ToolText2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (label1.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    if (labeltur.Text != "cs")
                    {
                        labeltur.Text = "dy";
                    }
                    int a = int.Parse(ToolText2.Text);
                    if (a > 10)
                    {
                        MessageBox.Show("MAX 10");
                        ToolText2.Text = "";
                    }
                    else
                    {
                        if (labeltur.Text != "cs")
                        {
                            comboBox4.Visible = false;
                            lbl = new Label[10];
                            rcbs = new RichTextBox[10];
                            for (int i = 0; i < Convert.ToInt32(ToolText2.Text); i++)
                            {
                                rcbs[i] = new RichTextBox
                                {
                                    Top = 10,
                                    Left = 10,//10
                                    Width = 730,//750
                                    Height = 35,
                                    Font = new Font("Arial Black", 11),
                                    Name = "Soru " + (i + 1).ToString(),
                                    BackColor = Color.DarkGray
                                };
                                lbl[i] = new Label
                                {
                                    Text = (i + 1) + ") (  ) ",
                                    Font = new Font("Arial Black", 11)
                                };
                                groupBox3.Controls.Add(rcbs[i]);
                                groupBox3.Controls.Add(lbl[i]);
                                tt.SetToolTip(rcbs[i], rcbs[i].Name);
                                tt.SetToolTip(lbl[i], lbl[i].Name);
                                rcbs[i].Location = new Point(sols + 50, yuks + 10);//sols+32 
                                lbl[i].Location = new Point(sols + 4, yuks + 10);
                                yuks += 40;
                                label1.Text = "dur";
                                button3.Enabled = true;
                            }
                        }
                        var sayi = groupBox3.Controls.OfType<RichTextBox>().Count();
                        if (sayi == 10)
                        {
                            rcbs[9].Location = new Point(sols + 60, yuks - 30);
                            rcbs[9].Width = 720;
                        }
                        ToolText2.Clear();
                        rcbs[0].Focus();
                        contextMenuStrip2.Close();
                    }
                }
            }
        }

        private void Tool4_DropDownOpened(object sender, EventArgs e)
        {
            ToolText2.TextBox.Focus();
            ToolText2.Clear();
        }

        private void Tool3_DropDownOpened(object sender, EventArgs e)
        {
            ToolText1.TextBox.Focus();
            ToolText1.Clear();
        }

        private void ToolText1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label1.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    if (labeltur.Text != "cs")
                    {
                        labeltur.Text = "bd";
                    }
                    int a = int.Parse(ToolText1.Text);
                    if (a > 10)
                    {
                        MessageBox.Show("MAX 10");
                        ToolText1.Text = "";
                    }
                    else
                    {
                        if (labeltur.Text != "cs")
                        {
                            comboBox4.Visible = false;
                            rcbs = new RichTextBox[10];
                            lbl = new Label[10];
                            for (int i = 0; i < Convert.ToInt32(ToolText1.Text); i++)
                            {
                                rcbs[i] = new RichTextBox
                                {
                                    Top = 10,
                                    Left = 10,
                                    Width = 750,
                                    Height = 35,
                                    Font = new Font("Arial Black", 11),
                                    Name = "Soru " + (i + 1).ToString(),
                                    BackColor = Color.DarkGray
                                };
                                lbl[i] = new Label
                                {
                                    Text = (i + 1) + ") ",
                                    Font = new Font("Arial Black", 11)
                                };
                                groupBox3.Controls.Add(rcbs[i]);
                                groupBox3.Controls.Add(lbl[i]);
                                tt.SetToolTip(rcbs[i], rcbs[i].Name);
                                tt.SetToolTip(lbl[i], lbl[i].Name);
                                rcbs[i].Location = new Point(sols + 32, yuks + 10);
                                lbl[i].Location = new Point(sols + 4, yuks + 10);
                                yuks += 40;
                                label1.Text = "dur";
                                button3.Enabled = true;
                            }
                        }
                        ToolText1.Clear();
                        rcbs[0].Focus();
                        contextMenuStrip2.Close();
                    }
                }
            }
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from konu where ders = " + lookUpEdit2.EditValue, con);
            da.Fill(dt);
            lookUpEdit3.Properties.ValueMember = "id";
            lookUpEdit3.Properties.DisplayMember = "konu";
            lookUpEdit3.Properties.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            lookUpEdit3.Properties.PopulateColumns();
            lookUpEdit3.Properties.Columns[0].Visible = false;
            lookUpEdit3.Properties.Columns[2].Visible = false;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ders where sinif = " + lookUpEdit1.EditValue, con);
            da.Fill(dt);
            lookUpEdit2.Properties.ValueMember = "id";
            lookUpEdit2.Properties.DisplayMember = "ders";
            lookUpEdit2.Properties.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            lookUpEdit2.Properties.PopulateColumns();
            lookUpEdit2.Properties.Columns[0].Visible = false;
            lookUpEdit2.Properties.Columns[2].Visible = false;
        }
    }
}
