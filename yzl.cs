using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using DevExpress.XtraReports.UI;
using System.Security.Cryptography.X509Certificates;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraBars.Ribbon.Helpers;

namespace YAZ_CIKART
{
    public partial class yzl : UserControl
    {
        public yzl()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        readonly SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        readonly ToolTip tt = new ToolTip();
        public LinkLabel[] llbl;
        Label[] lbl;
        public GroupBox[] grp;
        RichTextBox[] rcb;
        XtraReport1 rep;
        public LinkLabel llbls;
        readonly Frmsadi sadi = new Frmsadi();
        int yuks = 0;
        int onuc = 13;
        int i = 0;
        int j = 0;
        public string okul;
        public string ders;
        public string bosluk = "                               ";
        public string bosluk2 = "                       ";
        public string donemyzl;
        int left = 0;
        private SqlDataAdapter da;
        private DataSet ds;
        readonly int top = 0;
        public void Ric()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                richTextBox1.Text = bosluk + donemyzl + "   " + Environment.NewLine + bosluk2 + okul + " " + comboBox1.Text + " " + comboBox4.Text + " " + ders + " " + Environment.NewLine + bosluk + comboBox3.Text + " " + comboBox2.Text;
            }
            else
            {
                richTextBox1.Text = "frm2.donem" + " " + "OKUL ADI" + " " + comboBox1.Text + " " + "SINIF" + "/" + "ŞUBE" + " " + "DERS" + " " + "DÖNEMİ" + " " + "SINAV TÜRÜ";
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = groupBox1.Left.ToString();
            groupBox1.Left -= 10;
            if (groupBox1.Left <= -790)
            {
                timer1.Stop();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer4.Start();
            button4.SendToBack();
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            label3.Text = groupBox1.Left.ToString();
            groupBox1.Left += 10;
            if (groupBox1.Left >= +0)
            {
                button4.SendToBack();
                timer4.Stop();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ric();
            comboBox1.Enabled = true; comboBox2.Enabled = true; comboBox3.Enabled = true; comboBox4.Enabled = true;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox4.Enabled = true;
                comboBox3.Enabled = true;
                comboBox2.Enabled = true;
            }
            Cy(sender, e);
        }
        void Cy(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Button2_Click(sender, e);
            }
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cy(sender, e);
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cy(sender, e);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cy(sender, e);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Button11_Click(sender, e);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Yzl_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            richTextBox1.ReadOnly = true;
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush sbrush = new SolidBrush(richTextBox1.ForeColor);
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, sbrush, 40, 100);
            e.Graphics.DrawString("sa yaa", richTextBox1.Font, sbrush, 40, 100);
        }

        private void Tool1_DropDownOpened(object sender, EventArgs e)
        {
        }

        public void ToolText1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Syap();
            }
        }

        public int ssayi;

        public void Syap()
        {
            if (label4.Text == "dur")
            {
                //durdu
            }
            else
            {
                llbl = new LinkLabel[ssayi];
                Label[] lbl = new Label[ssayi];
                grp = new GroupBox[ssayi];
                for (int i = 0; i < ssayi; i++)
                {
                    llbl[i] = new LinkLabel
                    {
                        Top = 10,
                        Left = 10,
                        Width = 30,
                        Text = (i + 1).ToString(),
                        Font = new Font("Arial Black", 11),
                        Name = "Soru " + (i + 1).ToString(),
                        BackColor = Color.Transparent
                    };
                    grp[i] = new GroupBox
                    {
                        Top = 0,
                        Left = 0,
                        Width = 792,
                        Height = 515,
                        Text = "Soru" + (i + 1).ToString(),
                        Font = new Font("Arial Black", 11),
                        Name = "Soru " + (i + 1).ToString(),
                        BackColor = Color.Transparent,
                    };
                    flowLayoutPanel1.Controls.Add(llbl[i]);
                    groupBox2.Controls.Add(grp[i]);
                    tt.SetToolTip(llbl[i], llbl[i].Name);
                    llbl[i].Location = new Point(left + 8, top + 10);
                    left += 36;
                    label4.Text = "dur";
                }
                try
                {
                    llbl[0].Click += Llbl0_Click;
                    llbl[1].Click += Llbl1_Click;
                    llbl[2].Click += Llbl2_Click;
                    llbl[3].Click += Llbl3_Click;
                    llbl[4].Click += Llbl4_Click;
                    llbl[5].Click += Llbl5_Click;
                    llbl[6].Click += Llbl6_Click;
                    llbl[7].Click += Llbl7_Click;
                    llbl[8].Click += Llbl8_Click;
                    llbl[9].Click += Llbl9_Click;
                    llbl[10].Click += Llbl10_Click;
                    llbl[11].Click += Llbl11_Click;
                    llbl[12].Click += Llbl12_Click;
                    llbl[13].Click += Llbl13_Click;
                    llbl[14].Click += Llbl14_Click;
                    llbl[15].Click += Llbl15_Click;
                    llbl[16].Click += Llbl16_Click;
                    llbl[17].Click += Llbl17_Click;
                    llbl[18].Click += Llbl18_Click;
                    llbl[19].Click += Llbl19_Click;
                }
                catch (Exception)
                {

                }
                llbls = new LinkLabel
                {
                    Top = 10,
                    Left = 10,
                    Text = "Yazdır"
                };
                tt.SetToolTip(llbls, llbls.Name);
                llbls.Width = llbls.Text.Length * 12;
                llbls.Font = new Font("Arial Black", 11);
                llbls.Name = "Yazdır";
                llbls.BackColor = Color.Transparent;
                flowLayoutPanel1.Controls.Add(llbls);
                llbls.Location = new Point((Convert.ToInt32(ssayi) * 35) + 36, top + 10);
                contextMenuStrip2.Close();
                llbls.Click += Llbls_Click;
            }
        }

        public void Repdoldur()
        {

        }

        public void Llbls_Click(object sender, EventArgs e)
        {
            //rep = new XtraReport1();
            //rep.FilterString = "[kid] ='" + labelkid.Text + "'and [sadi]='" + yzlsinavadi + "'";
            //Repdoldur();
            //ReportPrintTool pt = new ReportPrintTool(rep);
            //pt.ShowPreviewDialog();
        }

        private void Llbl19_Click(object sender, EventArgs e)
        {
            llbl[19].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[19].Text;
            grp[19].BackColor = Color.LightSalmon;
            grp[19].BringToFront();
            labelhng.Text = llbl[19].Text; Oku();
            if (llbl[19].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl18_Click(object sender, EventArgs e)
        {
            llbl[18].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[18].Text;
            grp[18].BackColor = Color.LightSalmon;
            grp[18].BringToFront();
            labelhng.Text = llbl[18].Text; Oku();
            if (llbl[18].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl17_Click(object sender, EventArgs e)
        {
            llbl[17].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[17].Text;
            grp[17].BackColor = Color.LightSalmon;
            grp[17].BringToFront();
            labelhng.Text = llbl[17].Text; Oku();
            if (llbl[17].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl16_Click(object sender, EventArgs e)
        {
            llbl[16].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[16].Text;
            grp[16].BackColor = Color.LightSalmon;
            grp[16].BringToFront();
            labelhng.Text = llbl[16].Text; Oku();
            if (llbl[16].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl15_Click(object sender, EventArgs e)
        {
            llbl[15].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[15].Text;
            grp[15].BackColor = Color.LightSalmon;
            grp[15].BringToFront();
            labelhng.Text = llbl[15].Text; Oku();
            if (llbl[15].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl14_Click(object sender, EventArgs e)
        {
            llbl[14].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[14].Text;
            grp[14].BackColor = Color.LightSalmon;
            grp[14].BringToFront();
            labelhng.Text = llbl[14].Text; Oku();
            if (llbl[14].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl13_Click(object sender, EventArgs e)
        {
            llbl[13].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[13].Text;
            grp[13].BackColor = Color.LightSalmon;
            grp[13].BringToFront();
            labelhng.Text = llbl[13].Text; Oku();
            if (llbl[13].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl12_Click(object sender, EventArgs e)
        {
            llbl[12].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[12].Text;
            grp[12].BackColor = Color.LightSalmon;
            grp[12].BringToFront();
            labelhng.Text = llbl[12].Text; Oku();
            if (llbl[12].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl11_Click(object sender, EventArgs e)
        {
            llbl[11].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[11].Text;
            grp[11].BackColor = Color.LightSalmon;
            grp[11].BringToFront();
            labelhng.Text = llbl[11].Text; Oku();
            if (llbl[11].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl10_Click(object sender, EventArgs e)
        {
            llbl[10].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[10].Text;
            grp[10].BackColor = Color.LightSalmon;
            grp[10].BringToFront();
            labelhng.Text = llbl[10].Text; Oku();
            if (llbl[10].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl9_Click(object sender, EventArgs e)
        {
            llbl[9].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[9].Text;
            grp[9].BackColor = Color.LightSalmon;
            grp[9].BringToFront();
            labelhng.Text = llbl[9].Text; Oku();
            if (llbl[9].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl8_Click(object sender, EventArgs e)
        {
            llbl[8].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[8].Text;
            grp[8].BackColor = Color.LightSalmon;
            grp[8].BringToFront();
            labelhng.Text = llbl[8].Text; Oku();
            if (llbl[8].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl7_Click(object sender, EventArgs e)
        {
            llbl[7].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[7].Text;
            grp[7].BackColor = Color.LightSalmon;
            grp[7].BringToFront();
            labelhng.Text = llbl[7].Text; Oku();
            if (llbl[7].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl6_Click(object sender, EventArgs e)
        {
            llbl[6].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[6].Text;
            grp[6].BackColor = Color.LightSalmon;
            grp[6].BringToFront();
            labelhng.Text = llbl[6].Text; Oku();
            if (llbl[6].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl5_Click(object sender, EventArgs e)
        {
            llbl[5].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[5].Text;
            grp[5].BackColor = Color.LightSalmon;
            grp[5].BringToFront();
            labelhng.Text = llbl[5].Text; Oku();
            if (llbl[5].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl4_Click(object sender, EventArgs e)
        {
            llbl[4].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[4].Text;
            grp[4].BackColor = Color.LightSalmon;
            grp[4].BringToFront();
            labelhng.Text = llbl[4].Text; Oku();
            if (llbl[4].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl3_Click(object sender, EventArgs e)
        {
            llbl[3].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[3].Text;
            grp[3].BackColor = Color.LightSalmon;
            grp[3].BringToFront();
            labelhng.Text = llbl[03].Text; Oku();
            if (llbl[3].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl2_Click(object sender, EventArgs e)
        {
            llbl[2].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[2].Text;
            grp[2].BackColor = Color.LightSalmon;
            grp[2].BringToFront();
            labelhng.Text = llbl[2].Text; Oku();
            if (llbl[2].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl1_Click(object sender, EventArgs e)
        {
            llbl[1].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[1].Text;
            grp[1].BackColor = Color.LightSalmon;
            grp[1].BringToFront();
            labelhng.Text = llbl[1].Text; Oku();
            if (llbl[1].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }

        private void Llbl0_Click(object sender, EventArgs e)
        {
            llbl[0].ContextMenuStrip = contextMenuStrip1;
            ToolSoru.Text = "Soru: " + llbl[0].Text;
            grp[0].BackColor = Color.LightSalmon;
            grp[0].BringToFront();
            labelhng.Text = llbl[0].Text; Oku();
            if (llbl[0].LinkColor != Color.Lime)
            {
                Gridonay();
                Sotur();
                Gridsoru();
            }
        }
        int y = 0;
        void Sotur()
        {
            if (dataGridView1.Rows[0].Cells[5].Value != null)
            {
                if (dataGridView1.Rows[0].Cells[5].Value.ToString() == "cs")
                {
                    labelsayi.Text = 6.ToString();
                    rcb = new RichTextBox[200];
                    for (j = 0; j < Convert.ToInt32(labelsayi.Text + y); j++)
                    {
                        rcb[j] = new RichTextBox
                        {
                            Width = 721,
                            Height = 50,
                            Left = 10,
                            Top = 150 - 15,
                            Font = new Font("Arial Black", 12, FontStyle.Bold),
                        };
                        rcb[j].Location = new Point(30, yuks + 35);
                        tt.SetToolTip(rcb[j], rcb[j].Name);
                        yuks += 80;
                        grp[Convert.ToInt32(labelhng.Text) - 1].Controls.Add(rcb[j]);
                    }
                    yuks = 0;
                    y = 6;
                }
                else if (dataGridView1.Rows[0].Cells[5].Value.ToString() == "dy")
                {
                    labelsayi.Text = 10.ToString();
                    rcb = new RichTextBox[200];
                    lbl = new Label[10];
                    for (int j = 0; j < Convert.ToInt32(labelsayi.Text); j++)
                    {
                        rcb[j] = new RichTextBox
                        {
                            Width = 717,
                            Height = 35,
                            Left = 50,
                            Top = 150 - 15,
                            Font = new Font("Arial Black", 12, FontStyle.Bold),
                        };
                        lbl[j] = new Label
                        {
                            Text = (j + 1) + ") ( )",
                            Font = new Font("Arial Black", 11),
                            ForeColor = Color.White,
                        };
                        lbl[j].Location = new Point(4, onuc + 10);
                        grp[Convert.ToInt32(labelhng.Text) - 1].Controls.Add(lbl[j]);
                        onuc += 40;
                        rcb[j].Location = new Point(50, yuks + 20);
                        tt.SetToolTip(rcb[j], rcb[j].Name);
                        yuks += 40;
                        grp[Convert.ToInt32(labelhng.Text) - 1].Controls.Add(rcb[j]);
                        rcb[j].BringToFront();
                    }
                    var sayi = grp[Convert.ToInt32(labelhng.Text) - 1].Controls.OfType<RichTextBox>().Count();
                    if (sayi == 10)
                    {
                        rcb[9].Location = new Point(60, rcb[8].Location.Y + 40);
                        rcb[9].Width = 707;
                    }
                    yuks = 0;
                    onuc = 13;
                }
                else if (dataGridView1.Rows[0].Cells[5].Value.ToString() == "bd")
                {
                    labelsayi.Text = 10.ToString();
                    rcb = new RichTextBox[200];
                    lbl = new Label[10];
                    for (int j = 0; j < Convert.ToInt32(labelsayi.Text); j++)
                    {
                        rcb[j] = new RichTextBox
                        {
                            Width = 750,
                            Height = 35,
                            Left = 50,
                            Top = 150 - 15,
                            Font = new Font("Arial Black", 12, FontStyle.Bold),
                        };
                        lbl[j] = new Label
                        {
                            Text = (j + 1) + ")",
                            Font = new Font("Arial Black", 11),
                            ForeColor = Color.White,
                        };
                        lbl[j].Location = new Point(4, onuc + 10);
                        grp[Convert.ToInt32(labelhng.Text) - 1].Controls.Add(lbl[j]);
                        onuc += 40;
                        rcb[j].Location = new Point(35, yuks + 20);
                        tt.SetToolTip(rcb[j], rcb[j].Name);
                        yuks += 40;
                        grp[Convert.ToInt32(labelhng.Text) - 1].Controls.Add(rcb[j]);
                        rcb[j].BringToFront();
                    }
                    yuks = 0;
                    onuc = 13;
                }
            }
            else
            {
                MessageBox.Show("Henüz Soru Seçmediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Gridonay()
        {
            //var llbls = flowLayoutPanel1.Controls.OfType<LinkLabel>().Count();
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            da = new SqlDataAdapter("Select * From sinav where durum='" + 0 + "'and mid='" + labelhng.Text + "'and kid='" + labelkid.Text + "'", con);
            ds = new DataSet();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            da.Fill(ds, "sinav");
            dataGridView1.DataSource = ds.Tables["sinav"];
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void Gridsoru()
        {
            if (dataGridView1.Rows[0].Cells[5].Value != null)
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                da = new SqlDataAdapter("Select * From soru where durum='" + 2 + "'and Id='" + dataGridView1.Rows[0].Cells[1].Value.ToString() + "'", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView2.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                Txtgec();
            }
        }

        public void Txtgec()
        {
            if (dataGridView2.Rows[i].Cells[0].Value != null)
            {
                if (dataGridView2.Rows[i].Cells[26].Value.ToString() == "cs")
                {
                    //Ccsk();
                    if (dataGridView2.Rows[i].Cells[7].Value != DBNull.Value)
                    {
                        labeltblid.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        rcb[0].Text = dataGridView2.Rows[0].Cells[1].Value.ToString() + j;
                        rcb[1].Text = dataGridView2.Rows[0].Cells[2].Value.ToString() + j;
                        rcb[2].Text = dataGridView2.Rows[0].Cells[3].Value.ToString() + j;
                        rcb[3].Text = dataGridView2.Rows[0].Cells[4].Value.ToString() + j;
                        rcb[4].Text = dataGridView2.Rows[0].Cells[5].Value.ToString() + j;
                        rcb[5].Text = dataGridView2.Rows[0].Cells[6].Value.ToString();
                        //comboBox3.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
                        //comboBox1.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
                        //comboBox2.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
                        //labeltur.Text = dataGridView2.Rows[i].Cells[26].Value.ToString();
                        //label1.Text = "Doğru Cevap:" + (dataGridView2.Rows[i].Cells[15].Value.ToString()).ToUpper();
                        byte[] resim = (byte[])dataGridView2.Rows[0].Cells[7].Value;
                        MemoryStream ms = new MemoryStream(resim);
                        pictureBoxsr.Image = Image.FromStream(ms);
                        if (rcb[1].Text == "")
                        {
                            rcb[1].Visible = false;
                        }
                        if (rcb[2].Text == "")
                        {
                            rcb[2].Visible = false;
                        }
                        if (rcb[3].Text == "")
                        {
                            rcb[3].Visible = false;
                        }
                        if (rcb[4].Text == "")
                        {
                            rcb[4].Visible = false;
                        }
                        if (rcb[5].Text == "")
                        {
                            rcb[5].Visible = false;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value == DBNull.Value)
                        {
                            pictureBoxsr.Image = null;
                            //button2.Visible = false;
                        }
                        if (rcb[1].Text != "")
                        {
                            rcb[1].Visible = true;
                        }
                        if (rcb[2].Text != "")
                        {
                            rcb[2].Visible = true;
                        }
                        if (rcb[3].Text != "")
                        {
                            rcb[3].Visible = true;
                        }
                        if (rcb[4].Text != "")
                        {
                            rcb[4].Visible = true;
                        }
                        if (rcb[5].Text != "")
                        {
                            rcb[5].Visible = true;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                        {
                            //button2.Visible = true;
                        }
                        if (rcb[1].Text == "" && rcb[2].Text == "" && rcb[3].Text == "" && rcb[4].Text == "" && rcb[5].Text == "")
                        {
                            rcb[0].Width = 700;
                            rcb[0].Height = 300;
                        }
                        else
                        {
                            rcb[0].Width = 721;
                            rcb[0].Height = 70;
                        }
                        llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Lime;
                    }
                    else
                    {
                        labeltblid.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        rcb[0].Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                        rcb[1].Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
                        rcb[2].Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
                        rcb[3].Text = dataGridView2.Rows[0].Cells[4].Value.ToString();
                        rcb[4].Text = dataGridView2.Rows[0].Cells[5].Value.ToString();
                        rcb[5].Text = dataGridView2.Rows[0].Cells[6].Value.ToString();
                        //comboBox3.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
                        //comboBox1.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
                        //comboBox2.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
                        //labeltur.Text = dataGridView2.Rows[i].Cells[26].Value.ToString();
                        //label1.Text = "Doğru Cevap:" + (dataGridView2.Rows[i].Cells[15].Value.ToString()).ToUpper();
                        if (rcb[1].Text == "")
                        {
                            rcb[1].Visible = false;
                        }
                        if (rcb[2].Text == "")
                        {
                            rcb[2].Visible = false;
                        }
                        if (rcb[3].Text == "")
                        {
                            rcb[3].Visible = false;
                        }
                        if (rcb[4].Text == "")
                        {
                            rcb[4].Visible = false;
                        }
                        if (rcb[5].Text == "")
                        {
                            rcb[5].Visible = false;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value == DBNull.Value)
                        {
                            pictureBoxsr.Image = null;
                            //button2.Visible = false;
                        }
                        if (rcb[1].Text != "")
                        {
                            rcb[1].Visible = true;
                        }
                        if (rcb[2].Text != "")
                        {
                            rcb[2].Visible = true;
                        }
                        if (rcb[3].Text != "")
                        {
                            rcb[3].Visible = true;
                        }
                        if (rcb[4].Text != "")
                        {
                            rcb[4].Visible = true;
                        }
                        if (rcb[5].Text != "")
                        {
                            rcb[5].Visible = true;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                        {
                            //button2.Visible = true;
                        }
                        if (rcb[1].Text == "" && rcb[2].Text == "" && rcb[3].Text == "" && rcb[4].Text == "" && rcb[5].Text == "")
                        {
                            rcb[0].Width = 721;
                            rcb[0].Height = 300;
                        }
                        else
                        {
                            rcb[0].Width = 721;
                            rcb[0].Height = 70;
                        }
                        llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Lime;
                    }
                }
                else if (dataGridView2.Rows[0].Cells[26].Value.ToString() == "bd")
                {
                    //Dy();
                    if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                    {
                        labeltblid.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        rcb[0].Text = dataGridView2.Rows[0].Cells[16].Value.ToString();
                        rcb[1].Text = dataGridView2.Rows[0].Cells[17].Value.ToString();
                        rcb[2].Text = dataGridView2.Rows[0].Cells[18].Value.ToString();
                        rcb[3].Text = dataGridView2.Rows[0].Cells[19].Value.ToString();
                        rcb[4].Text = dataGridView2.Rows[0].Cells[20].Value.ToString();
                        rcb[5].Text = dataGridView2.Rows[0].Cells[21].Value.ToString();
                        rcb[6].Text = dataGridView2.Rows[0].Cells[22].Value.ToString();
                        rcb[7].Text = dataGridView2.Rows[0].Cells[23].Value.ToString();
                        rcb[8].Text = dataGridView2.Rows[0].Cells[24].Value.ToString();
                        rcb[9].Text = dataGridView2.Rows[0].Cells[25].Value.ToString();
                        //comboBox3.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
                        //comboBox1.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
                        //comboBox2.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
                        //labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                        //label1.Text = "Doğru Cevap:" + (dataGridView2.Rows[i].Cells[15].Value.ToString()).ToUpper();
                        byte[] resim = (byte[])dataGridView2.Rows[0].Cells[7].Value;
                        MemoryStream ms = new MemoryStream(resim);
                        pictureBoxsr.Image = Image.FromStream(ms);
                        if (rcb[1].Text == "")
                        {
                            rcb[1].Visible = false;
                        }
                        if (rcb[2].Text == "")
                        {
                            rcb[2].Visible = false;
                        }
                        if (rcb[3].Text == "")
                        {
                            rcb[3].Visible = false;
                        }
                        if (rcb[4].Text == "")
                        {
                            rcb[4].Visible = false;
                        }
                        if (rcb[5].Text == "")
                        {
                            rcb[5].Visible = false;
                        }
                        if (rcb[6].Text == "")
                        {
                            rcb[6].Visible = false;
                        }
                        if (rcb[7].Text == "")
                        {
                            rcb[7].Visible = false;
                        }
                        if (rcb[8].Text == "")
                        {
                            rcb[8].Visible = false;
                        }
                        if (rcb[9].Text == "")
                        {
                            rcb[9].Visible = false;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value == DBNull.Value)
                        {
                            pictureBoxsr.Image = null;
                            //button2.Visible = false;
                        }
                        if (rcb[1].Text != "")
                        {
                            rcb[1].Visible = true;
                        }
                        if (rcb[2].Text != "")
                        {
                            rcb[2].Visible = true;
                        }
                        if (rcb[3].Text != "")
                        {
                            rcb[3].Visible = true;
                        }
                        if (rcb[4].Text != "")
                        {
                            rcb[4].Visible = true;
                        }
                        if (rcb[5].Text != "")
                        {
                            rcb[5].Visible = true;
                        }
                        if (rcb[6].Text != "")
                        {
                            rcb[6].Visible = true;
                        }
                        if (rcb[7].Text != "")
                        {
                            rcb[7].Visible = true;
                        }
                        if (rcb[8].Text != "")
                        {
                            rcb[8].Visible = true;
                        }
                        if (rcb[9].Text != "")
                        {
                            rcb[9].Visible = true;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                        {
                            //button2.Visible = true;
                        }
                        llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Lime;
                    }
                    else
                    {
                        labeltblid.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        rcb[0].Text = dataGridView2.Rows[0].Cells[16].Value.ToString();
                        rcb[1].Text = dataGridView2.Rows[0].Cells[17].Value.ToString();
                        rcb[2].Text = dataGridView2.Rows[0].Cells[18].Value.ToString();
                        rcb[3].Text = dataGridView2.Rows[0].Cells[19].Value.ToString();
                        rcb[4].Text = dataGridView2.Rows[0].Cells[20].Value.ToString();
                        rcb[5].Text = dataGridView2.Rows[0].Cells[21].Value.ToString();
                        rcb[6].Text = dataGridView2.Rows[0].Cells[22].Value.ToString();
                        rcb[7].Text = dataGridView2.Rows[0].Cells[23].Value.ToString();
                        rcb[8].Text = dataGridView2.Rows[0].Cells[24].Value.ToString();
                        rcb[9].Text = dataGridView2.Rows[0].Cells[25].Value.ToString();
                        //comboBox3.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
                        //comboBox1.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
                        //comboBox2.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
                        //labeltur.Text = dataGridView2.Rows[i].Cells[26].Value.ToString();
                        //label1.Text = "Doğru Cevap:" + (dataGridView2.Rows[i].Cells[15].Value.ToString()).ToUpper();
                        if (rcb[1].Text == "")
                        {
                            rcb[1].Visible = false;
                        }
                        if (rcb[2].Text == "")
                        {
                            rcb[2].Visible = false;
                        }
                        if (rcb[3].Text == "")
                        {
                            rcb[3].Visible = false;
                        }
                        if (rcb[4].Text == "")
                        {
                            rcb[4].Visible = false;
                        }
                        if (rcb[5].Text == "")
                        {
                            rcb[5].Visible = false;
                        }
                        if (rcb[6].Text == "")
                        {
                            rcb[6].Visible = false;
                        }
                        if (rcb[7].Text == "")
                        {
                            rcb[7].Visible = false;
                        }
                        if (rcb[8].Text == "")
                        {
                            rcb[8].Visible = false;
                        }
                        if (rcb[9].Text == "")
                        {
                            rcb[9].Visible = false;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value == DBNull.Value)
                        {
                            pictureBoxsr.Image = null;
                            //button2.Visible = false;
                        }
                        if (rcb[1].Text != "")
                        {
                            rcb[1].Visible = true;
                        }
                        if (rcb[2].Text != "")
                        {
                            rcb[2].Visible = true;
                        }
                        if (rcb[3].Text != "")
                        {
                            rcb[3].Visible = true;
                        }
                        if (rcb[4].Text != "")
                        {
                            rcb[4].Visible = true;
                        }
                        if (rcb[5].Text != "")
                        {
                            rcb[5].Visible = true;
                        }
                        if (rcb[6].Text != "")
                        {
                            rcb[6].Visible = true;
                        }
                        if (rcb[7].Text != "")
                        {
                            rcb[7].Visible = true;
                        }
                        if (rcb[8].Text != "")
                        {
                            rcb[8].Visible = true;
                        }
                        if (rcb[9].Text != "")
                        {
                            rcb[9].Visible = true;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                        {
                            //button2.Visible = true;
                        }
                        llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Lime;
                    }
                }
                else if (dataGridView2.Rows[0].Cells[26].Value.ToString() == "dy")
                {
                    //Dy();
                    if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                    {
                        labeltblid.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        rcb[0].Text = dataGridView2.Rows[0].Cells[16].Value.ToString();
                        rcb[1].Text = dataGridView2.Rows[0].Cells[17].Value.ToString();
                        rcb[2].Text = dataGridView2.Rows[0].Cells[18].Value.ToString();
                        rcb[3].Text = dataGridView2.Rows[0].Cells[19].Value.ToString();
                        rcb[4].Text = dataGridView2.Rows[0].Cells[20].Value.ToString();
                        rcb[5].Text = dataGridView2.Rows[0].Cells[21].Value.ToString();
                        rcb[6].Text = dataGridView2.Rows[0].Cells[22].Value.ToString();
                        rcb[7].Text = dataGridView2.Rows[0].Cells[23].Value.ToString();
                        rcb[8].Text = dataGridView2.Rows[0].Cells[24].Value.ToString();
                        rcb[9].Text = dataGridView2.Rows[0].Cells[25].Value.ToString();
                        //comboBox3.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
                        //comboBox1.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
                        //comboBox2.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
                        //labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                        //label1.Text = "Doğru Cevap:" + (dataGridView2.Rows[i].Cells[15].Value.ToString()).ToUpper();
                        byte[] resim = (byte[])dataGridView2.Rows[0].Cells[7].Value;
                        MemoryStream ms = new MemoryStream(resim);
                        pictureBoxsr.Image = Image.FromStream(ms);
                        if (rcb[1].Text == "")
                        {
                            rcb[1].Visible = false;
                        }
                        if (rcb[2].Text == "")
                        {
                            rcb[2].Visible = false;
                        }
                        if (rcb[3].Text == "")
                        {
                            rcb[3].Visible = false;
                        }
                        if (rcb[4].Text == "")
                        {
                            rcb[4].Visible = false;
                        }
                        if (rcb[5].Text == "")
                        {
                            rcb[5].Visible = false;
                        }
                        if (rcb[6].Text == "")
                        {
                            rcb[6].Visible = false;
                        }
                        if (rcb[7].Text == "")
                        {
                            rcb[7].Visible = false;
                        }
                        if (rcb[8].Text == "")
                        {
                            rcb[8].Visible = false;
                        }
                        if (rcb[9].Text == "")
                        {
                            rcb[9].Visible = false;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value == DBNull.Value)
                        {
                            pictureBoxsr.Image = null;
                            //button2.Visible = false;
                        }
                        if (rcb[1].Text != "")
                        {
                            rcb[1].Visible = true;
                        }
                        if (rcb[2].Text != "")
                        {
                            rcb[2].Visible = true;
                        }
                        if (rcb[3].Text != "")
                        {
                            rcb[3].Visible = true;
                        }
                        if (rcb[4].Text != "")
                        {
                            rcb[4].Visible = true;
                        }
                        if (rcb[5].Text != "")
                        {
                            rcb[5].Visible = true;
                        }
                        if (rcb[6].Text != "")
                        {
                            rcb[6].Visible = true;
                        }
                        if (rcb[7].Text != "")
                        {
                            rcb[7].Visible = true;
                        }
                        if (rcb[8].Text != "")
                        {
                            rcb[8].Visible = true;
                        }
                        if (rcb[9].Text != "")
                        {
                            rcb[9].Visible = true;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                        {
                            //button2.Visible = true;
                        }
                        llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Lime;
                    }
                    else
                    {
                        labeltblid.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                        rcb[0].Text = dataGridView2.Rows[0].Cells[16].Value.ToString();
                        rcb[1].Text = dataGridView2.Rows[0].Cells[17].Value.ToString();
                        rcb[2].Text = dataGridView2.Rows[0].Cells[18].Value.ToString();
                        rcb[3].Text = dataGridView2.Rows[0].Cells[19].Value.ToString();
                        rcb[4].Text = dataGridView2.Rows[0].Cells[20].Value.ToString();
                        rcb[5].Text = dataGridView2.Rows[0].Cells[21].Value.ToString();
                        rcb[6].Text = dataGridView2.Rows[0].Cells[22].Value.ToString();
                        rcb[7].Text = dataGridView2.Rows[0].Cells[23].Value.ToString();
                        rcb[8].Text = dataGridView2.Rows[0].Cells[24].Value.ToString();
                        rcb[9].Text = dataGridView2.Rows[0].Cells[25].Value.ToString();
                        //comboBox3.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
                        //comboBox1.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
                        //comboBox2.Text = dataGridView2.Rows[i].Cells[12].Value.ToString();
                        //labeltur.Text = dataGridView2.Rows[i].Cells[26].Value.ToString();
                        //label1.Text = "Doğru Cevap:" + (dataGridView2.Rows[i].Cells[15].Value.ToString()).ToUpper();
                        if (rcb[1].Text == "")
                        {
                            rcb[1].Visible = false;
                        }
                        if (rcb[2].Text == "")
                        {
                            rcb[2].Visible = false;
                        }
                        if (rcb[3].Text == "")
                        {
                            rcb[3].Visible = false;
                        }
                        if (rcb[4].Text == "")
                        {
                            rcb[4].Visible = false;
                        }
                        if (rcb[5].Text == "")
                        {
                            rcb[5].Visible = false;
                        }
                        if (rcb[6].Text == "")
                        {
                            rcb[6].Visible = false;
                        }
                        if (rcb[7].Text == "")
                        {
                            rcb[7].Visible = false;
                        }
                        if (rcb[8].Text == "")
                        {
                            rcb[8].Visible = false;
                        }
                        if (rcb[9].Text == "")
                        {
                            rcb[9].Visible = false;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value == DBNull.Value)
                        {
                            pictureBoxsr.Image = null;
                            //button2.Visible = false;
                        }
                        if (rcb[1].Text != "")
                        {
                            rcb[1].Visible = true;
                        }
                        if (rcb[2].Text != "")
                        {
                            rcb[2].Visible = true;
                        }
                        if (rcb[3].Text != "")
                        {
                            rcb[3].Visible = true;
                        }
                        if (rcb[4].Text != "")
                        {
                            rcb[4].Visible = true;
                        }
                        if (rcb[5].Text != "")
                        {
                            rcb[5].Visible = true;
                        }
                        if (rcb[6].Text != "")
                        {
                            rcb[6].Visible = true;
                        }
                        if (rcb[7].Text != "")
                        {
                            rcb[7].Visible = true;
                        }
                        if (rcb[8].Text != "")
                        {
                            rcb[8].Visible = true;
                        }
                        if (rcb[9].Text != "")
                        {
                            rcb[9].Visible = true;
                        }
                        if (dataGridView2.Rows[0].Cells[7].Value != DBNull.Value)
                        {
                            //button2.Visible = true;
                        }
                        llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Lime;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu tarafta soru kalmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Tool6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            groupBox2.Controls.Clear();
            label4.Text = "";
            j = 0;
            i = 0;
            onuc = 13;
        }

        private void ToolSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("DELETE FROM sinav where kid='" + labelkid.Text + "' and sadi='" + yzlsinavadi + "' and mid='" + labelhng.Text + "' and sid='" + labeltblid.Text + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            llbl[Convert.ToInt32(labelhng.Text) - 1].LinkColor = Color.Red;
            grp[Convert.ToInt32(labelhng.Text) - 1].Controls.Clear();
            MessageBox.Show("Soru Silindi.");
        }

        void Tblsil()
        {
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("DELETE FROM sinav where kid='" + labelkid.Text + "' and sadi='" + yzlsinavadi + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            MessageBox.Show("Sınav Silindi.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (yzlsinavadi != null)
            {
                Tblsil(); 
            }
            else
            {
                MessageBox.Show("Açık sınav yok.");
            }
        }

        private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Tool7_Click(object sender, EventArgs e)
        {
            //contextMenuStrip2.Show();
            //Toolcmb1.DroppedDown = true;
        }

        private void Button10_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(button10, "Sınav Değiş");
        }

        private void labelsinav_TextChanged(object sender, EventArgs e)
        {
            button10.Visible = true;
        }

        private void toolDegis_DropDownOpened(object sender, EventArgs e)
        {
            toolText0.Focus();
        }

        public void Oku()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select * from sinav where sadi='" + yzlsinavadi + "'and mid='" + labelhng.Text + "'", con)
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
                D1 = dr["id"].ToString();
                S1 = dr["mid"].ToString();
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            //MessageBox.Show("d1=" + D1 + "s1=" + S1);
        }

        public void Oku2()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select * from sinav where sadi='" + yzlsinavadi + "'and mid='" + toolText0.Text + "'", con)
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
                D2 = dr["id"].ToString();
                S2 = dr["mid"].ToString();
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            // MessageBox.Show("d2=" + D2 + "s2=" + S2);
        }

        public string yzlsinavadi;
        public string D1;
        public string D2;
        public string S1;
        public string S2;

        private void toolText0_KeyDown(object sender, KeyEventArgs e)
        {
            Oku2();
            if (e.KeyCode == Keys.Enter)
            {
                if (toolText0.Text != null)
                {
                    //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SqlCommand cmd = new SqlCommand("update sinav set mid=@mid where sadi='" + yzlsinavadi + "'and id='" + D1 + "'", con);
                    cmd.Parameters.AddWithValue("@mid", S2);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlConnection con1 = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                    SqlCommand cmd1 = new SqlCommand("update sinav set mid=@mid where sadi='" + yzlsinavadi + "'and id='" + D2 + "'", con1);
                    cmd1.Parameters.AddWithValue("@mid", S1);
                    if (con1.State == ConnectionState.Closed)
                    {
                        con1.Open();
                    }
                    cmd1.ExecuteNonQuery();
                    if (con1.State == ConnectionState.Open)
                    {
                        con1.Close();
                    }
                    MessageBox.Show("Sorular Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grp[Convert.ToInt32(S1) - 1].Controls.Clear();
                    grp[Convert.ToInt32(S2) - 1].Controls.Clear();
                    llbl[Convert.ToInt32(S1) - 1].LinkColor = Color.Yellow;
                    llbl[Convert.ToInt32(S2) - 1].LinkColor = Color.Yellow;
                }
                else
                {
                    MessageBox.Show("Soru Belirlemediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEdit1.Width = Convert.ToInt32((comboBoxEdit1.Text.Length+1)*12);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
