/*
 Ejercicio 2

Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
Coche: puertas, ruedas, marca, ITV vigente
Mesa: peso, largo, material, color
 */

// Coche
int doorNumber = 2, wheelNumber = 4;
string brand = "Chevrolet";
bool isValidITV = true;

if (isValidITV)
    {
        Console.WriteLine("El coche tiene " + doorNumber + ", " + wheelNumber + " ruedas, " + "es de la marca " + brand + " y su ITV se encuentra vigente");
    }
else
    {
        Console.WriteLine("El coche tiene " + doorNumber + ", " + wheelNumber + " ruedas, " + "es de la marca " + brand + " y su ITV se encuentra vencido");
    }

// Mesa
float weight = 10.62f, length = 1.5f;
string material = "Madera", color = "Marrón";

Console.WriteLine("La mesa pesa " + weight + "Kg " + "mide " + length + "m " + "es de " + material + " y es de color " + color);