using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata2
{
    public class BasicPrinterAnterior : ILegacyPrinterAnterior
    {
        public void Fax(string document) => throw new NotImplementedException("BasicPrinterLegacy no puede enviar fax");

        public void Print(string document) => Console.WriteLine($"[Legacy] Imprimiendo: {document}");

        public void Scan(string document) => throw new NotImplementedException("BasicPrinterLegacy no puede escanear");
    }
}
