interface Movie
{
    title : string;
    year : number;
    actors : string [];
    metascore : number;
    seen : boolean;
}


let thematrix : Movie= {
    title: "The Matrix",
    year: 1999,
    actors: ["Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss"],
    metascore: 73,
    seen: true,
  };
let myfavoritemovie : Movie= {
    title: "The Shawshank Redemption",
    year: 1994,
    actors: ["Tim Robbins", "Morgan Freeman", "Bob Gunton"],
    metascore: 80,
    seen: true,
  };
let myworstmovie : Movie= {
    title: "The Room",
    year: 2003,
    actors: ["Tommy Wiseau", "Juliette Danielle", "Greg Sestero"],
    metascore: 9,
    seen: true,
  };
const wasMovieMadeInThe90s = (movie : Movie) : boolean =>{
    if(movie.year >= 1990 && movie.year <= 1990)
    {
        return true;
    }

    return false;
}
const averageMetaScore = (movies : Movie[]) : number => {
    let average : number = 0;
    for (let index = 0; index < movies.length; index++) {
        average += movies[index].metascore       
    }
    return (average/movies.length);
}
const fakeMetaScore = (movie : Movie, newscore : number) : Movie => {
    movie.metascore = newscore    
    return movie;
}


console.log(wasMovieMadeInThe90s(thematrix));
console.log(averageMetaScore([thematrix,myfavoritemovie,myworstmovie]));
console.log(fakeMetaScore(thematrix, 8));




  export{}