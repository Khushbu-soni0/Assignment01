using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        public static void Main(string[] args)
        {

            int length;
            int width;
            
            int menu;
            Console.WriteLine("Please Enter Length Value");
            length = int.Parse(Console.ReadLine());

            while(length==0 || length < 1)
            {
                Console.WriteLine("Input is invalid");
                Console.WriteLine("Enter Length again");
                length = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please Enter Width Value");
            width = int.Parse(Console.ReadLine());

            while (width == 0 || width < 1)
            {
                Console.WriteLine("Input is invalid");
                Console.WriteLine("Enter Width again");
                width = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Choose number in seven option");
            Console.WriteLine("1) Get Rectangle Length");
            Console.WriteLine("2) Change Rectangle Length");
            Console.WriteLine("3) Get Rectangle Width");
            Console.WriteLine("4) Change Rectangle Width");
            Console.WriteLine("5) Get Rectangle Perimeter");
            Console.WriteLine("6) Get Rectangle Area");
            Console.WriteLine("7) Exit");
            menu = int.Parse(Console.ReadLine());
            do
            { 
                

                //switch(menu)
                //{
                
           
                if (menu == 1)
                {
                    Rectangle R1 = new Rectangle(length, width);
                    int c = R1.GetLength();
                    Console.WriteLine("Your rectangle Length is {0}", c);
                    menu = int.Parse(Console.ReadLine());
                }

                if (menu == 2)
                {
                    Console.WriteLine("Enter your new Length value");
                    length = int.Parse(Console.ReadLine());
                    Rectangle R2 = new Rectangle(length, width);
                    int b = R2.SetLength(length);
                    Console.WriteLine("You set Length is {0}", b);
                    menu = int.Parse(Console.ReadLine());
                }

                if (menu == 3)
                {
                    Rectangle R3 = new Rectangle(length, width);
                    int d = R3.GetWidth();
                    Console.WriteLine("You set your Rectangle Width is {0}", d);
                    menu = int.Parse(Console.ReadLine());
                }

                if (menu == 4)
                {
                    Console.WriteLine("Enter your new Width value");
                    width = int.Parse(Console.ReadLine());
                    Rectangle R4 = new Rectangle(length, width);
                    int e = R4.SetWidth(width);
                    Console.WriteLine("You change Rectangle width and it's value is {0}", e);
                    menu = int.Parse(Console.ReadLine());

                }
                if (menu == 5)
                {
                    Rectangle R5 = new Rectangle(length, width);
                    int f = R5.GetPerimeter();
                    Console.WriteLine("Rectangle Perimeter is {0}", f);
                    menu = int.Parse(Console.ReadLine());
                }

                if (menu == 6)
                {
                    Rectangle R6 = new Rectangle(length, width);
                    int g = R6.GetArea();
                    Console.WriteLine("Rectangle are is {0}", g);
                    menu = int.Parse(Console.ReadLine());
                }

                if(menu == 7)
                {
                    break;
                }

            } while (menu != 7);

        }
    }
}
