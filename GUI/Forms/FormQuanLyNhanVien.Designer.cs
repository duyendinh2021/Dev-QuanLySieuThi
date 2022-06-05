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
            FontAwesome.Sharp.IconButton btnTimkiem;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.panelTimkiem = new System.Windows.Forms.Panel();
            this.dtGVDanhSachNV = new System.Windows.Forms.DataGridView();
            this.picBoxImg = new System.Windows.Forms.PictureBox();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            btnTimkiem = new FontAwesome.Sharp.IconButton();
            this.panelTimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDanhSachNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnTimkiem.BackColor = System.Drawing.Color.Transparent;
            btnTimkiem.Cursor = System.Windows.Forms.Cursors.Default;
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTimkiem.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnTimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            btnTimkiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnTimkiem.IconColor = System.Drawing.Color.Black;
            btnTimkiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTimkiem.IconSize = 28;
            btnTimkiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnTimkiem.Location = new System.Drawing.Point(1264, 18);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            btnTimkiem.Size = new System.Drawing.Size(69, 36);
            btnTimkiem.TabIndex = 2;
            btnTimkiem.UseMnemonic = false;
            btnTimkiem.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(32, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 60);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(395, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chức vụ";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 8;
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
            this.cmbChucvu.Location = new System.Drawing.Point(132, 25);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(170, 24);
            this.cmbChucvu.TabIndex = 8;
            // 
            // panelTimkiem
            // 
            this.panelTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panelTimkiem.Controls.Add(this.rjTextBox1);
            this.panelTimkiem.Controls.Add(this.label3);
            this.panelTimkiem.Controls.Add(this.label2);
            this.panelTimkiem.Controls.Add(this.comboBox1);
            this.panelTimkiem.Controls.Add(this.cmbChucvu);
            this.panelTimkiem.Controls.Add(btnTimkiem);
            this.panelTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimkiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTimkiem.Location = new System.Drawing.Point(0, 0);
            this.panelTimkiem.Name = "panelTimkiem";
            this.panelTimkiem.Size = new System.Drawing.Size(1448, 65);
            this.panelTimkiem.TabIndex = 26;
            // 
            // dtGVDanhSachNV
            // 
            this.dtGVDanhSachNV.AllowUserToAddRows = false;
            this.dtGVDanhSachNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dtGVDanhSachNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVDanhSachNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVDanhSachNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVDanhSachNV.ColumnHeadersHeight = 40;
            this.dtGVDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGVDanhSachNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.btnSua,
            this.btnXoa,
            this.colManv,
            this.colTennv,
            this.colTentk,
            this.colSDT,
            this.colNgaysinh,
            this.colDiachi,
            this.colChucVu,
            this.colGioiTinh,
            this.colLuong});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVDanhSachNV.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGVDanhSachNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVDanhSachNV.EnableHeadersVisualStyles = false;
            this.dtGVDanhSachNV.Location = new System.Drawing.Point(0, 296);
            this.dtGVDanhSachNV.Name = "dtGVDanhSachNV";
            this.dtGVDanhSachNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGVDanhSachNV.RowHeadersVisible = false;
            this.dtGVDanhSachNV.RowHeadersWidth = 80;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDanhSachNV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGVDanhSachNV.RowTemplate.Height = 24;
            this.dtGVDanhSachNV.Size = new System.Drawing.Size(1448, 494);
            this.dtGVDanhSachNV.TabIndex = 29;
            this.dtGVDanhSachNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVDanhSachNV_CellContentClick);
            // 
            // picBoxImg
            // 
            this.picBoxImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxImg.Location = new System.Drawing.Point(987, 89);
            this.picBoxImg.Name = "picBoxImg";
            this.picBoxImg.Size = new System.Drawing.Size(232, 183);
            this.picBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImg.TabIndex = 30;
            this.picBoxImg.TabStop = false;
            // 
            // Checked
            // 
            this.Checked.FillWeight = 160.4278F;
            this.Checked.HeaderText = "";
            this.Checked.MinimumWidth = 6;
            this.Checked.Name = "Checked";
            this.Checked.Width = 25;
            // 
            // btnSua
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnSua.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnSua.FillWeight = 94.50655F;
            this.btnSua.HeaderText = "";
            this.btnSua.MinimumWidth = 6;
            this.btnSua.Name = "btnSua";
            this.btnSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSua.Width = 35;
            // 
            // btnXoa
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnXoa.FillWeight = 94.50655F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnXoa.Width = 35;
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
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.rjTextBox1.BorderRadius = 6;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(894, 15);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "Tìm kiếm";
            this.rjTextBox1.Size = new System.Drawing.Size(325, 35);
            this.rjTextBox1.TabIndex = 10;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 790);
            this.Controls.Add(this.picBoxImg);
            this.Controls.Add(this.dtGVDanhSachNV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelTimkiem);
            this.Name = "FormQuanLyNhanVien";
            this.Text = "FormQuanLyNhanVien";
            this.Load += new System.EventHandler(this.FormQuanLyNhanVien_Load);
            this.panelTimkiem.ResumeLayout(false);
            this.panelTimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDanhSachNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private System.Windows.Forms.Panel panelTimkiem;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.PictureBox picBoxImg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTentk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        public System.Windows.Forms.DataGridView dtGVDanhSachNV;
    }
}