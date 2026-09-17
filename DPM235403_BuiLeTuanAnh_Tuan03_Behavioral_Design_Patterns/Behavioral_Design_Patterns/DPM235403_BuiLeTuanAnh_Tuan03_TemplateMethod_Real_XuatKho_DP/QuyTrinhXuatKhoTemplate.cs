using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_TemplateMethod_Real_XuatKho_DP
{
    public abstract class QuyTrinhXuatKhoTemplate
    {
        // Template Method: Định nghĩa khung quy trình chuẩn (Không cho phép lớp con sửa thứ tự)
        public void XuatKho()
        {
            KiemTraDonHang();
            LayHangKhoiKe();
            DongGoi();
            BanGiaoTaiXe();
            Console.WriteLine("-------------------------------------------------");
        }

        protected void KiemTraDonHang()
        {
            Console.WriteLine("1. Kiem tra: Da xac nhan don hang va thanh toan hop le.");
        }

        protected void LayHangKhoiKe()
        {
            Console.WriteLine("2. Lay hang: Xuat kho, dung xe nang chuyen hang ra khu vuc dong goi.");
        }

        protected void BanGiaoTaiXe()
        {
            Console.WriteLine("4. Ban giao: Ky nhan voi tai xe xe tai, bat dau van chuyen.");
        }

        // Bước này bắt buộc các loại hàng hóa phải tự định nghĩa cách làm riêng
        protected abstract void DongGoi();
    }
}