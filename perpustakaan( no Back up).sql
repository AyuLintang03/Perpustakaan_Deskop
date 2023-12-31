create database Perpustakaan
use Perpustakaan

create table petugas (
    id_petugas char(5) primary key,
    nama_petugas varchar(25) not null,
    jabatan varchar(25) not null,
    no_telp varchar(15) not null,
	jk_petugas char(1) not null,
    alamat varchar(50) not null);

create table mahasiswa (
    id_mhs char(5) primary key,
    nama varchar(20) not null,
    jurusan varchar(25)not null,
    no_telp varchar(50) not null,
	jk_mhs char(1) not null,
    alamat varchar(50)not null);

create table buku (
    id_buku char(5) primary key,
    judul_buku varchar(50) not null,
    penulis varchar(50) not null,
    penerbit varchar(50) not null,
    tahun varchar(10) not null,
    stok int not null);

create table peminjaman (
    id_peminjaman char(5) primary key,
    tanggal_pinjam date not null,
	tanggal_dikembalikan date not null,
    id_mhs char(5) not null FOREIGN KEY REFERENCES mahasiswa(id_mhs),
    id_petugas char(5) not null FOREIGN KEY REFERENCES petugas(id_petugas),
	id_buku char(5) not null FOREIGN KEY REFERENCES buku(id_buku)
	);

	create table detail_peminjaman(
	 id_peminjaman char(5) not null FOREIGN KEY REFERENCES peminjaman(id_peminjaman),
	 id_buku char(5) not null FOREIGN KEY REFERENCES buku(id_buku),
	 jumlah_buku_dipinjam int not null);

create table pengembalian (
	id_pengembalian char(5) primary key,
	 id_peminjaman  char(5) not null FOREIGN KEY REFERENCES peminjaman(id_peminjaman),
	tanggal_pinjam date not null,
	tanggal_pengembalian date not null,
    id_mhs char(5) not null FOREIGN KEY REFERENCES mahasiswa(id_mhs),
	id_buku char(5) not null FOREIGN KEY REFERENCES buku(id_buku));

	create table detail_pengembalian(
	id_pengembalian char(5) not null FOREIGN KEY REFERENCES pengembalian(id_pengembalian),
	id_buku char(5) not null FOREIGN KEY REFERENCES buku(id_buku),
	jumlah_buku_dikembalikan int not null,
	denda int not null);
	
INSERT INTO petugas VALUES
('01111','Andi','Kepala Perpustakaan','089765437098','L','Wayhalim'),
('01112','Dian','Kepala Tata Usaha','08237689-187','P','Waykandis'),
('01113','Yoga','Komite Perpustakaan','085421378503','L','Pahoman'),
('01114','AYU','Staff Adiministrasi','089745321891','P','Kedaton'),
('01115','Tiara','Staff Umum','089654321896','P','Kampung Baru'),
('01116','Gama','Staff Pelayanan','087641257906','L','Sukadadi'),
('01117','Gita','Staff Koleksi','085648761234','P','Karang Anyar'),
('01118','Gilang','Staff Perlengkapan','087512986543','L','Sukarame'),
('01119','Suti','Staff Kebersihan','0861592738063','P','Labuhan Ratu'),
('01110','Parji','Staff Kebersihan','087432907359','L','Palapa');


INSERT INTO mahasiswa VALUES
('M0001','Alfiana','Informatika','089765432198','P','Tulang Bawang'),
('M0002','Zaky','Informatika','089754216509','L','Metro'),
('M0003','Ayu','Informatika','0876543217656','P','Kota Bumi'),
('M0004','Vina','Sastra Inggris','081298364506','P','Lampung Barat'),
('M0005','Dinda','Pendidikan Matematika','082467890321','P','Lampung Tengah'),
('M0006','Ami','Teknik Komputer','0867302184965','P','Lampung Timur');

INSERT INTO buku VALUES
('B0001','Pemrograman Database dan Dhelpy7','Abdul Kadir','Penerbit Andi','2004','10'),
('B0002','Animasi Pendidikan Menggunakan Flash','Priyanto Hidayatullah','Informatika','2011','8'),
('B0003','The C++ Programming Language third edition','Bjarne Stroustrup','AT&T Labs','1997','11'),
('B0004','Sistem Operasi Microsoft Windows XP Professional','Ian Chandra K','Elex Media Komputindo','2016','5'),
('B0005','Algoritma & Teknik Pemrograman','Budi Sutejo','Michael An','2000','4');

INSERT INTO peminjaman VALUES
('P0001','2021/03/01','2021/03/07','M0001','01112','B0001'),
('P0002','2021/03/11','2021/03/17','M0003','01114','B0003'),
('P0003','2021/03/05','2021/03/15','M0004','01111','B0005');

