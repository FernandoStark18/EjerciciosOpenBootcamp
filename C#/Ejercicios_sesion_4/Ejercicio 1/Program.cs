/*
Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
 */

string target = null;
int i = 0, intTarget = 0;

Console.WriteLine("--- TABLA DE MULTIPLICAR DEL 1 AL 10 ---");
Console.Write("Ingrese el número: ");

target = Console.ReadLine();
intTarget = Convert.ToInt32(target);

Console.WriteLine($"\n --- TABLA DEL {target} ---");

while(i < 10)
{
    i++;
    Console.WriteLine($"{target} x {i} = {i * intTarget}");
}