namespace DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass.Before
{
    // Class này quá nhỏ, không có nhiều logic phức tạp
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetTelephoneNumber()
        {
            return $"({AreaCode}) {Number}";
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();
    }
}