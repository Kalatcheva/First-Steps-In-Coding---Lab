using System;
using System.IO;

namespace inchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double inchNum = double.Parse(Console.ReadLine());

            double cm = inchNum * 2.54;
            Console.WriteLine(cm);
        }
    }
    }
