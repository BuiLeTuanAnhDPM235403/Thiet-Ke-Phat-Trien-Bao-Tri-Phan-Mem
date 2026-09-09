using System;
using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Composite_Real_KhoHang_DP
{
    public class KhuVucKho : IKhoHang
    {
        private string _tenKhuVuc;
        private List<IKhoHang> _danhSachThanhPhan = new List<IKhoHang>();

        public KhuVucKho(string tenKhuVuc)
        {
            _tenKhuVuc = tenKhuVuc;
        }

        public void ThemThanhPhan(IKhoHang thanhPhan)
        {
            _danhSachThanhPhan.Add(thanhPhan);
        }

        public void HienThiThongTin(int mucDoThutLe)
        {
            Console.WriteLine(new String('-', mucDoThutLe) + $" + {_tenKhuVuc}");
            foreach (var item in _danhSachThanhPhan)
            {
                item.HienThiThongTin(mucDoThutLe + 2);
            }
        }

        public int TinhTongSoLuong()
        {
            int tong = 0;
            foreach (var item in _danhSachThanhPhan)
            {
                tong += item.TinhTongSoLuong();
            }
            return tong;
        }
    }
}