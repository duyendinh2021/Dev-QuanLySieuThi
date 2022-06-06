using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ClassSupport
{
    public class SupportLogic
    {
        private static SupportLogic instance;

        public static SupportLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SupportLogic();
                }
                return instance;
            }
        }

        public string getPathFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            string sPathImg = "";
            file.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            file.FilterIndex = 1;
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    sPathImg = file.FileName;
                }
                catch (Exception)
                {
                    sPathImg = "";
                }

            }
            return sPathImg;
        }

        public Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
