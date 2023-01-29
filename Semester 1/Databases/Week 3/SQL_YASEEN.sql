USE yaseenabdelhamid;
#--------------------------------------------------------------------
CREATE TABLE Persons
	(
    id INT AUTO_INCREMENT NOT NULL
    ,
    PRIMARY KEY (id)
    ,
    name VARCHAR(100)
    ,
    gender ENUM('m','f')
    ,
    age int(3)
	)
;
#--------------------------------------------------------------------
INSERT INTO Persons (name,gender,age)
	VALUES
    ("Bo","f",21),
    ("Robbe","m",21),
	("Robbe","m",22),
    ("Robbe","m",21),
    ("Ortwin","m",18),
    ("Cato","f",22),
    ("Jonathan","m",23),
	("Xian","m",23),
    ("Illias","m",23),
    ("Jon","m",24),
    ("Gio","m",25),
    ("Nathan","m",25),
    ("Alexander","m",20),
    ("Emma","f",20),
    ("Amber","f",19)
;
#--------------------------------------------------------------------
CREATE TABLE Schools
	(
    id INT AUTO_INCREMENT NOT NULL
    ,
    school_id INT NOT NULL
    ,
    name VARCHAR(10)
    ,
    location VARCHAR(20)
    ,
    PRIMARY KEY(id)
    ,
    FOREIGN KEY(school_id) REFERENCES Persons(id)
    )	
;
#--------------------------------------------------------------------
INSERT INTO Schools(school_id,name,location)
	VALUES
    (1,"AP","ANTWERPEN"),
    (2,"KDG","ANTWERPEN"),
    (3,"CENFLU","LINKEROEVER"),
    (4,"LINDE","BORNEM"),
    (5,"ZEEVAART","ANTWERPEN"),
	(6,"TOVERTUIN","WILLEBROEK")
;
#--------------------------------------------------------------------
SELECT name AS 'NAME_SCHOOL'
	FROM Schools
;
#--------------------------------------------------------------------
SELECT DISTINCT name 
	FROM Persons 
		WHERE name = "Robbe"
;
#--------------------------------------------------------------------
SELECT DISTINCT name 
	FROM Persons 
		WHERE name LIKE "%o%"
;
#--------------------------------------------------------------------
SELECT DISTINCT name, 
	id FROM Persons 
		WHERE id BETWEEN 5 AND 15
;
#--------------------------------------------------------------------
set sql_safe_updates = 0;
UPDATE Persons 
	SET name = "Robbe"
		WHERE name = "Alexander"
;
set sql_safe_updates = 1;
#--------------------------------------------------------------------
SELECT COUNT(gender) AS GenderAmount 
	FROM Persons
;
#--------------------------------------------------------------------
SELECT COUNT(gender) AS GenderAmount 
	FROM Persons
		JOIN Schools ON Persons.id = Schools.id
;
#--------------------------------------------------------------------
SELECT gender 
	FROM Persons
		ORDER BY gender
;
#--------------------------------------------------------------------
SELECT gender 
	FROM Persons
		JOIN Schools ON Persons.id = Schools.id
			ORDER BY gender
;
#--------------------------------------------------------------------

#--------------------------------------------------------------------

#--------------------------------------------------------------------

#--------------------------------------------------------------------








