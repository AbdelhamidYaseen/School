USE yaseenabdelhamid
;
-- ///////////////////////////////////////////////////////////////////////////
SET SQL_SAFE_UPDATES = 0;
DELETE FROM Nummers 
WHERE ReleaseDatum IS NUll;
SET SQL_SAFE_UPDATES = 1;

SELECT * FROM Nummers;