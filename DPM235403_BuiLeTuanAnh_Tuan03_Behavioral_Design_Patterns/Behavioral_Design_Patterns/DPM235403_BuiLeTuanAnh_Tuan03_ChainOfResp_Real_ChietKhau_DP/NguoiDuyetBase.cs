namespace DPM235403_BuiLeTuanAnh_Tuan03_ChainOfResp_Real_ChietKhau_DP
{
    abstract class NguoiDuyetBase : IDuyetChietKhau
    {
        private IDuyetChietKhau _capTren;

        public IDuyetChietKhau ThietLapCapTren(IDuyetChietKhau capTren)
        {
            _capTren = capTren;
            return capTren;
        }

        public virtual void XuLyYeuCau(string tenKhachHang, double phanTramChietKhau)
        {
            if (_capTren != null)
            {
                _capTren.XuLyYeuCau(tenKhachHang, phanTramChietKhau);
            }
            else
            {
                System.Console.WriteLine($"[Tu Choi] Khong ai co quyen xet duyet muc chiet khau {phanTramChietKhau}% cho khach {tenKhachHang}.");
            }
        }
    }
}