using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 43;
            switch (age)
            {
                case 0:
                    Console.WriteLine("You have not been born yet");
                    break;
                case 5:
                    Console.WriteLine("Too young for school");
                    break;
                case 10:
                    Console.WriteLine("You should be in school");
                    break;
                default:
                    Console.WriteLine("I don't know");
                    break;  
            }
            Console.Read();
        }
    }
}
