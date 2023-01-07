/*
 Ejercicio 3

Operadores Determina los operadores para verificar las siguientes condiciones:
Un número es mayor o igual a 18
Un char es ‘a’
Se cumplen dos conciones a la vez (ambas verdaderas)
Se cumple una de dos condiciones a la vez (una true y otra false)
 */

int number  = 5;
char letter = 'a';

Console.WriteLine(number + " es mayor o igual que 18: " + (number >= 18));
Console.WriteLine("Es " + letter + " un char 'a': " + (letter == 'a'));
Console.WriteLine(number + " es menor o igual que 18 y es " + letter + " un char 'a': " + ((number <= 18) && (letter == 'a')));
Console.WriteLine(number + " es menor o igual que 18 o es " + letter + " un char 'e': " + ((number <= 18) || (letter == 'e')));