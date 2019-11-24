using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.  the if single-selection statement performs the actions once, 
            //while the repetition statement repeatedly performs the actions until the condition becomes false 

            int SpeedLimit = 35;
            int speed = 42;
            if (speed > SpeedLimit)
            {
                Console.WriteLine(" SLOW NOW ");

            }
            //  if else statement

            int m = 12;
            int n = 13;

            if (m > 10)
                if (n > 5)
                {
                    Console.WriteLine(" It is True! ");
                }
                else
                {
                    Console.WriteLine(" It is false! ");
                }
            int celsius; 
            int faren;
            {
                Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            }
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("0Temperature in Fahrenheit is(°F) : " + faren);
            Console.ReadLine();
            {
                if (faren < 40)
                    if (faren > 90)
                    {
                        Console.WriteLine("It is Cold");
                    }
                    else
                    {
                        Console.WriteLine("It is Hot!");
                    }

                }
                int i = 1;
                while (i <= 10)
            {
                Console.WriteLine(i);
                i++;

            }
        int a = 60;
        while (a <= 20)
        {
         Console.WriteLine(a);
          a--;

            }
        }
    }
}
