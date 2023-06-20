create
(DonnerPass:Film {id: 1, releasejaar: date("1993"), titel: "Donner Pass"}),

(TalesFromTheDarksideTheMovie:Film {id: 4, releasejaar: date("1969"), titel: "Tales From The Darkside The Movie"}),

(ATeam:Film {id: 5, releasejaar: date("2011"), titel: "A-Team, The"}),

(politcaldocumentary:Categorie{id: 245, naam:"Political Documentary"}),

(socialproblemfilm:Categorie{id: 295, naam:"Social Problem Film"}),

(DonnerPass)-[:FILM_IN_CATEGORY_VAN{category:NULL}]

(ATeam)-][:FILM_IN_CATEGORY_VAN{category:socialproblemfilm}]

(TalesFromTheDarksideTheMovie)-[:FILM_IN_CATEGORY_VAN{category:politicaldocumentary}]
