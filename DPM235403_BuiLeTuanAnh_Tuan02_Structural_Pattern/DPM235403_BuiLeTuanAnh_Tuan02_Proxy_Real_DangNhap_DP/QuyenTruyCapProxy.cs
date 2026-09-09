using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Proxy_Real_DangNhap_DP
{
    public class QuyenTruyCapProxy : IHeThongThongKe
    {
        private HeThongThongKe _heThongThucTe;
        private string _chucVu;

        public QuyenTruyCapProxy(string chucVu)
        {
            _chucVu = chucVu;
        }

        public void XemBaoCaoDoanhThu()
        {
            if (_chucVu == "QuanLy")
            {
                if (_heThongThucTe == null)
                {
                    _heThongThucTe = new HeThongThongKe();
                }
                _heThongThucTe.XemBaoCaoDoanhThu();
            }
            else
            {
                Console.WriteLine($"Proxy: Tu choi truy cap! Chuc vu '{_chucVu}' khong co quyen xem thong ke.");
            }
        }
    }
}