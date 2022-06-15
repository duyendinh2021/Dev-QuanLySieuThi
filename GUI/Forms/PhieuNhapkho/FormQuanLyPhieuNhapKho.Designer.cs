namespace GUI.Forms.PhieuNhapkho
{
    partial class FormQuanLyPhieuNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnViewDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID_PhieuNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelDatails = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.chkSearchID = new System.Windows.Forms.CheckBox();
            this.chkSearchNgay = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSearchNgayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchNgayStar = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelDatails.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachPhieuNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Nhập Kho";
            // 
            // dgvDanhSachPhieuNhap
            // 
            this.dgvDanhSachPhieuNhap.AllowUserToAddRows = false;
            this.dgvDanhSachPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.dgvDanhSachPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachPhieuNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDanhSachPhieuNhap.ColumnHeadersHeight = 40;
            this.dgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnViewDetails,
            this.btnDelete,
            this.ID_PhieuNhapKho,
            this.ID_NhanVien,
            this.NgayLap,
            this.TongTien,
            this.TrangThai});
            this.dgvDanhSachPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachPhieuNhap.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDanhSachPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvDanhSachPhieuNhap.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachPhieuNhap.Name = "dgvDanhSachPhieuNhap";
            this.dgvDanhSachPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDanhSachPhieuNhap.RowHeadersVisible = false;
            this.dgvDanhSachPhieuNhap.RowHeadersWidth = 80;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhSachPhieuNhap.RowTemplate.Height = 50;
            this.dgvDanhSachPhieuNhap.Size = new System.Drawing.Size(1284, 300);
            this.dgvDanhSachPhieuNhap.TabIndex = 29;
            this.dgvDanhSachPhieuNhap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachPhieuNhap_CellMouseClick);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.FillWeight = 137.7106F;
            this.btnViewDetails.HeaderText = "";
            this.btnViewDetails.Image = global::GUI.Properties.Resources.file;
            this.btnViewDetails.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnViewDetails.MinimumWidth = 6;
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Width = 55;
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 160.4278F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = global::GUI.Properties.Resources.delete;
            this.btnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Width = 55;
            // 
            // ID_PhieuNhapKho
            // 
            this.ID_PhieuNhapKho.DataPropertyName = "Idphieunhapkho";
            this.ID_PhieuNhapKho.FillWeight = 75.4654F;
            this.ID_PhieuNhapKho.HeaderText = "ID Phiếu Nhập Kho";
            this.ID_PhieuNhapKho.MinimumWidth = 6;
            this.ID_PhieuNhapKho.Name = "ID_PhieuNhapKho";
            this.ID_PhieuNhapKho.ReadOnly = true;
            this.ID_PhieuNhapKho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID_PhieuNhapKho.Width = 255;
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.DataPropertyName = "Idnhanvien";
            this.ID_NhanVien.FillWeight = 75.4654F;
            this.ID_NhanVien.HeaderText = "ID Nhân Viên Lập";
            this.ID_NhanVien.MinimumWidth = 6;
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.ReadOnly = true;
            this.ID_NhanVien.Width = 255;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "Ngaylap";
            this.NgayLap.FillWeight = 75.4654F;
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            this.NgayLap.Width = 330;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Tongtien";
            this.TongTien.FillWeight = 75.4654F;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 330;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Trangthai";
            this.TrangThai.HeaderText = "Trang Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            this.TrangThai.Width = 260;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelDatails);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1290, 318);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelDatails
            // 
            this.panelDatails.Controls.Add(this.label5);
            this.panelDatails.Controls.Add(this.dtpNgayLap);
            this.panelDatails.Controls.Add(this.txtTongTien);
            this.panelDatails.Controls.Add(this.txtID);
            this.panelDatails.Controls.Add(this.label3);
            this.panelDatails.Controls.Add(this.label2);
            this.panelDatails.Controls.Add(this.label1);
            this.panelDatails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatails.Location = new System.Drawing.Point(0, 0);
            this.panelDatails.Name = "panelDatails";
            this.panelDatails.Size = new System.Drawing.Size(635, 318);
            this.panelDatails.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "label4";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(231, 126);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(249, 22);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(231, 216);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(249, 22);
            this.txtTongTien.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(231, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 22);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Tiền";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Tạo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Nhân Viên Tạo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.chkSearchID);
            this.panelSearch.Controls.Add(this.chkSearchNgay);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.groupBox2);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(651, 318);
            this.panelSearch.TabIndex = 0;
            // 
            // chkSearchID
            // 
            this.chkSearchID.AutoSize = true;
            this.chkSearchID.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchID.Location = new System.Drawing.Point(81, 281);
            this.chkSearchID.Name = "chkSearchID";
            this.chkSearchID.Size = new System.Drawing.Size(130, 24);
            this.chkSearchID.TabIndex = 10;
            this.chkSearchID.Text = "Tìm Theo ID";
            this.chkSearchID.UseVisualStyleBackColor = true;
            // 
            // chkSearchNgay
            // 
            this.chkSearchNgay.AutoSize = true;
            this.chkSearchNgay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchNgay.Location = new System.Drawing.Point(81, 244);
            this.chkSearchNgay.Name = "chkSearchNgay";
            this.chkSearchNgay.Size = new System.Drawing.Size(148, 24);
            this.chkSearchNgay.TabIndex = 10;
            this.chkSearchNgay.Text = "Tìm Theo Ngày";
            this.chkSearchNgay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkSearchNgay.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::GUI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(346, 244);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 57);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpSearchNgayEnd);
            this.groupBox2.Controls.Add(this.dtpSearchNgayStar);
            this.groupBox2.Location = new System.Drawing.Point(23, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 209);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tìm Kiếm";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(328, 155);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(157, 22);
            this.txtSearchID.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID Phiếu Nhập Hoạt Nhân Viên\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Kết Thúc";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Bất Đầu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpSearchNgayEnd
            // 
            this.dtpSearchNgayEnd.Location = new System.Drawing.Point(274, 99);
            this.dtpSearchNgayEnd.Name = "dtpSearchNgayEnd";
            this.dtpSearchNgayEnd.Size = new System.Drawing.Size(211, 22);
            this.dtpSearchNgayEnd.TabIndex = 7;
            // 
            // dtpSearchNgayStar
            // 
            this.dtpSearchNgayStar.Location = new System.Drawing.Point(274, 37);
            this.dtpSearchNgayStar.Name = "dtpSearchNgayStar";
            this.dtpSearchNgayStar.Size = new System.Drawing.Size(211, 22);
            this.dtpSearchNgayStar.TabIndex = 8;
            // 
            // FormQuanLyPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyPhieuNhapKho";
            this.Text = "FormQuanLyPhieuNhapKho";
            this.Load += new System.EventHandler(this.FormQuanLyPhieuNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhap)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelDatails.ResumeLayout(false);
            this.panelDatails.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelDatails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.CheckBox chkSearchID;
        private System.Windows.Forms.CheckBox chkSearchNgay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSearchNgayEnd;
        private System.Windows.Forms.DateTimePicker dtpSearchNgayStar;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuNhap;
        private System.Windows.Forms.DataGridViewImageColumn btnViewDetails;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhieuNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}