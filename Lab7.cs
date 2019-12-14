using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7.css
{
    class Book
    {
        private string Title;
        private string Author;
        private int Year;
        public Book(string Title, string Author, int year)
        {
            this.Title = Title;
            this.Author = Author;
        }
        public void Display()
        {
            Console.WriteLine("{0} writtenby {1}\n", Title, Author);
        } //3. A typeconstructor is uTlized to instate staTc inFormaTon in a type
    }     //   A case constructor is uTlized to make examples oF a type
          //4. New constructor method create a new FuncTon 
          //5. ExcepTon handling is important For handling excepTons in the program.
          //    // We can easily handlet hem by using try catch blocks
          //6. Methods, Variables and Constructors that are declared private can only be accessed within the declaredclass itselF.Private access modifer is the most restricTve access level. Class and interFaces cannot be private.
          //  A class, method, constructor, interface etc declared public can be accessed from any other class.±herefore Felds, methods, blocks declared inside a public class can be accessed from any class belonging
          //7. In the visual arts—in unique pain³ng, image design, images, and sculpture—composi³on is theplacement or associa³on of visual factors or cons³tuents in a work of art, as par³cular from the Feld of apiece
          //  he term composi³on manner 'pu´ng together,' and can observe to any work of art, from track towri³ng to images
}         //8. ata abstrac³on is one of the principle of object oriented programming. It is used to display only needed features of an object to outside the world.
