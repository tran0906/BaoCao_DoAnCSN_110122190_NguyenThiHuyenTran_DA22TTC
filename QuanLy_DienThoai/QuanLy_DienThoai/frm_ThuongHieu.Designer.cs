namespace QuanLy_DienThoai
{
    partial class frm_ThuongHieu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbweb = new System.Windows.Forms.ComboBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.cbtenthuonghieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbquocgia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvthuonghieu = new System.Windows.Forms.DataGridView();
            this.btnkhoitao = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuonghieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.cbweb);
            this.groupBox1.Controls.Add(this.txtmath);
            this.groupBox1.Controls.Add(this.cbtenthuonghieu);
            this.groupBox1.Controls.Add(this.btnkhoitao);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbquocgia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(265, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin thương hiệu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbweb
            // 
            this.cbweb.FormattingEnabled = true;
            this.cbweb.Items.AddRange(new object[] {
            " apple.com",
            "samsung.com",
            "mi.com",
            "oppo.com",
            "huawei.com",
            "nokia.com",
            "sony.com"});
            this.cbweb.Location = new System.Drawing.Point(303, 169);
            this.cbweb.Name = "cbweb";
            this.cbweb.Size = new System.Drawing.Size(654, 33);
            this.cbweb.TabIndex = 55;
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(303, 65);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(253, 30);
            this.txtmath.TabIndex = 54;
            // 
            // cbtenthuonghieu
            // 
            this.cbtenthuonghieu.FormattingEnabled = true;
            this.cbtenthuonghieu.Items.AddRange(new object[] {
            " Apple ",
            "Samsung",
            "Xiaomi ",
            "Oppo",
            "Trực tiếp",
            "Huawei",
            "Nokia",
            "Sony"});
            this.cbtenthuonghieu.Location = new System.Drawing.Point(303, 119);
            this.cbtenthuonghieu.Name = "cbtenthuonghieu";
            this.cbtenthuonghieu.Size = new System.Drawing.Size(253, 33);
            this.cbtenthuonghieu.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Website ";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(716, 65);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(238, 30);
            this.txtmota.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mô tả";
            // 
            // cbquocgia
            // 
            this.cbquocgia.FormattingEnabled = true;
            this.cbquocgia.Items.AddRange(new object[] {
            "Việt Nam",
            "Hoa Kỳ ",
            "Trung Quốc ",
            "Hàn Quốc ",
            "Nhật Bản ",
            "Đài Loan ",
            "Singapore ",
            "Canada ",
            "Pháp "});
            this.cbquocgia.Location = new System.Drawing.Point(716, 121);
            this.cbquocgia.Name = "cbquocgia";
            this.cbquocgia.Size = new System.Drawing.Size(241, 33);
            this.cbquocgia.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quốc gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên thương hiệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thương hiệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM THƯƠNG HIỆU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvthuonghieu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1868, 470);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thương hiệu";
            // 
            // dgvthuonghieu
            // 
            this.dgvthuonghieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthuonghieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvthuonghieu.Location = new System.Drawing.Point(3, 41);
            this.dgvthuonghieu.Name = "dgvthuonghieu";
            this.dgvthuonghieu.RowHeadersWidth = 51;
            this.dgvthuonghieu.RowTemplate.Height = 24;
            this.dgvthuonghieu.Size = new System.Drawing.Size(1862, 426);
            this.dgvthuonghieu.TabIndex = 0;
            this.dgvthuonghieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthuonghieu_CellContentClick);
            // 
            // btnkhoitao
            // 
            this.btnkhoitao.Image = global::QuanLy_DienThoai.Properties.Resources.industrial;
            this.btnkhoitao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhoitao.Location = new System.Drawing.Point(706, 245);
            this.btnkhoitao.Name = "btnkhoitao";
            this.btnkhoitao.Size = new System.Drawing.Size(130, 45);
            this.btnkhoitao.TabIndex = 52;
            this.btnkhoitao.Text = "Khởi tạo";
            this.btnkhoitao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhoitao.UseVisualStyleBackColor = true;
            this.btnkhoitao.Click += new System.EventHandler(this.btnkhoitao_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QuanLy_DienThoai.Properties.Resources.customer_support;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(562, 247);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(121, 45);
            this.btnsua.TabIndex = 51;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QuanLy_DienThoai.Properties.Resources.trash__1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(407, 247);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(121, 45);
            this.btnxoa.TabIndex = 50;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QuanLy_DienThoai.Properties.Resources.import1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(249, 245);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(116, 47);
            this.btnthem.TabIndex = 49;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::QuanLy_DienThoai.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(862, 245);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(135, 45);
            this.btnthoat.TabIndex = 76;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frm_ThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 892);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ThuongHieu";
            this.Text = "frm_ThuongHieu";
            this.Load += new System.EventHandler(this.frm_ThuongHieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuonghieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvthuonghieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbquocgia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkhoitao;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbtenthuonghieu;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.ComboBox cbweb;
        private System.Windows.Forms.Button btnthoat;
    }
}