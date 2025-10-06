# Nhom6-NT106.Q12
Thành viên nhóm:                                                                                                                                                                        
**23521228	Bùi Lê Huy Phước**                                                                                                                                                                                     
**23521250	Bùi Cao Minh Quân**                                                                                                                
**24520669	Lê Quang Huy**                                                                                                                                              
**23521480	Nguyễn Bá Thiện**                                                                                                                      
**23521558	Nguyễn Phan Thanh Thủy** 
<h1 align="center">💻 ỨNG DỤNG QUẢN LÝ TÀI KHOẢN NGƯỜI DÙNG</h1> <p align="center"> <img src="Resources/banner.png" alt="banner" width="800"> </p>
🧩 MÔ TẢ BÀI TẬP

Ứng dụng được phát triển bằng Windows Forms (C#) giúp quản lý người dùng bao gồm:

📝 Đăng ký tài khoản mới

🔐 Đăng nhập hệ thống

🔁 Đổi mật khẩu (kiểm tra trùng mật khẩu cũ)

👤 Cập nhật và hiển thị thông tin cá nhân

🔒 Mã hóa mật khẩu bằng SHA256 trước khi lưu vào SQL Server

Cơ sở dữ liệu được tạo trong SQL Server với bảng NguoiDung gồm các cột:

Username, Email, HoTen, PasswordHash, NgaySinh, GioiTinh, DiaChi, SoDienThoai.

⚙️ HƯỚNG DẪN CÀI ĐẶT
🧱 Yêu cầu môi trường

Visual Studio 2022 (hoặc mới hơn)

Cần chọn workload: .NET Desktop Development

SQL Server + SQL Server Management Studio (SSMS)

🚀 Cài đặt

Clone project:

git clone https://github.com/<your-username>/<repo-name>.git


Tạo cơ sở dữ liệu:

Mở SSMS

Chạy file SQL trong thư mục:

Database/QL_TaiKhoan.sql


Cấu hình chuỗi kết nối trong code C#:

Data Source=.;Initial Catalog=QL_TaiKhoan;Integrated Security=True;


⚠️ Nếu SQL của bạn có tên khác, chỉnh lại Data Source cho phù hợp.

Mở file .sln bằng Visual Studio, nhấn Ctrl + F5 để chạy ứng dụng.

🪄 HƯỚNG DẪN SỬ DỤNG
🔸 Đăng ký tài khoản

Nhập đầy đủ thông tin: Username, Email, Mật khẩu, Xác nhận mật khẩu.

Mật khẩu hợp lệ khi có:

Ít nhất 8 ký tự

Có chữ hoa, chữ thường, ký tự đặc biệt và số

Nhấn Đăng ký để lưu vào SQL.

🔸 Đăng nhập

Nhập Username/Email và mật khẩu đã đăng ký.

Nếu đúng → chuyển sang giao diện người dùng.

🔸 Đổi mật khẩu

Nhập mật khẩu cũ và mật khẩu mới.

Nếu trùng mật khẩu cũ → báo lỗi.

Nếu hợp lệ → cập nhật mật khẩu mới (mã hóa SHA256).

🔸 Quên mật khẩu

Nhập Email → khôi phục hoặc tạo mật khẩu mới.

Cập nhật thông tin trong cơ sở dữ liệu.

🔸 Đăng xuất

Nhấn Đăng xuất để quay lại màn hình đăng nhập.

🖼️ CÁC MÀN HÌNH GIAO DIỆN ỨNG DỤNG
🔹 Màn hình Đăng nhập
<p align="center"> <img src="Resources/login.png" alt="Màn hình đăng nhập" width="600"> </p>
🔹 Màn hình Đăng ký
<p align="center"> <img src="Resources/register.png" alt="Màn hình đăng ký" width="600"> </p>
🔹 Màn hình Quên mật khẩu
<p align="center"> <img src="Resources/forgot_password.png" alt="Màn hình quên mật khẩu" width="600"> </p>
🔹 Màn hình Đổi mật khẩu
<p align="center"> <img src="Resources/change_password.png" alt="Màn hình đổi mật khẩu" width="600"> </p>
