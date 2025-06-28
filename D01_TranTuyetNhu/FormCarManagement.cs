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
    public partial class FormCarManagement : Form
    {
        int tongkhachhang;
        int tongkhachhangmuaxemauden = 0;
        double tongdoanhthu;
        bool daTinhTien = false;
        bool daTiep = false;


        public FormCarManagement()
        {
            InitializeComponent();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn đóng hóa đơn mua xe không?", "Thoát ứng dụng!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                txtDienThoai.Enabled = txtDiaChi.Enabled = false;
                txtGiaTien.Enabled = txtPhuThu.Enabled = txtThue.Enabled = false;
                btnTinhTien.Enabled = btnTiep.Enabled = false;
                rdbMauDen.Enabled = rdbMauTrang.Enabled = false;
            }
            else
            {
                txtDienThoai.Enabled = txtDiaChi.Enabled = true;
                txtGiaTien.Enabled = txtThue.Enabled = true;
                btnTinhTien.Enabled = btnTiep.Enabled = btnThongKe.Enabled = true;
                rdbMauDen.Enabled = rdbMauTrang.Enabled = true;
            }
        }

        private void FormCarManagement_Load(object sender, EventArgs e)
        {
            txtDienThoai.Enabled = txtDiaChi.Enabled = false;
            txtGiaTien.Enabled = txtPhuThu.Enabled = txtThue.Enabled = false;
            btnTinhTien.Enabled = btnTiep.Enabled = btnThongKe.Enabled = false;
            txtThanhTien.Enabled = txtTongSoKhachHang.Enabled = txtTongSoKhachHangMuaXeMauDen.Enabled = txtTongDoanhThu.Enabled = false;
            rdbMauDen.Enabled = rdbMauTrang.Enabled = false;
            rdbMauDen.Checked = true;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập tên ở dạng kí tự chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số điện thoại ở dạng kí tự số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbMauDen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMauDen.Checked)
            {
                txtPhuThu.Text = "5%";
                picXeMauTrang.Image = Properties.Resources.XeMauTrangMo1;
                picXeMauDen.Image = Properties.Resources.XeMauDen;
            }
        }

        private void rdbMauTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMauTrang.Checked)
            {
                txtPhuThu.Text = "0%";
                picXeMauTrang.Image = Properties.Resources.XeMauTrang;
                picXeMauDen.Image = Properties.Resources.XeMauDenMo;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double tongtien;
            if (rdbMauDen.Checked == true)
            {
                tongtien = 10000000000 * 1.15; // Giá xe màu đen có phụ thu 15%
            }
            else
            {
                tongtien = 10000000000 * 1.1;  // Giá xe màu trắng có phụ thu 10%
            }
            txtThanhTien.Text = Convert.ToString(tongtien);
            tongdoanhthu += tongtien;
            daTinhTien = true;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (!daTinhTien)
            {
                MessageBox.Show("Vui lòng click vào nút 'Tính tiền' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            daTinhTien = false;
            daTiep = true;
            txtHoTen.Focus();
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtThanhTien.Text = "";

            tongkhachhang += 1;

            if (rdbMauDen.Checked == true)
            {
                tongkhachhangmuaxemauden += 1;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (!daTiep)
            {
                MessageBox.Show("Vui lòng click vào nút 'Tiếp' trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            daTiep = false;
            txtTongSoKhachHang.Text = Convert.ToString(tongkhachhang);
            txtTongSoKhachHangMuaXeMauDen.Text = Convert.ToString(tongkhachhangmuaxemauden);
            txtTongDoanhThu.Text = Convert.ToString(tongdoanhthu);
        }
    }
}
