CREATE DATABASE BusControlSystem;
go
USE BusControlSystem;

CREATE TABLE Drivers(
		DriverID INT IDENTITY PRIMARY KEY NOT NULL,
		DriverCode as ('DD-' + convert(varchar,year(getdate()) ) +':' + (convert(varchar,DriverID)) ),
		Cedula VARCHAR(30) NOT NULL,
		FirstName VARCHAR(30) NOT NULL,
		LastName VARCHAR(30) NOT NULL,
		Birthdate DATE,
		Movil VARCHAR(15),
		Email VARCHAR(30),
		onTrip bit Default 0,
		[Status] VARCHAR(15) DEFAULT  'Activo',
		CONSTRAINT UNQ_DriverCedula UNIQUE(Cedula),
		CONSTRAINT UNQ_DriverEmail UNIQUE(Email),
		CONSTRAINT CHK_DiverStatus CHECK([Status]='Activo' OR [Status]='Inactivo')
);
GO
CREATE TABLE Buses(
		BusID INT IDENTITY PRIMARY KEY NOT NULL,
		BusCode as ('BB-' + convert(varchar,year(getdate()) ) +':' + (convert(varchar,BusID)) ),
		Brand VARCHAR(25),
		Model VARCHAR(25),
		LicensePlate VARCHAR(25),
		Color VARCHAR(15),
		ModelYear INT,
		onTrip bit Default 0,
		[Status] VARCHAR(15) DEFAULT  'Activo',
		CONSTRAINT UNQ_LicensePlate UNIQUE(LicensePlate),
		CONSTRAINT CHK_BusStatus CHECK([Status]='Activo' OR [Status]='Inactivo')
);
GO
CREATE TABLE [Routes](
		RouteID INT IDENTITY PRIMARY KEY NOT NULL,
		RouteCode as ('RR-' + convert(varchar,year(getdate()) ) +':' + (convert(varchar,RouteID)) ),
		Origin VARCHAR(60),
		Destination VARCHAR(60),
		Price INT,
		onTrip bit Default 0,
		[Status] VARCHAR(15) DEFAULT  'Activo',
		CONSTRAINT CHK_RouteStatus CHECK([Status]='Activo' OR [Status]='Inactivo')
);
GO
CREATE TABLE Trips(
		TripId INT IDENTITY PRIMARY KEY NOT NULL,
		TripCode as ('TT-' + convert(varchar,year(getdate()) ) +':' + (convert(varchar,TripId)) ),
		DriverID INT NOT NULL,
		BusID INT NOT NULL,
		RouteID INT NOT NULL,
		CONSTRAINT UQ_DriverID UNIQUE (DriverID),
		CONSTRAINT UQ_BusID UNIQUE (BusID),
		CONSTRAINT UQ_RouteID UNIQUE (RouteID),
		CONSTRAINT FK_Routes FOREIGN KEY (RouteID)
			REFERENCES [Routes](RouteID),
		CONSTRAINT FK_Buses FOREIGN KEY (BusID) 
			REFERENCES Buses(BusID),
		CONSTRAINT FK_Drivers FOREIGN KEY (DriverID) 
			REFERENCES Drivers(DriverID),
);
