using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task1
{
    internal class Printer
    {
        public virtual void Print(string value) {
            Console.WriteLine(value);
        }
    }
}