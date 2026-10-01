using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject.Before
{
    public class Performance
    {
        public void PrintTeamInfo()
        {
            // Xấu: Dùng mảng string để lưu cả Tên và Số trận thắng
            string[] row = new string[2];
            row[0] = "Liverpool";
            row[1] = "15"; // Phải lưu số 15 dưới dạng chuỗi

            string name = row[0];
            int wins = int.Parse(row[1]); // Lại phải ép kiểu ngược lại

            Console.WriteLine($"Doi bong: {name} | Thang: {wins}");
        }
    }
}