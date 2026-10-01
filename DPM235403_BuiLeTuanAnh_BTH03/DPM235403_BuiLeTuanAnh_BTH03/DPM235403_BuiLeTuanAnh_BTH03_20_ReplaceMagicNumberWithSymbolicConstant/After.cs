namespace DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant.After
{
    public class Physics
    {
        // Khai báo hằng số có tên mô tả ý nghĩa
        private const double GRAVITATIONAL_CONSTANT = 9.81;

        public double PotentialEnergy(double mass, double height)
        {
            // Code trở nên cực kỳ dễ hiểu
            return mass * GRAVITATIONAL_CONSTANT * height;
        }
    }
}