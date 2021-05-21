
USE BanHang
UPDATE image
SET data =(SELECT bulkcolumn 
FROM OPENROWSET(BULK 'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\macPro1.jpg', SINGLE_BLOB) AS I) 
WHERE FileName = 'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\macPro1.jpg'

CREATE TABLE ImportedImages( 
      FileName sysname NULL, ImageData varbinary(max) NULL) 
GO 

insert INTO ImportedImages(FileName) 
EXEC xp_cmdshell'dir F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\*.jpg /B'

go
DELETE FROM ImportedImages
WHERE FileName IS NULL 
GO

-- Import all impages from folder
DECLARE C CURSOR FOR 
      (SELECT FileName FROM ImportedImages WHERE ImageData IS NULL) 
DECLARE @FileName sysname 
DECLARE @Path sysname 
DECLARE @SQL varchar(max)

-- Loop through each file loading the images one by one
OPEN C 
FETCH NEXT FROM C INTO @FileName 
WHILE (@@FETCH_STATUS <> -1) 
BEGIN 
  SET @Path = 'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\' + @FileName 
  SET @SQL = 
  'UPDATE ImportedImages 
      SET ImageData = (SELECT bulkcolumn FROM OPENROWSET(
      BULK ''' + @Path + ''', SINGLE_BLOB) AS IMAGE) 
      WHERE FileName = ''' + @FileName + '''' 
  EXEC (@sql) 
  FETCH NEXT FROM C INTO @FileName 
END 
CLOSE C 
DEALLOCATE C
--Lo?i s?n ph?m
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP06' , -- id_loaisanpham - char(10)
          'TH04' , -- id_thuonghieu - char(10)
          N'Ipad Pro'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP07' , -- id_loaisanpham - char(10)
          'TH04' , -- id_thuonghieu - char(10)
          N'Ipad Air'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP08' , -- id_loaisanpham - char(10)
          'TH04' , -- id_thuonghieu - char(10)
          N'Ipad Mini'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP09' , -- id_loaisanpham - char(10)
          'TH05' , -- id_thuonghieu - char(10)
          N'Samsung Tab S'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP10' , -- id_loaisanpham - char(10)
          'TH05' , -- id_thuonghieu - char(10)
          N'Samsung Tab A'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP11' , -- id_loaisanpham - char(10)
          'TH06' , -- id_thuonghieu - char(10)
          N'Huawei'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP12' , -- id_loaisanpham - char(10)
          'TH07' , -- id_thuonghieu - char(10)
          N'Iphone 12 (Mini, Pro, Pro Max)'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP13' , -- id_loaisanpham - char(10)
          'TH07' , -- id_thuonghieu - char(10)
          N'Iphone 11 (Pro, Pro Max)'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP14' , -- id_loaisanpham - char(10)
          'TH07' , -- id_thuonghieu - char(10)
          N'Iphone Xr'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP15' , -- id_loaisanpham - char(10)
          'TH07' , -- id_thuonghieu - char(10)
          N'Iphone SE (2020)'  -- name - nvarchar(50)
        
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP16' , -- id_loaisanpham - char(10)
          'TH08' , -- id_thuonghieu - char(10)
          N'Galaxy Note'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP17' , -- id_loaisanpham - char(10)
          'TH08' , -- id_thuonghieu - char(10)
          N'Galaxy S'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP18' , -- id_loaisanpham - char(10)
          'TH08' , -- id_thuonghieu - char(10)
          N'Galaxy A'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP19' , -- id_loaisanpham - char(10)
          'TH09' , -- id_thuonghieu - char(10)
          N'Oppo A'  -- name - nvarchar(50)
        )
INSERT INTO dbo.LoaiSanPham
VALUES  ( 'LP20' , -- id_loaisanpham - char(10)
          'TH02' , -- id_thuonghieu - char(10)
          N'Oppo Reno'  -- name - nvarchar(50)
        )
        
--Hình ?nh

