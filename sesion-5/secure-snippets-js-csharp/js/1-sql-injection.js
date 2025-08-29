/**
 * ✅ SEGURO: Uso de parámetros preparados con mysql2
 */
const express = require('express');
const app = express();
const mysql = require('mysql2');

const conn = mysql.createConnection({ host: 'localhost', user: 'root', password: 'root', database: 'demo' });

app.get('/user', (req, res) => {
  const username = req.query.username;
  const sql = "SELECT * FROM users WHERE username = ?";
  conn.execute(sql, [username], (err, rows) => {
    if (err) return res.status(500).send('Error DB');
    res.json(rows);
  });
});

app.listen(3000, () => console.log('Servidor seguro en http://localhost:3000'));
