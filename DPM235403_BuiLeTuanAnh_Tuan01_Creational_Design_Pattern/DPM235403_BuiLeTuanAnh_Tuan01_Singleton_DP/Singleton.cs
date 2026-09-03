namespace DPM235403_BuiLeTuanAnh_Tuan01_Singleton_DP
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void SomeBusinessLogic()
        {
            // Business logic implementation
        }
    }
}