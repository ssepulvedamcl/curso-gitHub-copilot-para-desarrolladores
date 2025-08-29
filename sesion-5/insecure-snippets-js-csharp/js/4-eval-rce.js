// ⚠️ RCE: uso inseguro de eval() con entrada de usuario
const userInput = "2 + 2";
const result = eval(userInput);