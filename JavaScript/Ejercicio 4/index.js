/*
Crea un archivo JS que contenga las siguientes líneas
- Una cadena de texto con tu Nombre
- Otra cadena de texto con tu Apellido
- Una cadena de texto que se llame "estudiante" concatenando tu Nombre y tu Apellido con un espacio entre medias
- Una cadena de texto que se llame "estudianteMayus" que contenga la cadena estudiante pero todo en mayúsculas
- Una cadena de texto que se llame "estudianteMinus" que contenga la cadena estudiante pero todo en minúsculas
- Una variable que contenga el número de letras de la cadena "estudiante" contando los espacios
- Una variable que contenga la primera letra del Nombre
- Otra variable que contenga la última letra del Apellido
- Una cadena de texto que elimine los espacios de la variable "estudiante"
- Una variable booleana que diga si el Nombre está contenido en la variable "estudiante" 
*/

const strMyName = "Fernando";
const strMyLastName = "Espericueta";
const strStudent = strMyName.concat(" ", strMyLastName);
const strStudentUpper = strStudent.toUpperCase();
const strStudentLower = strStudent.toLowerCase();
const strStudentLength = strStudent.length
const strFirstChar = strMyName.charAt(0);
const strLastChar = strMyLastName.charAt(strMyLastName.length - 1)
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