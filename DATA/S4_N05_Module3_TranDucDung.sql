--1. 3 select: 1 bảng, 2 bảng, 3 bảng, 4 bảng (có sử dụng điều kiện lọc, hàm tính toán).
--2. 3 View 
--3. 3 thủ tục
--4. 3 trigger
--5. Mẫu biểu.

use Ttcsdl_db

go

-- 1. select

-- đếm số các điểm bằng 10 là hệ số 3 
select count(MaDiem) from Diem where HeSo = 3 and Diem = 10 

-- đưa ra thông tin lớp có tên bắt đầu bằng a
select * from Lop where like 'a%'

-- đưa ra điểmtb cửa học sinh giỏi 
select * from DiemTb where XepLoai = N'Giỏi'


-- đưa ra thông tin học sinh và tên lớp học
select MaHS, TenHS, MaLop, TenLop 
from HocSinh HS, Lop 
where Hs.Malop = Lop.Malop 

-- đưa ra thông tin giáo viên chủ nhiệm lớp A1
select * 
from GiaoVien
where MaGV = (select MaGVCN from Lop where TenLop = N'A1')

-- đưa ra các điểm hệ số 3 của môn Toán 
select * 
from Diem, (select MaMH from MonHoc where TenMh = N'Toán') MToan
where HeSo = 3 and Diem.MaMH = MToan.MaMH


-- đưa ra học sinh có điểm trung bình môn Toán lớn nhất
select * from HocSinh
where MaHS in (	select MaHS 
				from BangDiem
				where DiemTb = (select max(DiemTb) 
								from BangDiem 
								where MaMh = (select Mamh from MonHoc where TenMH = N'Toán')
								)
				)
				
-- đưa ra top 3 học sinh có điểm hệ số 3 cao nhất của môn Toán
select top(3) *
from HocSinh, Diem, (select MaMh from MonHoc where TenMH = N'Toán' ) A
where HocSinh.MaHS = Diem.MaHS and Diem.MaMH = A.MaMH
order by Diem.Diem desc

-- đưa ra giáo viên dạy chính lớp họ chủ nhiệm
select * 
from GiaoVien GV, GiangDay GD, Lop
where GV.MaGV = GD.MaGV and GD.MaLop = Lop.MaLop and Lop.MaGVCN = GV.MaGV


-- đưa ra học sinh có điểm miệng môn Toán thấp nhất các khóa 
select TenHS, DThap , MaHK, TenHK
from HocSinh HS, Diem, (	select Min(Diem) DThap, MaHK, TenHK
							from Diem, HocKy
							where Diem.MaHK = HocKy.MaHK and Diem.MaMh = (select Mamh from MonHoc where TenMH = N'Toán')
							group by MaHK, TenHK
						) 	as A
where Hs.MaHS=Diem.MaHS 
and Diem.MaMh = (select Mamh from MonHoc where TenMH = N'Toán') 
and Diem.MaHK = A.MaHK

-- đưa ra học sinh có điểm tb môn toán cao nhất lớp 
select TenHs, TenLop, DiemTb
from HocSinh HS, Lop, (	select MaHS, DiemTb
						from BangDiem 
						where BangDiem.MaMH = (select MaMH from MonHoc where TenMH =N'Toán')
						and BangDiem.DiemTb = (	select max(DiemTb)
												from BangDiem, (select MaMh from MonHoc where TenMH = N'Toán' ) MH
												where BangDiem.MaMH = MH.MaMH
												)
						) BD
where HS.Malop = Lop.MaLop
and BD.MaHS = HS.MaHS

-- xem điểm môn Toán của học sinh học Nguyễn của lớp A
select TenHS, Diem, HeSo, TenLop
from HocSinh HS, Diem, MonHoc MH, Lop
where Diem.MaMH = (select MaMh from MonHoc where TenMH = N'Toán')
and Diem.MaHS = HS.MaHS
and Lop.TenLop = N'A'
and HS.MaLop = Lop.MaLop


-- 2. VIEW

-- điểm trung bình cao nhất của các môn
create view V_DiemCao as
select max(DiemTb), MaMH, TenMH 
from BangDiem, MonHoc
where BangDiem.MaMH = MonHoc.MaMH
group by MonHoc.MaMH, TenMH

-- danh sách điểm học sinh lớp A
create view V_DiemLopA as
select TenHS, DiemTb, MaMH
from HocSinh HS, Lop, BangDiem
where HS.MaHS = BangDiem.MaHS
and Lop.TenLop = N'A'
and Lop.MaLop = HS.MaLop


