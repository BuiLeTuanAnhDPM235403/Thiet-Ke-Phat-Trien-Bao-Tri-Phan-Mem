using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Flyweight_Real_LoHang_DP
{
    public class ChaiNongDuocFlyweight
    {
        private ThongTinChungNongDuoc _thongTinChung;

        public ChaiNongDuocFlyweight(ThongTinChungNongDuoc thongTinChung)
        {
            _thongTinChung = thongTinChung;
        }

        // Truyền vào thông tin riêng biệt (Extrinsic State) khi gọi hàm
        public void HienThiChiTiet(string maSerial, DateTime ngayHetHan)
        {
            Console.WriteLine($"[Serial: {maSerial}] {_thongTinChung.TenThuoc} | NSX: {_thongTinChung.NhaSanXuat} | HSD: {ngayHetHan:dd/MM/yyyy}");
        }
    }
}