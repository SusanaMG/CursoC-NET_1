using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable que se usara para guardar el mensaje proporcionado por el usuario
            string message = String.Empty;
            string Message = String.Empty; //para probar que es sensible a mayusculas

            Console.WriteLine("Proporciona un mensaje, por favor:");
            message = Console.ReadLine();
            if(message != String.Empty)
            {
                Console.WriteLine("El mensaje recibido es: '" + message + "'");
            }
            else
            {
                Console.WriteLine("No se recibió mensaje");
            }
            Console.Read();
        }
    }
}
