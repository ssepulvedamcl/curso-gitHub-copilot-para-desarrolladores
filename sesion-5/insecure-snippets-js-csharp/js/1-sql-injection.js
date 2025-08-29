// ⚠️ SQL Injection inseguro: concatenación de input del usuario
const userInput = "1; DROP TABLE users;";
const query = "SELECT * FROM users WHERE id = " + userInput;