﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("area=");
            Console.WriteLine(area);
        }
    }
}
