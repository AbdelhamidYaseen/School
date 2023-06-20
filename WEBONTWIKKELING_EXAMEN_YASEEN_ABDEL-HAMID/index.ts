import express, { json } from "express";
import {Profile, TrendingTag, Tweet } from "./types";

const app = express();

app.set("view engine","ejs");
app.use(express.static("public"));

app.use(express.json({ limit: '1mb' }));
app.use(express.urlencoded({ extended:true}));

let tweets: Tweet[] = [
];
let profiles: Profile[] = [];

let userHandle = "JonDoe";
const getTagsFromTweet = (tweet: Tweet) => {
    return tweet.text.split(" ").filter((word: string) => word.startsWith("#"));
}

const getTweets = () => {
    // - De tweets bevatten momenteel nog geen naam. Gebruik de map functie om 
    // voor elke tweet de naam van de gebruiker toe te voegen. De naam kan je
    // ophalen met de getProfileByHandle functie.
    // 
    // - Sorteer de tweets op datum. De nieuwste tweets moeten bovenaan staan.
    // Gebruik hiervoor de sort functie. Je moet de createdOn eerst omzetten
    // naar een Date object aan de hand van de constructor (new Date(...)), 
    // vervolgens kan je de getTime functie gebruiken om het aantal milliseconden 
    // en deze met elkaar te vergelijken.
    // 
    // TIP: sort past de array aan, je moet dus eerst een kopie maken van de array.
    /*    
    tweets.map(e=>getProfileByHandle(e.handle))
    console.log(tweets);
    */
    

    return tweets;
}

const getTweetsByHandle = (handle: string) => {
    // Herschrijf deze code met de filter functie.
    /*
    for (let tweet of tweets) {
        if (tweet.handle == handle) {
            tweets.push(tweet);
        }
    }
    */
    const filteredTweets: Tweet[] = tweets.filter(e=>{
        if(e.handle == handle) {return true;}
    })
    return filteredTweets;
}

const getProfileByHandle = (handle: string) => {
    // Herschrijf deze code met een array functie naar keuze.
    
    for (let profile of profiles) {
        if (profile.handle == handle) {
            return profile;
        }
    }
    
}

const createTweet = (tweet: Tweet) => {
    tweets.push(tweet);
}

const getTrendingTags = () => {
    // Gebruik de reduce functie om de trending tags te berekenen.
    // Je moet dus tellen hoeveel keer een tag voorkomt in de tweets.
    // Gebruik de getTagsFromTweet functie om de tags uit een tweet te halen. 
    // Bv: de tag #Warcraft komt 14 keer voor in de tweets.
    let trendingTags: TrendingTag[] = [
        { tag: '#Warcraft', count: 14 },
        { tag: '#WarcraftJokes', count: 2 },
        { tag: '#LichKingLife', count: 2 },
        { tag: '#Mrgglglglgl', count: 1 }
    ];
    return trendingTags;
}

app.get("", (req,res) => {
    let tweets = getTweets();
    return res.render("index", {
        error: undefined,
        tweets: tweets,
        userHandle: userHandle,
        trendingTags: getTrendingTags()
    });
});

app.get("/search", (req, res) => {
    // Haal de query string op uit de request.
    // Gebruik de filter functie om de tweets te filteren op basis van de query string.
    // Je moet zoeken in de handle, naam en tekst van de tweet.
    // Gebruik de getTweets functie om de tweets op te halen.
    let filteredTweets : Tweet[] = [];
    const queryString = req.query.q as string 
    //console.log(queryString);
    //console.log(tweets)
    console.log(queryString)
    filteredTweets = tweets.filter(e => {
        if(e.handle === queryString){
            return true;
        }}
    )
    if(filteredTweets.length != 0){
        res.render("search", {
            error: undefined,
            tweets: filteredTweets,
            userHandle: userHandle,
            trendingTags: getTrendingTags()
            ,filteredTweets
    });    
    }
    else{
        res.status(404);
        res.send(`404-No Tweets Found for ${queryString}`)
    }
});

app.get("/:handle", (req,res) => {
    const profile: any = getProfileByHandle(req.params.handle);
    if (profile) {
        console.log(userHandle);
        console.log(profile)
        const tweets = getTweetsByHandle(req.params.handle);
        res.render("profile", {
            tweets: tweets,
            profile: profile,
            userHandle: userHandle, 
            trendingTags: getTrendingTags()
        });
    } else {
        res.status(404);
        const error = "Profile not found."
        res.render("error", {errorMessage: error})
    }
});

app.get("/settings/profile", (req, res) => {
    const profile = userHandle;
    return res.render("editprofile", {
        error: undefined,
        tweets: tweets,
        profile: profile,
        userHandle: userHandle,
        trendingTags: getTrendingTags()
    });
});
app.post("/settings/profile", (req,res)=>{
    const profile = userHandle;
    let error : string | undefined = undefined;

    if (req.body.name.length == 0) {
        error = "Name is required";
        return res.render("editprofile", {
            error: undefined,
            tweets: tweets,
            profile: profile,
            userHandle: userHandle,
            trendingTags: getTrendingTags()
        });    
    }
    else if (req.body.bio.length == 0) {
        error = "Bio is required";
        return res.render("editprofile", {
            error: undefined,
            tweets: tweets,
            profile: profile,
            userHandle: userHandle,
            trendingTags: getTrendingTags()
        });    
    }
    else{
        res.redirect("/")
    }

})
// Schrijf een post request handler voor de route /settings/profile.
// De gebruiker moet de naam en bio kunnen aanpassen via een formulier.
// Als de gebruiker geen naam of bio heeft ingevuld, moet je een error message terugsturen.

app.post("/", (req, res) => {
    let error : string | undefined = undefined;
    if (req.body.text.length == 0) {
        error = "This tweet should be at least 1 character long";
    } else if (req.body.text.length > 280) {
        error = "This tweet is too long";
    } else {
        const newTweet : Tweet = {
            handle: userHandle,
            text: req.body.text,
            createdOn: new Date()
        }
        createTweet(newTweet);
    }

    let tweets = getTweets();
    res.render("index", {
        tweets: tweets,
        trendingTags: getTrendingTags(),
        userHandle: userHandle,
        error: error
    });
});

const loadData = async() => {
    // Gebruik de fetch API om de data op te halen van de volgende URL's:
    // https://raw.githubusercontent.com/similonap/json/master/twitter/profiles.json
    // https://raw.githubusercontent.com/similonap/json/master/twitter/tweets.json
    // Gebruik van promises is verplicht!
    const profilesFetch: Profile[] = 
        await 
        (fetch("https://raw.githubusercontent.com/similonap/json/master/twitter/profiles.json")
            .then((results:any)=>results.json()))
                profilesFetch.forEach(profile => {
                    profiles.push(profile);
    });

    const tweetsFetch: Tweet[] = await (fetch("https://raw.githubusercontent.com/similonap/json/master/twitter/profiles.json").then((results:any)=>results.json()))
    tweetsFetch.forEach(tweet => {
        tweets.push(tweet);
    });
};

app.listen(3000, () => {
    loadData();
    console.log(`The application is listening on http://localhost:3000`);
});