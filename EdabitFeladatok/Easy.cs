using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitFeladatok
{
    class Easy
    {
        public static string MonthName(int szam)
        {
            string honap = "";

            switch (szam)
            {
                case 1: { honap = "Január"; break; }
                case 2: { honap = "Február"; break; }
                case 3: { honap = "Március"; break; }
                case 4: { honap = "Április"; break; }
                case 5: { honap = "Május"; break; }
                case 6: { honap = "Június"; break; }
                case 7: { honap = "Július"; break; }
                case 8: { honap = "Augusztus"; break; }
                case 9: { honap = "Szeptember"; break; }
                case 10: { honap = "Október"; break; }
                case 11: { honap = "November"; break; }
                case 12: { honap = "December"; break; }
            }

            Console.WriteLine($"A keresett hónap: {honap}");

            return honap;
        }

        public static int[] FindMinMax(int[] bemeno)
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
        
            for (int i = 0; i < bemeno.Length; i++)
            {
                if (bemeno[i] <= min)
                {
                    min = bemeno[i];
                }

                if (max <= bemeno[i])
                {
                    max = bemeno[i];
                }
            }

            int[] kimeno = { min, max };

            Console.Write("A tömb elemei: ");
            foreach (int elem in bemeno)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine($"\nA legkisebb elem a tömbben: {min}.");
            Console.WriteLine($"A legnagyobb elem a tömbben: {max}.");
            Console.WriteLine($"A tömb elemeinek abszolút értékének összege: {GetAbsSum(bemeno)}.");

            return kimeno;
        }

        public static int GetAbsSum(int[] bemeno)
        {
            int osszeg = 0;

            foreach (int elem in bemeno)
            {
                osszeg += Math.Abs(elem);
            }

            return osszeg;
        }
    }
}
