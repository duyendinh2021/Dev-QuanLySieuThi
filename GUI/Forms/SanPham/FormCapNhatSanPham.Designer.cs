namespace GUI.Forms.SanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.cmbID_Loaisp = new System.Windows.Forms.ComboBox();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.ptcShowImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcShowImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(81, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Nhà Cung Cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(81, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn Vị Tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(327, 97);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(225, 22);
            this.txtTenSP.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(81, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn Giá";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(327, 537);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(225, 22);
            this.txtDonGia.TabIndex = 1;
            // 
            // btnEditNCC
            // 
            this.btnEditNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNCC.Image = global::GUI.Properties.Resources.writing;
            this.btnEditNCC.Location = new System.Drawing.Point(595, 178);
            this.btnEditNCC.Name = "btnEditNCC";
            this.btnEditNCC.Size = new System.Drawing.Size(84, 33);
            this.btnEditNCC.TabIndex = 6;
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
            this.btnRowImg.TabIndex = 4;
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
            this.btnConfirm.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnConfirm, "Click dể tiến hành cập nhật sản phẩm");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnEditID
            // 
            this.btnEditID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditID.Image = global::GUI.Properties.Resources.writing;
            this.btnEditID.Location = new System.Drawing.Point(595, 297);
            this.btnEditID.Name = "btnEditID";
            this.btnEditID.Size = new System.Drawing.Size(84, 33);
            this.btnEditID.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditID, "Click dể sửa loại sản phẩm");
            this.btnEditID.UseVisualStyleBackColor = true;
            this.btnEditID.Click += new System.EventHandler(this.btnEditID_Click);
            // 
            // btnEditDVT
            // 
            this.btnEditDVT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDVT.Image = global::GUI.Properties.Resources.writing;
            this.btnEditDVT.Location = new System.Drawing.Point(595, 423);
            this.btnEditDVT.Name = "btnEditDVT";
            this.btnEditDVT.Size = new System.Drawing.Size(84, 33);
            this.btnEditDVT.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditDVT, "Cick dể sửa đơn vị tính");
            this.btnEditDVT.UseVisualStyleBackColor = true;
            this.btnEditDVT.Click += new System.EventHandler(this.btnEditDVT_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(81, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Loại Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbNCC
            // 
            this.cmbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(327, 183);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(225, 24);
            this.cmbNCC.TabIndex = 5;
            // 
            // cmbID_Loaisp
            // 
            this.cmbID_Loaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID_Loaisp.FormattingEnabled = true;
            this.cmbID_Loaisp.Location = new System.Drawing.Point(327, 302);
            this.cmbID_Loaisp.Name = "cmbID_Loaisp";
            this.cmbID_Loaisp.Size = new System.Drawing.Size(225, 24);
            this.cmbID_Loaisp.TabIndex = 5;
            // 
            // cmbDVT
            // 
            this.cmbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDVT.FormattingEnabled = true;
            this.cmbDVT.Location = new System.Drawing.Point(327, 428);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(225, 24);
            this.cmbDVT.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::GUI.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(615, 630);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 74);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ptcShowImg
            // 
            this.ptcShowImg.Location = new System.Drawing.Point(794, 188);
            this.ptcShowImg.Name = "ptcShowImg";
            this.ptcShowImg.Size = new System.Drawing.Size(425, 369);
            this.ptcShowImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcShowImg.TabIndex = 2;
            this.ptcShowImg.TabStop = false;
            // 
            // FormCapNhatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 744);
            this.Controls.Add(this.btnEditDVT);
            this.Controls.Add(this.btnEditID);
            this.Controls.Add(this.btnEditNCC);
            this.Controls.Add(this.cmbDVT);
            this.Controls.Add(this.cmbID_Loaisp);
            this.Controls.Add(this.cmbNCC);
            this.Controls.Add(this.btnRowImg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.ptcShowImg);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapNhatSanPham";
            this.Load += new System.EventHandler(this.FormCapNhatSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcShowImg)).EndInit();
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
    }
}