namespace DPM235403_BuiLeTuanAnh_Tuan02_Bridge_Real_BaoCao_DP
{
    public class BaoCaoTonKho : BaoCao
    {
        public BaoCaoTonKho(IFormatBaoCao format) : base(format) { }

        public override void TaoVaInBaoCao(string tuNgay, string denNgay)
        {
            string duLieu = $"Du lieu Ton Kho Nong Duoc tu {tuNgay} den {denNgay}: Con 500 lo thuoc tru sau.";
            _format.InBaoCao(duLieu);
        }
    }
}