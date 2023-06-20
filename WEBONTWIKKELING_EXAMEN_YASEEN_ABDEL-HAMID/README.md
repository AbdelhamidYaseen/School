# Examen Webontwikkeling

## Project setup

Download het zip bestand van toets.ap.be en pak het uit in een nieuwe map. Open de map in Visual Studio Code. Gebruik het `npm install` commando om alle dependencies te installeren. 

## Profiles en Tweets inlezen

- [ ] Breid de functie `loadData` uit zodat deze de data ophaalt van de volgende URL's:
  - https://raw.githubusercontent.com/similonap/json/master/twitter/profiles.json
  - https://raw.githubusercontent.com/similonap/json/master/twitter/tweets.json
- [ ] Gebuik van promises is verplicht!
- [ ] De arrays `profiles` en `tweets` moeten gevuld worden met de data uit de API calls.

## getTweetsByHandle en getProfileByHandle

- [ ] **Gebruik de `filter` functie** om de for-loop in de functie `getTweetsByHandle` weg te werken. 
- [ ] **Gebruik een array functie naar keuze** om de functie `getProfileByHandle` uit te werken.

## getTweets

- [ ] **Gebruik de `map` functie** om de naam van de gebruiker toe te voegen aan de tweets. Gebruik de functie `getProfileByHandle` om de naam op te halen.
- [ ] **Gebruik de `sort` functie** om de tweets te sorteren op datum (nieuwste tweet eerst). 
    - **Bekijk de [documentatie over Date](DATE_DOCUMENTATIE.md)**. Zet de `createdOn` waarde om naar een Date object aan de hand van de constructor (`new Date(datetimestring : string)`). Gebruik daarna de `getTime` functie om datums te vergelijken.

## GET /search

- [ ] **Haal de query string op** uit de request.
- [ ] **Gebruik de `filter` functie** om de tweets te filteren op basis van de query string. Je moet zoeken in de handle, naam en tekst van de tweet. De zoekopdracht moet case insensitive zijn.
- [ ] **Maak een nieuwe search pagina** aan `search.ejs` en render deze met de gevonden tweets. 
  - [ ] De header (de h1 tag) bovenaan de pagina moet `Search results for: <zoekterm>` zijn.
  - [ ] Als er geen tweets gevonden zijn toon je de foutmelding `No tweets found for: <zoekterm>`.

## GET /:handle

- [ ] Als een gebruiker naar een profiel pagina gaat die niet bestaat, dan **toon je de `error.ejs` pagina** met de **foutmelding `Profile not found`.**
- [ ] **De knop `Edit profile` wordt enkel getoond** als de pagina van de gebruiker zelf is (afkomstig uit de userHandle variabele).

## /settings/profile

- [ ] Als een gebruiker op de `Edit profile` knop klikt, dan toon je de `editprofile.ejs` pagina.
- [ ] Voorzie een POST route waarmee je de gebruiker kan updaten. **De wijziging moet lokaal gebeuren** in de `profiles` array.
- [ ] Als de gebruiker op de `Save` knop klikt, dan wordt de gebruiker teruggestuurd naar hun profiel pagina.
- [ ] Als het `bio` veld leeg is, dan wordt de gebruiker teruggestuurd naar de `editprofile.ejs` pagina met de foutmelding `Bio is required`.
- [ ] Als het `name` veld leeg is, dan wordt de gebruiker teruggestuurd naar de `editprofile.ejs` pagina met de foutmelding `Name is required`.

## getTrendingTags

- [ ] Maak gebruik van een for loop in de `aside` template zodat de *trending tags* getoond worden. (Momenteel zijn deze nog hard gecodeerd)
- [ ] Gebruik **array functies** om de functie `getTrendingTags` uit te werken.
    - Gebruik **minstens** de `reduce` functie. 
    - De functie geeft een array terug van `TrendingTag` objecten. Een `TrendingTag` object heeft de volgende properties:  
      - `tag`: de naam van de tag  
      - `count`: het aantal keer dat de tag voorkomt in de tweets
    - [ ] **Sorteer** de `TrendingTag` objecten op basis van het aantal keer dat ze voorkomen. **De meest voorkomende tag moet bovenaan staan.**
    - [ ] De functie geeft **de 4 meest voorkomende tags** terug.

## Zippen en inzenden

> ⚠️**Let op**⚠️: Volg de onderstaande instructies nauwkeurig op. Doe je dit niet, dan verlies je punten op het examen.

- [ ] Verwijder de node_modules folder
- [ ] Zip het volledige project
- [ ] Dien de zip in via toets.ap.be (enkel een zip bestand, geen rar of 7z)