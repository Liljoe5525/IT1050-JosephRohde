using System;

namespace ConsoleApp7
{
    class Program
    {



        static void Main(string[] args)
        {//1. p[0}, p[1], p[2], and p[3]

            string[] months = {"January", "Febuary", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December"};

            for (int x = 0; x < months.Length; x++)
                Console.WriteLine("{0} {1}", x + 1, months[x]);
            {
                string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

                foreach (string winter in months)
                    Console.WriteLine(seasons);
                {
                    int[] elements = new int[1000];
                    foreach (int x in elements)
                        Console.WriteLine(x);
                }
            }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            
            {
                Console.WriteLine("{0,2}. {1}", i, names[i++]);
            }
        }

        
    }
}