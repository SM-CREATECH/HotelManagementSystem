-- CREATION DE LA BASE DE DONNEES
CREATE DATABASE IF NOT EXISTS `HotelManagementSystemDB`;

-- UTILISATION DE LA BASE CREEE
USE HotelManagementSystemDB;

-- TABLE DES ROLES
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

-- TABLE DES UTILISATEURS
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    UserPasswordHash VARCHAR(255) NOT NULL,
    UserRoleID INT NOT NULL,
    UserIsActive BOOLEAN DEFAULT TRUE,
    UserCreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

ALTER TABLE Users ADD ProfilePhotoPath VARCHAR(255);

-- INSERTION DES ROLES DISPONIBLES
INSERT INTO Roles (RoleName) VALUES
('Administrateur'),
('Réceptionniste'),
('Gestionnaire');

-- INSERTION D'UN UTILISATEUR ADMIN PAR DEFAUT
INSERT INTO Users (Username, UserPasswordHash, UserRoleID)
VALUES ('admin', 'admin123', 1);

-- TABLE DES CHAMBRES
CREATE TABLE Rooms (
    RoomID INT AUTO_INCREMENT PRIMARY KEY,
    RoomNumber VARCHAR(10) NOT NULL UNIQUE,
    RoomType ENUM('Simple', 'Double', 'Suite') NOT NULL,
    RoomPrice DECIMAL(10,2) NOT NULL,
    RoomStatus ENUM('Disponible', 'Occupée', 'En nettoyage') NOT NULL
);

-- TABLE DES CLIENTS
CREATE TABLE Clients (
    ClientID INT AUTO_INCREMENT PRIMARY KEY,
    ClientLastName VARCHAR(50) NOT NULL,
    ClientFirstName VARCHAR(50) NOT NULL,
    ClientPhone VARCHAR(20),
    ClientEmail VARCHAR(100) NOT NULL UNIQUE,
    ClientIdentityNumber VARCHAR(50) NOT NULL UNIQUE,
    ClientNationality VARCHAR(50) NOT NULL
);

-- TABLE DES RESERVATIONS
CREATE TABLE Reservations (
    ReservationID INT AUTO_INCREMENT PRIMARY KEY,
    ReservationClientID INT NOT NULL,
    ReservationRoomID INT NOT NULL,
    ReservationCheckInDate DATE NOT NULL,
    ReservationCheckOutDate DATE NOT NULL,
    ReservationNights INT AS (DATEDIFF(ReservationCheckOutDate, ReservationCheckInDate)) STORED,
    ReservationTotalCost DECIMAL(10,2),
    ReservationStatus ENUM('Confirmée', 'En attente', 'Annulée', 'Terminée') NOT NULL,

    FOREIGN KEY (ReservationClientID) REFERENCES Clients(ClientID),
    FOREIGN KEY (ReservationRoomID) REFERENCES Rooms(RoomID)
);

--TRIGGER POUR CALCUL AUTOMATIQUE DU COUT TOTAL
DELIMITER $$
CREATE TRIGGER CalculateTotalCost
BEFORE INSERT ON Reservations
FOR EACH ROW
BEGIN
    DECLARE roomPrice DECIMAL(10,2);

    SELECT RoomPrice INTO roomPrice
    FROM Rooms
    WHERE RoomID = NEW.ReservationRoomID;

    SET NEW.ReservationTotalCost = roomPrice * DATEDIFF(NEW.ReservationCheckOutDate, NEW.ReservationCheckInDate);
END$$
DELIMITER ;

--TRIGGER POUR CHANGER ETAT CHAMBRE QUAND RESERVATION CONFIRMEE
DELIMITER $$
CREATE TRIGGER UpdateRoomStatus
AFTER INSERT ON Reservations
FOR EACH ROW
BEGIN
    UPDATE Rooms
    SET RoomStatus = 'Occupée'
    WHERE RoomID = NEW.ReservationRoomID;
END$$
DELIMITER ;

-- TABLE DES PAIEMENTS
CREATE TABLE Payments (
    PaymentID INT AUTO_INCREMENT PRIMARY KEY,
    PaymentReservationID INT NOT NULL,
    PaymentDate DATETIME NOT NULL,
    PaymentAmount DECIMAL(10,2) NOT NULL,
    PaymentMethod ENUM('Cash', 'Carte', 'Mobile Money') NOT NULL,

    FOREIGN KEY (PaymentReservationID) REFERENCES Reservations(ReservationID)
);

-- TABLE DES FACTURES
CREATE TABLE Invoices (
    InvoiceID INT AUTO_INCREMENT PRIMARY KEY,
    InvoiceReservationID INT NOT NULL,
    InvoiceDate DATETIME NOT NULL,
    InvoiceTotalAmount DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (InvoiceReservationID) REFERENCES Reservations(ReservationID)
);

-- Voir si réservation est payée ou non (Requête utile)
SELECT
ReservationID,
ReservationTotalCost,
IFNULL(SUM(PaymentAmount),0) AS PaidAmount,
ReservationTotalCost - IFNULL(SUM(PaymentAmount),0) AS RemainingAmount
FROM Reservations
LEFT JOIN Payments ON ReservationID = PaymentReservationID
GROUP BY ReservationID;

-- COMMANDE D'EXPORTATION
mysqldump -u root -p HotelManagementSystemDB > HotelManagementSystemDB.sql

-- COMMANDE D'IMPORTATION
mysql -u root -p HotelManagementSystemDB < HotelManagementSystemDB.sql