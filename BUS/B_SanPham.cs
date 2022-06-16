using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class B_SanPham
    {
        private static B_SanPham instance;

        public static B_SanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_SanPham();
                }
                return instance;
            }
        }
        //select sản phẩm theo id loại sản phẩm
        [Obsolete]
        public void GetProducByProducType(ref DataGridView data, int id)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.loadSanPhamByLoaiSP(id);
            data.DataSource = sanPhams;
        }

        // select sản phẩm theo danh sách id loại sản phẩm
        [Obsolete]
        public void GetProducByProducTypes(List<int> ids, ref DataGridView data)
        {
            List<SanPham> list = new List<SanPham>();
            if (ids.Count > 0)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    List<SanPham> temp = D_SanPham.Instance.getSanPhamByLoai(ids[i]);
                    foreach (SanPham item in temp)
                    {
                        list.Add(item);
                    }
                }
            }
            else
            {
                list = D_SanPham.Instance.selectAllSanPhamDanghoatDong();
            }           
            data.DataSource = list;
        }

        // load data source đơn vị tính theo id sản phẩm
        [Obsolete]
        public void LoadDataSourceUnitByID(int id, ref ComboBox combox)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            sanPhams.Add(D_SanPham.Instance.LoadSanPhamTheoid(id));
            combox.DisplayMember = "Dvt";
            combox.ValueMember = "Dvt";
            combox.DataSource = sanPhams;
        }

        // Load data source đơn vị tính all (Tất cả đơn vị tính hiện có trong database)
        [Obsolete]
        public void loadDataSourceUnits(ref ComboBox comboBox)
        {

            List<SanPham> sanPhams = D_SanPham.Instance.loadComboBoxDVT();

            comboBox.DisplayMember = "Dvt";
            comboBox.ValueMember = "Dvt";
            comboBox.DataSource = sanPhams;
        }

        // Select tất cả sản phẩm trạng thái đang hoạt động
        [Obsolete]
        public void GetAllSanPhamNoDeleted(ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.selectAllSanPhamDanghoatDong();
            data.DataSource = sanPhams;
        }

        // stoker thêm sản phẩm mới (trả về true | false)
        [Obsolete]
        public bool StokerAddProduc(object[] parameter)
        {
            try
            {
                DAO.D_SanPham.Instance.stokerAddSanPham(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        // stoker Get sản Phẩm mới được thêm vào
        [Obsolete]
        public void StokerGetNewProduct(ref DataTable dataTable)
        {
            SanPham sanPham = D_SanPham.Instance.stokerGetNewProduct();

            dataTable.Columns.Add("id");
            dataTable.Columns.Add("ten_sp");
            dataTable.Columns.Add("id_ncc");
            dataTable.Columns.Add("id_loai");
            dataTable.Columns.Add("sl");
            dataTable.Columns.Add("dvt");
            dataTable.Columns.Add("dongia");
            dataTable.Columns.Add("hinh");
            dataTable.Columns.Add("trangthai");
            dataTable.Rows.Add(sanPham);
        }

        // stoker update số lượng sản phẩm sau khi nhập hàng
        [Obsolete]
        public void StokerUpdateSLSanPham(object[] parameter)
        {
            D_SanPham.Instance.UpdateSLSanPham(parameter);
        }

        // select sản phẩm theo id ( gán các cái properties cho form)
        [Obsolete]
        public void GetProductByID(int id,ref string ten_sp, ref int id_loai, ref int id_ncc, ref int sl, ref decimal dongia, ref byte[] hinh, ref int trangthai)
        {
           SanPham sanPham =  D_SanPham.Instance.LoadSanPhamTheoid(id);
            //int id_sp = sanPham.Idsanpham;
            id_loai = sanPham.Idloaisanpham;
            id_ncc = sanPham.Idnhacungcap;
            ten_sp = sanPham.Tensanpham;
            sl = sanPham.Sl;
            dongia = sanPham.Dongia;
            hinh = sanPham.Hinh;
            trangthai = sanPham.Trangthai;
        }

        // Get sản phẩm theo id nhà cung cấp
        [Obsolete]
        public void GetProductBySupplier(int id, ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.getSanPhamByNCC(id);
            data.DataSource = sanPhams;
        }

        // stoker Update thông tin sản phẩm
        [Obsolete]
        public bool StokerUpdateProduct(object[] parameter)
        {
            try
            {
                D_SanPham.Instance.stokerUpdateSanPham(parameter);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // stoker delete sản phâm
        [Obsolete]
        public bool StokerDeleteProduct(int id)
        {
            try
            {
                D_SanPham.Instance.stokerDeleteSanPham(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        // Get sản phẩm theo loại và nhà cung cấp
        [Obsolete]
        public void GetProductByProductTypeAndSupplier(int id_loai, int id_ncc,ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.SelectSanPhamByLoaiAndNCC(id_loai, id_ncc);
            data.DataSource = sanPhams;
        }

        // Get Sản phẩm số lượng bé hơn 50
        [Obsolete]
        public void GetProductIsOut(ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.getSanPamHetHang();
            data.DataSource = sanPhams;
        }


        // Get sản phẩm số lượng lơn hơn 50
        [Obsolete]
        public void GetProductIsStillInStock(ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.getSanPamConHang();
            data.DataSource = sanPhams;
        }
        [Obsolete]
        public DataTable adminGetTableOneMonth(DateTime date)
        {
            int month = date.Month;
            DataTable dt = new DataTable();
            dt = D_SanPham.Instance.adminGetProductSole(month);
            return dt;
        }
        [Obsolete]
        public DataTable top5ProductSole(DateTime date)
        {
            int month = date.Month;
            DataTable dt = new DataTable();
            dt = D_SanPham.Instance.top5ProductSole(month);
            return dt;
        }
        [Obsolete]
        public DataTable adminGetProductCurrent()
        {
            DataTable dt = new DataTable();
            dt = D_SanPham.Instance.adminGetProductCurrent();
            return dt;
        }
        [Obsolete]
        public DataTable cashierGetAllProduct(int id = 0)
        {
            DataTable dt = new DataTable();
            dt = D_SanPham.Instance.cashierGetAllProduct(id);
            return dt;
        }

        [Obsolete]
        public int getNumberSanPhamByID(int id)
        {
            int number = 0;
            DataTable dt = new DataTable();
            dt = D_SanPham.Instance.getSanPhamByID(id);
            DataRow[] row = dt.Select();
            number = int.Parse(row[0]["SoLuong"].ToString());
            return number;
        }
        [Obsolete]
        public void updateNumberSanPham(int id, decimal number)
        {
            D_SanPham.Instance.updateNumberSanPham(id, number);
        }
    }
}
