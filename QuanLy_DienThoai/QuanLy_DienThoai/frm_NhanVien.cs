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
using System.Windows.Input;

namespace QuanLy_DienThoai
{
    public partial class frm_NhanVien : Form
    {


        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.;Initial Catalog=quanlydienthoai1;Integrated Security=True;TrustServerCertificate=True";


        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlCommand commmand;

        void loaddata()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from NHANVIEN", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvnhanvien.DataSource = table;
                    SetupDataGridViewFullScreen();



                    dgvnhanvien.Columns["MANV"].HeaderText = "MÃ NHÂN VIÊN";
                    
                    dgvnhanvien.Columns["HOVATENNV"].HeaderText = "HỌ VÀ TÊN";
                    dgvnhanvien.Columns["GIOITINHNV"].HeaderText = "GIỚI TÍNH";
                    dgvnhanvien.Columns["NGAYSINHNV"].HeaderText = "NGÀY SINH";
                    dgvnhanvien.Columns["DIACHINV"].HeaderText = "ĐỊA CHỈ";
                    dgvnhanvien.Columns["SDTNV"].HeaderText = "SỐ ĐIỆN THOẠI";
                    dgvnhanvien.Columns["EMAILNV"].HeaderText = "EMAIL ";




                }
            }
        }

        //private void LoadMaDienThoai()
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(str))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand("SELECT MADT FROM DIENTHOAI", connection))
        //            {
        //                SqlDataReader reader = command.ExecuteReader();
        //                cbmadt.Items.Clear(); // Xóa các mục cũ trong ComboBox
        //                if (reader.HasRows) // Kiểm tra xem có dữ liệu hay không
        //                {
        //                    while (reader.Read())
        //                    {
        //                        cbmadt.Items.Add(reader["MADT"].ToString()); // Thêm mã điện thoại vào ComboBox
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Không có mã điện thoại nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải mã điện thoại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        public frm_NhanVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            //LoadMaDienThoai();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvnhanvien.CurrentRow.Index;

            txtmanv.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString();
            
            txthoten.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
            cbgioitinh.Text = dgvnhanvien.Rows[i].Cells[2].Value.ToString();
            txtngaysinh.Text = dgvnhanvien.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString();
            txtsdt.Text = dgvnhanvien.Rows[i].Cells[5].Value.ToString();
            txtemail.Text = dgvnhanvien.Rows[i].Cells[6].Value.ToString();

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            frm_DienThoai frm = new frm_DienThoai();
            frm.ShowDialog();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã nhà sản xuất đã tồn tại hay chưa
            string checkQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MANV";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@MANV", txtmanv.Text);

                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Mã nhà nhân viên này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng thao tác thêm nếu mã đã tồn tại
                }
            }

             


            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                command = connection.CreateCommand();
                command.CommandText = "insert into NHANVIEN values ('" + txtmanv.Text + "', '" + txthoten.Text + "','" + cbgioitinh.Text + "', '" + txtngaysinh.Text + "', '" + txtdiachi.Text + "', '" + txtsdt.Text + "', '" + txtemail.Text + "')";
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

       
            if (string.IsNullOrEmpty(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // 1. Xóa các bản ghi trong bảng MUA liên quan đến nhân viên
                string sqlDeleteMua = @"DELETE FROM MUA WHERE MADT IN (SELECT MADT FROM DIENTHOAI WHERE MANV = @MaNhanVien)";
                using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, connection))
                {
                    cmdDeleteMua.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text);
                    cmdDeleteMua.ExecuteNonQuery();
                }

                // 2. Xóa các bản ghi liên quan trong bảng DIENTHOAI
                string sqlDeleteDienThoai = "DELETE FROM DIENTHOAI WHERE MANV = @MaNhanVien";
                using (SqlCommand cmdDeleteDienThoai = new SqlCommand(sqlDeleteDienThoai, connection))
                {
                    cmdDeleteDienThoai.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text);
                    cmdDeleteDienThoai.ExecuteNonQuery();
                }


                // 3. Thực hiện lệnh xóa trong bảng NHANVIEN
                string sqlDeleteNhanVien = "DELETE FROM NHANVIEN WHERE MANV = @MaNhanVien";
                using (SqlCommand cmdDeleteNhanVien = new SqlCommand(sqlDeleteNhanVien, connection))
                {
                    cmdDeleteNhanVien.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text);
                    cmdDeleteNhanVien.ExecuteNonQuery();
                }

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

            if (string.IsNullOrEmpty(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh sửa nếu người dùng chọn Yes
                command = connection.CreateCommand();
                command.CommandText = "Update NHANVIEN set  HOVATENNV ='" + txthoten.Text + "', GIOITINHNV='" + cbgioitinh.Text + "', NGAYSINHNV='" + txtngaysinh.Text + "', DIACHINV='" + txtdiachi.Text + "', SDTNV='" + txtsdt.Text + "', EMAILNV = '" + txtemail.Text + "' where MANV='" + txtmanv.Text + "'";
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



            txtmanv.Text = "";
           
            txthoten.Text = "";
            cbgioitinh.Text = "";
            txtngaysinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
        }
            

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvnhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvnhanvien.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvnhanvien.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvnhanvien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvnhanvien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvnhanvien.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvnhanvien.RowsDefaultCellStyle.BackColor = Color.White;
            dgvnhanvien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvnhanvien.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvnhanvien.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvnhanvien.ReadOnly = true;

            // Đặt border
            dgvnhanvien.BorderStyle = BorderStyle.Fixed3D;
            dgvnhanvien.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvnhanvien.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvnhanvien.AllowUserToResizeColumns = false;
            dgvnhanvien.AllowUserToResizeRows = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

