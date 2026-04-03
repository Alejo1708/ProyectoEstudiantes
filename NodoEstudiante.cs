using System;

// Esta clase representa un NODO de estudiante dentro de la lista enlazada
//cada nodo almacena la informacion de un estudiante y apunta al  sgte nodo
public class NodoEstudiantes
{
    public int Codigo;   // Este es el codigo unico del estudiante que se genera automaticamente
     
     // los datos basicos del estudiante
    public string Nombre;
    public string Apellido;
    public string Direccion;
    public string Celular;
    public string Email;

    public ListaMaterias ListaMaterias; // Cada estudiante tiene su propia lista de materias, esto permite que cada estudiante tenga sus materias independientes 

// Este es el puntero o referencia al siguiente nodo en la lista enlazada
    // Si es null significa que este es el ultimo nodo de la lista
    public NodoEstudiantes Siguiente;


 // Constructor del nodo
    // Se ejecuta cada vez que se crea un nuevo estudiante
    public NodoEstudiantes(int codigo, string nombre, string apellido, string direccion, string celular, string email)
    {
       
       // Se asignan los valores recibidos a los atributos del nodo
        Codigo = codigo;
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion;
        Celular = celular;
        Email = email;


  // Aqui se crea una nueva lista enlazada de materias vacia para este estudiante
        // Esto es clave porque cada estudiante maneja sus propias materias
        ListaMaterias = new ListaMaterias(); // Se crea lista vacia para materias
        
        
          // Como el nodo acaba de crearse, no apunta a ningun otro nodo
        // Por eso el siguiente es null 
        Siguiente = null;
    }
}