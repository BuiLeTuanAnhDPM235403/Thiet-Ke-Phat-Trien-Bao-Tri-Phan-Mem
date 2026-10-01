namespace DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate.After
{
    public class Department
    {
        public string Manager { get; set; }

        public Department(string manager)
        {
            Manager = manager;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        private Department _department; // Đổi thành private, giấu khỏi thế giới bên ngoài

        public Person(Department department)
        {
            _department = department;
        }

        // HIDE DELEGATE: Cung cấp sẵn hàm lấy Manager để Client không cần chọc vào _department
        public string GetManager()
        {
            return _department.Manager;
        }
    }
}