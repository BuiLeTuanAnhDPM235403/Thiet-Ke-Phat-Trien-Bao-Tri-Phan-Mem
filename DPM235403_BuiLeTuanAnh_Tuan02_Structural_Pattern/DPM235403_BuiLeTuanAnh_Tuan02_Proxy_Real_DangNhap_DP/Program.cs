using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Proxy_Real_DangNhap_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CHUC NANG DANG NHAP VA PHAN QUYEN ---");

            Console.WriteLine("\n[Nhan vien Ban Hang dang nhap]");
            IHeThongThongKe proxyNhanVien = new QuyenTruyCapProxy("NhanVien");
            proxyNhanVien.XemBaoCaoDoanhThu(); // Sẽ bị từ chối

            Console.WriteLine("\n[Quan ly dang nhap]");
            IHeThongThongKe proxyQuanLy = new QuyenTruyCapProxy("QuanLy");
            proxyQuanLy.XemBaoCaoDoanhThu(); // Sẽ thành công

            Console.ReadLine();
        }
    }
}