CREATE PROC ThemNV
(	
	@idnv nvarchar(3),
	@hoten nvarchar(50),
	@ngaysinh datetime,
	@gioitinh nvarchar(10),
	@chucdanh nvarchar(30),
	@loainv nvarchar(20),
	@sdt char(10),
	@taikhoan varchar(100),
	@matkhau varchar(100),
	@hinh nvarchar(max),
	@Email varchar(100) 
)
AS 
BEGIN
	INSERT INTO NhanVien(IDNV,HoTen, NgaySinh, GioiTinh, ChucDanh, LoaiNV, SDT, TaiKhoan, MatKhau, Email, Hinh, TrangThai) 
	VALUES (@idnv, @hoten, @ngaysinh, @gioitinh, @chucdanh, @loainv, @sdt, @taikhoan, @matkhau, @Email, @hinh, 1)
END

GO 

CREATE PROC XaoNV
(
	@idnv nvarchar(3)
)
AS
BEGIN
	UPDATE NhanVien
	SET TrangThai = 0
	WHERE IDNV = @idnv
END

GO
CREATE PROC CapNhatNV
(
	@idnv nvarchar(3),
	@hoten nvarchar(50),
	@ngaysinh datetime,
	@gioitinh nvarchar(10),
	@chucdanh nvarchar(30),
	@loainv nvarchar(20),
	@sdt char(10),
	@taikhoan varchar(100),
	@matkhau varchar(100),
	@Email varchar(100), 
	@hinh nvarchar(max)
)
AS
BEGIN
	UPDATE NhanVien
	SET IDNV = @idnv, HoTen = @hoten, NgaySinh = @ngaysinh, GioiTinh = @gioitinh,
		ChucDanh = @chucdanh, LoaiNV = @loainv, SDT = @sdt, TaiKhoan = @taikhoan,
		MatKhau = @matkhau, Email = @Email
	WHERE IDNV = @idnv and TrangThai = 1
END

