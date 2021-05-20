using System;


namespace EdabitFeladatok
{
    class Easy
    {
        enum Honapok { Január = 1, Február, Március, Április, Május, Június, Július, Augusztus, Szeptember, Október, November, December }

        public static string HonapNeve(int szam)
        {
            string honap = "";

            for (int i = 1; i < 13; i++)
            {
                if (szam == i)
                {
                    honap = ((Honapok)szam).ToString();
                }
            }

            Console.WriteLine($"A keresett hónap: {honap}");

            return honap;
        }

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

        public static int CountVowels(string bemenet)
        {
            int maganhangzokSzama = 0;
            char[] tomb = bemenet.ToCharArray();

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == 'a' || tomb[i] == 'á' || 
                    tomb[i] == 'e' || tomb[i] == 'é' ||
                    tomb[i] == 'i' || tomb[i] == 'í' ||
                    tomb[i] == 'o' || tomb[i] == 'ó' ||
                    tomb[i] == 'ö' || tomb[i] == 'ő' ||
                    tomb[i] == 'u' || tomb[i] == 'ú' ||
                    tomb[i] == 'ü' || tomb[i] == 'ű')
                {
                    maganhangzokSzama++;
                }
            }

            Console.WriteLine($"A kifejezésben: {bemenet} található magánhangzók száma: {maganhangzokSzama}");

            return maganhangzokSzama;
        }

        public static bool IsIdentical(string bemenet)
        {
            char elso = bemenet[0];
            bool azonos = true;

            for (int i = 1; i < bemenet.Length; i++)
            {
                if (bemenet[i] != elso)
                {
                    azonos = false;
                    break;
                }
            }

            if (azonos)
            {
                Console.WriteLine("Minden karakter egyforma!");
            }
            else
            {
                Console.WriteLine("Nem minden karakter egyforma!");
            }

            return azonos;
        }
    }
}
