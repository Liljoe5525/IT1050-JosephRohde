using System;

namespace Lab4.cs
{
    class Program
    {//1.counter variable initial value of the counter variableincreament or decreament variableloop-continuation condition.
        //2.The while statement, also called the while loop, executes a block of statements as long as a specified condition is true. A while loop have a condition to check then executes untill
        //    the condition is true, increament or decrement is...
        //3. an example would be when you write a program for a text file thats stops at certain size.

        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                    
                    //7.for (i = 10; i <= 18; i++)
                    //    while (i <= 18)
                    //    {
                    //        Console.WriteLine(i); ++i;
                    //    }
                    //{
                    //    Console.WriteLine(i);

                    //}

                    //8. for (int i = 0; i < 101; i++)
                    //{
                    //    Console.WriteLine(i);
                    //    Console.WriteLine("********");
                    //}



                }
            }
        }
    }
}
