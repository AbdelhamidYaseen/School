USE yaseenabdelhamid;
SET sql_safe_updates = 0
;
UPDATE Games 
SET Uitgever = null
WHERE Uitgever = "Square Enix"
 ;
SET sql_safe_updates = 1
;
SELECT * FROM Games
;