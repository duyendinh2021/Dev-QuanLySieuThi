namespace GUI.Forms
{
    partial class FormThemNhanVien
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grBThongtin = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.ptbShowImage = new System.Windows.Forms.PictureBox();
            this.panDash6 = new System.Windows.Forms.Panel();
            this.panDash7 = new System.Windows.Forms.Panel();
            this.panDash5 = new System.Windows.Forms.Panel();
            this.panDash4 = new System.Windows.Forms.Panel();
            this.panDash3 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panDash2 = new System.Windows.Forms.Panel();
            this.panDash1 = new System.Windows.Forms.Panel();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenNganHang = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSoNganHang = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblSoTK = new System.Windows.Forms.Label();
            this.lblTenNganHang = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.panHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grBThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1285, 55);
            this.panHeader.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 50;
            this.btnExit.Location = new System.Drawing.Point(1210, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.grBThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 636);
            this.panel1.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnClear.Image = global::GUI.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(412, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 64);
            this.btnClear.TabIndex = 2;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnConfirm.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfirm.Location = new System.Drawing.Point(79, 538);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(153, 64);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grBThongtin
            // 
            this.grBThongtin.Controls.Add(this.btnImage);
            this.grBThongtin.Controls.Add(this.ptbShowImage);
            this.grBThongtin.Controls.Add(this.panDash6);
            this.grBThongtin.Controls.Add(this.panDash7);
            this.grBThongtin.Controls.Add(this.panDash5);
            this.grBThongtin.Controls.Add(this.panDash4);
            this.grBThongtin.Controls.Add(this.panDash3);
            this.grBThongtin.Controls.Add(this.txtHoTen);
            this.grBThongtin.Controls.Add(this.panDash2);
            this.grBThongtin.Controls.Add(this.panDash1);
            this.grBThongtin.Controls.Add(this.cmbGioiTinh);
            this.grBThongtin.Controls.Add(this.cmbChucvu);
            this.grBThongtin.Controls.Add(this.dtpNgayVaoLam);
            this.grBThongtin.Controls.Add(this.dtpNgaySinh);
            this.grBThongtin.Controls.Add(this.txtLuong);
            this.grBThongtin.Controls.Add(this.txtSDT);
            this.grBThongtin.Controls.Add(this.txtEmail);
            this.grBThongtin.Controls.Add(this.txtTenNganHang);
            this.grBThongtin.Controls.Add(this.txtDiachi);
            this.grBThongtin.Controls.Add(this.txtSoNganHang);
            this.grBThongtin.Controls.Add(this.lblGioiTinh);
            this.grBThongtin.Controls.Add(this.lblHoten);
            this.grBThongtin.Controls.Add(this.lblChucvu);
            this.grBThongtin.Controls.Add(this.lblSoTK);
            this.grBThongtin.Controls.Add(this.lblTenNganHang);
            this.grBThongtin.Controls.Add(this.lblDiachi);
            this.grBThongtin.Controls.Add(this.lblEmail);
            this.grBThongtin.Controls.Add(this.lblLuong);
            this.grBThongtin.Controls.Add(this.lblSDT);
            this.grBThongtin.Controls.Add(this.lblNgayVaoLam);
            this.grBThongtin.Controls.Add(this.lblNgaySinh);
            this.grBThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBThongtin.Location = new System.Drawing.Point(0, 0);
            this.grBThongtin.Name = "grBThongtin";
            this.grBThongtin.Size = new System.Drawing.Size(1285, 512);
            this.grBThongtin.TabIndex = 0;
            this.grBThongtin.TabStop = false;
            this.grBThongtin.Text = "Thông tin nhân viên";
            this.grBThongtin.Enter += new System.EventHandler(this.grBThongtin_Enter);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnImage.Image = global::GUI.Properties.Resources.photo;
            this.btnImage.Location = new System.Drawing.Point(1045, 109);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(146, 45);
            this.btnImage.TabIndex = 11;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // ptbShowImage
            // 
            this.ptbShowImage.Location = new System.Drawing.Point(1045, 179);
            this.ptbShowImage.Name = "ptbShowImage";
            this.ptbShowImage.Size = new System.Drawing.Size(216, 216);
            this.ptbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbShowImage.TabIndex = 44;
            this.ptbShowImage.TabStop = false;
            // 
            // panDash6
            // 
            this.panDash6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash6.Location = new System.Drawing.Point(728, 163);
            this.panDash6.Name = "panDash6";
            this.panDash6.Size = new System.Drawing.Size(207, 2);
            this.panDash6.TabIndex = 43;
            // 
            // panDash7
            // 
            this.panDash7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash7.Location = new System.Drawing.Point(728, 212);
            this.panDash7.Name = "panDash7";
            this.panDash7.Size = new System.Drawing.Size(207, 2);
            this.panDash7.TabIndex = 42;
            // 
            // panDash5
            // 
            this.panDash5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash5.Location = new System.Drawing.Point(728, 113);
            this.panDash5.Name = "panDash5";
            this.panDash5.Size = new System.Drawing.Size(207, 2);
            this.panDash5.TabIndex = 41;
            // 
            // panDash4
            // 
            this.panDash4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash4.Location = new System.Drawing.Point(231, 253);
            this.panDash4.Name = "panDash4";
            this.panDash4.Size = new System.Drawing.Size(207, 2);
            this.panDash4.TabIndex = 40;
            // 
            // panDash3
            // 
            this.panDash3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash3.Location = new System.Drawing.Point(231, 204);
            this.panDash3.Name = "panDash3";
            this.panDash3.Size = new System.Drawing.Size(207, 2);
            this.panDash3.TabIndex = 39;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Location = new System.Drawing.Point(233, 90);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 15);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // panDash2
            // 
            this.panDash2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash2.Location = new System.Drawing.Point(231, 155);
            this.panDash2.Name = "panDash2";
            this.panDash2.Size = new System.Drawing.Size(207, 2);
            this.panDash2.TabIndex = 38;
            // 
            // panDash1
            // 
            this.panDash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panDash1.Location = new System.Drawing.Point(231, 109);
            this.panDash1.Name = "panDash1";
            this.panDash1.Size = new System.Drawing.Size(207, 2);
            this.panDash1.TabIndex = 36;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(728, 308);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cmbGioiTinh.TabIndex = 10;
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Stoker"});
            this.cmbChucvu.Location = new System.Drawing.Point(728, 253);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(121, 24);
            this.cmbChucvu.TabIndex = 9;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(231, 343);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(207, 22);
            this.dtpNgayVaoLam.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(231, 288);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgaySinh.Size = new System.Drawing.Size(207, 22);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuong.Location = new System.Drawing.Point(234, 235);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(207, 15);
            this.txtLuong.TabIndex = 3;
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Location = new System.Drawing.Point(235, 185);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(207, 15);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(234, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 15);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtTenNganHang
            // 
            this.txtTenNganHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTenNganHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNganHang.Location = new System.Drawing.Point(731, 144);
            this.txtTenNganHang.Name = "txtTenNganHang";
            this.txtTenNganHang.Size = new System.Drawing.Size(207, 15);
            this.txtTenNganHang.TabIndex = 7;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiachi.Location = new System.Drawing.Point(730, 192);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(207, 15);
            this.txtDiachi.TabIndex = 8;
            this.txtDiachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiachi_KeyPress);
            // 
            // txtSoNganHang
            // 
            this.txtSoNganHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSoNganHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoNganHang.Location = new System.Drawing.Point(731, 93);
            this.txtSoNganHang.Name = "txtSoNganHang";
            this.txtSoNganHang.Size = new System.Drawing.Size(207, 15);
            this.txtSoNganHang.TabIndex = 6;
            this.txtSoNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNganHang_KeyPress);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(513, 300);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(175, 30);
            this.lblGioiTinh.TabIndex = 24;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblHoten
            // 
            this.lblHoten.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(46, 85);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(140, 30);
            this.lblHoten.TabIndex = 23;
            this.lblHoten.Text = "Họ tên";
            this.lblHoten.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblChucvu
            // 
            this.lblChucvu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.Location = new System.Drawing.Point(513, 245);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(175, 30);
            this.lblChucvu.TabIndex = 22;
            this.lblChucvu.Text = "Chức vụ";
            this.lblChucvu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSoTK
            // 
            this.lblSoTK.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTK.Location = new System.Drawing.Point(513, 85);
            this.lblSoTK.Name = "lblSoTK";
            this.lblSoTK.Size = new System.Drawing.Size(175, 30);
            this.lblSoTK.TabIndex = 21;
            this.lblSoTK.Text = "Số ngân hàng";
            this.lblSoTK.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTenNganHang
            // 
            this.lblTenNganHang.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNganHang.Location = new System.Drawing.Point(513, 141);
            this.lblTenNganHang.Name = "lblTenNganHang";
            this.lblTenNganHang.Size = new System.Drawing.Size(175, 30);
            this.lblTenNganHang.TabIndex = 20;
            this.lblTenNganHang.Text = "Tên ngân hàng";
            this.lblTenNganHang.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDiachi
            // 
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(513, 187);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(175, 30);
            this.lblDiachi.TabIndex = 19;
            this.lblDiachi.Text = "Địa chỉ";
            this.lblDiachi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(46, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(140, 30);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLuong
            // 
            this.lblLuong.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(46, 225);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(140, 30);
            this.lblLuong.TabIndex = 17;
            this.lblLuong.Text = "Lương";
            this.lblLuong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(46, 184);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(140, 30);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVaoLam.Location = new System.Drawing.Point(46, 335);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(140, 30);
            this.lblNgayVaoLam.TabIndex = 26;
            this.lblNgayVaoLam.Text = "Ngày vào làm";
            this.lblNgayVaoLam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(46, 280);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(140, 30);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemNhanVien";
            this.Load += new System.EventHandler(this.FormThemNhanVien_Load);
            this.panHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grBThongtin.ResumeLayout(false);
            this.grBThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grBThongtin;
        private System.Windows.Forms.PictureBox ptbShowImage;
        private System.Windows.Forms.Panel panDash6;
        private System.Windows.Forms.Panel panDash7;
        private System.Windows.Forms.Panel panDash5;
        private System.Windows.Forms.Panel panDash4;
        private System.Windows.Forms.Panel panDash3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Panel panDash2;
        private System.Windows.Forms.Panel panDash1;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNganHang;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSoNganHang;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblSoTK;
        private System.Windows.Forms.Label lblTenNganHang;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnImage;
    }
}