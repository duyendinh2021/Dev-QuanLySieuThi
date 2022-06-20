namespace GUI.Forms
{
    partial class FormCapNhatNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatNhanVien));
            this.ptbShowImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new FontAwesome.Sharp.IconButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
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
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grBThongtin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNganHang = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.grBThongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbShowImage
            // 
            this.ptbShowImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbShowImage.Location = new System.Drawing.Point(3, 18);
            this.ptbShowImage.Name = "ptbShowImage";
            this.ptbShowImage.Size = new System.Drawing.Size(257, 289);
            this.ptbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbShowImage.TabIndex = 44;
            this.ptbShowImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImage.FlatAppearance.BorderSize = 2;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnImage.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnImage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImage.IconSize = 32;
            this.btnImage.Location = new System.Drawing.Point(1259, 81);
            this.btnImage.Name = "btnImage";
            this.btnImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImage.Size = new System.Drawing.Size(95, 43);
            this.btnImage.TabIndex = 11;
            this.btnImage.Text = "...";
            this.btnImage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(305, 81);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 27);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(913, 347);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(207, 24);
            this.cmbGioiTinh.TabIndex = 10;
            this.cmbGioiTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGioiTinh_KeyDown);
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucvu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "Stoker"});
            this.cmbChucvu.Location = new System.Drawing.Point(913, 280);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(207, 24);
            this.cmbChucvu.TabIndex = 9;
            this.cmbChucvu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbChucvu_KeyDown);
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(305, 416);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(207, 22);
            this.dtpNgayVaoLam.TabIndex = 5;
            this.dtpNgayVaoLam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNgayVaoLam_KeyDown);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(305, 349);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgaySinh.Size = new System.Drawing.Size(207, 22);
            this.dtpNgaySinh.TabIndex = 4;
            this.dtpNgaySinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpNgaySinh_KeyDown);
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuong.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(305, 277);
            this.txtLuong.MaxLength = 255;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(208, 27);
            this.txtLuong.TabIndex = 3;
            this.txtLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLuong_KeyDown);
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(305, 215);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(207, 27);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(305, 148);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtSoNganHang
            // 
            this.txtSoNganHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSoNganHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoNganHang.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNganHang.Location = new System.Drawing.Point(913, 81);
            this.txtSoNganHang.MaxLength = 15;
            this.txtSoNganHang.Name = "txtSoNganHang";
            this.txtSoNganHang.Size = new System.Drawing.Size(207, 27);
            this.txtSoNganHang.TabIndex = 6;
            this.txtSoNganHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoNganHang_KeyDown);
            this.txtSoNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNganHang_KeyPress);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(677, 346);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(209, 25);
            this.lblGioiTinh.TabIndex = 24;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblHoten
            // 
            this.lblHoten.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(95, 88);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(194, 20);
            this.lblHoten.TabIndex = 23;
            this.lblHoten.Text = "Họ tên";
            this.lblHoten.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblChucvu
            // 
            this.lblChucvu.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.Location = new System.Drawing.Point(677, 279);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(209, 25);
            this.lblChucvu.TabIndex = 22;
            this.lblChucvu.Text = "Chức vụ";
            this.lblChucvu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSoTK
            // 
            this.lblSoTK.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTK.Location = new System.Drawing.Point(677, 83);
            this.lblSoTK.Name = "lblSoTK";
            this.lblSoTK.Size = new System.Drawing.Size(209, 25);
            this.lblSoTK.TabIndex = 21;
            this.lblSoTK.Text = "Số ngân hàng";
            this.lblSoTK.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTenNganHang
            // 
            this.lblTenNganHang.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNganHang.Location = new System.Drawing.Point(677, 150);
            this.lblTenNganHang.Name = "lblTenNganHang";
            this.lblTenNganHang.Size = new System.Drawing.Size(209, 25);
            this.lblTenNganHang.TabIndex = 20;
            this.lblTenNganHang.Text = "Tên ngân hàng";
            this.lblTenNganHang.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDiachi
            // 
            this.lblDiachi.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(677, 217);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(209, 25);
            this.lblDiachi.TabIndex = 19;
            this.lblDiachi.Text = "Địa Chỉ\r\n";
            this.lblDiachi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(95, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(194, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLuong
            // 
            this.lblLuong.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(95, 284);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(194, 20);
            this.lblLuong.TabIndex = 17;
            this.lblLuong.Text = "Lương Cơ Bản";
            this.lblLuong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSDT
            // 
            this.lblSDT.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(95, 222);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(194, 20);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVaoLam.Location = new System.Drawing.Point(95, 418);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(194, 20);
            this.lblNgayVaoLam.TabIndex = 26;
            this.lblNgayVaoLam.Text = "Ngày vào làm";
            this.lblNgayVaoLam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(95, 351);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(194, 20);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(651, 575);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 53);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Xóa tất cả";
            this.toolTip1.SetToolTip(this.btnClear, "Click nếu muốn xóa tất cả");
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfirm.IconColor = System.Drawing.Color.Black;
            this.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirm.Location = new System.Drawing.Point(305, 575);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(152, 53);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Xác nhận";
            this.toolTip1.SetToolTip(this.btnConfirm, "Click Dể Xác Nhân Và Tiến Hành Cập Nhật");
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.grBThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 668);
            this.panel1.TabIndex = 9;
            // 
            // grBThongtin
            // 
            this.grBThongtin.Controls.Add(this.groupBox1);
            this.grBThongtin.Controls.Add(this.label1);
            this.grBThongtin.Controls.Add(this.btnImage);
            this.grBThongtin.Controls.Add(this.txtHoTen);
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
            this.grBThongtin.Size = new System.Drawing.Size(1600, 529);
            this.grBThongtin.TabIndex = 1;
            this.grBThongtin.TabStop = false;
            this.grBThongtin.Text = "Thông tin nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbShowImage);
            this.groupBox1.Location = new System.Drawing.Point(1259, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 310);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh Nhân Viên";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Chỉ Cập Nhật Lương Cơ Bản";
            // 
            // txtTenNganHang
            // 
            this.txtTenNganHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTenNganHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNganHang.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganHang.Location = new System.Drawing.Point(913, 148);
            this.txtTenNganHang.MaxLength = 50;
            this.txtTenNganHang.Name = "txtTenNganHang";
            this.txtTenNganHang.Size = new System.Drawing.Size(207, 27);
            this.txtTenNganHang.TabIndex = 7;
            this.txtTenNganHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNganHang_KeyDown);
            this.txtTenNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNganHang_KeyPress);
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiachi.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(913, 215);
            this.txtDiachi.MaxLength = 255;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(207, 27);
            this.txtDiachi.TabIndex = 8;
            this.txtDiachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiachi_KeyDown);
            this.txtDiachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiachi_KeyPress);
            // 
            // FormCapNhatNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 668);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapNhatNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCapNhatNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormCapNhatNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grBThongtin.ResumeLayout(false);
            this.grBThongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ptbShowImage;
        public FontAwesome.Sharp.IconButton btnImage;
        public System.Windows.Forms.TextBox txtHoTen;
        public System.Windows.Forms.ComboBox cmbGioiTinh;
        public System.Windows.Forms.ComboBox cmbChucvu;
        public System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        public System.Windows.Forms.DateTimePicker dtpNgaySinh;
        public System.Windows.Forms.TextBox txtLuong;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtSoNganHang;
        public System.Windows.Forms.Label lblGioiTinh;
        public System.Windows.Forms.Label lblHoten;
        public System.Windows.Forms.Label lblChucvu;
        public System.Windows.Forms.Label lblSoTK;
        public System.Windows.Forms.Label lblTenNganHang;
        public System.Windows.Forms.Label lblDiachi;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblLuong;
        public System.Windows.Forms.Label lblSDT;
        public System.Windows.Forms.Label lblNgayVaoLam;
        public System.Windows.Forms.Label lblNgaySinh;
        public FontAwesome.Sharp.IconButton btnClear;
        public FontAwesome.Sharp.IconButton btnConfirm;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox grBThongtin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTenNganHang;
        public System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}