using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args) {
            ClassRoom classRoom = new ClassRoom(new NicePupil(), new BadPupil(), new GoodPupil());
            classRoom.ShowPupils();
        }
    }
}