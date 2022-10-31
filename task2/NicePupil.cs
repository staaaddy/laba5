using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    internal class NicePupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Nice read))");
        }

                public override void Write()
        {
            Console.WriteLine("Nice write))");
        }
                public override void Relax()
        {
            Console.WriteLine("Nice relax))");
        }
                public override void Study()
        {
            Console.WriteLine("Nice study))");
        }
    }
}