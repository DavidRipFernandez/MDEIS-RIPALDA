using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata4
{
    public class HumiditySensorLegacy : ISensorLegacy
    {
        public double ReadHumidity() => 45.7;
        public double ReadPreassure() => throw new NotSupportedException("HumiditySensorLegacy no soporta lectura de presión");
        public double ReadTemperature() => throw new NotSupportedException("HumiditySensorLegacy no soporta lectura de temperatura");
    }
}
