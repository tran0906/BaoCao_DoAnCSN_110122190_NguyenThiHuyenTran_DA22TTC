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
    public partial class frm_CauHinh : Form
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
                using (SqlCommand command = new SqlCommand("select * from CAUHINH", connection))
                {
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvcauhinh.DataSource = table;
                    SetupDataGridViewFullScreen();


                    dgvcauhinh.Columns["MACAUHINH"].HeaderText = "MÃ CẤU HÌNH";
                     
                     
                    dgvcauhinh.Columns["MANHINH"].HeaderText = "MÀNG HÌNH";
                    dgvcauhinh.Columns["CHIPXULY"].HeaderText = "CHÍP XỬ LÝ";
                    dgvcauhinh.Columns["RAM"].HeaderText = "RAM";
                    dgvcauhinh.Columns["BONHOTRONG"].HeaderText = "BỘ NHỚ TRONG";
                    dgvcauhinh.Columns["CAMERATRUOC"].HeaderText = "CAMERA TRƯỚC";
                    dgvcauhinh.Columns["CAMERASAU"].HeaderText = "CAMERA SAU";
                    dgvcauhinh.Columns["PIN"].HeaderText = "PIN";
                    dgvcauhinh.Columns["HEDIEUHANH"].HeaderText = "HỆ ĐIỀU HÀNH";
                    dgvcauhinh.Columns["SIM"].HeaderText = "SIM";
                    dgvcauhinh.Columns["KETNOI"].HeaderText = "KẾT NỐI";
                    dgvcauhinh.Columns["NGAYCAPNHAT"].HeaderText = "NGÀY CẬP NHẬT";





                }
            }
        }





        public frm_CauHinh()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frm_CauHinh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
         //   LoadMaDienThoai();

        }



        //private void LoadMaDienThoai()
        //{
        //    using (SqlConnection connection = new SqlConnection(str))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand("SELECT MADT FROM DIENTHOAI", connection))
        //        {
        //            SqlDataReader reader = command.ExecuteReader();
        //            cbmach.Items.Clear(); // Xóa các mục cũ trong ComboBox
        //            while (reader.Read())
        //            {
        //                cbmach.Items.Add(reader["MADT"].ToString()); // Thêm mã điện thoại vào ComboBox
        //            }
        //        }
        //    }
        //}





        private void dgvcauhinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvcauhinh.CurrentRow.Index;

            txtcauhinh.Text = dgvcauhinh.Rows[i].Cells[0].Value.ToString();
            
             
            cbmanhinh.Text = dgvcauhinh.Rows[i].Cells[1].Value.ToString();
            cbchipxuly.Text = dgvcauhinh.Rows[i].Cells[2].Value.ToString();
            cbram.Text = dgvcauhinh.Rows[i].Cells[3].Value.ToString();
            cbbonhotrong.Text = dgvcauhinh.Rows[i].Cells[4].Value.ToString();
            cbcameratruoc.Text = dgvcauhinh.Rows[i].Cells[5].Value.ToString();
            cbcamerasau.Text = dgvcauhinh.Rows[i].Cells[6].Value.ToString();
            cbpin.Text = dgvcauhinh.Rows[i].Cells[7].Value.ToString();
            cbhedieuhanh.Text = dgvcauhinh.Rows[i].Cells[8].Value.ToString();
            cbsim.Text = dgvcauhinh.Rows[i].Cells[9].Value.ToString();
            cbketnoi.Text = dgvcauhinh.Rows[i].Cells[10].Value.ToString();
            txtngaycapnhat.Text = dgvcauhinh.Rows[i].Cells[11].Value.ToString();

             

        }


        private void SetupDataGridViewFullScreen()
        {
            // Căn chỉnh DataGridView full màn hình
            dgvcauhinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động fill toàn bộ chiều ngang
            dgvcauhinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Không tự động điều chỉnh chiều cao dòng
            dgvcauhinh.ColumnHeadersHeight = 40; // Tăng chiều cao tiêu đề cột
            dgvcauhinh.RowTemplate.Height = 30; // Chiều cao dòng dữ liệu

            // Căn giữa tiêu đề cột
            dgvcauhinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ
            dgvcauhinh.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvcauhinh.DefaultCellStyle.Font = new Font("Arial", 10);

            // Màu nền xen kẽ cho dòng
            dgvcauhinh.RowsDefaultCellStyle.BackColor = Color.White;
            dgvcauhinh.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Màu nền tiêu đề
            dgvcauhinh.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvcauhinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Đặt chế độ ReadOnly để ngăn chỉnh sửa
            dgvcauhinh.ReadOnly = true;

            // Đặt border
            dgvcauhinh.BorderStyle = BorderStyle.Fixed3D;
            dgvcauhinh.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvcauhinh.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái

            // Không cho phép người dùng chỉnh sửa độ rộng cột
            dgvcauhinh.AllowUserToResizeColumns = false;
            dgvcauhinh.AllowUserToResizeRows = false;
        }

        //private void btncapnhat_Click(object sender, EventArgs e)
        //{
        //    frm_DienThoai frm = new frm_DienThoai();
        //    frm.ShowDialog();

        //}

        private void btnkhoitao_Click(object sender, EventArgs e)
        {
            txtcauhinh.Text = "";
         
            
            cbmanhinh.Text = "";
            cbchipxuly.Text = "";
            cbram.Text = "";
            cbbonhotrong.Text = "";
            cbcameratruoc.Text = "";
            cbcamerasau.Text = "";
            cbpin.Text = "";
            cbhedieuhanh.Text = "";
            cbsim.Text = "";
            cbketnoi.Text = "";
            txtngaycapnhat.Text = "";

        }

        private void btnsua_Click(object sender, EventArgs e)




        {
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(txtcauhinh.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã cấu hình để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // Check if the required  textbox is filled out.
                if (string.IsNullOrEmpty(txtcauhinh.Text))
                {
                    MessageBox.Show("Mã cấu hình cấu hình nầy chưa có vui lòng nhập mã mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                // Hỏi người dùng xác nhận trước khi sửa
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(str))
                        {
                            connection.Open();
                            string query = @"UPDATE CAUHINH
                                 SET   MANHINH = @MANHINH, CHIPXULY = @CHIPXULY, 
                                     RAM = @RAM, BONHOTRONG = @BONHOTRONG, CAMERATRUOC = @CAMERATRUOC, CAMERASAU = @CAMERASAU,
                                     PIN = @PIN, HEDIEUHANH = @HEDIEUHANH, SIM = @SIM, KETNOI = @KETNOI, NGAYCAPNHAT = @NGAYCAPNHAT
                                 WHERE MACAUHINH = @MACAUHINH";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {

                                command.Parameters.AddWithValue("@MANHINH", cbmanhinh.Text);
                                command.Parameters.AddWithValue("@CHIPXULY", cbchipxuly.Text);
                                command.Parameters.AddWithValue("@RAM", cbram.Text);
                                command.Parameters.AddWithValue("@BONHOTRONG", cbbonhotrong.Text);
                                command.Parameters.AddWithValue("@CAMERATRUOC", cbcameratruoc.Text);
                                command.Parameters.AddWithValue("@CAMERASAU", cbcamerasau.Text);
                                command.Parameters.AddWithValue("@PIN", cbpin.Text);
                                command.Parameters.AddWithValue("@HEDIEUHANH", cbhedieuhanh.Text);
                                command.Parameters.AddWithValue("@SIM", cbsim.Text);
                                command.Parameters.AddWithValue("@KETNOI", cbketnoi.Text);
                                command.Parameters.AddWithValue("@NGAYCAPNHAT", txtngaycapnhat.Text);
                                command.Parameters.AddWithValue("@MACAUHINH", txtcauhinh.Text);

                                command.ExecuteNonQuery();
                            }
                        }
                        loaddata();
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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





        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(txtcauhinh.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã cấu hình để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Hỏi người dùng xác nhận trước khi xóa
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {

                    // 1. Xóa các bản ghi trong bảng MUA liên quan đến nhân viên
                    string sqlDeleteMua = @"DELETE FROM MUA WHERE MADT IN (SELECT MADT FROM DIENTHOAI WHERE MACAUHINH = @MaCauHinh)";
                    using (SqlCommand cmdDeleteMua = new SqlCommand(sqlDeleteMua, connection))
                    {
                        cmdDeleteMua.Parameters.AddWithValue("@MaCauHinh", txtcauhinh.Text);
                        cmdDeleteMua.ExecuteNonQuery();
                    }


                    // Xóa các bản ghi liên quan trong bảng DIENTHOAI
                    commmand = connection.CreateCommand();
                commmand.CommandText = "DELETE FROM DIENTHOAI WHERE MACAUHINH = '" + txtcauhinh.Text + "'";
                commmand.ExecuteNonQuery();



                // Thực hiện lệnh xóa nếu người dùng chọn Yes
                commmand = connection.CreateCommand();
                commmand.CommandText = "DELETE FROM CAUHINH WHERE MACAUHINH = '" + txtcauhinh.Text + "'";
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
            
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}







        private void btnthem_Click(object sender, EventArgs e)
        {

            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrEmpty(txtcauhinh.Text))
                {
                    MessageBox.Show("Vui lòng chọn mã cấu hình để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Hỏi người dùng xác nhận trước khi xóa
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {

                // Kiểm tra mã cấu hình đã tồn tại hay chưa
                string checkQuery = "SELECT COUNT(*) FROM CAUHINH WHERE MACAUHINH = @MACAUHINH";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@MACAUHINH", txtcauhinh.Text);

                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Mã cấu hình này đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Dừng thao tác thêm nếu mã cấu hình đã tồn tại
                        }
                    }

                    // Thêm dữ liệu vào bảng CAUHINH
                    string insertQuery = @"INSERT INTO CAUHINH 
                                   (MACAUHINH, MANHINH, CHIPXULY, RAM, BONHOTRONG, CAMERATRUOC, CAMERASAU, PIN, HEDIEUHANH, SIM, KETNOI, NGAYCAPNHAT) 
                                   VALUES 
                                   (@MACAUHINH, @MANHINH, @CHIPXULY, @RAM, @BONHOTRONG, @CAMERATRUOC, @CAMERASAU, @PIN, @HEDIEUHANH, @SIM, @KETNOI, @NGAYCAPNHAT)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@MACAUHINH", txtcauhinh.Text);
                        insertCommand.Parameters.AddWithValue("@MANHINH", cbmanhinh.Text);
                        insertCommand.Parameters.AddWithValue("@CHIPXULY", cbchipxuly.Text);
                        insertCommand.Parameters.AddWithValue("@RAM", cbram.Text);
                        insertCommand.Parameters.AddWithValue("@BONHOTRONG", cbbonhotrong.Text);
                        insertCommand.Parameters.AddWithValue("@CAMERATRUOC", cbcameratruoc.Text);
                        insertCommand.Parameters.AddWithValue("@CAMERASAU", cbcamerasau.Text);
                        insertCommand.Parameters.AddWithValue("@PIN", cbpin.Text);
                        insertCommand.Parameters.AddWithValue("@HEDIEUHANH", cbhedieuhanh.Text);
                        insertCommand.Parameters.AddWithValue("@SIM", cbsim.Text);
                        insertCommand.Parameters.AddWithValue("@KETNOI", cbketnoi.Text);
                        insertCommand.Parameters.AddWithValue("@NGAYCAPNHAT", txtngaycapnhat.Text);

                        insertCommand.ExecuteNonQuery();
                    }

                    // Tải lại dữ liệu sau khi thêm
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
    
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

    

