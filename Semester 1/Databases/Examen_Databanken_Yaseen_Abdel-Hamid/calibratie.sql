USE yaseenabdelhamid;
DROP TABLE IF EXISTS SprintTijden;
CREATE TABLE SprintTijden (
Naam VARCHAR(100) NOT NULL,
Leeftijd INT NOT NULL,
Tijd DOUBLE NOT NULL
);

insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Liam Jancy', 91, 26.558);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Fredric Castaner', 76, 24.522);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Mildrid Tarzey', 28, 12.898);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Massimiliano MacCrosson', 31, 16.031);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Dayna Roskilly', 83, 36.927);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Trenton Thowless', 86, 28.893);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Clyve Eede', 39, 18.491);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Gaynor Pridden', 96, 31.44);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Rolf Fogel', 60, 21.3);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Rozanna Rosengren', 25, 18.621);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Clementius Enns', 24, 22.094);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Evin Franciskiewicz', 98, 39.006);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Mordecai Durrad', 26, 14.387);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Donnajean Inkster', 92, 31.082);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Goraud Moyser', 59, 22.123);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Urban Nuccii', 85, 30.641);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Elizabet Gravatt', 18, 12.823);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Marcella O''Carney', 40, 16.219);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Bat Giovannacci', 56, 19.451);
insert into SprintTijden (Naam, Leeftijd, Tijd) values ('Micah Silberschatz', 13, 34.975);

create table Diplomas (
Id int auto_increment primary key,
Titel varchar(100) NOT NULL
);

insert into Diplomas (Titel)
values
("Graduaat"),
("Bachelor"),
("Master"),
("Doctor");

create table Werkzoekenden (
	Id INT auto_increment primary key,
	Diplomas_Id INT,
	Voornaam VARCHAR(50),
	Familienaam VARCHAR(50),
	constraint fk_Werkzoekenden_Diplomas
	foreign key (Diplomas_Id)
	references Diplomas(Id)
);
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (1, 1, 'Ermengarde', 'Crix');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (2, 1, 'Colleen', 'Ames');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (3, 1, 'Hymie', 'Mizen');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (4, NULL, 'Dorthea', 'Rallings');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (5, NULL, 'Ellary', 'Gerling');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (6, NULL, 'Cassaundra', 'Smedmore');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (7, NULL, 'Maggi', 'Dunnett');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (8, NULL, 'Chandra', 'Acreman');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (9, NULL, 'Marianna', 'Mehew');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (10, 1, 'Robinette', 'Bigley');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (11, 1, 'Sibylle', 'Walles');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (12, 1, 'Lek', 'Fincken');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (13, 1, 'Skipper', 'Simeoli');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (14, 1, 'Elyse', 'Morriss');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (15, 1, 'Alleyn', 'Occleshaw');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (16, 2, 'Betsey', 'Chaikovski');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (17, 2, 'Norri', 'Spondley');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (18, 2, 'Christopher', 'Barniss');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (19, NULL, 'Doll', 'Shafier');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (20, NULL, 'Fara', 'Spratt');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (21, NULL, 'Orelie', 'Gowman');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (22, NULL, 'Paolina', 'Brinklow');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (23, 2, 'Bendix', 'Groneway');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (24, 2, 'Marta', 'Petow');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (25, 2, 'Aimil', 'Ivanichev');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (26, 2, 'Carlota', 'Neville');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (27, 2, 'Berta', 'Ochterlony');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (28, 2, 'Ben', 'Heaker');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (29, 2, 'Mattie', 'Wehner');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (30, 2, 'Noelyn', 'Joinsey');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (31, 2, 'Cletis', 'Kobiela');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (32, 2, 'Killian', 'McKane');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (33, 2, 'Blakelee', 'Duker');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (34, 2, 'Freddie', 'Stopper');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (35, 2, 'Humberto', 'Wanless');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (36, 3, 'Fannie', 'Vaneev');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (37, 3, 'Ilysa', 'Gimenez');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (38, 3, 'Kaiser', 'Sails');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (39, 3, 'Bear', 'Barrable');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (40, 3, 'Giacopo', 'Crayker');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (41, 3, 'Denys', 'Bound');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (42, 3, 'Lilias', 'Croce');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (43, 3, 'Currey', 'Shakshaft');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (44, 3, 'Ursula', 'Blinder');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (45, 3, 'Stormi', 'Drakard');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (46, 4, 'Goldy', 'Gillham');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (47, 4, 'Bonnie', 'Studdeard');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (48, 4, 'Hana', 'Thomen');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (49, NULL, 'Terrye', 'Querree');
insert into Werkzoekenden (Id, Diplomas_Id, Voornaam, Familienaam) values (50, NULL, 'Bat', 'Slowly');


DROP TABLE IF EXISTS Vogels;
CREATE TABLE Vogels (
Soort VARCHAR(100) CHAR SET utf8mb4 NOT NULL COLLATE utf8mb4_0900_as_cs,
Klank VARCHAR(50) CHAR SET utf8mb4 NOT NULL,
GewichtInGram MEDIUMINT UNSIGNED,
Zwemt INT,
Vliegt INT
);
INSERT INTO Vogels
VALUES
('Aethopyga primigenia','ae',100,False,True),
('ara','pollywantacracker',70,False,True),
('duif','roekoe',30,False,True),
('kraai','caw',30,False,True),
('eend','kwaak',100,True,True),
('oehôe','oehoe',1000,False,True),
('arend','krrriii',300,False,True),
('pinguïn','kweh',100,True,False),
('zwaluw','swoosh',20,False,True),
('struisvogel','kweh',50000,False,False),
('emoe','kweh',30000,False,False);
