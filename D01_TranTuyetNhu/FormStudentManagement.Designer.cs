namespace D01_TranTuyetNhu
{
    partial class FormStudentManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentManagement));
            this.pnlMenuSV = new System.Windows.Forms.Panel();
            this.lblMenuSV2 = new System.Windows.Forms.Label();
            this.lblMenuSV1 = new System.Windows.Forms.Label();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.btnTimKiemSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChinhSuaSV = new System.Windows.Forms.Button();
            this.btnThoatSV = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.lblHoSV = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.pnlMenuSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuSV
            // 
            this.pnlMenuSV.BackColor = System.Drawing.Color.Black;
            this.pnlMenuSV.Controls.Add(this.lblMenuSV2);
            this.pnlMenuSV.Controls.Add(this.lblMenuSV1);
            this.pnlMenuSV.Location = new System.Drawing.Point(0, -19);
            this.pnlMenuSV.Name = "pnlMenuSV";
            this.pnlMenuSV.Size = new System.Drawing.Size(886, 119);
            this.pnlMenuSV.TabIndex = 3;
            // 
            // lblMenuSV2
            // 
            this.lblMenuSV2.AutoSize = true;
            this.lblMenuSV2.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuSV2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSV2.ForeColor = System.Drawing.Color.White;
            this.lblMenuSV2.Location = new System.Drawing.Point(27, 32);
            this.lblMenuSV2.Name = "lblMenuSV2";
            this.lblMenuSV2.Size = new System.Drawing.Size(138, 19);
            this.lblMenuSV2.TabIndex = 2;
            this.lblMenuSV2.Text = "CHƯƠNG TRÌNH";
            // 
            // lblMenuSV1
            // 
            this.lblMenuSV1.AutoSize = true;
            this.lblMenuSV1.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuSV1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSV1.ForeColor = System.Drawing.Color.White;
            this.lblMenuSV1.Location = new System.Drawing.Point(23, 51);
            this.lblMenuSV1.Name = "lblMenuSV1";
            this.lblMenuSV1.Size = new System.Drawing.Size(381, 44);
            this.lblMenuSV1.TabIndex = 1;
            this.lblMenuSV1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewSV.Location = new System.Drawing.Point(31, 279);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.RowHeadersWidth = 51;
            this.dataGridViewSV.RowTemplate.Height = 24;
            this.dataGridViewSV.Size = new System.Drawing.Size(819, 239);
            this.dataGridViewSV.TabIndex = 0;
            this.dataGridViewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellContentClick);
            // 
            // btnTimKiemSV
            // 
            this.btnTimKiemSV.BackColor = System.Drawing.Color.Black;
            this.btnTimKiemSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSV.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSV.Location = new System.Drawing.Point(132, 581);
            this.btnTimKiemSV.Name = "btnTimKiemSV";
            this.btnTimKiemSV.Size = new System.Drawing.Size(99, 29);
            this.btnTimKiemSV.TabIndex = 2;
            this.btnTimKiemSV.Text = "Tìm kiếm";
            this.btnTimKiemSV.UseVisualStyleBackColor = false;
            this.btnTimKiemSV.Click += new System.EventHandler(this.btnTimKiemSV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(342, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnChinhSuaSV
            // 
            this.btnChinhSuaSV.BackColor = System.Drawing.Color.White;
            this.btnChinhSuaSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaSV.Location = new System.Drawing.Point(237, 581);
            this.btnChinhSuaSV.Name = "btnChinhSuaSV";
            this.btnChinhSuaSV.Size = new System.Drawing.Size(99, 29);
            this.btnChinhSuaSV.TabIndex = 3;
            this.btnChinhSuaSV.Text = "Chỉnh sửa";
            this.btnChinhSuaSV.UseVisualStyleBackColor = false;
            this.btnChinhSuaSV.Click += new System.EventHandler(this.btnChinhSuaSV_Click);
            // 
            // btnThoatSV
            // 
            this.btnThoatSV.BackColor = System.Drawing.Color.Black;
            this.btnThoatSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatSV.ForeColor = System.Drawing.Color.White;
            this.btnThoatSV.Location = new System.Drawing.Point(751, 581);
            this.btnThoatSV.Name = "btnThoatSV";
            this.btnThoatSV.Size = new System.Drawing.Size(99, 29);
            this.btnThoatSV.TabIndex = 8;
            this.btnThoatSV.Text = "Thoát";
            this.btnThoatSV.UseVisualStyleBackColor = false;
            this.btnThoatSV.Click += new System.EventHandler(this.btnThoatSV_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaSV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.ForeColor = System.Drawing.Color.White;
            this.lblMaSV.Location = new System.Drawing.Point(15, 36);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(91, 16);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // txtHoSV
            // 
            this.txtHoSV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoSV.Location = new System.Drawing.Point(298, 57);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(202, 22);
            this.txtHoSV.TabIndex = 7;
            this.txtHoSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoSV_KeyPress);
            // 
            // lblHoSV
            // 
            this.lblHoSV.AutoSize = true;
            this.lblHoSV.BackColor = System.Drawing.Color.Transparent;
            this.lblHoSV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoSV.ForeColor = System.Drawing.Color.White;
            this.lblHoSV.Location = new System.Drawing.Point(295, 38);
            this.lblHoSV.Name = "lblHoSV";
            this.lblHoSV.Size = new System.Drawing.Size(89, 16);
            this.lblHoSV.TabIndex = 1;
            this.lblHoSV.Text = "Họ sinh viên:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.Color.White;
            this.lblTenSV.Location = new System.Drawing.Point(590, 38);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(96, 16);
            this.lblTenSV.TabIndex = 2;
            this.lblTenSV.Text = "Tên sinh viên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.White;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 89);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.White;
            this.lblGioiTinh.Location = new System.Drawing.Point(299, 89);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(66, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(593, 110);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(195, 22);
            this.txtMaKhoa.TabIndex = 11;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKhoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.ForeColor = System.Drawing.Color.White;
            this.lblMaKhoa.Location = new System.Drawing.Point(590, 89);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(65, 16);
            this.lblMaKhoa.TabIndex = 5;
            this.lblMaKhoa.Text = "Mã khoa:";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(18, 110);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(179, 22);
            this.dateNgaySinh.TabIndex = 9;
            this.dateNgaySinh.Value = new System.DateTime(2024, 10, 26, 0, 0, 0, 0);
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.DropDownHeight = 104;
            this.cbo_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GioiTinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.IntegralHeight = false;
            this.cbo_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Giới tính khác"});
            this.cbo_GioiTinh.Location = new System.Drawing.Point(298, 109);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(202, 22);
            this.cbo_GioiTinh.TabIndex = 10;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Location = new System.Drawing.Point(593, 57);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(195, 22);
            this.txtTenSV.TabIndex = 8;
            this.txtTenSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSV_KeyPress);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(18, 55);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(179, 22);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbo_GioiTinh);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.lblMaKhoa);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.lblNgaySinh);
            this.groupBox1.Controls.Add(this.lblTenSV);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.txtTenSV);
            this.groupBox1.Controls.Add(this.lblHoSV);
            this.groupBox1.Controls.Add(this.txtHoSV);
            this.groupBox1.Controls.Add(this.lblMaSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(33, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sinh viên";
            // 
            // btnLuuSV
            // 
            this.btnLuuSV.BackColor = System.Drawing.Color.White;
            this.btnLuuSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSV.Location = new System.Drawing.Point(447, 581);
            this.btnLuuSV.Name = "btnLuuSV";
            this.btnLuuSV.Size = new System.Drawing.Size(95, 29);
            this.btnLuuSV.TabIndex = 14;
            this.btnLuuSV.Text = "Lưu";
            this.btnLuuSV.UseVisualStyleBackColor = false;
            this.btnLuuSV.Click += new System.EventHandler(this.btnLuuSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackColor = System.Drawing.Color.White;
            this.btnThemSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSV.Location = new System.Drawing.Point(31, 581);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(95, 29);
            this.btnThemSV.TabIndex = 15;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = false;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click_1);
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.BackColor = System.Drawing.Color.White;
            this.btnHuyTimKiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyTimKiem.Location = new System.Drawing.Point(447, 581);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Size = new System.Drawing.Size(127, 29);
            this.btnHuyTimKiem.TabIndex = 16;
            this.btnHuyTimKiem.Text = "Hủy Tìm";
            this.btnHuyTimKiem.UseVisualStyleBackColor = false;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // FormStudentManagement
            // 
            this.AcceptButton = this.btnLuuSV;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.btnHuyTimKiem);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.btnLuuSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.btnThoatSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChinhSuaSV);
            this.Controls.Add(this.btnTimKiemSV);
            this.Controls.Add(this.pnlMenuSV);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý sinh viên";
            this.Load += new System.EventHandler(this.FormStudentManagement_Load);
            this.pnlMenuSV.ResumeLayout(false);
            this.pnlMenuSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuSV;
        private System.Windows.Forms.Label lblMenuSV2;
        private System.Windows.Forms.Label lblMenuSV1;
        private System.Windows.Forms.Button btnTimKiemSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChinhSuaSV;
        private System.Windows.Forms.Button btnThoatSV;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.Label lblHoSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuuSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnHuyTimKiem;
    }
}