INSERT INTO detail_peminjaman VALUES
('P0003','B0005',1),
('P0002','B0001',1),
('P0002','B0003',1);

INSERT INTO pengembalian VALUES
('K0001','P0002','2021/03/01','2021/03/07','M0002','B0001'),
('K0002','P0003','2021/03/11','2021/03/17','M0003','B0003'),
('K0003','P0001','2021/03/05','2021/03/15','M0004','B0005');


INSERT INTO detail_pengembalian VALUES
('K0001','2021/03/01','2021/03/07','B0001',1,0),
('K0002','2021/03/11','2021/03/17','B0003',1,0),
('K0003','2021/03/05','2021/03/15','B0005',1,3000);

CREATE VIEW View_peminjaman AS
SELECT peminjaman.id_peminjaman, peminjaman.tanggal_pinjam,peminjaman.tanggal_dikembalikan, mahasiswa.id_mhs,mahasiswa.nama,
mahasiswa.jurusan,petugas.id_petugas,petugas.nama_petugas,detail_peminjaman.id_buku,buku.judul_buku,buku.penerbit,buku.stok,
detail_peminjaman.jumlah_buku_dipinjam
FROM peminjaman  join detail_peminjaman  on peminjaman.id_peminjaman=detail_peminjaman.id_peminjaman
join petugas on peminjaman.id_petugas=petugas.id_petugas
join mahasiswa on peminjaman.id_mhs = mahasiswa.id_mhs
join buku on detail_peminjaman.id_buku = buku.id_buku 

CREATE VIEW View_detailpeminjaman
AS
SELECT detail_peminjaman.id_peminjaman,buku.id_buku,buku.judul_buku,buku.stok,
detail_peminjaman.jumlah_buku_dipinjam FROM buku JOIN detail_peminjaman ON buku.id_buku=detail_peminjaman.id_buku;

CREATE VIEW View_pengembalian AS
SELECT pengembalian.id_pengembalian,pengembalian.id_peminjaman, pengembalian.tanggal_pinjam,pengembalian.tanggal_pengembalian, mahasiswa.id_mhs,mahasiswa.nama,
mahasiswa.jurusan,detail_pengembalian.id_buku,buku.judul_buku,buku.penerbit,buku.stok,
detail_pengembalian.jumlah_buku_dikembalikan,detail_pengembalian.denda
FROM pengembalian  join detail_pengembalian  on pengembalian.id_pengembalian=detail_pengembalian.id_pengembalian
join mahasiswa on pengembalian.id_mhs = mahasiswa.id_mhs
join buku on detail_pengembalian.id_buku = buku.id_buku 

select * from  detail_pengembalian

CREATE VIEW view_detailpengembalian
As
SELECT detail_pengembalian.id_pengembalian,buku.id_buku,
buku.judul_buku,buku.stok,detail_pengembalian.jumlah_buku_dikembalikan,detail_pengembalian.denda FROM buku INNER JOIN detail_pengembalian on buku.id_buku=detail_pengembalian.id_buku;

CREATE PROCEDURE SP_View_peminjaman AS
BEGIN
SELECT * FROM View_peminjaman;
END

EXECUTE SP_View_peminjaman

CREATE PROCEDURE SP_View_detailpeminjaman AS
BEGIN
SELECT * FROM View_detailpeminjaman;
END

EXECUTE SP_View_detailpeminjaman



CREATE PROCEDURE SP_View_pengembalian AS
BEGIN
SELECT * FROM View_pengembalian;
END

EXECUTE SP_View_pengembalian

CREATE PROCEDURE SP_View_detailpengembalian AS
BEGIN
SELECT * FROM View_pengembalian;
END

EXECUTE SP_View_detailpengembalian



CREATE PROCEDURE simpan_peminjaman
@id_peminjaman char(5),
@tanggal_pinjam date,
@tanggal_dikembalikan date,
@id_mhs char(5),
@id_petugas char(5),
@id_buku char(5)
AS
BEGIN
INSERT INTO peminjaman VALUES 
(@id_peminjaman,@tanggal_pinjam,@tanggal_dikembalikan,@id_mhs,@id_petugas,@id_buku)
END;

EXECUTE  simpan_peminjaman 'P0004','2021-06-20','2021-06-25','M0004','01112','B0004';

CREATE PROCEDURE cari_peminjaman
@id_peminjaman char(5)
AS
BEGIN
	SELECT * FROM View_peminjaman	
	WHERE id_peminjaman LIKE '%'+@id_peminjaman+'%';
END;

execute cari_peminjaman 'P0004'

