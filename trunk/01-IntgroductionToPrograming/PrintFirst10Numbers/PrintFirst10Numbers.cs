﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintFirst10Numbers
{
    class PrintFirst10Numbers
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(-i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
