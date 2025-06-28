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
    public partial class FormTimKiem : Form
    {
        public string MaSV { get; private set; } // Thuộc tính lưu mã số sinh viên
        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Gán giá trị mã số sinh viên vào thuộc tính MaSV và đóng form
            MaSV = txtMaSV.Text.Trim();
            this.DialogResult = DialogResult.OK; // Đặt kết quả là OK để xác nhận
            this.Close();
        }

        private void btn_XacNhan_click(object sender, EventArgs e)
        {
            MaSV = txtMaSV.Text.Trim();
            this.DialogResult = DialogResult.OK; // Đặt kết quả là OK để xác nhận
            this.Close();
        }
    }
}
