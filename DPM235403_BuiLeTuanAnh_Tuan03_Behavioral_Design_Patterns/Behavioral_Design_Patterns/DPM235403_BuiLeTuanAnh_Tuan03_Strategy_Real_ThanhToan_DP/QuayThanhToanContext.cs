namespace DPM235403_BuiLeTuanAnh_Tuan03_Strategy_Real_ThanhToan_DP
{
    public class QuayThanhToanContext
    {
        private IThanhToanStrategy _phuongThucThanhToan;

        public void SetPhuongThucThanhToan(IThanhToanStrategy phuongThuc)
        {
            _phuongThucThanhToan = phuongThuc;
        }

        public void TinhTien(double tongTien)
        {
            if (_phuongThucThanhToan == null)
            {
                System.Console.WriteLine("Loi: Vui long chon phuong thuc thanh toan truoc!");
                return;
            }

            _phuongThucThanhToan.XuLyThanhToan(tongTien);
        }
    }
}