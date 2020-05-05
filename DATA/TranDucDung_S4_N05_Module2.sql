--Thêm 5 bộ dữ liệu mỗi bảng
--Thêm môn học
create proc ThemMH @mamh varchar(10), @tenmh nvarchar(20), @sotiet int
as
	begin
		insert into MonHoc(mamh,tenmh,sotiet)
		values(@mamh,@tenmh,@sotiet)
	end


ThemMH 'TO1',N'Toán lớp 6', 60
ThemMH 'HH1',N'Hóa học lớp 6', 60
ThemMH 'VH1', N'Văn học lớp 6', 60
ThemMH 'VL1', N'Vật lý lớp 6', 60
ThemMH 'TA1', N'Tiếng anh lớp 6', 60

ThemMH 'LS1', N'Lịch sử lớp 6', 60
ThemMH 'DL1', N'Địa lý lớp 6', 60
ThemMH 'CN1', N'Công nghệ lớp 6', 60
ThemMH 'GD1', N'GDCD lớp 6', 60
ThemMH 'SH1', N'Sinh học lớp 6', 60
ThemMH 'MT1', N'Mỹ thuật lớp 6', 60
ThemMH 'AN1', N'Âm nhạc lớp 6', 60
ThemMH 'TD1', N'Thể dục lớp 6', 60

--Thêm giáo viên
create proc ThemGV @magv varchar(10), @tengv nvarchar(50), @ngaysinh date, @gioitinh nvarchar(4), @sdt varchar(12), @diachi nvarchar(100)
as
	begin
		insert into GiaoVien(magv,tengv,ngaysinh,gioitinh,sdt,diachi)
		values(@magv,@tengv,@ngaysinh,@gioitinh,@sdt,@diachi)
	end

ThemGV '1', N'Nguyễn Hùng Sinh', '1990-8-8', N'Nam', '091234534263', N'Ngõ 200, Tây Hồ, Hà Nội'
ThemGV '2', N'Hoàng Thùy Linh', '1988-3-10', N'Nữ', '039164826753', N'Ngõ 53, Bưởi, Hà Nội'
ThemGV '3', N'Trần Xuân Phong', '1970-10-3', N'Nam', '019362728394', N'Số 74, Hoàng Quốc Việt, Hà Nội'
ThemGV '4', N'Lê Xuân Linh', '1992-12-1', N'Nữ', '038294516343', N'Ngõ 93, Xuân Thủy, Hà Nội'
ThemGV '5', N'Lung Thị Linh', '1977-1-28', N'Nam', '093527436412', N'Ngõ 1000, Giải Phóng, Hà Nội'

ThemGV '11', N'Nguyễn Thị Loan', '1990-8-8', N'Nam', '091234534263', N'Ngõ 200, Tây Hồ, Hà Nội'
ThemGV '12', N'Hoàng Linh Linh', '1988-3-10', N'Nữ', '039164826753', N'Ngõ 53, Bưởi, Hà Nội'
ThemGV '13', N'Trần Xuân Nhạn', '1970-10-3', N'Nam', '019362728394', N'Số 74, Hoàng Quốc Việt, Hà Nội'
ThemGV '14', N'Lê Xuân Khang', '1992-12-1', N'Nữ', '038294516343', N'Ngõ 93, Xuân Thủy, Hà Nội'
ThemGV '15', N'Nguyễn Bằng', '1977-1-28', N'Nam', '093527436412', N'Ngõ 1000, Giải Phóng, Hà Nội'

ThemGV '16', N'Nông Hùng Giang', '1991-9-8', N'Nam', '091923534263', N'Ngõ 35, Xuân THủy, Hà Nội'
ThemGV '17', N'La Nông Văn Nữ', '1998-10-10', N'Nữ', '039192826753', N'Ngõ 02, Bưởi, Hà Nội'
ThemGV '18', N'Trần Trần Yên', '1970-10-3', N'Nam', '019092728394', N'Số 74, Trần Quốc Hoàn, Hà Nội'

--Thêm lịch giảng dạy
create proc ThemGD @mamh varchar(10), @magv varchar(10)
as
	begin
		insert into GiangDay(mamh,magv)
		values(@mamh,@magv)
	end

ThemGD 'TO1', '1'
ThemGD 'HH1', '2'
ThemGD 'VH1', '3'
ThemGD 'VL1', '4'
ThemGD 'TA1', '5'

ThemGD 'LS1', '11'
ThemGD 'DL1', '12'
ThemGD 'CN1', '13'
ThemGD 'GD1', '14'
ThemGD 'SH1', '15'
ThemGD 'MT1', '16'
ThemGD 'AN1', '17'
ThemGD 'TD1', '18'


--Thêm lớp
create proc ThemLop @malop varchar(10), @tenlop varchar(10), @nienkhoa varchar(10), @magvcn varchar(10)
as
	begin
		insert into Lop(malop,tenlop,nienkhoa,magvcn)
		values(@malop,@tenlop,@nienkhoa,@magvcn)
	end

ThemLop 'Lop1', 'A1', '2019-2025', '1'
ThemLop 'Lop2', 'A2', '2019-2025', '2'
ThemLop 'Lop3', 'B1', '2019-2025', '3'
ThemLop 'Lop4', 'B2', '2019-2025', '4'
ThemLop 'Lop5', 'C1', '2019-2025', '5'

