using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_return_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {//calling a methods with a return type
            Console.WriteLine(cube(5));
         //this wont give anthing to console
         cube(5);

            //freezing the console
            Console.ReadLine();
        }
        //declare a method with a retutn type int
        static int cube(int number)
        {
            int results = number * number * number;
            return results;
        }
        }
    }

