namespace GUI.Forms
{
    partial class FormNhapLoaiSP
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
            this.grbLoaiSP = new System.Windows.Forms.GroupBox();
            this.btnBrowsImg = new System.Windows.Forms.Button();
            this.ptcbShowImg = new System.Windows.Forms.PictureBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panHeader.SuspendLayout();
            this.grbLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbShowImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1067, 53);
            this.panHeader.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(983, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 53);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbLoaiSP
            // 
            this.grbLoaiSP.Controls.Add(this.btnBrowsImg);
            this.grbLoaiSP.Controls.Add(this.ptcbShowImg);
            this.grbLoaiSP.Controls.Add(this.txtMoTa);
            this.grbLoaiSP.Controls.Add(this.txtTenSP);
            this.grbLoaiSP.Controls.Add(this.label3);
            this.grbLoaiSP.Controls.Add(this.label1);
            this.grbLoaiSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbLoaiSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoaiSP.Location = new System.Drawing.Point(0, 53);
            this.grbLoaiSP.Name = "grbLoaiSP";
            this.grbLoaiSP.Size = new System.Drawing.Size(1067, 320);
            this.grbLoaiSP.TabIndex = 0;
            this.grbLoaiSP.TabStop = false;
            this.grbLoaiSP.Text = "Thông Tin Loại Sản Phẩm";
            // 
            // btnBrowsImg
            // 
            this.btnBrowsImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(88)))));
            this.btnBrowsImg.Image = global::GUI.Properties.Resources.photo;
            this.btnBrowsImg.Location = new System.Drawing.Point(714, 61);
            this.btnBrowsImg.Name = "btnBrowsImg";
            this.btnBrowsImg.Size = new System.Drawing.Size(123, 37);
            this.btnBrowsImg.TabIndex = 2;
            this.btnBrowsImg.UseVisualStyleBackColor = false;
            this.btnBrowsImg.Click += new System.EventHandler(this.btnBrowsImg_Click);
            this.btnBrowsImg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBrowsImg_KeyDown);
            // 
            // ptcbShowImg
            // 
            this.ptcbShowImg.Location = new System.Drawing.Point(714, 107);
            this.ptcbShowImg.Name = "ptcbShowImg";
            this.ptcbShowImg.Size = new System.Drawing.Size(180, 180);
            this.ptcbShowImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcbShowImg.TabIndex = 21;
            this.ptcbShowImg.TabStop = false;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(322, 159);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(246, 85);
            this.txtMoTa.TabIndex = 1;
            this.txtMoTa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoTa_KeyDown);
            this.txtMoTa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoTa_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(322, 77);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(246, 30);
            this.txtTenSP.TabIndex = 0;
            this.txtTenSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenSP_KeyDown);
            this.txtTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSP_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mô Tả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên Loại Sản Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(147)))), ((int)(((byte)(53)))));
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Image = global::GUI.Properties.Resources.clear;
            this.btnClearAll.Location = new System.Drawing.Point(411, 422);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(157, 71);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(175)))), ((int)(((byte)(88)))));
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfirm.Location = new System.Drawing.Point(134, 422);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(157, 71);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormNhapLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grbLoaiSP);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapLoaiSP";
            this.Text = "FormNhapLoaiSP";
            this.panHeader.ResumeLayout(false);
            this.grbLoaiSP.ResumeLayout(false);
            this.grbLoaiSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbShowImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.GroupBox grbLoaiSP;
        private System.Windows.Forms.Button btnBrowsImg;
        private System.Windows.Forms.PictureBox ptcbShowImg;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClearAll;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}