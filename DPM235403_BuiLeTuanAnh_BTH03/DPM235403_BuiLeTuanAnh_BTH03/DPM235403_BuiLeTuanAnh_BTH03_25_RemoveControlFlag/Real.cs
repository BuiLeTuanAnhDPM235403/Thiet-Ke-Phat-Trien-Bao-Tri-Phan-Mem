using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag.Real
{
    public class KiemDinhChatLuong
    {
        public bool CoChuaChatCam(string[] thanhPhan)
        {
            Console.WriteLine("Bat dau kiem tra thanh phan lo phan bon...");

            foreach (string chat in thanhPhan)
            {
                Console.WriteLine($"- Dang phan tich: {chat}");

                // Đã áp dụng Remove Control Flag: Return thẳng kết quả
                if (chat == "Melamine" || chat == "Asen")
                {
                    Console.WriteLine("=> [NGUY HIEM] Phat hien chat cam! Dinh chi lo hang ngay lap tuc.");
                    return true;
                }
            }

            Console.WriteLine("=> [AN TOAN] Khong phat hien chat cam.");
            return false;
        }
    }
}