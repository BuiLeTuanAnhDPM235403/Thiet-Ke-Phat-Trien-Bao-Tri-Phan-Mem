using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod.After
{
    public abstract class HoaDonTemplate
    {
        public void TinhToan()
        {
            DocDuLieu();
            TinhTienChiTiet();
            InHoaDon();
        }

        private void DocDuLieu() => Console.WriteLine("Doc du lieu...");
        protected abstract void TinhTienChiTiet();
        private void InHoaDon() => Console.WriteLine("In hoa don thanh cong.\n");
    }

    public class HoaDonThuong : HoaDonTemplate
    {
        protected override void TinhTienChiTiet() => Console.WriteLine("-> Tinh tien khach le (Khong chieu khau)");
    }

    public class HoaDonVIP : HoaDonTemplate
    {
        protected override void TinhTienChiTiet() => Console.WriteLine("-> Tinh tien khach VIP (Giam 15%)");
    }
}