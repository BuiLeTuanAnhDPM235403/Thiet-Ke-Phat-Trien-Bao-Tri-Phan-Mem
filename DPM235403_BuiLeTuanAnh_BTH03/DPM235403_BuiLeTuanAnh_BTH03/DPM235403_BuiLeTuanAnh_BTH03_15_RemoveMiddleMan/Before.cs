namespace DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan.Before
{
    public class Department
    {
        public string Manager { get; set; }
        public Department(string manager) { Manager = manager; }
    }

    public class Person
    {
        public string Name { get; set; }
        private Department _department;

        public Person(Department department)
        {
            _department = department;
        }

        // Person phải viết một hàm ủy quyền (Middle Man) chỉ để trả về Manager
        public string GetManager()
        {
            return _department.Manager;
        }
    }
}