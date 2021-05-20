using System;

namespace EdabitFeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            // VeryEasy.Sum(3, 2);
            // VeryEasy.Sum(-3, -6);
            // VeryEasy.Addition(0);
            // VeryEasy.Addition(9);
            // VeryEasy.TriArea(10, 12);
            // VeryEasy.TriArea(3, 5);
            // VeryEasy.Remainder(3, 5);
            // VeryEasy.Remainder(5, 3);
            // VeryEasy.LessThan(22, 15);
            // VeryEasy.LessThan(83, 34);

            // Easy.MonthName(2);
            // Easy.FindMinMax(new int[] { 12, 25, 36, -89, 7 });
            // Easy.HonapNeve(8);
            // Easy.CountVowels("almafák az erdőben");
            // Easy.IsIdentical("aaaaabaaa");

            // Medium.ArrayOfMultiples(7, 5);
            // Medium.ReverseCase("áéíóőúüűÁÉÍÓŐÚÜŰ");
            // Medium.GetMiddle("12");

            Hard.Interview(new int[] { 5, 5, 10, 11, 15, 15, 20, 20 }, 120);

            Console.ReadKey(true);
        }
    }
}