INSERT INTO image values ('SP01', (SELECT * FROM OPENROWSET(BULK N'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\macPro1.jpg', SINGLE_BLOB) as T1))
INSERT INTO image values ('SP21', (SELECT * FROM OPENROWSET(BULK N'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\iphone-12-den-new-600x600-600x600.jpg', SINGLE_BLOB) as T1))
INSERT INTO image values ('SP22', (SELECT * FROM OPENROWSET(BULK N'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\iphone-23-mini-do-new-600x600-600x600.jpg', SINGLE_BLOB) as T1))
INSERT INTO image values ('SP19', (SELECT * FROM OPENROWSET
(BULK N'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\iphone-12-pro-max-vang-new-600x600-600x600.jpg', SINGLE_BLOB) as T1))
INSERT INTO image values ('SP24', (SELECT * FROM OPENROWSET
(BULK N'F:\DAIHOC\TAILIEU_CHUYENNGANH\Nam3\LapTrinhNangCao\LapTrinhNangCao\BanHang\image\samsunggalaxynote20ultratrangnew-600x600-600x600.jpg', SINGLE_BLOB) as T1))

--S?n ph?m

INSERT INTO dbo.SanPham
VALUES  ( 'SP04' , -- id_sanpham - char(10)
          'LP02' , -- id_loaisanpham - char(10)
          N'MacBook Air M1 512GB/Silver (MGNA3SA/A)' , -- name - nvarchar(50)
          N' 13.3 inch, Retina (2560 x 1600)' , -- manhinh - nvarchar(50)
          N'Apple M1' , -- cpu - nvarchar(50)
          N'8 nhân GPU' , -- carddohoa - nvarchar(50)
          33990000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP05' , -- id_sanpham - char(10)
          'LP02' , -- id_loaisanpham - char(10)
          N'MacBook Air M1 256GB/Space Grey (MGN63SA/A)' , -- name - nvarchar(50)
          N' 13.3 inch, Retina (2560 x 1600)' , -- manhinh - nvarchar(50)
          N'Apple M1' , -- cpu - nvarchar(50)
          N'7 nhân GPU' , -- carddohoa - nvarchar(50)
          27990000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP07' , -- id_sanpham - char(10)
          'LP03' , -- id_loaisanpham - char(10)
          N'MacBook Air M1 512GB/Silver (MGNA3SA/A)' , -- name - nvarchar(50)
          N' 13.3 inch, Retina (2560 x 1600)' , -- manhinh - nvarchar(50)
          N'Apple M1' , -- cpu - nvarchar(50)
          N'8 nhân GPU' , -- carddohoa - nvarchar(50)
          33990000  -- giatien - float
        )

