﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az adatbázis nevét: ");
            string dbName = Console.ReadLine();
            Connect conn = new Connect(dbName);
        }
    }
}
