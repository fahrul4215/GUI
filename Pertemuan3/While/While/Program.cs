﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20) {
                Console.WriteLine("" + i);
                i += 2;
            }
            Console.ReadLine();
        }   
    }
}
