using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //Creación de campo de lista de ALumnos
    private List<Alumno> _alumnos;

    //Constructor que inicializa la lista
    public CasoList()
    {
        _alumnos = new List<Alumno>();
    }

    //Incluir metodo para agregr alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    //Incluir metodo para retornar la lista
    public List<Alumno> ObtenerLista()
    {
        return _alumnos;
    }

    //Incluir metodo para buscar alumno x nombre
    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.Find( a => string.Equals(a.Nombre, nombre, StringComparison.OrdinalIgnoreCase));
    }

    //Incluir metodo para eliminar nombre de alumno
    public bool EliminarALumno(Alumno alumno)
    {
        return _alumnos.Remove(alumno);
    }

    //Incluir metodo para eliminar un alumno en determinada posición
    public void EliminarEnPoisición(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
    }

}
