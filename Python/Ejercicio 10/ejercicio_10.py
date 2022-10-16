# En este ejercicio, tendréis que crear un archivo py donde creéis un archivo txt, lo abráis y escribáis dentro del archivo. 
# Para ello, tendréis que acceder dos veces al archivo creado.

f = open("ejercicio_10.txt", 'w')
f.write("Hola\n")
f.close()

f = open("ejercicio_10.txt", 'a+')
f.write("Mi nombre es Fernando")
f.close()