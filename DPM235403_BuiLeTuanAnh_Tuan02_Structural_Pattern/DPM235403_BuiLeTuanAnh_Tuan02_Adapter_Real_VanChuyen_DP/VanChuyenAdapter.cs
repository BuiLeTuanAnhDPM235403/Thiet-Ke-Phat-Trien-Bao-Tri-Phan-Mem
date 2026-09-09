namespace DPM235403_BuiLeTuanAnh_Tuan02_Adapter_Real_VanChuyen_DP
{
    // Đóng vai trò là cầu nối giữa IVanChuyen và GiaoHangNhanhAPI
    public class VanChuyenAdapter : IVanChuyen
    {
        private GiaoHangNhanhAPI _ghnApi;

        public VanChuyenAdapter(GiaoHangNhanhAPI ghnApi)
        {
            _ghnApi = ghnApi;
        }

        public void GiaoHang(string maDon, string diaChi)
        {
            // Chuyển đổi phương thức gọi cho phù hợp
            _ghnApi.CreateOrderAndShip(maDon, diaChi, true); // Mặc định hàng nông dược là hàng dễ vỡ/chất lỏng
        }
    }
}