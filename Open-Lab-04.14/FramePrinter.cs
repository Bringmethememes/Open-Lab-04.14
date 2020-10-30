using System;
namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int a = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length > a)
                {
                    a = strings[i].Length;
                }
            }
            int q = a + 3;
            // Hore najde najdlhsie

            for (int i = 0; i < q; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");

            for (int i = 0; i < strings.Length; i++)
            {
                int d = a - strings[i].Length;
                Console.Write("* " + strings[i]);

                for (int b = 0; b < d; b++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }

            //Posledny riadok
            for (int i = 0; i < q; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}
