namespace DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass.Before
{
    public class Person
    {
        public string Name { get; set; }

        // Các trường này đáng lẽ phải thuộc về một đối tượng Điện thoại riêng
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetTelephoneNumber()
        {
            return $"({OfficeAreaCode}) {OfficeNumber}";
        }
    }
}