using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitFeladatok
{
    class Hard
    {
        public static string Interview(int[] feladatokTomb, int ido)
        {
            string eredmeny = "";
            bool kizar = true;
            
            if (feladatokTomb.Length < 8)
            {
                kizar = false;
            }
            else
            {
                if (feladatokTomb[0] > 5 || feladatokTomb[1] > 5)
                {
                    kizar = false;
                }
                else if (feladatokTomb[2] > 10 || feladatokTomb[3] > 10)
                {
                    kizar = false;
                }
                else if (feladatokTomb[4] > 15 || feladatokTomb[5] > 15)
                {
                    kizar = false;
                }
                else if (feladatokTomb[6] > 20 || feladatokTomb[7] > 20)
                {
                    kizar = false;
                }
            }

            if (ido > 120)
            {
                kizar = false;
            }
            
            if (kizar)
            {
                eredmeny = "Qualified";
            }
            else
            {
                eredmeny = "Disqualified";
            }

            Console.WriteLine(eredmeny);

            return eredmeny;
        }
    }
}
