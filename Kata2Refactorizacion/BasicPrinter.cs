using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata2Refactorizacion
{
    public class BasicPrinter : IPrintable
    {
        public void Print(string document) => Console.WriteLine($"[Refactor] Imprimiendo: {document}");
    }
}
