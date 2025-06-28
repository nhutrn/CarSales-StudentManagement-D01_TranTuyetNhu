using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D01_TranTuyetNhu
{
    public partial class FormLogin : Form
    {
        private FormSystem _formSystem; // Tham chiếu đến FormSystem

        public FormLogin(FormSystem formSystem)
        {
            InitializeComponent();
            _formSystem = formSystem; // Lưu tham chiếu đến FormSystem
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void cbxQuenTaiKhoan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxQuenTaiKhoan.Checked)
            {
                MessageBox.Show("Tên đăng nhập: 'MRTHO', Mật khẩu: '123'", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxQuenTaiKhoan.Checked = false;
            }
        }

        private void cbxHienThiMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !cbxHienThiMatKhau.Checked;

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "MRTHO" || txtMatKhau.Text != "123")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnThoatDangNhap_Click_1(object sender, EventArgs e)
        {
            DialogResult ThoatDangNhap = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ThoatDangNhap == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Tên đăng nhập phải là chữ viết in hoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mật khẩu chỉ được nhập các ký tự số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

