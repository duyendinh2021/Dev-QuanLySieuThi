namespace GUI.Forms.NhaCungCap
{
    partial class FormCapNhatNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatNhaCungCap));
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditTRangThaiNCC = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTenNganHang = new System.Windows.Forms.TextBox();
            this.txtSoNganHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbThongTinNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Controls.Add(this.label9);
            this.grbThongTinNCC.Controls.Add(this.label8);
            this.grbThongTinNCC.Controls.Add(this.label7);
            this.grbThongTinNCC.Controls.Add(this.btnEditTRangThaiNCC);
            this.grbThongTinNCC.Controls.Add(this.cmbTrangThai);
            this.grbThongTinNCC.Controls.Add(this.txtTenNganHang);
            this.grbThongTinNCC.Controls.Add(this.txtSoNganHang);
            this.grbThongTinNCC.Controls.Add(this.txtSDT);
            this.grbThongTinNCC.Controls.Add(this.txtDiaChi);
            this.grbThongTinNCC.Controls.Add(this.txtTenCongTy);
            this.grbThongTinNCC.Controls.Add(this.label6);
            this.grbThongTinNCC.Controls.Add(this.label4);
            this.grbThongTinNCC.Controls.Add(this.label3);
            this.grbThongTinNCC.Controls.Add(this.label5);
            this.grbThongTinNCC.Controls.Add(this.label1);
            this.grbThongTinNCC.Controls.Add(this.label2);
            this.grbThongTinNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinNCC.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Size = new System.Drawing.Size(1287, 431);
            this.grbThongTinNCC.TabIndex = 0;
            this.grbThongTinNCC.TabStop = false;
            this.grbThongTinNCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(1029, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "1 : Hoạt Động";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(1029, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "0 : Ngừng Hoạt Động";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(876, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chú Thích";
            // 
            // btnEditTRangThaiNCC
            // 
            this.btnEditTRangThaiNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTRangThaiNCC.Image = global::GUI.Properties.Resources.writing;
            this.btnEditTRangThaiNCC.Location = new System.Drawing.Point(1162, 260);
            this.btnEditTRangThaiNCC.Name = "btnEditTRangThaiNCC";
            this.btnEditTRangThaiNCC.Size = new System.Drawing.Size(84, 33);
            this.btnEditTRangThaiNCC.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditTRangThaiNCC, "Click dể tiến có thể sửa trạng thái");
            this.btnEditTRangThaiNCC.UseVisualStyleBackColor = true;
            this.btnEditTRangThaiNCC.Click += new System.EventHandler(this.btnEditTRangThaiNCC_Click);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(876, 269);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(253, 24);
            this.cmbTrangThai.TabIndex = 5;
            this.cmbTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTrangThai_KeyDown);
            // 
            // txtTenNganHang
            // 
            this.txtTenNganHang.Location = new System.Drawing.Point(876, 179);
            this.txtTenNganHang.MaxLength = 50;
            this.txtTenNganHang.Name = "txtTenNganHang";
            this.txtTenNganHang.Size = new System.Drawing.Size(253, 22);
            this.txtTenNganHang.TabIndex = 4;
            this.txtTenNganHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNganHang_KeyDown);
            this.txtTenNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNganHang_KeyPress);
            // 
            // txtSoNganHang
            // 
            this.txtSoNganHang.Location = new System.Drawing.Point(876, 90);
            this.txtSoNganHang.MaxLength = 15;
            this.txtSoNganHang.Name = "txtSoNganHang";
            this.txtSoNganHang.Size = new System.Drawing.Size(253, 22);
            this.txtSoNganHang.TabIndex = 3;
            this.txtSoNganHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoNganHang_KeyDown);
            this.txtSoNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNganHang_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(267, 267);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(321, 22);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(267, 179);
            this.txtDiaChi.MaxLength = 255;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(321, 22);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyDown);
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(267, 90);
            this.txtTenCongTy.MaxLength = 50;
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(321, 22);
            this.txtTenCongTy.TabIndex = 0;
            this.txtTenCongTy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenCongTy_KeyDown);
            this.txtTenCongTy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenCongTy_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(655, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng Thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Ngân Hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(655, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Ngân Hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Công Ty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dịa Chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnConfirm.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfirm.Location = new System.Drawing.Point(326, 504);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(186, 85);
            this.btnConfirm.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnConfirm, "Click Tiến Hành Cập Nhật Thông Tin");
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnClear.Image = global::GUI.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(597, 504);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 85);
            this.btnClear.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnClear, "Click Xóa Tất Cả ");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormCapNhatNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 643);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grbThongTinNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapNhatNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.FormCapNhatNhaCungCap_Load);
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.TextBox txtTenNganHang;
        private System.Windows.Forms.TextBox txtSoNganHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditTRangThaiNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}