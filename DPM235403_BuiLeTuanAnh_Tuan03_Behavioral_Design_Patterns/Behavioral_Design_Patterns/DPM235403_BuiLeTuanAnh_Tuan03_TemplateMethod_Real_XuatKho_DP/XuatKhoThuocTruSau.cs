using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_TemplateMethod_Real_XuatKho_DP
{
    public class XuatKhoThuocTruSau : QuyTrinhXuatKhoTemplate
    {
        protected override void DongGoi()
        {
            Console.WriteLine("3. Dong goi (Thuoc Tru Sau): Dong vao thung carton, chen them mut xop de chong soc, dan tem 'HANG DE VO - DOC HAI'.");
        }
    }
}