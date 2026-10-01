using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan.Real
{
    public class NhaCungCap
    {
        public string TenNhaCungCap { get; set; }
        public string HotlineKyThuat { get; set; }

        public NhaCungCap(string ten, string hotline)
        {
            TenNhaCungCap = ten;
            HotlineKyThuat = hotline;
        }
    }

    public class ThuocBaoVeThucVat
    {
        public string TenThuoc { get; set; }

        // Cung cấp thẳng đối tượng NhaCungCap thay vì viết hàm GetHotline() trung gian
        public NhaCungCap ThongTinNhaCungCap { get; set; }

        public ThuocBaoVeThucVat(string ten, NhaCungCap ncc)
        {
            TenThuoc = ten;
            ThongTinNhaCungCap = ncc;
        }
    }
}