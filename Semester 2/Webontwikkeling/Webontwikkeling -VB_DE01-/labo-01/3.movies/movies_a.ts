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
  export{}