/*
bepaalde opdracht zo uitvoeren dat normaal niet kan [HIJ MOET WERKEN] 
gegevens moeten tezien zijn zoals gevraagd
*/
USE TussentijdseEvaluatie1BDB;
CREATE VIEW BoekenInfo
	AS
		SELECT Titel, Auteurs_Id, Uitgeverijen_Id 
			FROM Boeken
;
