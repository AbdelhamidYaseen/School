let spreadsheet: number[][] = 
[
    [100, 104, 105],
    [144, 110, 109],
    [105, 107, 111]
]
;
for(let i : number = 0; i <= 2; i++)
{
    let somRij : number = 0;
    somRij = spreadsheet[i][0] + spreadsheet[i][1] + spreadsheet[i][2];
    console.log(`De som van rij ${i+1} is: ${somRij}`);
}
