using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Real_TrangThaiDonHang_DP
{
    public class TrangThaiDangGiaoHang : TrangThaiDonHangBase
    {
        public override void XuLy()
        {
            Console.WriteLine("[State: Dang Giao Hang] -> Khach da nhan hang. Chuyen sang trang thai: Hoan Thanh.");
            _context.ChuyenTrangThai(new TrangThaiHoanThanh());
        }

        public override void Huy()
        {
            Console.WriteLine("[State: Dang Giao Hang] -> KHONG the huy truc tiep. Phai goi tai xe xe tai quay dau!");
        }
    }
}