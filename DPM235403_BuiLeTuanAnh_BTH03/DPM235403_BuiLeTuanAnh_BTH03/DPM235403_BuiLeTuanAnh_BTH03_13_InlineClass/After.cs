namespace DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass.After
{
    public class Person
    {
        public string Name { get; set; }

        // INLINE CLASS: Đưa các thuộc tính của TelephoneNumber về lại Person
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetTelephoneNumber()
        {
            return $"({OfficeAreaCode}) {OfficeNumber}";
        }
    }
}