/*
eigen versie van een reverse functie schrijven
length & concat & if & loops
string.length
*/
SET GLOBAL log_bin_trust_function_creators = TRUE;
DROP procedure IF EXISTS `MyReverse`;
DELIMITER $$
USE `TussentijdseEvaluatie1BDB`$$
CREATE PROCEDURE MyReverse (IN myString VARCHAR(100), OUT reversedString VARCHAR(100))
BEGIN
	SET reversedString = "";
	SET i = 0;
    concat_loop: LOOP
    IF i> myString.Length THEN
    reversedString = myString[myString.Length - i];
    i = i+1;
    END IF
	ELSE IF i = 0 THEN
    LEAVE concat_loop;
    END IF
    END LOOP;
    SELECT reversedString;
END$$
DELIMITER ;

/*MyReverse("hoopla");*/