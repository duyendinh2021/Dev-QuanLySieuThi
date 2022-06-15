namespace GUI.Forms.SanPham
{
    partial class FormViewSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.ptbShowImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbLoaiSp = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbNcc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nhà Cung Cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "Loại Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dơn Vị Tính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 36);
            this.label6.TabIndex = 54;
            this.label6.Text = "Đơn Giá";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(384, 61);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.ReadOnly = true;
            this.txtTenSp.Size = new System.Drawing.Size(241, 22);
            this.txtTenSp.TabIndex = 56;
            // 
            // cmbDVT
            // 
            this.cmbDVT.FormattingEnabled = true;
            this.cmbDVT.Location = new System.Drawing.Point(384, 320);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(241, 24);
            this.cmbDVT.TabIndex = 60;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(384, 405);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(241, 22);
            this.txtDonGia.TabIndex = 61;
            // 
            // ptbShowImage
            // 
            this.ptbShowImage.Location = new System.Drawing.Point(883, 58);
            this.ptbShowImage.Name = "ptbShowImage";
            this.ptbShowImage.Size = new System.Drawing.Size(342, 369);
            this.ptbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbShowImage.TabIndex = 63;
            this.ptbShowImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbShowImage);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.cmbDVT);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.cmbLoaiSp);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbNcc);
            this.groupBox1.Controls.Add(this.txtTenSp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1436, 572);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(384, 320);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(241, 24);
            this.comboBox3.TabIndex = 60;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(384, 222);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(241, 24);
            this.comboBox2.TabIndex = 59;
            // 
            // cmbLoaiSp
            // 
            this.cmbLoaiSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSp.FormattingEnabled = true;
            this.cmbLoaiSp.Location = new System.Drawing.Point(384, 222);
            this.cmbLoaiSp.Name = "cmbLoaiSp";
            this.cmbLoaiSp.Size = new System.Drawing.Size(241, 24);
            this.cmbLoaiSp.TabIndex = 59;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 58;
            // 
            // cmbNcc
            // 
            this.cmbNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNcc.FormattingEnabled = true;
            this.cmbNcc.Location = new System.Drawing.Point(384, 145);
            this.cmbNcc.Name = "cmbNcc";
            this.cmbNcc.Size = new System.Drawing.Size(241, 24);
            this.cmbNcc.TabIndex = 58;
            // 
            // FormViewSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 572);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormViewSanPham";
            this.Load += new System.EventHandler(this.FormViewSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.ComboBox cmbDVT;
        private System.Windows.Forms.TextBox txtDonGia;
        public System.Windows.Forms.PictureBox ptbShowImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLoaiSp;
        private System.Windows.Forms.ComboBox cmbNcc;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}