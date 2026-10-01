using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag.Before
{
    public class Security
    {
        public void CheckSecurity(string[] people)
        {
            // Xấu: Dùng cờ điều khiển 'found' để dừng vòng lặp
            bool found = false;
            for (int i = 0; i < people.Length; i++)
            {
                if (!found)
                {
                    if (people[i].Equals("Don"))
                    {
                        Console.WriteLine("Phat hien Don!");
                        found = true;
                    }
                    if (people[i].Equals("John"))
                    {
                        Console.WriteLine("Phat hien John!");
                        found = true;
                    }
                }
            }
        }
    }
}