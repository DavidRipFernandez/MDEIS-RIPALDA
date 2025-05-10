using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata4
{
    public class PreassureSensorLegacy : ISensorLegacy
    {
        public double ReadHumidity() => throw new NotSupportedException("PressureSensorLegacy no soporta lectura de humedad");
        public double ReadPreassure() => 1.013; // valor de ejemplo en bar
        public double ReadTemperature() => throw new NotSupportedException("PressureSensorLegacy no soporta lectura de temperatura");

    }
}
