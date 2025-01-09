namespace QuanLy_DienThoai
{
    partial class frm_DienThoai
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtenthuonghieu = new System.Windows.Forms.ComboBox();
            this.cbbaohanh = new System.Windows.Forms.ComboBox();
            this.cbmacauhinh = new System.Windows.Forms.ComboBox();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbmansx = new System.Windows.Forms.ComboBox();
            this.cbtenth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmaquocgia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttendt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmadt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdienthoai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnnhasanxuat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnthuonghieu = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnkhoitao = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienthoai)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.cbtenthuonghieu);
            this.groupBox1.Controls.Add(this.cbbaohanh);
            this.groupBox1.Controls.Add(this.cbmacauhinh);
            this.groupBox1.Controls.Add(this.btnnhasanxuat);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnthuonghieu);
            this.groupBox1.Controls.Add(this.btnnhanvien);
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbmansx);
            this.groupBox1.Controls.Add(this.cbtenth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbmaquocgia);
            this.groupBox1.Controls.Add(this.btnkhoitao);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttendt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmadt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(172, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1387, 423);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin điện thoại";
            // 
            // cbtenthuonghieu
            // 
            this.cbtenthuonghieu.FormattingEnabled = true;
            this.cbtenthuonghieu.Items.AddRange(new object[] {
            "Apple",
            "Samsung",
            "Xiaomi",
            "Vivo",
            "Huawei",
            "Oppo",
            "Nikia",
            "Sonny"});
            this.cbtenthuonghieu.Location = new System.Drawing.Point(682, 96);
            this.cbtenthuonghieu.Name = "cbtenthuonghieu";
            this.cbtenthuonghieu.Size = new System.Drawing.Size(248, 33);
            this.cbtenthuonghieu.TabIndex = 74;
            // 
            // cbbaohanh
            // 
            this.cbbaohanh.FormattingEnabled = true;
            this.cbbaohanh.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "12 tháng",
            "18 tháng"});
            this.cbbaohanh.Location = new System.Drawing.Point(682, 246);
            this.cbbaohanh.Name = "cbbaohanh";
            this.cbbaohanh.Size = new System.Drawing.Size(248, 33);
            this.cbbaohanh.TabIndex = 73;
            // 
            // cbmacauhinh
            // 
            this.cbmacauhinh.FormattingEnabled = true;
            this.cbmacauhinh.Location = new System.Drawing.Point(187, 191);
            this.cbmacauhinh.Name = "cbmacauhinh";
            this.cbmacauhinh.Size = new System.Drawing.Size(248, 33);
            this.cbmacauhinh.TabIndex = 72;
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(187, 88);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(248, 33);
            this.cbmanv.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 25);
            this.label12.TabIndex = 66;
            this.label12.Text = "Mã nhân  viên";
            // 
            // cbmansx
            // 
            this.cbmansx.FormattingEnabled = true;
            this.cbmansx.Location = new System.Drawing.Point(187, 241);
            this.cbmansx.Name = "cbmansx";
            this.cbmansx.Size = new System.Drawing.Size(248, 33);
            this.cbmansx.TabIndex = 65;
            // 
            // cbtenth
            // 
            this.cbtenth.FormattingEnabled = true;
            this.cbtenth.Location = new System.Drawing.Point(187, 139);
            this.cbtenth.Name = "cbtenth";
            this.cbtenth.Size = new System.Drawing.Size(248, 33);
            this.cbtenth.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tên thương hiệu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 25);
            this.label11.TabIndex = 59;
            this.label11.Text = "Mã nhà sản xuất";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 57;
            this.label10.Text = "Mã cấu hình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Mã thương hiệu";
            // 
            // cbmaquocgia
            // 
            this.cbmaquocgia.FormattingEnabled = true;
            this.cbmaquocgia.Items.AddRange(new object[] {
            "Vietnam (VN)",
            "Hoa Kỳ (US)",
            "Trung Quốc (CN)",
            "Hàn Quốc (KR)",
            "Nhật Bản (JP)",
            "Đài Loan (TW)",
            "Singapore (SG)",
            "Canada (CA)",
            "Pháp (FR)"});
            this.cbmaquocgia.Location = new System.Drawing.Point(682, 194);
            this.cbmaquocgia.Name = "cbmaquocgia";
            this.cbmaquocgia.Size = new System.Drawing.Size(248, 33);
            this.cbmaquocgia.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mô tả";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(187, 312);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(743, 30);
            this.txtmota.TabIndex = 15;
            this.txtmota.TextChanged += new System.EventHandler(this.txtmota_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời hạn bảo hành";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã quốc gia";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(682, 144);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(248, 30);
            this.txtgiaban.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá bán";
            // 
            // txttendt
            // 
            this.txttendt.Location = new System.Drawing.Point(682, 38);
            this.txttendt.Name = "txttendt";
            this.txttendt.Size = new System.Drawing.Size(248, 30);
            this.txttendt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên điện thoại";
            // 
            // txtmadt
            // 
            this.txtmadt.Location = new System.Drawing.Point(187, 41);
            this.txtmadt.Name = "txtmadt";
            this.txtmadt.Size = new System.Drawing.Size(248, 30);
            this.txtmadt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã điện thoại";
            // 
            // dgvdienthoai
            // 
            this.dgvdienthoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdienthoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdienthoai.Location = new System.Drawing.Point(3, 19);
            this.dgvdienthoai.Name = "dgvdienthoai";
            this.dgvdienthoai.RowHeadersWidth = 51;
            this.dgvdienthoai.RowTemplate.Height = 24;
            this.dgvdienthoai.Size = new System.Drawing.Size(1625, 344);
            this.dgvdienthoai.TabIndex = 0;
            this.dgvdienthoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdienthoai_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "FORM ĐIỆN THOẠI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdienthoai);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1631, 366);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin điện thoại";
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::QuanLy_DienThoai.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(855, 366);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(135, 45);
            this.btnthoat.TabIndex = 75;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnnhasanxuat
            // 
            this.btnnhasanxuat.Image = global::QuanLy_DienThoai.Properties.Resources.update;
            this.btnnhasanxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhasanxuat.Location = new System.Drawing.Point(1014, 282);
            this.btnnhasanxuat.Name = "btnnhasanxuat";
            this.btnnhasanxuat.Size = new System.Drawing.Size(308, 55);
            this.btnnhasanxuat.TabIndex = 71;
            this.btnnhasanxuat.Text = "Cập nhật nhà sản xuất";
            this.btnnhasanxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhasanxuat.UseVisualStyleBackColor = true;
            this.btnnhasanxuat.Click += new System.EventHandler(this.btnnhasanxuat_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QuanLy_DienThoai.Properties.Resources.update;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1014, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 55);
            this.button3.TabIndex = 70;
            this.button3.Text = "Cập nhật mã cấu hình";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnthuonghieu
            // 
            this.btnthuonghieu.Image = global::QuanLy_DienThoai.Properties.Resources.update;
            this.btnthuonghieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthuonghieu.Location = new System.Drawing.Point(1014, 126);
            this.btnthuonghieu.Name = "btnthuonghieu";
            this.btnthuonghieu.Size = new System.Drawing.Size(308, 55);
            this.btnthuonghieu.TabIndex = 69;
            this.btnthuonghieu.Text = "Cập nhật mã thương hiệu";
            this.btnthuonghieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthuonghieu.UseVisualStyleBackColor = true;
            this.btnthuonghieu.Click += new System.EventHandler(this.btnthuonghieu_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Image = global::QuanLy_DienThoai.Properties.Resources.update;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(1014, 44);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(308, 53);
            this.btnnhanvien.TabIndex = 68;
            this.btnnhanvien.Text = "Cập nhật mã nhân viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnkhoitao
            // 
            this.btnkhoitao.Image = global::QuanLy_DienThoai.Properties.Resources.industrial;
            this.btnkhoitao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhoitao.Location = new System.Drawing.Point(699, 366);
            this.btnkhoitao.Name = "btnkhoitao";
            this.btnkhoitao.Size = new System.Drawing.Size(127, 45);
            this.btnkhoitao.TabIndex = 19;
            this.btnkhoitao.Text = "Khởi tạo";
            this.btnkhoitao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhoitao.UseVisualStyleBackColor = true;
            this.btnkhoitao.Click += new System.EventHandler(this.btnkhoitao_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QuanLy_DienThoai.Properties.Resources.customer_support;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(536, 366);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(121, 45);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QuanLy_DienThoai.Properties.Resources.trash__1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(381, 366);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(121, 45);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QuanLy_DienThoai.Properties.Resources.import1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(225, 366);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(121, 45);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frm_DienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 836);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_DienThoai";
            this.Text = "frm_DienThoai";
            this.Load += new System.EventHandler(this.frm_DienThoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdienthoai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmaquocgia;
        private System.Windows.Forms.Button btnkhoitao;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttendt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmadt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvdienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmansx;
        private System.Windows.Forms.ComboBox cbtenth;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnnhasanxuat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnthuonghieu;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.ComboBox cbmacauhinh;
        private System.Windows.Forms.ComboBox cbbaohanh;
        private System.Windows.Forms.ComboBox cbtenthuonghieu;
        private System.Windows.Forms.Button btnthoat;
    }
}