using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism.Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public int Type { get; set; }
        public int MonthlySalary { get; set; } = 1000;
        public int Commission { get; set; } = 200;
        public int Bonus { get; set; } = 500;

        public Employee(int type)
        {
            Type = type;
        }

        public int PayAmount()
        {
            // Xấu: Lệnh switch phơi bày logic tính lương, khó mở rộng nếu thêm loại nhân viên mới
            switch (Type)
            {
                case ENGINEER:
                    return MonthlySalary;
                case SALESMAN:
                    return MonthlySalary + Commission;
                case MANAGER:
                    return MonthlySalary + Bonus;
                default:
                    throw new Exception("Loi loai nhan vien");
            }
        }
    }
}