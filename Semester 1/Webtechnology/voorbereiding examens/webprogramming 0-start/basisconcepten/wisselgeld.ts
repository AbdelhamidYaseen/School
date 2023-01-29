export{}

const teBetalenBedrag : number = 454;
const aantalBriefjes : number = Math.ceil(teBetalenBedrag/50);
const wisselgeld : number = aantalBriefjes*50-teBetalenBedrag;

console.log("Te betalen bedrag: " + teBetalenBedrag);
console.log("Je hebt " + aantalBriefjes + " van 50 nodig");
console.log("Je wisselgeld is dan " + wisselgeld);
