using System;
using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Flyweight_Real_LoHang_DP
{
    public class NongDuocFactory
    {
        private Dictionary<string, ChaiNongDuocFlyweight> _danhSachMau = new Dictionary<string, ChaiNongDuocFlyweight>();

        public ChaiNongDuocFlyweight LayMauThuoc(string tenThuoc, string nsx, string thanhPhan)
        {
            string key = $"{tenThuoc}_{nsx}";
            if (!_danhSachMau.ContainsKey(key))
            {
                Console.WriteLine($"\n[Factory] Tao bo nho cache moi cho thuoc: {tenThuoc}");
                var thongTinChung = new ThongTinChungNongDuoc(tenThuoc, nsx, thanhPhan);
                _danhSachMau[key] = new ChaiNongDuocFlyweight(thongTinChung);
            }
            else
            {
                Console.WriteLine($"\n[Factory] Su dung lai du lieu cache cua thuoc: {tenThuoc}");
            }
            return _danhSachMau[key];
        }
    }
}