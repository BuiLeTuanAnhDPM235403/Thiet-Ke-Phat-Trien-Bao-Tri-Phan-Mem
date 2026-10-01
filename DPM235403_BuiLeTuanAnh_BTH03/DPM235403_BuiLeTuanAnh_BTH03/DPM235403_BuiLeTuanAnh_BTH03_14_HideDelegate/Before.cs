namespace DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate.Before
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
        public Department Department { get; set; }
    }
}