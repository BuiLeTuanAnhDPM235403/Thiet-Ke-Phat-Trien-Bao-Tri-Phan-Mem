using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable.After
{
    public class TrinhDuyet
    {
        public void RenderBanner(string platform, string browser, int resize)
        {
            // Đã áp dụng Extract Variable
            bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            bool isIE = browser.ToUpper().IndexOf("IE") > -1;
            bool wasResized = resize > 0;

            // Câu lệnh if giờ đây đọc dễ hiểu như tiếng Anh
            if (isMacOs && isIE && wasResized)
            {
                Console.WriteLine("Hien thi Banner cho he dieu hanh Mac va trinh duyet IE");
            }
        }
    }
}