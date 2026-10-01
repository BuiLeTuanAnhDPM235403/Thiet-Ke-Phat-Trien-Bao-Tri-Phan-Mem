namespace DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod.Before
{
    public class GiaoHang
    {
        private int _soLanGiaoTre = 6;

        public int LayDanhGia()
        {
            return GiaoTreHonNamLan() ? 2 : 1;
        }

        private bool GiaoTreHonNamLan()
        {
            return _soLanGiaoTre > 5;
        }
    }
}