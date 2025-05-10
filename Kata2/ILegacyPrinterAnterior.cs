using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata2
{
    public interface ILegacyPrinterAnterior
    {
        void Print(string document);
        void Scan(string document);
        void Fax(string document);
    }
}
