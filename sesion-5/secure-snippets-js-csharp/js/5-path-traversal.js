/**
 * ✅ SEGURO: Validación de rutas y restricción a un directorio base
 */
const express = require('express');
const fs = require('fs');
const path = require('path');
const app = express();

const BASE_DIR = path.join(__dirname, 'files'); // restringido a carpeta files

app.get('/read', (req, res) => {
  const filename = path.basename(req.query.file || "");
  const filePath = path.join(BASE_DIR, filename);
  try {
    const content = fs.readFileSync(filePath, 'utf8');
    res.type('text/plain').send(content);
  } catch (e) {
    res.status(404).send('No encontrado');
  }
});

app.listen(3002, () => console.log('Servidor seguro en :3002'));
