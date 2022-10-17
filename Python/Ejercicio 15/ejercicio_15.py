# En este segundo ejercicio, tendréis que crear una interfaz sencilla la cual debe de contener una lista de 
# elementos seleccionables, también debe de tener un label con el texto que queráis.

import tkinter

listaMarcasCoches = ['Ford', 'Chevrolet', 'Chrysler', 'Nissan', 'Honda', 'Mazda', 'Toyota']

window = tkinter.Tk()
    
lista = tkinter.Listbox(window)
for item in listaMarcasCoches:
    lista.insert(tkinter.END, item)
lista.pack()

tkinter.Label(window, text="Lista de marcas de coches").pack()

window.mainloop()