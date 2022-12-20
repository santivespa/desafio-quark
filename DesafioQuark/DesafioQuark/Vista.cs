using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioQuark
{
    public static class Vista
    {
        public static void WriteLine(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public static void Write(string mensaje)
        {
            Console.Write(mensaje);
        }

        public static void ReadKey()
        {
            Console.ReadKey();
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
