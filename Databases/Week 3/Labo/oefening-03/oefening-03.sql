USE yaseenabdelhamid;
set sql_safe_updates = 0;
UPDATE Liedjes SET AantalVerkocht=AantalVerkocht*10;
set sql_safe_updates = 1;
