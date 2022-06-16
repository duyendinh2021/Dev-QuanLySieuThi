using BUS;
using FontAwesome.Sharp;
using GUI.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Forms
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }
        public void AddItemTag(string name, string number, IconPictureBox image)
        {
            var w = new Tag()
            {
                Title = name,
                Cost = number,
                Image = image
            };
            panTag.Controls.Add(w);
        }
        [Obsolete]
        private void LoadChart(Chart ob, DateTimePicker pk, DateTimePicker pk1)
        {
            ArrayList NameProduct = new ArrayList();
            ArrayList NumberOfProduct = new ArrayList();
            DataTable dt = B_NhanVien.Instance.LoadDataSumProductEveryDayOfMonth(DateTime.Parse(pk.Value.ToShortDateString()));
            dataGridView1.DataSource = dt;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                NameProduct.Add(row.Cells["Ngay"].Value.ToString());
                NumberOfProduct.Add(row.Cells["TongSo"].Value.ToString());
            }
            ob.Series[1].Points.DataBindXY(NameProduct, NumberOfProduct);
            dt = B_NhanVien.Instance.LoadDataSumProductEveryDayOfMonth(DateTime.Parse(pk1.Value.ToShortDateString()));
            dataGridView2.DataSource = dt;
            ArrayList NameProduct1 = new ArrayList();
            ArrayList NumberOfProduct1 = new ArrayList();
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                NameProduct1.Add(row.Cells["Ngay"].Value.ToString());
                NumberOfProduct1.Add(row.Cells["TongSo"].Value.ToString());
            }
            ob.Series[0].Points.DataBindXY(NameProduct1, NumberOfProduct1);
        }

        [Obsolete]
        private void LoadCirCleChart(Chart obcirlce, DateTimePicker pk)
        {
            ArrayList NameProduct = new ArrayList();
            ArrayList NumberOfProduct = new ArrayList();
            DataTable dt = B_SanPham.Instance.top5ProductSole(DateTime.Parse(pk.Value.ToShortDateString()));
            dataGridView1.DataSource = dt;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                NameProduct.Add(row.Cells["Name"].Value.ToString());
                NumberOfProduct.Add(row.Cells["Value"].Value.ToString());
            }
            obcirlce.Series[0].Points.DataBindXY(NameProduct, NumberOfProduct);

            //ArrayList NameProduct2 = new ArrayList();
            //ArrayList NumberOfProduct2 = new ArrayList();
            //dt = B_NhanVien.Instance.top5NhanVienXuatSac(DateTime.Parse(pk.Value.ToShortDateString()));
            //dataGridView1.DataSource = dt;
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    NameProduct2.Add(row.Cells["Name"].Value.ToString());
            //    string value = string.Format("{0:0.####}", row.Cells["Value"].Value);
            //    NumberOfProduct2.Add(value);
            //}
            //obcirlce1.Series[0].Points.DataBindXY(NameProduct2, NumberOfProduct2);
        }

        [Obsolete]
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadInforOneMonth();
        }

        [Obsolete]
        private void LoadInforOneMonth()
        {
            panTag.Controls.Clear();
            setTagFunctionOneMonth("Doanh Thu", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
            setTagFunctionOneMonth("Sản Phẩm Đã Bán", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
            setTagFunctionOneMonth("Số Hóa Đơn Đã Tạo", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
            setTagFunctionOneMonth("Tài Khoản Login", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
            setTagFunctionOneMonth("Số Sản Phẩm Tồn", DateTime.Parse(dateTimePicker1.Value.ToShortDateString()));
            LoadChart(Chart, dateTimePicker1, dateTimePicker2);
            LoadCirCleChart(ChartTopSP,dateTimePicker1);
        }
        [Obsolete]
        private void setTagFunctionOneMonth(string query, DateTime date)
        {

            switch (query)
            {
                case "Doanh Thu":
                    {
                        IconPictureBox icon = new IconPictureBox();
                        dataGridView1.DataSource = B_HoaDon.Instance.adminGetTableOneMonth(date);
                        icon.IconChar = IconChar.UserTag;
                        if (dataGridView1.RowCount <=0) return;
                        DataGridViewRow row = dataGridView1.Rows[0];
                        string value = string.Format("{0:0.####}", row.Cells["Value"].Value);
                        AddItemTag(query, value + " VNĐ", icon);
                    }
                    break;
                case "Sản Phẩm Đã Bán":
                    {
                        IconPictureBox icon = new IconPictureBox();
                        dataGridView1.DataSource = B_SanPham.Instance.adminGetTableOneMonth(date);
                        icon.IconChar = IconChar.Deezer;
                        if (dataGridView1.RowCount <= 0) return;
                        DataGridViewRow row = dataGridView1.Rows[0];
                        string value = string.Format("{0:0.####}", row.Cells["Value"].Value);
                        AddItemTag(query, value + " Sản Phẩm", icon);
                    }
                    break;
                case "Số Hóa Đơn Đã Tạo":
                    {
                        IconPictureBox icon = new IconPictureBox();
                        dataGridView1.DataSource = B_HoaDon.Instance.adminGetTableSumOrderOneMonth(date);
                        icon.IconChar = IconChar.FileAlt;
                        if (dataGridView1.RowCount <= 0) return;
                        DataGridViewRow row = dataGridView1.Rows[0];
                        string value = string.Format("{0:0.####}", row.Cells["Value"].Value);
                        AddItemTag(query, value + " Hóa Đơn", icon);
                    }
                    break;
                case "Tài Khoản Login":
                    {
                        IconPictureBox icon = new IconPictureBox();
                        dataGridView1.DataSource = B_TaiKhoan.Instance.adminGetTableLoginStatus();
                        icon.IconChar = IconChar.UserAlt;
                        if (dataGridView1.RowCount <= 0) return;
                        DataGridViewRow row = dataGridView1.Rows[0];
                        string value = string.Format("{0:0.####}", row.Cells["Value"].Value);
                        AddItemTag(query, value + " Tài Khoản", icon);
                    }
                    break;
                case "Số Sản Phẩm Tồn":
                    {
                        IconPictureBox icon = new IconPictureBox();
                        dataGridView1.DataSource = B_SanPham.Instance.adminGetProductCurrent();
                        icon.IconChar = IconChar.Qrcode;
                        DataGridViewRow row = dataGridView1.Rows[0];
                        string value = string.Format("{0:0.####}", row.Cells["Value"].Value);
                        AddItemTag(query, value + " Sản Phẩm", icon);
                    }
                    break;
            }
        }
        [Obsolete]
        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            LoadChart(Chart, dateTimePicker1, dateTimePicker2);
        }

        [Obsolete]
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadInforOneMonth();
        }
    }
}
