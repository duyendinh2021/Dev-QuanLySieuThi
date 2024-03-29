﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class B_PhieuNhapKho
    {
        private static B_PhieuNhapKho instance;

        public static B_PhieuNhapKho Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_PhieuNhapKho();
                }
                return instance;
            }
        }


        [Obsolete]
        public bool stokerCreatePhieuNhapKho(object[] parameter)
        {
            try
            {
                D_PhieuNhapKho.Instance.stokerCreatePhieuNhapKho(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        [Obsolete]
        public bool confirmReceipt(int id)
        {
            try
            {
                D_PhieuNhapKho.Instance.confirmReceipt(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


        [Obsolete]
        public int stokerGetNewReceipt() { 
            return D_PhieuNhapKho.Instance.stokerGetNewReceipt();
        }


        [Obsolete]
        public void GetReceiptNotReceivedByStatus(int status,ref DataGridView data)
        {
            List<PhieuNhapKho> phieuNhapKhos = D_PhieuNhapKho.Instance.GetReceiptNotReceivedByStatus(status);
            data.DataSource = phieuNhapKhos;
        }

        [Obsolete]
        public void GetReceiptNotReceived(ref DataGridView data)
        {
            List<PhieuNhapKho> phieuNhapKhos = D_PhieuNhapKho.Instance.GetReceiptNotReceived();
            data.DataSource = phieuNhapKhos;
        }

        [Obsolete]
        public void GetAllPhieuNhapKhoNoDeleted(ref DataGridView data)
        {
            List<PhieuNhapKho> phieuNhapKhos = D_PhieuNhapKho.Instance.GetAllPhieuNhapKhoNoDeleted();
            data.DataSource = phieuNhapKhos;
        }


        [Obsolete]
        public bool StokerDeletePhieuNhapKhoByID(int id)
        {
            try
            {
                D_PhieuNhapKho.Instance.StokerDeletePhieuNhapKhoByID(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


        [Obsolete]
        public void GetReceiptInStarDateToEndDate(DateTime StarDate,DateTime EndDate,ref DataGridView data)
        {
            List<PhieuNhapKho> phieuNhapKhos = D_PhieuNhapKho.Instance.GetReceiptInStarDateToEndDate(StarDate,EndDate);
            data.DataSource = phieuNhapKhos;
        }
    }
}
