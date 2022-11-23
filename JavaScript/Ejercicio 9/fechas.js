/*
Crea un archivo llamado fechas.js que contenga las siguientes líneas
- La fecha de hoy
- La fecha de tu nacimiento
- Un variable que indique si hoy es más tarde (>) que la fecha de tu nacimiento
- Una variable que contenga el día de tu nacimiento
- Una variable que contenga el mes de tu nacimiento (recuerda que Enero es mes 0)
- Una variable que contenga el año de tu nacimiento (con 4 dígitos)
*/

const today = new Date();
const myBirthday = new Date('September 5, 2000');
const isLater = (today > myBirthday);
const myBirthdayDay = myBirthday.getDate();
const myBirthdayMonth = myBirthday.getMonth();
const myBirthdayYear = myBirthday.getFullYear();

console.log(today);
console.log(myBirthday);
console.log(isLater);
console.log(myBirthdayDay);
console.log(myBirthdayMonth + 1);
console.log(myBirthdayYear);