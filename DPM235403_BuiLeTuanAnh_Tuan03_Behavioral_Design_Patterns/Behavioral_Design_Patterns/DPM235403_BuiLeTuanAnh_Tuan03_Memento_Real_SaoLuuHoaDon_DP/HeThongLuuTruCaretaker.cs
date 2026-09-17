using System;
using System.Collections.Generic;
using System.Linq;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Memento_Real_SaoLuuHoaDon_DP
{
    public class HeThongLuuTruCaretaker
    {
        private List<IMemento> _danhSachBanSao = new List<IMemento>();
        private HoaDonOriginator _hoaDon;

        public HeThongLuuTruCaretaker(HoaDonOriginator hoaDon)
        {
            _hoaDon = hoaDon;
        }

        public void Backup()
        {
            _danhSachBanSao.Add(_hoaDon.TaoBanSao());
        }

        public void Undo()
        {
            if (_danhSachBanSao.Count == 0) return;

            var banSaoGanNhat = _danhSachBanSao.Last();
            _danhSachBanSao.Remove(banSaoGanNhat);

            Console.WriteLine($"\n[Undo] Quay lai ban sao: {banSaoGanNhat.GetTenBanSao()}");
            _hoaDon.KhoiPhuc(banSaoGanNhat);
        }
    }
}