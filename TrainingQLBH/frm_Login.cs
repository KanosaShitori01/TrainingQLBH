using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DTO;
using BUS;
namespace TrainingQLBH
{
    public partial class frm_Login : Form
    {
        LoginControl LC = new LoginControl();
        LoginProps LP = new LoginProps();

        public frm_Login()
        {
            InitializeComponent();
        }
        private void LoginQuery()
        {
            LP.username = txt_tendangnhap.Text;
            LP.password = txt_matkhau.Text;
            string user = LC.checkAccount(LP);
            switch (user)
            {
                case "required_username":
                    MessageBox.Show("Không được để trống tài khoản");
                    return;
                case "required_password":
                    MessageBox.Show("Không được để trống mật khẩu");
                    return;
            }
            MessageBox.Show(LC.HashAccount(LP));
            frm_Main Main = new frm_Main();
            Main.Show();
            Main.NDL_menuToolStrip.Enabled = true;
            Main.nhậpDanhSáchNhânViênToolStripMenuItem.Enabled = true;
            Main.nhậpPhòngBanToolStripMenuItem.Enabled = true;
            this.Hide();
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            LoginQuery();
        }
    }
}
