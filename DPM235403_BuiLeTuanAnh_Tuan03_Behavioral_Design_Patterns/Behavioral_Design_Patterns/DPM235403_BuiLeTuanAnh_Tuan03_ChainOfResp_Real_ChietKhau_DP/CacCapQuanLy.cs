using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_ChainOfResp_Real_ChietKhau_DP
{
    class NhanVienBanHang : NguoiDuyetBase
    {
        public override void XuLyYeuCau(string tenKhachHang, double phanTramChietKhau)
        {
            if (phanTramChietKhau <= 5.0)
                Console.WriteLine($"[Nhan Vien] Da xet duyet chiet khau {phanTramChietKhau}% cho don hang cua {tenKhachHang}.");
            else
                base.XuLyYeuCau(tenKhachHang, phanTramChietKhau);
        }
    }

    class CuaHangTruong : NguoiDuyetBase
    {
        public override void XuLyYeuCau(string tenKhachHang, double phanTramChietKhau)
        {
            if (phanTramChietKhau <= 10.0)
                Console.WriteLine($"[Cua Hang Truong] Da xet duyet chiet khau {phanTramChietKhau}% cho don hang cua {tenKhachHang}.");
            else
                base.XuLyYeuCau(tenKhachHang, phanTramChietKhau);
        }
    }

    class GiamDoc : NguoiDuyetBase
    {
        public override void XuLyYeuCau(string tenKhachHang, double phanTramChietKhau)
        {
            if (phanTramChietKhau <= 20.0)
                Console.WriteLine($"[Giam Doc] Da dac cach duyet chiet khau {phanTramChietKhau}% cho khach VIP {tenKhachHang}.");
            else
                base.XuLyYeuCau(tenKhachHang, phanTramChietKhau);
        }
    }
}