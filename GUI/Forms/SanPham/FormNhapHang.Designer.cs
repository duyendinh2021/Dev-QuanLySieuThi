namespace GUI.Forms.SanPham
{
    partial class FormNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapHang));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbDSNhapHang = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearDS = new System.Windows.Forms.Button();
            this.btnHangMoi = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.grbDSHangHoa = new System.Windows.Forms.GroupBox();
            this.dtgDSHangHoa = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbDSNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbDSHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.cmbNCC);
            this.splitContainer1.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.cmbLoaiSP);
            this.splitContainer1.Panel2.Controls.Add(this.grbDSHangHoa);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1837, 756);
            this.splitContainer1.SplitterDistance = 651;
            this.splitContainer1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbDSNhapHang);
            this.panel3.Controls.Add(this.txtTongGia);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 480);
            this.panel3.TabIndex = 4;
            // 
            // grbDSNhapHang
            // 
            this.grbDSNhapHang.Controls.Add(this.dgvHoaDonNhap);
            this.grbDSNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDSNhapHang.Location = new System.Drawing.Point(0, 0);
            this.grbDSNhapHang.Name = "grbDSNhapHang";
            this.grbDSNhapHang.Size = new System.Drawing.Size(651, 418);
            this.grbDSNhapHang.TabIndex = 1;
            this.grbDSNhapHang.TabStop = false;
            this.grbDSNhapHang.Text = "Danh Sách Hàng Nhập";
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.AllowUserToAddRows = false;
            this.dgvHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHoaDonNhap.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDonNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDonNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonNhap.ColumnHeadersHeight = 40;
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.QTY,
            this.COST,
            this.ID,
            this.Delete});
            this.dgvHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonNhap.EnableHeadersVisualStyles = false;
            this.dgvHoaDonNhap.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(3, 18);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.RowHeadersWidth = 40;
            this.dgvHoaDonNhap.RowTemplate.Height = 20;
            this.dgvHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(645, 397);
            this.dgvHoaDonNhap.TabIndex = 12;
            this.dgvHoaDonNhap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoaDonNhap_CellMouseClick);
            this.dgvHoaDonNhap.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoaDonNhap_CellMouseDoubleClick);
            this.dgvHoaDonNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellValueChanged);
            this.dgvHoaDonNhap.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvHoaDonNhap_EditingControlShowing);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.FillWeight = 96.9697F;
            this.Item.HeaderText = "SẢN PHẨM";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.FillWeight = 96.9697F;
            this.QTY.HeaderText = "SỐ LƯỢNG";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            // 
            // COST
            // 
            this.COST.DataPropertyName = "COST";
            this.COST.FillWeight = 96.9697F;
            this.COST.HeaderText = "GIÁ";
            this.COST.MinimumWidth = 6;
            this.COST.Name = "COST";
            this.COST.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "";
            this.Delete.Image = global::GUI.Properties.Resources.delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(266, 441);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(242, 22);
            this.txtTongGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng Giá Trị";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearDS);
            this.panel2.Controls.Add(this.btnHangMoi);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 639);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 117);
            this.panel2.TabIndex = 0;
            // 
            // btnClearDS
            // 
            this.btnClearDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnClearDS.Image = global::GUI.Properties.Resources.clear;
            this.btnClearDS.Location = new System.Drawing.Point(470, 24);
            this.btnClearDS.Name = "btnClearDS";
            this.btnClearDS.Size = new System.Drawing.Size(147, 58);
            this.btnClearDS.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnClearDS, "Nhấn Xóa Danh Sách Hàng Nhập");
            this.btnClearDS.UseVisualStyleBackColor = false;
            this.btnClearDS.Click += new System.EventHandler(this.btnClearDS_Click);
            // 
            // btnHangMoi
            // 
            this.btnHangMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnHangMoi.Image = global::GUI.Properties.Resources.add;
            this.btnHangMoi.Location = new System.Drawing.Point(266, 24);
            this.btnHangMoi.Name = "btnHangMoi";
            this.btnHangMoi.Size = new System.Drawing.Size(147, 58);
            this.btnHangMoi.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnHangMoi, "Nhấn Thêm Sản Phẩm Mới");
            this.btnHangMoi.UseVisualStyleBackColor = false;
            this.btnHangMoi.Click += new System.EventHandler(this.btnHangMoi_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnConfirm.Image = global::GUI.Properties.Resources.add_Hang;
            this.btnConfirm.Location = new System.Drawing.Point(52, 24);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(147, 58);
            this.btnConfirm.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnConfirm, "Nhấn Tạo Phiếu Nhập Kho");
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhà Cung Cấp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbNCC
            // 
            this.cmbNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(658, 68);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(205, 24);
            this.cmbNCC.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cmbNCC, "Click Nếu Muốn Lọc Theo Nhà Cung Cấp");
            this.cmbNCC.SelectedIndexChanged += new System.EventHandler(this.cmbNCC_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::GUI.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(925, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 49);
            this.btnRefresh.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRefresh, "Click Dể Refresh");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(187, 65);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(256, 24);
            this.cmbLoaiSP.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbLoaiSP, "Click Nếu Muốn Lọc Thể Loại Sản Phẩm");
            this.cmbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiSP_SelectedIndexChanged);
            // 
            // grbDSHangHoa
            // 
            this.grbDSHangHoa.Controls.Add(this.dtgDSHangHoa);
            this.grbDSHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDSHangHoa.Location = new System.Drawing.Point(0, 159);
            this.grbDSHangHoa.Name = "grbDSHangHoa";
            this.grbDSHangHoa.Size = new System.Drawing.Size(1182, 502);
            this.grbDSHangHoa.TabIndex = 1;
            this.grbDSHangHoa.TabStop = false;
            this.grbDSHangHoa.Text = "Danh Sách Hàng Hóa";
            // 
            // dtgDSHangHoa
            // 
            this.dtgDSHangHoa.AllowUserToAddRows = false;
            this.dtgDSHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDSHangHoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgDSHangHoa.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgDSHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDSHangHoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDSHangHoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDSHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDSHangHoa.ColumnHeadersHeight = 45;
            this.dtgDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgDSHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.ID_SP,
            this.Ten,
            this.id_ncc,
            this.id_loaisp,
            this.sl,
            this.dvt,
            this.dongia});
            this.dtgDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDSHangHoa.EnableHeadersVisualStyles = false;
            this.dtgDSHangHoa.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgDSHangHoa.Location = new System.Drawing.Point(3, 18);
            this.dtgDSHangHoa.Name = "dtgDSHangHoa";
            this.dtgDSHangHoa.ReadOnly = true;
            this.dtgDSHangHoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgDSHangHoa.RowHeadersVisible = false;
            this.dtgDSHangHoa.RowHeadersWidth = 51;
            this.dtgDSHangHoa.RowTemplate.Height = 24;
            this.dtgDSHangHoa.Size = new System.Drawing.Size(1176, 481);
            this.dtgDSHangHoa.TabIndex = 13;
            this.dtgDSHangHoa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDSHangHoa_CellMouseClick);
            // 
            // Add
            // 
            this.Add.HeaderText = "";
            this.Add.Image = global::GUI.Properties.Resources.left_arrow;
            this.Add.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            // 
            // ID_SP
            // 
            this.ID_SP.DataPropertyName = "Idsanpham";
            this.ID_SP.HeaderText = "ID Sản Phẩm";
            this.ID_SP.MinimumWidth = 6;
            this.ID_SP.Name = "ID_SP";
            this.ID_SP.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Tensanpham";
            this.Ten.HeaderText = "Tên Sản Phẩm";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // id_ncc
            // 
            this.id_ncc.DataPropertyName = "Idnhacungcap";
            this.id_ncc.HeaderText = "ID Nhà Cung Cấp";
            this.id_ncc.MinimumWidth = 6;
            this.id_ncc.Name = "id_ncc";
            this.id_ncc.ReadOnly = true;
            // 
            // id_loaisp
            // 
            this.id_loaisp.DataPropertyName = "Idloaisanpham";
            this.id_loaisp.HeaderText = "ID Loại Sản Phẩm";
            this.id_loaisp.MinimumWidth = 6;
            this.id_loaisp.Name = "id_loaisp";
            this.id_loaisp.ReadOnly = true;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Sl";
            this.sl.HeaderText = "Số Lượng Còn";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "Dvt";
            this.dvt.HeaderText = "Đơn Vị Tính";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "Dongia";
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 661);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 95);
            this.panel1.TabIndex = 0;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(293, 38);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(255, 22);
            this.txtSl.TabIndex = 1;
            this.txtSl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSl_KeyDown);
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Lượng Cần Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 165;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.left_arrow;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 146;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 756);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grbDSNhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbDSHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearDS;
        private System.Windows.Forms.Button btnHangMoi;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.GroupBox grbDSHangHoa;
        private System.Windows.Forms.DataGridView dtgDSHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbDSNhapHang;
        public System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.TextBox txtTongGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}