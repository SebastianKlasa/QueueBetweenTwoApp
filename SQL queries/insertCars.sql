SET IDENTITY_INSERT Cars ON

INSERT INTO Cars (carID, liczba_drzwi, rocznik,
           marka, model, nadwozie, 
		   cena_za_godzine, dostepnosc)
SELECT  carID, liczba_drzwi, rocznik,
           marka, model, nadwozie, 
		   cena_za_godzine, dostepnosc
        
   FROM OPENROWSET (BULK 'E:\KSRprojekt\jsonEdit\jsonEdit\bin\Debug\netcoreapp2.2\data.json', SINGLE_CLOB) as j
   CROSS APPLY OPENJSON(BulkColumn)
   WITH( carID int, liczba_drzwi INT, rocznik VARCHAR(4),
           marka VARCHAR(50), model VARCHAR(50), nadwozie VARCHAR(50), 
		   cena_za_godzine INT, dostepnosc BIT
        ) 
SET IDENTITY_INSERT Cars OFF