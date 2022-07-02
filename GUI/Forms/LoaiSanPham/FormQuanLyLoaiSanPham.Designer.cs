namespace GUI.Forms.LoaiSanPham
{
    partial class FormQuanLyLoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyLoaiSanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhSachLoaiSP = new System.Windows.Forms.DataGridView();
            this.colbtnSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_loaiSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptcBoxImg = new System.Windows.Forms.PictureBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThemLoaiSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxImg)).BeginInit();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachLoaiSP
            // 
            this.dgvDanhSachLoaiSP.AllowUserToAddRows = false;
            this.dgvDanhSachLoaiSP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.dgvDanhSachLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachLoaiSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachLoaiSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLoaiSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachLoaiSP.ColumnHeadersHeight = 40;
            this.dgvDanhSachLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colbtnSua,
            this.ID,
            this.Ten_loaiSp,
            this.mota,
            this.TrangThai,
            this.Hinh});
            this.dgvDanhSachLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachLoaiSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachLoaiSP.EnableHeadersVisualStyles = false;
            this.dgvDanhSachLoaiSP.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSachLoaiSP.Name = "dgvDanhSachLoaiSP";
            this.dgvDanhSachLoaiSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLoaiSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachLoaiSP.RowHeadersVisible = false;
            this.dgvDanhSachLoaiSP.RowHeadersWidth = 80;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachLoaiSP.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachLoaiSP.RowTemplate.Height = 50;
            this.dgvDanhSachLoaiSP.Size = new System.Drawing.Size(1135, 290);
            this.dgvDanhSachLoaiSP.TabIndex = 28;
            this.dgvDanhSachLoaiSP.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachLoaiSP_CellMouseClick);
            // 
            // colbtnSua
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.colbtnSua.DefaultCellStyle = dataGridViewCellStyle2;
            this.colbtnSua.FillWeight = 133.6898F;
            this.colbtnSua.HeaderText = "";
            this.colbtnSua.Image = global::GUI.Properties.Resources.edit;
            this.colbtnSua.MinimumWidth = 6;
            this.colbtnSua.Name = "colbtnSua";
            this.colbtnSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbtnSua.ToolTipText = "Nhấn Để Tiến Hành Edit";
            this.colbtnSua.Width = 60;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Idloaisanpham";
            this.ID.FillWeight = 79.15629F;
            this.ID.HeaderText = "ID Loại Sản Phẩm";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 300;
            // 
            // Ten_loaiSp
            // 
            this.Ten_loaiSp.DataPropertyName = "Tensanpham";
            this.Ten_loaiSp.FillWeight = 79.15629F;
            this.Ten_loaiSp.HeaderText = "Tên Loại Sản Phẩm";
            this.Ten_loaiSp.MinimumWidth = 6;
            this.Ten_loaiSp.Name = "Ten_loaiSp";
            this.Ten_loaiSp.ReadOnly = true;
            this.Ten_loaiSp.Width = 350;
            // 
            // mota
            // 
            this.mota.DataPropertyName = "Mota";
            this.mota.FillWeight = 79.15629F;
            this.mota.HeaderText = "Mô Tả";
            this.mota.MinimumWidth = 6;
            this.mota.Name = "mota";
            this.mota.ReadOnly = true;
            this.mota.Width = 450;
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
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hinh";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            this.Hinh.Visible = false;
            this.Hinh.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachLoaiSP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 311);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptcBoxImg);
            this.groupBox2.Location = new System.Drawing.Point(890, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 220);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh Đại Diện Loại Sản Phẩm";
            // 
            // ptcBoxImg
            // 
            this.ptcBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcBoxImg.Location = new System.Drawing.Point(3, 18);
            this.ptcBoxImg.Name = "ptcBoxImg";
            this.ptcBoxImg.Size = new System.Drawing.Size(216, 199);
            this.ptcBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcBoxImg.TabIndex = 0;
            this.ptcBoxImg.TabStop = false;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panHeader.Controls.Add(this.txtSearch);
            this.panHeader.Controls.Add(this.label2);
            this.panHeader.Controls.Add(this.cmbTrangThai);
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1141, 64);
            this.panHeader.TabIndex = 32;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(778, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(648, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Kiếm";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(241, 18);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(193, 24);
            this.cmbTrangThai.TabIndex = 1;
            this.cmbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng Thái";
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.FillWeight = 133.6898F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.edit;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Nhấn Để Tiến Hành Edit";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // btnThemLoaiSP
            // 
            this.btnThemLoaiSP.Image = global::GUI.Properties.Resources.add;
            this.btnThemLoaiSP.Location = new System.Drawing.Point(89, 117);
            this.btnThemLoaiSP.Name = "btnThemLoaiSP";
            this.btnThemLoaiSP.Size = new System.Drawing.Size(144, 68);
            this.btnThemLoaiSP.TabIndex = 30;
            this.btnThemLoaiSP.UseVisualStyleBackColor = true;
            this.btnThemLoaiSP.Click += new System.EventHandler(this.btnThemLoaiSP_Click);
            // 
            // FormQuanLyLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 607);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemLoaiSP);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyLoaiSanPham";
            this.Text = "Quản Lý Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.FormQuanLyLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxImg)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLoaiSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemLoaiSP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn colbtnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_loaiSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.PictureBox ptcBoxImg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}