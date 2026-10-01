using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_11_MoveField.Real
{
    public class DanhMucSanPham
    {
        public string TenDanhMuc { get; set; }
        // MOVE FIELD: Di chuyển biến Thuế VAT về đúng nơi quản lý nó
        public double MucThueVat { get; set; }

        public DanhMucSanPham(string tenDanhMuc, double mucThue)
        {
            TenDanhMuc = tenDanhMuc;
            MucThueVat = mucThue;
        }
    }

    public class SanPhamNongDuoc
    {
        public string TenSanPham { get; set; }
        public double GiaGoc { get; set; }
        private DanhMucSanPham _danhMuc;

        public SanPhamNongDuoc(string ten, double giaGoc, DanhMucSanPham danhMuc)
        {
            TenSanPham = ten;
            GiaGoc = giaGoc;
            _danhMuc = danhMuc;
        }

        public void InGiaBanLe()
        {
            // Sản phẩm lấy mức thuế từ Danh mục của nó
            double giaSauThue = GiaGoc + (GiaGoc * _danhMuc.MucThueVat);
            Console.WriteLine($"- {TenSanPham} | Gia Goc: {GiaGoc:N0} | Thuoc nhom: {_danhMuc.TenDanhMuc} (Thue {_danhMuc.MucThueVat * 100}%) => Gia Ban: {giaSauThue:N0} VND");
        }
    }
}