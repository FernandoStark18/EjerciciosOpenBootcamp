/*
 Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y 
pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */

string input;

Console.WriteLine("-- Lista de leguajes: C#, Java, C++ --");
Console.Write("Seleccione un lenguaje con 1, 2,y 3: ");
input = Console.ReadLine();

switch (input)
{
    case "1": Console.WriteLine("Hola, mundo"); break;
    case "2": Console.WriteLine("Java"); break;
    case "3": Console.WriteLine("C++"); break;
    default: Console.WriteLine("Opción desconocida"); break;
}