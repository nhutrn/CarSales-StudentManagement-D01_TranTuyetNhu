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
    public partial class FormSystem : Form
    {
        public FormSystem()
        {
            InitializeComponent();
            tsmiChucNang.Enabled = false;
            tsmiTroGiup.Enabled = false;
        }

        private void tsmiDangNhap_Click_1(object sender, EventArgs e)
        {
            using (FormLogin f1 = new FormLogin(this))
            {
                this.Hide();
                DialogResult result = f1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tsmiChucNang.Enabled = true;
                    tsmiTroGiup.Enabled = true;
                }
                else if (result == DialogResult.Cancel)
                {
                    tsmiChucNang.Enabled = false;
                    tsmiTroGiup.Enabled = false;
                }
                this.Show();
            }
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmiXe_Click(object sender, EventArgs e)
        {
            FormCarManagement f2 = new FormCarManagement();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void tsmiSV_Click(object sender, EventArgs e)
        {
            FormStudentManagement f3 = new FormStudentManagement();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void Thongtin_click(object sender, EventArgs e)
        {
            FormInfo frm = new FormInfo();
            frm.ShowDialog();
        }

        private void FormSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
