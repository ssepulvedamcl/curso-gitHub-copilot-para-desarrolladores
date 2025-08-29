/**
 * ✅ Mitigación: Secretos vía variables de entorno (.env) o secret managers
 * - Nunca hardcodear API keys.
 * - Falla rápido si falta un secreto.
 */
require('dotenv').config(); // opcional si usas .env
const API_KEY = process.env.API_KEY;
const DB_PASSWORD = process.env.DB_PASSWORD;
if (!API_KEY || !DB_PASSWORD) {
  throw new Error('Faltan secretos: defina API_KEY y DB_PASSWORD en variables de entorno');
}

function connect() {
  console.log("Conectando con API_KEY (masked):", API_KEY.substring(0,4) + '...');
  // Conectar usando DB_PASSWORD sin loguearla
}
connect();
