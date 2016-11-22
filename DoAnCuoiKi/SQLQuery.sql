create database DoAnCuoiKi
use DoAnCuoiKi;
create table Congnhan(id char(10) primary key,hoten char(20) not null,ngaysinh date not null,diachi char(20),cmnd char(12) not null,sdt int,luongngay int not null,luongtangca int not null,phongban char(10) not null)
create table Chamcong(id char(10) ,today date,comat bit not null,sogiotangca int, primary key(id,today));
create table phongban(maphong char(10) primary key,tenphong char(20) not null,matotruong char(10) not null,diadiem char(20))
create table tinhluong(id char(10) ,thang int,nam int,tonggiotangca int,songaylam int,chuyencan int,
						thuong int,phat int,tienung int,tongluong int,
						primary key(id,thang,nam));
create table chucvu(id char(10) primary key,tenchucvu char(20),mota char(30) );
create table damnhiem(macn char(10),macv char(10), primary key(macn,macv));
alter table damnhiem add foreign key (macn) references congnhan(id);
alter table damnhiem add foreign key (macv) references chucvu(id);
--alter table congnhan add foreign key (phongban) references phongban(maphong);
alter table chamcong add foreign key(id) references congnhan(id);
alter table phongban add foreign key (matotruong) references congnhan(id);
alter table tinhluong add foreign key(id) references congnhan(id);

--
insert into Congnhan values('3','hung','02-06-1996','phu tuc','272518617',01654564346,500000,100000,'02');
insert into Congnhan values('1','long','02-07-1996','phu tuc','272518617',01654564346,500000,100000,'01');
insert into Congnhan values('2','long','02-07-1996','phu tuc','272518617',01654564346,500000,100000,'01');
insert into tinhluong values('1',3,2016,30,28,200000,500000,0,200000,5000000);
insert into tinhluong values('2',3,2016,35,29,200000,500000,0,1000000,5500000);
insert into Chamcong values('1','10-10-2016',1,30);
insert into Chamcong values('1','12-10-2016',1,30);
insert into Chamcong values('1','10-12-2016',1,30);
insert into Chamcong values('2','10-10-2016',0,0);
insert into Chamcong values('3','10-10-2016',1,35);
insert into phongban values('01','VP 01','2','Khu A');
insert into phongban values('02','VP 02','2','Khu B');
insert into chucvu values('1','Ke toan','tinh toan thu chi cong ty');
--tạo trigger 
create trigger Trg_Over0_CN on Congnhan
for insert,update as
declare @ins1 int = (select luongngay from inserted)
declare @ins2 int = (select luongtangca from inserted)
begin
	if(@ins1 < 0 or @ins2 < 0)
	begin
		raiserror('Cac so nhap vao phai lon hon 0',16,1);
		rollback tran;
		return;
	end
end

create trigger Trg_Over0_TL on tinhluong
for update as
declare @ins1 int = (select thuong from inserted)
declare @ins2 int = (select phat from inserted)
declare @ins3 int = (select tienung from inserted)
begin
	if(@ins1 < 0 or @ins2 < 0 or @ins3 < 0)
	begin
		raiserror('Cac so nhap vao phai lon hon 0',16,1);
		rollback tran;
		return;
	end
end

create trigger Trg_Ungtien_TL on tinhluong
for insert,update as 
declare @ins int = (select tienung from inserted);
declare @luongngay int = (select luongngay from Congnhan,inserted where inserted.id = Congnhan.id);
declare @thanghientai int = (select datepart(MM,GETDATE()));
declare @namhientai int = (select datepart(yy,GETDATE()));
declare @songay int =(select count(comat) from Chamcong where comat = 1 and @thanghientai = (select datepart(MM,Chamcong.today)) and @namhientai =(select datepart(YY,Chamcong.today)));
declare @sotienduocung int = (@luongngay*@songay)/2;
begin
	if(@ins > @sotienduocung)
	begin
		raiserror('So tien ung phai nho hon 50% luong thang hien tai',16,1);
		rollback tran;
		return;
	end
end
create trigger Trg_Chuyencan_TL on tinhluong
for update as
declare @tongngaylam int = (select songaylam from inserted)
declare @chuyen int = (select chuyencan from inserted);
begin
	set @tongngaylam = (select count(comat) from Chamcong,inserted where inserted.id = Chamcong.id and comat = 1);
	if(@tongngaylam < 28 and @chuyen != 0)
	begin
		print('Nhan vien chua chuyen can khong the nhap');
		rollback tran;
		return;
	end
end

create trigger Trg_Vangmat_CC on Chamcong
for insert,update as
declare @vangmat binary = (select comat from inserted);
declare @tangca int = (select sogiotangca from inserted);
begin
	if(@vangmat = 0 and @tangca != 0)
	begin
		print('Nhan vien vang mat khong the nhap gio tang ca');
		rollback tran;
		return;
	end
end
-- TẠO INDEX
create index SG_Index on Congnhan(id);
create index Multi_Index on Congnhan(id,hoten);
create index SG2_Index on Congnhan(hoten);
create index Multiple_Index on tinhluong(id,thang,nam);
create index Multiple2_Index on tinhluong(id);
create index Multiple3_Index on tinhluong(tongluong);
--Tạo FUNCTION trả về bảng
create function TimKiemCongNhan(@phongban char(10))
returns table
as
return select * from Congnhan where Congnhan.phongban=@phongban
--Sử dụng hàm
select * from TimKiemCongNhan('01')

