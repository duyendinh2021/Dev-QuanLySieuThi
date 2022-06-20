namespace GUI.Components
{
    partial class Wiget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panItem = new System.Windows.Forms.Panel();
            this.panContent = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.panItem.SuspendLayout();
            this.panContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panItem
            // 
            this.panItem.Controls.Add(this.panContent);
            this.panItem.Controls.Add(this.ptbImage);
            this.panItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panItem.Location = new System.Drawing.Point(0, 0);
            this.panItem.Name = "panItem";
            this.panItem.Size = new System.Drawing.Size(324, 150);
            this.panItem.TabIndex = 0;
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.lblCost);
            this.panContent.Controls.Add(this.lblName);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(177, 150);
            this.panContent.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCost.Location = new System.Drawing.Point(-5, 50);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(83, 29);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "10000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "milo";
            // 
            // ptbImage
            // 
            this.ptbImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbImage.Location = new System.Drawing.Point(177, 0);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(147, 150);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Wiget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panItem);
            this.Name = "Wiget";
            this.Size = new System.Drawing.Size(324, 150);
            this.panItem.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Panel panItem;
        public System.Windows.Forms.Panel panContent;
        public System.Windows.Forms.PictureBox ptbImage;
    }
}
