USE yaseenabdelhamid;
set sql_safe_updates = 0;
SELECT Artiest
FROM Liedjes
WHERE Artiest LIKE "%e%";
set sql_safe_updates = 1;
