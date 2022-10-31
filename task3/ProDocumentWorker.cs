using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task3
{
   internal class ProDocumentWorker : DocumentWorker 
   {
    public override string Mode {get {return "Pro ver.";}}
    public override void EditDocument() {
        Console.WriteLine("Rewrite doc:");
        doc = Console.ReadLine();
        Console.WriteLine("Document edited");
    }

    public override void SaveDocument() {
        File.WriteAllText(filePath, doc);
        Console.WriteLine("Document save in old format, new format available in Pro ver.");
        doc = "";
    }
   } 
}