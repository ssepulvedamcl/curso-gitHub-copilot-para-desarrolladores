/**
 * ✅ SEGURO: Escapar la salida
 */
const express = require('express');
const app = express();
const escape = require('escape-html');

app.get('/hello', (req, res) => {
  const name = req.query.name || "invitado";
  res.send(`<h1>Hola ${escape(name)}</h1>`);
});

app.listen(3003, () => console.log('Servidor seguro en :3003'));
