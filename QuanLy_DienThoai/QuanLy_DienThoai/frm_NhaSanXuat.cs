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
    public partial class frm_NhaSanXuat : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.;Initial Catalog=quanlydienthoai1;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlCommand commmand;

        // Hàm tải dữ liệu
        void loaddata()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM NHASANXUAT", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvnhasanxuat.DataSource = table;
                    SetupDataGridViewFullScreen();



                    dgvnhasanxuat.Columns["MANHASANXUAT"].HeaderText = "MÃ NHÀ SẢN XUẤT";
                  
                    dgvnhasanxuat.Columns["TENNHASANXUAT"].HeaderText = "TÊN NHÀ SẢN XUẤT";
                    dgvnhasanxuat.Columns["DIACHI"].HeaderText = "ĐỊA CHỈ";
                    dgvnhasanxuat.Columns["MANHASANXUAT"].HeaderText = "MÃ NHÀ SẢN XUẤT";
                    dgvnhasanxuat.Columns["SODIENTHOAI"].HeaderText = "SỐ ĐIỆN THOẠI";
                    dgvnhasanxuat.Columns["MANHASANXUAT"].HeaderText = "MÃ NHÀ SẢN XUẤT";
                    dgvnhasanxuat.Columns["EMAIL"].HeaderText = "EMAIL";








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





        public frm_NhaSanXuat()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_NhaSanXuat_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
          //  LoadMaDienThoai();

        }

        private void dgvnhasanxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvnhasanxuat.CurrentRow.Index;
            txtmansx.Text = dgvnhasanxuat.Rows[i].Cells[0].Value.ToString();
           
            cbtennsx.Text = dgvnhasanxuat.Rows[i].Cells[1].Value.ToString();
            cbdiachi.Text = dgvnhasanxuat.Rows[i].Cells[2].Value.ToString();
            cbsdt.Text = dgvnhasanxuat.Rows[i].Cells[3].Value.ToString();
            cbemail.Text = dgvnhasanxuat.Rows[i].Cells[4].Value.ToString();

        }
        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvnhasanxuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvnhasanxuat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvnhasanxuat.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvnhasanxuat.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvnhasanxuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvnhasanxuat.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvnhasanxuat.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvnhasanxuat.RowsDefaultCellStyle.BackColor = Color.White;
            dgvnhasanxuat.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvnhasanxuat.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvnhasanxuat.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvnhasanxuat.ReadOnly = true;

            // Đặt border
            dgvnhasanxuat.BorderStyle = BorderStyle.Fixed3D;
            dgvnhasanxuat.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvnhasanxuat.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvnhasanxuat.AllowUserToResizeColumns = false;
            dgvnhasanxuat.AllowUserToResizeRows = false;
        }

        //private void btncapnhat_Click(object sender, EventArgs e)
        //{
        //    frm_DienThoai frm = new frm_DienThoai();
        //    frm.ShowDialog();

        //}

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check for empty required fields (like frm_DienThoai)
                if (string.IsNullOrEmpty(txtmansx.Text) || string.IsNullOrEmpty(cbtennsx.Text) || string.IsNullOrEmpty(cbdiachi.Text) || string.IsNullOrEmpty(cbsdt.Text) || string.IsNullOrEmpty(cbemail.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Check if MANHASANXUAT already exists (like frm_CauHinh)
                string checkQuery = "SELECT COUNT(*) FROM NHASANXUAT WHERE MANHASANXUAT = @MANHASANXUAT";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@MANHASANXUAT", txtmansx.Text);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã nhà sản xuất này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit if the code exists
                    }
                }

                // Ask the user for confirmation (like frm_DienThoai and frm_CauHinh)
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Insert into database (using parameters like frm_DienThoai and frm_CauHinh)
                    string insertQuery = @"
                    INSERT INTO NHASANXUAT (MANHASANXUAT, TENNHASANXUAT, DIACHI, SODIENTHOAI, EMAIL)
                     VALUES (@MANHASANXUAT, @TENNHASANXUAT, @DIACHI, @SODIENTHOAI, @EMAIL)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@MANHASANXUAT", txtmansx.Text);
                        insertCommand.Parameters.AddWithValue("@TENNHASANXUAT", cbtennsx.Text);
                        insertCommand.Parameters.AddWithValue("@DIACHI", cbdiachi.Text);
                        insertCommand.Parameters.AddWithValue("@SODIENTHOAI", cbsdt.Text);
                        insertCommand.Parameters.AddWithValue("@EMAIL", cbemail.Text);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            loaddata();  // Reload the data
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
            if (string.IsNullOrEmpty(txtmansx.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhà sản xuất để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hỏi người dùng xác nhận trước khi xóa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {



                // 1. Xóa các bản ghi trong bảng MUA liên quan đến nhân viên
                string sqlDeleteMua = @"DELETE FROM MUA WHERE MADT IN (SELECT MADT FROM DIENTHOAI WHERE MANHASANXUAT = @MaNhaSanXuat)";
                using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, connection))
                {
                    cmdDeleteMua.Parameters.AddWithValue("@MaNhaSanXuat", txtmansx.Text);
                    cmdDeleteMua.ExecuteNonQuery();
                }


                // Xóa các bản ghi liên quan trong bảng DIENTHOAI
                commmand = connection.CreateCommand();
                commmand.CommandText = "DELETE FROM DIENTHOAI WHERE MANHASANXUAT = '" + txtmansx.Text + "'";
                commmand.ExecuteNonQuery();

                










                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM NHASANXUAT WHERE MANHASANXUAT = '" + txtmansx.Text + "'";
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
            if (string.IsNullOrEmpty(txtmansx.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhà sản xuất để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            



            if (confirmResult == DialogResult.Yes)
            {
                // Thực hiện lệnh sửa nếu người dùng chọn Yes
                command = connection.CreateCommand();
                command.CommandText = "UPDATE NHASANXUAT SET " +
                                      "TENNHASANXUAT = '" + cbtennsx.Text + "', " +
                                      "DIACHI = '" + cbdiachi.Text + "', " +
                                      "SODIENTHOAI = '" + cbsdt.Text + "', " +
                                      "EMAIL = '" + cbemail.Text + "' " +
                                      "WHERE MANHASANXUAT = '" + txtmansx.Text + "'";
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
            txtmansx.Text = "";
            
            cbtennsx.Text = "";
            cbdiachi.Text = "";
            cbsdt.Text = "";
            cbemail.Text = "";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