INSERT INTO dbo.SanPham
VALUES  ( 'SP06' , -- id_sanpham - char(10)
          'LP03' , -- id_loaisanpham - char(10)
          N'MacBook Air M1 512GB/Silver (MGNA3SA/A)' , -- name - nvarchar(50)
          N' 13.3 inch, Retina (2560 x 1600)' , -- manhinh - nvarchar(50)
          N'Apple M1' , -- cpu - nvarchar(50)
          N'8 nhân GPU' , -- carddohoa - nvarchar(50)
          33990000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP08' , -- id_sanpham - char(10)
          'LP04' , -- id_loaisanpham - char(10)
          N'Dell Vostro 3500 i5 1135G7 (P90F006V3500B)' , -- name - nvarchar(50)
          N' 15.6", Full HD (1920 x 1080)' , -- manhinh - nvarchar(50)
          N' Intel Core i5 Tiger Lake, 2.40 GHz' , -- cpu - nvarchar(50)
          N'NVIDIA GeForce MX330, 2 GB' , -- carddohoa - nvarchar(50)
          17690000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP09' , -- id_sanpham - char(10)
          'LP05' , -- id_loaisanpham - char(10)
          N'Dell Inspiron 3501 i5 1135G7 (P90F005N3501B)' , -- name - nvarchar(50)
          N'15.6", Full HD (1920 x 1080)' , -- manhinh - nvarchar(50)
          N'Intel Core i5 Tiger Lake, 2.40 GHz' , -- cpu - nvarchar(50)
          N' Intel Iris Xe Graphics' , -- carddohoa - nvarchar(50)
          16690000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP10' , -- id_sanpham - char(10)
          'LP06' , -- id_loaisanpham - char(10)
          N'iPad Pro M1 12.9 inch WiFi Cellular 256GB (2021)' , -- name - nvarchar(50)
          N' 12.9", Liquid Retina XDR mini-LED LCD' , -- manhinh - nvarchar(50)
          N'Chip Apple M1 8 nhân' , -- cpu - nvarchar(50)
          N'RAM 8 GB, ROM 256 GB' , -- carddohoa - nvarchar(50)
          37990000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP11' , -- id_sanpham - char(10)
          'LP06' , -- id_loaisanpham - char(10)
          N'iPad Pro 12.9 inch Wifi Cellular 128GB (2020)' , -- name - nvarchar(50)
          N'12.9", Liquid Retina' , -- manhinh - nvarchar(50)
          N'Chip Apple A12Z Bionic' , -- cpu - nvarchar(50)
          N'RAM 6 GB, ROM 128 GB' , -- carddohoa - nvarchar(50)
          31190000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP18' , -- id_sanpham - char(10)
          'LP10' , -- id_loaisanpham - char(10)
          N'Samsung Galaxy Tab A7 (2020)' , -- name - nvarchar(50)
          N'10.4", TFT LCD' , -- manhinh - nvarchar(50)
          N'Chip Snapdragon 662' , -- cpu - nvarchar(50)
          N'RAM 3 GB, ROM 64 GB' , -- carddohoa - nvarchar(50)
          7990000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP19' , -- id_sanpham - char(10)
          'LP12' , -- id_loaisanpham - char(10)
          N'iPhone 12 Pro Max 512GB' , -- name - nvarchar(50)
          N' 6.7" ' , -- manhinh - nvarchar(50)
          N'Chip Apple A14 Bionic' , -- cpu - nvarchar(50)
          N'RAM 6 GB, ROM 512 GB' , -- carddohoa - nvarchar(50)
          41490000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP20' , -- id_sanpham - char(10)
          'LP12' , -- id_loaisanpham - char(10)
          N'iPhone 12 Pro 512GB' , -- name - nvarchar(50)
          N' 6.1" ' , -- manhinh - nvarchar(50)
          N'Chip Apple A14 Bionic' , -- cpu - nvarchar(50)
          N'RAM 6 GB, ROM 512 GB' , -- carddohoa - nvarchar(50)
          36490000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP21' , -- id_sanpham - char(10)
          'LP12' , -- id_loaisanpham - char(10)
          N'iPhone 12 256GB' , -- name - nvarchar(50)
          N' 6.7" ' , -- manhinh - nvarchar(50)
          N'Chip Apple A14 Bionic' , -- cpu - nvarchar(50)
          N'RAM 4 GB, ROM 256 GB' , -- carddohoa - nvarchar(50)
          25490000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP22' , -- id_sanpham - char(10)
          'LP12' , -- id_loaisanpham - char(10)
          N'iPhone 12 mini 256GB' , -- name - nvarchar(50)
          N' 5.4" ' , -- manhinh - nvarchar(50)
          N'Chip Apple A14 Bionic' , -- cpu - nvarchar(50)
          N'RAM 4 GB, ROM 256 GB' , -- carddohoa - nvarchar(50)
          21490000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP24' , -- id_sanpham - char(10)
          'LP16' , -- id_loaisanpham - char(10)
          N'Samsung Galaxy Note 20 Ultra 5G Tr?ng' , -- name - nvarchar(50)
          N'  6.9"' , -- manhinh - nvarchar(50)
          N'Chip Exynos 990' , -- cpu - nvarchar(50)
          N'RAM 12 GB, ROM 256 GB' , -- carddohoa - nvarchar(50)
          32990000  -- giatien - float
        )
INSERT INTO dbo.SanPham
VALUES  ( 'SP25' , -- id_sanpham - char(10)
          'LP14' , -- id_loaisanpham - char(10)
          N'Samsung Galaxy Note 20 Ultra 5G' , -- name - nvarchar(50)
          N' 6.9" ' , -- manhinh - nvarchar(50)
          N'Chip Exynos 990' , -- cpu - nvarchar(50)
          N'RAM 6 GB, ROM 256 GB' , -- carddohoa - nvarchar(50)
          32990000  -- giatien - float
        )

