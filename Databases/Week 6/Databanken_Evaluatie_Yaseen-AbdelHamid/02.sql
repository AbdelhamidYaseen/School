USE yaseenabdelhamid;
SELECT COUNT(ReleaseJaar) 
AS "Aantal Nummers"
FROM Liedjes
GROUP BY ReleaseJaar < 1990
;
