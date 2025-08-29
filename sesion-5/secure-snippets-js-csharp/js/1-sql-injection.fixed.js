/**
 * ✅ Mitigación: SQL parametrizado con mysql2
 * - Valida input (length/charset).
 * - Usa placeholders (?) para evitar inyección.
 */
const express = require('express');
const app = express();
const mysql = require('mysql2'); // usar mysql2
const conn = mysql.createPool({ host: 'localhost', user: 'appuser', password: process.env.DB_PASS, database: 'demo' });

function isSafeUsername(u) {
  return typeof u === 'string' && u.length > 0 && u.length <= 50 && /^[a-zA-Z0-9_.-]+$/.test(u);
}

app.get('/user', (req, res) => {
  const username = req.query.username;
  if (!isSafeUsername(username)) return res.status(400).json({ error: 'username inválido' });

  // Parametrizado ✅
  conn.execute("SELECT * FROM users WHERE username = ?", [username], (err, rows) => {
    if (err) return res.status(500).send('Error DB');
    res.json(rows);
  });
});

app.listen(3000, () => console.log('Servidor seguro en http://localhost:3000'));
