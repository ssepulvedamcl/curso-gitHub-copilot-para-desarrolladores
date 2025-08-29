/**
 * ✅ Mitigación: Normalizar ruta y restringir a un directorio base
 * - Rechaza rutas que escapen del baseDir.
 */
const express = require('express');
const fs = require('fs');
const path = require('path');
const app = express();

const baseDir = path.resolve(__dirname, 'public'); // solo servir desde /public

function safeJoin(base, target) {
  const resolved = path.resolve(base, target);
  if (!resolved.startsWith(base + path.sep)) throw new Error('Acceso denegado');
  return resolved;
}

app.get('/read', (req, res) => {
  try {
    const filename = req.query.file;
    if (typeof filename !== 'string' || filename.includes('\0')) throw new Error('Nombre inválido');
    const full = safeJoin(baseDir, filename);
    const content = fs.readFileSync(full, 'utf8');
    res.type('text/plain').send(content);
  } catch (e) {
    res.status(400).send('Solicitud inválida');
  }
});

app.listen(3002, () => console.log('Servidor seguro path en :3002'));
