# Escribe una función que pueda decirte si un año (número entero) es bisiesto o no.

def isBisiesto(anio):
    if anio % 4 == 0 and (anio % 100 != 0 or anio % 400 == 0):
        return True
    else:
        return False

resultado = "Es bisiesto" if isBisiesto(2024) else "No es bisiesto"
print(resultado)