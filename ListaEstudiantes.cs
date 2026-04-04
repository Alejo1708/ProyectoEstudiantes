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