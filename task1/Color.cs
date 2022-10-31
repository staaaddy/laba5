using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task1
{
    internal class Color : Printer {
        Random random;

        public Color() {
            
            random = new Random();

        }

        public override void Print(string value) {
            Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}