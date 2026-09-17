using System;
using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Real_TinhThue_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG TINH THUE CUA HANG NONG DUOC ---");

            // Khởi tạo giỏ hàng
            var gioHang = new List<ISanPhamNongDuoc>
            {
                new PhanBon("Bao Ure Ca Mau 50kg", 800000),
                new ThuocHoaHoc("Thuoc diet co luu dan (Doc thap)", 150000, 1),
                new ThuocHoaHoc("Thuoc tru sau Regen (Doc cao)", 300000, 2)
            };

            // Gọi hệ thống tính thuế áp dụng vào giỏ hàng
            var boTinhThue = new ThueVietNamVisitor();

            Console.WriteLine("\nChi tiet thue tung san pham:");
            foreach (var sanPham in gioHang)
            {
                sanPham.Accept(boTinhThue);
            }

            Console.ReadLine();
        }
    }
}