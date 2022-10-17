from email.policy import default
from django.db import models

class Director(models.Model):
    nombre = models.CharField(max_length = 25, help_text="Ingrese nombre del director")
    apellido = models.CharField(max_length = 50, help_text="Ingrese apellido del director")

    def __str__(self):
        return self.nombre + " " + self.apellido

class Pelicula(models.Model):
    nombre = models.CharField(max_length = 50, help_text="Ingrese nombre del l apelícula")
    director = models.ForeignKey('Director', on_delete=models.CASCADE)
    descripcion = models.TextField()

    def __str__(self):
        return self.nombre