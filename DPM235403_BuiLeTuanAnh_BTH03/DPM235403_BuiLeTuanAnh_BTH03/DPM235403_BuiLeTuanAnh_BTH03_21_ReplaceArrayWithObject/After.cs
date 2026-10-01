using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject.After
{
    // Tạo hẳn một class để quản lý dữ liệu thay vì nhét vào mảng
    public class Team
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }

    public class Performance
    {
        public void PrintTeamInfo()
        {
            // Tốt: Sử dụng Object, gọi thuộc tính rõ ràng, đúng kiểu dữ liệu
            var team = new Team { Name = "Liverpool", Wins = 15 };

            Console.WriteLine($"Doi bong: {team.Name} | Thang: {team.Wins}");
        }
    }
}