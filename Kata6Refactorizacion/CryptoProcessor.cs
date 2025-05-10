using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6Refactorizacion
{
    public class CryptoProcessor : ICryptoPayment
    {
        public void ProcessCrypto() => Console.WriteLine($"[Refactor] Procesando pago con Cripto...");
    }
}
