using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_DienThoai
{
    public partial class frm_DiaChiGiaoHang : Form
    {


        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.;Initial Catalog=quanlydienthoai1;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from DIACHIGIAOHANG", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvdiachigiaohang.DataSource = table;
                    SetupDataGridViewFullScreen();


                    dgvdiachigiaohang.Columns["MADIACHI"].HeaderText = "MÃ ĐỊA CHỈ";
                    dgvdiachigiaohang.Columns["MAKH"].HeaderText = "MÃ KHÁCH HÀNG";
                    dgvdiachigiaohang.Columns["DIACHICUTHE"].HeaderText = "ĐỊA CHỈ CỤ THỂ";
                    dgvdiachigiaohang.Columns["TENTINH"].HeaderText = "TÊN TỈNH";
                    dgvdiachigiaohang.Columns["TENHUYEN"].HeaderText = "TÊN HUYỆN";
                    dgvdiachigiaohang.Columns["SDTNGUOINHAN"].HeaderText = "SDT NGƯỜI NHẬN";
                    dgvdiachigiaohang.Columns["TENNGUOINHAN"].HeaderText = "TÊN NGƯỜI NHẬN";




                }
            }
        }


        public frm_DiaChiGiaoHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        private void LoadMaKhachhang()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MAKH FROM KHACHHANG", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cbmakh.Items.Clear(); // Xóa các mục cũ trong ComboBox
                    while (reader.Read())
                    {
                        cbmakh.Items.Add(reader["MAKH"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }


        private void frm_DiaChiGiaoHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            LoadMaKhachhang();
        }

        private void dgvdiachigiaohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvdiachigiaohang.CurrentRow.Index;

            txtdiachi.Text = dgvdiachigiaohang.Rows[i].Cells[0].Value.ToString();
            cbmakh.Text = dgvdiachigiaohang.Rows[i].Cells[1].Value.ToString();
            txtdiachicuthe.Text = dgvdiachigiaohang.Rows[i].Cells[2].Value.ToString();
            txttentinh.Text = dgvdiachigiaohang.Rows[i].Cells[3].Value.ToString();
            txttenhuyen.Text = dgvdiachigiaohang.Rows[i].Cells[4].Value.ToString();
            txtsdt.Text = dgvdiachigiaohang.Rows[i].Cells[5].Value.ToString();
            txttennguoinhan.Text = dgvdiachigiaohang.Rows[i].Cells[6].Value.ToString();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng chọn mã địa chỉ giao hàng để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // Kiểm tra mã nhà sản xuất đã tồn tại hay chưa
            string checkQuery = "SELECT COUNT(*) FROM DIACHIGIAOHANG WHERE MADIACHI = @MADIACHI";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@MADIACHI", txtdiachi.Text);

                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã địa chỉ giao hàng này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thao tác thêm nếu mã đã tồn tại
                }
            }





            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh xóa nếu người dùng chọn Yes

                command = connection.CreateCommand();
                command.CommandText = "insert into DIACHIGIAOHANG values ('" + txtdiachi.Text + "', '" + cbmakh.Text + "', '" + txtdiachicuthe.Text + "', '" + txttentinh.Text + "', '" + txttenhuyen.Text + "', '" + txtsdt.Text + "', '" + txttennguoinhan.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                // Thông báo thành công
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thông báo nếu người dùng chọn No
                MessageBox.Show("Hủy thao tác thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng chọn mã địa chỉ giao hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                command = connection.CreateCommand();
                command.CommandText = "delete from DIACHIGIAOHANG where MADIACHI = '" + txtdiachi.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
                // Thông báo thành công
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thông báo nếu người dùng chọn No
                MessageBox.Show("Hủy thao tác xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng chọn mã địa chỉ giao hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh sửa nếu người dùng chọn Yes
                command = connection.CreateCommand();
                command.CommandText = "Update DIACHIGIAOHANG set MAKH = '" + cbmakh.Text + "', DIACHICUTHE = '" + txtdiachicuthe.Text + "', TENTINH = '" + txttentinh.Text + "', TENHUYEN = '" + txttenhuyen.Text + "', SDTNGUOINHAN = '" + txtsdt.Text + "', TENNGUOINHAN = '" + txttennguoinhan.Text + "' where MADIACHI = '" + txtdiachi.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
                // Thông báo thành công
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thông báo nếu người dùng chọn No
                MessageBox.Show("Hủy thao tác sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnkhoitao_Click(object sender, EventArgs e)
        {
            txtdiachi.Text = "";
            cbmakh.Text = "";
            txtdiachicuthe.Text = "";
            txttentinh.Text = "";
            txttenhuyen.Text = "";
            txtsdt.Text = "";
            txttennguoinhan.Text = "";

        }



        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvdiachigiaohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvdiachigiaohang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvdiachigiaohang.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvdiachigiaohang.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvdiachigiaohang.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvdiachigiaohang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvdiachigiaohang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvdiachigiaohang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvdiachigiaohang.ReadOnly = true;

            // Đặt border
            dgvdiachigiaohang.BorderStyle = BorderStyle.Fixed3D;
            dgvdiachigiaohang.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvdiachigiaohang.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvdiachigiaohang.AllowUserToResizeColumns = false;
            dgvdiachigiaohang.AllowUserToResizeRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            frm.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 