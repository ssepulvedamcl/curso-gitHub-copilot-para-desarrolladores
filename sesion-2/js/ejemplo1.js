// Función que calcule la suma, promedio, mínimo y máximo de una lista de números
/// Genera documentación para esta función, distingue la cantidad de numeros pares de impares.

/**
 * Calcula estadísticas básicas (suma, promedio, mínimo y máximo) de una lista de números.
 * @param {number[]} numeros - La lista de números a analizar.
 * @returns {Object|null} Un objeto con las estadísticas calculadas o null si la entrada es inválida.
 */

function calcularEstadisticas(numeros) {
    if (!Array.isArray(numeros) || numeros.length === 0) {
        return null;
    }

    let suma = 0;
    let min = numeros[0];
    let max = numeros[0];
    let pares = 0;
    let impares = 0;

    for (let num of numeros) {
        suma += num;
        if (num < min) min = num;
        if (num > max) max = num;
    }

    const promedio = suma / numeros.length;
    numeros.forEach(num => {
        if (num % 2 === 0) {
            pares++;
        } else {
            impares++;
        }
    });
    
    return {
        suma,
        promedio,
        minimo: min,
        maximo: max,
        pares,
        impares
    };
}

// Ejemplo de uso:
const resultado = calcularEstadisticas(["1", "2", 3, 4, 5]);
console.log(resultado);
