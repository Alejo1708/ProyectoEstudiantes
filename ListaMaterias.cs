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
    