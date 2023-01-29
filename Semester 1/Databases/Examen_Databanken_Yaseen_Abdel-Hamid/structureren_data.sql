USE yaseenabdelhamid;
#TECHSITES
DROP TABLE IF EXISTS TechSites;
CREATE TABLE TechSites
	(Id INT AUTO_INCREMENT, URL VARCHAR(100) NOT NULL, Naam VARCHAR(100) NOT NULL, PRIMARY KEY(Id))
;
INSERT INTO TechSites (URL, Naam)
	VALUES 
    ("arstechnica.com","Ars Technica"),
    ("arstechnica.com","Ars Technica"),
	("tweakers.net","Tweakers"),
	("tweakers.net","Tweakers"),
	("tweakers.net","Tweakers 7")
;
#FABRIKANTEN
DROP TABLE IF EXISTS Fabrikanten;
CREATE TABLE Fabrikanten
	(Id INT AUTO_INCREMENT, Naam VARCHAR(100) NOT NULL, Land VARCHAR(100) NOT NULL, Zetel VARCHAR(100) NOT NULL, PRIMARY KEY(Id))
;
INSERT INTO Fabrikanten (Naam, Land, Zetel)
	VALUES 
    ("Xiaomi","China","Haidan district,Beijing"),
    ("Xiaomi","China","Haidan district,Beijing"),
    ("Fairphone","Nederland","Amsterdam"),
    ("Samsung","Zuid-Korea","Suwon"),
    ("Xiaomi","China","Haidan district,Beijing")
;
#GSMs
DROP TABLE IF EXISTS GSMs;
CREATE TABLE GSMs
	(Id INT AUTO_INCREMENT, Model VARCHAR(100) NOT NULL, Fabrikanten_Id INT, PRIMARY KEY(Id), FOREIGN KEY(Fabrikanten_Id) REFERENCES Fabrikanten(Id))
;
INSERT INTO GSMs (Model,Fabrikanten_Id)
	VALUES 
    ("Mi 9",1),
    ("Redmi Note 2",2),
    ("Fairphone 4",3),
    ("Galaxy S8",4),
    ("Mi9",5)
;
#REVIEWS
DROP TABLE IF EXISTS Reviews;
CREATE TABLE Reviews
	(ScoreOp100 TINYINT,Samenvatting VARCHAR(200),TechSites_Id INT, GSMs_Id INT, FOREIGN KEY(TechSites_Id) REFERENCES TechSites(Id), FOREIGN KEY(GSMs_Id) REFERENCES GSMs(Id))
;
INSERT INTO Reviews (ScoreOp100,Samenvatting,TechSites_Id,GSMs_Id)
	VALUES 
    (60,"Niet slecht maar er zijn betere opties",1,1),
    (80, "Goed gerief!",2,2),
    (00,"Geen Samenvatting",3,3),
    (50, "Kan een stuk beter",4,4),
    (75,"Een goed toestel met enkele minpuntjes",5,5)
;


SELECT GSMs.Model, Fabrikanten.Naam AS 'Fabrikant', Fabrikanten.Land, Fabrikanten.Zetel,
TechSites.URL, TechSites.Naam AS 'Site', COALESCE(Reviews.ScoreOp100,'Geen score') AS
'ScoreOp100', COALESCE(Reviews.Samenvatting,'Geen samenvatting') AS 'Samenvatting'
FROM GSMs CROSS JOIN Fabrikanten CROSS JOIN TechSites CROSS JOIN Reviews
WHERE Fabrikanten_Id = Fabrikanten.Id AND TechSites_Id = TechSites.Id AND GSMS_Id = GSMs.Id
ORDER BY URL, Model;
