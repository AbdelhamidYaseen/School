const express = require('express');
const session = require('express-session');
const fs = require('fs');
const app = express();
const port = 1337;

app.use(express.static('public'));

app.get("/", (req,res) => {
    res.send('http/text', )
});


app.listen(port, () => {
    console.log(`Example app listening at http://localhost:${port}`); 
});