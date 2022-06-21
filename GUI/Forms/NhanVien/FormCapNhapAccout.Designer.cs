namespace GUI.Forms
{
    partial class FormCapNhapAccout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhapAccout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1002, 55);
            this.panHeader.TabIndex = 8;
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
            this.btnExit.IconSize = 50;
            this.btnExit.Location = new System.Drawing.Point(927, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 55);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(275, 179);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(221, 22);
            this.txtTaiKhoan.TabIndex = 9;
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(275, 298);
            this.txtMk.MaxLength = 25;
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(221, 22);
            this.txtMk.TabIndex = 1;
            this.txtMk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMk_KeyDown);
            this.txtMk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMk_KeyPress);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "hoạt động",
            "không hoạt động"});
            this.cmbTrangThai.Location = new System.Drawing.Point(721, 179);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(175, 24);
            this.cmbTrangThai.TabIndex = 2;
            this.cmbTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTrangThai_KeyDown);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.btnCapNhat.Image = global::GUI.Properties.Resources.update;
            this.btnCapNhat.Location = new System.Drawing.Point(547, 419);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(187, 66);
            this.btnCapNhat.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCapNhat, "Click Dể Xác Nhận Chỉnh Sửa Hoàng Tất");
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.btnSua.Image = global::GUI.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(224, 419);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 66);
            this.btnSua.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSua, "Click Dể Tiến Hành Chỉnh Sửa");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormCapNhapAccout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 600);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapNhapAccout";
            this.Load += new System.EventHandler(this.FormViewAccout_Load);
            this.panHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}