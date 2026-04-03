using System;


// Esta clase representa una lista enlazada de materias
// Cada elemento de la lista es un NodoMateria
public class ListaMaterias
{
    
    private NodoMateria cabeza;// Apuntador al primer nodo de la lista
    // Si es null, la lista esta vacia

    public ListaMaterias() // Constructor de la lista
    // Inicializa la lista vacia
    {
        cabeza = null;
    }
    // Verificar si ya existe una materia
    public bool Existe(string nombre) // Metodo para verificar si ya existe una materia en la lista
    // Recorre toda la lista buscando por nombre
    {
        NodoMateria actual = cabeza;

        while (actual != null)   // Se recorre la lista nodo por nodo
        {
            if (actual.Nombre.ToLower() == nombre.ToLower()) // Se compara el nombre ignorando mayusculas y minusculas
                return true;

            actual = actual.Siguiente;
        }

        return false;  // Si no se encontro la materia, retorna false
    }

    // Agregar materia
    public void Agregar(string nombre, double nota) // Metodo para agregar una nueva materia a la lista
    {
        if (Existe(nombre)) // Primero se valida que la materia no exista
        {
            Console.WriteLine("La materia ya existe.");
            return;
        }

        NodoMateria nuevo = new NodoMateria(nombre, nota);  // Se crea un nuevo nodo con los datos recibidos

        if (cabeza == null) // Si la lista esta vacia, el nuevo nodo pasa a ser la cabeza
        {
            cabeza = nuevo;
        }
        else
        {
            NodoMateria actual = cabeza;  // Si la lista no esta vacia, se recorre hasta el ultimo nodo
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;   // Se enlaza el nuevo nodo al final de la lista
        }

        Console.WriteLine("Materia agregada correctamente.");
    }