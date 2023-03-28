/*
stored procedure
bepaalde taak gemakkelijker uitvoeren 
[hij gaat niet altijd lukken]
[als hij niet werkt dan moet er een foutscenario gegeven worden] 
*/
SET GLOBAL log_bin_trust_function_creators = TRUE;
DROP procedure IF EXISTS `VoegOntleningToe`;
DELIMITER $$
USE TussentijdseEvaluatie1BDB;
CREATE PROCEDURE VoegOntleningToe (IN Id_Ontlener INT, IN Id_Boek)


END$$
DELIMITER ;