namespace GUI.Forms.HoaDon
{
    partial class FormChiTietHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtIDSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachDetailsPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewSanPham = new System.Windows.Forms.Button();
            this.ID_HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDetailsPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(884, 31);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(181, 22);
            this.txtSL.TabIndex = 9;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(255, 114);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.ReadOnly = true;
            this.txtChietKhau.Size = new System.Drawing.Size(181, 22);
            this.txtChietKhau.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(884, 116);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(181, 22);
            this.txtDonGia.TabIndex = 11;
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.Location = new System.Drawing.Point(255, 31);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.ReadOnly = true;
            this.txtIDSanPham.Size = new System.Drawing.Size(181, 22);
            this.txtIDSanPham.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "% Chiết Khấu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvDanhSachDetailsPhieuNhap
            // 
            this.dgvDanhSachDetailsPhieuNhap.AllowUserToAddRows = false;
            this.dgvDanhSachDetailsPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDetailsPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvDanhSachDetailsPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachDetailsPhieuNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersHeight = 40;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachDetailsPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HD,
            this.ID_SanPham,
            this.ChietKhau,
            this.SL,
            this.DonGia,
            this.TrangThai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachDetailsPhieuNhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSachDetailsPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDetailsPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvDanhSachDetailsPhieuNhap.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachDetailsPhieuNhap.Name = "dgvDanhSachDetailsPhieuNhap";
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersVisible = false;
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersWidth = 80;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachDetailsPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDanhSachDetailsPhieuNhap.RowTemplate.Height = 50;
            this.dgvDanhSachDetailsPhieuNhap.Size = new System.Drawing.Size(1149, 283);
            this.dgvDanhSachDetailsPhieuNhap.TabIndex = 31;
            this.dgvDanhSachDetailsPhieuNhap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachDetailsPhieuNhap_CellMouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachDetailsPhieuNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 304);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết Phiếu Nhập Kho";
            // 
            // btnViewSanPham
            // 
            this.btnViewSanPham.Image = global::GUI.Properties.Resources.eye;
            this.btnViewSanPham.Location = new System.Drawing.Point(528, 22);
            this.btnViewSanPham.Name = "btnViewSanPham";
            this.btnViewSanPham.Size = new System.Drawing.Size(83, 40);
            this.btnViewSanPham.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnViewSanPham, "Nhấn Dể Xem Chi Tiết Sản Phẩm");
            this.btnViewSanPham.UseVisualStyleBackColor = true;
            this.btnViewSanPham.Click += new System.EventHandler(this.btnViewSanPham_Click);
            // 
            // ID_HD
            // 
            this.ID_HD.DataPropertyName = "Idhd";
            this.ID_HD.HeaderText = "ID Phiếu Nhập";
            this.ID_HD.MinimumWidth = 6;
            this.ID_HD.Name = "ID_HD";
            this.ID_HD.ReadOnly = true;
            this.ID_HD.Visible = false;
            // 
            // ID_SanPham
            // 
            this.ID_SanPham.DataPropertyName = "Idsp";
            this.ID_SanPham.HeaderText = "ID Sản Phẩm";
            this.ID_SanPham.MinimumWidth = 6;
            this.ID_SanPham.Name = "ID_SanPham";
            this.ID_SanPham.ReadOnly = true;
            // 
            // ChietKhau
            // 
            this.ChietKhau.DataPropertyName = "Chietkhau";
            this.ChietKhau.HeaderText = "Chiết Khấu";
            this.ChietKhau.MinimumWidth = 6;
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "Sl";
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "Dongia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Trangthai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 632);
            this.Controls.Add(this.btnViewSanPham);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtChietKhau);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtIDSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDetailsPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnViewSanPham;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtIDSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDanhSachDetailsPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}