--Thêm phân công giảng dạy
create proc ThemPC @magv varchar(10), @malop varchar(10)
as
	begin
		insert into PhanCong(magv,malop)
		values(@magv,@malop)
	end

ThemPC '1', 'Lop1'
ThemPC '2', 'Lop1'
ThemPC '3', 'Lop1'
ThemPC '4', 'Lop1'
ThemPC '5', 'Lop1'

ThemPC '11', 'Lop1'
ThemPC '12', 'Lop1'
ThemPC '13', 'Lop1'
ThemPC '14', 'Lop1'
ThemPC '15', 'Lop1'

ThemPC '16', 'Lop1'
ThemPC '17', 'Lop1'
ThemPC '18', 'Lop1'


--Thêm thời khóa biểu
create proc ThemTKB @malop varchar(10), @mamh varchar(10)
as
	begin
		insert into TKB(malop,mamh)
		values(@malop,@mamh)
	end

ThemTKB 'lop1', 'TO1'
ThemTKB 'lop1', 'HH1'
ThemTKB 'lop1', 'VH1'
ThemTKB 'lop1', 'VL1'
ThemTKB 'lop1', 'TA1'

ThemTKB 'lop1', 'LS1'
ThemTKB 'lop1', 'DL1'
ThemTKB 'lop1', 'CN1'
ThemTKB 'lop1', 'GD1'
ThemTKB 'lop1', 'SH1'
ThemTKB 'lop1', 'MT1'
ThemTKB 'lop1', 'AN1'
ThemTKB 'lop1', 'TD1'

--Thêm học kỳ
create proc ThemHocKy @mahk nvarchar(30), @namhoc varchar(10)
as
	begin
		insert into HocKy(mahk,namhoc)
		values(@mahk,@namhoc)
	end

ThemHocKy 'k60-k1-n1', '2019-2020'
ThemHocKy 'k60-k2-n1', '2019-2020'
ThemHocKy 'k60-k1-n2', '2020-2021'
ThemHocKy 'k60-k2-n2', '2020-2021'
ThemHocKy 'k60-k1-n3', '2021-2022'

--Thêm chi tiết học kỳ
create proc ThemCTHK @mahk nvarchar(30), @mamh varchar(10)
as
	begin
		insert into ChiTietHocKy(mahk,mamh)
		values(@mahk,@mamh)
	end

ThemCTHK 'k60-k1-n1', 'TO1'
ThemCTHK 'k60-k1-n1', 'HH1'
ThemCTHK 'k60-k1-n1', 'VH1'
ThemCTHK 'k60-k1-n1', 'VL1'
ThemCTHK 'k60-k1-n1', 'TA1'

ThemCTHK 'k60-k1-n1', 'LS1'
ThemCTHK 'k60-k1-n1', 'DL1'
ThemCTHK 'k60-k1-n1', 'CN1'
ThemCTHK 'k60-k1-n1', 'GD1'
ThemCTHK 'k60-k1-n1', 'SH1'
ThemCTHK 'k60-k1-n1', 'MT1'
ThemCTHK 'k60-k1-n1', 'AN1'
ThemCTHK 'k60-k1-n1', 'TD1'


--Thêm học sinh
create proc ThemHS @mahs varchar(10), @tenhs nvarchar(50), @gioitinh nvarchar(4), @ngaysinh date, @diachi nvarchar(100), @ghichu nvarchar(100), @malop varchar(10)
as
	begin
		insert into HocSinh(mahs,tenhocsinh,gioitinh,ngaysinh,diachi,ghichu,malop)
		values(@mahs,@tenhs,@gioitinh,@ngaysinh,@diachi,@ghichu,@malop)
	end

ThemHS 'HS1', N'Giàng A Tấng', N'Nam', '1999-6-4', N'Bản Vàng, Làng Bạc, Cao Bằng', N'', 'lop1'
ThemHS 'HS2', N'Nùng Chí Cao', N'Nam', '1998-3-20', N'Bản A Pa, Làng Lũ, Lào Cao', N'', 'lop1'
ThemHS 'HS3', N'Chu Hùng', N'Nam', '1997-12-1', N'Na Lữ, Hào An, Cao Bằng', N'', 'lop1'
ThemHS 'HS4', N'Nguyễn Thị Tha', N'Nữ', '1999-1-29', N'Xuân Thủy, Cầu Giấy, Hà Nội', N'', 'lop1'
ThemHS 'HS5', N'Trần Văn Lang', N'Nam', '1999-7-30', N'Ba Đình, Hà Nội', N'', 'lop1'

--Thêm phụ huynh
create proc ThemPH @mahs varchar(10), @tenph nvarchar(50), @sdt varchar(12)
as
	begin
		insert into PhuHuynh(mahs,tenph,sdt)
		values(@mahs,@tenph,@sdt)
	end

ThemPH 'HS1', N'Giàng Vứ A' , '092837421621'
ThemPH 'HS2', N'Nùng Ha' ,    '092315235235'
ThemPH 'HS3', N'Chu Dũng' ,   '039183726391'
ThemPH 'HS4', N'Nguyễn Nam' , '091837264222'
ThemPH 'HS5', N'Trần Hào' ,   '039287462312'
--Thêm bảng điểm bằng thủ tục
create proc ThemBD @mahs varchar(10), @mamh varchar(10), @diemtb float, @xeploai nvarchar(10)
as
	begin
		insert into BangDiem(mahs,mamh,diemtb,xeploai)
		values(@mahs,@mamh,@diemtb,@xeploai)
	end

