using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task3
{
    internal class DocumentWorker
    {
        protected string doc = "";
        protected string filePath;
        public virtual string Mode {get { return "free ver.";}}
        public string Doc {get { return doc;}}

        public DocumentWorker() {
            string? path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            filePath = path + "/test.txtold";
            File.Create(filePath).Dispose();
        }

        public virtual void OpenDocument() {
            Console.WriteLine("Document open");
            Console.WriteLine(File.ReadAllText(filePath));
        }
public virtual void EditDocument() {
    Console.WriteLine("Document edit available in Pro ver.");
}
public virtual void SaveDocument() {
    Console.WriteLine("Document sace available in Pro ver.");
}
    }
}