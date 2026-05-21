using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo (int) y el valor el alumno (Alumno)
    private Dictionary<int, Alumno> _alumnos;
    
    // Constructor para inicializar el diccionario en memoria
    public CasoDictionary()
    {
        _alumnos = new Dictionary<int, Alumno>();
    }
    
    //Incluir un método para agregar un alumno al diccionaio
    public bool AgregarAlumno(Alumno alumno)
    {
        return _alumnos.TryAdd(alumno.Id, alumno);
        
    }
    
    //Incluirn método de busqueda de un alumno utilizando la clave
    public Alumno? BuscarPorLegajo(int legajo)
    {
        _alumnos.TryGetValue(legajo, out Alumno? alumnoEncontrado);
        return alumnoEncontrado;
    }
    
    //Incluir metodo para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }
    
    //Incluir metodo de eliminacion de alumno utilizando la clave
    public bool EliminarPorLegajo(int legajo)
    {
        return _alumnos.Remove(legajo);
    }
}