CREATE PROCEDURE simpan_detailpeminjaman
	@id_peminjaman char(5),
    @id_buku char(5),
	@jumlah int
AS
BEGIN
INSERT INTO detail_peminjaman VALUES (@id_peminjaman,@id_buku,@jumlah);
END;
SELECT * FROM detail_peminjaman;

CREATE PROCEDURE simpan_pengembalian
@id_pengembalian char(5),
@id_peminjaman char(5),
@tanggal_pinjam date,
@tanggal_dikembalikan date,
@id_mhs char(5),
@id_buku char(5)
AS
BEGIN
INSERT INTO pengembalian VALUES 
(@id_pengembalian,@id_peminjaman,@tanggal_pinjam,@tanggal_dikembalikan,@id_mhs,@id_buku)
END;

CREATE PROCEDURE simpan_detailpengembalian
	@id_pengembalian char(5),
    @id_buku char(5),
	@jumlah int,
	@denda int
AS
BEGIN
INSERT INTO detail_pengembalian VALUES (@id_pengembalian,@id_buku,@jumlah,@denda);
END;

CREATE PROCEDURE hapus_detailpengembalian
	@id_pengembalian char(5),
	@id_buku char(5)
AS
BEGIN
DELETE FROM detail_pengembalian WHERE id_pengembalian=@id_pengembalian AND id_buku= @id_buku ;
END;

CREATE PROCEDURE hapus_detailpeminjaman
	@id_peminjaman char(5),
	@id_buku char(5)
AS
BEGIN
DELETE FROM detail_peminjaman WHERE id_peminjaman=@id_peminjaman AND id_buku= @id_buku ;
END;

EXECUTE hapus_detailpeminjaman 'P0004','B0001';

CREATE PROCEDURE simpan_mahasiswa

	@id_mhs char(5),
    @nama varchar(20),
    @jurusan varchar(25),
    @no_telp varchar(50),
	@jk_mhs char(1),
    @alamat varchar(50)
AS
BEGIN
	INSERT INTO mahasiswa VALUES
	(@id_mhs,@nama,@jurusan,@no_telp,@jk_mhs,@alamat);
END;

execute simpan_mahasiswa 'M0007','Alfiana','Informatika','081279276441','P','Bandar Lampung';
	SELECT * FROM mahasiswa;

CREATE PROCEDURE hapus_mahasiswa
@id_mhs char(5)
AS
BEGIN
	DELETE FROM mahasiswa WHERE id_mhs = @id_mhs;
	
END;

EXECUTE hapus_mahasiswa'M0007';
SELECT * FROM mahasiswa;
CREATE PROCEDURE ubah_mahasiswa
	@id_mhs char(5),
    @nama varchar(20),
    @jurusan varchar(25),
    @no_telp varchar(50),
	@jk_mhs char(1),
    @alamat varchar(50)
AS
BEGIN
	UPDATE mahasiswa SET nama = @nama,
	jurusan = @jurusan, no_telp=@no_telp,alamat=@alamat
	WHERE id_mhs = @id_mhs;
	
END;
SELECT * FROM mahasiswa;
EXECUTE ubah_mahasiswa 'M0007','Alfiana','Sistem Informatika','081279276441','P','Bandar Lampung';


CREATE PROCEDURE cari_mahasiswa
@nama varchar(5)
AS
BEGIN
	SELECT * FROM mahasiswa	
	WHERE nama LIKE '%'+@nama+'%';
END;

EXECUTE cari_mahasiswa 'A';

CREATE PROCEDURE simpan_petugas
@id_petugas char(5),
@nama_petugas varchar(25),
@jabatan varchar(50),
@no_tlp varchar(15),
@jk char(1),
@alamat varchar(50)
AS
BEGIN
	INSERT INTO petugas VALUES
	(@id_petugas,@nama_petugas,@jabatan,@no_tlp,@jk,@alamat)
END;

EXECUTE simpan_petugas'01120', 'Alzi', 'Staff Administrasi','081219302212','L', 'Bandar Lampung';


CREATE PROCEDURE hapus_petugas
@id_petugas char(5)
AS
BEGIN
	DELETE FROM petugas WHERE id_petugas = @id_petugas;
END;

EXECUTE hapus_petugas'01120';
	SELECT * FROM petugas;

CREATE PROCEDURE ubah_petugas
@id_petugas char(5),
@nama_petugas varchar(25),
@jabatan varchar(50),
@no_tlp varchar(15),
@alamat varchar(50)
AS
BEGIN
	UPDATE petugas SET nama_petugas = @nama_petugas,
	jabatan = @jabatan, no_telp=@no_tlp, alamat=@alamat
	WHERE id_petugas = @id_petugas;
END;

