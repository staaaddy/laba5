using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            DocumentWorker documentWorker = null;

            Dictionary<string, string> keys = new Dictionary<string, string>() {
                {"epx", 12345678.ToString()}, {"pro", 87654321.ToString()}
            };

            while (true)
            {
                Console.WriteLine("Enter key(pro/exp) ********");

                string[] msg = Console.ReadLine().Split(" ");

                if (msg.Length ==2 )
                {
                    string value;
                    if (!keys.TryGetValue(msg[0], out value)) {
                        documentWorker = new DocumentWorker();
                        break;
                    }

                    if (msg[1] != value) 
                    continue;

                    if (msg[0] == "exp")
                    {
                        documentWorker = new ExpertDocumentWorker();
                    }
                    else if (msg[0] == "pro") {
                        documentWorker = new ProDocumentWorker();
                    }
                }
                    else 
                    documentWorker = new DocumentWorker();
                    break;
                }
while (true)
{
    Console.Clear();
    Console.WriteLine(documentWorker.Mode);
    Console.WriteLine("True buffer: " + documentWorker.Doc);
    Console.WriteLine("open/edit/save");

    string[] msg = Console.ReadLine().Split(" ");

    if (msg[0] == "open")
    {
        documentWorker.OpenDocument();
    }
    else if (msg[0] == "edit")
    {
        documentWorker.EditDocument();
    }
    else if (msg[0] == "save")
    {
        documentWorker.SaveDocument();
    }
    Console.ReadLine();
}
            }
        }
    }
