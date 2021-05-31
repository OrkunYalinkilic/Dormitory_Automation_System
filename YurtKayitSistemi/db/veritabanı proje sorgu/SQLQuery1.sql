--create table tblUrunler
--(
--urunID int identity(1,1) primary key,
--urunAdi varchar(50),
--urunMarka varchar(50),
--urunKategori int,
--urunAlisFiyat decimal(18,2),
--urunSatisFiyat decimal(18,2),
--urunStok int check(urunStok>0),
--urunDurum bit default '1'
--)

--create table tblPersonel
--(
--personelID int identity(1,1) primary key,
--personelAdSoyad varchar(50)
--)

--create table tblMusteri(
--musteriID int primary key identity(1,1),
--musteriAdi varchar(50),
--musteriSoyadi varchar(50),
--musteriSehir varchar(13),
--musteriBakiye decimal(18,2)
--)

--create table tblHareket
--(
--hareketID int primary key identity(1,1),
--urun int,
--musteri int,
--personel int,
--adet int,
--tutar decimal(18,2),
--tarih smalldatetime
--)

--create procedure SatisHareketleri
--as
--SELECT hareketId,urunAdi,musteriAdi + ' ' + musteriSoyadi as 'Ad-Soyad',
--personelAdSoyad,adet,tutar,tarih from tblHareket 
--INNER JOIN tblUrunler
--on tblHareket.urun = tblUrunler.UrunID 
--INNER JOIN tblMusteri 
--on tblHareket.musteri = tblMusteri.musteriID
--Inner JOIN tblPersonel
--on tblHareket.personel = tblPersonel.personelID

--create procedure UrunBilgiGetir
--@deger varchar(50) = ''
--as
--select urunAdi,urunMarka,urunStok,urunAlisFiyat,urunSatisFiyat,urunStok
--FROM tblUrunler
--WHERE urunAdi=@deger

--ALTER procedure [dbo].[SatisHareketleri]
--as
--SELECT hareketId as 'Satis ID',urunAdi as 'Ürün Adý',musteriAdi + ' ' + musteriSoyadi as 'Müþteri Ad-Soyad',
--personelAdSoyad as 'Personel',adet as 'Adet',tutar as 'Tutar',tarih as 'Tarih' from tblHareket 
--INNER JOIN tblUrunler
--on tblHareket.urun = tblUrunler.UrunID 
--INNER JOIN tblMusteri 
--on tblHareket.musteri = tblMusteri.musteriID
--Inner JOIN tblPersonel
--on tblHareket.personel = tblPersonel.personelID

--create procedure UrunEkle
--@Adi varchar(50) = '',
--@Marka varchar(50) = '',
--@Kategori int,
--@AlisFiyat decimal(18, 2),
--@SatisFiyat decimal(18, 2),
--@Stok int 
--as
--insert into tblUrunler(urunAdi,urunMarka,urunKategori,urunAlisFiyat,urunSatisFiyat,urunStok) 
--values(@Adi,@Marka,@Kategori,@AlisFiyat,@SatisFiyat,@Stok)

--alter procedure UrunGuncelle
--@Adi varchar(50) = '',
--@Marka varchar(50) = '',
--@AlisFiyat decimal(18, 2),
--@SatisFiyat decimal(18, 2),
--@urunID int
--as
--update tblUrunler 
--set urunAdi=@Adi, urunMarka=@Marka,urunAlisFiyat=@AlisFiyat, urunSatisFiyat=@SatisFiyat
--where urunID=@urunID

