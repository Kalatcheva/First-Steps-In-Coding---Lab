using System;
using System.IO;

namespace petShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double price = dogFood * 2.50 + catFood * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
    }
