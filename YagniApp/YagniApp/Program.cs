// See https://aka.ms/new-console-template for more information
namespace YagniApp
{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto de nombre {name} y precio {price} añadido.");

        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Producto {productId} borrado.");

        }

    }
      static
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductService servicio = new ProductService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre del producto: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio del producto: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal price))
                        {
                            servicio.AddProduct(name, price);
                        }
                        else
                        {
                            Console.WriteLine("El precio ingresado no es valido.");

                        }
                        break;
                    case "2":
                        Console.Write("Ingrese el ID del producto a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int productId))
                        {
                            servicio.DeleteProduct(productId);
                        }
                        else
                        {
                            Console.WriteLine("El ID ingresado no es válido.");
                        }
                        break;

                    case "3":
                        exit = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;

                }
            }
        }
    }
}