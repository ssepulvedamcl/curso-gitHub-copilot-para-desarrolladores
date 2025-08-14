const assert = require('assert');
const { esPalindromo } = require('./esPalindromo');

console.log(esPalindromo('Anita lava la tina')); // true
console.log(esPalindromo('Hola mundo')); // false

assert.strictEqual(esPalindromo('Anita lava la tina'), true);
assert.strictEqual(esPalindromo('Hola mundo'), false);
console.log('Todos los tests pasaron.');
