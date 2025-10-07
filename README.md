# Nhom6-NT106.Q12
Thành viên nhóm:                                                                                                                                                                        
**23521228	Bùi Lê Huy Phước**                                                                                                                                                                                     
**23521250	Bùi Cao Minh Quân**                                                                                                                
**24520669	Lê Quang Huy**                                                                                                                                              
**23521480	Nguyễn Bá Thiện**                                                                                                                      
**23521558	Nguyễn Phan Thanh Thủy** 
# 🧩 ỨNG DỤNG QUẢN LÝ NGƯỜI DÙNG  
### Môn: Lập Trình Trực Quan (NT106)  
### Nhóm 6 – Bài Tập Về Nhà 1

---

## 📝 MÔ TẢ BÀI TẬP

Ứng dụng được xây dựng bằng **C# WinForms (.NET Framework)** nhằm mô phỏng quy trình **quản lý tài khoản người dùng** trong một hệ thống đơn giản.  
Người dùng có thể thực hiện các thao tác cơ bản như:

- 🔐 **Đăng nhập** với tên người dùng hoặc email.
- 🆕 **Đăng ký** tài khoản mới bằng cách nhập thông tin cá nhân đầy đủ.
- ❓ **Quên mật khẩu**, nhận và xác thực mã OTP để tạo lại mật khẩu mới.
- 🔄 **Đổi mật khẩu** sau khi xác thực.
- 👤 **Xem thông tin cá nhân** sau khi đăng nhập thành công.
- 🚪 **Đăng xuất** khỏi hệ thống.

Mỗi chức năng được xây dựng thành một form riêng trong không gian tên  
`BTVN1_Nhom6_NT106.Q12`, gồm:

| Form | Mục đích |
|------|-----------|
| `Dangnhap` | Cho phép người dùng đăng nhập |
| `Dangky` | Cho phép người dùng tạo tài khoản mới |
| `Quenmatkhau` | Xác thực email và gửi mã OTP |
| `MatKhauMoi` | Đặt lại mật khẩu mới sau khi quên |
| `ThongTinNguoiDung` | Hiển thị thông tin chi tiết người dùng đã đăng nhập |

---

## ⚙️ HƯỚNG DẪN CÀI ĐẶT

1. **Yêu cầu hệ thống:**
   - Windows 10 hoặc mới hơn  
   - Visual Studio 2022 hoặc tương đương  
   - .NET Framework 6.0 trở lên  

2. **Cách cài đặt và chạy ứng dụng:**
   ```bash
   # Clone project
   git clone https://github.com/<your-repo>/BTVN1_Nhom6_NT106.git

   # Mở Visual Studio
   # → Chọn File → Open → Project/Solution
   # → Chạy file .sln của project

   # Nhấn F5 để chạy chương trình
