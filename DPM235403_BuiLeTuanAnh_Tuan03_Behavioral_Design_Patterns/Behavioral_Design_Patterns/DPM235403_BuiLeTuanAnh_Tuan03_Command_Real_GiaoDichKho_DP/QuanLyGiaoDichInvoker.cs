using System;
using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Command_Real_GiaoDichKho_DP
{
    public class QuanLyGiaoDichInvoker
    {
        private Stack<IGiaoDichCommand> _lichSuLenh = new Stack<IGiaoDichCommand>();

        public void ThucHienLenh(IGiaoDichCommand lenh)
        {
            lenh.ThucThi();
            _lichSuLenh.Push(lenh); // Lưu vết lệnh vừa chạy vào ngăn xếp
        }

        public void UndoGiaoDichCuoi()
        {
            if (_lichSuLenh.Count > 0)
            {
                Console.WriteLine("\n[He thong] Dang hoan tac (Undo) giao dich gan nhat...");
                var lenhCuoi = _lichSuLenh.Pop();
                lenhCuoi.HoanTac();
            }
            else
            {
                Console.WriteLine("Khong co giao dich nao de hoan tac!");
            }
        }
    }
}