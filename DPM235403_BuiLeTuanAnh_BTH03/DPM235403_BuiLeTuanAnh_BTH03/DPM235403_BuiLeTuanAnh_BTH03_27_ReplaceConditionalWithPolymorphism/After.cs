using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism.After
{
    // Lớp cha trừu tượng
    public abstract class Employee
    {
        public int MonthlySalary { get; set; } = 1000;

        // Tốt: Bắt buộc các lớp con phải tự định nghĩa cách tính lương
        public abstract int PayAmount();
    }

    public class Engineer : Employee
    {
        public override int PayAmount() => MonthlySalary;
    }

    public class Salesman : Employee
    {
        public int Commission { get; set; } = 200;
        public override int PayAmount() => MonthlySalary + Commission;
    }

    public class Manager : Employee
    {
        public int Bonus { get; set; } = 500;
        public override int PayAmount() => MonthlySalary + Bonus;
    }
}