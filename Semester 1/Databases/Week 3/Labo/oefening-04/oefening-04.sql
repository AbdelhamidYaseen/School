USE yaseenabdelhamid;
set sql_safe_updates = 0;
UPDATE Geboortes SET Familienaam = CONCAT(SUBSTRING(Familienaam,1,1),'.');
set sql_safe_updates = 1;