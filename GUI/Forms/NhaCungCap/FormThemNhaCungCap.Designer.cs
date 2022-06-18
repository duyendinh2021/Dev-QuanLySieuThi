namespace GUI.Forms
{
    partial class FormThemNhaCungCap
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
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.txtTenNganHang = new System.Windows.Forms.TextBox();
            this.txtSoNganHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnConfirm = new FontAwesome.Sharp.IconButton();
            this.panHeader.SuspendLayout();
            this.grbThongTinNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1213, 46);
            this.panHeader.TabIndex = 3;
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
            this.btnExit.IconSize = 42;
            this.btnExit.Location = new System.Drawing.Point(1138, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 46);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Controls.Add(this.txtTenNganHang);
            this.grbThongTinNCC.Controls.Add(this.txtSoNganHang);
            this.grbThongTinNCC.Controls.Add(this.txtSDT);
            this.grbThongTinNCC.Controls.Add(this.txtDiaChi);
            this.grbThongTinNCC.Controls.Add(this.txtTenCongTy);
            this.grbThongTinNCC.Controls.Add(this.label4);
            this.grbThongTinNCC.Controls.Add(this.label3);
            this.grbThongTinNCC.Controls.Add(this.label5);
            this.grbThongTinNCC.Controls.Add(this.label1);
            this.grbThongTinNCC.Controls.Add(this.label2);
            this.grbThongTinNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinNCC.Location = new System.Drawing.Point(0, 46);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Size = new System.Drawing.Size(1213, 431);
            this.grbThongTinNCC.TabIndex = 0;
            this.grbThongTinNCC.TabStop = false;
            this.grbThongTinNCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // txtTenNganHang
            // 
            this.txtTenNganHang.Location = new System.Drawing.Point(876, 187);
            this.txtTenNganHang.Name = "txtTenNganHang";
            this.txtTenNganHang.Size = new System.Drawing.Size(253, 22);
            this.txtTenNganHang.TabIndex = 4;
            this.txtTenNganHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNganHang_KeyDown);
            this.txtTenNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNganHang_KeyPress);
            // 
            // txtSoNganHang
            // 
            this.txtSoNganHang.Location = new System.Drawing.Point(876, 90);
            this.txtSoNganHang.Name = "txtSoNganHang";
            this.txtSoNganHang.Size = new System.Drawing.Size(253, 22);
            this.txtSoNganHang.TabIndex = 3;
            this.txtSoNganHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoNganHang_KeyDown);
            this.txtSoNganHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNganHang_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(267, 264);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(321, 22);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(267, 187);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(321, 22);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaChi_KeyDown);
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(267, 89);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(321, 22);
            this.txtTenCongTy.TabIndex = 0;
            this.txtTenCongTy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenCongTy_KeyDown);
            this.txtTenCongTy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenCongTy_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Ngân Hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(655, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Ngân Hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Công Ty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dịa Chỉ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(526, 551);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 53);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Xóa tất cả";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfirm.IconColor = System.Drawing.Color.Black;
            this.btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirm.Location = new System.Drawing.Point(256, 551);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(152, 53);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormThemNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 724);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grbThongTinNCC);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemNhaCungCap";
            this.Text = "FormThemNhaCungCap";
            this.panHeader.ResumeLayout(false);
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNganHang;
        private System.Windows.Forms.TextBox txtSoNganHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton btnClear;
        public FontAwesome.Sharp.IconButton btnConfirm;
    }
}