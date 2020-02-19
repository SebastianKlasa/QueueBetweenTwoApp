CREATE TABLE Users (
	userID INT IDENTITY(1,1) PRIMARY KEY,
	imie VARCHAR(50) NOT NULL,
	nazwisko VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	haslo VARCHAR(50) NOT NULL,
	potwierdz_haslo VARCHAR(50) NOT NULL,
	data_urodzenia DATE NOT NULL,
	adres VARCHAR(50) NOT NULL,
	telefon VARCHAR(15) NOT NULL,
	opcje_zarzadzania BIT
)
CREATE TABLE Cars (
	carID INT IDENTITY(1,1) PRIMARY KEY,
	liczba_drzwi INT NOT NULL,
	rocznik VARCHAR(4) NOT NULL,
	marka VARCHAR(50) NOT NULL,
	model VARCHAR(50) NOT NULL,
	nadwozie VARCHAR(50) NOT NULL,
	cena_za_dzien INT NOT NULL,
	dostepnosc BIT NOT NULL
)
CREATE TABLE Hire (
	hireID INT IDENTITY(1,1) PRIMARY KEY,
	userID int FOREIGN KEY REFERENCES Users(userID) NOT NULL,
	carID int FOREIGN KEY REFERENCES Cars(carID) NOT NULL,
	data_wynajmu DATE NOT NULL,
	data_zakonczenia_wynajmu DATE NOT NULL,
	cena_wynajmu INT NOT NULL,
	czy_oplacone BIT,
	status_wypozyczenia VARCHAR(50)
)