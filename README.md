# 📝Nhóm 6- NT106.Q12 - GVHD: Lê Minh Khánh Hội

Thành viên nhóm:                                                                                                                                                                        
**23521228	Bùi Lê Huy Phước**                                                                                                                                                                                     
**23521250	Bùi Cao Minh Quân**                                                                                                                
**24520669	Lê Quang Huy**                                                                                                                                              
**23521480	Nguyễn Bá Thiện**                                                                                                                      
**23521558	Nguyễn Phan Thanh Thủy** 

# 🧩 ỨNG DỤNG QUẢN LÝ NGƯỜI DÙNG  
### Môn: Lập Trình Mạng Căn Bản (NT106)  
### Bài Tập Về Nhà Tuần 3
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
   # Clone project về Visual Studio
   git clone https://github.com/phuoccouhp/BTVN1_Nhom6_NT106.git

   # Tải file SQL về, chạy file SQL để tạo database QL_TaiKhoan  
   # Tải thủ công vì file sql đặt ở ngoài thư mục BTVN

    # Mở Visual Studio
   # → Chọn File → Open → Project/Solution
   # → Chạy file .sln của project

   # Nhấn F5 để chạy chương trình
## 💡 HƯỚNG DẪN SỬ DỤNG
# 1️⃣ Màn hình Đăng nhập (Dangnhap)
<img width="661" height="311" alt="image" src="https://github.com/user-attachments/assets/38cd2cbc-3a2e-46e0-8ea9-c4ab9fc6ba56" />

Nhập Username/Email và Mật khẩu

Chọn Đăng nhập để truy cập hệ thống

Có thể bấm “Quên mật khẩu?” để phục hồi mật khẩu

Nếu chưa có tài khoản, chọn “Đăng ký”

# 2️⃣ Màn hình Đăng ký (Dangky)
<img width="643" height="601" alt="image" src="https://github.com/user-attachments/assets/ca33ef3f-46d9-4765-bab9-3106841e91ab" />

Nhập các thông tin cá nhân:

Username

Email

Họ tên

Mật khẩu & Nhập lại mật khẩu, Mật khẩu được mã hoá  SHA-256 trước khi lưu vào SQL   

Số điện thoại, Ngày sinh, Giới tính, Địa chỉ (Tuỳ chọn)  

Nhấn “Đăng ký” để tạo tài khoản mới

Nếu đã có tài khoản, chọn “Đăng nhập”

# 3️⃣ Màn hình Quên mật khẩu (Quenmatkhau)
<img width="804" height="479" alt="image" src="https://github.com/user-attachments/assets/e17e1cf8-fe81-408f-afb7-e6a512010f76" />   

Nhập Email đăng ký

Nhấn “Gửi OTP” để nhận mã xác thực thông qua gmail

Nhập mã OTP nhận được → chọn “Xác thực” để chuyển sang màn hình đổi mật khẩu mới.

# 4️⃣ Màn hình Đổi mật khẩu (MatKhauMoi)
<img width="814" height="499" alt="image" src="https://github.com/user-attachments/assets/fd41c7d1-8323-4096-b69d-8a4cb1ae0a01" />    

Nhập Username/Email

Nhập mật khẩu mới và xác nhận lại, mật khẩu mới sẽ được kiểm tra và mã hoá bằng SHA-256 trước khi đưa vào SQL  

Nhấn “Đổi mật khẩu” để cập nhật mật khẩu lên SQL

# 5️⃣ Màn hình Thông tin người dùng (ThongTinNguoiDung)
<img width="641" height="557" alt="image" src="https://github.com/user-attachments/assets/22e81f6c-0335-4b4e-8655-4b4d3fd90d34" />    

Hiển thị thông tin cá nhân của người dùng:

Username, Email, Mật khẩu, SĐT, Giới tính, Ngày sinh, Địa chỉ

Có thể chọn 👁 hiện/ẩn mật khẩu( dạng mã hoá SHA-256)  

Nhấn “Đăng xuất” để thoát khỏi tài khoản
