# 🌿 Hệ Thống Quản Lý Cửa Hàng Nông Dược An Giang

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design_Patterns-GoF-FF6F00?style=for-the-badge)
![Refactoring](https://img.shields.io/badge/Refactoring-Martin_Fowler-blue?style=for-the-badge)

Dự án ứng dụng các **Mẫu Thiết Kế (Design Patterns)** chuẩn Gang of Four (GoF) và **30 Kỹ Thuật Refactoring** theo Martin Fowler vào quá trình xây dựng, phát triển và bảo trì phần mềm thực tế cho **Cửa Hàng Nông Dược**.

## 👨‍💻 Thông Tin Sinh Viên

| Họ và Tên | Mã Số Sinh Viên | Chuyên Ngành | Trường |
| :--- | :---: | :--- | :--- |
| **Bùi Lê Tuấn Anh** | `DPM235403` | Kĩ Thuật Phần Mềm | Đại học An Giang (AGU) |

---

## 🎯 Mục Tiêu Đồ Án
1. Nắm vững lý thuyết và thực tiễn của các mẫu thiết kế kinh điển (Design Patterns).
2. Thực hành thuần thục **30 Kỹ Thuật Refactoring (Martin Fowler)** để cải thiện cấu trúc mã nguồn, khử mùi code xấu (Code Smells).
3. Ứng dụng thực tế vào bài toán quản lý kinh doanh phân bón, thuốc bảo vệ thực vật tại miền Tây.

---

## 📂 Cấu Trúc Repository Dự Án

```text
📦 Thiet-Ke-Phat-Trien-Bao-Tri-Phan-Mem
 ┣ 📂 DPM235403_BuiLeTuanAnh_Tuan01_Creational_Design_Pattern
 ┃ ┣ 📜 Nhóm 5 mẫu khởi tạo lý thuyết (Factory, Builder, Abstract, Prototype, Singleton)
 ┃ ┗ 📜 Ứng dụng: Quản lý hóa đơn sỉ/lẻ, kho FIFO, nhân bản lô thuốc, phiên đăng nhập.
 ┃
 ┣ 📂 DPM235403_BuiLeTuanAnh_Tuan02_Structural_Design_Pattern
 ┃ ┣ 📂 Nhóm 7 mẫu cấu trúc lý thuyết (Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy)
 ┃ ┗ 📜 Ứng dụng: Tích hợp API vận chuyển, cây kho hàng, thêm phí ship/VAT, phân quyền.
 ┃
 ┣ 📂 DPM235403_BuiLeTuanAnh_Tuan03_Behavioral_Design_Pattern
 ┃ ┣ 📂 Nhóm 10 mẫu hành vi lý thuyết (Chain of Resp, Command, Iterator, Mediator, Memento, Observer, State, Strategy, Template, Visitor)
 ┃ ┗ 📜 Ứng dụng: Duyệt chiết khấu, Undo giao dịch, duyệt hóa đơn, tính thuế xuất kho.
 ┃
 ┣ 📂 DPM235403_BuiLeTuanAnh_BTH03 (30 Kỹ Thuật Refactoring - Martin Fowler)
 ┃ ┣ 📂 DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod đến _30_FormTemplateMethod
 ┃ ┗ 📜 Mỗi bài gồm 4 cấu trúc chuẩn: Before.cs, After.cs, Real.cs (Domain Nông Dược), Program.cs
 ┃
 ┣ 📂 Cuahang_Nongduoc (Mã nguồn gốc phần mềm nhận bảo trì)
 ┣ 📜 .gitignore
 ┗ 📜 README.md
