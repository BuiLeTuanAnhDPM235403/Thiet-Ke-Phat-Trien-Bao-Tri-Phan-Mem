using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable.Before
{
    public class TrinhDuyet
    {
        public void RenderBanner(string platform, string browser, int resize)
        {
            // Biểu thức khó hiểu, khó bảo trì
            if ((platform.ToUpper().IndexOf("MAC") > -1) &&
                (browser.ToUpper().IndexOf("IE") > -1) &&
                resize > 0)
            {
                Console.WriteLine("Hien thi Banner cho he dieu hanh Mac va trinh duyet IE");
            }
        }
    }
}