--Tự sinh bảng điểm từ điểm nhập vào bên trường điểm 
create trigger TinhBangDiem on Diem for insert 
as 
begin 
	--lấy dữ liệu nhập vào
	declare @heso int, @diem float, @mahs varchar(10), @mamh varchar(10)
	select @heso = heso from inserted
	select @diem = diem from inserted
	select @mahs = mahs from inserted
	select @mamh = mamh from inserted

	--xét trường hợp đã có dữ liệu trong bảng điểm hay chưa 
	if @mahs in (select MaHS from BangDiem where MaMH = @mamh)
	begin
	--trường hợp đã có rồi thì update lại
		declare @temp int 
		select @temp = (select sum(heso) from Diem where MaHS=@mahs and MaMH=@mamh)
		update BangDiem
		set DiemTb = ((DiemTb*(@temp-@heso))+(@heso*@diem))/(@temp)
		where MaHS=@mahs and MaMH=@mamh
		declare @temp0 nvarchar(10)
		select @temp0 = case when @diem < 4 then N'Yếu'
		when @diem >= 4 and @diem <=5 then N'Trung Bình'
		when @diem >= 6 and @diem <=7 then N'Khá'
		else N'Giỏi' end 
		update BangDiem
		set xeploai = @temp0
		where MaHS=@mahs and MaMH=@mamh
	end
	else
	begin
		--trường hợp chưa có thì tạo mới
		declare @temp1 nvarchar(10)
		select @temp1 = case when @diem < 4 then N'Yếu'
		when @diem >= 4 and @diem <=5 then N'Trung Bình'
		when @diem >= 6 and @diem <=7.9 then N'Khá'
		else N'Giỏi' end 
		--gọi proc thêm 
	exec ThemBD @mahs, @mamh, @diem, @temp1 
	end
end


--Thêm điểm cho học sinh
create proc ThemDiem @madiem int, @heso int, @diem float, @mahs varchar(10), @mamh varchar(10), @mahk nvarchar(30)
as
	begin
		insert into Diem(madiem,heso,diem,mahs,mamh,mahk)
		values(@madiem,@heso,@diem,@mahs,@mamh,@mahk)
	end

ThemDiem 1, 1, 8, 'HS1', 'TO1', 'k60-k1-n1'
ThemDiem 2, 1, 9, 'HS2', 'TO1', 'k60-k1-n1'
ThemDiem 3, 1, 7, 'HS3', 'HH1', 'k60-k1-n1'
ThemDiem 4, 1, 8, 'HS4', 'HH1', 'k60-k1-n1'
ThemDiem 5, 1, 10, 'HS5', 'TO1', 'k60-k1-n1'

ThemDiem 6, 2, 9, 'HS1', 'TO1', 'k60-k1-n1'
ThemDiem 7, 2, 10, 'HS2', 'TO1', 'k60-k1-n1'
ThemDiem 8, 2, 9, 'HS3', 'HH1', 'k60-k1-n1'
ThemDiem 9, 2, 7, 'HS4', 'HH1', 'k60-k1-n1'
ThemDiem 10, 2, 9, 'HS5', 'TO1', 'k60-k1-n1'

ThemDiem 56, 3, 9, 'HS1', 'TO1', 'k60-k1-n1'
ThemDiem 57, 3, 10, 'HS2', 'TO1', 'k60-k1-n1'
ThemDiem 58, 3, 7, 'HS3', 'HH1', 'k60-k1-n1'
ThemDiem 59, 3, 6, 'HS4', 'HH1', 'k60-k1-n1'
ThemDiem 60, 3, 5, 'HS5', 'TO1', 'k60-k1-n1'

ThemDiem 61, 1, 7, 'HS1', 'HH1', 'k60-k1-n1'
ThemDiem 62, 1, 4, 'HS2', 'HH1', 'k60-k1-n1'
ThemDiem 63, 1, 5, 'HS3', 'TO1', 'k60-k1-n1'
ThemDiem 64, 1, 8, 'HS4', 'TO1', 'k60-k1-n1'
ThemDiem 65, 1, 9, 'HS5', 'HH1', 'k60-k1-n1'

ThemDiem 66, 2, 5, 'HS1', 'HH1', 'k60-k1-n1'
ThemDiem 67, 2, 4, 'HS2', 'HH1', 'k60-k1-n1'
ThemDiem 68, 2, 5, 'HS3', 'TO1', 'k60-k1-n1'
ThemDiem 69, 2, 4, 'HS4', 'TO1', 'k60-k1-n1'
ThemDiem 70, 2, 5, 'HS5', 'HH1', 'k60-k1-n1'

ThemDiem 71, 3, 6, 'HS1', 'HH1', 'k60-k1-n1'
ThemDiem 72, 3, 8, 'HS2', 'HH1', 'k60-k1-n1'
ThemDiem 73, 3, 7, 'HS3', 'TO1', 'k60-k1-n1'
ThemDiem 74, 3, 8, 'HS4', 'TO1', 'k60-k1-n1'
ThemDiem 75, 3, 9, 'HS5', 'HH1', 'k60-k1-n1'

ThemDiem 76, 1, 10, 'HS1', 'VH1', 'k60-k1-n1'
ThemDiem 77, 1, 9, 'HS2', 'VH1', 'k60-k1-n1'
ThemDiem 78, 1, 7, 'HS3', 'VH1', 'k60-k1-n1'
ThemDiem 79, 1, 9, 'HS4', 'VH1', 'k60-k1-n1'
ThemDiem 80, 1, 4, 'HS5', 'VH1', 'k60-k1-n1'

