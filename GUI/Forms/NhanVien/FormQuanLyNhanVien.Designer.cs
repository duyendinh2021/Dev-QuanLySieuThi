﻿namespace GUI
{
    partial class FormQuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.panelTimkiem = new System.Windows.Forms.Panel();
            this.txtSeacrch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGVDanhSachNV = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnXemAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.colManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.picBoxImg = new System.Windows.Forms.PictureBox();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDanhSachNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(492, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chức vụ";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(646, 23);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(220, 24);
            this.cmbTrangThai.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbTrangThai, "Click Dể Tiến Hành Lọc");
            this.cmbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThai_SelectedIndexChanged);
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Location = new System.Drawing.Point(180, 23);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(170, 24);
            this.cmbChucvu.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbChucvu, "Click Dể Tiến Hành Lọc");
            this.cmbChucvu.SelectedIndexChanged += new System.EventHandler(this.cmbChucvu_SelectedIndexChanged);
            // 
            // panelTimkiem
            // 
            this.panelTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTimkiem.Controls.Add(this.txtSeacrch);
            this.panelTimkiem.Controls.Add(this.label1);
            this.panelTimkiem.Controls.Add(this.label3);
            this.panelTimkiem.Controls.Add(this.label2);
            this.panelTimkiem.Controls.Add(this.cmbTrangThai);
            this.panelTimkiem.Controls.Add(this.cmbChucvu);
            this.panelTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimkiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTimkiem.Location = new System.Drawing.Point(0, 0);
            this.panelTimkiem.Name = "panelTimkiem";
            this.panelTimkiem.Size = new System.Drawing.Size(1448, 65);
            this.panelTimkiem.TabIndex = 0;
            // 
            // txtSeacrch
            // 
            this.txtSeacrch.Location = new System.Drawing.Point(1150, 24);
            this.txtSeacrch.Name = "txtSeacrch";
            this.txtSeacrch.Size = new System.Drawing.Size(286, 22);
            this.txtSeacrch.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtSeacrch, "Nhập Dể Tiến Hành Tiền Kiếm");
            this.txtSeacrch.TextChanged += new System.EventHandler(this.txtSeacrch__TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1037, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm Kiếm";
            // 
            // dtGVDanhSachNV
            // 
            this.dtGVDanhSachNV.AllowUserToAddRows = false;
            this.dtGVDanhSachNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dtGVDanhSachNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVDanhSachNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVDanhSachNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtGVDanhSachNV.ColumnHeadersHeight = 40;
            this.dtGVDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGVDanhSachNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSua,
            this.btnXoa,
            this.btnXemAcc,
            this.colManv,
            this.colTennv,
            this.colTentk,
            this.colSDT,
            this.colNgaysinh,
            this.colDiachi,
            this.colChucVu,
            this.colGioiTinh,
            this.colLuong});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVDanhSachNV.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtGVDanhSachNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVDanhSachNV.EnableHeadersVisualStyles = false;
            this.dtGVDanhSachNV.Location = new System.Drawing.Point(0, 296);
            this.dtGVDanhSachNV.Name = "dtGVDanhSachNV";
            this.dtGVDanhSachNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtGVDanhSachNV.RowHeadersVisible = false;
            this.dtGVDanhSachNV.RowHeadersWidth = 80;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDanhSachNV.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtGVDanhSachNV.RowTemplate.Height = 50;
            this.dtGVDanhSachNV.Size = new System.Drawing.Size(1448, 494);
            this.dtGVDanhSachNV.TabIndex = 2;
            this.dtGVDanhSachNV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGVDanhSachNV_CellMouseClick);
            // 
            // btnSua
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnSua.DefaultCellStyle = dataGridViewCellStyle12;
            this.btnSua.FillWeight = 94.50655F;
            this.btnSua.HeaderText = "";
            this.btnSua.Image = global::GUI.Properties.Resources.edit;
            this.btnSua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnSua.MinimumWidth = 6;
            this.btnSua.Name = "btnSua";
            this.btnSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSua.Width = 50;
            // 
            // btnXoa
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.DefaultCellStyle = dataGridViewCellStyle13;
            this.btnXoa.FillWeight = 94.50655F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.Image = global::GUI.Properties.Resources.delete;
            this.btnXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnXoa.Width = 50;
            // 
            // btnXemAcc
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            this.btnXemAcc.DefaultCellStyle = dataGridViewCellStyle14;
            this.btnXemAcc.HeaderText = "";
            this.btnXemAcc.Image = global::GUI.Properties.Resources.eye;
            this.btnXemAcc.MinimumWidth = 6;
            this.btnXemAcc.Name = "btnXemAcc";
            this.btnXemAcc.Width = 50;
            // 
            // colManv
            // 
            this.colManv.DataPropertyName = "Id";
            this.colManv.FillWeight = 94.50655F;
            this.colManv.HeaderText = "ID";
            this.colManv.MinimumWidth = 6;
            this.colManv.Name = "colManv";
            this.colManv.ReadOnly = true;
            this.colManv.Width = 50;
            // 
            // colTennv
            // 
            this.colTennv.DataPropertyName = "Name";
            this.colTennv.FillWeight = 94.50655F;
            this.colTennv.HeaderText = "Họ tên";
            this.colTennv.MinimumWidth = 6;
            this.colTennv.Name = "colTennv";
            this.colTennv.ReadOnly = true;
            this.colTennv.Width = 150;
            // 
            // colTentk
            // 
            this.colTentk.DataPropertyName = "email";
            this.colTentk.FillWeight = 94.50655F;
            this.colTentk.HeaderText = "Email";
            this.colTentk.MinimumWidth = 6;
            this.colTentk.Name = "colTentk";
            this.colTentk.ReadOnly = true;
            this.colTentk.Width = 150;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.FillWeight = 94.50655F;
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            this.colSDT.Width = 150;
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.DataPropertyName = "Ngaysinh";
            this.colNgaysinh.FillWeight = 94.50655F;
            this.colNgaysinh.HeaderText = "Ngày sinh";
            this.colNgaysinh.MinimumWidth = 6;
            this.colNgaysinh.Name = "colNgaysinh";
            this.colNgaysinh.ReadOnly = true;
            this.colNgaysinh.Width = 150;
            // 
            // colDiachi
            // 
            this.colDiachi.DataPropertyName = "Diachi";
            this.colDiachi.FillWeight = 94.50655F;
            this.colDiachi.HeaderText = "Địa chỉ";
            this.colDiachi.MinimumWidth = 6;
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.ReadOnly = true;
            this.colDiachi.Width = 150;
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "Chucvu";
            this.colChucVu.FillWeight = 94.50655F;
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            this.colChucVu.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "Gioitinh";
            this.colGioiTinh.FillWeight = 94.50655F;
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 150;
            // 
            // colLuong
            // 
            this.colLuong.DataPropertyName = "TongLuong";
            this.colLuong.FillWeight = 94.50655F;
            this.colLuong.HeaderText = "Lương";
            this.colLuong.MinimumWidth = 6;
            this.colLuong.Name = "colLuong";
            this.colLuong.ReadOnly = true;
            this.colLuong.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle18.NullValue")));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewImageColumn1.FillWeight = 94.50655F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 35;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle19.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle19.NullValue")));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewImageColumn2.FillWeight = 94.50655F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 35;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle20.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle20.NullValue")));
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // picBoxImg
            // 
            this.picBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxImg.Location = new System.Drawing.Point(3, 18);
            this.picBoxImg.Name = "picBoxImg";
            this.picBoxImg.Size = new System.Drawing.Size(209, 201);
            this.picBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImg.TabIndex = 30;
            this.picBoxImg.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(32, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.toolTip1.SetToolTip(this.btnAdd, "Click Muốn Thêm Nhân Viên Mới");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBoxImg);
            this.groupBox1.Location = new System.Drawing.Point(1041, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 222);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh Nhân Viên";
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 790);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGVDanhSachNV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelTimkiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FormQuanLyNhanVien_Load);
            this.panelTimkiem.ResumeLayout(false);
            this.panelTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDanhSachNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private System.Windows.Forms.Panel panelTimkiem;
        private System.Windows.Forms.PictureBox picBoxImg;
        public System.Windows.Forms.DataGridView dtGVDanhSachNV;
        private System.Windows.Forms.TextBox txtSeacrch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn btnSua;
        private System.Windows.Forms.DataGridViewImageColumn btnXoa;
        private System.Windows.Forms.DataGridViewImageColumn btnXemAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTentk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}