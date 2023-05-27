using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thietkemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Vẽ hình chữ nhật");
            Console.WriteLine("2. Vẽ hình vuông");
            Console.WriteLine("3. Vẽ hình tam giác");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("Bạn chọn gì ?");
            choice = Int32.Parse(Console.ReadLine());
            while (choice != 0) 
            {                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
                Console.WriteLine("Menu");
                Console.WriteLine("1. Vẽ hình chữ nhật");
                Console.WriteLine("2. Vẽ hình vuông");
                Console.WriteLine("3. Vẽ hình tam giác");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Bạn chọn gì ?");
                choice = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
