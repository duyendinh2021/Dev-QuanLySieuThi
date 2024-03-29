﻿namespace GUI.Forms.SanPham
{
    partial class FormCapNhatSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapNhatSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditNCC = new System.Windows.Forms.Button();
            this.btnRowImg = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnEditID = new System.Windows.Forms.Button();
            this.btnEditDVT = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.cmbID_Loaisp = new System.Windows.Forms.ComboBox();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.ptcShowImg = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.btneditTrangThai = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcShowImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(81, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Nhà Cung Cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(81, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn Vị Tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(327, 97);
            this.txtTenSP.MaxLength = 50;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(225, 22);
            this.txtTenSP.TabIndex = 0;
            this.txtTenSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenSP_KeyDown);
            this.txtTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSP_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(81, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn Giá";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(327, 545);
            this.txtDonGia.MaxLength = 255;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(225, 22);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDonGia_KeyDown);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // btnEditNCC
            // 
            this.btnEditNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNCC.Image = global::GUI.Properties.Resources.writing;
            this.btnEditNCC.Location = new System.Drawing.Point(595, 176);
            this.btnEditNCC.Name = "btnEditNCC";
            this.btnEditNCC.Size = new System.Drawing.Size(84, 33);
            this.btnEditNCC.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEditNCC, "Click dể Sửa Nhà Cung Cấp");
            this.btnEditNCC.UseVisualStyleBackColor = true;
            this.btnEditNCC.Click += new System.EventHandler(this.btnEditNCC_Click);
            // 
            // btnRowImg
            // 
            this.btnRowImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRowImg.Image = global::GUI.Properties.Resources.photo;
            this.btnRowImg.Location = new System.Drawing.Point(794, 95);
            this.btnRowImg.Name = "btnRowImg";
            this.btnRowImg.Size = new System.Drawing.Size(128, 66);
            this.btnRowImg.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnRowImg, "Click dể tiến hành thay đổi hình ảnh sản phẩm");
            this.btnRowImg.UseVisualStyleBackColor = true;
            this.btnRowImg.Click += new System.EventHandler(this.btnRowImg_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfirm.Location = new System.Drawing.Point(327, 630);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(151, 74);
            this.btnConfirm.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnConfirm, "Click dể tiến hành cập nhật sản phẩm");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnEditID
            // 
            this.btnEditID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditID.Image = global::GUI.Properties.Resources.writing;
            this.btnEditID.Location = new System.Drawing.Point(595, 266);
            this.btnEditID.Name = "btnEditID";
            this.btnEditID.Size = new System.Drawing.Size(84, 33);
            this.btnEditID.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEditID, "Click dể sửa loại sản phẩm");
            this.btnEditID.UseVisualStyleBackColor = true;
            this.btnEditID.Click += new System.EventHandler(this.btnEditID_Click);
            // 
            // btnEditDVT
            // 
            this.btnEditDVT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDVT.Image = global::GUI.Properties.Resources.writing;
            this.btnEditDVT.Location = new System.Drawing.Point(595, 356);
            this.btnEditDVT.Name = "btnEditDVT";
            this.btnEditDVT.Size = new System.Drawing.Size(84, 33);
            this.btnEditDVT.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditDVT, "Cick dể sửa đơn vị tính");
            this.btnEditDVT.UseVisualStyleBackColor = true;
            this.btnEditDVT.Click += new System.EventHandler(this.btnEditDVT_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::GUI.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(615, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 74);
            this.btnClear.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnClear, "Click Nếu Muốn Xóa Tất Cả");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(81, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Loại Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbNCC
            // 
            this.cmbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(327, 185);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(225, 24);
            this.cmbNCC.TabIndex = 1;
            this.cmbNCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNCC_KeyDown);
            // 
            // cmbID_Loaisp
            // 
            this.cmbID_Loaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID_Loaisp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbID_Loaisp.FormattingEnabled = true;
            this.cmbID_Loaisp.Location = new System.Drawing.Point(327, 275);
            this.cmbID_Loaisp.Name = "cmbID_Loaisp";
            this.cmbID_Loaisp.Size = new System.Drawing.Size(225, 24);
            this.cmbID_Loaisp.TabIndex = 3;
            this.cmbID_Loaisp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbID_Loaisp_KeyDown);
            // 
            // cmbDVT
            // 
            this.cmbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDVT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDVT.FormattingEnabled = true;
            this.cmbDVT.Location = new System.Drawing.Point(327, 365);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(225, 24);
            this.cmbDVT.TabIndex = 5;
            this.cmbDVT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDVT_KeyDown);
            // 
            // ptcShowImg
            // 
            this.ptcShowImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptcShowImg.Location = new System.Drawing.Point(3, 18);
            this.ptcShowImg.Name = "ptcShowImg";
            this.ptcShowImg.Size = new System.Drawing.Size(403, 375);
            this.ptcShowImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcShowImg.TabIndex = 2;
            this.ptcShowImg.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(81, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trạng Thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(327, 455);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(225, 24);
            this.cmbTrangThai.TabIndex = 11;
            this.cmbTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTrangThai_KeyDown);
            // 
            // btneditTrangThai
            // 
            this.btneditTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditTrangThai.Image = global::GUI.Properties.Resources.writing;
            this.btneditTrangThai.Location = new System.Drawing.Point(595, 446);
            this.btneditTrangThai.Name = "btneditTrangThai";
            this.btneditTrangThai.Size = new System.Drawing.Size(84, 33);
            this.btneditTrangThai.TabIndex = 6;
            this.btneditTrangThai.UseVisualStyleBackColor = true;
            this.btneditTrangThai.Click += new System.EventHandler(this.btneditTrangThai_Click);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(1072, 630);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "1 : Hoạt Động";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(1072, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "0 : Ngừng Hoạt Động";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(919, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Chú Thích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptcShowImg);
            this.groupBox1.Location = new System.Drawing.Point(794, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 396);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh Sản Phẩm";
            // 
            // FormCapNhatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 744);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.btneditTrangThai);
            this.Controls.Add(this.btnEditDVT);
            this.Controls.Add(this.btnEditID);
            this.Controls.Add(this.btnEditNCC);
            this.Controls.Add(this.cmbDVT);
            this.Controls.Add(this.cmbID_Loaisp);
            this.Controls.Add(this.cmbNCC);
            this.Controls.Add(this.btnRowImg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapNhatSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Sản Phẩm";
            this.Load += new System.EventHandler(this.FormCapNhatSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcShowImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.PictureBox ptcShowImg;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRowImg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.ComboBox cmbID_Loaisp;
        private System.Windows.Forms.ComboBox cmbDVT;
        private System.Windows.Forms.Button btnEditNCC;
        private System.Windows.Forms.Button btnEditID;
        private System.Windows.Forms.Button btnEditDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btneditTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}