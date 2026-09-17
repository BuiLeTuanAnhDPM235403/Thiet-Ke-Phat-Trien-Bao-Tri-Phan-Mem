namespace DPM235403_BuiLeTuanAnh_Tuan03_ChainOfResp_Real_ChietKhau_DP
{
    public interface IDuyetChietKhau
    {
        IDuyetChietKhau ThietLapCapTren(IDuyetChietKhau capTren);
        void XuLyYeuCau(string tenKhachHang, double phanTramChietKhau);
    }
}