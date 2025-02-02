// See https://aka.ms/new-console-template for more information

namespace SolidApp
{
    
    public class EmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Enviando Email a {email}: {message}");
        }
    }

    
    public class SMSService
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Enviando SMS a {phoneNumber}: {message}");
        }
    }

    
    public class LoggerService
    {
        public void LogNotification(string message)
        {
            Console.WriteLine($"Registrando notificación: {message}");
        }
    }

    
    public class Program
    {
        public static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            LoggerService loggerService = new LoggerService();

            Console.WriteLine("Seleccione el tipo de notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            Console.Write("Ingrese el mensaje: ");
            string message = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el correo electrónico: ");
                    string email = Console.ReadLine();
                    emailService.SendEmail(email, message);
                    loggerService.LogNotification($"Email enviado a {email} con el mensaje: {message}");
                    break;

                case "2":
                    Console.Write("Ingrese el número de teléfono: ");
                    string phoneNumber = Console.ReadLine();
                    smsService.SendSMS(phoneNumber, message);
                    loggerService.LogNotification($"SMS enviado a {phoneNumber} con el mensaje: {message}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
