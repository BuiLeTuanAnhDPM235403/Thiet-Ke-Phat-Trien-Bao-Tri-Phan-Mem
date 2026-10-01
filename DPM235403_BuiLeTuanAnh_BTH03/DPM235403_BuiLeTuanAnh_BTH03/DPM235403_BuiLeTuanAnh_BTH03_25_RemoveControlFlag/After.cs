using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag.After
{
    public class Security
    {
        public void CheckSecurity(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    Console.WriteLine("Phat hien Don!");
                    break; // Tốt: Thoát vòng lặp ngay lập tức, không cần cờ
                }
                if (people[i].Equals("John"))
                {
                    Console.WriteLine("Phat hien John!");
                    break;
                }
            }
        }
    }
}