// factorial-break.js -> Este archivo debe calcular el factorial de 10 utilizando un bucle while, una bifurcación if y una sentencia break

let resultado = 1;
let i = 1;

while (true) {
    resultado *= i;

    if (i >= 10) {
        break;
    }

    i++;
}

console.log(resultado);