ThemDiem 81, 2, 5, 'HS1', 'VH1', 'k60-k1-n1'
ThemDiem 82, 2, 4, 'HS2', 'VH1', 'k60-k1-n1'
ThemDiem 83, 2, 5, 'HS3', 'VH1', 'k60-k1-n1'
ThemDiem 84, 2, 4, 'HS4', 'VH1', 'k60-k1-n1'
ThemDiem 85, 2, 5, 'HS5', 'VH1', 'k60-k1-n1'

ThemDiem 86, 3, 8, 'HS1', 'VH1', 'k60-k1-n1'
ThemDiem 87, 3, 8, 'HS2', 'VH1', 'k60-k1-n1'
ThemDiem 88, 3, 6, 'HS3', 'VH1', 'k60-k1-n1'
ThemDiem 89, 3, 8, 'HS4', 'VH1', 'k60-k1-n1'
ThemDiem 90, 3, 7, 'HS5', 'VH1', 'k60-k1-n1'

ThemDiem 91, 1, 5, 'HS1', 'VL1', 'k60-k1-n1'
ThemDiem 92, 1, 4, 'HS2', 'VL1', 'k60-k1-n1'
ThemDiem 93, 1, 5, 'HS3', 'VL1', 'k60-k1-n1'
ThemDiem 94, 1, 8, 'HS4', 'VL1', 'k60-k1-n1'
ThemDiem 95, 1, 10, 'HS5', 'VL1', 'k60-k1-n1'

ThemDiem 96, 2, 8, 'HS1', 'VL1', 'k60-k1-n1'
ThemDiem 97, 2, 7, 'HS2', 'VL1', 'k60-k1-n1'
ThemDiem 98, 2, 5, 'HS3', 'VL1', 'k60-k1-n1'
ThemDiem 99, 2, 4, 'HS4', 'VL1', 'k60-k1-n1'
ThemDiem 100, 2, 7, 'HS5', 'VL1', 'k60-k1-n1'

ThemDiem 101, 3, 9, 'HS1', 'VL1', 'k60-k1-n1'
ThemDiem 102, 3, 10, 'HS2', 'VL1', 'k60-k1-n1'
ThemDiem 103, 3, 7, 'HS3', 'VL1', 'k60-k1-n1'
ThemDiem 104, 3, 4, 'HS4', 'VL1', 'k60-k1-n1'
ThemDiem 105, 3, 6, 'HS5', 'VL1', 'k60-k1-n1'

ThemDiem 106, 1, 9, 'HS1', 'TA1', 'k60-k1-n1'
ThemDiem 107, 1, 9, 'HS2', 'TA1', 'k60-k1-n1'
ThemDiem 108, 1, 9, 'HS3', 'TA1', 'k60-k1-n1'
ThemDiem 109, 1, 9, 'HS4', 'TA1', 'k60-k1-n1'
ThemDiem 110, 1, 9, 'HS5', 'TA1', 'k60-k1-n1'

ThemDiem 111, 2, 10, 'HS1', 'TA1', 'k60-k1-n1'
ThemDiem 112, 2, 7, 'HS2', 'TA1', 'k60-k1-n1'
ThemDiem 113, 2, 8, 'HS3', 'TA1', 'k60-k1-n1'
ThemDiem 114, 2, 9, 'HS4', 'TA1', 'k60-k1-n1'
ThemDiem 115, 2, 7, 'HS5', 'TA1', 'k60-k1-n1'

ThemDiem 116, 3, 6, 'HS1', 'TA1', 'k60-k1-n1'
ThemDiem 117, 3, 5, 'HS2', 'TA1', 'k60-k1-n1'
ThemDiem 118, 3, 9, 'HS3', 'TA1', 'k60-k1-n1'
ThemDiem 119, 3, 9, 'HS4', 'TA1', 'k60-k1-n1'
ThemDiem 120, 3, 10, 'HS5', 'TA1', 'k60-k1-n1'

ThemDiem 121, 1, 8, 'HS1', 'LS1', 'k60-k1-n1'
ThemDiem 122, 1, 10, 'HS2', 'LS1', 'k60-k1-n1'
ThemDiem 123, 1, 9, 'HS3', 'LS1', 'k60-k1-n1'
ThemDiem 124, 1, 2, 'HS4', 'LS1', 'k60-k1-n1'
ThemDiem 125, 1, 8, 'HS5', 'LS1', 'k60-k1-n1'

ThemDiem 126, 2, 8, 'HS1', 'LS1', 'k60-k1-n1'
ThemDiem 127, 2, 7, 'HS2', 'LS1', 'k60-k1-n1'
ThemDiem 128, 2, 5, 'HS3', 'LS1', 'k60-k1-n1'
ThemDiem 129, 2, 4, 'HS4', 'LS1', 'k60-k1-n1'
ThemDiem 130, 2, 7, 'HS5', 'LS1', 'k60-k1-n1'

ThemDiem 131, 3, 9, 'HS1', 'LS1', 'k60-k1-n1'
ThemDiem 132, 3, 10, 'HS2', 'LS1', 'k60-k1-n1'
ThemDiem 133, 3, 7, 'HS3', 'LS1', 'k60-k1-n1'
ThemDiem 134, 3, 4, 'HS4', 'LS1', 'k60-k1-n1'
ThemDiem 135, 3, 6, 'HS5', 'LS1', 'k60-k1-n1'

