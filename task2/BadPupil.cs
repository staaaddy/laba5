using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Bad read(");
        }

                public override void Write()
        {
            Console.WriteLine("Bad write(");
        }
                public override void Relax()
        {
            Console.WriteLine("Bad relax(");
        }
                public override void Study()
        {
            Console.WriteLine("Bad study(");
        }
    }
}