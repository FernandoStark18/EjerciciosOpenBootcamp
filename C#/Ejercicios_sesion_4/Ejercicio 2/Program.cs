/*
Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:

- Reciba al menos un número por consola
- Determine si el número es positivo o negativo
- Presente un contador para cada tipo (positivo y negativo).
- Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
 */

string target = null;
int posCounter = 0, negCounter = 0, zeroCounter = 0, intTarget = 0;

while (posCounter < 3 && negCounter < 3 && zeroCounter < 3)
{
    Console.Write("Ingrese un número: ");
    target = Console.ReadLine();
    intTarget = Convert.ToInt32(target);
    
    if(intTarget > 0)
    {
        posCounter++;
    }
    else if(intTarget < 0)
    {
        negCounter++;
    }
    else { zeroCounter++; }
}

Console.WriteLine($"\nPositivos: {posCounter}\nNegativos: {negCounter}\nCeros: {zeroCounter}");