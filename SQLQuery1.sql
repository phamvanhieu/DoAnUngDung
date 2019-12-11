// Lay du lieu cua cac bang trong database :
CREATE PROCEDURE spGetDaTaTable
@nameTable nvarchar(50)
as 
exec('select * from dbo.['+@nameTable+']');
exec spGetDaTaTable 'XEMAY'






//Them du lieu vao bang Xemay :
create procedure spInsertXeMay(@TENXE NVARCHAR(50),@MAUXE NVARCHAR(50),@HANGXE NVARCHAR(50),@PHANKHOI NVARCHAR(10),@GIAXE NVARCHAR(50),@NGAYSX NVARCHAR(50))
as begin
	insert into XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
	values(@TENXE,@MAUXE,@HANGXE,@PHANKHOI,@GIAXE,@NGAYSX)
end


//Them du lieu vao bang MauXe :
create procedure spInsertMauXessss(@TENMAU NVARCHAR(50))
as begin
	insert into MAUXE(TENMAU)
	values(@TENMAU)
end

//Them du lieu vao bang HANGXE :
create procedure spInsertHangXess(@TENHANG CHAR(50))
as begin
	insert into HANGXE(TENHANG)
	values(@TENHANG)
end

//Them du lieu vao bang phankhoi :
create procedure spInsertPhanKhoiss(@SOPK INT)
as begin
	insert into PHANKHOI(SOPK)
	values(@SOPK)
end

//Sua du lieu bang Xemay :
create procedure spUptateXeMaysss(@MAXE INT,@TENXE NVARCHAR(50),@MAUXE NVARCHAR(50),@HANGXE NVARCHAR(50),@PHANKHOI NVARCHAR(10),@GIAXE NVARCHAR(50),@NGAYSX NVARCHAR(50))
as begin
	UPDATE XEMAY
	SET TENXE = @TENXE , MAUXE=@MAUXE , HANGXE=@HANGXE , PHANKHOI=@PHANKHOI, GIAXE=@GIAXE , NGAYSX=@NGAYSX
	WHERE MAXE=@MAXE;
end

//Sua du lieu bang HangXe :
create procedure spUptateHangXe(@MAHANG INT,@TENHANG CHAR(50))
as begin
	UPDATE HANGXE
	SET TENHANG=@TENHANG
	WHERE MAHANG=@MAHANG;
end

//Sua du lieu bang PHANKHOI :
create procedure spUptatePhanKhoi(@MAPK INT,@SOPK INT)
as begin
	UPDATE PHANKHOI
	SET SOPK=@SOPK
	WHERE MAPK=@MAPK;
end

//Sua du lieu bang MAUXE :
create procedure spUptateMauXe(@MAMAU INT,@TENMAU NVARCHAR(50))
as begin
	UPDATE MAUXE
	SET TENMAU=@TENMAU
	WHERE MAMAU=@MAMAU;
end

//Xoa du lieu bang Xemay :
create procedure spDeleteXeMay(@TENXE NVARCHAR(50))
as begin
	DELETE FROM XEMAY
	where TENXE=@TENXE;
end

//Xoa du lieu bang PHANKHOI :
create procedure spDeletePhanKhoi(@SOPK INT)
as begin
	DELETE FROM PHANKHOI
	where SOPK=@SOPK;
end

//Xoa du lieu bang MAUXE :
create procedure spDeleteMauXe(@TENMAU NVARCHAR(50))
as begin
	DELETE FROM MAUXE
	where TENMAU=@TENMAU;
end

//Xoa du lieu bang HANGXE :
create procedure spDeleteHangXe(@TENHANG CHAR(50))
as begin
	DELETE FROM HANGXE
	where TENHANG=@TENHANG;
end

//Tim kiem theo ten xe bang Xemay :
create procedure spSearchTenXesss(@TENXE NVARCHAR(50))
as begin
	select * from XEMAY where TENXE like '%' + @TENXE + '%' ;
end

