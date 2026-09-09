namespace DPM235403_BuiLeTuanAnh_Tuan02_Bridge_Real_BaoCao_DP
{
    public abstract class BaoCao
    {
        protected IFormatBaoCao _format;

        public BaoCao(IFormatBaoCao format)
        {
            _format = format;
        }

        public abstract void TaoVaInBaoCao(string tuNgay, string denNgay);
    }
}