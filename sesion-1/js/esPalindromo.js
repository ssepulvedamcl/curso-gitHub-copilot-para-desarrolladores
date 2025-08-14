
function esPalindromo(palabra) {
    // Eliminar espacios y convertir a minúsculas
    palabra = palabra.replace(/\s+/g, '').toLowerCase();
    // Invertir la palabra
    var palabraInvertida = palabra.split('').reverse().join('');
    // Comparar la palabra original con la invertida
    return palabra === palabraInvertida;
}

module.exports = { esPalindromo };