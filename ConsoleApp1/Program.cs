class program { 
    static void Main() {
       int option;

        do
        {
            //Opciones: Agregar producto, listar productos, salir
            Console.WriteLine("Por favor seleccione una opcion:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Listar productos");
            Console.WriteLine("3. Salir");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Opcion1 seleccionada: Agregar producto");
                    break;
                case 2:
                    Console.WriteLine("Opcion2 seleccionada: Listar productos");
                    break;
                case 3:
                    Console.WriteLine("Opcion3 seleccionada: Salir");
                    break;
                default:
                    Console.WriteLine("Opcion no valida, por favor intente de nuevo.");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (option != 3);
    }
}
