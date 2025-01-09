namespace QuanLy_DienThoai
{
    partial class frm_NhaSanXuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbsdt = new System.Windows.Forms.ComboBox();
            this.cbdiachi = new System.Windows.Forms.ComboBox();
            this.cbemail = new System.Windows.Forms.ComboBox();
            this.txtmansx = new System.Windows.Forms.TextBox();
            this.btnkhoitao = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbtennsx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvnhasanxuat = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhasanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(780, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM NHÀ SẢN XUẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.cbsdt);
            this.groupBox1.Controls.Add(this.cbdiachi);
            this.groupBox1.Controls.Add(this.cbemail);
            this.groupBox1.Controls.Add(this.txtmansx);
            this.groupBox1.Controls.Add(this.btnkhoitao);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.cbtennsx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(276, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1295, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin nhà sản xuất";
            // 
            // cbsdt
            // 
            this.cbsdt.FormattingEnabled = true;
            this.cbsdt.Items.AddRange(new object[] {
            " 1-800-692-7753",
            "+82-2-2255-0114",
            "+86-400-100-5678",
            "+86-400-166-6888",
            "+86-400-822-9999",
            "+358-10-505-5000",
            "+81-3-6748-2111"});
            this.cbsdt.Location = new System.Drawing.Point(859, 94);
            this.cbsdt.Name = "cbsdt";
            this.cbsdt.Size = new System.Drawing.Size(219, 33);
            this.cbsdt.TabIndex = 51;
            // 
            // cbdiachi
            // 
            this.cbdiachi.FormattingEnabled = true;
            this.cbdiachi.Items.AddRange(new object[] {
            "Apple Park, 1 Apple Park Way, Cupertino, CA 95014, USA",
            "Samsung Town, 129 Samsung-ro, Yeongtong-gu, Suwon-si, Gyeonggi-do, South Korea",
            "Xiaomi Science and Technology Park, Haidian District, Beijing, China",
            "OPPO Industrial Park, No. 18 Haibin Road, Wusha, Chang\'an, Dongguan, Guangdong, C" +
                "hina",
            "Huawei Base, Bantian, Longgang District, Shenzhen, Guangdong, China",
            "1-7-1 Konan, Minato-ku, Tokyo, 108-0075, Japan"});
            this.cbdiachi.Location = new System.Drawing.Point(441, 141);
            this.cbdiachi.Name = "cbdiachi";
            this.cbdiachi.Size = new System.Drawing.Size(637, 33);
            this.cbdiachi.TabIndex = 50;
            // 
            // cbemail
            // 
            this.cbemail.FormattingEnabled = true;
            this.cbemail.Items.AddRange(new object[] {
            "support@apple.com",
            "support@samsung.com",
            "service.global@xiaomi.com",
            "support@oppo.com",
            "support@huawei.com",
            "contact@nokia.com",
            "support@sony.com"});
            this.cbemail.Location = new System.Drawing.Point(859, 45);
            this.cbemail.Name = "cbemail";
            this.cbemail.Size = new System.Drawing.Size(219, 33);
            this.cbemail.TabIndex = 49;
            // 
            // txtmansx
            // 
            this.txtmansx.Location = new System.Drawing.Point(441, 48);
            this.txtmansx.Name = "txtmansx";
            this.txtmansx.Size = new System.Drawing.Size(219, 30);
            this.txtmansx.TabIndex = 48;
            // 
            // btnkhoitao
            // 
            this.btnkhoitao.Image = global::QuanLy_DienThoai.Properties.Resources.industrial;
            this.btnkhoitao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhoitao.Location = new System.Drawing.Point(801, 212);
            this.btnkhoitao.Name = "btnkhoitao";
            this.btnkhoitao.Size = new System.Drawing.Size(143, 45);
            this.btnkhoitao.TabIndex = 47;
            this.btnkhoitao.Text = "Khởi tạo";
            this.btnkhoitao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhoitao.UseVisualStyleBackColor = true;
            this.btnkhoitao.Click += new System.EventHandler(this.btnkhoitao_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QuanLy_DienThoai.Properties.Resources.customer_support;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(657, 214);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(121, 45);
            this.btnsua.TabIndex = 46;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QuanLy_DienThoai.Properties.Resources.trash__1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(502, 214);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(121, 45);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QuanLy_DienThoai.Properties.Resources.import1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(344, 212);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(116, 47);
            this.btnthem.TabIndex = 44;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbtennsx
            // 
            this.cbtennsx.FormattingEnabled = true;
            this.cbtennsx.Items.AddRange(new object[] {
            " Apple ",
            "Samsung",
            "Xiaomi ",
            "Oppo",
            "Trực tiếp",
            "Huawei",
            "Nokia",
            "Sony"});
            this.cbtennsx.Location = new System.Drawing.Point(441, 94);
            this.cbtennsx.Name = "cbtennsx";
            this.cbtennsx.Size = new System.Drawing.Size(219, 33);
            this.cbtennsx.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 149);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà sản xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvnhasanxuat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1873, 449);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà sản xuất";
            // 
            // dgvnhasanxuat
            // 
            this.dgvnhasanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhasanxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvnhasanxuat.Location = new System.Drawing.Point(3, 29);
            this.dgvnhasanxuat.Name = "dgvnhasanxuat";
            this.dgvnhasanxuat.RowHeadersWidth = 51;
            this.dgvnhasanxuat.RowTemplate.Height = 24;
            this.dgvnhasanxuat.Size = new System.Drawing.Size(1867, 417);
            this.dgvnhasanxuat.TabIndex = 0;
            this.dgvnhasanxuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhasanxuat_CellContentClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::QuanLy_DienThoai.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(971, 213);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(135, 45);
            this.btnthoat.TabIndex = 76;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frm_NhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 785);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_NhaSanXuat";
            this.Text = "frm_NhaSanXuat";
            this.Load += new System.EventHandler(this.frm_NhaSanXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhasanxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvnhasanxuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtennsx;
        private System.Windows.Forms.Button btnkhoitao;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmansx;
        private System.Windows.Forms.ComboBox cbemail;
        private System.Windows.Forms.ComboBox cbdiachi;
        private System.Windows.Forms.ComboBox cbsdt;
        private System.Windows.Forms.Button btnthoat;
    }
}