using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata2Refactorizacion
{
    public class Scanner : IScannable
    {
        public void Scan(string document)=> Console.WriteLine($"[Refactor] Escaneando: {document}");
    }
}
