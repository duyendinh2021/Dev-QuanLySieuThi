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
        private static Form formChild = null;


        public event EventHandler LogOut;


        [Obsolete]
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
            //update status LogIn
            BUS.B_TaiKhoan.Instance.updateStatusLogin(BUS.B_TaiKhoan.Instance.id);


        }

        [Obsolete]
        private void FormMainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (isThoat)
            {
                Application.Exit();
            }
        }

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
            btnCashierReport.Visible = false;
            //Stoker
            btnSTmanageProducts.Visible = false;
            btnbtnAdmissionSlip.Visible = false;
            btnSTmanageProducts.Visible = false;
            btnStockReport.Visible = false;
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
                    btnCashierReport.Visible = true;
                    break;

                case "Stoker":
                    //Stoker
                    btnSTmanageProducts.Visible = true;
                    btnbtnAdmissionSlip.Visible = true;
                    btnSTmanageProducts.Visible = true;
                    btnStockReport.Visible = true;
                    break;
                default:
                    break;
            }
            //string user = B_TaiKhoan.Instance.chucvu;
            //if (user == "Admin")
            //{
            //    //Admin
            //    btnDashboard.Visible = true;
            //    btnOrders.Visible = true;
            //    btnProducts.Visible = true;
            //    btnAccounts.Visible = true;
            //}
            //else if (user == "Cashier")
            //{
            //    //Cashier
            //    btnSale.Visible = true;
            //    btnCashierReport.Visible = true;
            //}
            //else if (user == "Stoker")
            //{
            //    //Stoker
            //    btnSTmanageProducts.Visible = true;
            //    btnbtnAdmissionSlip.Visible = true;
            //    btnSTmanageProducts.Visible = true;
            //    btnStockReport.Visible = true;
            //}

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color4);
            SupportUI_UX.Instance.HideSubmenu();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color1);
            SupportUI_UX.Instance.ShowSubmenu(panOrdersManage);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color2);
            SupportUI_UX.Instance.HideSubmenu();
        }

        //private void btnAccounts_Click(object sender, EventArgs e)
        //{
        //    SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color3);
        //    SupportUI_UX.Instance.HideSubmenu();
        //}

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
        }

        private void btnbtnAdmissionSlip_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color3);
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

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            SupportUI_UX.Instance.ActivateButton(sender, SupportUI_UX.Instance.color3);
            SupportUI_UX.Instance.HideSubmenu();
            FormQuanLyNhanVien formQuanLyNhanVien = new FormQuanLyNhanVien();
            SupportUI_UX.Instance.showChildForm(formQuanLyNhanVien, panChildForm);
        }
    }
}
