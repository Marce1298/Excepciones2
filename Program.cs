using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("Introduce un n° entre 0 y 100");

            do
            {

                intentos++;

                try
                {

                    miNumero = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {

                    Console.WriteLine("No has introducido un valor numérico valido. Se toma como numero introducido el 0.");
                    Console.WriteLine(e.Message);

                    miNumero = 0;

                }

                if (miNumero > aleatorio) Console.WriteLine("El n° es mas bajo");

                if (miNumero < aleatorio) Console.WriteLine("El n° es mas alto");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos.");

            Console.WriteLine("A partir de esta línea de código el programa cuntinuaría");
        }
    }
}
