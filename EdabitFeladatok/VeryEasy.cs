using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitFeladatok
{
    class VeryEasy
    {
        public static int Sum(int a, int b)
        {
            int osszeg = a + b;

            Console.WriteLine($"Az első szám: {a}, és a második szám: {b} összege: {osszeg}");

            return osszeg;
        }

        public static int Addition(int a)
        {
            int kovetkezo = a + 1;

            Console.WriteLine($"A bekért szám: {a} utáni első szám: {kovetkezo}");

            return kovetkezo;
        }

        public static double TriArea(int alap, int magassag)
        {
            double terulet = alap * magassag / 2.0d;

            Console.WriteLine($"A háromszög alapja: {alap}, magassága: {magassag} és területe: {terulet}");

            return terulet;
        }

        public static int Remainder(int a, int b)
        {
            int maradek = a % b;
            int hanyados = a / b;
            string kimenet = $"Első szám: {a}, második szám: {b}, maradék: {maradek}, " +
                $"osztás: {a} = {hanyados} * {b} + {maradek}.";

            Console.WriteLine(kimenet);

            return maradek;
        }

        public static bool LessThan(int a, int b)
        {
            int osszeg = a + b;
            
            if (osszeg < 100)
            {
                Console.WriteLine($"Igaz. {a} + {b} = {osszeg} < 100");
                return true;
            }
            else
            {
                Console.WriteLine($"Hamis. {a} + {b} = {osszeg} > 100");
                return false;
            }
        }
    }
}