ThemDiem 136, 1, 9, 'HS1', 'DL1', 'k60-k1-n1'
ThemDiem 137, 1, 9, 'HS2', 'DL1', 'k60-k1-n1'
ThemDiem 138, 1, 9, 'HS3', 'DL1', 'k60-k1-n1'
ThemDiem 139, 1, 9, 'HS4', 'DL1', 'k60-k1-n1'
ThemDiem 140, 1, 9, 'HS5', 'DL1', 'k60-k1-n1'

ThemDiem 141, 2, 8, 'HS1', 'DL1', 'k60-k1-n1'
ThemDiem 142, 2, 8, 'HS2', 'DL1', 'k60-k1-n1'
ThemDiem 143, 2, 7, 'HS3', 'DL1', 'k60-k1-n1'
ThemDiem 144, 2, 5, 'HS4', 'DL1', 'k60-k1-n1'
ThemDiem 145, 2, 6, 'HS5', 'DL1', 'k60-k1-n1'

ThemDiem 146, 3, 6, 'HS1', 'DL1', 'k60-k1-n1'
ThemDiem 147, 3, 5, 'HS2', 'DL1', 'k60-k1-n1'
ThemDiem 148, 3, 9, 'HS3', 'DL1', 'k60-k1-n1'
ThemDiem 149, 3, 9, 'HS4', 'DL1', 'k60-k1-n1'
ThemDiem 150, 3, 9, 'HS5', 'DL1', 'k60-k1-n1'

ThemDiem 151, 1, 10, 'HS1', 'CN1', 'k60-k1-n1'
ThemDiem 152, 1, 9, 'HS2', 'CN1', 'k60-k1-n1'
ThemDiem 153, 1, 9, 'HS3', 'CN1', 'k60-k1-n1'
ThemDiem 154, 1, 6, 'HS4', 'CN1', 'k60-k1-n1'
ThemDiem 155, 1, 7, 'HS5', 'CN1', 'k60-k1-n1'

ThemDiem 156, 2, 9, 'HS1', 'CN1', 'k60-k1-n1'
ThemDiem 157, 2, 8, 'HS2', 'CN1', 'k60-k1-n1'
ThemDiem 158, 2, 4, 'HS3', 'CN1', 'k60-k1-n1'
ThemDiem 159, 2, 5, 'HS4', 'CN1', 'k60-k1-n1'
ThemDiem 160, 2, 8, 'HS5', 'CN1', 'k60-k1-n1'

ThemDiem 161, 3, 6, 'HS1', 'CN1', 'k60-k1-n1'
ThemDiem 162, 3, 9, 'HS2', 'CN1', 'k60-k1-n1'
ThemDiem 163, 3, 8, 'HS3', 'CN1', 'k60-k1-n1'
ThemDiem 164, 3, 6, 'HS4', 'CN1', 'k60-k1-n1'
ThemDiem 165, 3, 8, 'HS5', 'CN1', 'k60-k1-n1'

ThemDiem 166, 1, 10, 'HS1', 'GD1', 'k60-k1-n1'
ThemDiem 167, 1, 8, 'HS2', 'GD1', 'k60-k1-n1'
ThemDiem 168, 1, 7, 'HS3', 'GD1', 'k60-k1-n1'
ThemDiem 169, 1, 9, 'HS4', 'GD1', 'k60-k1-n1'
ThemDiem 170, 1, 8, 'HS5', 'GD1', 'k60-k1-n1'

ThemDiem 171, 2, 5, 'HS1', 'GD1', 'k60-k1-n1'
ThemDiem 172, 2, 8, 'HS2', 'GD1', 'k60-k1-n1'
ThemDiem 173, 2, 7, 'HS3', 'GD1', 'k60-k1-n1'
ThemDiem 174, 2, 6, 'HS4', 'GD1', 'k60-k1-n1'
ThemDiem 175, 2, 8, 'HS5', 'GD1', 'k60-k1-n1'

ThemDiem 176, 3, 8, 'HS1', 'GD1', 'k60-k1-n1'
ThemDiem 177, 3, 5, 'HS2', 'GD1', 'k60-k1-n1'
ThemDiem 178, 3, 10, 'HS3', 'GD1', 'k60-k1-n1'
ThemDiem 179, 3, 9, 'HS4', 'GD1', 'k60-k1-n1'
ThemDiem 180, 3, 9, 'HS5', 'GD1', 'k60-k1-n1'

ThemDiem 181, 1, 8, 'HS1', 'SH1', 'k60-k1-n1'
ThemDiem 182, 1, 10, 'HS2', 'SH1', 'k60-k1-n1'
ThemDiem 183, 1, 4, 'HS3', 'SH1', 'k60-k1-n1'
ThemDiem 184, 1, 8, 'HS4', 'SH1', 'k60-k1-n1'
ThemDiem 185, 1, 9, 'HS5', 'SH1', 'k60-k1-n1'

ThemDiem 186, 2, 10, 'HS1', 'SH1', 'k60-k1-n1'
ThemDiem 187, 2, 8, 'HS2', 'SH1', 'k60-k1-n1'
ThemDiem 188, 2, 6, 'HS3', 'SH1', 'k60-k1-n1'
ThemDiem 189, 2, 5, 'HS4', 'SH1', 'k60-k1-n1'
ThemDiem 190, 2, 9, 'HS5', 'SH1', 'k60-k1-n1'

