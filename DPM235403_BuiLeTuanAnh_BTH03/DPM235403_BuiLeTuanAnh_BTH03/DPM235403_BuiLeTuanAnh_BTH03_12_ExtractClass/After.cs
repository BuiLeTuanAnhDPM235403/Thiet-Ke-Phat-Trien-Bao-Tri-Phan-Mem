namespace DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass.After
{
    // EXTRACT CLASS: Lớp mới được tách ra
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
        // Person giờ chỉ cần giữ 1 tham chiếu đến đối tượng TelephoneNumber
        public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();

        public string GetTelephoneNumber()
        {
            return OfficeTelephone.GetTelephoneNumber();
        }
    }
}