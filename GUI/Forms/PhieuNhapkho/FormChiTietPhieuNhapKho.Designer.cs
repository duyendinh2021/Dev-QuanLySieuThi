namespace GUI.Forms.PhieuNhapkho
{
    partial class FormChiTietPhieuNhapKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhieuNhapKho));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDetailsPhieuNhap = new System.Windows.Forms.DataGridView();
            this.ID_PhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDSanPham = new System.Windows.Forms.TextBox();
            this.txtIDNcc = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.btnViewSanPham = new System.Windows.Forms.Button();
            this.btnViewNhaCungCap = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDetailsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachDetailsPhieuNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chi Tiết Phiếu Nhập Kho";
            // 
            // dgvDanhSachDetailsPhieuNhap
            // 
            this.dgvDanhSachDetailsPhieuNhap.AllowUserToAddRows = false;
            this.dgvDanhSachDetailsPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachDetailsPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dgvDanhSachDetailsPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachDetailsPhieuNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersHeight = 40;
            this.dgvDanhSachDetailsPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachDetailsPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PhieuNhap,
            this.ID_SanPham,
            this.ID_Ncc,
            this.SL,
            this.DonGia,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachDetailsPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachDetailsPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDetailsPhieuNhap.EnableHeadersVisualStyles = false;
            this.dgvDanhSachDetailsPhieuNhap.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachDetailsPhieuNhap.Name = "dgvDanhSachDetailsPhieuNhap";
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersVisible = false;
            this.dgvDanhSachDetailsPhieuNhap.RowHeadersWidth = 80;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachDetailsPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachDetailsPhieuNhap.RowTemplate.Height = 50;
            this.dgvDanhSachDetailsPhieuNhap.Size = new System.Drawing.Size(1149, 283);
            this.dgvDanhSachDetailsPhieuNhap.TabIndex = 31;
            this.dgvDanhSachDetailsPhieuNhap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachDetailsPhieuNhap_CellMouseClick);
            // 
            // ID_PhieuNhap
            // 
            this.ID_PhieuNhap.DataPropertyName = "Idphieunhapkho";
            this.ID_PhieuNhap.HeaderText = "ID Phiếu Nhập";
            this.ID_PhieuNhap.MinimumWidth = 6;
            this.ID_PhieuNhap.Name = "ID_PhieuNhap";
            this.ID_PhieuNhap.ReadOnly = true;
            this.ID_PhieuNhap.Visible = false;
            // 
            // ID_SanPham
            // 
            this.ID_SanPham.DataPropertyName = "Idsp";
            this.ID_SanPham.HeaderText = "ID Sản Phẩm";
            this.ID_SanPham.MinimumWidth = 6;
            this.ID_SanPham.Name = "ID_SanPham";
            this.ID_SanPham.ReadOnly = true;
            // 
            // ID_Ncc
            // 
            this.ID_Ncc.DataPropertyName = "Idnhacungcap";
            this.ID_Ncc.HeaderText = "ID Nhà Cung Cấp";
            this.ID_Ncc.MinimumWidth = 6;
            this.ID_Ncc.Name = "ID_Ncc";
            this.ID_Ncc.ReadOnly = true;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Nhà Cung Cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn Giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.Location = new System.Drawing.Point(255, 52);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.ReadOnly = true;
            this.txtIDSanPham.Size = new System.Drawing.Size(181, 22);
            this.txtIDSanPham.TabIndex = 2;
            // 
            // txtIDNcc
            // 
            this.txtIDNcc.Location = new System.Drawing.Point(255, 135);
            this.txtIDNcc.Name = "txtIDNcc";
            this.txtIDNcc.ReadOnly = true;
            this.txtIDNcc.Size = new System.Drawing.Size(181, 22);
            this.txtIDNcc.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(884, 137);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(181, 22);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(884, 52);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(181, 22);
            this.txtSL.TabIndex = 2;
            // 
            // btnViewSanPham
            // 
            this.btnViewSanPham.Image = global::GUI.Properties.Resources.eye;
            this.btnViewSanPham.Location = new System.Drawing.Point(528, 43);
            this.btnViewSanPham.Name = "btnViewSanPham";
            this.btnViewSanPham.Size = new System.Drawing.Size(83, 40);
            this.btnViewSanPham.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnViewSanPham, "Nhấn Dể Xem Chi Tiết Sản Phẩm");
            this.btnViewSanPham.UseVisualStyleBackColor = true;
            this.btnViewSanPham.Click += new System.EventHandler(this.btnViewSanPham_Click);
            // 
            // btnViewNhaCungCap
            // 
            this.btnViewNhaCungCap.Image = global::GUI.Properties.Resources.eye;
            this.btnViewNhaCungCap.Location = new System.Drawing.Point(528, 126);
            this.btnViewNhaCungCap.Name = "btnViewNhaCungCap";
            this.btnViewNhaCungCap.Size = new System.Drawing.Size(83, 40);
            this.btnViewNhaCungCap.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnViewNhaCungCap, "Nhấn Dể Xem Chi Tiết Nhà Cung Cấp");
            this.btnViewNhaCungCap.UseVisualStyleBackColor = true;
            this.btnViewNhaCungCap.Click += new System.EventHandler(this.btnViewNhaCungCap_Click);
            // 
            // FormChiTietPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 632);
            this.Controls.Add(this.btnViewNhaCungCap);
            this.Controls.Add(this.btnViewSanPham);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtIDNcc);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtIDSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChiTietPhieuNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Nhập Kho";
            this.Load += new System.EventHandler(this.FormChiTietPhieuNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDetailsPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDSanPham;
        private System.Windows.Forms.TextBox txtIDNcc;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridView dgvDanhSachDetailsPhieuNhap;
        private System.Windows.Forms.Button btnViewSanPham;
        private System.Windows.Forms.Button btnViewNhaCungCap;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}