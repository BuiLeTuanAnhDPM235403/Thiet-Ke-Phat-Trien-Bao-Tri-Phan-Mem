using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate.Real
{
    public class ChiNhanh
    {
        public string TenChiNhanh { get; set; }
        public string QuanLyChiNhanh { get; set; }

        public ChiNhanh(string ten, string quanLy)
        {
            TenChiNhanh = ten;
            QuanLyChiNhanh = quanLy;
        }
    }

    public class NhanVienNongDuoc
    {
        public string TenNhanVien { get; set; }
        // Giấu thông tin Chi nhánh không cho ai trực tiếp can thiệp
        private ChiNhanh _chiNhanhTrucThuoc;

        public NhanVienNongDuoc(string ten, ChiNhanh chiNhanh)
        {
            TenNhanVien = ten;
            _chiNhanhTrucThuoc = chiNhanh;
        }

        // HIDE DELEGATE: Ủy quyền việc lấy tên quản lý, giấu đi bước trung gian
        public string LayTenQuanLyCuaToi()
        {
            return _chiNhanhTrucThuoc.QuanLyChiNhanh;
        }

        public void InBaoCao()
        {
            Console.WriteLine($"Nhan vien: {TenNhanVien}");
            Console.WriteLine($"Bao cao truc tiep cho: {LayTenQuanLyCuaToi()}");
        }
    }
}