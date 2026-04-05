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

            
             // Se evalua la opcion elegida
            switch (opcion)
            {
                case 1:      // Llama al metodo para agregar un estudiante
                    lista.Agregar();
                    break;

                case 2:     // Muestra todos los estudiantes
                    lista.Listar();
                    break;

                case 3:     // Permite buscar un estudiante por codigo
                    Console.Write("Codigo: ");
                    int cod = int.Parse(Console.ReadLine());
                    var est = lista.Buscar(cod);

                    
                    // Se verifica si el estudiante existe
                    if (est != null)
                        Console.WriteLine(est.Nombre + " encontrado.");
                    else
                        Console.WriteLine("No existe.");
                    break;

                case 4:         // Permite eliminar un estudiante por codigo
                    Console.Write("Codigo: ");
                    lista.Eliminar(int.Parse(Console.ReadLine()));
                    break;