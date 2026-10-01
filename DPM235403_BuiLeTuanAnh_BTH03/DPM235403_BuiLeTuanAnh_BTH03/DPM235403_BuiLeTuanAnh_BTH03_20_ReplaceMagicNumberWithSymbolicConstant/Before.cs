namespace DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant.Before
{
    public class Physics
    {
        public double PotentialEnergy(double mass, double height)
        {
            // Số 9.81 là một "Magic Number", người đọc không biết nó là gì
            return mass * 9.81 * height;
        }
    }
}