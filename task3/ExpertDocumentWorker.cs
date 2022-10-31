using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task3
{
    internal class ExpertDocumentWorker : ProDocumentWorker 
    {
        public override string Mode {get {return "Expert version";}}
        public ExpertDocumentWorker() {
            string? path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = path + "/test.txtnew";
            File.Create(filePath).Dispose();
        }

        public override void SaveDocument() {
File.WriteAllText(filePath, doc);
Console.WriteLine("Document save in new format");
doc = "";
        }
    }
}