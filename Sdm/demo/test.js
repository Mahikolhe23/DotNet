const express = require('express');
const app = express();

app.get('/', function (req, resp) {
    resp.send("Hello welcome to express page");
})
app.listen(3000);
console.log("running");