using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod.Real
{
    public abstract class QuyTrinhCapPhatThuoc
    {
        public void ThucHienQuyTrinh(string tenNongDan)
        {
            Console.WriteLine($"--- Bat dau xu ly cho: {tenNongDan} ---");
            KiemTraGiayToCCCD();
            TinhTienThanhToan();
            XuatKhoVaGiaoThuoc();
            Console.WriteLine("-------------------------------------------\n");
        }

        private void KiemTraGiayToCCCD()
        {
            Console.WriteLine("1. Xac thuc Can cuoc cong dan/So dien tich dat hop le.");
        }

        protected abstract void TinhTienThanhToan();

        private void XuatKhoVaGiaoThuoc()
        {
            Console.WriteLine("3. Ghi so kho, in phieu va giao thuoc cho nong dan.");
        }
    }

    public class NongDanThuong : QuyTrinhCapPhatThuoc
    {
        protected override void TinhTienThanhToan()
        {
            Console.WriteLine("2. Tinh tien: Ap dung gia ban le niem yet (Khong tro gia).");
        }
    }

    public class NongDanTroGia : QuyTrinhCapPhatThuoc
    {
        protected override void TinhTienThanhToan()
        {
            Console.WriteLine("2. Tinh tien: Ap dung chinh sach tro gia 30% tu ngan sach nha nuoc.");
        }
    }
}