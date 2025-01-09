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
    public partial class frm_KhachHang : Form
    {



        SqlConnection connection;
        SqlCommand commmand;
        string str = @"Data Source=.;Initial Catalog=quanlydienthoai1;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from KHACHHANG", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvkhachhang.DataSource = table;
                    SetupDataGridViewFullScreen();


                    dgvkhachhang.Columns["MAKH"].HeaderText = "MÃ KHÁCH HÀNG";
                    dgvkhachhang.Columns["HOTENKH"].HeaderText = "HỌ VÀ TÊN";
                    dgvkhachhang.Columns["NGAYSINH"].HeaderText = "NGÀY SINH";
                    dgvkhachhang.Columns["CMND"].HeaderText = "CMND";
                    dgvkhachhang.Columns["EMAIL"].HeaderText = "EMAIL";
                    dgvkhachhang.Columns["DIACHI"].HeaderText = "ĐỊA CHỈ";
                    
                    
                }
            }
        }


        public frm_KhachHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvkhachhang.CurrentRow.Index;

            txtmakh.Text = dgvkhachhang.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvkhachhang.Rows[i].Cells[1].Value.ToString();
            txtngaysinh.Text = dgvkhachhang.Rows[i].Cells[2].Value.ToString();
            txtcmnd.Text = dgvkhachhang.Rows[i].Cells[3].Value.ToString();
            txtemail.Text = dgvkhachhang.Rows[i].Cells[4].Value.ToString();
            txtdiachi.Text = dgvkhachhang.Rows[i].Cells[5].Value.ToString();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtmakh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra mã nhà sản xuất đã tồn tại hay chưa
            string checkQuery = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = @MAKH";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@MAKH", txtmakh.Text);

                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã khách hàng này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thao tác thêm nếu mã đã tồn tại
                }
            }




            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                commmand = connection.CreateCommand();
                commmand.CommandText = "insert into KHACHHANG values ('" + txtmakh.Text + "', '" + txthoten.Text + "', '" + txtngaysinh.Text + "', '" + txtcmnd.Text + "', '" + txtemail.Text + "', '" + txtdiachi.Text + "')";
                commmand.ExecuteNonQuery();
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

            if (string.IsNullOrEmpty(txtmakh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {



                // Xóa các bản ghi liên quan trong bảng MUA
                commmand = connection.CreateCommand();
                commmand.CommandText = "DELETE FROM MUA WHERE MAKH = '" + txtmakh.Text + "'";
                commmand.ExecuteNonQuery();



                // Xóa các bản ghi liên quan trong bảng DIACHIGIAOHANG
                commmand = connection.CreateCommand();
                commmand.CommandText = "DELETE FROM DIACHIGIAOHANG WHERE MAKH = '" + txtmakh.Text + "'";
                commmand.ExecuteNonQuery();





                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                commmand = connection.CreateCommand();
                commmand.CommandText = "delete from KHACHHANG where MAKH = '" + txtmakh.Text + "'";
                commmand.ExecuteNonQuery();
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

            if (string.IsNullOrEmpty(txtmakh.Text))
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh sửa nếu người dùng chọn Yes
                commmand = connection.CreateCommand();
                commmand.CommandText = "Update KHACHHANG set HOTENKH ='" + txthoten.Text + "', NGAYSINH='" + txtngaysinh.Text + "', CMND='" + txtcmnd.Text + "', EMAIL='" + txtemail.Text + "', DIACHI='" + txtdiachi.Text + "' where MAKH='" + txtmakh.Text + "'";
                commmand.ExecuteNonQuery();
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

            txtmakh.Text = "";
            txthoten.Text = "";
            txtngaysinh.Text = "";
            txtcmnd.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            
        }


        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvkhachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvkhachhang.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvkhachhang.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvkhachhang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvkhachhang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvkhachhang.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvkhachhang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvkhachhang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvkhachhang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvkhachhang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvkhachhang.ReadOnly = true;

            // Đặt border
            dgvkhachhang.BorderStyle = BorderStyle.Fixed3D;
            dgvkhachhang.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvkhachhang.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvkhachhang.AllowUserToResizeColumns = false;
            dgvkhachhang.AllowUserToResizeRows = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
