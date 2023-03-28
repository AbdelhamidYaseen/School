const tryParseInt = (str: string) => {
    let number ;
    try{
        number = parseInt(str);
    }
    catch(error)
    {
        console.log('error');
    }
    return number;

}



console.log(tryParseInt("error"));