-- Danh sách sĩ số của từng lớp
create view V_SiSoLop as
select count(MaHS) SiSo, Malop, TenLop
from Lop, HocSinh
where Lop.Malop = HocSinh.Malop
group by Lop.Malop, TenLop


-- 3. proc

-- xem điểm tb môn nào đó của lớp nào đó  
create proc TbMon @mamh varchar(10), @malop varchar(10)
as
begin
	select TenHs, DiemTb
	from HocSinh HS,(	select MaHS, DiemTb
						from BangDiem 
						where BangDiem.MaMH = @mamh
					) BD
	where HS.Malop = @malop
	and BD.MaHS = HS.MaHS	
end

-- xem danh sách giáo viên dạy lớp nào đó
create proc DanhSachGV @malop varchar(10)
as
begin
	select MaGV, TenGV
	from GiaoVien, GiangDay
	where GiaoVien.MaGV = GiangDay.MaGV
	and GiangDay.MaLop = @malop
end

-- xem danh sách giảng dạy của 1 lớp
create proc XemTKB @malop varchar(10)
as
begin
	select	MaGV, TenGV, MaMH, TenMh
	from GiaoVien GV, (select * from GiangDay where MaLop = @malop) GD, 
		 PhanCong PC, (select * from TKB where MaLop = @malop) A, MonHoc MH
	where GV.MaGV = GD.MaGV
	and A.MaMH = PC.MaMH
	and PC.MaGV = GD.MaGV
	and MH.MaMH = A.MaMh
end

-- 4. TRIGGER

-- thông báo và kiểm tra điểm vừa mới nhập vào
create trigger ThongBaoNhapDiem
on Diem 
for insert
as
begin
	declare @heso int, @diem float, @mahs varchar(10), @mamh varchar(10), @mahk varchar(10), @tenhs nvarchar(50), @tenmh nvarchar(50)
	select @heso = HeSo, @diem = Diem, @mahs = MaHS, @mamh = MaMH, @mahk = MaHK from inserted
	select @tenhs = (select TenHocSinh from HocSinh where MaHS = @mahs)
	select @tenmh = (select TenMH from MonHoc where TenMH = @mamh)
	if(@diem < 0 or @diem >10)
	begin
		print N'Nhập sai điểm'
		rollback 
	end
	if(@heso != 1 and @heso != 2 and @heso != 3)
	begin
		print N'Nhập sai hệ số'
		rollback
	end
	print N'Học sinh vừa được nhập điểm là ' +@tenhs+ ' hệ số ' +convert(varchar(10), @heso)+ ' số điểm là ' +convert(varchar(10), @diem)
			+' môn học ' +@tenmh+ ' học kì ' +@mahk
end

-- xử lý xóa điểm của 1 học sinh update lại bảng điểm
create trigger XoaDiem
on Diem
for delete
as
begin
	declare @diem float, @heso int, @mahs varchar(10), @mamh varchar(10), @temp float
	select @diem = Diem, @heso = HeSo, @mahs = MaHS, @mamh = MaMH from deleted
	-- kiểm tra xem hết điểm của môn này chưa nếu hết rồi thì xóa điểm tb bên bảng điểm
	if (@mamh not in (select MaMH from Diem where MaHS = @mahs))
	begin
		delete from BangDiem where MaHS = @mahs and MaMH = @mamh
	end
	else
	-- update lại nếu vẫn còn điểm
	begin
	select @temp = (select sum(HeSO) from Diem where MaHS=@mahs and MaMH=@mamh)
	update BangDiem
	set DiemTb = ((DiemTb*(@temp+@heso))-(@diem*@heso))/@temp
	where MaHS=@mahs and MaMH=@mamh
	declare @temp0 nvarchar(10)
	select @temp0 = case when @diem < 4 then N'Yếu'
						when @diem >= 4 and @diem <=5 then N'Trung Bình'
						when @diem >= 6 and @diem <=7.9 then N'Khá'
						else N'Giỏi' end 
	update BangDiem
	set xeploai = @temp0
	where MaHS=@mahs and MaMH=@mamh
	end
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
-- update
create trigger UpdateBangDiem on Diem for update
as
begin
	--lấy dữ liệu nhập vào
	declare @heso int, @diem float, @mahs varchar(10), @mamh varchar(10)
	select @heso = heso from inserted
	select @diem = diem from inserted
	select @mahs = mahs from inserted
	select @mamh = mamh from inserted
	declare @heso1 int, @diem1 float, @mahs1 varchar(10), @mamh1 varchar(10)
	select @heso1 = heso from deleted
	select @diem1 = diem from deleted
	select @mahs1 = mahs from deleted
	select @mamh1 = mamh from deleted
	-- update lại
	declare @temp int 
	select @temp = (select sum(heso) from Diem where MaHS=@mahs and MaMH=@mamh)
	update BangDiem
	set DiemTb = ((DiemTb*(@temp-@heso+@heso1))-(@heso1*@diem1)+(@heso*@diem))/(@temp)
	where MaHS=@mahs and MaMH=@mamh
	declare @temp0 nvarchar(10)
	select @temp0 = case when @diem < 4 then N'Yếu'
	when @diem >= 4 and @diem <=5 then N'Trung Bình'
	when @diem >= 6 and @diem <=7.9 then N'Khá'
	else N'Giỏi' end 
	update BangDiem
	set xeploai = @temp0
	where MaHS=@mahs and MaMH=@mamh
