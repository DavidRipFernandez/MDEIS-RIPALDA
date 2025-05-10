using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6
{
    public class PayPalProcessorLegacy : IPaymentProcessorLegacy
    {
        public void ProcessCreditCard()
       => throw new NotSupportedException("PayPalProcessorLegacy no soporta tarjeta de crédito");

        public void ProcessCrypto()
        => throw new NotSupportedException("PayPalProcessorLegacy no soporta Cripto");

        public void ProcessPayPal()
      => Console.WriteLine($"[Legacy] Procesando pago con PayPal..");
    }
}
