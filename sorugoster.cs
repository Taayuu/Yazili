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
using System.IO;
using System.Collections;
using System.Security.Permissions;

namespace YAZ_CIKART
{
    public partial class Sorugoster : UserControl
    {
        public Sorugoster()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        readonly ToolTip tt = new ToolTip();
        int i = 0;
        readonly Frmsadi sadi = new Frmsadi();
        readonly int a = 0;
        RichTextBox rc1;
        RichTextBox rc2;
        RichTextBox rc3;
        RichTextBox rc4;
        RichTextBox rc5;
        RichTextBox rc6;
        RichTextBox rc7;
        RichTextBox rc8;
        RichTextBox rc9;
        RichTextBox rc10;
        GroupBox gp1;
        Label[] lbl;
        string gridblg;

        private void Sorugoster_Load(object sender, EventArgs e)
        {
            Gridonay();
            var count = dataGridView1.Rows.Count;
            if (count! > 1)
            {
                Txtgec();
            }
            i = 0;
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

        public void Gridaracs()
        {
            Sonoku();
            lblsira();
            if (tbtn == "ileri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                gridblg = "gridaracs";
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "cs" + "'and durum='" + 2 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "cs";
            }
            else if (tbtn == "geri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                gridblg = "gridaracs";
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "cs" + "'and durum='" + 2 + "' and Id<'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "cs";
            }
            else
            {
                gridblg = "gridaracs";
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "cs" + "'and durum='" + 2 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "cs";
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
        }

        public void Gridarady()
        {
            gridblg = "gridarady";
            Sonoku();
            if (tbtn == "ileri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "dy" + "'and durum='" + 2 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "dy";
            }
            else if (tbtn == "geri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "dy" + "'and durum='" + 2 + "' and Id<'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "dy";
            }
            else
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "dy" + "'and durum='" + 2 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "dy";
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
        }

        public void Gridarabd()
        {
            Sonoku();
            if (tbtn == "ileri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                gridblg = "gridarabd";
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "bd" + "'and durum='" + 2 + "'and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "bd";
            }
            else if (tbtn == "geri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                gridblg = "gridarabd";
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "bd" + "'and durum='" + 2 + "'and Id<'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "bd";
            }
            else
            {
                gridblg = "gridarabd";
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //da = new SqlDataAdapter("Select * From soru WHERE konu like '" + comboBox2.Text + "%'", con);
                da = new SqlDataAdapter("Select * From soru WHERE konu='" + lookUpEdit3.Text + "'and stur='" + "bd" + "'and durum='" + 2 + "'and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labeltur.Text = "bd";
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
        }

        int g = 1;

        public void Gridonay()
        {
            gridblg = "gridonay";
            Sonoku();
            if (tbtn == "ileri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 2 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else if (tbtn == "geri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 2 + "' and Id < '" + g + "' order by Id desc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 2 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
        }

        public void Gridnonay()
        {
            gridblg = "gridnonay";
            Sonoku();
            if (tbtn == "ileri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 1 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else if (tbtn == "geri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 1 + "' and Id < '" + g + "' order by Id desc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 1 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
        }

        public void Gridpasif()
        {
            gridblg = "gridarapasif";
            Sonoku();
            if (tbtn == "ileri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 0 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else if (tbtn == "geri")
            {
                if (labelsid.Text != "")
                {
                    g = Convert.ToInt32(labelsid.Text);
                }

                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 0 + "' and Id < '" + g + "' order by Id desc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); da = new SqlDataAdapter("Select * From soru where durum=2", con);
                da = new SqlDataAdapter("Select top 10 with ties * From soru where durum='" + 0 + "' and Id>'" + g + "' order by Id asc", con);
                ds = new DataSet();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(ds, "soru");
                dataGridView1.DataSource = ds.Tables["soru"];
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
        }
        public string sinav;
        public string soru;
        public string btn9drm;
        public string mid;

        public void Artieksi()
        {
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select sid,mid from sinav WHERE kid='" + labelid.Text + "' AND sadi='" + sinav + "' AND sid='" + labelsid.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                soru = dr["sid"].ToString();
                mid = dr["mid"].ToString();
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (soru == labelsid.Text)
            {
                button9.BackgroundImage = Properties.Resources.minus;
                btn9drm = "-";
            }
            else if (soru != labelsid.Text)
            {
                button9.BackgroundImage = Properties.Resources.plus;
                btn9drm = "+";
            }
            soru = "";
        }

        public void Txtgec()
        {
            if (gridblg == "gridonay")
            {
                Gridonay();
            }
            if (gridblg == "gridaracs")
            {
                Gridaracs();
            }
            if (gridblg == "gridarabd")
            {
                Gridarabd();
            }
            if (gridblg == "gridarady")
            {
                Gridarady();
            }
            if (gridblg == "gridnonay")
            {
                Gridnonay();
            }
            if (gridblg == "gridpasif")
            {
                Gridpasif();
            }

            i = 0;

            try
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[26].Value.ToString() == "cs")
                    {
                        Ccsk();
                        if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                        {
                            labelsid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            rc1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            rc2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            rc3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            rc4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            rc5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            rc6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                            lookUpEdit1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                            lookUpEdit2.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                            lookUpEdit3.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                            labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                            label1.Text = "Doğru Cevap:" + (dataGridView1.Rows[i].Cells[15].Value.ToString()).ToUpper();
                            byte[] resim = (byte[])dataGridView1.Rows[i].Cells[7].Value;
                            MemoryStream ms = new MemoryStream(resim);
                            pictureBoxsr.Image = Image.FromStream(ms);
                            Artieksi();
                            if (rc2.Text == "")
                            {
                                rc2.Visible = false;
                            }
                            if (rc3.Text == "")
                            {
                                rc3.Visible = false;
                            }
                            if (rc4.Text == "")
                            {
                                rc4.Visible = false;
                            }
                            if (rc5.Text == "")
                            {
                                rc5.Visible = false;
                            }
                            if (rc6.Text == "")
                            {
                                rc6.Visible = false;
                            }
                            if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                            {
                                pictureBoxsr.Image = null;
                                button2.Visible = false;
                            }
                            if (rc2.Text != "")
                            {
                                rc2.Visible = true;
                            }
                            if (rc3.Text != "")
                            {
                                rc3.Visible = true;
                            }
                            if (rc4.Text != "")
                            {
                                rc4.Visible = true;
                            }
                            if (rc5.Text != "")
                            {
                                rc5.Visible = true;
                            }
                            if (rc6.Text != "")
                            {
                                rc6.Visible = true;
                            }
                            if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                            {
                                button2.Visible = true;
                            }
                            if (rc2.Text == "" && rc3.Text == "" && rc4.Text == "" && rc5.Text == "" && rc6.Text == "")
                            {
                                rc1.Width = 700;
                                rc1.Height = 300;
                            }
                            else
                            {
                                rc1.Width = 721;
                                rc1.Height = 109;
                            }
                        }
                        else
                        {
                            labelsid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            rc1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            rc2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            rc3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            rc4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                            rc5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                            rc6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                            lookUpEdit1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                            lookUpEdit2.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                            lookUpEdit3.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                            labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                            label1.Text = "Doğru Cevap:" + (dataGridView1.Rows[i].Cells[15].Value.ToString()).ToUpper();
                            Artieksi();
                            if (rc2.Text == "")
                            {
                                rc2.Visible = false;
                            }
                            if (rc3.Text == "")
                            {
                                rc3.Visible = false;
                            }
                            if (rc4.Text == "")
                            {
                                rc4.Visible = false;
                            }
                            if (rc5.Text == "")
                            {
                                rc5.Visible = false;
                            }
                            if (rc6.Text == "")
                            {
                                rc6.Visible = false;
                            }
                            if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                            {
                                pictureBoxsr.Image = null;
                                button2.Visible = false;
                            }
                            if (rc2.Text != "")
                            {
                                rc2.Visible = true;
                            }
                            if (rc3.Text != "")
                            {
                                rc3.Visible = true;
                            }
                            if (rc4.Text != "")
                            {
                                rc4.Visible = true;
                            }
                            if (rc5.Text != "")
                            {
                                rc5.Visible = true;
                            }
                            if (rc6.Text != "")
                            {
                                rc6.Visible = true;
                            }
                            if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                            {
                                button2.Visible = true;
                            }
                            if (rc2.Text == "" && rc3.Text == "" && rc4.Text == "" && rc5.Text == "" && rc6.Text == "")
                            {
                                rc1.Width = 721;
                                rc1.Height = 300;
                            }
                            else
                            {
                                rc1.Width = 721;
                                rc1.Height = 109;
                            }
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[26].Value.ToString() == "bd")
                    {
                        Bd();
                        try
                        {
                            if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                            {
                                labelsid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                rc1.Text = dataGridView1.Rows[i].Cells[16].Value.ToString().Remove(0, 3);
                                rc2.Text = dataGridView1.Rows[i].Cells[17].Value.ToString().Remove(0, 3);
                                rc3.Text = dataGridView1.Rows[i].Cells[18].Value.ToString().Remove(0, 3);
                                rc4.Text = dataGridView1.Rows[i].Cells[19].Value.ToString().Remove(0, 3);
                                rc5.Text = dataGridView1.Rows[i].Cells[20].Value.ToString().Remove(0, 3);
                                rc6.Text = dataGridView1.Rows[i].Cells[21].Value.ToString().Remove(0, 3);
                                rc7.Text = dataGridView1.Rows[i].Cells[22].Value.ToString().Remove(0, 3);
                                rc8.Text = dataGridView1.Rows[i].Cells[23].Value.ToString().Remove(0, 3);
                                rc9.Text = dataGridView1.Rows[i].Cells[24].Value.ToString().Remove(0, 3);
                                rc10.Text = dataGridView1.Rows[i].Cells[25].Value.ToString().Remove(0, 3);
                                lookUpEdit1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                                lookUpEdit2.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                                lookUpEdit3.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                                labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                                byte[] resim = (byte[])dataGridView1.Rows[i].Cells[7].Value;
                                MemoryStream ms = new MemoryStream(resim);
                                pictureBoxsr.Image = Image.FromStream(ms);
                                Artieksi();
                                if (rc2.Text == "")
                                {
                                    rc2.Visible = false;
                                }
                                if (rc3.Text == "")
                                {
                                    rc3.Visible = false;
                                }
                                if (rc4.Text == "")
                                {
                                    rc4.Visible = false;
                                }
                                if (rc5.Text == "")
                                {
                                    rc5.Visible = false;
                                }
                                if (rc6.Text == "")
                                {
                                    rc6.Visible = false;
                                }
                                if (rc7.Text == "")
                                {
                                    rc7.Visible = false;
                                }
                                if (rc8.Text == "")
                                {
                                    rc8.Visible = false;
                                }
                                if (rc9.Text == "")
                                {
                                    rc9.Visible = false;
                                }
                                if (rc10.Text == "")
                                {
                                    rc10.Visible = false;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                                {
                                    pictureBoxsr.Image = null;
                                    button2.Visible = false;
                                }
                                if (rc2.Text != "")
                                {
                                    rc2.Visible = true;
                                }
                                if (rc3.Text != "")
                                {
                                    rc3.Visible = true;
                                }
                                if (rc4.Text != "")
                                {
                                    rc4.Visible = true;
                                }
                                if (rc5.Text != "")
                                {
                                    rc5.Visible = true;
                                }
                                if (rc6.Text != "")
                                {
                                    rc6.Visible = true;
                                }
                                if (rc7.Text != "")
                                {
                                    rc7.Visible = true;
                                }
                                if (rc8.Text != "")
                                {
                                    rc8.Visible = true;
                                }
                                if (rc9.Text != "")
                                {
                                    rc9.Visible = true;
                                }
                                if (rc10.Text != "")
                                {
                                    rc10.Visible = true;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                                {
                                    button2.Visible = true;
                                }
                            }
                            else
                            {
                                labelsid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                rc1.Text = dataGridView1.Rows[i].Cells[16].Value.ToString().Remove(0, 3);
                                rc2.Text = dataGridView1.Rows[i].Cells[17].Value.ToString().Remove(0, 3);
                                rc3.Text = dataGridView1.Rows[i].Cells[18].Value.ToString().Remove(0, 3);
                                rc4.Text = dataGridView1.Rows[i].Cells[19].Value.ToString().Remove(0, 3);
                                rc5.Text = dataGridView1.Rows[i].Cells[20].Value.ToString().Remove(0, 3);
                                rc6.Text = dataGridView1.Rows[i].Cells[21].Value.ToString().Remove(0, 3);
                                rc7.Text = dataGridView1.Rows[i].Cells[22].Value.ToString().Remove(0, 3);
                                rc8.Text = dataGridView1.Rows[i].Cells[23].Value.ToString().Remove(0, 3);
                                rc9.Text = dataGridView1.Rows[i].Cells[24].Value.ToString().Remove(0, 3);
                                rc10.Text = dataGridView1.Rows[i].Cells[25].Value.ToString().Remove(0, 3);
                                lookUpEdit1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                                lookUpEdit2.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                                lookUpEdit3.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                                labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                                Artieksi();
                                if (rc2.Text == "")
                                {
                                    rc2.Visible = false;
                                }
                                if (rc3.Text == "")
                                {
                                    rc3.Visible = false;
                                }
                                if (rc4.Text == "")
                                {
                                    rc4.Visible = false;
                                }
                                if (rc5.Text == "")
                                {
                                    rc5.Visible = false;
                                }
                                if (rc6.Text == "")
                                {
                                    rc6.Visible = false;
                                }
                                if (rc7.Text == "")
                                {
                                    rc7.Visible = false;
                                }
                                if (rc8.Text == "")
                                {
                                    rc8.Visible = false;
                                }
                                if (rc9.Text == "")
                                {
                                    rc9.Visible = false;
                                }
                                if (rc10.Text == "")
                                {
                                    rc10.Visible = false;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                                {
                                    pictureBoxsr.Image = null;
                                    button2.Visible = false;
                                }
                                if (rc2.Text != "")
                                {
                                    rc2.Visible = true;
                                }
                                if (rc3.Text != "")
                                {
                                    rc3.Visible = true;
                                }
                                if (rc4.Text != "")
                                {
                                    rc4.Visible = true;
                                }
                                if (rc5.Text != "")
                                {
                                    rc5.Visible = true;
                                }
                                if (rc6.Text != "")
                                {
                                    rc6.Visible = true;
                                }
                                if (rc7.Text != "")
                                {
                                    rc7.Visible = true;
                                }
                                if (rc8.Text != "")
                                {
                                    rc8.Visible = true;
                                }
                                if (rc9.Text != "")
                                {
                                    rc9.Visible = true;
                                }
                                if (rc10.Text != "")
                                {
                                    rc10.Visible = true;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                                {
                                    button2.Visible = true;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                                {
                                    button2.Visible = true;
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else if (dataGridView1.Rows[i].Cells[26].Value.ToString() == "dy")
                    {
                        Dy();
                        try
                        {
                            if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                            {
                                labelsid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                rc1.Text = dataGridView1.Rows[i].Cells[16].Value.ToString().Remove(0, 8);
                                rc2.Text = dataGridView1.Rows[i].Cells[17].Value.ToString().Remove(0, 8);
                                rc3.Text = dataGridView1.Rows[i].Cells[18].Value.ToString().Remove(0, 8);
                                rc4.Text = dataGridView1.Rows[i].Cells[19].Value.ToString().Remove(0, 8);
                                rc5.Text = dataGridView1.Rows[i].Cells[20].Value.ToString().Remove(0, 8);
                                rc6.Text = dataGridView1.Rows[i].Cells[21].Value.ToString().Remove(0, 8);
                                rc7.Text = dataGridView1.Rows[i].Cells[22].Value.ToString().Remove(0, 8);
                                rc8.Text = dataGridView1.Rows[i].Cells[23].Value.ToString().Remove(0, 8);
                                rc9.Text = dataGridView1.Rows[i].Cells[24].Value.ToString().Remove(0, 8);
                                rc10.Text = dataGridView1.Rows[i].Cells[25].Value.ToString().Remove(0, 8);
                                lookUpEdit1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                                lookUpEdit2.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                                lookUpEdit3.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                                labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                                byte[] resim = (byte[])dataGridView1.Rows[i].Cells[7].Value;
                                MemoryStream ms = new MemoryStream(resim);
                                pictureBoxsr.Image = Image.FromStream(ms);
                                Artieksi();
                                if (rc2.Text == "")
                                {
                                    rc2.Visible = false;
                                }
                                if (rc3.Text == "")
                                {
                                    rc3.Visible = false;
                                }
                                if (rc4.Text == "")
                                {
                                    rc4.Visible = false;
                                }
                                if (rc5.Text == "")
                                {
                                    rc5.Visible = false;
                                }
                                if (rc6.Text == "")
                                {
                                    rc6.Visible = false;
                                }
                                if (rc7.Text == "")
                                {
                                    rc7.Visible = false;
                                }
                                if (rc8.Text == "")
                                {
                                    rc8.Visible = false;
                                }
                                if (rc9.Text == "")
                                {
                                    rc9.Visible = false;
                                }
                                if (rc10.Text == "")
                                {
                                    rc10.Visible = false;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                                {
                                    pictureBoxsr.Image = null;
                                    button2.Visible = false;
                                }
                                if (rc2.Text != "")
                                {
                                    rc2.Visible = true;
                                }
                                if (rc3.Text != "")
                                {
                                    rc3.Visible = true;
                                }
                                if (rc4.Text != "")
                                {
                                    rc4.Visible = true;
                                }
                                if (rc5.Text != "")
                                {
                                    rc5.Visible = true;
                                }
                                if (rc6.Text != "")
                                {
                                    rc6.Visible = true;
                                }
                                if (rc7.Text != "")
                                {
                                    rc7.Visible = true;
                                }
                                if (rc8.Text != "")
                                {
                                    rc8.Visible = true;
                                }
                                if (rc9.Text != "")
                                {
                                    rc9.Visible = true;
                                }
                                if (rc10.Text != "")
                                {
                                    rc10.Visible = true;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                                {
                                    button2.Visible = true;
                                }
                            }
                            else
                            {
                                labelsid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                rc1.Text = dataGridView1.Rows[i].Cells[16].Value.ToString().Remove(0, 8);
                                rc2.Text = dataGridView1.Rows[i].Cells[17].Value.ToString().Remove(0, 8);
                                rc3.Text = dataGridView1.Rows[i].Cells[18].Value.ToString().Remove(0, 8);
                                rc4.Text = dataGridView1.Rows[i].Cells[19].Value.ToString().Remove(0, 8);
                                rc5.Text = dataGridView1.Rows[i].Cells[20].Value.ToString().Remove(0, 8);
                                rc6.Text = dataGridView1.Rows[i].Cells[21].Value.ToString().Remove(0, 8);
                                rc7.Text = dataGridView1.Rows[i].Cells[22].Value.ToString().Remove(0, 8);
                                rc8.Text = dataGridView1.Rows[i].Cells[23].Value.ToString().Remove(0, 8);
                                rc9.Text = dataGridView1.Rows[i].Cells[24].Value.ToString().Remove(0, 8);
                                rc10.Text = dataGridView1.Rows[i].Cells[25].Value.ToString().Remove(0, 8);
                                lookUpEdit1.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                                lookUpEdit2.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                                lookUpEdit3.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
                                labeltur.Text = dataGridView1.Rows[i].Cells[26].Value.ToString();
                                Artieksi();
                                if (rc2.Text == "")
                                {
                                    rc2.Visible = false;
                                }
                                if (rc3.Text == "")
                                {
                                    rc3.Visible = false;
                                }
                                if (rc4.Text == "")
                                {
                                    rc4.Visible = false;
                                }
                                if (rc5.Text == "")
                                {
                                    rc5.Visible = false;
                                }
                                if (rc6.Text == "")
                                {
                                    rc6.Visible = false;
                                }
                                if (rc7.Text == "")
                                {
                                    rc7.Visible = false;
                                }
                                if (rc8.Text == "")
                                {
                                    rc8.Visible = false;
                                }
                                if (rc9.Text == "")
                                {
                                    rc9.Visible = false;
                                }
                                if (rc10.Text == "")
                                {
                                    rc10.Visible = false;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value == DBNull.Value)
                                {
                                    pictureBoxsr.Image = null;
                                    button2.Visible = false;
                                }
                                if (rc2.Text != "")
                                {
                                    rc2.Visible = true;
                                }
                                if (rc3.Text != "")
                                {
                                    rc3.Visible = true;
                                }
                                if (rc4.Text != "")
                                {
                                    rc4.Visible = true;
                                }
                                if (rc5.Text != "")
                                {
                                    rc5.Visible = true;
                                }
                                if (rc6.Text != "")
                                {
                                    rc6.Visible = true;
                                }
                                if (rc7.Text != "")
                                {
                                    rc7.Visible = true;
                                }
                                if (rc8.Text != "")
                                {
                                    rc8.Visible = true;
                                }
                                if (rc9.Text != "")
                                {
                                    rc9.Visible = true;
                                }
                                if (rc10.Text != "")
                                {
                                    rc10.Visible = true;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                                {
                                    button2.Visible = true;
                                }
                                if (dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                                {
                                    button2.Visible = true;
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    panel1.Focus();
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (tbtn == "ileri")
                {
                    g += 1;
                    Gridonay();
                }
                else if (tbtn == "geri")
                {
                    g -= 1;
                    Gridonay();
                }
            }
        }

        void Bd()
        {
            int onuc = 13;
            panel1.Controls.Clear();
            gp1 = new GroupBox
            {
                Width = 744,
                Height = 455,
                Left = 3,
                Top = 6,
                BackColor = Color.Black,
                Font = new Font("Arial Black", 12, FontStyle.Bold)
            };
            rc1 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc2 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc3 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 2 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc4 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 3 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc5 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 4 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc6 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 5 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc7 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 6 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc8 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 7 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc9 = new RichTextBox
            {
                Width = 707,
                Height = 35,
                Left = 25,
                Top = onuc + 8 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc10 = new RichTextBox
            {
                Width = 697,
                Height = 35,
                Left = 35,
                Top = onuc + 9 * 40,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            panel1.Controls.Add(gp1);
            gp1.Controls.Add(rc1);
            gp1.Controls.Add(rc2);
            gp1.Controls.Add(rc3);
            gp1.Controls.Add(rc4);
            gp1.Controls.Add(rc5);
            gp1.Controls.Add(rc6);
            gp1.Controls.Add(rc7);
            gp1.Controls.Add(rc8);
            gp1.Controls.Add(rc9);
            gp1.Controls.Add(rc10);
            lbl = new Label[10];
            for (int s = 0; s < 10; s++)
            {
                lbl[s] = new Label
                {
                    Text = (s + 1) + ")",
                    Font = new Font("Arial Black", 11),
                    ForeColor = Color.White,
                };
                lbl[s].Location = new Point(4, onuc + 5);
                gp1.Controls.Add(lbl[s]);
                onuc += 40;
            }
        }

        void Dy()
        {
            int onuc = 13;
            panel1.Controls.Clear();
            gp1 = new GroupBox
            {
                Width = 744,
                Height = 455,
                Left = 3,
                Top = 6,
                BackColor = Color.Black,
            };
            rc1 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc2 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc3 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 2 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc4 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 3 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc5 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 4 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc6 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 5 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc7 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 6 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc8 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 7 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc9 = new RichTextBox
            {
                Width = 680,
                Height = 35,
                Left = 50,
                Top = onuc + 8 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            rc10 = new RichTextBox
            {
                Width = 670,
                Height = 35,
                Left = 60,
                Top = onuc + 9 * 40,
                Font = new Font("Arial Black", 11, FontStyle.Bold),
                ReadOnly = true
            };
            panel1.Controls.Add(gp1);
            gp1.Controls.Add(rc1);
            gp1.Controls.Add(rc2);
            gp1.Controls.Add(rc3);
            gp1.Controls.Add(rc4);
            gp1.Controls.Add(rc5);
            gp1.Controls.Add(rc6);
            gp1.Controls.Add(rc7);
            gp1.Controls.Add(rc8);
            gp1.Controls.Add(rc9);
            gp1.Controls.Add(rc10);
            lbl = new Label[10];
            for (int s = 0; s < 10; s++)
            {
                lbl[s] = new Label
                {
                    Text = (s + 1) + ") ( )",
                    Font = new Font("Arial Black", 11),
                    ForeColor = Color.White,
                };
                lbl[s].Location = new Point(4, onuc + 5);
                gp1.Controls.Add(lbl[s]);
                onuc += 40;
            }
        }

        private void Ccsk()
        {
            panel1.Controls.Clear();
            gp1 = new GroupBox
            {
                Width = 744,
                Height = 455,
                Left = 3,
                Top = 6,
                BackColor = Color.Black,
                Font = new Font("Arial Black", 12, FontStyle.Bold)
            };
            rc1 = new RichTextBox
            {
                Width = 721,
                Height = 109,
                Left = 10,
                Top = 18 - 5,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc2 = new RichTextBox
            {
                Width = 721,
                Height = 50,
                Left = 10,
                Top = 150 - 15,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc3 = new RichTextBox
            {
                Width = 721,
                Height = 50,
                Left = 10,
                Top = 215 - 15,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc4 = new RichTextBox
            {
                Width = 721,
                Height = 50,
                Left = 10,
                Top = 279 - 15,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc5 = new RichTextBox
            {
                Width = 721,
                Height = 50,
                Left = 10,
                Top = 344 - 15,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            rc6 = new RichTextBox
            {
                Width = 721,
                Height = 50,
                Left = 10,
                Top = 407 - 15,
                Font = new Font("Arial Black", 12, FontStyle.Bold),
                ReadOnly = true
            };
            panel1.Controls.Add(gp1);
            gp1.Controls.Add(rc1);
            gp1.Controls.Add(rc2);
            gp1.Controls.Add(rc3);
            gp1.Controls.Add(rc4);
            gp1.Controls.Add(rc5);
            gp1.Controls.Add(rc6);
        }

        int bir = 1;
        string tbtn;

        public void Btnİleri_Click(object sender, EventArgs e)
        {
            lblsira();
            tbtn = "ileri";
            g += 1;
            i++;
            bir += 1;
            if (bir <= s)
            {
                Txtgec();
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
            else
            {
                MessageBox.Show("Bu tarafta soru kalmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                g--;
                i--;
                bir--;
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            tbtn = "geri";
            g -= 1;
            i--;
            bir -= 1;
            if (bir >= 1)
            {
                Txtgec();
                labelsirano.Text = bir.ToString() + " / " + (s).ToString();
            }
            else
            {
                MessageBox.Show("Bu tarafta soru kalmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                i = 0;
                bir++;
                i++;
                g++;
            }
        }

        private void BtnGeri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                BtnGeri_Click(sender, e);
            }
        }


        private void Btnİleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Btnİleri_Click(sender, e);
            }
        }

        int b2 = 0;

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            i = 0;
            bir = 1;
            g = 1;
            if (radioButton1.Checked)
            {
                Gridaracs();
            }
            else if (radioButton2.Checked)
            {
                Gridarady();
            }
            else if (radioButton3.Checked)
            {
                Gridarabd();
            }
            Txtgec();
        }

        private void ComboBox3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                Gridpasif();
                Txtgec();
            }
            if (comboBox4.SelectedIndex == 1)
            {
                Gridonay();
                Txtgec();
                Sonoku();
            }
            if (comboBox4.SelectedIndex == 2)
            {
                Gridnonay();
                Txtgec();
            }
        }

        int s;

        void Sonoku()
        {
            if (gridblg == "gridonay")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlCommand cmd = new SqlCommand("SELECT mid FROM soru WHERE durum ='" + durumson + "'", con);
                SqlCommand cmd = new SqlCommand("SELECT count(mid) as mid FROM soru WHERE durum ='" + durumson + "'", con);
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
            else if (gridblg == "gridnonay")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlCommand cmd = new SqlCommand("SELECT mid FROM soru WHERE durum ='" + durumson + "'", con);
                SqlCommand cmd = new SqlCommand("SELECT count(mid) as mid FROM soru WHERE durum ='" + 1 + "'", con);
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
            else if (gridblg == "gridpasif")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //SqlCommand cmd = new SqlCommand("SELECT mid FROM soru WHERE durum ='" + durumson + "'", con);
                SqlCommand cmd = new SqlCommand("SELECT count(mid) as mid FROM soru WHERE durum ='" + 0 + "'", con);
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
            else if (gridblg == "gridaracs")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("SELECT count(mid) as mid FROM soru WHERE durum ='" + durumson + "' and stur ='" + "cs" + "' and konu='" + lookUpEdit3.Text + "'", con);
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
            else if (gridblg == "gridarady")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("SELECT count(mid) as mid FROM soru WHERE durum ='" + durumson + "' and stur ='" + "dy" + "' and konu='" + lookUpEdit3.Text + "'", con);
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
            else if (gridblg == "gridarabd")
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("SELECT count(mid) as mid FROM soru WHERE durum ='" + durumson + "' and stur ='" + "bd" + "' and konu='" + lookUpEdit3.Text + "'", con);
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
        }

        void lblsira()
        {
            /*
             * onaylı soruların adedi kadar sıra sayısı
            */
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("with tally (eksik) AS (SELECT TOP (SELECT MAX(Id) FROM soru where durum='" + 2 + "') ROW_NUMBER() OVER (ORDER BY t1.Object_ID) AS eksik FROM Yusuf.sys.All_Columns t1 CROSS JOIN Yusuf.sys.All_Columns t2)SELECT eksik FROM tally", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // sira = Convert.ToInt32(dr["eksik"]);
            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        int durumson = 2;
        int durumek = 1;
        int eksikk;

        void eksik()
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("with tally (eksik) AS (SELECT TOP (SELECT MAX(mid) FROM soru where durum='" + durumek + "' ) ROW_NUMBER() OVER (ORDER BY t1.Object_ID) AS eksik FROM Yusuf.sys.All_Columns t1 CROSS JOIN Yusuf.sys.All_Columns t2)SELECT eksik FROM tally WHERE NOT EXISTS (SELECT * FROM soru WHERE durum='" + durumek + "' and mid = eksik)", con);
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

        private void Button3_Click(object sender, EventArgs e)
        {
            durumek = 2;
            eksik();
            if (eksikk < 1)
            {
                Sonoku();
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("update soru set durum=@durum, mid=@mid where Id='" + labelsid.Text + "'", con);
                cmd.Parameters.AddWithValue("@durum", 2);
                cmd.Parameters.AddWithValue("@mid", s + 1);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Soru Onaylandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durumek = 1;
            }
            else
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("update soru set durum=@durum, mid=@mid where Id='" + labelsid.Text + "'", con);
                cmd.Parameters.AddWithValue("@durum", 2);
                cmd.Parameters.AddWithValue("@mid", eksikk);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Soru Onaylandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                durumek = 1;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            durumson = 1;
            eksik();
            if (eksikk < 1)
            {
                Sonoku();
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("update soru set durum=@durum, mid=@mid where Id='" + labelsid.Text + "'", con);
                cmd.Parameters.AddWithValue("@durum", 1);
                cmd.Parameters.AddWithValue("@mid", s + 1);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Soru Reddedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("update soru set durum=@durum, mid=@mid where Id='" + labelsid.Text + "'", con);
                cmd.Parameters.AddWithValue("@durum", 1);
                cmd.Parameters.AddWithValue("@mid", eksikk);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Soru Reddedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            durumson = 2;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            durumek = 0;
            if (eksikk < 1)
            {
                durumson = 0;
                Sonoku();
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("update soru set durum=@durum, mid=@mid where Id='" + labelsid.Text + "'", con);
                cmd.Parameters.AddWithValue("@durum", 0);
                cmd.Parameters.AddWithValue("@mid", s + 1);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Soru Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlConnection con = new SqlConnection("Data Source = yusuf.database.windows.net; Initial Catalog = Yusuf; User ID = Taayuu; Password = Ty58yt85!; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cmd = new SqlCommand("update soru set durum=@durum, mid=@mid where Id='" + labelsid.Text + "'", con);
                cmd.Parameters.AddWithValue("@durum", 0);
                cmd.Parameters.AddWithValue("@mid", eksikk);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Soru Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            durumson = 2;
            durumek = 1;
        }

        private void Button6_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button6, "Bildir");
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button3, "Onayla");
        }

        private void Button4_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button4, "Normal");
        }

        private void Button5_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button5, "Sil");
        }

        private void Btnİleri_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Btnİleri, "Sonraki Soru");
        }

        private void BtnGeri_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(BtnGeri, "Önceki Soru");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            frmbildir frmbildir = new frmbildir();
            frmbildir.labelid.Text = this.labelid.Text;
            frmbildir.labelsid.Text = this.labelsid.Text;
            frmbildir.ShowDialog();
        }

        private void Panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Btnİleri_Click(sender, e);
                panel1.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                BtnGeri_Click(sender, e);
                panel1.Focus();
            }
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        public void Bnmsoru()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            da = new SqlDataAdapter("Select * From soru WHERE KID like '" + labelid.Text + "%'", con);
            ds = new DataSet();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            da.Fill(ds, "soru");
            dataGridView1.DataSource = ds.Tables["soru"];
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                Bnmsoru();
                Txtgec();
            }
            catch
            {
                MessageBox.Show("Sorunuz Bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            //DialogResult pdr = printDialog1.ShowDialog();
            //if (pdr == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush sbrush = new SolidBrush(rc1.ForeColor);
            if (labeltur.Text == "cs")
            {
                if (pictureBoxsr.Image != null)
                {
                    e.Graphics.DrawImage(pictureBoxsr.Image, 40, 100, pictureBoxsr.Image.Width, pictureBoxsr.Image.Height);
                    e.Graphics.DrawString(rc1.Text + Environment.NewLine + rc2.Text + Environment.NewLine + rc3.Text + Environment.NewLine + rc4.Text + Environment.NewLine + rc5.Text + Environment.NewLine + rc6.Text, rc1.Font, sbrush, 40, (pictureBoxsr.Image.Height) + 150);
                    //e.Graphics.DrawString(richTextBox2.Text, richTextBox2.Font, sbrush, 40, (pictureBoxsr.Image.Height)+200);
                }
                else
                {
                    e.Graphics.DrawString(rc1.Text, rc1.Font, sbrush, 40, 100);
                    e.Graphics.DrawString(rc1.Text + Environment.NewLine + rc2.Text + Environment.NewLine + rc3.Text + Environment.NewLine + rc4.Text + Environment.NewLine + rc5.Text + Environment.NewLine + rc6.Text, rc1.Font, sbrush, 40, 100);
                }
            }
            else if (labeltur.Text == "dy")
            {
                e.Graphics.DrawString(rc1.Text, rc1.Font, sbrush, 40, 100);
                e.Graphics.DrawString(rc1.Text + Environment.NewLine + rc2.Text + Environment.NewLine + rc3.Text + Environment.NewLine + rc4.Text + Environment.NewLine + rc5.Text + Environment.NewLine + rc6.Text + Environment.NewLine + rc7.Text + Environment.NewLine + rc8.Text + Environment.NewLine + rc9.Text + Environment.NewLine + rc10.Text, rc1.Font, sbrush, 40, 100);
            }
        }

        private void Button8_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(button8, "Önizleme");
        }

        private void Button9_MouseHover(object sender, EventArgs e)
        {
            if (btn9drm == "+")
            {
                tt.SetToolTip(button9, "Sınava Ekle");
            }
            else if (btn9drm == "-")
            {
                tt.SetToolTip(button9, "Sınavdan Çıkar");
            }
        }

        private void ComboBox4_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(comboBox4, comboBox4.Text);
        }

        private void Button10_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(button10, "Sınav Değiş");
        }

        private void labelsinav_TextChanged(object sender, EventArgs e)
        {
            button10.Visible = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (b2 == 0)
            {
                pictureBoxsr.Visible = true;
                //panel1.Visible = false;
                button2.BackColor = Color.Red;
                button2.Text = "Geri";
                //panel1.Size = new Size(panel1.Width, (panel1.Height) - (pictureBoxsr.Height));
                pictureBoxsr.BringToFront();
                b2 = 1;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (b2 == 1)
            {
                pictureBoxsr.Visible = false;
                panel1.Visible = true;
                button2.BackColor = Color.Navy;
                button2.Text = "Resim Önz.";
                //panel1.Size = new Size(panel1.Width, (panel1.Height) + (pictureBoxsr.Height));
                pictureBoxsr.SendToBack();
                b2 = 0;
            }
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

        private void lookUpEdit1_Click(object sender, EventArgs e)
        {

        }
    }
}
