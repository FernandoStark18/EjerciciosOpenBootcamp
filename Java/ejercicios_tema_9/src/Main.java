/*
Crea una clase Persona con las siguientes variables:
 * La edad
 * El nombre
 * El teléfono
- Una vez creada la clase, crea una nueva clase Cliente que herede de Persona, esta nueva clase tendrá la variable
  credito solo para esa clase.
- Crea ahora un objeto de la clase Cliente que debe tener como propiedades la edad, el telefono, el nombre y el credito,
  tienes que darles valor y mostrarlas por pantalla.
- Una vez hecho esto, haz lo mismo con la clase Trabajador que herede de Persona, y con una variable salario que solo
  tenga la clase Trabajador.
*/

public class Main {
    public static void main(String[] args) {
        Cliente cliente = new Cliente();
        Trabajador trabajador = new Trabajador();

        cliente.setEdad(32);
        cliente.setNombre("Eduardo");
        cliente.setTelefono("323 1684 75 92");
        cliente.setCredito(2499);

        System.out.println("***** Cliente *****");
        System.out.println("Edad: " + cliente.getEdad());
        System.out.println("Nombre: " + cliente.getNombre());
        System.out.println("Teléfono: " + cliente.getTelefono());
        System.out.println("Crédito: " + cliente.getCredito() + "\n");

        trabajador.setEdad(43);
        trabajador.setNombre("Francisco");
        trabajador.setTelefono("783 3457 14 36");
        trabajador.setSalario(4300);

        System.out.println("***** Trabajador *****");
        System.out.println("Edad: " + trabajador.getEdad());
        System.out.println("Nombre: " + trabajador.getNombre());
        System.out.println("Teléfono: " + trabajador.getTelefono());
        System.out.println("Salario: " + trabajador.getSalario());
    }
}

class Persona {
    private int edad;
    private String nombre;
    private String telefono;

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public int getEdad() {
        return edad;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return nombre;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getTelefono() {
        return telefono;
    }
}

class Cliente extends Persona {
    private int credito;

    public void setCredito(int credito) {
        this.credito = credito;
    }

    public int getCredito() {
        return credito;
    }
}

class Trabajador extends Persona {
    private int salario;

    public void setSalario(int salario) {
        this.salario = salario;
    }

    public int getSalario() {
        return salario;
    }
}