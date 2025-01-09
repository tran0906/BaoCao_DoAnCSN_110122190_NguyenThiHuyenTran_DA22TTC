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
    public partial class frm_MuaHang : Form
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
                using (SqlCommand command = new SqlCommand("select * from MUA", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvmuahang.DataSource = table;
                    SetupDataGridViewFullScreen();



                    dgvmuahang.Columns["MADT"].HeaderText = "MÃ ĐIỆN THOẠI";
                    dgvmuahang.Columns["MAKH"].HeaderText = "MÃ KHÁCH HÀNG";
                    dgvmuahang.Columns["NGAYMUA"].HeaderText = "NGÀY MUA";
                    dgvmuahang.Columns["SONAMBH"].HeaderText = "SỐ NĂM BẢO HÀNH";
                    dgvmuahang.Columns["GHICHU"].HeaderText = "GHI CHÚ";
                    dgvmuahang.Columns["SOLG"].HeaderText = "SỐ LƯỢNG";



                }
            }
        }




        private void LoadMaDienThoai()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT MADT FROM DIENTHOAI", connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        cbmadt.Items.Clear(); // Xóa các mục cũ trong ComboBox
                        if (reader.HasRows) // Kiểm tra xem có dữ liệu hay không
                        {
                            while (reader.Read())
                            {
                                cbmadt.Items.Add(reader["MADT"].ToString()); // Thêm mã điện thoại vào ComboBox
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không có mã điện thoại nào trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã điện thoại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public frm_MuaHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_MuaHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            LoadMaDienThoai();
            LoadMaKhachhang();


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




        private void dgvmuahang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvmuahang.CurrentRow.Index;

            cbmadt.Text = dgvmuahang.Rows[i].Cells[0].Value.ToString();
            cbmakh.Text = dgvmuahang.Rows[i].Cells[1].Value.ToString();
            cbbh.Text = dgvmuahang.Rows[i].Cells[2].Value.ToString();
            txtngaymua.Text = dgvmuahang.Rows[i].Cells[3].Value.ToString();
             
            txtghichu.Text = dgvmuahang.Rows[i].Cells[4].Value.ToString();
            txtsoluong.Text = dgvmuahang.Rows[i].Cells[5].Value.ToString();

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            frm_DienThoai frm = new frm_DienThoai();
            frm.ShowDialog();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the mandatory fields are empty.
                if (string.IsNullOrEmpty(cbmadt.Text) || string.IsNullOrEmpty(cbmakh.Text) || string.IsNullOrEmpty(txtngaymua.Text) || string.IsNullOrEmpty(cbbh.Text) || string.IsNullOrEmpty(txtsoluong.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if MADT already exists (like frm_CauHinh)
                string checkQuery = "SELECT COUNT(*) FROM MUA WHERE MADT = @MADT";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@MADT", cbmadt.Text);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã mua này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit if the code exists
                    }
                }

                // Ask the user for confirmation (like in other forms)
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Insert into database using parameterized query
                    string insertQuery = @"INSERT INTO MUA (MADT, MAKH, NGAYMUA, SONAMBH, GHICHU, SOLG)
                                  VALUES (@MADT, @MAKH, @NGAYMUA, @SONAMBH, @GHICHU, @SOLG)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@MADT", cbmadt.Text);
                        insertCommand.Parameters.AddWithValue("@MAKH", cbmakh.Text);

                        DateTime ngaymuaDate;
                        if (DateTime.TryParse(txtngaymua.Text, out ngaymuaDate))
                        {
                            insertCommand.Parameters.Add("@NGAYMUA", SqlDbType.DateTime).Value = ngaymuaDate;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập một ngày mua hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        insertCommand.Parameters.AddWithValue("@SONAMBH", cbbh.Text);
                        insertCommand.Parameters.AddWithValue("@GHICHU", txtghichu.Text);
                        insertCommand.Parameters.AddWithValue("@SOLG", txtsoluong.Text);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            loaddata();
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Inform the user if cancelled
                    MessageBox.Show("Hủy thao tác thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txtngaymua.Text))
            {
                MessageBox.Show("Vui lòng chọn mã mua để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {


 

                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                commmand = connection.CreateCommand();
                commmand.CommandText = "delete from MUA where MADT = '" + cbmadt.Text + "'";
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

            if (string.IsNullOrEmpty(txtngaymua.Text))
            {
                MessageBox.Show("Vui lòng chọn mã mua để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nầy không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh sửa nếu người dùng chọn Yes
                commmand = connection.CreateCommand();
                commmand.CommandText = "update MUA set MAKH = '" + cbmakh.Text + "', NGAYMUA = '" + txtngaymua.Text + "', SONAMBH = '" + cbbh.Text + "', GHICHU = '" + txtghichu.Text + "', SOLG = '" + txtsoluong.Text + "' where MADT = '" + cbmadt.Text + "'";
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
            cbmadt.Text = "";
            cbmakh.Text = "";
            txtngaymua.Text = "";
            cbbh.Text = "";
            txtghichu.Text = "";
            txtsoluong.Text = "";

        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvmuahang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvmuahang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvmuahang.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvmuahang.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvmuahang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvmuahang.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvmuahang.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvmuahang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvmuahang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvmuahang.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvmuahang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvmuahang.ReadOnly = true;

            // Đặt border
            dgvmuahang.BorderStyle = BorderStyle.Fixed3D;
            dgvmuahang.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvmuahang.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvmuahang.AllowUserToResizeColumns = false;
            dgvmuahang.AllowUserToResizeRows = false;
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

 