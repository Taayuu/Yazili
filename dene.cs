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
using System.IO;

namespace YAZ_CIKART
{
    public partial class dene : Form
    {//ozellik_satir_sayisi = richTextBox3.Lines.Count();
       // richTextBox3.Multiline = true;
            //for (int i = 0; i <= ozellik_satir_sayisi; i++)
           // {
           //    string[] satirlar = richTextBox3.Lines;
       // richTextBox4.Line = satirlar;
         //   }
    public dene()
        {
            InitializeComponent();
        }
        string soru1, soru2, soru3, soru4;
        void Sonoku()
        {
            //SqlConnection con = new SqlConnection("Data Source=sunucuklmdr.database.windows.net;Initial Catalog=kalemdar;User ID=kalemdar;Password=1251a1985.;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection("Data Source=yusuf.database.windows.net;Initial Catalog=Yusuf;User ID=Taayuu;Password=Ty58yt85!;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT * FROM soru WHERE Id='" + 1 + "'", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                soru1 = Environment.NewLine+Convert.ToString(dr["SORU"]) + Environment.NewLine+ Convert.ToString(dr["SIK1"]) +Environment.NewLine+ Convert.ToString(dr["SIK2"]) + Environment.NewLine+ Convert.ToString(dr["SIK3"]) + Environment.NewLine;
                soru2 = Convert.ToString(dr["SIK1"]) + Environment.NewLine;
                soru3 = Convert.ToString(dr["SIK2"]) + Environment.NewLine;
                soru4 = Convert.ToString(dr["SIK3"]) + Environment.NewLine;

            }
            dr.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void dene_Load(object sender, EventArgs e)
        {
            Sonoku();
            richEditControl1.Text = soru1;
        }
    }
}
