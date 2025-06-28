namespace D01_TranTuyetNhu
{
    partial class FormSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSystem));
            this.mnsHeThong = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChaoMung1 = new System.Windows.Forms.Label();
            this.lblChaoMung2 = new System.Windows.Forms.Label();
            this.mnsHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsHeThong
            // 
            this.mnsHeThong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiChucNang,
            this.tsmiTroGiup});
            this.mnsHeThong.Location = new System.Drawing.Point(0, 0);
            this.mnsHeThong.Name = "mnsHeThong";
            this.mnsHeThong.Size = new System.Drawing.Size(884, 24);
            this.mnsHeThong.TabIndex = 0;
            this.mnsHeThong.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDangNhap,
            this.tsmiThoat});
            this.tsmiFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(38, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiDangNhap
            // 
            this.tsmiDangNhap.Image = global::D01_TranTuyetNhu.Properties.Resources.login_icon_removebg_preview;
            this.tsmiDangNhap.Name = "tsmiDangNhap";
            this.tsmiDangNhap.Size = new System.Drawing.Size(148, 22);
            this.tsmiDangNhap.Text = "Đăng nhập";
            this.tsmiDangNhap.Click += new System.EventHandler(this.tsmiDangNhap_Click_1);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Image = global::D01_TranTuyetNhu.Properties.Resources.exit_icon_removebg_preview;
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiThoat.Size = new System.Drawing.Size(148, 22);
            this.tsmiThoat.Text = "Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // tsmiChucNang
            // 
            this.tsmiChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXe,
            this.tsmiSV});
            this.tsmiChucNang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiChucNang.Name = "tsmiChucNang";
            this.tsmiChucNang.Size = new System.Drawing.Size(81, 20);
            this.tsmiChucNang.Text = "Chức năng";
            // 
            // tsmiXe
            // 
            this.tsmiXe.Image = global::D01_TranTuyetNhu.Properties.Resources.icon_removebg_preview;
            this.tsmiXe.Name = "tsmiXe";
            this.tsmiXe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiXe.Size = new System.Drawing.Size(206, 22);
            this.tsmiXe.Text = "Quản lý bán xe";
            this.tsmiXe.Click += new System.EventHandler(this.tsmiXe_Click);
            // 
            // tsmiSV
            // 
            this.tsmiSV.Image = global::D01_TranTuyetNhu.Properties.Resources.student_icon_removebg_preview;
            this.tsmiSV.Name = "tsmiSV";
            this.tsmiSV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmiSV.Size = new System.Drawing.Size(206, 22);
            this.tsmiSV.Text = "Quản lý sinh viên";
            this.tsmiSV.Click += new System.EventHandler(this.tsmiSV_Click);
            // 
            // tsmiTroGiup
            // 
            this.tsmiTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThongTin});
            this.tsmiTroGiup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTroGiup.Name = "tsmiTroGiup";
            this.tsmiTroGiup.Size = new System.Drawing.Size(66, 20);
            this.tsmiTroGiup.Text = "Trợ giúp";
            // 
            // tsmiThongTin
            // 
            this.tsmiThongTin.Image = global::D01_TranTuyetNhu.Properties.Resources.infor_icon_removebg_preview;
            this.tsmiThongTin.Name = "tsmiThongTin";
            this.tsmiThongTin.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmiThongTin.Size = new System.Drawing.Size(146, 22);
            this.tsmiThongTin.Text = "Thông tin";
            this.tsmiThongTin.Click += new System.EventHandler(this.Thongtin_click);
            // 
            // lblChaoMung1
            // 
            this.lblChaoMung1.AutoSize = true;
            this.lblChaoMung1.BackColor = System.Drawing.Color.Transparent;
            this.lblChaoMung1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaoMung1.ForeColor = System.Drawing.Color.White;
            this.lblChaoMung1.Location = new System.Drawing.Point(27, 532);
            this.lblChaoMung1.Name = "lblChaoMung1";
            this.lblChaoMung1.Size = new System.Drawing.Size(675, 44);
            this.lblChaoMung1.TabIndex = 1;
            this.lblChaoMung1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI FAUGET";
            // 
            // lblChaoMung2
            // 
            this.lblChaoMung2.AutoSize = true;
            this.lblChaoMung2.BackColor = System.Drawing.Color.Transparent;
            this.lblChaoMung2.ForeColor = System.Drawing.Color.White;
            this.lblChaoMung2.Location = new System.Drawing.Point(32, 576);
            this.lblChaoMung2.Name = "lblChaoMung2";
            this.lblChaoMung2.Size = new System.Drawing.Size(179, 15);
            this.lblChaoMung2.TabIndex = 2;
            this.lblChaoMung2.Text = "Vui lòng đăng nhập để tiếp tục!";
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::D01_TranTuyetNhu.Properties.Resources.system_bg;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.lblChaoMung2);
            this.Controls.Add(this.lblChaoMung1);
            this.Controls.Add(this.mnsHeThong);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsHeThong;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý bán xe";
            this.Load += new System.EventHandler(this.FormSystem_Load);
            this.mnsHeThong.ResumeLayout(false);
            this.mnsHeThong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangNhap;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmiChucNang;
        private System.Windows.Forms.ToolStripMenuItem tsmiXe;
        private System.Windows.Forms.ToolStripMenuItem tsmiSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiTroGiup;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongTin;
        private System.Windows.Forms.Label lblChaoMung1;
        private System.Windows.Forms.Label lblChaoMung2;
    }
}

