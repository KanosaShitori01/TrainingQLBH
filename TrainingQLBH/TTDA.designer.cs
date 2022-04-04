
namespace TrainingQLBH
{
    partial class TTDA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tv_ds = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ht = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.cbb_tennv = new System.Windows.Forms.ComboBox();
            this.cbb_mada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sogtg = new System.Windows.Forms.TextBox();
            this.txt_tenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tsg = new System.Windows.Forms.TextBox();
            this.txt_tsnvtg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_ds
            // 
            this.tv_ds.Location = new System.Drawing.Point(15, 36);
            this.tv_ds.Name = "tv_ds";
            this.tv_ds.Size = new System.Drawing.Size(196, 495);
            this.tv_ds.TabIndex = 0;
            this.tv_ds.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_ds_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng sô nhân viên tham gia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_ds);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 549);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên dự án";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ht);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_tsg);
            this.groupBox2.Controls.Add(this.txt_tsnvtg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 549);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dự án";
            // 
            // dgv_ht
            // 
            this.dgv_ht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ht.Location = new System.Drawing.Point(27, 36);
            this.dgv_ht.Name = "dgv_ht";
            this.dgv_ht.RowHeadersWidth = 62;
            this.dgv_ht.RowTemplate.Height = 28;
            this.dgv_ht.Size = new System.Drawing.Size(830, 216);
            this.dgv_ht.TabIndex = 6;
            this.dgv_ht.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ht_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_thoat);
            this.groupBox3.Controls.Add(this.bt_luu);
            this.groupBox3.Controls.Add(this.cbb_tennv);
            this.groupBox3.Controls.Add(this.cbb_mada);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_sogtg);
            this.groupBox3.Controls.Add(this.txt_tenda);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhân viên tham gia dự án";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(719, 120);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(93, 36);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Location = new System.Drawing.Point(719, 63);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(93, 40);
            this.bt_luu.TabIndex = 5;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // cbb_tennv
            // 
            this.cbb_tennv.FormattingEnabled = true;
            this.cbb_tennv.Location = new System.Drawing.Point(186, 117);
            this.cbb_tennv.Name = "cbb_tennv";
            this.cbb_tennv.Size = new System.Drawing.Size(177, 33);
            this.cbb_tennv.TabIndex = 4;
            // 
            // cbb_mada
            // 
            this.cbb_mada.FormattingEnabled = true;
            this.cbb_mada.Location = new System.Drawing.Point(186, 35);
            this.cbb_mada.Name = "cbb_mada";
            this.cbb_mada.Size = new System.Drawing.Size(85, 33);
            this.cbb_mada.TabIndex = 4;
            this.cbb_mada.SelectedIndexChanged += new System.EventHandler(this.cbb_mada_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số giờ tham gia";
            // 
            // txt_sogtg
            // 
            this.txt_sogtg.Location = new System.Drawing.Point(186, 164);
            this.txt_sogtg.Name = "txt_sogtg";
            this.txt_sogtg.Size = new System.Drawing.Size(177, 30);
            this.txt_sogtg.TabIndex = 3;
            // 
            // txt_tenda
            // 
            this.txt_tenda.Location = new System.Drawing.Point(186, 76);
            this.txt_tenda.Name = "txt_tenda";
            this.txt_tenda.Size = new System.Drawing.Size(271, 30);
            this.txt_tenda.TabIndex = 3;
            this.txt_tenda.TextChanged += new System.EventHandler(this.txt_tenda_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dự án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã dự án";
            // 
            // txt_tsg
            // 
            this.txt_tsg.Location = new System.Drawing.Point(607, 271);
            this.txt_tsg.Name = "txt_tsg";
            this.txt_tsg.Size = new System.Drawing.Size(100, 30);
            this.txt_tsg.TabIndex = 3;
            // 
            // txt_tsnvtg
            // 
            this.txt_tsnvtg.Location = new System.Drawing.Point(323, 266);
            this.txt_tsnvtg.Name = "txt_tsnvtg";
            this.txt_tsnvtg.Size = new System.Drawing.Size(100, 30);
            this.txt_tsnvtg.TabIndex = 3;
            this.txt_tsnvtg.TextChanged += new System.EventHandler(this.txt_tsnvtg_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng số giờ";
            // 
            // meomew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "meomew";
            this.Text = "meomew";
            this.Load += new System.EventHandler(this.meomew_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.ComboBox cbb_tennv;
        private System.Windows.Forms.ComboBox cbb_mada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sogtg;
        private System.Windows.Forms.TextBox txt_tenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tsg;
        private System.Windows.Forms.TextBox txt_tsnvtg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ht;
    }
}