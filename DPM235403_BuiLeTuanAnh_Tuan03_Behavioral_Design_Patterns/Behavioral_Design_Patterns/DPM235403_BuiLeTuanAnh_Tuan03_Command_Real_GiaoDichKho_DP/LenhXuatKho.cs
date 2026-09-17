namespace DPM235403_BuiLeTuanAnh_Tuan03_Command_Real_GiaoDichKho_DP
{
    public class LenhXuatKho : IGiaoDichCommand
    {
        private KhoNongDuocReceiver _kho;
        private int _soLuong;

        public LenhXuatKho(KhoNongDuocReceiver kho, int soLuong)
        {
            _kho = kho;
            _soLuong = soLuong;
        }

        public void ThucThi() => _kho.XuatKho(_soLuong);

        // Hoàn tác của Xuất kho là Nhập lại vào kho
        public void HoanTac() => _kho.NhapKho(_soLuong);
    }
}