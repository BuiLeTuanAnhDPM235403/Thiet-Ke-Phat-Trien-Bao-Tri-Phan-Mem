namespace DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan.After
{
    public class Department
    {
        public string Manager { get; set; }
        public Department(string manager) { Manager = manager; }
    }

    public class Person
    {
        public string Name { get; set; }
        // REMOVE MIDDLE MAN: Mở public Department để người bên ngoài tự gọi thẳng
        public Department Department { get; set; }

        public Person(Department department)
        {
            Department = department;
        }
    }
}