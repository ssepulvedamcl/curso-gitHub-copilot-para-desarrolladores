/**
 * ✅ SEGURO: Eliminar eval y usar operaciones controladas
 */
const http = require('http');
const url = require('url');

http.createServer((req, res) => {
  const q = url.parse(req.url, true).query;
  if (q && q.code) {
    if(/^[0-9+\-*/ ]+$/.test(q.code)) {
      try {
        const result = Function('"use strict";return (' + q.code + ')')();
        res.end('Resultado: ' + String(result));
      } catch(e) {
        res.end('Error');
      }
    } else {
      res.end('Entrada no permitida');
    }
  } else {
    res.end('Pase ?code=1+2');
  }
}).listen(3001, () => console.log('Servidor seguro en :3001'));
