/*
 Ejercicio 1

 Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. 
 Ej: nombre, apellido, edad, sabe programar, etc.
 */
string name, lastname, age, isDeveloper, message;

Console.Write("Ingrese el nombre: ");
name = Console.ReadLine();
Console.Write("Ingrese el apellido: ");
lastname = Console.ReadLine();
Console.Write("Ingrese la edad: ");
age = Console.ReadLine();
Console.Write("¿Sabe programar?: ");
isDeveloper = Console.ReadLine();

message = "\nSu nombre es " + name + " " + lastname + " tiene " + age + " años y " + isDeveloper + " sabe programar";

Console.WriteLine(message);
