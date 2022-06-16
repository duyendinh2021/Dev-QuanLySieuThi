namespace GUI.Forms
{
    partial class FormDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panTag = new System.Windows.Forms.FlowLayoutPanel();
            this.panFunction = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTopSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panTag
            // 
            this.panTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTag.Location = new System.Drawing.Point(0, 0);
            this.panTag.Name = "panTag";
            this.panTag.Size = new System.Drawing.Size(1400, 132);
            this.panTag.TabIndex = 20;
            // 
            // panFunction
            // 
            this.panFunction.Controls.Add(this.label2);
            this.panFunction.Controls.Add(this.label1);
            this.panFunction.Controls.Add(this.dateTimePicker1);
            this.panFunction.Controls.Add(this.btnThongKe);
            this.panFunction.Controls.Add(this.btnSoSanh);
            this.panFunction.Controls.Add(this.dateTimePicker2);
            this.panFunction.Location = new System.Drawing.Point(12, 138);
            this.panFunction.Name = "panFunction";
            this.panFunction.Size = new System.Drawing.Size(372, 259);
            this.panFunction.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Chọn tháng cần so sánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chọn tháng cần thống kê";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.CustomFormat = "MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.Location = new System.Drawing.Point(22, 77);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(175, 51);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSoSanh
            // 
            this.btnSoSanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btnSoSanh.FlatAppearance.BorderSize = 0;
            this.btnSoSanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoSanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSoSanh.Location = new System.Drawing.Point(22, 199);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(175, 51);
            this.btnSoSanh.TabIndex = 23;
            this.btnSoSanh.Text = "So Sánh";
            this.btnSoSanh.UseVisualStyleBackColor = false;
            this.btnSoSanh.Click += new System.EventHandler(this.btnSoSanh_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker2.CustomFormat = "MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(22, 171);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.Chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.AxisX.IsMarginVisible = false;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineWidth = 0;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.MajorTickMark.Size = 2F;
            chartArea7.AxisX.MinorGrid.Interval = double.NaN;
            chartArea7.AxisX.MinorGrid.IntervalOffset = double.NaN;
            chartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.MinorGrid.LineWidth = 0;
            chartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MinorTickMark.Size = 3F;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea7.AxisY.MajorTickMark.Size = 2F;
            chartArea7.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea7.AxisY.MinorTickMark.LineWidth = 0;
            chartArea7.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisY2.LineWidth = 0;
            chartArea7.AxisY2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea7.BackColor = System.Drawing.Color.Transparent;
            chartArea7.BackSecondaryColor = System.Drawing.Color.White;
            chartArea7.BorderColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea7);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend7.BackColor = System.Drawing.Color.Transparent;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.ForeColor = System.Drawing.Color.Gainsboro;
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.Chart.Legends.Add(legend7);
            this.Chart.Location = new System.Drawing.Point(0, 626);
            this.Chart.Name = "Chart";
            series10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series10.BackImageTransparentColor = System.Drawing.Color.Blue;
            series10.BackSecondaryColor = System.Drawing.Color.Transparent;
            series10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series10.Color = System.Drawing.Color.RoyalBlue;
            series10.Legend = "Legend1";
            series10.Name = "SanPhamSoSanh";
            series11.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series11.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series11.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series11.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series11.BorderColor = System.Drawing.Color.White;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.RoyalBlue;
            series11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.LabelForeColor = System.Drawing.Color.DodgerBlue;
            series11.Legend = "Legend1";
            series11.MarkerBorderColor = System.Drawing.Color.MediumSlateBlue;
            series11.MarkerColor = System.Drawing.Color.MediumSlateBlue;
            series11.MarkerSize = 10;
            series11.Name = "SanPham";
            series11.ShadowColor = System.Drawing.Color.Blue;
            series11.ShadowOffset = 1;
            this.Chart.Series.Add(series10);
            this.Chart.Series.Add(series11);
            this.Chart.Size = new System.Drawing.Size(1400, 429);
            this.Chart.TabIndex = 23;
            this.Chart.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.ForeColor = System.Drawing.Color.Gainsboro;
            title7.Name = "Title1";
            title7.Text = "Biểu Đồ Thống Kê Sản Phẩm Bán Ra Mỗi Ngày";
            this.Chart.Titles.Add(title7);
            // 
            // ChartTopSP
            // 
            this.ChartTopSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            chartArea8.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.ChartTopSP.ChartAreas.Add(chartArea8);
            legend8.BackColor = System.Drawing.Color.Transparent;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.ForeColor = System.Drawing.Color.Gainsboro;
            legend8.Name = "Legend1";
            this.ChartTopSP.Legends.Add(legend8);
            this.ChartTopSP.Location = new System.Drawing.Point(478, 3);
            this.ChartTopSP.Name = "ChartTopSP";
            this.ChartTopSP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartTopSP.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(100)))), ((int)(((byte)(122))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(128)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(240))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(199)))), ((int)(((byte)(177))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(167)))), ((int)(((byte)(104)))))};
            series12.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series12.BackSecondaryColor = System.Drawing.Color.Violet;
            series12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Color = System.Drawing.Color.MediumSlateBlue;
            series12.IsValueShownAsLabel = true;
            series12.LabelForeColor = System.Drawing.Color.Gainsboro;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.ChartTopSP.Series.Add(series12);
            this.ChartTopSP.Size = new System.Drawing.Size(529, 421);
            this.ChartTopSP.TabIndex = 24;
            this.ChartTopSP.Text = "chart1";
            title8.Alignment = System.Drawing.ContentAlignment.TopRight;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.ForeColor = System.Drawing.Color.Gainsboro;
            title8.Name = "Title1";
            title8.Text = "Top 5 Sản Phẩm";
            this.ChartTopSP.Titles.Add(title8);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(24, 19);
            this.dataGridView1.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ChartTopSP);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(390, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1010, 494);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 403);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(24, 19);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.Visible = false;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1400, 1055);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.panFunction);
            this.Controls.Add(this.panTag);
            this.Name = "FormDashBoard";
            this.Text = "FormDashBoard";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panFunction.ResumeLayout(false);
            this.panFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panTag;
        private System.Windows.Forms.Panel panFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSoSanh;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTopSP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}