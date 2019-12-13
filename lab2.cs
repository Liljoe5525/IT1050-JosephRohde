using System;

namespace lab2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int product;

            Console.Write("Enter first integer: ");

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter scond integer: ");

            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2;

            Console.WriteLine("Product is {0}", product);
            
            {
                Console.WriteLine("{0}\n{1}", "Hello World!", "From Joe!");
            }
            {
                Console.WriteLine("{0}\t{1}", "Hello World", "FromJoe!");
            }
            //4a.From the main
            // b. integer is a number without a decimal and a floating point value is a number with decimal place
            // c. example of methods are sum() product()
            // d. public,a set
            // e. an object is a collection of data that represents something. A class defines that structure and everthing about it. There is no limit for the number of instances we can create
        }
    }
}
