/**
 * ✅ Mitigación: Hash seguro con bcrypt (o Argon2/scrypt)
 * - Incluye salt y factor de costo.
 */
const bcrypt = require('bcryptjs'); // o 'bcrypt'
const COST = 12;

async function storePassword(user, pass) {
  const hash = await bcrypt.hash(pass, COST);
  console.log(`Guardar para ${user}: ${hash}`); // almacena hash, no el pass
}

async function verifyPassword(user, pass, storedHash) {
  return bcrypt.compare(pass, storedHash);
}

storePassword('alice', 'password123');
