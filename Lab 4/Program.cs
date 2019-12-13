using System;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= 90) { Console.WriteLine("fish"); }
            else if (temp >= 80) { Console.WriteLine("Lion"); }
            else if (temp >= 70) { Console.WriteLine("Turtle"); }
            else if (temp >= 60) { Console.WriteLine("Deer"); }
            else if (temp >= 50) { Console.WriteLine("Reindeer"); }
            else if (temp >= 40) { Console.WriteLine("Moose"); }
            else if (temp >= 20) { Console.WriteLine("Penguin"); }
            else if (temp >= 10) { Console.WriteLine("Polar Bear"); }
            else { Console.WriteLine("Bug"); }

            Console.WriteLine("Please enter the exhibit number: "); 
            string str = Console.ReadLine();
            int caseSwitch = int.Parse(str);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("polar bear ");
                    break;
                case 2:
                    Console.WriteLine("penquin ");
                    break;
                case 3:
                    Console.WriteLine("moose ");
                    break;
                case 4:
                    Console.WriteLine("reindeer ");
                    break;
                case 5:
                    Console.WriteLine("deer ");
                    break;
                case 6:
                    Console.WriteLine("turtle ");
                    break;
                case 7:
                    Console.Write("lion ");
                    break;
                case 8:
                    Console.WriteLine("fish ");
                    break;
                case 9:
                    Console.WriteLine("bug ");
                    break;
            }


            int i = 10;
            for (i = 10; i <= 18; i++)
                while (i <= 18)
                {
                    Console.WriteLine(i); ++i;
                }
            {
                Console.WriteLine(i);
            
            }
        }
    }
}


        
    

