using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using GUI.Forms;
using GUI.Forms.NhaCungCap;
using GUI.Forms.PhieuNhapkho;
using GUI.Forms.SanPham;
using GUI.Forms.NhanVien;
using GUI.Forms.HoaDon;

namespace GUI
{
    public partial class FormMainApp : Form
    {
        [Obsolete]
        public FormMainApp()
        {
            InitializeComponent();

            SupportUI_UX.Instance.leftBorderBtn = new Panel();
            SupportUI_UX.Instance.leftBorderBtn.Size = new Size(7, 60);
            panSideMenu.Controls.Add(SupportUI_UX.Instance.leftBorderBtn);
        }
        public bool isThoat = true;
        public bool isResultmessage = false;

        public event EventHandler LogOut;
        [Obsolete]
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            BUS.B_TaiKhoan.Instance.updateStatusLogin(BUS.B_TaiKhoan.Instance.id);
            BUS.B_TaiKhoan.Instance.id = -1;
            LogOut(this, new EventArgs());
        }


        [Obsolete]
        private void FormMainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                BUS.B_TaiKhoan.Instance.updateStatusLogin(BUS.B_TaiKhoan.Instance.id);
                Application.Exit();
            }
        }

        [Obsolete]
        private void FormMainApp_Load(object sender, EventArgs e)
        {
            CustomizeDesing();
            CheckPower();
        }

        private void CustomizeDesing()
        {
            //Admin
            btnDashboard.Visible = false;
            btnOrders.Visible = false;
            panOrdersManage.Visible = false;
            panelSettingsManage.Visible = false;
            btnProducts.Visible = false;
            btnStaffs.Visible = false;
            //Cashier
            btnSale.Visible = false;
            btnProductsType.Visible = false;
            //Stoker
            btnSTmanageProducts.Visible = false;
            btnbtnAdmissionSlip.Visible = false;
            btnSTmanageProducts.Visible = false;
            btnStockSupplierManagement.Visible = false;
            btnProductsType.Visible=false;

        }

        private void CheckPower()
        {

            switch (BUS.B_TaiKhoan.Instance.quyen)
            {
                case "Admin":
                    //Admin
                    btnDashboard.Visible = true;
                    btnOrders.Visible = true;
                    btnProducts.Visible = true;
                    btnStaffs.Visible = true;
                    break;

                case "Cashier":
                    //Cashier
                    btnSale.Visible = true;
                    btnProductsType.Visible = true;

                    break;

                case "Stoker":
                    //Stoker
                    btnSTmanageProducts.Visible = true;
                    btnbtnAdmissionSlip.Visible = true;
                    btnSTmanageProducts.Visible = true;
                    btnStockSupplierManagement.Visible = true;
                    btnProductsType.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color4);
            SupportUI_UX.Instance.HideSubmenu();
            SupportUI_UX.Instance.showChildForm(new FormDashBoard(), panChildForm);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color1);
            SupportUI_UX.Instance.showChildForm(new FormQuanLyHoaDon(), panChildForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color2);

            // admin View Product

            FormQuanLySanPham formQuanLySanPham = new FormQuanLySanPham();
            SupportUI_UX.Instance.showChildForm(formQuanLySanPham, panChildForm);

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color2);
            SupportUI_UX.Instance.showChildForm(new FormSale(), panChildForm);
        }

        private void btnCashierReport_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color3);
        }

        private void btnSTmanageProducts_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color2);
            FormQuanLySanPham formQuanLySanPham = new FormQuanLySanPham();
            SupportUI_UX.Instance.showChildForm(formQuanLySanPham, panChildForm);
        }

        
        private void btnbtnAdmissionSlip_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.Color7);
            FormQuanLyPhieuNhapKho formQuanLyPhieuNhapKho = new FormQuanLyPhieuNhapKho();
            SupportUI_UX.Instance.showChildForm(formQuanLyPhieuNhapKho, panChildForm);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color5);
            SupportUI_UX.Instance.HideSubmenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color6);
            SupportUI_UX.Instance.ShowSubmenu(panelSettingsManage);
            SupportUI_UX.Instance.HideSubmenu();
        }

        [Obsolete]
        private void btnStaffs_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color3);
            SupportUI_UX.Instance.HideSubmenu();
            FormQuanLyNhanVien formQuanLyNhanVien = new FormQuanLyNhanVien();
            SupportUI_UX.Instance.showChildForm(formQuanLyNhanVien, panChildForm);
        }

        [Obsolete]
        private void btnExit_Click(object sender, EventArgs e)
        {
            BUS.B_TaiKhoan.Instance.updateStatusLogin(B_TaiKhoan.Instance.id);
            Application.Exit();
        }

        private void btnStockSupplierManagement_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color8);
            FormQuanLyNhaCungCap formQuanLyNhaCungCap = new FormQuanLyNhaCungCap();
            SupportUI_UX.Instance.showChildForm(formQuanLyNhaCungCap, panChildForm);
        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
           // SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.Color7);
            FormChangePassWord formChangePassWord = new FormChangePassWord(B_TaiKhoan.Instance.id);
            formChangePassWord.ShowDialog();
        }

        private void btnProductsType_Click(object sender, EventArgs e)
        {

        }
    }
}
