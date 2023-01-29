USE yaseenabdelhamid;
SET @Gemiddelde10_20 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 10 AND 20);
SET @Gemiddelde20_30 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 20 AND 30);
SET @Gemiddelde30_40 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 30 AND 40);
SET @Gemiddelde40_50 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 40 AND 50);
SET @Gemiddelde50_60 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 50 AND 60);
SET @Gemiddelde60_70 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 60 AND 70);
SET @Gemiddelde70_80 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 70 AND 80);
SET @Gemiddelde80_90 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 80 AND 90);
SET @Gemiddelde90_100 = (SELECT AVG(Tijd) FROM SprintTijden WHERE Leeftijd BETWEEN 90 AND 100);

SELECT SUBSTRING("VAN TOT",1)"Categorie",@Gemiddlede30_40 AS "Gemiddelde" FROM SprintTijden
; 
