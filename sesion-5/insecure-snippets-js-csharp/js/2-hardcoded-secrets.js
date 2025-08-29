// ⚠️ Secretos hardcodeados: API keys en código fuente
// Descripción: Este snippet contiene una API key hardcodeada en el código fuente, lo que puede ser explotado si el código es accesible públicamente.
const apiKey = "12345-ABCDE";  
//general un ejemplo de uso de API
fetch(`https://api.example.com/data?api_key=${apiKey}`)
  .then(response => response.json())
  .then(data => console.log(data)); 