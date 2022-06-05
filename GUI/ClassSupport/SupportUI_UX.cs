using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class SupportUI_UX
    {
        private static SupportUI_UX _instance;

        public static SupportUI_UX Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SupportUI_UX();
                }
                return _instance;
            }
        }
        public IconButton currentBtn;
        public Panel leftBorderBtn;
        public Form activeFrom = null;
        public Color color1 = Color.FromArgb(172, 126, 241);
        public Color color2 = Color.FromArgb(249, 118, 176);
        public Color color3 = Color.FromArgb(253, 138, 114);
        public Color color4 = Color.FromArgb(95, 77, 221);
        public Color color5 = Color.FromArgb(249, 88, 155);
        public Color color6 = Color.FromArgb(24, 161, 251);
        public void ActivateButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        public void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void HideSubmenu(Panel panOrdersManage)
        {
            if (panOrdersManage.Visible == true)
                panOrdersManage.Visible = false;
            // muti....
        }
        public void HideSubmenu()
        {
            Panel panOrdersManage = new Panel();
            if (panOrdersManage.Visible == true)
                panOrdersManage.Visible = false;
            // muti....
        }
        public void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        public void showChildForm(Form chideForm, Panel panChildForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = chideForm;
            chideForm.TopLevel = false;
            chideForm.FormBorderStyle = FormBorderStyle.None;
            chideForm.Dock = DockStyle.Fill;
            panChildForm.Controls.Add(chideForm);
            panChildForm.Tag = chideForm;
            chideForm.BringToFront();
            chideForm.Show();
        }
    }
}
