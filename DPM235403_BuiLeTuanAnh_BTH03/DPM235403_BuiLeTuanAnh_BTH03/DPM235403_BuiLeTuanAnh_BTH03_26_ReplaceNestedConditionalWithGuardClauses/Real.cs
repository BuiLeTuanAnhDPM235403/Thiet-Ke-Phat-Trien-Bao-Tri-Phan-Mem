using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses.Real
{
    public class DaiLyNongDuoc
    {
        public string TenDaiLy { get; set; }
        public bool DaNgungHopTac { get; set; }
        public bool DangNoQuaHan { get; set; }
        public double DoanhSoThang { get; set; }

        public DaiLyNongDuoc(string ten, bool ngungHopTac, bool noQuaHan, double doanhSo)
        {
            TenDaiLy = ten;
            DaNgungHopTac = ngungHopTac;
            DangNoQuaHan = noQuaHan;
            DoanhSoThang = doanhSo;
        }

        public double TinhTienThuongChietKhau()
        {
            Console.WriteLine($"\nDang xet duyet thuong cho: {TenDaiLy}...");

            // GUARD CLAUSES: Các mệnh đề bảo vệ lọc ngay những ca không hợp lệ
            if (DaNgungHopTac)
            {
                Console.WriteLine("=> [TU CHOI] Dai ly da ngung hop tac.");
                return 0;
            }

            if (DangNoQuaHan)
            {
                Console.WriteLine("=> [TU CHOI] Dai ly dang co no xau qua han.");
                return 0;
            }

            if (DoanhSoThang < 50000000)
            {
                Console.WriteLine("=> [TU CHOI] Doanh so chua dat moc toi thieu 50 trieu.");
                return 0;
            }

            // MAIN LOGIC: Kịch bản hoàn hảo nhất, đại lý xuất sắc
            Console.WriteLine("=> [HOP LE] Dai ly xuat sac, duoc thuong 5% doanh so.");
            return DoanhSoThang * 0.05;
        }
    }
}