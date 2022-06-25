using BUS;
using FontAwesome.Sharp;
using GUI.ClassSupport;
using GUI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSale : Form
    {
        private double loiNhuan = 0.25;
        decimal sumCost = 0;

        [Obsolete]
        public FormSale()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        [Obsolete]
        private void frmSale_Load(object sender, EventArgs e)
        {
            loadProduct();
            IconButton btn = new IconButton();
            btn.Text = "Tất cả";
            btn.IconChar = IconChar.Qrcode;
            Addbtn(btn, 0);
            LoadButtonProduct();

        }

        public void AddItem(string name, string cost, Image image, int id, int id_loai)
        {
            var w = new Wiget()
            {
                Title = name,
                Cost = cost,
                Image = image,
                Id = id,
                Id_loai = id_loai
            };
            panSanPham.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {

                var wdg = (Wiget)ss;
                foreach (DataGridViewRow item in dgvHoaDon.Rows)
                {
                    if (item.Cells["Item"].Value.ToString() == wdg.Title)
                    {
                        item.Cells["QTY"].Value = decimal.Parse(item.Cells["QTY"].Value.ToString()) + 1;
                        item.Cells["COST"].Value = decimal.Parse(item.Cells["QTY"].Value.ToString()) * decimal.Parse(wdg.Cost.ToString());
                        calSumCost();
                        return;
                    }
                }
                dgvHoaDon.Rows.Add(new object[] { wdg.Title, 1, wdg.Cost, wdg.Id });
                calSumCost();
            };
        }

        [Obsolete]
        public void Addbtn(IconButton btn, int id)
        {
            var w = new ButtonCategory()
            {
                Button = btn,
                ID_Loai = id,
            };
            panSideMenu.Controls.Add(w);

            w.OnSelect += (ss, ee) =>
            {
                var wdg = (ButtonCategory)ss;
                //loadProduct(wdg.ID_Loai);
                categoryLoad(wdg.ID_Loai);
            };
        }

        [Obsolete]
        private void LoadButtonProduct()
        {
            //dataGridView1.DataSource = B_LoaiSanPham.Instance.cashierLoadLoaiSP();
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    string name = row.Cells["TenLoaiSanPham"].Value.ToString();
            //    int id_LSP = int.Parse(row.Cells["ID_LoaiSanPham"].Value.ToString());
            //    IconButton btn = new IconButton();
            //    btn.Text = name;
            //    btn.IconChar = IconChar.None;
            //    Addbtn(btn, id_LSP);
            //}

            DataTable dt = B_LoaiSanPham.Instance.cashierLoadLoaiSP();
            foreach (DataRow item in dt.Rows)
            {
                string name = item["TenLoaiSanPham"].ToString();
                int id_LSP = int.Parse(item["ID_LoaiSanPham"].ToString());
                IconButton btn = new IconButton();
                btn.Text = name;
                btn.IconChar = IconChar.None;
                Addbtn(btn, id_LSP);
            }

            //B_LoaiSanPham.Instance.CashierGetProductTypes(ref dataGridView1);
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    string name = row.Cells["Tensanpham"].Value.ToString();
            //    int id_LSP = int.Parse(row.Cells["Idloaisanpham"].Value.ToString());

            //    IconButton btn = new IconButton();
            //    btn.Text = name;
            //    btn.IconChar = IconChar.None;
            //    Addbtn(btn, id_LSP);
            //}
        }

        private void categoryLoad(int id)
        {
            foreach (Control control in panSanPham.Controls)
            {
                if (control.GetType() == typeof(Wiget))
                {
                    if (id == 0)
                    {
                        ((Wiget)control).Visible = true;
                    }
                    else if (((Wiget)control).Id_loai == id)
                    {
                        ((Wiget)control).Visible = true;
                    }
                    else
                    {
                        ((Wiget)control).Visible = false;
                    }
                }
            }
        }

        private void searchLoad()
        {
            string key = txtSearch.Text.ToUpper();
            foreach (Control control in panSanPham.Controls)
            {
                if (control.GetType() == typeof(Wiget))
                {
                    if ((((Wiget)control).Title.ToUpper()).Contains(key))
                    {
                        ((Wiget)control).Visible = true;
                    }
                    else
                    {
                        ((Wiget)control).Visible = false;
                    }
                }
            }
        }

        [Obsolete]
        private void loadProduct(int id = 0)
        {
            panSanPham.Controls.Clear();
            dataGridView2.DataSource = B_SanPham.Instance.cashierGetAllProduct(id);
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                decimal price = (decimal)((double.Parse(row.Cells["Price"].Value.ToString()) * loiNhuan) + double.Parse(row.Cells["Price"].Value.ToString()));
                string value = string.Format("{0:0.####}", price);
                string name = row.Cells["Name"].Value.ToString();
                Image image = null;
                int id_Loai = int.Parse(row.Cells["L_ID"].Value.ToString());
                SupportLogic.Instance.byteArrayToImage((byte[])row.Cells["Image"].Value, ref image);
                int id_SP = int.Parse(row.Cells["SP_ID"].Value.ToString());
                AddItem(name, value, image, id_SP, id_Loai);
            }
        }
        private void calSumCost()
        {
            decimal cost = 0;
            foreach (DataGridViewRow item in dgvHoaDon.Rows)
            {
                cost += decimal.Parse(item.Cells["COST"].Value.ToString());
            }
            sumCost = cost;
            txtTongTien.Text = sumCost.ToString();
        }

        [Obsolete]
        private void btnCal_Click(object sender, EventArgs e)
        {

            if (txtTongTien.Text != "")
            {
                decimal sumCost1 = decimal.Parse(txtTongTien.Text);
                if (txtKhachDua.Text != "")
                {
                    decimal payCost = decimal.Parse(txtKhachDua.Text);
                    if (payCost - sumCost1 >= 0)
                    {
                        //kiểm tra số lượng sản phẩm tồn trong database


                        // try catch 

                        try
                        {
                            string name = "";
                            int slKho = 0;
                            bool isCheckNumber = true;
                            foreach (DataGridViewRow item in dgvHoaDon.Rows)
                            {
                                name = item.Cells["Item"].Value.ToString();
                                int slSanPham = int.Parse(item.Cells["QTY"].Value.ToString());
                                int id_SP = int.Parse(item.Cells["ID"].Value?.ToString());
                                slKho = B_SanPham.Instance.getNumberSanPhamByID(id_SP);
                                if (slKho - slSanPham < 0)
                                {
                                    isCheckNumber = false;
                                    break;
                                }
                            }
                            if (isCheckNumber)
                            {
                                decimal tienThua = payCost - sumCost1;
                                txtTienThua.Text = tienThua.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Sản phẩm không đủ, Tồn kho còn " + name + " " + slKho.ToString() + " hàng !", "Thông báo!");
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Data err !!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Không đủ tiền!", "Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập số tiền!", "Thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm!", "Thông báo!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKhachDua.Clear();
            txtTienThua.Clear();
            txtTongTien.Clear();
            dgvHoaDon.Rows.Clear();
        }

        [Obsolete]
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text != "")
            {
                decimal sumCost1 = decimal.Parse(txtTongTien.Text);
                if (txtKhachDua.Text != "")
                {
                    decimal payCost = decimal.Parse(txtKhachDua.Text);
                    if (payCost - sumCost1 >= 0)
                    {
                        if (txtTienThua.Text != "")
                        {
                            //lấy tổng giá
                            object[] objects = new object[] { B_TaiKhoan.Instance.id, sumCost1 };
                            //Lưu Hóa Đơn InsertHoaDon, cashierAddHoaDon
                            if (B_HoaDon.Instance.cashierAddHoaDon(objects))
                            {
                                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo");
                                //Lưu chi tiết hóa đơn
                                //lấy id hóa đơn vừa thêm vào
                                int id_HD = B_HoaDon.Instance.cashierGetHoaDonID();
                                foreach (DataGridViewRow row in dgvHoaDon.Rows)
                                {
                                    //Ở đây chiết khấu tôi sẽ set cứng là 0
                                    // Fields @id_HD , @id_SanPham , @dongia , @soluong , @chietkhau
                                    int id_SP = int.Parse(row.Cells["ID"].Value.ToString());
                                    decimal cost = decimal.Parse(row.Cells["COST"].Value.ToString());
                                    decimal qty = decimal.Parse(row.Cells["QTY"].Value.ToString());
                                    object[] objectsct = new object[] { id_HD, id_SP, cost, qty, 0 };
                                    B_ChiTietHoaDon.Instance.cashierAddCTHoaDon(objectsct);
                                    //Cập nhật lại database
                                    B_SanPham.Instance.updateNumberSanPham(id_SP, qty);
                                }
                                loadProduct();
                                btnReset_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thất bại!", "Thông báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa tính tiền!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không đủ tiền!", "Thông báo!");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập số tiền!", "Thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm!", "Thông báo!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchLoad();
        }

        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    dgvHoaDon.Rows.RemoveAt(e.RowIndex);
                    calSumCost();
                }
            }
        }
        decimal baseQTY = 1;
        decimal CostAtItem = 1;
        private void dgvHoaDon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                baseQTY = decimal.Parse(dgvHoaDon[1, e.RowIndex].Value.ToString());
                CostAtItem = decimal.Parse(dgvHoaDon[2, e.RowIndex].Value.ToString());
            }
        }

        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (e.ColumnIndex == 1 && dgvHoaDon[1, e.RowIndex].Value != null)
                    {
                        decimal baseCost = CostAtItem / baseQTY;
                        dgvHoaDon[2, e.RowIndex].Value = string.Format("{0:####}", decimal.Parse(dgvHoaDon[1, e.RowIndex].Value.ToString()) * baseCost);
                        calSumCost();
                    }
                }
            }
            catch (Exception)
            {
                dgvHoaDon[1, e.RowIndex].Value = baseQTY;
            }

        }

        private void txtKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
