namespace GUI.Forms.NhaCungCap
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyNhaCungCap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchNCC = new System.Windows.Forms.TextBox();
            this.cmbTrangThaiNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGVDanhSachNCC = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            // txtSearchNCC
            // 
            this.txtSearchNCC.Location = new System.Drawing.Point(925, 28);
            this.txtSearchNCC.Name = "txtSearchNCC";
            this.txtSearchNCC.Size = new System.Drawing.Size(230, 22);
            this.txtSearchNCC.TabIndex = 2;
            this.txtSearchNCC.TextChanged += new System.EventHandler(this.txtSearchNCC_TextChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGVDanhSachNCC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1466, 578);
            this.groupBox1.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVDanhSachNCC.ColumnHeadersHeight = 40;
            this.dtGVDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGVDanhSachNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSua,
            this.btnXoa,
            this.ID_NCC,
            this.Ten_CT,
            this.Dia_Chi,
            this.SDT,
            this.Ten_NganHang,
            this.SO_NganHang,
            this.TrangThai});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGVDanhSachNCC.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGVDanhSachNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVDanhSachNCC.EnableHeadersVisualStyles = false;
            this.dtGVDanhSachNCC.Location = new System.Drawing.Point(3, 18);
            this.dtGVDanhSachNCC.Name = "dtGVDanhSachNCC";
            this.dtGVDanhSachNCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGVDanhSachNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGVDanhSachNCC.RowHeadersVisible = false;
            this.dtGVDanhSachNCC.RowHeadersWidth = 80;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGVDanhSachNCC.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGVDanhSachNCC.RowTemplate.Height = 50;
            this.dtGVDanhSachNCC.Size = new System.Drawing.Size(1460, 557);
            this.dtGVDanhSachNCC.TabIndex = 30;
            this.dtGVDanhSachNCC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGVDanhSachNCC_CellMouseClick);
            // 
            // btnSua
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnSua.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnXoa.FillWeight = 94.50655F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.Image = global::GUI.Properties.Resources.delete;
            this.btnXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnXoa.Width = 50;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.btnThemNCC.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnThemNCC, "Click Dể Tiến Hành Thêm Nhà Cung Cấp Mới");
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // FormQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 837);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyNhaCungCap";
            this.Text = "Quản Lý Nhà Cung Cấp";
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn btnSua;
        private System.Windows.Forms.DataGridViewImageColumn btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NganHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_NganHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}