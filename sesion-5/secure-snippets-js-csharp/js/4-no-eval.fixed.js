/**
 * ✅ Mitigación: Evitar eval; whitelists/parse seguro
 * Ejemplo simple: solo operaciones permitidas con validación explícita.
 */
const http = require('http');
const url = require('url');

function safeCalc(op, a, b) {
  const A = Number(a), B = Number(b);
  if (!Number.isFinite(A) || !Number.isFinite(B)) throw new Error('Inputs no numéricos');
  switch (op) {
    case 'add': return A + B;
    case 'sub': return A - B;
    case 'mul': return A * B;
    case 'div': return B === 0 ? Infinity : A / B;
    default: throw new Error('Operación no permitida');
  }
}

http.createServer((req, res) => {
  const q = url.parse(req.url, true).query;
  try {
    const result = safeCalc(q.op, q.a, q.b);
    res.end(String(result));
  } catch (e) {
    res.statusCode = 400;
    res.end('Error: ' + e.message);
  }
}).listen(3001, () => console.log('Servidor seguro en :3001'));