ThemDiem 191, 3, 6, 'HS1', 'SH1', 'k60-k1-n1'
ThemDiem 192, 3, 9, 'HS2', 'SH1', 'k60-k1-n1'
ThemDiem 193, 3, 8, 'HS3', 'SH1', 'k60-k1-n1'
ThemDiem 194, 3, 6, 'HS4', 'SH1', 'k60-k1-n1'
ThemDiem 195, 3, 8, 'HS5', 'SH1', 'k60-k1-n1'

ThemDiem 196, 1, 10, 'HS1', 'MT1', 'k60-k1-n1'
ThemDiem 197, 1, 9, 'HS2', 'MT1', 'k60-k1-n1'
ThemDiem 198, 1, 7, 'HS3', 'MT1', 'k60-k1-n1'
ThemDiem 199, 1, 8, 'HS4', 'MT1', 'k60-k1-n1'
ThemDiem 200, 1, 10, 'HS5', 'MT1', 'k60-k1-n1'

ThemDiem 201, 2, 7, 'HS1', 'MT1', 'k60-k1-n1'
ThemDiem 202, 2, 8, 'HS2', 'MT1', 'k60-k1-n1'
ThemDiem 203, 2, 9, 'HS3', 'MT1', 'k60-k1-n1'
ThemDiem 204, 2, 10, 'HS4', 'MT1', 'k60-k1-n1'
ThemDiem 205, 2, 9, 'HS5', 'MT1', 'k60-k1-n1'

ThemDiem 206, 3, 10, 'HS1', 'MT1', 'k60-k1-n1'
ThemDiem 207, 3, 9, 'HS2', 'MT1', 'k60-k1-n1'
ThemDiem 208, 3, 10, 'HS3', 'MT1', 'k60-k1-n1'
ThemDiem 209, 3, 9, 'HS4', 'MT1', 'k60-k1-n1'
ThemDiem 210, 3, 9, 'HS5', 'MT1', 'k60-k1-n1'

ThemDiem 211, 1, 8, 'HS1', 'AN1', 'k60-k1-n1'
ThemDiem 212, 1, 10, 'HS2', 'AN1', 'k60-k1-n1'
ThemDiem 213, 1, 9, 'HS3', 'AN1', 'k60-k1-n1'
ThemDiem 214, 1, 8, 'HS4', 'AN1', 'k60-k1-n1'
ThemDiem 215, 1, 9, 'HS5', 'AN1', 'k60-k1-n1'

ThemDiem 216, 2, 10, 'HS1', 'AN1', 'k60-k1-n1'
ThemDiem 217, 2, 8, 'HS2', 'AN1', 'k60-k1-n1'
ThemDiem 218, 2, 9, 'HS3', 'AN1', 'k60-k1-n1'
ThemDiem 219, 2, 9, 'HS4', 'AN1', 'k60-k1-n1'
ThemDiem 220, 2, 9, 'HS5', 'AN1', 'k60-k1-n1'

ThemDiem 221, 3, 9, 'HS1', 'AN1', 'k60-k1-n1'
ThemDiem 222, 3, 9, 'HS2', 'AN1', 'k60-k1-n1'
ThemDiem 223, 3, 8, 'HS3', 'AN1', 'k60-k1-n1'
ThemDiem 224, 3, 9, 'HS4', 'AN1', 'k60-k1-n1'
ThemDiem 225, 3, 8, 'HS5', 'AN1', 'k60-k1-n1'

ThemDiem 226, 1, 9, 'HS1', 'TD1', 'k60-k1-n1'
ThemDiem 227, 1, 9, 'HS2', 'TD1', 'k60-k1-n1'
ThemDiem 228, 1, 9, 'HS3', 'TD1', 'k60-k1-n1'
ThemDiem 229, 1, 9, 'HS4', 'TD1', 'k60-k1-n1'
ThemDiem 230, 1, 9, 'HS5', 'TD1', 'k60-k1-n1'

ThemDiem 231, 2, 7, 'HS1', 'TD1', 'k60-k1-n1'
ThemDiem 232, 2, 8, 'HS2', 'TD1', 'k60-k1-n1'
ThemDiem 233, 2, 9, 'HS3', 'TD1', 'k60-k1-n1'
ThemDiem 234, 2, 10, 'HS4', 'TD1', 'k60-k1-n1'
ThemDiem 235, 2, 9, 'HS5', 'TD1', 'k60-k1-n1'

ThemDiem 236, 3, 10, 'HS1', 'TD1', 'k60-k1-n1'
ThemDiem 237, 3, 9, 'HS2', 'TD1', 'k60-k1-n1'
ThemDiem 238, 3, 10, 'HS3', 'TD1', 'k60-k1-n1'
ThemDiem 239, 3, 9, 'HS4', 'TD1', 'k60-k1-n1'
ThemDiem 240, 3, 9, 'HS5', 'TD1', 'k60-k1-n1'

