using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Contexts;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Collections;

namespace YAZ_CIKART
{
    public partial class yazili : UserControl
    {
        public yazili()
        {
            InitializeComponent();
        }

        readonly Form2 frm2 = new Form2();
        public string okul;
        public string ders;
        public string bosluk = "                               ";
        public string bosluk2 = "                       ";
        public void Ric()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                richTextBox1.Text = bosluk + "frm2.donem" + "   " + Environment.NewLine + bosluk2 + okul + " " + comboBox1.Text + " " + comboBox4.Text + " " + ders + " " + Environment.NewLine + bosluk + comboBox3.Text + " " + comboBox2.Text;
            }
            else
            {
                richTextBox1.Text = "frm2.donem" + " " + "OKUL ADI" + " " + comboBox1.Text + " " + "SINIF" + "/" + "ŞUBE" + " " + "DERS" + " " + "DÖNEMİ" + " " + "SINAV TÜRÜ";
            }
        }
        public void Cur()
        {

        }

        private void Yazili_Load(object sender, EventArgs e)
        {
            Cur();
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            richTextBox1.ReadOnly = true;
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
        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != 0)
            {
                comboBox2.Enabled = true;
            }
            Cy(sender, e);
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cy(sender, e);
        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ric();
            comboBox1.Enabled = true; comboBox2.Enabled = true; comboBox3.Enabled = true; comboBox4.Enabled = true;
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
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            //Font myFont = new Font("Arial", 20);
            SolidBrush sbrush = new SolidBrush(richTextBox1.ForeColor);
            //Pen myPen = new Pen(Color.Black);
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, sbrush, 40, 100);
        }
        private void YazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(RichTextBox))
                {
                    ColorDialog dlg = new ColorDialog();
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ((RichTextBox)item).ForeColor = dlg.Color;
                    }
                }
            }
            //foreach (var item in groupBox3.Controls)
            //{
            //    if (item.GetType() == typeof(RichTextBox))
            //    {
            //        ColorDialog dlg = new ColorDialog();
            //        if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        {
            //            ((RichTextBox)item).ForeColor = dlg.Color;
            //        }
            //    }
            //}
        }

        private void YazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(RichTextBox))
                {
                    FontDialog fdlg = new FontDialog();
                    if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ((RichTextBox)item).Font = fdlg.Font;
                    }
                }
            }
        }

        private void İlkRengVeFontaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Black", 13);
            richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);
            richTextBox1.ForeColor = Color.Black;
            Ric();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                ilkRengVeFontaDönToolStripMenuItem.Visible = false;
            }
            else
            {
                ilkRengVeFontaDönToolStripMenuItem.Visible = true;
            }
        }

        private void TümünüKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^C");
        }

        private void TümünüKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^X");
        }

        private void YapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^V");
        }
        int sol = 0;
        readonly int yuk = 0;
        readonly int sols = 0;
        int yuks = 0;
        readonly ArrayList lst = new ArrayList();
        public dynamic grb = new GroupBox();
        public dynamic rc = new RichTextBox();
        void Llbl_Click(object sender, EventArgs e)
        {
            var count = groupBox2.Controls.OfType<LinkLabel>().Count();
            panel1.Top = ((LinkLabel)sender).Top - 2; panel1.Left = ((LinkLabel)sender).Left - 6; panel1.Width = (((LinkLabel)sender).Width) + 10; panel2.Width = (((LinkLabel)sender).Width) + 2;
            for (int i = 0; i < count - 1; i++)
            {
                if ((sender as LinkLabel).Text == "Soru 2") //(sender as LinkLabel).TabIndex == 2 //lst.Contains(grb.Text)
                {
                    MessageBox.Show("heee");
                }
                else
                {
                    grb.Top = 150;
                    grb.Left = 10;
                    grb.Width = 792;
                    grb.Height = 200;//400
                    grb.Text = "Soru " + ((LinkLabel)sender).Text;
                    grb.Font = new Font("Arial Black", 11);
                    grb.Name = "Soru" + ((LinkLabel)sender).Text;
                    grb.BackColor = Color.Transparent;
                    grb.TabIndex = 1;
                    groupBox3.Controls.Add(grb);
                    grb.Location = new Point(sols, yuks + 55);
                    grb.BringToFront();
                    if (((LinkLabel)sender).Text == grb.Text)
                    {
                        lst.Add(grb.Text);
                    }
                    rc.Top = 150;
                    rc.Left = 10;
                    rc.Width = 750;
                    rc.Height = 109;
                    rc.Font = new Font("Arial Black", 11);
                    rc.Name = "rc " + ((LinkLabel)sender).Text;
                    rc.BackColor = Color.LightGray;
                    grb.Controls.Add(rc);
                    rc.Location = new Point(sols + 8, yuks + 25);
                    label4.BringToFront();
                    label5.BringToFront();
                    yuks += 10;
                    label5.Text = "";
                    label4.Text = "";
                }
            }
        }

        private void ToolStripTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label2.Text == "dur")
                {
                    //durdu
                }
                else
                {
                    int a = int.Parse(toolStripTextBox4.Text);
                    if (a > 30)
                    {
                        MessageBox.Show("MAX 30");
                        toolStripTextBox4.Text = "";
                    }
                    else
                    {
                        LinkLabel llbl = new LinkLabel();
                        for (int i = 0; i < Convert.ToInt32(toolStripTextBox4.Text); i++)
                        {

                            ToolTip nam = new ToolTip();
                            llbl.Top = 10;
                            llbl.Left = 10;
                            llbl.Width = 30;
                            llbl.Text = (i + 1).ToString();
                            llbl.Font = new Font("Arial Black", 11);
                            llbl.Name = "Soru " + (i + 1).ToString();
                            llbl.BackColor = Color.Transparent;
                            llbl.Click += new EventHandler(Llbl_Click);
                            llbl.Click += Llbl2;
                            groupBox2.Controls.Add(llbl);
                            groupBox2.Controls.Add(panel1);
                            nam.SetToolTip(llbl, llbl.Name);
                            llbl.Location = new Point(sol + 8, yuk + 10);
                            panel1.Location = new Point(sol + 2, yuk + 8);
                            sol += 36;
                            label2.Text = "dur";
                            panel1.Location = new Point(2, 8);
                        }
                        LinkLabel llbls = new LinkLabel();
                        ToolTip nams = new ToolTip();
                        nams.SetToolTip(llbls, llbls.Name);
                        llbls.Top = 10;
                        llbls.Left = 10;
                        llbls.Text = "Yazdır";
                        llbls.Width = llbls.Text.Length * 12;
                        llbls.Font = new Font("Arial Black", 11);
                        llbls.Name = "Yazdır";
                        llbls.BackColor = Color.Transparent;
                        groupBox2.Controls.Add(llbls);
                        llbls.Location = new Point((Convert.ToInt32(toolStripTextBox4.Text) * 35) + 36, yuk + 10);
                        llbls.Click += new EventHandler(Llbls_Click);
                    }
                }
            }
        }

        private void Llbl2(object sender, EventArgs e)
        {

        }

        private void Llbls_Click(object sender, EventArgs e)
        {
            panel1.Top = ((LinkLabel)sender).Top - 2; panel1.Left = (((LinkLabel)sender).Left) - 6; panel1.Width = (((LinkLabel)sender).Width) + 10; panel1.SendToBack(); panel2.Width = (((LinkLabel)sender).Width) + 2;
        }

        private void ToolStripMenuItem2_MouseHover(object sender, EventArgs e)
        {
            toolStripTextBox4.TextBox.Focus();
        }
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                GroupBox grb = new GroupBox();
                //grb.Top = 150;
                //grb.Left = 10;
                //grb.Width = 792;
                //grb.Height = 400;
                //grb.Text = "Soru" + (i + 1).ToString();
                //grb.Font = new Font("Arial Black", 11);
                //grb.Name = "grp " + (i + 1).ToString();
                //grb.BackColor = Color.Transparent;
                //groupBox3.Controls.Add(grb);
                //grb.Location = new Point(sols, yuks + 55);
                RichTextBox rc = new RichTextBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 750,
                    Height = 109,
                    Font = new Font("Arial Black", 11),
                    Name = "Soru " + (i + 1).ToString(),
                    BackColor = Color.LightGray
                };
                grb.Controls.Add(rc);
                rc.Location = new Point(sols + 8, yuks + 25);
                for (int b = 0; b < 3; b++)
                {
                    RichTextBox rc2 = new RichTextBox
                    {
                        Top = 150,
                        Left = 10,
                        Width = 750,
                        Height = 50,
                        Font = new Font("Arial Black", 11),
                        Name = "Şık " + (b + 1).ToString(),
                        Text = (b + 1).ToString(),
                        BackColor = Color.LightGray
                    };
                    grb.Controls.Add(rc2);
                    rc2.Location = new Point(sols + 8, yuks + 150);
                    yuks += 70;
                    if (rc2.Text == 1.ToString())
                    {
                        rc2.Text = "A) ";
                    }
                    if (rc2.Text == 2.ToString())
                    {
                        rc2.Text = "B) ";
                    }
                    if (rc2.Text == 3.ToString())
                    {
                        rc2.Text = "C) ";
                    }
                }
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            label3.Text = groupBox1.Top.ToString();
            groupBox1.Top -= 4;
            groupBox3.Top -= 4;
            if (groupBox1.Top <= -197)
            {
                button5.BringToFront();
                timer4.Stop();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button5.SendToBack();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = groupBox1.Top.ToString();
            groupBox1.Top += 4;
            groupBox3.Top += 4;
            if (groupBox1.Top >= 0)
            {
                timer1.Stop();
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                GroupBox grb = new GroupBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 792,
                    Height = 400,
                    Text = "Soru" + (i + 1).ToString(),
                    Font = new Font("Arial Black", 11),
                    Name = "grp " + (i + 1).ToString(),
                    BackColor = Color.Transparent
                };
                groupBox3.Controls.Add(grb);
                grb.Location = new Point(sols, yuks + 55);
                RichTextBox rc = new RichTextBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 750,
                    Height = 109,
                    Font = new Font("Arial Black", 11),
                    Name = "Soru " + (i + 1).ToString(),
                    BackColor = Color.LightGray
                };
                grb.Controls.Add(rc);
                rc.Location = new Point(sols + 8, yuks + 25);
                RichTextBox rc2 = new RichTextBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 750,
                    Height = 119,
                    Font = new Font("Arial Black", 11),
                    Name = "Şıklar",
                    BackColor = Color.LightGray
                };
                grb.Controls.Add(rc2);
                rc2.Location = new Point(sols + 8, yuks + 150);
            }
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                GroupBox grb = new GroupBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 792,
                    Height = 400,
                    Text = "Soru" + (i + 1).ToString(),
                    Font = new Font("Arial Black", 11),
                    Name = "grp " + (i + 1).ToString(),
                    BackColor = Color.Transparent
                };
                groupBox3.Controls.Add(grb);
                grb.Location = new Point(sols, yuks + 55);
                RichTextBox rc = new RichTextBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 750,
                    Height = 109,
                    Font = new Font("Arial Black", 11),
                    Name = "Soru " + (i + 1).ToString(),
                    BackColor = Color.LightGray
                };
                grb.Controls.Add(rc);
                rc.Location = new Point(sols + 8, yuks + 25);
                for (int b = 0; b < 4; b++)
                {
                    RichTextBox rc2 = new RichTextBox
                    {
                        Top = 150,
                        Left = 10,
                        Width = 750,
                        Height = 50,
                        Font = new Font("Arial Black", 11),
                        Name = "Şık " + (b + 1).ToString(),
                        Text = (b + 1).ToString(),
                        BackColor = Color.LightGray
                    };
                    grb.Controls.Add(rc2);
                    rc2.Location = new Point(sols + 8, yuks + 150);
                    yuks += 70;
                    if (rc2.Text == 1.ToString())
                    {
                        rc2.Text = "A) ";
                    }
                    if (rc2.Text == 2.ToString())
                    {
                        rc2.Text = "B) ";
                    }
                    if (rc2.Text == 3.ToString())
                    {
                        rc2.Text = "C) ";
                    }
                    if (rc2.Text == 4.ToString())
                    {
                        rc2.Text = "D) ";
                    }
                }
            }
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                GroupBox grb = new GroupBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 792,
                    Height = 500,
                    Text = "Soru" + (i + 1).ToString(),
                    Font = new Font("Arial Black", 11),
                    Name = "grp " + (i + 1).ToString(),
                    BackColor = Color.Transparent
                };
                groupBox3.Controls.Add(grb);
                grb.Location = new Point(sols, yuks + 55);
                RichTextBox rc = new RichTextBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 750,
                    Height = 109,
                    Font = new Font("Arial Black", 11),
                    Name = "Soru " + (i + 1).ToString(),
                    BackColor = Color.LightGray
                };
                grb.Controls.Add(rc);
                rc.Location = new Point(sols + 8, yuks + 25);
                for (int b = 0; b < 5; b++)
                {
                    RichTextBox rc2 = new RichTextBox
                    {
                        Top = 150,
                        Left = 10,
                        Width = 750,
                        Height = 50,
                        Font = new Font("Arial Black", 11),
                        Name = "Şık " + (b + 1).ToString(),
                        Text = (b + 1).ToString(),
                        BackColor = Color.LightGray
                    };
                    grb.Controls.Add(rc2);
                    rc2.Location = new Point(sols + 8, yuks + 150);
                    yuks += 70;
                    if (rc2.Text == 1.ToString())
                    {
                        rc2.Text = "A) ";
                    }
                    if (rc2.Text == 2.ToString())
                    {
                        rc2.Text = "B) ";
                    }
                    if (rc2.Text == 3.ToString())
                    {
                        rc2.Text = "C) ";
                    }
                    if (rc2.Text == 4.ToString())
                    {
                        rc2.Text = "D) ";
                    }
                    if (rc2.Text == 5.ToString())
                    {
                        rc2.Text = "E) ";
                    }
                }
            }
        }

        private void GroupBox3_MouseHover(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {

            }
            else
            {
                if (groupBox1.Top <= -197)
                {
                    button5.BringToFront();
                    timer4.Stop();
                }
                else
                {
                    timer4.Start();
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void KlasikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                GroupBox grb = new GroupBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 792,
                    Height = 500,
                    Text = "Soru" + (i + 1).ToString(),
                    Font = new Font("Arial Black", 11),
                    Name = "grp " + (i + 1).ToString(),
                    BackColor = Color.Transparent
                };
                groupBox3.Controls.Add(grb);
                grb.Location = new Point(sols, yuks + 55);
                RichTextBox rc = new RichTextBox
                {
                    Top = 150,
                    Left = 10,
                    Width = 750,
                    Height = 109,
                    Font = new Font("Arial Black", 11),
                    Name = "Soru " + (i + 1).ToString(),
                    BackColor = Color.LightGray
                };
                grb.Controls.Add(rc);
                rc.Location = new Point(sols + 8, yuks + 25);
                for (int b = 0; b < 1; b++)
                {
                    RichTextBox rc2 = new RichTextBox
                    {
                        Top = 150,
                        Left = 10,
                        Width = 750,
                        Height = 119,
                        Font = new Font("Arial Black", 11),
                        Name = "Şıklar",
                        BackColor = Color.LightGray
                    };
                    grb.Controls.Add(rc2);
                    rc2.Location = new Point(sols + 8, yuks + 150);
                    //Label lb = new Label();
                    //lb.Top = 200;
                    //lb.Left = 6;
                    //lb.Width = 25;
                    //lb.Height = 25;
                    //lb.Text = "Cevap";
                    //grb.Controls.Add(lb);
                    //lb.Location = new Point(sols+8, yuks+230);
                }
            }
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^Z");
        }

        private void TümünüSeçToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(RichTextBox))
                {
                    ((RichTextBox)item).SelectAll();
                }
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cy(sender, e);
        }

        private void RichTextBox1_MouseEnter(object sender, EventArgs e)
        {
            if (richTextBox1.ReadOnly == true)
            {
                if (richTextBox1.Text == "")
                {
                    richTextBox1.Cursor = Cursors.No;
                }
                else
                {
                    richTextBox1.Cursor = Cursors.IBeam;
                }
            }
            else
            {
                richTextBox1.Cursor = Cursors.IBeam;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            _ = new Form2();
            //frm2.button11_Click(sender, e);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
