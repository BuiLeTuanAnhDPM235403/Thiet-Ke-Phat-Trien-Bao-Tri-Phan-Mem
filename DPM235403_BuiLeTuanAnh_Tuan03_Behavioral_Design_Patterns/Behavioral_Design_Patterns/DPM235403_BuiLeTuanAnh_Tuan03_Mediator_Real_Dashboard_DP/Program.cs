using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Mediator_Real_Dashboard_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- DASHBOARD TRUNG TAM CUA HANG NONG DUOC ---");

            // Khởi tạo các phân hệ
            var phanHeBanHang = new PhanHeBanHang();
            var phanHeKhoHang = new PhanHeKhoHang();

            // Khởi tạo Mediator và gắn các phân hệ vào
            new DashboardCuaHang(phanHeBanHang, phanHeKhoHang);

            // Bắt đầu quy trình từ việc nhân viên chốt đơn
            Console.WriteLine("\n[Khach hang mua thuoc tru sau va thanh toan]");
            phanHeBanHang.TaoDonHangMoi();

            Console.ReadLine();
        }
    }
}