Create Database QLXeMay;

Use QLXeMay

//Tao Bang XEMAY:
CREATE TABLE XEMAY(
MAXE INT IDENTITY(1,1),
TENXE NVARCHAR(50) NOT NULL,
MAUXE NVARCHAR(50) NOT NULL,
HANGXE NVARCHAR(50),
PHANKHOI NVARCHAR(10),
GIAXE NVARCHAR(50),
NGAYSX NVARCHAR(50),
PRIMARY KEY(MAXE)
);

//TAO BANG PHANKHOI:
CREATE TABLE PHANKHOI(
MAPK INT IDENTITY(1,1),
SOPK INT,
PRIMARY KEY(MAPK)
);
//TAO BANG ADMIN:
CREATE TABLE ADMINS(
ID INT IDENTITY(1,1) ,
USERNAME VARCHAR(50) NOT NULL,
PASSWORDS VARCHAR(100) NOT NULL,
PRIMARY KEY(ID)
);
CREATE TABLE USERS(
ID INT IDENTITY(1,1) ,
USERNAME VARCHAR(50) NOT NULL,
PASSWORDS VARCHAR(100) NOT NULL,
PRIMARY KEY(ID)
);
drop table ADMINS
//TAO BANG MAUXE:
CREATE TABLE MAUXE(
MAMAU INT IDENTITY(1,1),
TENMAU NVARCHAR(50) NOT NULL,
PRIMARY KEY(MAMAU)
);
//TAO BANG HANGXE:
CREATE TABLE HANGXE(
MAHANG INT IDENTITY(1,1),
TENHANG CHAR(50) NOT NULL,
 PRIMARY KEY(MAHANG)
);

//Them du lieu bang Xemay:
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');
INSERT INTO XEMAY(TENXE,MAUXE,HANGXE,PHANKHOI,GIAXE,NGAYSX)
VALUES ('SH','DO','SUZUKI','150','30000000','02/10/2000');

//THEM DU LIEU VAO BANG MAUXE:
INSERT INTO MAUXE(MAMAU,TENMAU)
VALUES ('D1','DO');
INSERT INTO MAUXE(MAMAU,TENMAU)
VALUES ('D2','DEN');
INSERT INTO MAUXE(MAMAU,TENMAU)
VALUES ('T1','TRANG');
INSERT INTO MAUXE(MAMAU,TENMAU)
VALUES ('T2','TIM');
INSERT INTO MAUXE(MAMAU,TENMAU)
VALUES ('N1','NAU');

//THEM DU LIEU VAO BANG HANGXE:
INSERT INTO HANGXE(MAHANG,TENHANG)
VALUES ('SZK','SUZUKI');
INSERT INTO HANGXE(MAHANG,TENHANG)
VALUES ('HD','HONDA');
INSERT INTO HANGXE(MAHANG,TENHANG)
VALUES ('YMH','YAMAHA');


//THEM DU LIEU VAO BANG PHANKHOI:
INSERT INTO PHANKHOI(MAPK,SOPK)
VALUES ('PK1','50');
INSERT INTO PHANKHOI(MAPK,SOPK)
VALUES ('PK2','100');
INSERT INTO PHANKHOI(MAPK,SOPK)
VALUES ('PK3','125');
INSERT INTO PHANKHOI(MAPK,SOPK)
VALUES ('PK5','175');

//THEM DU LIEU VAO BANG ADMIN:
INSERT INTO ADMINS(USERNAME,PASSWORDS)
VALUES('ADMIN','123456');



//Sua du lieu bang PHANKHOI:
UPDATE PHANKHOI
SET MAPK = 'PK5'
WHERE SOPK = '50';

//Xoa du lieu bang PHANKHOI:
DELETE FROM PHANKHOI
where MAPK='PK4';

//Sua du lieu bang HANGXE:
UPDATE HANGXE
SET MAHANG = 'sadsd'
WHERE TENHANG = 'SUZUKI'AND MAHANG='sdsd';

//Xoa du lieu bang HANGXE:
DELETE FROM HANGXE
where TENHANG='HONDA';

//Sua du lieu bang MAUXE:
UPDATE MAUXE
SET MAMAU = 'D3'
WHERE TENMAU = 'DO';

//Xoa du lieu bang MAUXE:
DELETE FROM MAUXE
where TENMAU='NAU';

SELECT * FROM MAUXE;

//Sua du lieu bang XEMAY:
UPDATE XEMAY
SET MAXE = '01'
WHERE TENXE = 'EXCITER';

//Xoa du lieu bang XEMAY:
DELETE FROM XEMAY
where TENXE='EXCITER';

SELECT * FROM ADMINS;
select MAPK,SOPK from PHANKHOI;
select MAMAU,TENMAU from MAUXE;
select MAHANG,TENHANG from HANGXE;

delete  from ADMINS where USERNAME='USER'
select * from ADMINS where USERNAME='hieu'AND PASSWORDS='123456';






select * from XEMAY where TENXE like 'SH' ;
// Dang ki tai khoan bang uSERS :
create procedure spInsertUser(@USERNAME VARCHAR(50),@PASSWORDS VARCHAR(100))
as begin
	insert into USERS(USERNAME,PASSWORDS)
	values(@USERNAME,@PASSWORDS)
end

// Kiem tra tai khoan :
create procedure spCheckUserByName(@USERNAME VARCHAR(50))
AS BEGIN
	SELECT COUNT(*) FROM USERS WHERE USERNAME=@USERNAME
END