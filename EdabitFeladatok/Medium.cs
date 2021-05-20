using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitFeladatok
{
    class Medium
    {
        public static int[] ArrayOfMultiples(int szam, int hossz)
        {
            int[] tomb = new int[hossz];

            for (int i = 0; i < hossz; i++)
            {
                tomb[i] = (i + 1) * szam;
            }

            TombKiir(tomb);

            return tomb;
        }


        public static string ReverseCase(string bemenet)
        {
            char[] tomb = new char[bemenet.Length];

            for (int i = 0; i < bemenet.Length; i++)
            {
                int charSzam = (int)bemenet[i];
                if ((charSzam >= 65 && charSzam <= 90) || (charSzam >= 192 && charSzam <= 220))
                {
                    char ujKarakter = (char)(charSzam + 32);
                    tomb[i] = ujKarakter;
                }
                else if ((charSzam >= 97 && charSzam <= 122) || (charSzam >= 224 && charSzam <= 252))
                {
                    char ujKarakter = (char)(charSzam - 32);
                    tomb[i] = ujKarakter;
                }
                else if (charSzam == 336)
                {
                    char ujKarakter = (char)(337);
                    tomb[i] = ujKarakter;
                }
                else if (charSzam == 337)
                {
                    char ujKarakter = (char)(336);
                    tomb[i] = ujKarakter;
                }
                else if (charSzam == 368)
                {
                    char ujKarakter = (char)(369);
                    tomb[i] = ujKarakter;
                }
                else if (charSzam == 369)
                {
                    char ujKarakter = (char)(368);
                    tomb[i] = ujKarakter;
                }
            }

            string kimenet = new String(tomb);
            Console.WriteLine($"A bemenet: {bemenet} és a kimenet: {kimenet}");

            return kimenet;
        }

        public static string GetMiddle(string bemenet)
        {
            string kimenet = "";

            int bemenetHossz = bemenet.Length;

            if (bemenetHossz % 2 == 0)
            {
                kimenet = bemenet.Substring(bemenetHossz / 2 - 1, 2);
            }
            else
            {
                kimenet = bemenet.Substring(bemenetHossz / 2, 1);
            }

            Console.WriteLine($"A kapott szó: {bemenet}, és a középső karakter(ek): {kimenet}");

            return kimenet;
        }

        public static void TombKiir(int[] tomb)
        {
            Console.Write("A tömb elemei: ");

            foreach (int elem in tomb)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
