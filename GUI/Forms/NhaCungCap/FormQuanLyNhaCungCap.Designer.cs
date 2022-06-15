﻿namespace GUI.Forms.NhaCungCap
{
    partial class FormQuanLyNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyNhaCungCap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTrangThaiNCC = new System.Windows.Forms.ComboBox();
            this.txtSearchNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGVDanhSachNCC = new System.Windows.Forms.DataGridView();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NganHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_NganHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDanhSachNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchNCC);
            this.panel1.Controls.Add(this.cmbTrangThaiNCC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1466, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng Thái ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTrangThaiNCC
            // 
            this.cmbTrangThaiNCC.FormattingEnabled = true;
            this.cmbTrangThaiNCC.Location = new System.Drawing.Point(293, 26);
            this.cmbTrangThaiNCC.Name = "cmbTrangThaiNCC";
            this.cmbTrangThaiNCC.Size = new System.Drawing.Size(197, 24);
            this.cmbTrangThaiNCC.TabIndex = 1;
            this.cmbTrangThaiNCC.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThaiNCC_SelectedIndexChanged);
            // 
            // txtSearchNCC
            // 
            this.txtSearchNCC.Location = new System.Drawing.Point(925, 28);
            this.txtSearchNCC.Name = "txtSearchNCC";
            this.txtSearchNCC.Size = new System.Drawing.Size(230, 22);
            this.txtSearchNCC.TabIndex = 2;
            this.txtSearchNCC.TextChanged += new System.EventHandler(this.txtSearchNCC_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(744, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm Kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGVDanhSachNCC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1466, 578);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dtGVDanhSachNCC
            // 
            this.dtGVDanhSachNCC.AllowUserToAddRows = false;
            this.dtGVDanhSachNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dtGVDanhSachNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGVDanhSachNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGVDanhSachNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtGVDanhSachNCC.ColumnHeadersHeight = 40;
            this.dtGVDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGVDanhSachNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.btnSua,
            this.btnXoa,
            this.ID_NCC,
            this.Ten_CT,
            this.Dia_Chi,
            this.SDT,
            this.Ten_NganHang,
            this.SO_NganHang,
            this.TrangThai});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVDanhSachNCC.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtGVDanhSachNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVDanhSachNCC.EnableHeadersVisualStyles = false;
            this.dtGVDanhSachNCC.Location = new System.Drawing.Point(3, 18);
            this.dtGVDanhSachNCC.Name = "dtGVDanhSachNCC";
            this.dtGVDanhSachNCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtGVDanhSachNCC.RowHeadersVisible = false;
            this.dtGVDanhSachNCC.RowHeadersWidth = 80;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDanhSachNCC.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dtGVDanhSachNCC.RowTemplate.Height = 50;
            this.dtGVDanhSachNCC.Size = new System.Drawing.Size(1460, 557);
            this.dtGVDanhSachNCC.TabIndex = 30;
            this.dtGVDanhSachNCC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGVDanhSachNCC_CellMouseClick);
            // 
            // Checked
            // 
            this.Checked.FillWeight = 160.4278F;
            this.Checked.HeaderText = "";
            this.Checked.MinimumWidth = 6;
            this.Checked.Name = "Checked";
            this.Checked.Width = 35;
            // 
            // ID_NCC
            // 
            this.ID_NCC.DataPropertyName = "Idnhacungcap";
            this.ID_NCC.HeaderText = "ID Nhà Cung Cấp";
            this.ID_NCC.MinimumWidth = 6;
            this.ID_NCC.Name = "ID_NCC";
            this.ID_NCC.ReadOnly = true;
            this.ID_NCC.Width = 175;
            // 
            // Ten_CT
            // 
            this.Ten_CT.DataPropertyName = "Tencongty";
            this.Ten_CT.HeaderText = "Tên Công Ty";
            this.Ten_CT.MinimumWidth = 6;
            this.Ten_CT.Name = "Ten_CT";
            this.Ten_CT.ReadOnly = true;
            this.Ten_CT.Width = 200;
            // 
            // Dia_Chi
            // 
            this.Dia_Chi.DataPropertyName = "Diachi";
            this.Dia_Chi.HeaderText = "Địa Chỉ";
            this.Dia_Chi.MinimumWidth = 6;
            this.Dia_Chi.Name = "Dia_Chi";
            this.Dia_Chi.ReadOnly = true;
            this.Dia_Chi.Width = 225;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "Sdt";
            this.SDT.HeaderText = "Số Điện Thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 150;
            // 
            // Ten_NganHang
            // 
            this.Ten_NganHang.DataPropertyName = "Tennganhang";
            this.Ten_NganHang.HeaderText = "Tên Ngân Hàng";
            this.Ten_NganHang.MinimumWidth = 6;
            this.Ten_NganHang.Name = "Ten_NganHang";
            this.Ten_NganHang.ReadOnly = true;
            this.Ten_NganHang.Width = 175;
            // 
            // SO_NganHang
            // 
            this.SO_NganHang.DataPropertyName = "Sotaikhoan";
            this.SO_NganHang.HeaderText = "STK Ngân Hàng";
            this.SO_NganHang.MinimumWidth = 6;
            this.SO_NganHang.Name = "SO_NganHang";
            this.SO_NganHang.ReadOnly = true;
            this.SO_NganHang.Width = 200;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Trangthai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            this.TrangThai.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewImageColumn1.FillWeight = 94.50655F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle16.NullValue")));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewImageColumn2.FillWeight = 94.50655F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Image = global::GUI.Properties.Resources.resume;
            this.btnThemNCC.Location = new System.Drawing.Point(94, 144);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(159, 80);
            this.btnThemNCC.TabIndex = 2;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnSua
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnSua.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.DefaultCellStyle = dataGridViewCellStyle11;
            this.btnXoa.FillWeight = 94.50655F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.Image = global::GUI.Properties.Resources.delete;
            this.btnXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnXoa.Width = 50;
            // 
            // FormQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 837);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyNhaCungCap";
            this.Load += new System.EventHandler(this.FormQuanLyNhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDanhSachNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchNCC;
        private System.Windows.Forms.ComboBox cmbTrangThaiNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtGVDanhSachNCC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewImageColumn btnSua;
        private System.Windows.Forms.DataGridViewImageColumn btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NganHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_NganHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}