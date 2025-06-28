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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoatInfo_Click(object sender, EventArgs e)
        {
            DialogResult thoatSV = MessageBox.Show("Bạn có muốn đóng trang thông tin không?", "Thoát ứng dụng!",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoatSV == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
