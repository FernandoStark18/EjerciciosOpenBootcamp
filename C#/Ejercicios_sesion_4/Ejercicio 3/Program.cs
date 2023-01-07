/*
Ejercicio 3 - For

Escribe un programa que realice estos pasos:
Reciba 3 datos:

- ancho
- alto
- relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true
Output:

** **

** **

Input: 3, 4, 1, relleno = false
Output:

***

* *

* *

***
 */

string width = null, height = null, fill = null, repeat = null;
int intWidth = 0, intHeight = 0, intRepeat = 0;
bool blFill = false;

Console.Write("Ingerese el ancho: ");
width = Console.ReadLine();
Console.Write("Ingerese el alto: ");
height = Console.ReadLine();
Console.Write("¿Cuántas repeticiones?: ");
repeat = Console.ReadLine();
Console.Write("¿Con relleno?: ");
fill = Console.ReadLine();

intWidth = Convert.ToInt32(width);
intHeight = Convert.ToInt32(height);
intRepeat = Convert.ToInt32(repeat);

if(fill == "Sí") { blFill= true; }
else { blFill= false; };

for (int j = 0; j < intHeight; j++)
{
    for (int i = 0; i < intRepeat; i++)
    {
        for (int k = 0; k < intWidth; k++)
        {
            if (blFill)
            {
                Console.Write("*");
            }
            else
            {
                if (k == 0 || k == intWidth - 1 || j == 0 || j == intHeight - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
        Console.Write(" ");
    }
    Console.WriteLine("");
}