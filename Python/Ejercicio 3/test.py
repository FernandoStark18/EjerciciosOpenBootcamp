import random
import tkinter
from tkinter import ttk


colores = ['blue', 'red', 'yellow', 'purple', 'green', 'black']

window = tkinter.Tk()

for x in range(500):
    color = random.randint(0, len(colores) - 1)
    color2 = random.randint(0, len(colores)- 1)
    label = tkinter.Label(window, text="", bg=colores[color], fg=colores[color2], padx=random.randint(0,20), pady=random.randint(0,10))
    label.place(x=random.randint(0,300), y=random.randint(0,300))
window.mainloop()