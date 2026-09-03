using System;
using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Builder_Real_PhieuXuat_DP
{
    public class HoaDon
    {
        private List<string> _thanhPhan = new List<string>();

        public void Add(string phan)
        {
            _thanhPhan.Add(phan);
        }

        public void HienThi()
        {
            Console.WriteLine("--- CHI TIET HOA DON BAN HANG ---");
            foreach (var item in _thanhPhan)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("---------------------------------\n");
        }
    }
}