using System;

// Esta clase representa un NODO dentro de la lista enlazada de materias
// Cada nodo almacena la informacion de una materia especifica
public class NodoMateria
{
    public string Nombre;   // Nombre de la materia
    public double Nota;     // Nota de la materia (0 a 5)
    public NodoMateria Siguiente; // Apuntador al siguiente nodo en la lista enlazada
    //si es null significa que este es el ultimo nodo de la lista

    public NodoMateria(string nombre, double nota)//Constructor de la clase NodoMateria,se ejecuta cada que se crea una nueva materia
    {
      //se le dan los valores que se recibieron a los atributos del nodo
        Nombre = nombre;
        Nota = nota;
        
        //Como se acabo de crear ese nodo, no apunta  a ningun otro nodo 
        //por eso se inicializa en  null
        Siguiente = null;
    }
}
