# 🌿 Hệ Thống Quản Lý Cửa Hàng Nông Dược An Giang

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design_Patterns-GoF-FF6F00?style=for-the-badge)

Dự án ứng dụng **22 Mẫu Thiết Kế (Design Patterns)** theo chuẩn Gang of Four (GoF) vào quá trình xây dựng, phát triển và bảo trì phần mềm thực tế cho **Cửa Hàng Nông Dược**. Dự án được chia thành các giai đoạn tương ứng với 3 nhóm mẫu thiết kế cốt lõi: Khởi tạo (Creational), Cấu trúc (Structural), và Hành vi (Behavioral).

## 👨‍💻 Thông Tin Sinh Viên

| Họ và Tên | Mã Số Sinh Viên | Chuyên Ngành |
| :--- | :---: | :--- |
| **Bùi Lê Tuấn Anh** | `DPM235403` | Kĩ Thuật Phần Mềm |

---

## 🎯 Mục Tiêu Đồ Án
1. Nắm vững lý thuyết (Conceptual) của 22 mẫu thiết kế kinh điển.
2. Ứng dụng thực tiễn (Real-world) các mẫu thiết kế này vào bài toán quản lý cửa hàng kinh doanh phân bón, thuốc bảo vệ thực vật.
3. Tối ưu hóa mã nguồn, tăng khả năng tái sử dụng, dễ dàng bảo trì và mở rộng hệ thống.

---

## 📂 Cấu Trúc Thư Mục Dự Án

Dự án được phân chia rõ ràng theo từng tuần học, bao gồm phần Code mẫu lý thuyết (Guru) và Code ứng dụng thực tế vào phần mềm Nông dược:

```text
📦 Thiet-Ke-Phat-Trien-Bao-Tri-Phan-Mem
 ┣ 📂 DPM235403_BuiLeTuanAnh_Tuan01_Creational_Design_Pattern
 ┃ ┣ 📜 Nhóm 5 mẫu khởi tạo lý thuyết (Factory, Builder, Abstract, Prototype, Singleton)
 ┃ ┗ 📜 Ứng dụng: Quản lý hóa đơn sỉ/lẻ, kho FIFO, nhân bản lô thuốc, phiên đăng nhập.
 ┃
 ┣ 📂 DPM235403_BuiLeTuanAnh_Tuan02_Structural_Design_Pattern
 ┃ ┣ 📜 Nhóm 7 mẫu cấu trúc lý thuyết (Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy)
 ┃ ┗ 📜 Ứng dụng: Tích hợp API vận chuyển, cây kho hàng, thêm phí ship/VAT, phân quyền.
 ┃
 ┣ 📂 DPM235403_BuiLeTuanAnh_Tuan03_Behavioral_Design_Pattern
 ┃ ┣ 📜 Nhóm 10 mẫu hành vi lý thuyết (Chain of Resp, Command, Iterator, Mediator, Memento, Observer, State, Strategy, Template, Visitor)
 ┃ ┗ 📜 Ứng dụng: Duyệt chiết khấu, Undo giao dịch, duyệt hóa đơn, tính thuế xuất kho.
 ┃
 ┣ 📂 Cuahang_Nongduoc (Mã nguồn gốc phần mềm nhận bảo trì)
 ┣ 📜 .gitignore
 ┗ 📜 README.md
