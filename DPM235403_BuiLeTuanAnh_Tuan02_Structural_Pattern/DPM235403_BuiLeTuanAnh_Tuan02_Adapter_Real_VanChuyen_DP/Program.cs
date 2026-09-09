using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Adapter_Real_VanChuyen_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG VAN CHUYEN NONG DUOC ---");

            Console.WriteLine("\n[Truong hop 1: Giao bang xe nha]");
            IVanChuyen vanChuyenNha = new VanChuyenNoiBo();
            vanChuyenNha.GiaoHang("DH001", "Cho Moi, An Giang");

            Console.WriteLine("\n[Truong hop 2: Giao bang doi tac GHN]");
            GiaoHangNhanhAPI apiGHN = new GiaoHangNhanhAPI();
            IVanChuyen vanChuyenDoiTac = new VanChuyenAdapter(apiGHN);
            vanChuyenDoiTac.GiaoHang("DH002", "Chau Doc, An Giang");

            Console.ReadLine();
        }
    }
}