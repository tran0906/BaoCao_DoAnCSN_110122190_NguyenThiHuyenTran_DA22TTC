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
    public partial class frm_ThuongHieu : Form
    {


        SqlConnection connection;
        SqlCommand commmand;
        string str = @"Data Source=.;Initial Catalog=quanlydienthoai1;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlCommand command;

        void loaddata()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM THUONGHIEU", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvthuonghieu.DataSource = table;
                    SetupDataGridViewFullScreen();


                    dgvthuonghieu.Columns["MATH"].HeaderText = "MÃ THƯƠNG HIỆU";
                    dgvthuonghieu.Columns["TENTH"].HeaderText = "TÊN THƯƠNG HIỆU";
                    dgvthuonghieu.Columns["MOTA"].HeaderText = "MÔ TẢ";
                    dgvthuonghieu.Columns["QUOCGIA"].HeaderText = "QUỐC GIA";
                    dgvthuonghieu.Columns["WEBSITETHUONGHIEU"].HeaderText = "WEDSITE THƯƠNG HIỆU";






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








        public frm_ThuongHieu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_ThuongHieu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            // LoadMaDienThoai();


        }

        private void dgvthuonghieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvthuonghieu.CurrentRow.Index;
            txtmath.Text = dgvthuonghieu.Rows[i].Cells[0].Value.ToString();

            cbtenthuonghieu.Text = dgvthuonghieu.Rows[i].Cells[1].Value.ToString();
            txtmota.Text = dgvthuonghieu.Rows[i].Cells[2].Value.ToString();
            cbquocgia.Text = dgvthuonghieu.Rows[i].Cells[3].Value.ToString();
            cbweb.Text = dgvthuonghieu.Rows[i].Cells[4].Value.ToString();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(txtmath.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã thương hiệu để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Kiểm tra mã thương hiệu
                    string checkQuery = "SELECT COUNT(*) FROM THUONGHIEU WHERE MATH = @MATH";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@MATH", txtmath.Text);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Mã thương hiệu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Xác nhận thêm
                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Thêm thương hiệu
                        string insertQuery = "INSERT INTO THUONGHIEU (MATH, TENTH, MOTA, QUOCGIA, WEBSITETHUONGHIEU) " +
                                             "VALUES (@MATH, @TENTH, @MOTA, @QUOCGIA, @WEBSITETHUONGHIEU)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@MATH", txtmath.Text);
                            insertCommand.Parameters.AddWithValue("@TENTH", cbtenthuonghieu.Text);
                            insertCommand.Parameters.AddWithValue("@MOTA", txtmota.Text);
                            insertCommand.Parameters.AddWithValue("@QUOCGIA", cbquocgia.Text);
                            insertCommand.Parameters.AddWithValue("@WEBSITETHUONGHIEU", cbweb.Text);

                            insertCommand.ExecuteNonQuery();
                        }

                        loaddata();
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
          
            
            

    


        private void btnxoa_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if the required field is filled out
                if (string.IsNullOrEmpty(txtmath.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã thương hiệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ask the user for confirmation before deleting
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();


                        // 1. Xóa các bản ghi trong bảng MUA liên quan đến nhân viên
                        string sqlDeleteMua = @"DELETE FROM MUA WHERE MADT IN (SELECT MADT FROM DIENTHOAI WHERE MATH = @MaThuongHieu)";
                        using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, connection))
                        {
                            cmdDeleteMua.Parameters.AddWithValue("@MaThuongHieu", txtmath.Text);
                            cmdDeleteMua.ExecuteNonQuery();
                        }



                        //Delete related records in DIENTHOAI table
                        string deleteDienThoaiQuery = "DELETE FROM DIENTHOAI WHERE MATH = @MATH";
                        using (SqlCommand deleteDienThoaiCommand = new SqlCommand(deleteDienThoaiQuery, connection))
                        {
                            deleteDienThoaiCommand.Parameters.AddWithValue("@MATH", txtmath.Text);
                            int rowsAffectedDienThoai = deleteDienThoaiCommand.ExecuteNonQuery();
                            if (rowsAffectedDienThoai < 0)
                            {
                                MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Delete the record in THUONGHIEU table (using parameterized query)
                        string deleteQuery = "DELETE FROM THUONGHIEU WHERE MATH = @MATH";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@MATH", txtmath.Text);

                            int rowsAffected = deleteCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                loaddata();
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy mã thương hiệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thao tác xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            //// Hỏi người dùng xác nhận trước khi xóa
            //DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (confirmResult == DialogResult.Yes)
            //{




            //    // Xóa các bản ghi liên quan trong bảng DIENTHOAI
            //    commmand = connection.CreateCommand();
            //    commmand.CommandText = "DELETE FROM DIENTHOAI WHERE MATH = '" + txtmath.Text + "'";
            //    commmand.ExecuteNonQuery();





            //    // Thực hiện lệnh xóa nếu người dùng chọn Yes
            //    commmand = connection.CreateCommand();
            //    commmand.CommandText = "delete from THUONGHIEU where MATH = '" + cbtenthuonghieu.Text + "'";
            //    commmand.ExecuteNonQuery();
            //    loaddata();

            //    // Thông báo thành công
            //    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    // Thông báo nếu người dùng chọn No
            //    MessageBox.Show("Hủy thao tác xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        
            try
            {

                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(txtmath.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã thương hiệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Hỏi người dùng xác nhận trước khi sửa
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Tạo đối tượng SqlCommand và mở kết nối
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("UPDATE THUONGHIEU SET " +
                                                                   "TENTH = @TENTH, " +
                                                                   "MOTA = @MOTA, " +
                                                                   "QUOCGIA = @QUOCGIA, " +
                                                                   "WEBSITETHUONGHIEU = @WEBSITETHUONGHIEU " +
                                                                   "WHERE MATH = @MATH", connection))
                        {
                            // Thêm tham số vào lệnh SQL
                            command.Parameters.AddWithValue("@MATH", txtmath.Text);
                            command.Parameters.AddWithValue("@TENTH", cbtenthuonghieu.Text);
                            command.Parameters.AddWithValue("@MOTA", txtmota.Text);
                            command.Parameters.AddWithValue("@QUOCGIA", cbquocgia.Text);
                            command.Parameters.AddWithValue("@WEBSITETHUONGHIEU", cbweb.Text);

                            // Thực thi lệnh SQL để cập nhật dữ liệu
                            command.ExecuteNonQuery();
                        }

                        // Thông báo thành công
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Thông báo nếu người dùng chọn No
                    MessageBox.Show("Hủy thao tác sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        
        

        

        }

        
 

        private void btnkhoitao_Click(object sender, EventArgs e)
        {


            // Clear input fields
            txtmath.Text = "";
            cbtenthuonghieu.SelectedIndex = -1; // Clear ComboBox
            txtmota.Text = "";
            cbquocgia.SelectedIndex = -1;      // Clear ComboBox
            cbweb.Text = "";
            txtmath.ReadOnly = false;



            //// Xóa toàn bộ giá trị của các trường nhập liệu
            //txtmath.Text = "";
            //cbtenthuonghieu.SelectedIndex = -1; // Đặt ComboBox về trạng thái trống
            //txtmota.Clear();
            //cbquocgia.SelectedIndex = -1; // Nếu là ComboBox
            //txtweb.Clear();

        }

        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvthuonghieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvthuonghieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvthuonghieu.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvthuonghieu.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvthuonghieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvthuonghieu.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvthuonghieu.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvthuonghieu.RowsDefaultCellStyle.BackColor = Color.White;
            dgvthuonghieu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvthuonghieu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvthuonghieu.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvthuonghieu.ReadOnly = true;

            // Đặt border
            dgvthuonghieu.BorderStyle = BorderStyle.Fixed3D;
            dgvthuonghieu.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvthuonghieu.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvthuonghieu.AllowUserToResizeColumns = false;
            dgvthuonghieu.AllowUserToResizeRows = false;
        }

        //private void btncapnhat_Click(object sender, EventArgs e)
        //{
        //    frm_DienThoai frm = new frm_DienThoai();
        //    frm.ShowDialog();
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

