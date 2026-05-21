using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    
    public static void EjemploList()
    {
        Console.WriteLine("\nEjemplo List");
        CasoList casoList = new CasoList();
        
        //Agregación de 3 alumnos
        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Luis", 9.2);
        Alumno a3 = new Alumno(3, "Maria", 7.5);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);
        
        
        //Listar por consola a los alumnos
        Console.WriteLine("\nLista Original:");
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }
        
        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\nBuscamos a Luis: ");
        Alumno? encontrado = casoList.BuscarPorNombre("Luis");
        Console.WriteLine(encontrado != null? encontrado.ToString(): "No existe Luis");
        
        //Buscar por nombre un alumno que no exista y mostrar por consola el texto
        Console.WriteLine("\nBuscamos a Carlos: ");
        Alumno? noEncontrado= casoList.BuscarPorNombre("Carlos");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe Carlos" );
        
        //Eliminar a un alumno y listar por consola a los restantes
        Console.WriteLine("\nEliminando a María");
        casoList.EliminarALumno(a3);
        
        //Actualización de lista de los alumnos
        foreach (var alumno in casoList.ObtenerLista() )
        {
            Console.WriteLine(alumno);
        }
        
        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\nEliminando el primer alumno");
        casoList.EliminarEnPoisición(0);
        
        //Actualizamos lista 
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("--------------------------------\n");
    }
    
    //------------------------------------------------------------------------------------------------------------------

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    
    public static void EjemploDictionary()
    {
        Console.WriteLine("\nEjemplo Dictionary");
        CasoDictionary casoDict = new CasoDictionary();
        Alumno a1 = new Alumno(101, "Pablo", 8.5);
        Alumno a2 = new Alumno(102, "Carolina", 9.2);
        Alumno a3 = new Alumno(103, "Ignacio", 7.5);
        
        casoDict.AgregarAlumno(a1);
        casoDict.AgregarAlumno(a2);
        casoDict.AgregarAlumno(a3);
        
        //Listar por consola los alumnos
        Console.WriteLine("\nDiccionario original: ");
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave: {kvp.Key} -> Valor: {kvp.Value}");
        }
        
        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\nBuscamos legajo 102");
        Alumno? encontrado = casoDict.BuscarPorLegajo(102);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe legajo");
        
        //Buscar un alumno por clave, pero no existente
        Console.WriteLine("\nBuscando legajo 999: ");
        Alumno? noEncontrado = casoDict.BuscarPorLegajo(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe legajo");
        
        //Eliminar alumno por clave y listar los alumnos
        Console.WriteLine("\nEliminar Alumno");
        casoDict.EliminarPorLegajo(101);
        
        //Listar alumnos en lista actualizada
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Clave: {kvp.Key} -> Valor: {kvp.Value}");
        }
        Console.WriteLine("--------------------------------------\n");
    }
    
    
    //------------------------------------------------------------------------------------------------------------------

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("\nObtener metodos");
        CasoLinq casoLinq = new CasoLinq();
        
        //Primer Libro
        Console.WriteLine($"1. Primer libro: {casoLinq.GetPrimero()?.Titulo}");
        
        //Segundo Libro
        Console.WriteLine($"2. Último libro: {casoLinq.GetUltimo()?.Titulo}");
        
        //Suma de precios
        Console.WriteLine($"3. Suma total de precios: {casoLinq.GetTotalPrecios():C}");
        
        //Promedio de precios
        Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios():C}");
        
        //Lista de libros con ID > 15
        Console.WriteLine("\n5. Libros con ID > 15:");
        foreach (var libro in casoLinq.GetListaById())
        {
            Console.WriteLine($"   - {libro.Titulo} (ID: {libro.Id})");
        }
        
        //Obtener titulo de lirbos formato moneda
        Console.WriteLine("\n6. Lista en formato moneda:");
        foreach (var item in casoLinq.GetLibros())
        {
            Console.WriteLine($"   {item}");
        }
        
        //Obtener libro de precio mas alto
        Console.WriteLine($"\n7. Libro más caro: {casoLinq.GetMayorPrecio()?.Titulo} ({casoLinq.GetMayorPrecio()?.Precio:C})");
        
        //Obtener el libro con el precio mas bajo
        Console.WriteLine($"8. Libro más barato: {casoLinq.GetMenorPrecio()?.Titulo} ({casoLinq.GetMenorPrecio()?.Precio:C})");
        
        //Obtener los libros cuyo precio sea mayor al promedio
        Console.WriteLine("\n9. Libros por encima del promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"   - {libro.Titulo} ({libro.Precio:C})");
        }
        
        //Obtener los libros ordenados por titulo de forma descendente
        Console.WriteLine("\n10. Libros ordenados (Z-A):");
        foreach (var libro in casoLinq.GetLibrosOrdenadosPorTituloDescendente())
        {
            Console.WriteLine($"   - {libro.Titulo}");
        }
        Console.WriteLine("--------------------\n");
    }
}
