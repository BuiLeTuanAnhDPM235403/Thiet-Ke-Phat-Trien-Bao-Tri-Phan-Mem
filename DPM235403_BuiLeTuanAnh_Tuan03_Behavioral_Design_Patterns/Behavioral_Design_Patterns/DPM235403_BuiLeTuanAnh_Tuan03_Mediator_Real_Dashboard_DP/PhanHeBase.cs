namespace DPM235403_BuiLeTuanAnh_Tuan03_Mediator_Real_Dashboard_DP
{
    public class PhanHeBase
    {
        protected ITrungTamDieuPhoi _trungTam;

        public PhanHeBase(ITrungTamDieuPhoi trungTam = null)
        {
            _trungTam = trungTam;
        }

        public void SetTrungTam(ITrungTamDieuPhoi trungTam)
        {
            _trungTam = trungTam;
        }
    }
}