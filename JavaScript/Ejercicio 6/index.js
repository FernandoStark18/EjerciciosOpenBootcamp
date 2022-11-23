/*
Crea un archivo JS que contenga las siguientes líneas
- Una variable que contenga la lista de la compra (mínimo 5 elementos)
- Modifica la lista de la compra y añádele "Aceite de Girasol"
- Vuelve a modificar la lista de la compra eliminando "Aceite de Girasol"
- Una lista de tus 3 películas favoritas (objetos con propiedades: titulo, director, fecha)
- Una nueva lista que contenga las películas posteriores al 1 de enero de 2010 (utilizando filter)
- Una nueva lista que contenga los directores de la lista de películas original (utilizando map)
- Una nueva lista que contenga los títulos de la lista de películas original (utilizando map)
- Una nueva lista que concatene la lista de directores y la lista de los títulos (utilizando concat)
- Una nueva lista que concatene la lista de directores y la lista de los títulos (utilizando el factor de propagación)
*/

const lstShoppingList = ["Pollo", "Avena", "Leche", "Café", "Verduras"];
lstShoppingList.push("Aceite de Girasol");
lstShoppingList.pop();
const lstFavMovies = [
    {titulo: "Shrek 2", director: "Mike Myers", anyo: "2004"},
    {titulo: "Spiderman 2", director: "Sam Raimi", anyo: "2004"},
    {titulo: "Spider-Man No Way Home", director: "Jon Watts", anyo: "2021"}
];
const lstMoviesAfter2010 = lstFavMovies.filter(valor => valor.anyo > 2010);
const lstDirectors = lstFavMovies.map(valor => valor.director);
const lstMovies = lstFavMovies.map(valor => valor.titulo);
const lstDirectorsAndMovies = lstDirectors.concat(lstMovies);
const lstDirectorsAndMoviesProp = [...lstDirectors, ...lstMovies];

console.log(lstShoppingList);
console.log(lstFavMovies);
console.log(lstMoviesAfter2010);
console.log(lstDirectors);
console.log(lstMovies);
console.log(lstDirectorsAndMovies);
console.log(lstDirectorsAndMoviesProp);