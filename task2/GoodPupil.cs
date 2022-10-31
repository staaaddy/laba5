using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Good read(");
        }

                public override void Write()
        {
            Console.WriteLine("Good write)");
        }
                public override void Relax()
        {
            Console.WriteLine("Good relax)");
        }
                public override void Study()
        {
            Console.WriteLine("Good study)");
        }
    }
}