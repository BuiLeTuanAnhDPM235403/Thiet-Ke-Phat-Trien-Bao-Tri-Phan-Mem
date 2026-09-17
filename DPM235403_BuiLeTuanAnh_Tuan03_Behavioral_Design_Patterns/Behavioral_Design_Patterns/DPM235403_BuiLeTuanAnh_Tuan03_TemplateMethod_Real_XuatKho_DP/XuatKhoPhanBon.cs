using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_TemplateMethod_Real_XuatKho_DP
{
    public class XuatKhoPhanBon : QuyTrinhXuatKhoTemplate
    {
        protected override void DongGoi()
        {
            Console.WriteLine("3. Dong goi (Phan Bon): Boc them lop nylon ben ngoai bao tai de chong am uot khi di duong xa.");
        }
    }
}