-- phần nghiệp vụ, 3 bộ dữ liệu 
-- Thêm học sinh
ThemHS 'HS6', N'Nguyễn Lung Linh', N'Nữ', '2000-7-30', N'Chương Mỹ, Hà Nội', N'', 'lop3'
ThemHS 'HS7', N'Nông Hồng Trang', N'Nữ', '2001-12-2', N'Đan Mỹ, Hà Nội', N'', 'lop3'
ThemHS 'HS8', N'Nguyễn Văn Nam', N'Nam', '2000-1-23', N'Đan Phượng, Hà Nội', N'', 'lop3'
-- Thêm môn học 
ThemMH 'TO2',N'Toán lớp 7', 60
ThemMH 'HH2',N'Hóa học lớp 7', 60
ThemMH 'VH2', N'Văn học lớp 7', 60
ThemMH 'VL2', N'Vật lý lớp 7', 60
ThemMH 'TA2', N'Tiếng anh lớp 7', 60

ThemMH 'LS2', N'Lịch sử lớp 7', 60
ThemMH 'DL2', N'Địa lý lớp 7', 60
ThemMH 'CN2', N'Công nghệ lớp 7', 60
ThemMH 'GD2', N'GDCD lớp 7', 60
ThemMH 'SH2', N'Sinh học lớp 7', 60
ThemMH 'MT2', N'Mỹ thuật lớp 7', 60
ThemMH 'AN2', N'Âm nhạc lớp 7', 60
ThemMH 'TD2', N'Thể dục lớp 7', 60
-- Thêm gv dạy học (gvcn của lớp 3 đã có ở bên trên)
ThemGV '6', N'Nguyễn Hùng Anh', '1991-9-8', N'Nam', '091923534263', N'Ngõ 35, Xuân THủy, Hà Nội'
ThemGV '7', N'Hoàng Nông Linh', '1998-10-10', N'Nữ', '039192826753', N'Ngõ 02, Bưởi, Hà Nội'
ThemGV '8', N'Trần Băng Phong', '1970-10-3', N'Nam', '019092728394', N'Số 74, Trần Quốc Hoàn, Hà Nội'
ThemGV '9', N'Mai Tuân Linh', '1993-12-12', N'Nam', '038228416343', N'Ngõ 93, Trung Kính, Hà Nội'
ThemGV '10', N'Loan Xuân', '1987-11-28', N'Nam', '093523436412', N'Ngõ 1000, Kim Mã, Hà Nội'


ThemGV '19', N'Mai Văn Đạt', '1993-12-12', N'Nam', '038228416343', N'Ngõ 93, Trung Kính, Hà Nội'
ThemGV '20', N'Lý Quỳ', '1987-11-28', N'Nam', '093523436412', N'Ngõ 1000, Kim Mã, Hà Nội'
ThemGV '21', N'Ma Hùng La', '1991-9-8', N'Nam', '091923534263', N'Ngõ 35, Xuân THủy, Hà Nội'
ThemGV '22', N'Băng Nông Anh', '1998-10-10', N'Nữ', '039192826753', N'Ngõ 02, Bưởi, Hà Nội'
ThemGV '23', N'Trần Hoàng Phong', '1970-10-3', N'Nam', '019092728394', N'Số 74, Trần Quốc Hoàn, Hà Nội'
ThemGV '24', N'Kiều Văn Linh', '1993-12-12', N'Nam', '038228416343', N'Ngõ 93, Trung Kính, Hà Nội'
ThemGV '25', N'Anh Kiên', '1987-11-28', N'Nam', '093523436412', N'Ngõ 1000, Kim Mã, Hà Nội'
ThemGV '26', N'Hùng Nam', '1987-11-28', N'Nam', '093523436412', N'Ngõ 1000, Kim Mã, Hà Nội'
-- thêm lịch giảng dạy (chia môn cho giáo viên gồm magv và mã môn học)
ThemGD 'TO2', '6'
ThemGD 'HH2', '7'
ThemGD 'VH2', '8'
ThemGD 'VL2', '9'
ThemGD 'TA2', '10'


ThemGD 'LS2', '19'
ThemGD 'DL2', '20'
ThemGD 'CN2', '21'
ThemGD 'GD2', '22'
ThemGD 'SH2', '23'
ThemGD 'MT2', '24'
ThemGD 'AN2', '25'
ThemGD 'TD2', '26'
-- thêm phân công giảng dạy (chia giáo viên cho lớp gồm mã giáo viên và mã lớp học)
ThemPC '6', 'Lop3'
ThemPC '7', 'Lop3'
ThemPC '8', 'Lop3'
ThemPC '9', 'Lop3'
ThemPC '10', 'Lop3'

ThemPC '19', 'Lop3'
ThemPC '20', 'Lop3'
ThemPC '21', 'Lop3'
ThemPC '22', 'Lop3'
ThemPC '23', 'Lop3'
ThemPC '24', 'Lop3'
ThemPC '25', 'Lop3'
ThemPC '26', 'Lop3'
-- thêm thời khóa biểu (mã môn và mã lớp) 
ThemTKB 'lop3', 'TO2'
ThemTKB 'lop3', 'HH2'
ThemTKB 'lop3', 'VH2'
ThemTKB 'lop3', 'VL2'
ThemTKB 'lop3', 'TA2'

ThemTKB 'lop3', 'LS2'
ThemTKB 'lop3', 'DL2'
ThemTKB 'lop3', 'CN2'
ThemTKB 'lop3', 'GD2'
ThemTKB 'lop3', 'SH2'
ThemTKB 'lop3', 'MT2'
ThemTKB 'lop3', 'AN2'
ThemTKB 'lop3', 'TD2'
-- thêm môn vào học kì để lấy được thông tin học kì trong bảng tổng (dữ liệu K60-k1-n2 đã có ở trên)
ThemCTHK 'k60-k1-n2', 'TO2'
ThemCTHK 'k60-k1-n2', 'HH2'
ThemCTHK 'k60-k1-n2', 'VH2'
ThemCTHK 'k60-k1-n2', 'VL2'
ThemCTHK 'k60-k1-n2', 'TA2'

