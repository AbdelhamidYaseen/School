  const languages = [
    "english",
    "french",
    "spanish",
    "german",
    "dutch",
    "italian",
  ];
  interface getGoodbyeInLanguage
  {
    (language : string) : string
  }
  interface getRandomLanguage
  {
  }
  interface sayGoodbye
  {
    (name : string) : void
  }
  interface sayGoodbyeTimes
  {
    (name : string, times : number) : void
  }  
  const getGoodbyeInLanguage : getGoodbyeInLanguage = (language = "english")=> {
    if (language === "english") {
      return "Goodbye";
    } else if (language === "french") {
      return "Au revoir";
    } else if (language === "spanish") {
      return "Adiós";
    } else if (language === "german") {
      return "Auf Wiedersehen";
    } else if (language === "dutch") {
      return "Tot ziens";
    } else if (language === "italian") {
      return "Arrivederci";
    } else {
      return "Language not found";
    }
  }
  
  const getRandomLanguage = () =>{
    return languages[Math.floor(Math.random() * languages.length)];
  }
  
  const sayGoodbye : sayGoodbye= (name) => {
    let goodbye = getGoodbyeInLanguage(getRandomLanguage());
    console.log(`${goodbye}, ${name}`);
  }
  
  const sayGoodbyeTimes : sayGoodbyeTimes= (name: string, times: number) => {
    for (let i = 0; i < times; i++) {
      sayGoodbye(name);
    }
  }
  
  sayGoodbyeTimes("Andie", 5);
  export{}