--2.Tìm công nhân và mức lương công nhân đó

create function TimMucLuong(@id char(10))
returns table
as
return select Congnhan.id,hoten,tongluong from tinhluong,Congnhan where tinhluong.id = @id and Congnhan.id=tinhluong.id
--chạy thử
select * from TimMucLuong('1')

--3.danh sach cong nhan co mat trong ngay hom nay hoặc tìm cong nhan khong co mat
-- tìm bằng từ khóa :1 là có mặt,0: là ko có mặt
create function TimCacCongNhanCoMatTrongNgay(@comat bit)
returns table
as
return select Congnhan.id,hoten from Chamcong,Congnhan where Chamcong.comat = @comat and Congnhan.id=Chamcong.id
--chạy thử
select * from TimCacCongNhanCoMatTrongNgay(1)
--4.tìm các công nhân theo mã tổ trưởng
create function TimCacCongNhanTheoMaToTruong(@totruong char(10))
returns table
as
return select Congnhan.id,hoten,matotruong from phongban,Congnhan where 
phongban.matotruong = @totruong and Congnhan.phongban=phongban.maphong
--chạy thử
select * from TimCacCongNhanTheoMaToTruong('2')
--5.Tìm chức vụ của công nhân
create function TimChucVuCongNhan(@id char(10))
returns table
as
return select Congnhan.id,hoten,tenchucvu from chucvu,Congnhan where 
Congnhan.id = @id and Congnhan.id=chucvu.id
--chạy thử
select * from TimChucVuCongNhan('1')

--CÁC FUNCTION NHIỀU LỆNH TRONG THÂN--
--6.Số ngày làm trong tháng của công nhân
create function SoNgayLamCN(@thang int,@nam int)
returns @tblSoNgay table
(
	id char(10),
	hoten char(20),
	thang int,
	songaylam int
)
as
begin
	with Q(id1,tongngaylam) as (select id,count(today) from Chamcong
	 where (select DATEPART(mm,today)) = @thang and (select DATEPART(yy,today)) = @nam and Chamcong.comat=1 group by Chamcong.id)
	 insert into @tblSoNgay select id1,hoten,@thang,tongngaylam from Q,Congnhan
	 Where Q.id1=Congnhan.id
return
end
---Chạy thử
select * from SoNgayLamCN(10,2016)
--TẠO PROCEDURE

create procedure InsChamCong
@macn char(10),
@comat binary,
@giotangca int
as
begin
	declare @ngay date = (select GETDATE());
	insert into Chamcong values (@macn,@ngay,@comat,@giotangca)
end

create procedure UptLuong
@macn char(10)
as
begin 
	if (select DATEPART(dd,GETDATE())) = 1
	begin		
		declare @thang int = (select DATEPART(mm,GETDATE()));
		declare @nam int = (select DATEPART(yy,GETDATE()));
		declare @thuong int = (select thuong from tinhluong where @macn = tinhluong.id and thang = @thang - 1 and @nam = nam);
		declare @phat int = (select phat from tinhluong where @macn = tinhluong.id and thang = @thang - 1 and @nam = nam);
		declare @ungtien int = (select tienung from tinhluong where @macn = tinhluong.id and thang = @thang - 1 and @nam = nam);
		declare @tonggtc int = (select sum(sogiotangca) from Chamcong where 
				Chamcong.id = @macn 
				and @thang - 1 = (select DATEPART(mm,Chamcong.today)) 
				and @nam =(select DATEPART(yy,Chamcong.today))
				and comat = 1);
		declare @tongngay int = (select count(today) from Chamcong where 
				Chamcong.id = @macn 
				and @thang - 1 = (select DATEPART(mm,Chamcong.today)) 
				and @nam =(select DATEPART(yy,Chamcong.today))
				and comat = 1
				);
		declare @luongngay int = (select luongngay from Congnhan where id = @macn);
		declare @luongtca int = (select luongtangca from Congnhan where id = @macn);
		declare @chuyencan int;
		if DATEPART(dd,(select CONVERT(date,DATEADD(dd,-1,GETDATE())))) = @tongngay
			set @chuyencan = 200000;
		else
			set @chuyencan = 0;
		declare @tongluong int = @thuong - @phat -@ungtien + @chuyencan + @tongngay * @luongngay + @tonggtc * @luongtca;
		update tinhluong set tonggiotangca = @tonggtc,songaylam = @tongngay, chuyencan = @chuyencan, tongluong = @tongluong;
		insert into tinhluong values(@macn,@thang,@nam,0,0,0,0,0,0,0);
	end                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
end

create procedure InsCN
@macn char(10),
@hoten char(20),
@ngaysinh date,
@diachi char(20),
@cmnd char(12),
@sdt int,
@lngay int,
@ltangca int,
@phongban char(10)
as
begin 
insert into Congnhan values(@macn,@hoten,@ngaysinh,@diachi,@cmnd,@sdt,@lngay,@ltangca,@phongban);
end
