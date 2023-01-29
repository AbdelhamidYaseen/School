USE yaseenabdelhamid;
SELECT Album 
FROM Liedjes 
WHERE Genre 
LIKE "%ock%" 
GROUP BY Album 
HAVING SUM(Royalties) > 300 ORDER BY Album DESC
;