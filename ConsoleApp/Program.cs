public class Program
{
    public static void Main(string[] args)
    {
        
        //Interfaz de usuario, menu
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Digite la opcion deseada:");
        Console.WriteLine("1. Agregar un producto");
        Console.WriteLine("2. Consultar listado de productos");
        Console.WriteLine("3. Salir");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Digite la informacion del producto a continuacion");
                break;
            case 2:
                Console.WriteLine("Listado de productos existentes:");
                break;
            case 3:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion no valida, por favor intente de nuevo.");
                break;
        }

    }
}
