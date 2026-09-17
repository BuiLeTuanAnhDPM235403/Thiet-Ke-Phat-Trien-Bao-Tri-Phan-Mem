namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Real_TrangThaiDonHang_DP
{
    public abstract class TrangThaiDonHangBase
    {
        protected DonHangContext _context;

        public void SetContext(DonHangContext context)
        {
            _context = context;
        }

        public abstract void XuLy();
        public abstract void Huy();
    }
}