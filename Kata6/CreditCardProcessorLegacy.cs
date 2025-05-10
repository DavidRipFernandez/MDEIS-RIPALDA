using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6
{
    public class CreditCardProcessorLegacy : IPaymentProcessorLegacy
    {
        public void ProcessCreditCard()
        => Console.WriteLine($"[Legacy] Procesando pago con tarjeta de crédito...");
        public void ProcessCrypto()
        => throw new NotSupportedException("CreditCardProcessorLegacy no soporta Cripto");
        public void ProcessPayPal()
        => throw new NotSupportedException("CreditCardProcessorLegacy no soporta PayPal");
    }
}
