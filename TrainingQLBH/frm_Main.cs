using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingQLBH
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PB nhapPB = new PB();
            nhapPB.Show();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void tổngHợpTheoDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTDA THDA = new TTDA();
            THDA.Show();
        }

        private void tổngHopwjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
