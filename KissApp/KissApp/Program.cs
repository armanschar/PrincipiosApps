// See https://aka.ms/new-console-template for more information

namespace KissApp
{
    public class RestaurantBill
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los precios de los platos (separados por comas): ");
            string[] inputprecios = Console.ReadLine().Split(',');
            decimal total = 0;

            foreach (string prec in inputprecios)
            {
                total += Decimal.Parse(prec);
            }

            Console.WriteLine("Desea agregar una propina personalizada? (s/n): ");
            string propinaPers = Console.ReadLine().ToLower();

            decimal tipPercentage = propinaPers == "s"
                ? GetPropinaPers()
                : 10m;

            total += total * (tipPercentage / 100);
            Console.WriteLine($"Total a pagar (con propina del {tipPercentage}%): {total}");
        }
        private static decimal GetPropinaPers()
        {
            Console.WriteLine("Ingrese el porcentaje de propina personalizado: ");
            return decimal.Parse(Console.ReadLine());
        }
        }
    }
