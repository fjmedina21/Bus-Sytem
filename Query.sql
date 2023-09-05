USE BusControlSystem

--Insertar, editar y mostrar Conductor
CREATE PROCEDURE sp_insertDriver 
@Cedula varchar(14), @FirstName varchar(30), @LastName varchar(30),
@Birthdate date, @Movil varchar(15), @Email varchar(30)
AS
BEGIN
	INSERT INTO Drivers (Cedula, FirstName, LastName, Birthdate, Movil, Email)
		VALUES (@Cedula, @FirstName, @LastName, @Birthdate, @Movil, @Email)
END

CREATE PROCEDURE sp_searchDrivers @search varchar(20)
AS
BEGIN
	SELECT DriverID, DriverCode, Cedula, FirstName, LastName, Birthdate, Movil, Email FROM Drivers 
	WHERE (DriverCode = @search OR Cedula = @search) OR (FirstName LIKE @search+'%' OR LastName LIKE @search+'%') 
	AND ([Status] = 'Activo' AND onTrip = 0 ) 
END
-----
CREATE PROC sp_updateDriver @DriverCode varchar(20),
@FirstName varchar(30), @LastName varchar(30),
@Birthdate date, @Movil varchar(15), @Email varchar(30)
AS
BEGIN
	 SET NOCOUNT ON
	UPDATE Drivers SET FirstName=@FirstName, LastName = @LastName, Birthdate = @Birthdate, Movil = @Movil, Email = @Email
		WHERE DriverCode = @DriverCode
	 SET NOCOUNT OFF
END
------
CREATE PROC sp_deleteDriver @DriverCode varchar(20)
AS
BEGIN
	SET NOCOUNT ON
	 UPDATE Drivers SET [Status] = 'Inactivo' WHERE DriverCode = @DriverCode
	SET NOCOUNT OFF
END

-------------------------------------------------------------------------------------------------------------------------------

--Insertar, eliminar y mostrar Vehiculos
CREATE PROCEDURE sp_insertBus 
@Brand varchar(25), @Model varchar(25), @LicensePlate varchar(25),
@Color varchar(15), @ModelYear int
AS
BEGIN
	INSERT INTO Buses (Brand, Model, LicensePlate, Color, ModelYear)
		VALUES (@Brand, @Model, @LicensePlate, @Color, @ModelYear)
END
---------
CREATE PROCEDURE sp_searchBuses @search varchar(20)
AS
BEGIN 
	SELECT BusID, BusCode, Brand, Model, LicensePlate, Color, ModelYear FROM Buses 
	WHERE (BusCode = @search OR LicensePlate = @search	OR Brand LIKE @search+'%' ) 
	AND ([Status] = 'Activo' AND onTrip = 0 ) 
END
--------
CREATE PROC sp_deleteBus @BusCode varchar(20)
AS
BEGIN
	SET NOCOUNT ON
	 UPDATE Buses SET [Status] = 'Inactivo' WHERE BusCode = @BusCode 
	SET NOCOUNT OFF
END

-----------------------------------------------------------------------------------------------------------

--Insertar, eliminar, editar y mostrar Rutas
CREATE PROCEDURE sp_insertRoute
@Origin varchar(60), @Destination varchar(60),@Price int
AS
BEGIN
	INSERT INTO [Routes] (Origin, Destination, Price)
		VALUES (@Origin, @Destination, @Price)
END
--------
CREATE PROCEDURE sp_searchRoutes @search varchar(20)
AS
BEGIN  
	SELECT RouteID,RouteCode, Origin, Destination, Price FROM [Routes] 
	WHERE (RouteCode = @search OR Origin LIKE @search+'%' OR Destination LIKE @search+'%' ) 
	AND ([Status] = 'Activo' AND onTrip = 0 ) 
END
---------
CREATE PROC sp_updateRoute @RouteCode varchar(20), @Price int
AS
BEGIN
	 SET NOCOUNT ON
	UPDATE [Routes] SET Price = @Price
		WHERE RouteCode = @RouteCode
	 SET NOCOUNT OFF
END
---------
CREATE PROC sp_deleteRoute @RouteCode varchar(20)
AS
BEGIN
	 SET NOCOUNT ON
	UPDATE [Routes] SET [Status] = 'Inactivo'
		WHERE RouteCode = @RouteCode
	 SET NOCOUNT OFF
END

--------------------------------------------------------------------------------------------------------------------------------

