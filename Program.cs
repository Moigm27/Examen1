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

        static void Main(string[] args)
        {

            HiloHexadecimal.Start();
            HiloBinario.Start();
            HiloOctal.Start();

            Console.ReadLine();
        }

        private static void Hexadecimal()
        {

        }
        private static void Binario()
        {

        }
        private static void Octal()
        {

        }

        public static Thread HiloHexadecimal = new Thread(Hexadecimal);
        public static Thread HiloBinario = new Thread(Binario);
        public static Thread HiloOctal = new Thread(Binario);

    }
}
