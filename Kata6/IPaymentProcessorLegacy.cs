using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata6
{
    public interface IPaymentProcessorLegacy
    {
        void ProcessCreditCard();
        void ProcessPayPal();
        void ProcessCrypto();
    }
}
