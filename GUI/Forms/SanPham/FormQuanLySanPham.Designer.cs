namespace GUI.Forms
{
    partial class FormQuanLySanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbXemSanPham = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dtDanhSachSP = new System.Windows.Forms.DataGridView();
            this.colbtnSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.colbtnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.id_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHangHoa = new System.Windows.Forms.Label();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.panDashside2 = new System.Windows.Forms.Panel();
            this.panTimKiem = new System.Windows.Forms.Panel();
            this.radHetHang = new System.Windows.Forms.RadioButton();
            this.radConHang = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.panTonKho = new System.Windows.Forms.Panel();
            this.radSPKhongHoat = new System.Windows.Forms.RadioButton();
            this.panSideMenu = new System.Windows.Forms.Panel();
            this.btnBrowField = new System.Windows.Forms.Button();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTonKho = new FontAwesome.Sharp.IconButton();
            this.btnLoaiHang = new FontAwesome.Sharp.IconButton();
            this.panBottom1 = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXemSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachSP)).BeginInit();
            this.panTonKho.SuspendLayout();
            this.panSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.groupBox1);
            this.panMain.Controls.Add(this.dataGridView);
            this.panMain.Controls.Add(this.dtDanhSachSP);
            this.panMain.Controls.Add(this.lblHangHoa);
            this.panMain.Controls.Add(this.btnNhapHang);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(389, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(981, 790);
            this.panMain.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbXemSanPham);
            this.groupBox1.Location = new System.Drawing.Point(671, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 245);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình Ảnh Sản Phẩm";
            // 
            // ptbXemSanPham
            // 
            this.ptbXemSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbXemSanPham.Location = new System.Drawing.Point(3, 18);
            this.ptbXemSanPham.Name = "ptbXemSanPham";
            this.ptbXemSanPham.Size = new System.Drawing.Size(209, 224);
            this.ptbXemSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbXemSanPham.TabIndex = 28;
            this.ptbXemSanPham.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(426, 64);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(10, 10);
            this.dataGridView.TabIndex = 30;
            this.dataGridView.Visible = false;
            // 
            // dtDanhSachSP
            // 
            this.dtDanhSachSP.AllowUserToAddRows = false;
            this.dtDanhSachSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.dtDanhSachSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtDanhSachSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtDanhSachSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDanhSachSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtDanhSachSP.ColumnHeadersHeight = 40;
            this.dtDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtDanhSachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbtnSua,
            this.colbtnXoa,
            this.id_sp,
            this.ten_sp,
            this.id_ncc,
            this.id_loaisp,
            this.sl,
            this.dvt,
            this.donGia});
            this.dtDanhSachSP.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDanhSachSP.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtDanhSachSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtDanhSachSP.EnableHeadersVisualStyles = false;
            this.dtDanhSachSP.Location = new System.Drawing.Point(0, 314);
            this.dtDanhSachSP.Name = "dtDanhSachSP";
            this.dtDanhSachSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDanhSachSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtDanhSachSP.RowHeadersVisible = false;
            this.dtDanhSachSP.RowHeadersWidth = 80;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDanhSachSP.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dtDanhSachSP.RowTemplate.Height = 50;
            this.dtDanhSachSP.Size = new System.Drawing.Size(981, 476);
            this.dtDanhSachSP.TabIndex = 27;
            this.dtDanhSachSP.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtDanhSachSP_CellMouseClick);
            // 
            // colbtnSua
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.colbtnSua.DefaultCellStyle = dataGridViewCellStyle10;
            this.colbtnSua.HeaderText = "";
            this.colbtnSua.Image = global::GUI.Properties.Resources.edit;
            this.colbtnSua.MinimumWidth = 6;
            this.colbtnSua.Name = "colbtnSua";
            this.colbtnSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbtnSua.ToolTipText = "Nhấn Để Tiến Hành Edit";
            this.colbtnSua.Width = 45;
            // 
            // colbtnXoa
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            this.colbtnXoa.DefaultCellStyle = dataGridViewCellStyle11;
            this.colbtnXoa.HeaderText = "";
            this.colbtnXoa.Image = global::GUI.Properties.Resources.delete;
            this.colbtnXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colbtnXoa.MinimumWidth = 6;
            this.colbtnXoa.Name = "colbtnXoa";
            this.colbtnXoa.ToolTipText = "Nhấn Dể Xóa";
            this.colbtnXoa.Width = 45;
            // 
            // id_sp
            // 
            this.id_sp.DataPropertyName = "Idsanpham";
            this.id_sp.HeaderText = "ID Sản Phẩm";
            this.id_sp.MinimumWidth = 6;
            this.id_sp.Name = "id_sp";
            this.id_sp.ReadOnly = true;
            this.id_sp.Width = 150;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "Tensanpham";
            this.ten_sp.HeaderText = "Tên Sản Phẩm";
            this.ten_sp.MinimumWidth = 6;
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.ReadOnly = true;
            this.ten_sp.Width = 150;
            // 
            // id_ncc
            // 
            this.id_ncc.DataPropertyName = "Idnhacungcap";
            this.id_ncc.HeaderText = "ID Nhà Cung Cấp";
            this.id_ncc.MinimumWidth = 6;
            this.id_ncc.Name = "id_ncc";
            this.id_ncc.ReadOnly = true;
            this.id_ncc.Visible = false;
            this.id_ncc.Width = 175;
            // 
            // id_loaisp
            // 
            this.id_loaisp.DataPropertyName = "Idloaisanpham";
            this.id_loaisp.HeaderText = "ID Loại Sản Phẩm";
            this.id_loaisp.MinimumWidth = 6;
            this.id_loaisp.Name = "id_loaisp";
            this.id_loaisp.ReadOnly = true;
            this.id_loaisp.Visible = false;
            this.id_loaisp.Width = 175;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Sl";
            this.sl.HeaderText = "Số Lượng Tồn Kho";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 200;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "Dvt";
            this.dvt.HeaderText = "Đơn Vị Tính";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 125;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "Dongia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 150;
            // 
            // lblHangHoa
            // 
            this.lblHangHoa.AutoSize = true;
            this.lblHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangHoa.Location = new System.Drawing.Point(25, 19);
            this.lblHangHoa.Name = "lblHangHoa";
            this.lblHangHoa.Size = new System.Drawing.Size(124, 29);
            this.lblHangHoa.TabIndex = 26;
            this.lblHangHoa.Text = "Hàng hóa";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhapHang.IconColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.Location = new System.Drawing.Point(51, 160);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(186, 70);
            this.btnNhapHang.TabIndex = 25;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // panDashside2
            // 
            this.panDashside2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panDashside2.Location = new System.Drawing.Point(369, 0);
            this.panDashside2.Name = "panDashside2";
            this.panDashside2.Size = new System.Drawing.Size(20, 790);
            this.panDashside2.TabIndex = 16;
            // 
            // panTimKiem
            // 
            this.panTimKiem.AutoSize = true;
            this.panTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTimKiem.Location = new System.Drawing.Point(0, 50);
            this.panTimKiem.Name = "panTimKiem";
            this.panTimKiem.Size = new System.Drawing.Size(369, 0);
            this.panTimKiem.TabIndex = 1;
            // 
            // radHetHang
            // 
            this.radHetHang.AutoSize = true;
            this.radHetHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHetHang.Location = new System.Drawing.Point(19, 102);
            this.radHetHang.Name = "radHetHang";
            this.radHetHang.Size = new System.Drawing.Size(190, 20);
            this.radHetHang.TabIndex = 0;
            this.radHetHang.TabStop = true;
            this.radHetHang.Text = "Sấp Hết hàng trong kho";
            this.radHetHang.UseVisualStyleBackColor = true;
            this.radHetHang.CheckedChanged += new System.EventHandler(this.radHetHang_CheckedChanged);
            // 
            // radConHang
            // 
            this.radConHang.AutoSize = true;
            this.radConHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radConHang.Location = new System.Drawing.Point(19, 59);
            this.radConHang.Name = "radConHang";
            this.radConHang.Size = new System.Drawing.Size(161, 20);
            this.radConHang.TabIndex = 0;
            this.radConHang.TabStop = true;
            this.radConHang.Text = "Còn hàng trong kho";
            this.radConHang.UseVisualStyleBackColor = true;
            this.radConHang.CheckedChanged += new System.EventHandler(this.radConHang_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(19, 16);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(72, 20);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "Tất cả";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // panTonKho
            // 
            this.panTonKho.AutoSize = true;
            this.panTonKho.Controls.Add(this.radSPKhongHoat);
            this.panTonKho.Controls.Add(this.radHetHang);
            this.panTonKho.Controls.Add(this.radConHang);
            this.panTonKho.Controls.Add(this.radAll);
            this.panTonKho.Location = new System.Drawing.Point(3, 518);
            this.panTonKho.Name = "panTonKho";
            this.panTonKho.Size = new System.Drawing.Size(369, 202);
            this.panTonKho.TabIndex = 7;
            // 
            // radSPKhongHoat
            // 
            this.radSPKhongHoat.AutoSize = true;
            this.radSPKhongHoat.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSPKhongHoat.Location = new System.Drawing.Point(19, 140);
            this.radSPKhongHoat.Name = "radSPKhongHoat";
            this.radSPKhongHoat.Size = new System.Drawing.Size(246, 24);
            this.radSPKhongHoat.TabIndex = 1;
            this.radSPKhongHoat.TabStop = true;
            this.radSPKhongHoat.Text = "Sản Phẩm không Hoạt Động";
            this.radSPKhongHoat.UseVisualStyleBackColor = true;
            this.radSPKhongHoat.CheckedChanged += new System.EventHandler(this.radSPKhongHoat_CheckedChanged);
            // 
            // panSideMenu
            // 
            this.panSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.panSideMenu.Controls.Add(this.btnBrowField);
            this.panSideMenu.Controls.Add(this.flpCategory);
            this.panSideMenu.Controls.Add(this.panTonKho);
            this.panSideMenu.Controls.Add(this.btnTonKho);
            this.panSideMenu.Controls.Add(this.btnLoaiHang);
            this.panSideMenu.Controls.Add(this.panBottom1);
            this.panSideMenu.Controls.Add(this.panTimKiem);
            this.panSideMenu.Controls.Add(this.btnSearch);
            this.panSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panSideMenu.Name = "panSideMenu";
            this.panSideMenu.Size = new System.Drawing.Size(369, 790);
            this.panSideMenu.TabIndex = 15;
            // 
            // btnBrowField
            // 
            this.btnBrowField.Image = global::GUI.Properties.Resources.search;
            this.btnBrowField.Location = new System.Drawing.Point(46, 374);
            this.btnBrowField.Name = "btnBrowField";
            this.btnBrowField.Size = new System.Drawing.Size(257, 67);
            this.btnBrowField.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBrowField, "Click Dể Tìm Theo Loại Sản Phẩm");
            this.btnBrowField.UseVisualStyleBackColor = true;
            this.btnBrowField.Click += new System.EventHandler(this.btnBrowField_Click);
            // 
            // flpCategory
            // 
            this.flpCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategory.Location = new System.Drawing.Point(0, 128);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(369, 240);
            this.flpCategory.TabIndex = 8;
            // 
            // btnTonKho
            // 
            this.btnTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnTonKho.FlatAppearance.BorderSize = 0;
            this.btnTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTonKho.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTonKho.IconChar = FontAwesome.Sharp.IconChar.CaretUp;
            this.btnTonKho.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTonKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTonKho.Location = new System.Drawing.Point(3, 462);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(369, 50);
            this.btnTonKho.TabIndex = 6;
            this.btnTonKho.Text = "Tồn kho";
            this.btnTonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTonKho.UseVisualStyleBackColor = false;
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnLoaiHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiHang.FlatAppearance.BorderSize = 0;
            this.btnLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiHang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoaiHang.IconChar = FontAwesome.Sharp.IconChar.CaretUp;
            this.btnLoaiHang.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoaiHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoaiHang.Location = new System.Drawing.Point(0, 64);
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.Size = new System.Drawing.Size(369, 64);
            this.btnLoaiHang.TabIndex = 3;
            this.btnLoaiHang.Text = "Loại hàng";
            this.btnLoaiHang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLoaiHang.UseVisualStyleBackColor = false;
            // 
            // panBottom1
            // 
            this.panBottom1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBottom1.Location = new System.Drawing.Point(0, 50);
            this.panBottom1.Name = "panBottom1";
            this.panBottom1.Size = new System.Drawing.Size(369, 14);
            this.panBottom1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(369, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.edit;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Nhấn Để Tiến Hành Edit";
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle16.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle16.NullValue")));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Nhấn Dể Xóa";
            this.dataGridViewImageColumn2.Width = 45;
            // 
            // FormQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 790);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panDashside2);
            this.Controls.Add(this.panSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLySanPham";
            this.Text = "FormQuanLySanPham";
            this.Load += new System.EventHandler(this.FormQuanLySanPham_Load);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbXemSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDanhSachSP)).EndInit();
            this.panTonKho.ResumeLayout(false);
            this.panTonKho.PerformLayout();
            this.panSideMenu.ResumeLayout(false);
            this.panSideMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.PictureBox ptbXemSanPham;
        private System.Windows.Forms.DataGridView dtDanhSachSP;
        private System.Windows.Forms.Label lblHangHoa;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private System.Windows.Forms.Panel panDashside2;
        private System.Windows.Forms.Panel panTimKiem;
        private FontAwesome.Sharp.IconButton btnTonKho;
        private System.Windows.Forms.RadioButton radHetHang;
        private System.Windows.Forms.RadioButton radConHang;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Panel panTonKho;
        private System.Windows.Forms.Panel panSideMenu;
        private FontAwesome.Sharp.IconButton btnLoaiHang;
        private System.Windows.Forms.Panel panBottom1;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnBrowField;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn colbtnSua;
        private System.Windows.Forms.DataGridViewImageColumn colbtnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.RadioButton radSPKhongHoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}