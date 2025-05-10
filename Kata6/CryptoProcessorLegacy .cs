using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6
{
    public class CryptoProcessorLegacy : IPaymentProcessorLegacy
    {
        public void ProcessCreditCard()
            => throw new NotSupportedException("CryptoProcessorLegacy no soporta tarjeta de crédito");
        public void ProcessCrypto()
             => Console.WriteLine($"[Legacy] Procesando pago con Cripto");
        public void ProcessPayPal()
            => throw new NotSupportedException("CryptoProcessorLegacy no soporta PayPal");
    }
}
