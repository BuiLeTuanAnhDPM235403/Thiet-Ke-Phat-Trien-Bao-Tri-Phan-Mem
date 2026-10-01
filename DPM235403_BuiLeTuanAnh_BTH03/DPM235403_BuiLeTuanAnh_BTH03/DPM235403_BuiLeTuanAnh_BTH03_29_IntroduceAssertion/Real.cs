using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion.Real
{
    public class MayPhaThuoc
    {
        public void PhaChe(string tenThuoc, double mlThuoc, double litNuoc)
        {
            if (litNuoc <= 0)
            {
                throw new ArgumentException("LUONG NUOC PHA BAT BUOC PHAI LON HON 0 LIT!");
            }

            double nongDo = mlThuoc / litNuoc;

            Console.WriteLine($"[THANH CONG] Da pha {mlThuoc}ml '{tenThuoc}' vao {litNuoc}L nuoc.");
            Console.WriteLine($"=> Nong do xit: {nongDo:N2} ml/Lit\n");
        }
    }
}