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
    // Listar materias
    public void Listar()   // Metodo para listar todas las materias de la lista
    {
        if (cabeza == null) // Si la lista esta vacia, se informa al usuario
        {
            Console.WriteLine("No hay materias.");
            return;
        }

        NodoMateria actual = cabeza;

        while (actual != null) // Se recorre toda la lista mostrando cada materia
        {
            Console.WriteLine("Materia: " + actual.Nombre + " - Nota: " + actual.Nota);
            actual = actual.Siguiente;
        }
    }

    // Modificar nota
    public void Modificar(string nombre, double nuevaNota)  // Metodo para modificar la nota de una materia existente
    {
        NodoMateria actual = cabeza;

        while (actual != null)    // Se recorre la lista buscando la materia
        {
            if (actual.Nombre.ToLower() == nombre.ToLower())  // Comparacion sin importar mayusculas o minusculas
            {
               
               // Se actualiza la nota
                actual.Nota = nuevaNota;  
                Console.WriteLine("Nota actualizada.");
                return;
            }

            actual = actual.Siguiente;
        }

        Console.WriteLine("Materia no encontrada."); // Si no se encontro la materia
    }
    // Eliminar materia
    public void Eliminar(string nombre)  // Metodo para eliminar una materia de la lista
    {
        if (cabeza == null)  // Verifica si la lista esta vacia
        {
            Console.WriteLine("Lista vacia.");
            return;
        }


// Si la materia que se va a eliminar esta en la cabeza
        if (cabeza.Nombre.ToLower() == nombre.ToLower()) 
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("Materia eliminada.");
            return;
        }

        NodoMateria actual = cabeza;

        while (actual.Siguiente != null)   // Se recorre la lista buscando el nodo anterior al que se desea eliminar
        {
            if (actual.Siguiente.Nombre.ToLower() == nombre.ToLower())
            {
                
                // Se salta el nodo a eliminar
                actual.Siguiente = actual.Siguiente.Siguiente;
                Console.WriteLine("Materia eliminada.");
                return;
            }

            actual = actual.Siguiente;
        }
// Si no se encontro la materia
        Console.WriteLine("Materia no encontrada.");
    }
}