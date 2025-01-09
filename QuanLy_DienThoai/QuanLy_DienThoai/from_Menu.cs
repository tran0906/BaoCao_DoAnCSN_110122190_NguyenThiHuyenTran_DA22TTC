using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_DienThoai
{
    public partial class from_Menu : Form
    {
        public from_Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


        }


        private Form currentFormChild;



        private void OpenChildForm(Form childForm)

        {

            if (currentFormChild != null)

            {

                currentFormChild.Close();

            }

            currentFormChild = childForm;

            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            panel_Body.Controls.Add(childForm);

            panel_Body.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();

        }




        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btndienthoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DienThoai());
            label1.Text = btndienthoai.Text;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (currentFormChild != null)

            {

                currentFormChild.Close();
                label1.Text = "Home";

            }
        }

        private void btncauhinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_CauHinh());
            label1.Text = btncauhinh.Text;
        }

        private void btnnhasanxuat_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_NhaSanXuat());
            //label1.Text = btnnhasanxuat.Text;
        }

        private void btnthuonghieu_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_ThuongHieu());
            //label1.Text = btnthuonghieu.Text;
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
        //    OpenChildForm(new frm_NhanVien());
        //    label1.Text = btnnhanvien.Text;
        //    //frm_DienThoai DienThoaifrom = new frm_DienThoai();
        //    //frm_NhanVien nhanVienForm = new frm_NhanVien(DienThoaifrom);
        //    //nhanVienForm.Show();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_KhachHang());
            //label1.Text = btnkhachhang.Text;
        }

        private void btnmuahang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_MuaHang());
            //label1.Text = btnmuahang.Text;
        }

        private void btndiachigiaohang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_DiaChiGiaoHang());
            //label1.Text = btndiachigiaohang.Text;
        }

        private void btncauhinh_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_CauHinh());
            label1.Text = btncauhinh.Text;
        }

        private void btnnhasanxuat_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhaSanXuat());
            label1.Text = btnnhasanxuat.Text;
        }

        private void btnthuonghieu_Click_1(object sender, EventArgs e)
        {

            OpenChildForm(new frm_ThuongHieu());
            label1.Text = btnthuonghieu.Text;
        }

        private void btnnhanvien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhanVien());
            label1.Text = btnnhanvien.Text;
        }

        private void btnkhachhang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_KhachHang());
            label1.Text = btnkhachhang.Text;
        }

        private void btnmuahang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MuaHang());
            label1.Text = btnmuahang.Text;
        }

        private void btndiachigiaohang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DiaChiGiaoHang());
            label1.Text = btndiachigiaohang.Text;
        }

        private void btnhdsd_Click(object sender, EventArgs e)
        {
             
            Help.ShowHelp(this, "HDSDhelp.chm");
            label1.Text = btnhdsd.Text;
        }
    }

         
    }

