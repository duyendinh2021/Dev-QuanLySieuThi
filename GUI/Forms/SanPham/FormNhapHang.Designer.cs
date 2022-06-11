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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapHang));
            this.panHeader = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDSHangHoa = new System.Windows.Forms.GroupBox();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.dtgDSHangHoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.grbDSNhapHang = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongGia = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Add = new System.Windows.Forms.DataGridViewImageColumn();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbDSHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHangHoa)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbDSNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1468, 45);
            this.panHeader.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmbLoaiSP);
            this.splitContainer1.Panel2.Controls.Add(this.grbDSHangHoa);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1468, 711);
            this.splitContainer1.SplitterDistance = 726;
            this.splitContainer1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 95);
            this.panel1.TabIndex = 0;
            // 
            // grbDSHangHoa
            // 
            this.grbDSHangHoa.Controls.Add(this.dtgDSHangHoa);
            this.grbDSHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDSHangHoa.Location = new System.Drawing.Point(0, 114);
            this.grbDSHangHoa.Name = "grbDSHangHoa";
            this.grbDSHangHoa.Size = new System.Drawing.Size(738, 502);
            this.grbDSHangHoa.TabIndex = 1;
            this.grbDSHangHoa.TabStop = false;
            this.grbDSHangHoa.Text = "Danh Sách Hàng Hóa";
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(28, 60);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(256, 24);
            this.cmbLoaiSP.TabIndex = 2;
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
            this.dtgDSHangHoa.ColumnHeadersHeight = 40;
            this.dtgDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgDSHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add});
            this.dtgDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDSHangHoa.EnableHeadersVisualStyles = false;
            this.dtgDSHangHoa.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgDSHangHoa.Location = new System.Drawing.Point(3, 18);
            this.dtgDSHangHoa.Name = "dtgDSHangHoa";
            this.dtgDSHangHoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgDSHangHoa.RowHeadersVisible = false;
            this.dtgDSHangHoa.RowHeadersWidth = 51;
            this.dtgDSHangHoa.RowTemplate.Height = 24;
            this.dtgDSHangHoa.Size = new System.Drawing.Size(732, 481);
            this.dtgDSHangHoa.TabIndex = 13;
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
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(293, 38);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(255, 22);
            this.txtSl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 117);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.button3.Image = global::GUI.Properties.Resources.clear;
            this.button3.Location = new System.Drawing.Point(470, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 58);
            this.button3.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button3, "Nhấn Xóa Danh Sách Hàng Nhập");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.button2.Image = global::GUI.Properties.Resources.add;
            this.button2.Location = new System.Drawing.Point(266, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 58);
            this.button2.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button2, "Nhấn Thêm Sản Phẩm Mới");
            this.button2.UseVisualStyleBackColor = false;
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
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(1393, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbDSNhapHang
            // 
            this.grbDSNhapHang.Controls.Add(this.dgvHoaDonNhap);
            this.grbDSNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDSNhapHang.Location = new System.Drawing.Point(0, 0);
            this.grbDSNhapHang.Name = "grbDSNhapHang";
            this.grbDSNhapHang.Size = new System.Drawing.Size(726, 418);
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
            this.dgvHoaDonNhap.RowHeadersWidth = 51;
            this.dgvHoaDonNhap.RowTemplate.Height = 24;
            this.dgvHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(720, 397);
            this.dgvHoaDonNhap.TabIndex = 12;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "SẢN PHẨM";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "SỐ LƯỢNG";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            // 
            // COST
            // 
            this.COST.DataPropertyName = "COST";
            this.COST.HeaderText = "GIÁ";
            this.COST.MinimumWidth = 6;
            this.COST.Name = "COST";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "XÓA";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
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
            // txtTongGia
            // 
            this.txtTongGia.Location = new System.Drawing.Point(266, 441);
            this.txtTongGia.Name = "txtTongGia";
            this.txtTongGia.Size = new System.Drawing.Size(242, 22);
            this.txtTongGia.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbDSNhapHang);
            this.panel3.Controls.Add(this.txtTongGia);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 480);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm Kiếm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(175, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(267, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.HeaderText = "";
            this.Add.Image = global::GUI.Properties.Resources.left_arrow;
            this.Add.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 756);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.panHeader.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbDSHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHangHoa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbDSNhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.GroupBox grbDSHangHoa;
        private System.Windows.Forms.DataGridView dtgDSHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbDSNhapHang;
        public System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn COST;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox txtTongGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn Add;
    }
}