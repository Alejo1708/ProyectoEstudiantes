using System;


// Esta clase representa una lista enlazada de estudiantes
// Cada nodo es un objeto de tipo NodoEstudiantes

public class ListaEstudiantes
{
    private NodoEstudiantes cabeza; // Apuntador al primer nodo de la lista
    private int contador = 1; // Codigo autoincremental

    public ListaEstudiantes()    // Constructor de la lista inicializa la lista vacia
    {
        cabeza = null;
    }

    // Validar celular (solo numeros)
    private bool ValidarCelular(string celular)    // Metodo para validar que el celular solo tenga numeros
    {
        foreach (char c in celular)
        {
            if (!char.IsDigit(c))    // Si encuentra un caracter que no es numero, retorna false
                return false;
        }
        return true;
    }

    // Validar email (debe tener @)
    private bool ValidarEmail(string email)  // Metodo para validar que el email tenga un @
    {
        return email.Contains("@");
    }

    // Agregar estudiante
    public void Agregar()    // Metodo para agregar un nuevo estudiante a la lista
    {
       
       // Se piden los datos al usuario
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Direccion: ");
        string direccion = Console.ReadLine();

        string celular;
         // Se valida que el celular sea solo numeros
        do
        {
            Console.Write("Celular (solo numeros): ");
            celular = Console.ReadLine();
        } while (!ValidarCelular(celular));

        string email;
        // Se valida que el email tenga @
        do
        {
            Console.Write("Email: ");
            email = Console.ReadLine();
        } while (!ValidarEmail(email));

        
        
        // Se crea el nuevo nodo con un codigo automatico
        NodoEstudiantes nuevo = new NodoEstudiantes(contador, nombre, apellido, direccion, celular, email);
        contador++;

        if (cabeza == null)  // Si la lista esta vacia, el nodo se convierte en la cabeza
        {
            cabeza = nuevo;
        }
        else
        {
            
             // Si no, se recorre hasta el ultimo nodo
            NodoEstudiantes actual = cabeza;  
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo; // Se enlaza el nuevo nodo al final
        }

        Console.WriteLine("Estudiante agregado.");
    }

    // Listar estudiantes
    public void Listar()  // Metodo para listar todos los estudiantes
    {
        if (cabeza == null)
    {
        Console.WriteLine("No hay estudiantes.");
        return;
    }
       
        NodoEstudiantes actual = cabeza;

        while (actual != null) // Recorre toda la lista mostrando los datos
        {
            Console.WriteLine("Codigo: " + actual.Codigo + " - " + actual.Nombre + " " + actual.Apellido);
            actual = actual.Siguiente;
        }
    }

    // Buscar estudiante
    public NodoEstudiantes Buscar(int codigo)  // Metodo para buscar un estudiante por codigo
    {
        NodoEstudiantes actual = cabeza;

        while (actual != null)   // Recorre la lista buscando coincidencia
        {
            if (actual.Codigo == codigo)
                return actual;

            actual = actual.Siguiente;
        }

        return null;  // Si no se encuentra, retorna null
    }

    // Eliminar estudiante
    public void Eliminar(int codigo) // Metodo para eliminar un estudiante por codigo
    {
        if (cabeza == null) // Verifica si la lista esta vacia
        {
            Console.WriteLine("Lista vacia.");
            return;
        }

      
      // Si el estudiante que se quiere eliminar es el primero de la lista
        if (cabeza.Codigo == codigo)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("Eliminado.");
            return;
        }

        NodoEstudiantes actual = cabeza;

        while (actual.Siguiente != null) // Se busca el nodo anterior al que se quiere eliminar
        {
            if (actual.Siguiente.Codigo == codigo)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;  // Se salta el nodo a eliminar
                Console.WriteLine("Eliminado.");
                return;
            }

            actual = actual.Siguiente;
        }


        Console.WriteLine("No encontrado.");
    }
}