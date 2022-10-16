# En este segundo ejercicio, tenéis que crear una aplicación que obtendrá los elementos impares de una lista pasada por parámetro con 
# filter y realizará una suma de todos estos elementos obtenidos mediante reduce.
from functools import reduce

numeros = list(range(10))

numerosPares = list(filter(lambda numero: numero % 2 == 0, numeros))
sumaPares = reduce(lambda a, b: a + b, numerosPares)

print(f'Números pares: {numerosPares}')
print(f'Suma de números pares: {sumaPares}')