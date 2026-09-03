using System;
using System.Collections.Generic;

namespace Builder_Real_HoaDonPhucTap
{
    // Lớp chứa thông tin hóa đơn phức tạp
    public class HoaDon
    {
        private List<string> _thanhPhan = new List<string>();

        public void Add(string phan)
        {
            _thanhPhan.Add(phan);
        }

        public void HienThi()
        {
            Console.WriteLine("--- CHI TIET HOA DON BÁN HÀNG ---");
            foreach (var item in _thanhPhan)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("---------------------------------\n");
        }
    }

    // Giao diện Builder khai báo các bước lập hóa đơn
    public interface IHoaDonBuilder
    {
        void BuildThongTinSanPham();
        void BuildChiPhiVanChuyen();
        void BuildDichVuPhu();
        void BuildGiamGiaKhuyenMai();
        HoaDon GetHoaDon();
    }

    // Builder cụ thể cho Hóa đơn bán lẻ có giao hàng
    public class HoaDonGiaoTanNoiBuilder : IHoaDonBuilder
    {
        private HoaDon _hoaDon = new HoaDon();

        public HoaDonGiaoTanNoiBuilder() { this.Reset(); }
        public void Reset() { _hoaDon = new HoaDon(); }

        public void BuildThongTinSanPham() => _hoaDon.Add("San pham: 10 chai thuoc tru sau, 5 bao phan bon");
        public void BuildChiPhiVanChuyen() => _hoaDon.Add("Phi van chuyen: 50,000 VND (Giao bang xe tai nhe)");
        public void BuildDichVuPhu() => _hoaDon.Add("Dich vu phu: Boc xep tan kho (20,000 VND)");
        public void BuildGiamGiaKhuyenMai() => _hoaDon.Add("Giam gia: Khach hang than thiet giam 5%");

        public HoaDon GetHoaDon()
        {
            HoaDon result = _hoaDon;
            this.Reset();
            return result;
        }
    }

    // Director quản lý quy trình xây dựng
    public class NhanVienBanHang
    {
        private IHoaDonBuilder _builder;

        public IHoaDonBuilder Builder
        {
            set { _builder = value; }
        }

        public void LapHoaDonDayDu()
        {
            _builder.BuildThongTinSanPham();
            _builder.BuildChiPhiVanChuyen();
            _builder.BuildDichVuPhu();
            _builder.BuildGiamGiaKhuyenMai();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NhanVienBanHang nhanVien = new NhanVienBanHang();
            HoaDonGiaoTanNoiBuilder builder = new HoaDonGiaoTanNoiBuilder();
            nhanVien.Builder = builder;

            Console.WriteLine("Yeu cau: Lap hoa don ban hang day du phi van chuyen va giam gia...");
            nhanVien.LapHoaDonDayDu();
            builder.GetHoaDon().HienThi();

            Console.ReadLine();
        }
    }
}