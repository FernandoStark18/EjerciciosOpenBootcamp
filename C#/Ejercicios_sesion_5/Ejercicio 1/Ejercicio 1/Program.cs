/*
 Ejercicio 1 - If

Escribe un programa que:
Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.
 */

// Client data
string name, email, cupon;
int intCupon = 0, price = 100, finalPrice = 0;


Console.Write("Ingrese el nombre: ");
name = Console.ReadLine();
Console.Write("Ingrese el email: ");
email = Console.ReadLine();
Console.Write("Ingrese el cupón: ");
cupon = Console.ReadLine();

intCupon = Convert.ToInt32(cupon);

if (intCupon > 0) finalPrice = price - (price * intCupon / 100);
else finalPrice = price;

Console.WriteLine($"Nombre: {name}, email: {email}, Precio final: {finalPrice}");