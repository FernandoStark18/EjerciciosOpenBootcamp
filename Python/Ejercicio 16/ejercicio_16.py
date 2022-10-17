import sqlite3
from unittest import result

def buscarAlumno(nombre):
    conn = sqlite3.connect(".\Python\Alumnos.db")
    cursor = conn.cursor()

    row = list(cursor.execute(f'SELECT * FROM alumnos WHERE nombre = "{nombre}"'))
    
    print("------------------------------\nLos datos del alumno son:")
    print(f'ID: {row[0][0]}\nNombre: {row[0][1]}\nApellido: {row[0][2]}')

    cursor.close()
    conn.close()

def main():
    nombre =  input("Ingrese nombre del alumno: ")
    buscarAlumno(nombre)

if __name__ == "__main__":
    main()