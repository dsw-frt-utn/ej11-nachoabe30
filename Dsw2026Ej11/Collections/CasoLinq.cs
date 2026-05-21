using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private readonly List<Libro> _libros;
    
    //Constructor de la lista libros
    public CasoLinq()
    {
        _libros = Libro.CrearLista();
    }
    
    //Obtener el primer libro
    public Libro? GetPrimero()
    {
        return _libros.FirstOrDefault();
    }
    
    //Obtener Ultimo Libro
    public Libro? GetUltimo()
    {
        return _libros.LastOrDefault();
    }
    
    //Obtner la suma de precios 
    public decimal GetTotalPrecios()
    {
        return _libros.Sum(l => l.Precio);
    }
    
    //Obtener el promedio de precios
    public decimal GetPromedioPrecios()
    {
        return _libros.Average(l => l.Precio);
    }
    
    //Obtener la lista de libros con Id mayor a 15
    public List<Libro> GetListaById()
    {
        return _libros.Where(l => l.Id > 15).ToList();
    }
    
    //Obtener una lista de cada libro con su título y precio en formato moneda 
    public List<string> GetLibros()
    {
        return _libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
    }
    
    //Obtener el libro con el precio mas alto
    public Libro? GetMayorPrecio()
    {
        return _libros.OrderByDescending(l => l.Precio).FirstOrDefault();
    }
    
    //Obtener el libro con el precio mas bajo
    public Libro? GetMenorPrecio()
    {
        return _libros.OrderBy(l => l.Precio).FirstOrDefault();
    }
    
    //Obtener libros cuyo precio sea mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();
        return _libros.Where(l => l.Precio > promedio).ToList();
    }
    
    //Obtener los libros ordenados por título de forma descendente
    public List<Libro> GetLibrosOrdenadosPorTituloDescendente()
    {
        return _libros.OrderByDescending(l => l.Precio).ToList();
    }
    
    
}
