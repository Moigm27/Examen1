using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {

        private static int numero = 24;
        private static readonly object bloqueo = new object();


        static void Main(string[] args)
        {
            HiloOctal.Start();
            HiloHexadecimal.Start();
            HiloBinario.Start();
            Console.ReadLine();
        }

        private static void Hexadecimal()
        {
            lock (bloqueo)
            {

                Console.WriteLine("convirtiendo a hexadecimal.......");
                Thread.Sleep(5000);
                Console.WriteLine($"Hexadecimal: {Convert.ToString(numero, 16)}");
                Console.WriteLine("");
            }
        }
        private static void Binario()
        {
            lock (bloqueo)
            {
                Console.WriteLine("convirtiendo a Binario.....");
                Thread.Sleep(5000);
                int Decimal = numero;
                if (Decimal == 0) Decimal = 0;
                    
                

                string binario = "";
                while (Decimal > 0)
                {
                    int residuo = Decimal % 2;
                    binario = residuo + binario;
                    Decimal /= 2;
                }
                Console.WriteLine("resultado en Binario: "+binario);
                Console.WriteLine("");



            }
        }
        private static void Octal()
        {
            lock (bloqueo)
            {
                Console.WriteLine("convirtiendo a Octal......");
                int Decimal = numero;
                string octal = "";
                if (Decimal == 0) octal= "0";

                while (Decimal > 0)
                {
                    int residuo = Decimal % 8;
                    octal = residuo + octal;
                    Decimal /= 8;
                }

                Thread.Sleep(5000);
                Console.WriteLine("resultado en Octal: "+ octal);
                Console.WriteLine("");

            }
        }

        public static Thread HiloHexadecimal = new Thread(Hexadecimal);
        public static Thread HiloBinario = new Thread(Binario);
        public static Thread HiloOctal = new Thread(Octal);

    }
}
