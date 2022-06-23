namespace GUI.Forms
{
    partial class FormNhapSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapSanPham));
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptbShowImage = new System.Windows.Forms.PictureBox();
            this.btnBrowsImg = new System.Windows.Forms.Button();
            this.btnThemLoaiSp = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.cmbLoaiSp = new System.Windows.Forms.ComboBox();
            this.cmbNcc = new System.Windows.Forms.ComboBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1500, 45);
            this.panHeader.TabIndex = 13;
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
            this.btnExit.Location = new System.Drawing.Point(1425, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBrowsImg);
            this.groupBox1.Controls.Add(this.btnThemLoaiSp);
            this.groupBox1.Controls.Add(this.btnThemNCC);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.cmbDVT);
            this.groupBox1.Controls.Add(this.cmbLoaiSp);
            this.groupBox1.Controls.Add(this.cmbNcc);
            this.groupBox1.Controls.Add(this.txtTenSp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1500, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptbShowImage);
            this.groupBox2.Location = new System.Drawing.Point(1017, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 307);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh Sản Phẩm";
            // 
            // ptbShowImage
            // 
            this.ptbShowImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbShowImage.Location = new System.Drawing.Point(3, 18);
            this.ptbShowImage.Name = "ptbShowImage";
            this.ptbShowImage.Size = new System.Drawing.Size(275, 286);
            this.ptbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbShowImage.TabIndex = 63;
            this.ptbShowImage.TabStop = false;
            // 
            // btnBrowsImg
            // 
            this.btnBrowsImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(88)))));
            this.btnBrowsImg.Image = global::GUI.Properties.Resources.photo;
            this.btnBrowsImg.Location = new System.Drawing.Point(1017, 100);
            this.btnBrowsImg.Name = "btnBrowsImg";
            this.btnBrowsImg.Size = new System.Drawing.Size(123, 55);
            this.btnBrowsImg.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnBrowsImg, "Click dể tiến hành chọn hình");
            this.btnBrowsImg.UseVisualStyleBackColor = false;
            this.btnBrowsImg.Click += new System.EventHandler(this.btnBrowsImg_Click);
            // 
            // btnThemLoaiSp
            // 
            this.btnThemLoaiSp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnThemLoaiSp.Image = global::GUI.Properties.Resources.other;
            this.btnThemLoaiSp.Location = new System.Drawing.Point(654, 231);
            this.btnThemLoaiSp.Name = "btnThemLoaiSp";
            this.btnThemLoaiSp.Size = new System.Drawing.Size(85, 28);
            this.btnThemLoaiSp.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnThemLoaiSp, "Click nếu muốn thêm loại sản phẩm mới");
            this.btnThemLoaiSp.UseVisualStyleBackColor = false;
            this.btnThemLoaiSp.Click += new System.EventHandler(this.btnThemLoaiSp_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnThemNCC.Image = global::GUI.Properties.Resources.other;
            this.btnThemNCC.Location = new System.Drawing.Point(654, 145);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(85, 28);
            this.btnThemNCC.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnThemNCC, "Click nếu muốn thêm nhà cung cấp mới");
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(384, 403);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(241, 22);
            this.txtDonGia.TabIndex = 6;
            this.txtDonGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDonGia_KeyDown);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // cmbDVT
            // 
            this.cmbDVT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDVT.FormattingEnabled = true;
            this.cmbDVT.Location = new System.Drawing.Point(384, 317);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(241, 24);
            this.cmbDVT.TabIndex = 5;
            this.cmbDVT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDVT_KeyDown);
            // 
            // cmbLoaiSp
            // 
            this.cmbLoaiSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLoaiSp.FormattingEnabled = true;
            this.cmbLoaiSp.Location = new System.Drawing.Point(384, 231);
            this.cmbLoaiSp.Name = "cmbLoaiSp";
            this.cmbLoaiSp.Size = new System.Drawing.Size(241, 24);
            this.cmbLoaiSp.TabIndex = 3;
            this.cmbLoaiSp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLoaiSp_KeyDown);
            // 
            // cmbNcc
            // 
            this.cmbNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNcc.FormattingEnabled = true;
            this.cmbNcc.Location = new System.Drawing.Point(384, 145);
            this.cmbNcc.Name = "cmbNcc";
            this.cmbNcc.Size = new System.Drawing.Size(241, 24);
            this.cmbNcc.TabIndex = 1;
            this.cmbNcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNcc_KeyDown);
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(384, 61);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(241, 22);
            this.txtTenSp.TabIndex = 0;
            this.txtTenSp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenSp_KeyDown);
            this.txtTenSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSp_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "Đơn Giá";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 36);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dơn Vị Tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 36);
            this.label3.TabIndex = 51;
            this.label3.Text = "Loại Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 36);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nhà Cung Cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 36);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnClear.Image = global::GUI.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(654, 653);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 62);
            this.btnClear.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnClear, "Click Nếu Muốn Xóa Tất Cả");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfirm.Location = new System.Drawing.Point(384, 653);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(157, 62);
            this.btnConfirm.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnConfirm, "Click Dể Xác Nhận Và Nhập Sản Phẩm Mới");
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormNhapSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhapSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhapSanPham";
            this.Load += new System.EventHandler(this.FormNhapSanPham_Load);
            this.panHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemLoaiSp;
        private System.Windows.Forms.Button btnThemNCC;
        public System.Windows.Forms.PictureBox ptbShowImage;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cmbDVT;
        private System.Windows.Forms.ComboBox cmbLoaiSp;
        private System.Windows.Forms.ComboBox cmbNcc;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowsImg;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}