EXECUTE ubah_petugas '01119', 'anita','Staff Administrasi ','0812981109123', 'Lampung Barat';

CREATE PROCEDURE cari_petugas
@nama_petugas varchar(25)
AS
BEGIN
	SELECT * FROM petugas	
	WHERE nama_petugas LIKE '%'+@nama_petugas+'%';
END;

EXECUTE cari_petugas 'Anita';

CREATE PROCEDURE simpan_buku

    @id_buku char(5),
    @judul_buku varchar(50),
    @penulis varchar(50),
    @penerbit varchar(50),
    @tahun varchar(10),
    @stok int
AS
BEGIN
	INSERT INTO buku VALUES
	(@id_buku,@judul_buku,@penulis,@penerbit,@tahun,@stok);
END;
	SELECT * FROM buku;

EXECUTE simpan_buku'B0006','Learn PHP 7','Steve Prettyman','Apress', '2014', 15;


CREATE PROCEDURE hapus_buku
@id_buku char(5)
AS
BEGIN
	DELETE FROM buku WHERE id_buku = @id_buku;
END;
	SELECT * FROM buku;

EXECUTE hapus_buku'B0006';


CREATE PROCEDURE ubah_buku

    @id_buku char(5),
    @judul_buku varchar(50),
    @penulis varchar(50),
    @penerbit varchar(50),
    @tahun varchar(10),
    @stok int
AS
BEGIN
	UPDATE buku SET judul_buku = @judul_buku, penulis = @penulis,penerbit=@penerbit,tahun=@tahun ,stok= @stok
	WHERE id_buku = @id_buku;
	SELECT * FROM buku;
END;

EXECUTE ubah_buku 'B0002','Learn PHP 7','Steve Prettyman','Apress', '2014', 15;

CREATE PROCEDURE cari_buku
@Judul_buku varchar(25)
AS
BEGIN
	SELECT * FROM buku
	WHERE judul_buku LIKE '%'+@Judul_buku+'%';
END;

EXECUTE cari_buku'learn';

CREATE TRIGGER trigger_buku
ON detail_peminjaman
AFTER INSERT
AS
BEGIN
DECLARE  @jumlah int,@kode char(5)
select @jumlah=jumlah_buku_dipinjam,
@kode=id_buku FROM inserted
update buku SET buku.stok=buku.stok-@jumlah WHERE buku.id_buku=@kode;
END
EXECUTE simpan_detailpeminjaman 'P0004','B0003', 1;

select * from detail_peminjaman 

CREATE TRIGGER AfterDe1ete_peminjaman
ON detail_peminjaman
AFTER DELETE 
AS 
BEGIN 
DECLARE @jumlah int, @id char(5) 
SELECT @jumlah=jumlah_buku_dipinjam, 
@id =id_buku FROM deleted
UPDATE buku SET buku.stok =
buku.stok + @jumlah 
WHERE buku. id_buku = @id; 
SELECT *FROM buku;
END


execute hapus_detailpeminjaman 'P0004','B0004'; 

 
CREATE TRIGGER trigger_bukupengembalian
ON detail_pengembalian
AFTER INSERT
AS
BEGIN
DECLARE  @jumlah int,@kode char(5)
select @jumlah=jumlah_buku_dikembalikan,
@kode=id_buku FROM inserted
update buku SET buku.stok=buku.stok+@jumlah WHERE buku.id_buku=@kode;
END

EXECUTE simpan_detailpengembalian'K0004','B0004',1,0; 

CREATE TRIGGER AfterDe1ete_pengembalian
ON detail_pengembalian
AFTER DELETE 
AS 
BEGIN 
DECLARE @jumlah int, @id char(5) 
SELECT @jumlah=jumlah_buku_dikembalikan, 
@id =id_buku FROM deleted
UPDATE buku SET buku.stok =
buku.stok - @jumlah 
WHERE buku. id_buku = @id; 
SELECT *FROM buku;
END

execute hapus_detailpengembalian 'K0004','B0004'

CREATE TABLE tbl_login (
username varchar(25) PRIMARY KEY, 
password varchar( 25) NOT NULL); 

CREATE TABLE log_tbl_login (
username varchar(25 ) NOT NULL, 
user_status varchar (10)NOT NULL, 
date_status datetime DEFAULT GETDATE());


CREATE TRIGGER insert_login 
ON tbl_login 
AFTER INSERT 
AS 
BEGIN 
DECLARE @user varchar(25) 
SELECT @user = username FROM inserted 
INSERT INTO log_tbl_login (username, user_status) 
VALUES (@user,'REGISTERED ');
SELECT *FROM log_tbl_login; 
END

INSERT INTO tbl_login VALUES ('IF19C','123'); 