--USE [YurtOtomasyonu]
--GO
--/****** Object:  StoredProcedure [dbo].[UrunBilgiGetir]    Script Date: 16.12.2019 22:40:52 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--ALTER procedure [dbo].[UrunBilgiGetir]
--@urunID int
--as
--select urunAdi,urunMarka,urunAlisFiyat,urunSatisFiyat
--FROM tblUrunler
--WHERE urunID = @urunID

--alter procedure MusteriEkle
--@Adi varchar(50) = '',
--@Soyadi varchar(50) = '',
--@Sehir varchar(50) = '',
--@Bakiye decimal(18, 2)
--as
--insert into tblMusteri(musteriAdi,musteriSoyadi,musteriSehir,musteriBakiye) 
--values(@Adi,@Soyadi,@Sehir,@Bakiye)

--create procedure MusteriSil
--@ID int
--as
--delete from tblMusteri where musteriID=@ID

--create procedure PersonelEkle
--@ad varchar(25),
--@soyad varchar(25)
--as
--insert into tblPersonel(personelAdSoyad) values(@ad + ' ' + @soyad)

--create procedure PersonelSil
--@ID int
--as
--delete from tblPersonel where personelID=@ID

--create view KasaToplam
--as
--select *from tblKasa

--create view MusteriGetir
--as
--select musteriAdi,musteriSoyadi from tblMusteri

--create view KategoriAdiGetir
--as
--select kategoriAdi from tblKategori

--alter procedure urunleriGetir
--@kategoriAd varchar(50)
--as
--select urunID,urunAdi,urunMarka,urunSatisFiyat from tblUrunler 
--where urunKategori = (select kategoriID from tblKategori where kategoriAdi=@kategoriAd)

--create procedure urunStokGetir
--@ID int
--as
--select urunStok from tblUrunler where urunID=@ID

--select * from KategoriAdiGetir
--select *from MusteriGetir
--execute urunleriGetir @kategoriAd='TEMÝZLÝK'
--execute urunStokGetir @ID=1

--create trigger kategoriArtis
--on tblHareket 
--after insert
--as
--update tblToplamKategori set adet+=1

--create view PersonelGetir
--as
--select personelAdSoyad from tblPersonel

--alter procedure HareketEkle
--@PersonelAdiSoyadi varchar(50) ,
--@MusteriAdiSoyadi varchar(100),
--@urunID int,
--@Adet int,
--@tutar decimal(18,2)
--as
--insert into tblHareket(urun,musteri,personel,adet,tutar)
--values(@urunID,
--(SELECT musteriID from tblMusteri where musteriAdi+musteriSoyadi=@MusteriAdiSoyadi ),
--(select personelID from tblPersonel where personelAdSoyad=@PersonelAdiSoyadi),
--@Adet,
--@tutar)

--create procedure stokAzalt
--@urunID int,
--@Adet int
--as
--update tblUrunler set urunStok-=@Adet where urunID=@urunID
	
--execute stokAzalt @urunID=1,@Adet=1

--create procedure kasaArtir
--@tutar decimal(18,2)
--as
--update tblKasa set KasaToplam+=@tutar

--execute kasaArtir @tutar=5

--alter procedure musteriBakiyeArtir
--@MusteriAdSoyad varchar(100),
--@tutar decimal(18,2)
--as
--update tblMusteri set musteriBakiye+=@tutar 
--where 
--musteriID=(SELECT musteriID from tblMusteri where musteriAdi+musteriSoyadi=@MusteriAdSoyad)

--UPDATE tblKasa set KasaToplam = (select SUM(tutar) from tblHareket )

--create trigger personelArtis
--on tblPersonel
--after insert
--as
--update tblIstatistik set PersonelSayisi+=1

--create trigger personelAzalis
--on tblPersonel
--after delete
--as
--update tblIstatistik set PersonelSayisi-=1

--create trigger musteriArtis
--on tblMusteri
--after insert
--as
--update tblIstatistik set MusteriSayisi+=1

--create trigger musteriAzalis
--on tblMusteri
--after delete
--as
--update tblIstatistik set MusteriSayisi-=1

--create trigger islemSayisiArtis
--on tblHareket
--after insert
--as
--update tblIstatistik set YapýlanIslemSayýsý+=1

--create trigger urunArtis
--on tblUrunler
--after insert
--as
--update tblIstatistik set UrunSayisi+=1

--create trigger urunAzalis
--on tblUrunler
--after delete
--as
--update tblIstatistik set UrunSayisi-=1

--create view bosOdalar
--as
--select odaNo from Odalar where OdaAktif != OdaKapasite