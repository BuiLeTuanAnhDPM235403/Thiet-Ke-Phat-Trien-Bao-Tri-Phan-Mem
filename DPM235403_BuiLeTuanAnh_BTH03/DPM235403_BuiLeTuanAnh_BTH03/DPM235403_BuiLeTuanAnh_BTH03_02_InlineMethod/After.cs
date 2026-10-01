namespace DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod.After
{
    public class GiaoHang
    {
        private int _soLanGiaoTre = 6;

        public int LayDanhGia()
        {
            return _soLanGiaoTre > 5 ? 2 : 1;
        }
    }
}