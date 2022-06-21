namespace GUI.Forms.NhanVien
{
    partial class FormChangePassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassWord));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtPassold = new System.Windows.Forms.TextBox();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPassNew2 = new System.Windows.Forms.TextBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.ptcCaptcha = new System.Windows.Forms.PictureBox();
            this.btnRefreshCaptcha = new System.Windows.Forms.Button();
            this.btnConfrim = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptcCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập Mật Khẩu Cũ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Mật Khẩu Mới";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập Mã Xác Minh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(399, 72);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.ReadOnly = true;
            this.txtAcc.Size = new System.Drawing.Size(244, 22);
            this.txtAcc.TabIndex = 1;
            // 
            // txtPassold
            // 
            this.txtPassold.Location = new System.Drawing.Point(399, 159);
            this.txtPassold.Name = "txtPassold";
            this.txtPassold.Size = new System.Drawing.Size(244, 22);
            this.txtPassold.TabIndex = 0;
            this.txtPassold.UseSystemPasswordChar = true;
            this.txtPassold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassold_KeyDown);
            this.txtPassold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassold_KeyPress);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(399, 246);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(244, 22);
            this.txtPassNew.TabIndex = 1;
            this.txtPassNew.UseSystemPasswordChar = true;
            this.txtPassNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassNew_KeyPress);
            // 
            // txtPassNew2
            // 
            this.txtPassNew2.Location = new System.Drawing.Point(399, 333);
            this.txtPassNew2.Name = "txtPassNew2";
            this.txtPassNew2.Size = new System.Drawing.Size(244, 22);
            this.txtPassNew2.TabIndex = 2;
            this.txtPassNew2.UseSystemPasswordChar = true;
            this.txtPassNew2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassNew2_KeyPress);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(399, 420);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(244, 22);
            this.txtCaptcha.TabIndex = 3;
            // 
            // ptcCaptcha
            // 
            this.ptcCaptcha.Location = new System.Drawing.Point(752, 103);
            this.ptcCaptcha.Name = "ptcCaptcha";
            this.ptcCaptcha.Size = new System.Drawing.Size(234, 78);
            this.ptcCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptcCaptcha.TabIndex = 2;
            this.ptcCaptcha.TabStop = false;
            // 
            // btnRefreshCaptcha
            // 
            this.btnRefreshCaptcha.Image = global::GUI.Properties.Resources.refresh;
            this.btnRefreshCaptcha.Location = new System.Drawing.Point(834, 186);
            this.btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            this.btnRefreshCaptcha.Size = new System.Drawing.Size(116, 44);
            this.btnRefreshCaptcha.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnRefreshCaptcha, "Click Dể Dủ Mã Xác Minh");
            this.btnRefreshCaptcha.UseVisualStyleBackColor = true;
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.btnRefreshCaptcha_Click);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Image = global::GUI.Properties.Resources.confirmation;
            this.btnConfrim.Location = new System.Drawing.Point(399, 494);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(204, 61);
            this.btnConfrim.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnConfrim, "Click dể xác nhận và tiến hành cập nhật");
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfrim_Click);
            // 
            // FormChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 588);
            this.Controls.Add(this.btnConfrim);
            this.Controls.Add(this.btnRefreshCaptcha);
            this.Controls.Add(this.ptcCaptcha);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.txtPassNew2);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtPassold);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptcCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtPassold;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPassNew2;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.PictureBox ptcCaptcha;
        private System.Windows.Forms.Button btnRefreshCaptcha;
        private System.Windows.Forms.Button btnConfrim;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}