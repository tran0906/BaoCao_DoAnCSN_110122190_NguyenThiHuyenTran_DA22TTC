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
    public partial class frm_DienThoai : Form
    {

        SqlConnection connection;
        SqlCommand commmand;
        string str = @"Data Source=.;Initial Catalog=quanlydienthoai1;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
       // private string connectionString;

        void loaddata()
        {

            using (SqlConnection connection = new SqlConnection(str))

            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("select * from DIENTHOAI", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvdienthoai.DataSource = table;
                    SetupDataGridViewFullScreen();

                    dgvdienthoai.Columns["MADT"].HeaderText = "MÃ ĐIỆN THOẠI";
                    dgvdienthoai.Columns["MANV"].HeaderText = "MÃ NHÂN VIÊN";
                    dgvdienthoai.Columns["MATH"].HeaderText = "MÃ THƯƠNG HIỆU";
                    dgvdienthoai.Columns["MACAUHINH"].HeaderText = "MÃ CẤU HÌNH";
                    dgvdienthoai.Columns["MANHASANXUAT"].HeaderText = "MÃ NHÀ SẢN XUẤT ";
                    dgvdienthoai.Columns["TENDT"].HeaderText = "TÊN ĐIỆN THOẠI";
                    dgvdienthoai.Columns["GIABAN"].HeaderText = "GIÁ BÁN";
                    dgvdienthoai.Columns["TENTHUONGHIEU"].HeaderText = "TÊN THƯƠNG HIỆU";
                    dgvdienthoai.Columns["MAQUOCGIA"].HeaderText = "MÃ QUỐC GIA";
                    dgvdienthoai.Columns["THOIHANBHDT"].HeaderText = "THỜI HẠN BẢO HÀNH";
                    dgvdienthoai.Columns["MOTA"].HeaderText = "MÔ TẢ";




                }


            }
        }




        public frm_DienThoai()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frm_DienThoai_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            
            LoadMaThuongHieu();
            LoadMaNhaSanXuat();
            LoadNhanVien();
            LoadMaCauHinh();
            //DataTable dataTable = new DataTable("Employees");
            //dataTable.Columns.Add("TÊN THƯƠNG HIỆU", typeof(String));

            //dataTable.Rows.Add(new String[] { "Apple" });

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    String var = "";
            //    multicolumncbtenthuonghieu.Items.add(dataTable.Rows[i].ToString());
            //}




        }


      





        private void LoadMaThuongHieu()
        {
            
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT MATH FROM THUONGHIEU", connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        cbtenth.Items.Clear();  // Clear old items
                        while (reader.Read())
                        {
                            cbtenth.Items.Add(reader["MATH"].ToString()); // Add new items
                        }
                    }
                }
            }




        private void LoadMaNhaSanXuat()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MANHASANXUAT FROM NHASANXUAT", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cbmacauhinh.Items.Clear(); // Xóa các mục cũ trong ComboBox
                    while (reader.Read())
                    {
                        cbmansx.Items.Add(reader["MANHASANXUAT"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }


        private void LoadNhanVien()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MANV FROM NHANVIEN", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cbmacauhinh.Items.Clear(); // Xóa các mục cũ trong ComboBox
                    while (reader.Read())
                    {
                        cbmanv.Items.Add(reader["MANV"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }




        private void LoadMaCauHinh()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT MACAUHINH FROM CAUHINH", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    cbmacauhinh.Items.Clear(); // Xóa các mục cũ trong ComboBox
                    while (reader.Read())
                    {
                        cbmacauhinh.Items.Add(reader["MACAUHINH"].ToString()); // Thêm mã điện thoại vào ComboBox
                    }
                }
            }
        }





        private void dgvdienthoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgvdienthoai.CurrentRow.Index;

            txtmadt.Text = dgvdienthoai.Rows[i].Cells[0].Value.ToString();
            cbmanv.Text = dgvdienthoai.Rows[i].Cells[1].Value.ToString();
            cbtenth.Text = dgvdienthoai.Rows[i].Cells[2].Value.ToString();
            cbmacauhinh.Text = dgvdienthoai.Rows[i].Cells[3].Value.ToString();
            cbmansx.Text = dgvdienthoai.Rows[i].Cells[4].Value.ToString();
            txttendt.Text = dgvdienthoai.Rows[i].Cells[5].Value.ToString();
            txtgiaban.Text = dgvdienthoai.Rows[i].Cells[6].Value.ToString();
            cbtenthuonghieu.Text = dgvdienthoai.Rows[i].Cells[7].Value.ToString();

            
             
            cbmaquocgia.Text = dgvdienthoai.Rows[i].Cells[8].Value.ToString();
            cbbaohanh.Text = dgvdienthoai.Rows[i].Cells[9].Value.ToString();
            txtmota.Text = dgvdienthoai.Rows[i].Cells[10].Value.ToString();


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các ô bắt buộc
                if (string.IsNullOrEmpty(txtmadt.Text) || string.IsNullOrEmpty(txttendt.Text) || string.IsNullOrEmpty(txtgiaban.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if cbmanv has a value
                if (string.IsNullOrEmpty(cbmanv.Text))
                {
                    MessageBox.Show("Mã nhân viên chưa có mã. Vui lòng nhấn nút cập nhật nhân viên sau đó nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Check if MANV exists in NHANVIEN table
                string checkNhanVienQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MANV";
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand checkNhanVienCommand = new SqlCommand(checkNhanVienQuery, connection))
                    {
                        checkNhanVienCommand.Parameters.AddWithValue("@MANV", cbmanv.Text);

                        int nhanVienCount = (int)checkNhanVienCommand.ExecuteScalar();
                        if (nhanVienCount == 0)
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại. Vui lòng nhấn nút cập nhật nhân viên để nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }




                if (string.IsNullOrEmpty(cbtenth.Text))
                {
                    MessageBox.Show("Mã thương hiệu chưa có mã. Vui lòng nhấn nút cập nhật thương hiệu sau đó nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Check if MATH exists in THUONGHIEU table
                string checkThuongHieuQuery = "SELECT COUNT(*) FROM THUONGHIEU WHERE MATH = @MATH";
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand checkThuongHieuCommand = new SqlCommand(checkThuongHieuQuery, connection))
                    {
                        checkThuongHieuCommand.Parameters.AddWithValue("@MATH", cbtenth.Text);
                        int thuongHieuCount = (int)checkThuongHieuCommand.ExecuteScalar();
                        if (thuongHieuCount == 0)
                        {
                            MessageBox.Show("Mã thương hiệu không tồn tại. Vui lòng nhấn nút cập nhật thương hiệu để nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }







                if (string.IsNullOrEmpty(cbmacauhinh.Text))
                {
                    MessageBox.Show("Mã cấu hình chưa có mã. Vui lòng nhấn nút cập nhật cấu hình sau đó nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Check if MACAUHINH exists in CAUHINH table
                string checkCauHinhQuery = "SELECT COUNT(*) FROM CAUHINH WHERE MACAUHINH = @MACAUHINH";
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand checkCauHinhCommand = new SqlCommand(checkCauHinhQuery, connection))
                    {
                        checkCauHinhCommand.Parameters.AddWithValue("@MACAUHINH", cbmacauhinh.Text);
                        int cauHinhCount = (int)checkCauHinhCommand.ExecuteScalar();
                        if (cauHinhCount == 0)
                        {
                            MessageBox.Show("Mã cấu hình không tồn tại. Vui lòng nhấn nút cập nhật cấu hình để nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }




                if (string.IsNullOrEmpty(cbmansx.Text))
                {
                    MessageBox.Show("Mã nhà sản xuất chưa có mã. Vui lòng nhấn nút cập nhật nhà sản xuất sau đó nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Check if MANHASANXUAT exists in NHASANXUAT table
                string checkNhaSanXuatQuery = "SELECT COUNT(*) FROM NHASANXUAT WHERE MANHASANXUAT = @MANHASANXUAT";
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();
                    using (SqlCommand checkNhaSanXuatCommand = new SqlCommand(checkNhaSanXuatQuery, connection))
                    {
                        checkNhaSanXuatCommand.Parameters.AddWithValue("@MANHASANXUAT", cbmansx.Text);
                        int nhaSanXuatCount = (int)checkNhaSanXuatCommand.ExecuteScalar();
                        if (nhaSanXuatCount == 0)
                        {
                            MessageBox.Show("Mã nhà sản xuất không tồn tại. Vui lòng nhấn nút cập nhật nhà sản xuất để nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }








                // Check if the required combo boxes have values
                if (string.IsNullOrEmpty(cbmacauhinh.Text) ||
                    string.IsNullOrEmpty(cbtenth.Text) ||
                    string.IsNullOrEmpty(cbmansx.Text))
                    {
                        MessageBox.Show("Mã cấu hình, mã thương hiệu và mã nhà sản xuất chưa có mã. Vui lòng nhấn nút cập nhật tất cả các mã sau đó nhập dữ liệu và nhấn nút thêm để lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the event handler if the check fails
                    }



                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Thực hiện thêm dữ liệu vào bảng DIENTHOAI
                        string insertQuery = @"
                 INSERT INTO DIENTHOAI (MADT, MANV, MATH, MACAUHINH, MANHASANXUAT, TENDT, TENTHUONGHIEU, GIABAN, MAQUOCGIA, THOIHANBHDT, MOTA)
                 VALUES (@MADT, @MANV, @MATH, @MACAUHINH, @MANHASANXUAT, @TENDT, @TENTHUONGHIEU, @GIABAN, @MAQUOCGIA, @THOIHANBHDT, @MOTA)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@MADT", txtmadt.Text);
                            insertCommand.Parameters.AddWithValue("@MANV", cbmanv.Text);
                            insertCommand.Parameters.AddWithValue("@MATH", cbtenth.Text);
                            insertCommand.Parameters.AddWithValue("@MACAUHINH", cbmacauhinh.Text);
                            insertCommand.Parameters.AddWithValue("@MANHASANXUAT", cbmansx.Text);
                            insertCommand.Parameters.AddWithValue("@TENDT", txttendt.Text);
                            insertCommand.Parameters.AddWithValue("@TENTHUONGHIEU", cbtenthuonghieu.Text);
                            insertCommand.Parameters.AddWithValue("@GIABAN", txtgiaban.Text);
                            insertCommand.Parameters.AddWithValue("@MAQUOCGIA", cbmaquocgia.Text);
                            insertCommand.Parameters.AddWithValue("@THOIHANBHDT", cbbaohanh.Text);
                            insertCommand.Parameters.AddWithValue("@MOTA", txtmota.Text);

                            int rowsAffected = insertCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                loaddata(); // Tải lại dữ liệu
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
                MessageBox.Show("Mã điện thoại nầy đã có vui lòng nhập mã mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnxoa_Click(object sender, EventArgs e)
        {
            string madt = txtmadt.Text.Trim();
        
            try
            {
                // Check if the required field is filled out
                if (string.IsNullOrEmpty(txtmadt.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã điện thoại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ask the user for confirmation before deleting
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        connection.Open();



                        // 5. Xóa các bản ghi trong bảng con (MUA) trước
                        string sqlDeleteMua = "DELETE FROM MUA WHERE MADT = @MADT";
                        using (SqlCommand cmdDeleteChild = new SqlCommand(sqlDeleteMua, connection))
                        {
                            cmdDeleteChild.Parameters.AddWithValue("@MADT", madt);
                            cmdDeleteChild.ExecuteNonQuery();
                        }


                        // Delete the record in DIENTHOAI table (using parameterized query)
                        string deleteQuery = "DELETE FROM DIENTHOAI WHERE MADT = @MADT";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@MADT", txtmadt.Text);

                            int rowsAffected = deleteCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                loaddata();
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    // Inform the user if cancelled
                    MessageBox.Show("Hủy thao tác xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnsua_Click(object sender, EventArgs e)
        {

  
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(txtmadt.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã điện thoại để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hỏi người dùng xác nhận trước khi sửa
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Cập nhật dữ liệu vào bảng DIENTHOAI
                    string updateQuery = @"
            UPDATE DIENTHOAI
            SET 
                MANV = @MANV,
                MATH = @MATH,
                MACAUHINH = @MACAUHINH,
                MANHASANXUAT = @MANHASANXUAT,
                TENDT = @TENDT,
                TENTHUONGHIEU = @TENTHUONGHIEU,
                GIABAN = @GIABAN,
                MAQUOCGIA = @MAQUOCGIA,
                THOIHANBHDT = @THOIHANBHDT,
                MOTA = @MOTA
            WHERE MADT = @MADT";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@MADT", txtmadt.Text);
                        updateCommand.Parameters.AddWithValue("@MANV", cbmanv.Text);
                        updateCommand.Parameters.AddWithValue("@MATH", cbtenth.Text);
                        updateCommand.Parameters.AddWithValue("@MACAUHINH", cbmacauhinh.Text);
                        updateCommand.Parameters.AddWithValue("@MANHASANXUAT", cbmansx.Text);
                        updateCommand.Parameters.AddWithValue("@TENDT", txttendt.Text);
                        updateCommand.Parameters.AddWithValue("@TENTHUONGHIEU", cbtenthuonghieu.Text);
                        updateCommand.Parameters.AddWithValue("@GIABAN", txtgiaban.Text);
                        updateCommand.Parameters.AddWithValue("@MAQUOCGIA", cbmaquocgia.Text);
                        updateCommand.Parameters.AddWithValue("@THOIHANBHDT", cbbaohanh.Text);
                        updateCommand.Parameters.AddWithValue("@MOTA", txtmota.Text);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            loaddata(); // Tải lại dữ liệu vào DataGridView
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa dữ liệu, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thao tác sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }



        private void btnkhoitao_Click(object sender, EventArgs e)
        {
            txtmadt.Text = "";
            cbtenth.Text = "";
            cbmanv.Text = "";
            cbmacauhinh.Text = "";
            cbmansx.Text = "";

            txttendt.Text = "";
            cbtenthuonghieu.Text = "";
            txtgiaban.Text = "";
            
            cbmaquocgia.Text = "";
            cbbaohanh.Text = "";
            txtmota.Text = "";

            txtmadt.ReadOnly = false;

        }
    
    

            private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvdienthoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvdienthoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvdienthoai.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvdienthoai.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvdienthoai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvdienthoai.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvdienthoai.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvdienthoai.RowsDefaultCellStyle.BackColor = Color.White;
            dgvdienthoai.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvdienthoai.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvdienthoai.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvdienthoai.ReadOnly = true;

            // Đặt border
            dgvdienthoai.BorderStyle = BorderStyle.Fixed3D;
            dgvdienthoai.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvdienthoai.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvdienthoai.AllowUserToResizeColumns = false;
            dgvdienthoai.AllowUserToResizeRows = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmota_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_CauHinh frm = new frm_CauHinh();
              frm.ShowDialog();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.ShowDialog();
        }

        private void btnthuonghieu_Click(object sender, EventArgs e)
        {
            frm_ThuongHieu frm = new frm_ThuongHieu();
            frm.ShowDialog();
        }

        private void btnnhasanxuat_Click(object sender, EventArgs e)
        {
            frm_NhaSanXuat frm = new frm_NhaSanXuat();
            frm.ShowDialog();
        }

        private void cbmach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}







