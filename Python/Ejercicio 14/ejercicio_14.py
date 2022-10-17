# - En este ejercicio tenéis que crear una lista de RadioButton que muestre la opción que se ha seleccionado 
# y que contenga un botón de reinicio para que deje todo como al principio.
# - Al principio no tiene que haber una opción seleccionada.
import tkinter

window = tkinter.Tk()

def reiniciar():
    opcion.set(None)
    lblOpcionSeleccionada.config(text="")

def seleccionada():
    lblOpcionSeleccionada.config(text=f'{(opcion.get())}')

opcion = tkinter.StringVar()
opcion.set(None)

tkinter.Label(window, text="Marcas de coches").pack()
tkinter.Radiobutton(window, text="Ford", value="Ford", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)
tkinter.Radiobutton(window, text="Chevrolet", value="Chevrolet", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)
tkinter.Radiobutton(window, text="Chrysler", value="Chrysler", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)
tkinter.Radiobutton(window, text="Nissan", value="Nissan", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)
tkinter.Radiobutton(window, text="Honda", value="Honda", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)
tkinter.Radiobutton(window, text="Mazda", value="Mazda", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)
tkinter.Radiobutton(window, text="Toyota", value="Toyota", variable=opcion, command=seleccionada).pack(anchor=tkinter.W)

lblOpcionSeleccionada =  tkinter.Label(window)
lblOpcionSeleccionada.pack()

tkinter.Button(window, text="Reiniciar", command=reiniciar).pack()

window.mainloop()