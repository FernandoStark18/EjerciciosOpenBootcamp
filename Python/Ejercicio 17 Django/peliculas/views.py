from django.shortcuts import render
from .models import Director, Pelicula

def index(request):

    num_peliculas = Pelicula.objects.all().count()
    num_directores = Director.objects.all().count()

    return render(
        request, 
        'index.html',
        context={
            'num_peliculas': num_peliculas,
            'num_directores': num_directores
        }
     )
