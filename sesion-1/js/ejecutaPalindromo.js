const { esPalindromo } = require('./esPalindromo');

const palabras = [
  'Anita lava la tina',
  'reconocer',
  'Hola mundo',
  'oso',
  'palindromo'
];

palabras.forEach(palabra => {
  const resultado = esPalindromo(palabra) ? 'es palíndromo' : 'no es palíndromo';
  console.log(`'${palabra}' ${resultado}`);
});
