# En este segundo ejercicio, tendréis que crear un programa que tenga una clase llamada Alumno que tenga como atributos su nombre y su nota. 
# Deberéis de definir los métodos para inicializar sus atributos, imprimirlos y mostrar un mensaje con el resultado de la nota y si ha 
# aprobado o no.

class Alumno:
    def inicializar(self, nombre, nota):
        self.nombre = nombre
        self.nota = nota

    def mostrarAtributos(self):
        print("Nombre:", self.nombre)
        print("Nota:", self.nota)

    def resultado(self):
        resultado = "El alumno ha reprobado" if self.nota < 5 else "El alumno ha aprobado"
        print(resultado)

alumno1 = Alumno()
alumno2 = Alumno()

alumno1.inicializar("Fernando", 8)
alumno2.inicializar("Víctor", 3)

alumno1.mostrarAtributos()
alumno1.resultado()

alumno2.mostrarAtributos()
alumno2.resultado()