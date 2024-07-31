using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAZ_CIKART
{
    public partial class hazirbelge : UserControl
    {
        public hazirbelge()
        {
            InitializeComponent();
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
    }
}
