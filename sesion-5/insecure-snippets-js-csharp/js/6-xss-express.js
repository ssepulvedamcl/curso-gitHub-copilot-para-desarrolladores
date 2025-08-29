// ⚠️ XSS reflejado: salida sin escape en Express.js
// Descripción: Este snippet muestra cómo una aplicación Express.js puede ser vulnerable a ataques XSS reflejados si no se escapan correctamente los datos de entrada del usuario antes de enviarlos en la respuesta.

app.get('/search', (req, res) => {
  const query = req.query.q;
  res.send(`Resultados de búsqueda para: ${query}`);
});
