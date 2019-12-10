using DocumentFormat.OpenXml.Wordprocessing;
using System;

namespace Lab5
{
    class Program
    {

        public string bark;
        public static void bark();
         //1.a scope is the double and double width anything in the ()
         //  b. if static you can access information all across the code. If not static then must fetch information another way
         //  c. return type is "double" it signifies how the program returns the info it cab be void or int 
         //  d. Method name ia getArea it tells the code where to go for the info 
         //  e. Parameters "Public" tells the code the access restrictions if any
         //  f. Method Body return height*width marks the area the code must executed
         //2. User defined method is written by the user and are hidden from other methods. Methods provided by the framework are
         // able to be reused from several locations in an app. When creating user-defined methods we should take into consideration to not “reinvent the wheel.”
         //3. The difference between a static and non-static method is that a non-static method is allowed to access all the non-static fields in an object. While the static method does not have access to any of the objects non-static fields
           {
            Console.WriteLine("{0} is barking", Name); 
           }
        public string doTrick;
        public static void doTrick(trickName);
           {
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", name, trickName);
           }

        }
    }
}
