/*
Crea un nuevo proyecto de Node
- Instala la dependencia ESLint (https://www.npmjs.com/package/eslint)
- Duplica el archivo del ejercicio de la sesión 04-Textos
- Utiliza los tres estilos de comillas de forma alterna (comillas simples, dobles, backticks)
- Crea el fichero .eslintrc.json
- Cambia la configuración de ESLint para que la versión ecmaVersion sea "latest"
- Cambia la configuración de ESLint para que muestre un error cada vez que las comillas no sean dobles
- Crea un script en el package.json para corregir automáticamente todos los errores
- Ejecuta el script a través del terminal
*/

const strMyName = "Fernando";
const strMyLastName = "Espericueta";
const strStudent = strMyName.concat(" ", strMyLastName);
const strStudentUpper = strStudent.toUpperCase();
const strStudentLower = strStudent.toLowerCase();
const strStudentLength = strStudent.length;
const strFirstChar = strMyName.charAt(0);
const strLastChar = strMyLastName.charAt(strMyLastName.length - 1);
const strSpacesFree = strStudent.replace(" ", "");
const containsTheName = strStudent.includes(strMyName);

console.log(strMyName);
console.log(strMyLastName);
console.log(strStudent);
console.log(strStudentUpper);
console.log(strStudentLower);
console.log(strStudentLength);
console.log(strFirstChar);
console.log(strLastChar);
console.log(strSpacesFree);
console.log(containsTheName);