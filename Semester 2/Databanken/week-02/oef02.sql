USE ApDB;
SET SQL_SAFE_UPDATES = 0;
UPDATE AuteursBoeken 
	SET
		Titel = "Pet Cemetery"
        WHERE Titel = "Pet Sematary"
    ;
UPDATE AuteursBoeken
	SET
		Auteur = "Stephen King"
        WHERE Auteur = "Steven King"
	;
SET SQL_SAFE_UPDATES = 1;
	
/*
OMDAT VOOR & FAMILIENAAM 2 APPARTE COLUMNS ZIJN --> SQL KAN DIT NIET VERWERKEN 
*/