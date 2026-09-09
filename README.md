# ĐỒ ÁN MÔN HỌC: THIẾT KẾ PHÁT TRIỂN VÀ BẢO TRÌ PHẦN MỀM

## 1. Thông tin sinh viên & Đề tài
* **Sinh viên thực hiện:** Bùi Lê Tuấn Anh
* **Mã số sinh viên:** DPM235403
* **Trường:** Đại học An Giang
* **Đề tài:** Bảo trì và nâng cấp hệ thống phần mềm Quản lý Cửa hàng Nông dược An Giang
* **Công nghệ:** C# (.NET WinForms / Console), Microsoft Access Database

---

## 2. Mục tiêu & Yêu cầu đề tài
Thực hiện tiếp nhận, bảo trì, tái kiến trúc và mở rộng hệ thống phần mềm quản lý bán hàng cho Công ty Nông dược An Giang theo quy chuẩn kỹ thuật chuyên nghiệp:
* **Sửa lỗi tồn đọng:** Khắc phục tối thiểu 10 lỗi nhỏ trong mã nguồn gốc.
* **Refactoring:** Áp dụng 60 kỹ thuật tái cấu trúc code nhằm tối ưu hiệu năng và khả năng bảo trì.
* **Quản lý bán hàng & kho hàng:** 
  * Bổ sung tính năng bán sỉ và bán lẻ[cite: 2, 3].
  * Cấu hình phương pháp xuất kho (FIFO - Nhập trước xuất trước theo hạn sử dụng hoặc xuất theo lô chỉ định)[cite: 2, 3].
  * Hỗ trợ 2 phương pháp tính giá vốn xuất kho: Bình quân gia quyền và FIFO[cite: 2, 3].
* **Mở rộng tính năng:**
  * Lập hóa đơn tích hợp phí vận chuyển, chi phí dịch vụ phụ và chiết khấu/giảm giá[cite: 2, 3].
  * Thống kê báo cáo tồn kho, doanh thu, khuyến mãi lọc tùy chọn từ ngày đến ngày theo nhân viên[cite: 2, 3].
  * Hoàn thiện cơ chế đăng nhập và phân quyền người dùng[cite: 2, 3].
* **Áp dụng Design Patterns:** Triển khai đầy đủ 23 Design Patterns trong quá trình tái kiến tạo và viết mới các module[cite: 2, 3].

---

## 3. Cấu trúc kho lưu trữ (Repository Structure)

```text
├── README.md                                               # Tài liệu tổng quan đề tài
├── .gitignore                                              # Bỏ qua các file tạm, bin/, obj/
│
├── DPM235403_BuiLeTuanAnh_Tuan01_Creational_Design_Pattern/ # Bài tập Tuần 01: Creational Patterns
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Factory_DP/            # Mẫu Factory (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Builder_DP/            # Mẫu Builder (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Abstract_DP/           # Mẫu Abstract Factory (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Prototype_DP/          # Mẫu Prototype (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Singleton_DP/          # Mẫu Singleton (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Factory_Real_HoaDon_DP/        # Real: Phân loại hóa đơn sỉ/lẻ
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Builder_Real_PhieuXuat_DP/     # Real: Lắp ráp hóa đơn có phí ship/giảm giá
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Abstract_Real_KhoXuat_DP/      # Real: Cấu hình kho FIFO / Chỉ định
│   ├── DPM235403_BuiLeTuanAnh_Tuan01_Prototype_Real_LoHang_DP/      # Real: Nhân bản lô thuốc/phân bón
│   └── DPM235403_BuiLeTuanAnh_Tuan01_Singleton_Real_DangNhap_DP/    # Real: Quản lý phiên đăng nhập duy nhất
│
├── DPM235403_BuiLeTuanAnh_Tuan02_Structural_Design_Pattern/ # Bài tập Tuần 02: Structural Patterns
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Adapter_DP/             # Mẫu Adapter (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Bridge_DP/              # Mẫu Bridge (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Composite_DP/           # Mẫu Composite (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Decorator_DP/         # Mẫu Decorator (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Facade_DP/              # Mẫu Facade (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Flyweight_DP/           # Mẫu Flyweight (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Proxy_DP/               # Mẫu Proxy (Refactoring Guru)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Adapter_Real_VanChuyen_DP/   # Real: Tích hợp API vận chuyển ngoài
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Bridge_Real_BaoCao_DP/       # Real: Xuất báo cáo đa định dạng (PDF/Excel)
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Composite_Real_KhoHang_DP/   # Real: Quản lý cấu trúc cây kho hàng
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Decorator_Real_HoaDon_DP/    # Real: Thêm phí ship, giảm giá vào hóa đơn
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Facade_Real_BanHang_DP/      # Real: Gộp quy trình bán hàng tự động
│   ├── DPM235403_BuiLeTuanAnh_Tuan02_Flyweight_Real_LoHang_DP/    # Real: Tối ưu RAM cho dữ liệu lô hàng lớn
│   └── DPM235403_BuiLeTuanAnh_Tuan02_Proxy_Real_DangNhap_DP/      # Real: Phân quyền đăng nhập xem báo cáo
│
└── Cuahang_Nongduoc/                                       # Mã nguồn gốc phần mềm nhận bảo trì
