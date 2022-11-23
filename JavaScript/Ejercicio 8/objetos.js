/*
Crea un archivo llamado objetos.js que contenga las siguientes líneas
- Un objeto con tus datos personales (nombre, apellido, edad, altura, eresDesarrollador)
- Una variable que obtenga tu edad a partir del objeto anterior
- Una lista que contenga el objeto con tus datos personales y un nuevo objeto con los datos personales de tus dos mejores amig@s
- Una nueva lista con los objetos de la lista anterior ordenados por edad, de mayor a menor
*/

const objMe = {
    nombre: "Fernando",
    apellido: "Espericueta",
    edad: 22,
    altura: 174,
    eresDesarrollador: true
};
const intMyAge = objMe.edad;
const lstMyBestFriends = [
    { nombre: "Víctor", apellido: "Gómez", edad: 23, altura: 182, eresDesarrollador: false }, 
    { nombre: "Bryant", apellido: "Ramos", edad: 21, altura: 177, eresDesarrollador: false }
];
const lstData = [objMe, ...lstMyBestFriends];
const lstDataOrederedByAge = lstData.sort((a, b) => b.edad - a.edad);

console.log(objMe);
console.log(intMyAge);
console.log(lstData);
console.log(lstDataOrederedByAge);