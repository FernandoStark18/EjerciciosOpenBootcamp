/*
Crea un archivo JS que contenga las siguientes líneas
- Una variable que contenga tu altura en centímetros (entero)
- Una variable que contenga tu altura en metros (número de coma flotante)
- Una variable que contenga tu peso en kilogramos (número de coma flotante)
- Una variable que contenga tu altura en metros redondeada hacia arriba
- Una variable que contenga tu peso en kilogramos redondeado hacia abajo
- Una variable que contenga si "el máximo valor que se puede obtener en Javascript + 1" es igual al máximo valor que se puede obtener en Javascript
*/

const intHeight = 174;
const fltHeight = 1.74;
const fltWeight = 83.32;
const intRoundedHeight = Math.ceil(fltHeight);
const intRoundedWeight = Math.floor(fltWeight);
const isEqual = (Number.MAX_VALUE + 1 === Number.MAX_VALUE)

console.log(intHeight);
console.log(fltHeight);
console.log(fltWeight);
console.log(intRoundedHeight);
console.log(intRoundedWeight);
console.log(isEqual);