using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6Refactorizacion
{
    public class PayPalProcessor : IPayPalPayment
    {
        public void ProcessPayPal() => Console.WriteLine($"[Refactor] Procesando pago con PayPaL...");
    }
}
