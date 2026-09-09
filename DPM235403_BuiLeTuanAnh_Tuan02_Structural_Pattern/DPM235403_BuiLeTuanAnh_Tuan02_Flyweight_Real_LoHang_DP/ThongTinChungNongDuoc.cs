namespace DPM235403_BuiLeTuanAnh_Tuan02_Flyweight_Real_LoHang_DP
{
    public class ThongTinChungNongDuoc
    {
        public string TenThuoc { get; set; }
        public string NhaSanXuat { get; set; }
        public string ThanhPhanHoaHoc { get; set; }

        public ThongTinChungNongDuoc(string ten, string nsx, string thanhPhan)
        {
            TenThuoc = ten;
            NhaSanXuat = nsx;
            ThanhPhanHoaHoc = thanhPhan;
        }
    }
}