--Insertar, eliminar y mostrar Viajes
CREATE PROCEDURE sp_insertTrip 
@DriverID int, @BusID int,@RouteID int
AS
BEGIN
		Declare @busStatus varchar(20), @driverStatus varchar(20), @routeStatus varchar(20)
		
		set @busStatus = (select [status] from Buses where BusID = @BusID)
		set @driverStatus = (select [status] from Drivers where DriverID = @DriverID)
		set @routeStatus = (select [status] from [Routes] where RouteID = @RouteID)
					 
      IF(@busStatus = 'Inactivo' OR @driverStatus = 'Inactivo' OR @routeStatus = 'Inactivo')
      BEGIN
			PRINT 'Se produjo un Error: ' + error_message()  
      END ELSE BEGIN
			INSERT INTO Trips (DriverID, BusID, RouteID)
				 VALUES (@DriverID, @BusID, @RouteID)
		END    
END
------------------------------
CREATE VIEW Trips_View 
AS
	SELECT t.TripCode, (d.FirstName +' '+ d.LastName) AS 'Driver', 
	(b.Brand+' '+b.Model+', '+convert(varchar,b.ModelYear)) AS 'Bus', r.Origin, r.Destination, r.Price FROM Trips t 
	JOIN Drivers d ON d.driverID = t.driverID 
	JOIN Buses b ON b.busID = t.busID
	JOIN [Routes] r ON r.RouteID = t.RouteID 

CREATE PROCEDURE sp_searchTrips @search varchar(20)
AS
BEGIN
	SELECT * FROM Trips_View 
		WHERE (Origin LIKE @search+'%' OR Destination LIKE @search+'%') OR TripCode = @search
END

CREATE PROC sp_deleteTrip @TripCode varchar(20)
AS
BEGIN
	SET NOCOUNT ON
	 DELETE Trips WHERE TripCode = @TripCode 
	SET NOCOUNT OFF
END

--------------------------------------------------------------------------------------------------------------------------------

EXEC sp_insertDriver '123-4567890-3', 'Maicol', 'Sena', '1995/05/18', '829-222-5476', 'ms@gmail.com'
EXEC sp_searchDrivers ''
EXEC sp_updateDriver 'DD-2022:3','Josue', 'Sena', '1992/05/18', '829-222-5476', 'js@gmail.com'
EXEC sp_deleteDriver 'DD-20223' 

EXEC sp_insertBus 'Mercedes Benz', 'Tourismo', 'RD10234', 'Rojo', 2022
EXEC sp_insertBus 'Mercedes Benz', 'Turiclass', 'RD14598', 'Blanco', 2019
EXEC sp_insertBus 'Toyota', 'Coaster', 'RD47632', 'Blanco', 2021
EXEC sp_insertBus 'Mercedes Benz', 'Tourrider', 'RD05477', 'Azul', 2018
EXEC sp_searchBuses ''

EXEC sp_insertRoute 'Santo Domingo', 'Barahona', 400
EXEC sp_insertRoute 'Barahona', 'Santo Domingo', 400
EXEC sp_searchRoutes ''

EXEC sp_insertTrip 3,1,2
EXEC sp_searchTrips ''
EXEC sp_deleteTrip 'TT-2022:1'

----------TRIGGERS------------------------
CREATE TRIGGER trgIns_onTrips 
ON Trips FOR INSERT
AS
BEGIN
	SET NOCOUNT ON
	Declare @DriverID int, @BusID int, @RouteID int
		
	set @DriverID = (select DriverID from inserted)
	set @BusID= (select BusID from inserted)
	set @RouteID = (select RouteID from inserted)

	update Drivers set onTrip = 1 Where DriverID = @DriverID
	update Buses set onTrip = 1 Where BusID = @BusID
	update [Routes] set onTrip = 1 Where RouteID = @RouteID 
		
	SET NOCOUNT OFF
END

CREATE TRIGGER trgDel_onTrips 
ON Trips FOR DELETE
AS
BEGIN
	SET NOCOUNT ON
	Declare @DriverID int, @BusID int, @RouteID int
		
	set @DriverID = (select DriverID from deleted)
	set @BusID= (select BusID from deleted)
	set @RouteID = (select RouteID from deleted)

	update Drivers set onTrip = 0 Where DriverID = @DriverID
	update Buses set onTrip = 0 Where BusID = @BusID
	update [Routes] set onTrip = 0 Where RouteID = @RouteID 
		
	SET NOCOUNT OFF
END
