// See https://aka.ms/new-console-template for more information
namespace DryApp
{
    public class Payroll
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo):");
            string employeeType = Console.ReadLine();

            switch (employeeType)
            {
                case "1":
                    
                    ProcesoTiempoCompleto();
                    break;
                case "2":
                    
                    ProcesoMedioTiempo();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Seleccione 1 o 2.");
                    break;
            }
        }
        private static void ProcesoTiempoCompleto()
        {
            Console.WriteLine("Ingrese el salario base:");
            string salarioBaseInput = Console.ReadLine();
            if (decimal.TryParse(salarioBaseInput, out decimal salarioBase))
            {
                decimal salarioNeto = CalcSalarioNeto(salarioBase);
                Console.WriteLine($"Salario neto después de impuestos y bono: {salarioNeto}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor válido para el salario base.");
            }
        }

        private static void ProcesoMedioTiempo()
        {
            Console.WriteLine("Ingrese el sueldo por hora:");
            string porHoraInput = Console.ReadLine();
            if (decimal.TryParse(porHoraInput, out decimal porHora))
            {
                Console.WriteLine("Ingrese las horas trabajadas:");
                string horasTrabajadasInput = Console.ReadLine();
                if (int.TryParse(horasTrabajadasInput, out int horasTrabajadas))
                {
                    decimal salarioBruto = porHora * horasTrabajadas;
                    decimal salarioNeto = CalcSalarioNeto(salarioBruto);
                    Console.WriteLine($"Salario neto después de impuestos y bono: {salarioNeto}");
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor válido para las horas trabajadas.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor válido para el sueldo por hora.");
            }
        }
        private static decimal CalcSalarioNeto(decimal salarioBruto)
        {
            decimal tax = salarioBruto * 0.18m;  
            decimal bonus = salarioBruto * 0.05m; 
            return salarioBruto - tax + bonus;   
        }

    }

}

