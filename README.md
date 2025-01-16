# SOA_B1

## Mô tả Dự án
Dự án này bao gồm hai phần chính:
1. **DB_WS**: Một SOAP Web Service được xây dựng bằng ASP.NET để truy xuất thông tin thành phố và quốc gia từ cơ sở dữ liệu MySQL.
2. **CityClient**: Một ứng dụng WinForms được xây dựng bằng C# để kết nối với Web Service và thực hiện các chức năng truy xuất dữ liệu.

---
## Cách sử dụng

### 1. **Khởi chạy Web Service (DB_WS)**
   - Mở thư mục `DB_WS` trong Visual Studio.
   - Build và chạy dự án để khởi động Web Service.
   - Đảm bảo rằng cơ sở dữ liệu MySQL đang chạy và thông tin kết nối được cấu hình đúng trong `ConnectDB.cs`.

### 2. **Khởi chạy ứng dụng khách (CityClient)**
   - Mở thư mục `CityClient` trong Visual Studio.
   - Build và chạy ứng dụng.
   - Sử dụng giao diện để thực hiện các chức năng như tìm kiếm hoặc hiển thị danh sách.

---

## Yêu cầu hệ thống
- **Visual Studio 2019** hoặc mới hơn.
- **.NET Framework 4.7.2** hoặc cao hơn.
- **MySQL Server** và thư viện **MySqlConnector**.
- **Cơ sở dữ liệu "world"** được cấu hình trước trong MySQL.

---
## Các bài học rút ra

### 1. **Hiểu về Web Services**
   - Tìm hiểu cách xây dựng và triển khai một **SOAP Web Service** với ASP.NET.
   - Học cách sử dụng các phương thức SOAP để trao đổi dữ liệu giữa server và client.

### 2. **Kết nối với cơ sở dữ liệu MySQL**
   - Học cách sử dụng thư viện **MySqlConnector** để kết nối và thao tác với cơ sở dữ liệu.
   - Sử dụng các phương pháp tối ưu hóa kết nối để cải thiện hiệu suất ứng dụng.

### 3. **Xây dựng ứng dụng WinForm**
   - Phát triển giao diện người dùng với WinForm để tạo kết nối trực quan giữa người dùng và dịch vụ Web.
   - Kết nối và trao đổi dữ liệu với service để thực thi các chức năng
---
## Tác giả
- **Thien Huong**
