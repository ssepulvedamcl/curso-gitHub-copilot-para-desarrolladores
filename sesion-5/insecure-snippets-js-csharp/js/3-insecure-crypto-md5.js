// ⚠️ Hash inseguro: uso de MD5 para contraseñas

function hashPassword(password) {
  return crypto.createHash('md5').update(password).digest('hex');
}
