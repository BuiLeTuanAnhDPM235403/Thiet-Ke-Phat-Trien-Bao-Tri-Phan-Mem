using System;
using System.Linq;

namespace DPM235403_BuiLeTuanAnh_BTH03_09_SubstituteAlgorithm.Real
{
    public class KiemDinhNongDuoc
    {
        public bool KiemTraThuocCam(string tenThuoc)
        {
            // Thay vì if (ten == "A") else if (ten == "B")... ta tạo mảng và dùng Contains
            string[] danhMucCam = { "Paraquat", "2,4-D", "Chlorpyrifos", "Glyphosate" };

            // Thuật toán LINQ cực kỳ ngắn gọn của C#
            bool laThuocCam = danhMucCam.Contains(tenThuoc);

            if (laThuocCam)
            {
                Console.WriteLine($"[CANH BAO] {tenThuoc} la hoa chat bi CAM luu hanh!");
            }
            else
            {
                Console.WriteLine($"[HOP LE] {tenThuoc} duoc phep kinh doanh.");
            }

            return laThuocCam;
        }
    }
}