/**
 * ✅ SEGURO: Hash de contraseñas con bcrypt
 */
const bcrypt = require('bcrypt');

async function storePassword(user, pass) {
  const hash = await bcrypt.hash(pass, 10);
  console.log(`Almacenando hash bcrypt de ${user}: ${hash}`);
}

storePassword('alice', 'password123');
