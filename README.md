# Nhom6-NT106.Q12
Thành viên nhóm:                                                                                                                                                                        
**23521228	Bùi Lê Huy Phước**                                                                                                                                                                                     
**23521250	Bùi Cao Minh Quân**                                                                                                                
**24520669	Lê Quang Huy**                                                                                                                                              
**23521480	Nguyễn Bá Thiện**                                                                                                                      
**23521558	Nguyễn Phan Thanh Thủy**  <h1 align="center">💻 ỨNG DỤNG QUẢN LÝ TÀI KHOẢN NGƯỜI DÙNG</h1>

<p align="center">
  <img src="Resources/banner.png" alt="banner" width="800">
</p>

---

## 🧩 **MÔ TẢ BÀI TẬP**

Ứng dụng được xây dựng bằng **Windows Forms (C#)**, hỗ trợ người dùng:
- 📝 Đăng ký tài khoản mới  
- 🔐 Đăng nhập vào hệ thống  
- 🔁 Đổi mật khẩu và kiểm tra trùng mật khẩu cũ  
- 👤 Cập nhật thông tin cá nhân  
- 🔒 Mã hóa mật khẩu bằng **SHA256** trước khi lưu vào cơ sở dữ liệu  

Cơ sở dữ liệu sử dụng **SQL Server**, lưu trữ trong bảng `NguoiDung` với các thông tin:
> Username, Email, Họ tên, Mật khẩu (đã mã hóa), Ngày sinh, Giới tính, Địa chỉ, Số điện thoại.

---

## ⚙️ **HƯỚNG DẪN CÀI ĐẶT**

### 🧱 Yêu cầu môi trường
- Visual Studio 2022 hoặc mới hơn (chọn workload: `.NET Desktop Development`)
- SQL Server + SQL Server Management Studio (SSMS)

### 🚀 Cài đặt
1. Clone project:
   ```bash
   git clone https://github.com/<your-username>/<repo-name>.git
Tạo cơ sở dữ liệu:

Mở SSMS

Chạy file SQL có sẵn trong thư mục:

pgsql
Sao chép mã
Database/QL_TaiKhoan.sql
Kiểm tra chuỗi kết nối trong App.config hoặc phần code C#:

csharp
Sao chép mã
Data Source=.;Initial Catalog=QL_TaiKhoan;Integrated Security=True;
⚠️ Nếu bạn đặt tên SQL khác, hãy sửa lại Data Source cho đúng.

Mở file .sln trong Visual Studio, sau đó nhấn Ctrl + F5 để chạy ứng dụng.

🪄 HƯỚNG DẪN SỬ DỤNG
🔸 Đăng ký tài khoản
Nhập đầy đủ thông tin: Username, Email, Mật khẩu, Xác nhận mật khẩu.

Mật khẩu hợp lệ nếu có:

≥ 8 ký tự

Ít nhất 1 chữ hoa, 1 chữ thường, 1 ký tự đặc biệt, 1 chữ số.

Nhấn Đăng ký → Tài khoản được lưu trong SQL Server.

🔸 Đăng nhập
Nhập Username/Email và mật khẩu đã tạo.

Nếu đúng → chuyển sang giao diện người dùng.

🔸 Đổi mật khẩu
Nhập mật khẩu cũ và mật khẩu mới.

Nếu mật khẩu mới trùng mật khẩu cũ → báo lỗi.

Nếu hợp lệ → cập nhật mật khẩu mới (được mã hóa SHA256).

🔸 Quên mật khẩu
Nhập Email để nhận liên kết hoặc tạo mật khẩu mới trực tiếp.

Hệ thống sẽ cập nhật thông tin trong cơ sở dữ liệu.

🔸 Đăng xuất
Nhấn nút “Đăng xuất” để quay lại màn hình đăng nhập.

🖼️ CÁC MÀN HÌNH GIAO DIỆN ỨNG DỤNG
🔹 Màn hình Đăng nhập
<p align="center"> <img src="Resources/login.png" alt="Màn hình đăng nhập" width="600"> </p>
🔹 Màn hình Đăng ký
<p align="center"> <img src="Resources/register.png" alt="Màn hình đăng ký" width="600"> </p>
🔹 Màn hình Quên mật khẩu
<p align="center"> <img src="Resources/forgot_password.png" alt="Màn hình quên mật khẩu" width="600"> </p>
🔹 Màn hình Đổi mật khẩu
<p align="center"> <img src="Resources/change_password.png" alt="Màn hình đổi mật khẩu" width="600"> </p>

**Sử dụng**  

**Các màn hình giao diện ứng dụng**    

