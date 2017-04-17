USE [MayaStok]
GO
/****** Object:  StoredProcedure [dbo].[Stok_Ekle]    Script Date: 31.03.2017 02:12:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Stok_Ekle]
(

@Stok_Kodu nvarchar(50),

@Stok_Adi nvarchar(50),

@Urun_Turu nvarchar(50),

@Adet nvarchar (50),

@Genislik nvarchar (50),

@Yukseklik nvarchar (50)



)

AS
BEGIN
INSERT INTO dbo.Urunler(Stok_Kodu, Stok_Adi, Urun_Turu,Adet,Genislik,Yukseklik) 
VALUES (@Stok_Kodu, @Stok_Adi, @Urun_Turu,@Adet,@Genislik,@Yukseklik)
END
