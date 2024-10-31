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

            HiloHexadecimal.Start();
            HiloBinario.Start();
            HiloOctal.Start();
            Console.ReadLine();
        }

        private static void Hexadecimal()
        {
            lock (bloqueo)
            {

                Console.WriteLine("convirtiendo a hexadecimal");
                Console.WriteLine( "resultado en hexadecimal:"+numero);
                Thread.Sleep(5000);

            }
        }
        private static void Binario()
        {
            lock (bloqueo)
            {
                Console.WriteLine("convirtiendo a Binario");
                Console.WriteLine("resultado en Binario:"+numero);
                Thread.Sleep(5000);


            }
        }
        private static void Octal()
        {
            lock (bloqueo)
            {
                Console.WriteLine("convirtiendo a Octal");
                Console.WriteLine("resultado en Octal:"+numero);
                Thread.Sleep(5000);

            }
        }

        public static Thread HiloHexadecimal = new Thread(Hexadecimal);
        public static Thread HiloBinario = new Thread(Binario);
        public static Thread HiloOctal = new Thread(Octal);

    }
}
