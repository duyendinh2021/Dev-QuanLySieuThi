namespace GUI.Forms.HoaDon
{
    partial class FormEditChiTietHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditChiTietHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachChiTietHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtIDSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnViewSanPham = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtSlTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkLoiKT = new System.Windows.Forms.CheckBox();
            this.chkBinhThuong = new System.Windows.Forms.CheckBox();
            this.ID_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachChiTietHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 453);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1464, 304);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết Hoá Đơn Kho";
            // 
            // dgvDanhSachChiTietHD
            // 
            this.dgvDanhSachChiTietHD.AllowUserToAddRows = false;
            this.dgvDanhSachChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachChiTietHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvDanhSachChiTietHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachChiTietHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachChiTietHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachChiTietHD.ColumnHeadersHeight = 40;
            this.dgvDanhSachChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SanPham,
            this.ChietKhau,
            this.SL,
            this.SlTra,
            this.DonGia,
            this.GhiChu,
            this.TrangThai,
            this.TinhTrang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachChiTietHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachChiTietHD.EnableHeadersVisualStyles = false;
            this.dgvDanhSachChiTietHD.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachChiTietHD.Name = "dgvDanhSachChiTietHD";
            this.dgvDanhSachChiTietHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachChiTietHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachChiTietHD.RowHeadersVisible = false;
            this.dgvDanhSachChiTietHD.RowHeadersWidth = 80;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachChiTietHD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachChiTietHD.RowTemplate.Height = 50;
            this.dgvDanhSachChiTietHD.Size = new System.Drawing.Size(1458, 283);
            this.dgvDanhSachChiTietHD.TabIndex = 31;
            this.dgvDanhSachChiTietHD.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachChiTietHD_CellMouseClick);
            this.dgvDanhSachChiTietHD.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChiTietHD_CellValueChanged);
            this.dgvDanhSachChiTietHD.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDanhSachChiTietHD_CurrentCellDirtyStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(1035, 44);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(240, 27);
            this.txtSL.TabIndex = 20;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChietKhau.Location = new System.Drawing.Point(345, 121);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.ReadOnly = true;
            this.txtChietKhau.Size = new System.Drawing.Size(261, 27);
            this.txtChietKhau.TabIndex = 21;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(1035, 153);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(240, 27);
            this.txtDonGia.TabIndex = 22;
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSanPham.Location = new System.Drawing.Point(345, 42);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.ReadOnly = true;
            this.txtIDSanPham.Size = new System.Drawing.Size(261, 27);
            this.txtIDSanPham.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Số Lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đơn Giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "% Chiết Khấu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnViewSanPham
            // 
            this.btnViewSanPham.Image = global::GUI.Properties.Resources.eye;
            this.btnViewSanPham.Location = new System.Drawing.Point(630, 31);
            this.btnViewSanPham.Name = "btnViewSanPham";
            this.btnViewSanPham.Size = new System.Drawing.Size(83, 40);
            this.btnViewSanPham.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnViewSanPham, "Nhấn Dể Xem Chi Tiết Sản Phẩm");
            this.btnViewSanPham.UseVisualStyleBackColor = true;
            this.btnViewSanPham.Click += new System.EventHandler(this.btnViewSanPham_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::GUI.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(280, 320);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 78);
            this.btnEdit.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnEdit, "Click dể có thể sửa hóa đơn");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::GUI.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(786, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 78);
            this.btnSave.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnSave, "Click Dể Tiến Hành Lưu Hóa Đơn");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfirm.Location = new System.Drawing.Point(548, 320);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 78);
            this.btnConfirm.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnConfirm, "Click Dể Xác Nhận Cập Nhật Hóa Đơn");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.Enabled = false;
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(345, 208);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(261, 24);
            this.cmbTrangThai.TabIndex = 24;
            this.toolTip1.SetToolTip(this.cmbTrangThai, "Ghi Chú 1 = Chưa Xoá\r\n              0 = Đã Xoá\r\n");
            this.cmbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Trạng Thái";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(751, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ghi Chú";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(1035, 209);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(240, 27);
            this.txtGhiChu.TabIndex = 21;
            // 
            // txtSlTra
            // 
            this.txtSlTra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlTra.Location = new System.Drawing.Point(1035, 97);
            this.txtSlTra.Name = "txtSlTra";
            this.txtSlTra.ReadOnly = true;
            this.txtSlTra.Size = new System.Drawing.Size(240, 27);
            this.txtSlTra.TabIndex = 28;
            this.txtSlTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSlTra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(751, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Số Lượng Trả Nếu Có";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkLoiKT
            // 
            this.chkLoiKT.AutoSize = true;
            this.chkLoiKT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoiKT.Location = new System.Drawing.Point(1035, 274);
            this.chkLoiKT.Name = "chkLoiKT";
            this.chkLoiKT.Size = new System.Drawing.Size(263, 27);
            this.chkLoiKT.TabIndex = 29;
            this.chkLoiKT.Text = "Sản Phẩm Lỗi Ký Thuật";
            this.chkLoiKT.UseVisualStyleBackColor = true;
            this.chkLoiKT.CheckedChanged += new System.EventHandler(this.chkLoiKT_CheckedChanged);
            // 
            // chkBinhThuong
            // 
            this.chkBinhThuong.AutoSize = true;
            this.chkBinhThuong.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBinhThuong.Location = new System.Drawing.Point(1035, 331);
            this.chkBinhThuong.Name = "chkBinhThuong";
            this.chkBinhThuong.Size = new System.Drawing.Size(252, 27);
            this.chkBinhThuong.TabIndex = 29;
            this.chkBinhThuong.Text = "Sản Phẩm Bình Thường";
            this.chkBinhThuong.UseVisualStyleBackColor = true;
            this.chkBinhThuong.CheckedChanged += new System.EventHandler(this.chkBinhThuong_CheckedChanged);
            // 
            // ID_SanPham
            // 
            this.ID_SanPham.DataPropertyName = "Idsp";
            this.ID_SanPham.HeaderText = "ID Sản Phẩm";
            this.ID_SanPham.MinimumWidth = 6;
            this.ID_SanPham.Name = "ID_SanPham";
            // 
            // ChietKhau
            // 
            this.ChietKhau.DataPropertyName = "Chietkhau";
            this.ChietKhau.HeaderText = "Chiết Khấu";
            this.ChietKhau.MinimumWidth = 6;
            this.ChietKhau.Name = "ChietKhau";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "Sl";
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // SlTra
            // 
            this.SlTra.DataPropertyName = "Sl_tra";
            this.SlTra.HeaderText = "Số Lượng Trả";
            this.SlTra.MinimumWidth = 6;
            this.SlTra.Name = "SlTra";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "Dongia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "Ghichu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Trangthai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = false;
            // 
            // FormEditChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 757);
            this.Controls.Add(this.chkBinhThuong);
            this.Controls.Add(this.chkLoiKT);
            this.Controls.Add(this.txtSlTra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnViewSanPham);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtChietKhau);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtIDSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditChiTietHoaDon";
            this.Text = "Edit Chi Tiêt Hoá Đơn";
            this.Load += new System.EventHandler(this.FormEditChiTietHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTietHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtIDSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnViewSanPham;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSlTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkLoiKT;
        private System.Windows.Forms.CheckBox chkBinhThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}