end
-- 5. Mẫu Biểu
-- đưa ra biểu mẫu điểm trung bình các môn của học sinh trong 1 lớp

create proc BieuMau (@malop varchar(10), @makh varchar(30), @result nvarchar(max) output)
as
begin
	--đặt biến
	declare @columns nvarchar(max)
	--truy tên môn của lớp cần tìm
	set @columns = N'';
	select @columns += N', ' + quotename(MaMH)
	from (select MaMH from MonHoc where MaMH in (select MaMH from TKB where MaLop = @malop and MaMH in (select MaMH from ChiTietHocKy where MaHK = @makh))) AS x;

	--nối các câu lệnh với nhau 
	select @result = N'
	SELECT ROW_NUMBER() OVER(ORDER BY TenHocSinh ASC) as STT ,TenHocSinh,' + STUFF(@columns, 1, 2, '') + ', DiemTrungBinh, XepLoaiChung
	FROM
	(
		Select MaMH as Mon,ROUND(DiemTb, 1) as DiemTb,TenHocSinh,DiemTrungBinh,XepLoaiChung
		From HocSinh,V_DTBMon
		left join BangDiem
		on V_DTBMon.MaHS = BangDiem.MaHS
		WHERE HocSinh.MaHS = V_DTBMon.MaHS
		AND HocSinh.MaLop = '''+@malop+'''
	) AS j
	PIVOT
	(
	 SUM(DiemTB) FOR [Mon] IN ('
	 + STUFF(REPLACE(@columns, ', [', ',['), 1, 1, '')
	 + ')
	) AS p'
end

declare @s nvarchar(max)
exec BieuMau @malop = 'Lop1', @makh = 'k60-k1-n1', @result = @s output
print(@s)


-- tính % xếp loại 
-- tính sĩ số của lớp học

create view V_DTBMon as
select ROUND(avg(DiemTb), 1) DiemTrungBinh, HocSinh.MaHS, MaLop, 
case when avg(DiemTb) is null then N'NULL' 
	when avg(DiemTb) < 4 then N'Yếu'
	when avg(DiemTb) >= 4 and avg(DiemTb) <=5 then N'Trung Bình'
	when avg(DiemTb) >= 6 and avg(DiemTb) <=7.9 then N'Khá'
	else N'Giỏi' end as XepLoaiChung
from HocSinh
left join BangDiem
on BangDiem.MaHS = HocSinh.MaHS 
group by HocSinh.MaHS, MaLop

select * from V_DTBMon

create proc XepLoai (@malop varchar(10), @result nvarchar(100) output)
as
begin
	declare @siso float, @gioi float, @kha float, @trungbinh float, @yeu float
	select @siso = (select count(MaHS) from HocSinh where MaLop = @malop and MaHS in (select MaHS from Diem))
	set @gioi = (select count(MaHS) from V_DTBMon where XepLoaiChung = N'Giỏi' and V_DTBMon.MaLop = @malop)/@siso
	set @kha = (select count(MaHS) from V_DTBMon where XepLoaiChung = N'Khá' and V_DTBMon.MaLop = @malop)/@siso
	set @trungbinh = (select count(MaHS) from V_DTBMon where XepLoaiChung = N'Trung Bình' and V_DTBMon.MaLop = @malop)/@siso
	set @yeu = (select count(MaHS) from V_DTBMon where XepLoaiChung = N'Yếu' and V_DTBMon.MaLop = @malop)/@siso
	select @result = N'Giỏi : '+convert(varchar(10), ROUND(@gioi*100, 1)) +'%,  '+
					 N'Khá : ' + convert(varchar(10), ROUND(@kha*100, 1))+'%,  ' + 
					 N'Trung Bình : '+convert(varchar(10), ROUND(@trungbinh*100, 1))+'%,  ' + 
					 N'Yếu : '+convert(varchar(10), ROUND(@yeu*100, 1))+'%'
end

declare @s nvarchar(100)
exec XepLoai @malop = 'Lop1', @result = @s output
print @s
















