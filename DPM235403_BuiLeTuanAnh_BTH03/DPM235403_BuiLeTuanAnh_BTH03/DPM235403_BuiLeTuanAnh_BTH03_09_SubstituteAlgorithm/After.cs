using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_BTH03_09_SubstituteAlgorithm.After
{
    public class Person
    {
        public string FoundPerson(string[] people)
        {
            // Thuật toán mới: Dùng List.Contains ngắn gọn và dễ bảo trì hơn
            List<string> candidates = new List<string> { "Don", "John", "Kent" };

            foreach (string person in people)
            {
                if (candidates.Contains(person))
                {
                    return person;
                }
            }
            return "";
        }
    }
}