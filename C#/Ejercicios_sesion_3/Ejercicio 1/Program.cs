/*
 Ejercicio 1

 Crea una estructura de datos para un cliente con estos campos:
 Nombre completo
 Teléfono
 Dirección
 Email
 Si es nuevo cliente
 Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */
Cliente Cliente_1 = new Cliente("Fernando Espericueta", "316 186 62 41", "Emiliano Zapata #85", "cliente1@correo.com", true);
Console.WriteLine(Cliente_1);
public struct Cliente
{
    public Cliente(string fullName, string phone, string address, string email, bool isNew)
    {
        FullName = fullName;
        Phone = phone;
        Address = address;
        Email = email;
        IsNew = isNew;
    }

    public string FullName { get; }
    public string Phone { get; }
    public string Address { get; }
    public string Email { get; }
    public bool IsNew { get; }

    public override string ToString() => $"({FullName}, {Phone}, {Address}, {Email}, {IsNew})";
}