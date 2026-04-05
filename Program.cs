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


                 case 5:     // Gestion de materias de un estudiante especifico
                    Console.Write("Codigo estudiante: ");
                    int codigo = int.Parse(Console.ReadLine());
                    var estudiante = lista.Buscar(codigo);


                     // Si no existe el estudiante, no se puede continuar
                    if (estudiante == null)
                    {
                        Console.WriteLine("No existe.");
                        break;
                    }

                    int op2; // Variable para el submenu de materias

                    // Submenu de materias
                    do
                    {
                        Console.WriteLine("\n--- MATERIAS ---");
                        Console.WriteLine("1. Agregar");
                        Console.WriteLine("2. Listar");
                        Console.WriteLine("3. Modificar nota");
                        Console.WriteLine("4. Eliminar");
                        Console.WriteLine("5. Volver");

                        op2 = int.Parse(Console.ReadLine());


                        switch (op2)
                        {
                            case 1:         // Agregar una nueva materia
                                Console.Write("Nombre: ");
                                string nom = Console.ReadLine();

                                double nota;
                                
                                 // Se valida que la nota este entre 0 y 5
                                do
                                {
                                    Console.Write("Nota (0 a 5): ");
                                    nota = double.Parse(Console.ReadLine());
                                } while (nota < 0 || nota > 5);

                                estudiante.ListaMaterias.Agregar(nom, nota);
                                break;

                            case 2:      // Listar todas las materias del estudiante
                                estudiante.ListaMaterias.Listar();
                                break;

                            case 3:   // Modificar la nota de una materia
                                Console.Write("Materia: ");
                                string mat = Console.ReadLine();

                                double nueva;
                                
                                // Validar la nueva nota
                                do
                                {
                                    Console.Write("Nueva nota (0 a 5): ");
                                    nueva = double.Parse(Console.ReadLine());
                                } while (nueva < 0 || nueva > 5);

                                estudiante.ListaMaterias.Modificar(mat, nueva);
                                break;

                            case 4:    // Eliminar una materia por nombre
                                Console.Write("Materia: ");
                                estudiante.ListaMaterias.Eliminar(Console.ReadLine());
                                break;
                        }

                    } while (op2 != 5);  // Se repite hasta que el usuario quiera volver
                    break;
            }

        } while (opcion != 6);   // El programa termina cuando el usuario elige salir
    }
}