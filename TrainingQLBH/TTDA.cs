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

namespace TrainingQLBH
{
    public partial class TTDA : Form
    {
        SqlConnection kn = new SqlConnection(@"Server=.; database=qlda; Integrated security = true");
        SqlDataAdapter da;
        DataTable dt;
        public TTDA()
        {
            InitializeComponent();
        }

        private void meomew_Load(object sender, EventArgs e)
        {
            //buoc_cbb();
            trevew();
            buoc_cb_mada();



        }
        //public void buoc_luoi()
        //{
        //    string chuoi = String.Format("select * from THAMGIA where MADA='" + this.cbb_mada.Text + "'");
        //    SqlDataAdapter da = new SqlDataAdapter(chuoi, kn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    DataView dv = new DataView(dt);
        //    dv.Sort = "SOGIOLAMVIEC";
        //    this.dgv_ht.DataSource = dv;
        //}


        private void cbb_mada_SelectedIndexChanged(object sender, EventArgs e)
        {
            buoctenda();
            //buoc_luoi();
            //buoctennv();


        }
        //public void buoc_cbb()
        //{
        //    SqlDataReader drr;
        //    string chuoitv = "Select * from DUAN";
        //    SqlCommand cmd = new SqlCommand(chuoitv, kn);
        //    cmd.Connection.Open();
        //    drr = cmd.ExecuteReader();
        //    while (drr.Read())
        //    {
        //        this.cbb_mada.Items.Add(drr.GetValue(0));
        //    }
        //    cmd.Connection.Close();
        //}

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void trevew()
        {
            da = new SqlDataAdapter(String.Format("SELECT * from DUAN"), kn);
            dt = new DataTable(); dt.Clear();
            da.Fill(dt);
            tv_ds.Nodes.Clear();
            tv_ds.BeginUpdate();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tv_ds.Nodes.Add(dt.Rows[i]["TENDA"].ToString());
                SqlDataAdapter datg = new SqlDataAdapter(String.Format(" Select NHANVIEN.MANV, HODEM, TENNV, HODEM+TENNV AS HOTEN FROM NHANVIEN,THAMGIA WHERE NHANVIEN.MANV = THAMGIA.MANV AND THAMGIA.TENDA = N'{0}'", dt.Rows[i]["TENDA"].ToString()), kn);
                DataTable dt_tg = new DataTable();
                dt_tg.Clear();
                datg.Fill(dt_tg);
                for (int j = 0; j < dt_tg.Rows.Count; j++)
                {
                    tv_ds.Nodes[i].Nodes.Add(dt_tg.Rows[j]["HOTEN"].ToString());
                }
            }
            tv_ds.EndUpdate();
        }
        public void ttchiso()
        {
            int tsnv = 0;
            int tsg = 0;
            for (int i = 0; i < dgv_ht.Rows.Count - 1; i++)
            {
                tsg += Convert.ToInt32(dgv_ht.Rows[i].Cells["SOGIOLAMVIEC"].Value);
                tsnv++;
            }
            txt_sogtg.Text = tsg.ToString();
            txt_tsnvtg.Text = tsnv.ToString();
        }

        private void txt_tsnvtg_TextChanged(object sender, EventArgs e)
        {

        }
        public void buoc_cb_mada()
        {
            da = new SqlDataAdapter(String.Format("SELECT * from DUAN"), kn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            this.cbb_mada.DataSource = dt;
            this.cbb_mada.DisplayMember = "MADA";
            this.cbb_mada.ValueMember = "MADA";
        }

        public void buoctenda()
        {
            da = new SqlDataAdapter(String.Format("select * from DUAN" + " where MADA = N'{0}'", this.cbb_mada.SelectedValue), kn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txt_tenda.DataBindings.Clear();
            txt_tenda.DataBindings.Add("Text", dt, "TENDA");
        }
        //public void buoctennv()
        //{
        //    da = new SqlDataAdapter(String.Format("SELECT * FROM NHANVIEN" + "Where TENNV", this.cbb_tennv.SelectedValue), kn);
        //    dt = new DataTable();
        //    dt.Clear();
        //    da.Fill(dt);
        //    cbb_tennv.DataBindings.Clear();
        //    cbb_tennv.DataBindings.Add("Text", dt, "TENNV");
        //}
        public void buoc_cb_tennv()
        {
            da = new SqlDataAdapter(String.Format("SELECT MANV, HODEM, TENNV, HODEM+TENNV AS HOTEN FROM NHANVIEN"), kn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            this.cbb_tennv.DataSource = dt;
            this.cbb_tennv.DisplayMember = "TENNV";
            this.cbb_tennv.ValueMember = "TENNV";
        }

        private void tv_ds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node  in tv_ds.Nodes)
            {
                if (node.IsSelected)
                {
                    da = new SqlDataAdapter(String.Format("Select NHANVIEN.MANV, HODEM, TENNV, (HODEM+' '+TENNV) AS HOTEN, SOGIOLAMVIEC " + " FROM NHANVIEN,THAMGIA WHERE NHANVIEN.MANV = THAMGIA.MANV AND TENDA = N'{0}'", node.Text), kn);
                    dt = new DataTable(); dt.Clear();
                    da.Fill(dt);
                    dgv_ht.DataSource = dt;
                }
            }
            ttchiso();
        }

        private void txt_tenda_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void luu()
        {
            string chuoi_them = String.Format("INSERT INTO THAMGIA VALUES(N'{0}',N'{1}',N'{2}',{3}", cbb_mada.Text, this.cbb_tennv.SelectedValue, this.txt_tenda.Text, txt_sogtg.Text);
            SqlCommand cmd_them = new SqlCommand(chuoi_them, kn);
            cmd_them.Connection.Open();
            try
            {
                cmd_them.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");

            }
            cmd_them.Connection.Close();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            luu();
            buoc_cb_mada();
            this.txt_sogtg.Text = "";
            txt_tsg.Clear();
            cbb_mada.Text = "";
            this.cbb_tennv.Text = "";
            this.txt_tenda.Text = "";
        }

        private void dgv_ht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
