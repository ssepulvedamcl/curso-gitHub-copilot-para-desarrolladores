/**
 * ✅ Mitigación: Codificación/escape de salida (XSS)
 * - Mejor usar motor de plantillas que escape por defecto.
 */
const express = require('express');
const app = express();

function escapeHtml(str='') {
  return String(str)
    .replace(/&/g, '&amp;')
    .replace(/</g, '&lt;')
    .replace(/>/g, '&gt;')
    .replace(/"/g, '&quot;')
    .replace(/'/g, '&#39;');
}

app.get('/hello', (req, res) => {
  const name = escapeHtml(req.query.name || 'invitado');
  res.send(`<h1>Hola ${name}</h1>`);
});

app.listen(3003, () => console.log('Servidor XSS mitigado en :3003'));
