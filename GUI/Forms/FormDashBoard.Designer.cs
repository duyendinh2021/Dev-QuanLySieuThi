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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashBoard));
            this.panTag = new System.Windows.Forms.FlowLayoutPanel();
            this.panFunction = new System.Windows.Forms.Panel();
            this.cmbLuaChon = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSoSanh = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTopSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopSP)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panFunction.Controls.Add(this.cmbLuaChon);
            this.panFunction.Controls.Add(this.dataGridView1);
            this.panFunction.Controls.Add(this.dataGridView2);
            this.panFunction.Controls.Add(this.label2);
            this.panFunction.Controls.Add(this.label1);
            this.panFunction.Controls.Add(this.dateTimePicker1);
            this.panFunction.Controls.Add(this.btnThongKe);
            this.panFunction.Controls.Add(this.btnSoSanh);
            this.panFunction.Controls.Add(this.dateTimePicker2);
            this.panFunction.Location = new System.Drawing.Point(12, 138);
            this.panFunction.Name = "panFunction";
            this.panFunction.Size = new System.Drawing.Size(675, 482);
            this.panFunction.TabIndex = 0;
            // 
            // cmbLuaChon
            // 
            this.cmbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLuaChon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLuaChon.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLuaChon.FormattingEnabled = true;
            this.cmbLuaChon.Items.AddRange(new object[] {
            "Số Lượng Sản Phẩm Bán Hằng Ngày",
            "Số Lượng Sản Phẩm Nhập Hằng Ngày",
            "Doanh Thu Hằng Ngày"});
            this.cmbLuaChon.Location = new System.Drawing.Point(22, 200);
            this.cmbLuaChon.Name = "cmbLuaChon";
            this.cmbLuaChon.Size = new System.Drawing.Size(275, 28);
            this.cmbLuaChon.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(24, 19);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(532, 380);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(24, 19);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.Visible = false;
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
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker1.TabIndex = 0;
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
            this.btnThongKe.TabIndex = 1;
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
            this.btnSoSanh.Location = new System.Drawing.Point(22, 233);
            this.btnSoSanh.Name = "btnSoSanh";
            this.btnSoSanh.Size = new System.Drawing.Size(175, 51);
            this.btnSoSanh.TabIndex = 4;
            this.btnSoSanh.Text = "So Sánh";
            this.toolTip1.SetToolTip(this.btnSoSanh, "Click Dể Tiến Hành So Sánh");
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
            this.dateTimePicker2.Size = new System.Drawing.Size(275, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.Chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisX.MinorGrid.Interval = double.NaN;
            chartArea1.AxisX.MinorGrid.IntervalOffset = double.NaN;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineWidth = 0;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.Size = 3F;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea1.AxisY.MajorTickMark.Size = 2F;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorTickMark.LineWidth = 0;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(0, 626);
            this.Chart.Name = "Chart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageTransparentColor = System.Drawing.Color.Blue;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "SanPhamSoSanh";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.DodgerBlue;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.MediumSlateBlue;
            series2.MarkerColor = System.Drawing.Color.MediumSlateBlue;
            series2.MarkerSize = 10;
            series2.Name = "SanPham";
            series2.ShadowColor = System.Drawing.Color.Blue;
            series2.ShadowOffset = 1;
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(1400, 429);
            this.Chart.TabIndex = 23;
            this.Chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Gainsboro;
            title1.Name = "Title1";
            title1.Text = "Biểu Đồ Thống Kê";
            this.Chart.Titles.Add(title1);
            // 
            // ChartTopSP
            // 
            this.ChartTopSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChartTopSP.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = System.Drawing.Color.Gainsboro;
            legend2.Name = "Legend1";
            this.ChartTopSP.Legends.Add(legend2);
            this.ChartTopSP.Location = new System.Drawing.Point(66, 3);
            this.ChartTopSP.Name = "ChartTopSP";
            this.ChartTopSP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartTopSP.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(100)))), ((int)(((byte)(122))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(128)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(240))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(199)))), ((int)(((byte)(177))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(167)))), ((int)(((byte)(104)))))};
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series3.BackSecondaryColor = System.Drawing.Color.Violet;
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.MediumSlateBlue;
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.Gainsboro;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartTopSP.Series.Add(series3);
            this.ChartTopSP.Size = new System.Drawing.Size(638, 421);
            this.ChartTopSP.TabIndex = 24;
            this.ChartTopSP.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopRight;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Gainsboro;
            title2.Name = "Title1";
            title2.Text = "Top 5 Sản Phẩm";
            this.ChartTopSP.Titles.Add(title2);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ChartTopSP);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(693, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(707, 494);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1400, 1055);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.panFunction);
            this.Controls.Add(this.panTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panFunction.ResumeLayout(false);
            this.panFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopSP)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbLuaChon;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}