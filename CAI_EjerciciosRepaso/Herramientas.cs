using System;
using System.Threading;

namespace CAI_EjerciciosRepaso
{
    public class Herramientas
    {
        public static bool ValidarLimites(int NRO, int MIN, int MAX)
        {
            if (NRO < MIN) return false;
            if (NRO > MAX) return false;
            else return true;
        }

        public static void Salir()
        {
            Console.Clear();
            Console.WriteLine(@" /\_/\");
            Console.WriteLine(@"(=^.^=)");
            Console.WriteLine("(\") (\")");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static bool VerificarSiEsPrimo(int NRO)
        {
            if (NRO == 1) return true;

            for (int i = 2; i < NRO; i++)
            {
                if ((NRO % i) == 0)
                {
                    // No es primo
                    return false;
                }
            }

            // Es primo
            return true;
        }
    }
}
