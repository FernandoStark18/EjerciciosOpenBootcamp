# En este segundo ejercicio, tendréis que crear un archivo py y dentro crearéis una clase Vehículo, haréis un objeto de ella, lo 
# guardaréis en un archivo y luego lo cargamos.
import pickle

class Vehiculo:
    modelo = ""
    Cilindrada = 0.0
    marca = ""

    def __init__(self, modelo, cilindrada, marca):
        self.modelo = modelo
        self.Cilindrada = cilindrada
        self.marca = marca

    def getMarca(self):
        return self.marca

# v1 = Vehiculo("2017", 1.2, "Kia")
# vehiculo = open("Vehiculo.bin", 'wb')

# pickle.dump(v1, vehiculo)

f = open("Vehiculo.bin", 'rb')
vehiculo = pickle.load(f)
f.close()

print(vehiculo.getMarca())