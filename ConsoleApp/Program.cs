using Entities;
using System.Diagnostics;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int option;
        do
        {
            //Interfaz de usuario, menu
            Console.WriteLine("Bienvenido al gestor de productos Dummy");
            Console.WriteLine("Digite la opcion deseada:");
            Console.WriteLine("1. Agregar un producto");
            Console.WriteLine("2. Consultar listado de productos");
            Console.WriteLine("3. Salir");

            option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite la informacion del producto a continuacion");
                    Console.WriteLine("Indique el ID:"); 
                    var id = Int32.Parse(Console.ReadLine()); //captura ID
                    Console.WriteLine("Indique el nombre:");
                    var name = Console.ReadLine(); //captura Nombre
                    Console.WriteLine("Indique la cantidad disponible:");
                    var stock = Int32.Parse(Console.ReadLine()); //captura Stock
                    Console.WriteLine("Indique el precio:");
                    var price = Double.Parse(Console.ReadLine()); //captura Precio

                    var myProduct = new Product() { Id = id, Name = name, Stock = stock, Price = price }; //instancia de la clase producto

                    var pm=new ProductManager() { Id = id, Name = name, Stock = stock, Price = price } //COMPLETAR

                        try
                    {
                        Pm.addProduct(myProduct);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }


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
        } while (option != 3); //do while para que se ejecute al menos una vez y se repita hasta que el usuario decida salir.

    }
}
