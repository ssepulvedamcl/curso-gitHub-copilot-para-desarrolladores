/**
 * ✅ SEGURO: Usar variables de entorno
 */
require('dotenv').config();

const API_KEY = process.env.API_KEY;
const DB_PASSWORD = process.env.DB_PASSWORD;

function connect() {
  console.log("Conectando con API_KEY:", API_KEY ? "OK" : "No definida");
}
connect();