ThemCTHK 'k60-k1-n2', 'LS2'
ThemCTHK 'k60-k1-n2', 'DL2'
ThemCTHK 'k60-k1-n2', 'CN2'
ThemCTHK 'k60-k1-n2', 'GD2'
ThemCTHK 'k60-k1-n2', 'SH2'
ThemCTHK 'k60-k1-n2', 'MT2'
ThemCTHK 'k60-k1-n2', 'AN2'
ThemCTHK 'k60-k1-n2', 'TD2'
-- thêm điểm từng môn cho từng học sinh còn bảng điểm trung bình sẽ được sinh tự động
ThemDiem 11, 1, 8, 'HS6', 'TO2', 'k60-k1-n2'
ThemDiem 12, 2, 9, 'HS6', 'TO2', 'k60-k1-n2'
ThemDiem 13, 3, 7, 'HS6', 'TO2', 'k60-k1-n2'
ThemDiem 14, 1, 8, 'HS6', 'HH2', 'k60-k1-n2'
ThemDiem 15, 2, 10, 'HS6', 'HH2', 'k60-k1-n2'
ThemDiem 16, 3, 9, 'HS6', 'HH2', 'k60-k1-n2'
ThemDiem 17, 1, 10, 'HS6', 'VH2', 'k60-k1-n2'
ThemDiem 18, 2, 9, 'HS6', 'VH2', 'k60-k1-n2'
ThemDiem 19, 3, 7, 'HS6', 'VH2', 'k60-k1-n2'
ThemDiem 20, 1, 7, 'HS6', 'VL2', 'k60-k1-n2'
ThemDiem 21, 2, 8, 'HS6', 'VL2', 'k60-k1-n2'
ThemDiem 22, 3, 10, 'HS6', 'VL2', 'k60-k1-n2'
ThemDiem 23, 1, 5, 'HS6', 'TA2', 'k60-k1-n2'
ThemDiem 24, 2, 10, 'HS6', 'TA2', 'k60-k1-n2'
ThemDiem 25, 3, 7, 'HS6', 'TA2', 'k60-k1-n2'

ThemDiem 26, 1, 9, 'HS7', 'TO2', 'k60-k1-n2'
ThemDiem 27, 2, 9, 'HS7', 'TO2', 'k60-k1-n2'
ThemDiem 28, 3, 7, 'HS7', 'TO2', 'k60-k1-n2'
ThemDiem 29, 1, 7, 'HS7', 'HH2', 'k60-k1-n2'
ThemDiem 30, 2, 10, 'HS7', 'HH2', 'k60-k1-n2'
ThemDiem 31, 3, 5, 'HS7', 'HH2', 'k60-k1-n2'
ThemDiem 32, 1, 10, 'HS7', 'VH2', 'k60-k1-n2'
ThemDiem 33, 2, 6, 'HS7', 'VH2', 'k60-k1-n2'
ThemDiem 34, 3, 6, 'HS7', 'VH2', 'k60-k1-n2'
ThemDiem 35, 1, 7, 'HS7', 'VL2', 'k60-k1-n2'
ThemDiem 36, 2, 9, 'HS7', 'VL2', 'k60-k1-n2'
ThemDiem 37, 3, 8, 'HS7', 'VL2', 'k60-k1-n2'
ThemDiem 38, 1, 7, 'HS7', 'TA2', 'k60-k1-n2'
ThemDiem 39, 2, 9, 'HS7', 'TA2', 'k60-k1-n2'
ThemDiem 40, 3, 7, 'HS7', 'TA2', 'k60-k1-n2'

ThemDiem 41, 1, 9, 'HS8', 'TO2', 'k60-k1-n2'
ThemDiem 42, 2, 9, 'HS8', 'TO2', 'k60-k1-n2'
ThemDiem 43, 3, 9, 'HS8', 'TO2', 'k60-k1-n2'
ThemDiem 44, 1, 7, 'HS8', 'HH2', 'k60-k1-n2'
ThemDiem 45, 2, 9, 'HS8', 'HH2', 'k60-k1-n2'
ThemDiem 46, 3, 10, 'HS8', 'HH2', 'k60-k1-n2'
ThemDiem 47, 1, 5, 'HS8', 'VH2', 'k60-k1-n2'
ThemDiem 48, 2, 9, 'HS8', 'VH2', 'k60-k1-n2'
ThemDiem 49, 3, 5, 'HS8', 'VH2', 'k60-k1-n2'
ThemDiem 50, 1, 8, 'HS8', 'VL2', 'k60-k1-n2'
ThemDiem 51, 2, 8, 'HS8', 'VL2', 'k60-k1-n2'
ThemDiem 52, 3, 10, 'HS8', 'VL2', 'k60-k1-n2'
ThemDiem 53, 1, 9, 'HS8', 'TA2', 'k60-k1-n2'
ThemDiem 54, 2, 8, 'HS8', 'TA2', 'k60-k1-n2'
ThemDiem 55, 3, 10, 'HS8', 'TA2', 'k60-k1-n2'

