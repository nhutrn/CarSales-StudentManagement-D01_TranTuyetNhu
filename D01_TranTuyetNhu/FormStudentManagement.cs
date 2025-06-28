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


namespace D01_TranTuyetNhu
{

    public partial class FormStudentManagement : Form
    {
        private bool isEditing = false;
        SqlConnection conn;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-D81CL96G;Initial Catalog=QuanLySV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        void HienChiTiet()
        {
            command = conn.CreateCommand();
            command.CommandText = "Select * from QuanLySinhVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewSV.DataSource = table;
        }
        public FormStudentManagement()
        {
            InitializeComponent();
            txtMaSV.ReadOnly = true;
            txtHoSV.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            dateNgaySinh.Enabled = false;
            cbo_GioiTinh.Enabled = false;
            txtMaKhoa.ReadOnly = true;
            btnLuuSV.Visible = false;
            btnHuyTimKiem.Visible = false;
        }
        private void FormStudentManagement_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                // Gọi hàm hiển thị chi tiết sinh viên
                HienChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến SQL Server: \n" + ex.Message);
            }
            cbo_GioiTinh.SelectedIndex = 0;
        }
        private void btnThoatSV_Click(object sender, EventArgs e)
        {
            DialogResult thoatSV = MessageBox.Show("Bạn có muốn đóng chương trình quản lý sinh viên không?", "Thoát ứng dụng!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoatSV == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                txtMaSV.Text = dataGridViewSV.Rows[i].Cells[0].Value.ToString();
                txtHoSV.Text = dataGridViewSV.Rows[i].Cells[1].Value.ToString();
                txtTenSV.Text = dataGridViewSV.Rows[i].Cells[2].Value.ToString();
                dateNgaySinh.Value = Convert.ToDateTime(dataGridViewSV.Rows[i].Cells[3].Value);
                cbo_GioiTinh.Text = dataGridViewSV.Rows[i].Cells[4].Value.ToString();
                txtMaKhoa.Text = dataGridViewSV.Rows[i].Cells[5].Value.ToString();
            }
        }
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng điền mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoSV.Text))
            {
                MessageBox.Show("Vui lòng điền họ sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Vui lòng điền tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbo_GioiTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbo_GioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng điền mã khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhoa.Focus();
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            txtMaSV.Clear();
            txtHoSV.Clear();
            txtTenSV.Clear();
            dateNgaySinh.Value = DateTime.Now;
            cbo_GioiTinh.SelectedIndex = -1;
            txtMaKhoa.Clear();
        }
        private void btnThemSV_Click_1(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            txtHoSV.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            dateNgaySinh.Enabled = true;
            cbo_GioiTinh.Enabled = true;
            txtMaKhoa.ReadOnly = false;
            btnLuuSV.Visible = true;
            btnThemSV.Enabled = false;
            txtMaSV.Focus();
            ClearFields();
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("MSSV chỉ được nhập các ký tự số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtHoSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên SV chỉ được nhập các ký tự chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên SV chỉ được nhập các ký tự chữ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnChinhSuaSV_Click(object sender, EventArgs e)
        {
            isEditing = true; // Đặt cờ là true khi vào chế độ chỉnh sửa
            txtMaSV.ReadOnly = false;
            txtHoSV.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            dateNgaySinh.Enabled = true;
            cbo_GioiTinh.Enabled = true;
            txtMaKhoa.ReadOnly = false;
            if (KiemTraThongTin())
            {
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn chỉnh sửa thông tin sinh viên này?",
                    "Xác nhận chỉnh sửa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    btnLuuSV.Visible = true;
                }
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        using (SqlCommand command = new SqlCommand("DELETE FROM QuanLySinhVien WHERE MaSV = @MaSV", conn))
                        {
                            command.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HienChiTiet();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (SqlException sqlEx) when (sqlEx.Number == 547) // Mã lỗi SQL cho vi phạm khóa ngoại
                    {
                        MessageBox.Show("Không thể xóa sinh viên vì dữ liệu đang được sử dụng ở nơi khác.",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            HienChiTiet();
            btnHuyTimKiem.Visible = false;
        }
        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            FormTimKiem FormTimKiem = new FormTimKiem();
            btnHuyTimKiem.Visible = true;
            if (FormTimKiem.ShowDialog() == DialogResult.OK)
            {
                // Lấy mã sinh viên từ form nhỏ
                string maSV = FormTimKiem.MaSV;

                if (!string.IsNullOrEmpty(maSV))
                {
                    try
                    {
                        command = conn.CreateCommand();
                        command.CommandText = "SELECT * FROM QuanLySinhVien WHERE MaSV = @MaSV";
                        command.Parameters.AddWithValue("@MaSV", maSV);
                        adapter.SelectCommand = command;
                        DataTable searchTable = new DataTable();
                        adapter.Fill(searchTable);
                        if (searchTable.Rows.Count > 0)
                        {
                            dataGridViewSV.DataSource = searchTable;
                            btnHuyTimKiem.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên với mã: " + maSV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnHuyTimKiem.Visible = true;
            }
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraThongTin()) return;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open(); // Mở kết nối nếu chưa mở
                }

                SqlCommand command;

                if (isEditing)
                {
                    // Cập nhật thông tin sinh viên
                    command = new SqlCommand(
                        "UPDATE QuanLySinhVien SET HoSV = @HoSV, TenSV = @TenSV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, MaKhoa = @MaKhoa WHERE MaSV = @MaSV", conn);
                    command.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    command.Parameters.AddWithValue("@HoSV", txtHoSV.Text);
                    command.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                    command.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                    command.Parameters.AddWithValue("@GioiTinh", cbo_GioiTinh.Text);
                    command.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    isEditing = false;
                }
                else
                {
                    // Thêm sinh viên mới
                    command = new SqlCommand(
                        "INSERT INTO QuanLySinhVien (MaSV, HoSV, TenSV, NgaySinh, GioiTinh, MaKhoa) VALUES (@MaSV, @HoSV, @TenSV, @NgaySinh, @GioiTinh, @MaKhoa)", conn);
                    command.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                    command.Parameters.AddWithValue("@HoSV", txtHoSV.Text);
                    command.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                    command.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                    command.Parameters.AddWithValue("@GioiTinh", cbo_GioiTinh.Text);
                    command.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                }

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    string message = isEditing ? "Chỉnh sửa thông tin sinh viên thành công!" : "Thêm sinh viên thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLuuSV.Visible = false; // Ẩn nút Lưu sau khi thực hiện
                    HienChiTiet(); // Cập nhật lại dữ liệu hiển thị
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được thêm hoặc chỉnh sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Lỗi trùng khóa chính hoặc ràng buộc duy nhất
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Xử lý các lỗi khác
                    MessageBox.Show("Đã xảy ra lỗi khi thêm hoặc chỉnh sửa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không xác định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close(); // Đóng kết nối sau khi hoàn tất
                }
            }
            btnThemSV.Enabled = true;
            ClearFields();
        }
    }
}

