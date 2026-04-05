using System;

//clase principal donde comienza todo el programa 

class Program
{
    static void Main()
    {
         // Se crea la lista principal de estudiantes
        ListaEstudiantes lista = new ListaEstudiantes();
        
        int opcion;    // Variable para guardar la opcion del menu

        do               // Bucle principal del programa, se repite hasta que el usuario decida salir
        {
           
              // Menu principal

            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Listar estudiantes");
            Console.WriteLine("3. Buscar estudiante");
            Console.WriteLine("4. Eliminar estudiante");
            Console.WriteLine("5. Gestionar materias");
            Console.WriteLine("6. Salir");

           // Se lee la opcion del usuario
            opcion = int.Parse(Console.ReadLine());