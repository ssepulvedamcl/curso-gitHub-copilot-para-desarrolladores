// ⚠️ Path Traversal: leer archivos con rutas no validadas
const fs = require('fs');

const filePath = "../config.json";
fs.readFile(filePath, 'utf8', (err, data) => {
  if (err) {
    console.error(err);
    return;
  }
  console.log(data);
});
