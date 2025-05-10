using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6Refactorizacion
{
    public class CreditCardProcessor : ICreditCardPayment
    {
        public void ProcessCreditCard() => Console.WriteLine($"[Refactor] Procesando pago con tarjeta de crédito");
    }
}
