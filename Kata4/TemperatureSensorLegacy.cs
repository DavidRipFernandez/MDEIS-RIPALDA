using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata4
{
    public class TemperatureSensorLegacy : ISensorLegacy
    {
        public double ReadTemperature() => 25.5;

        public double ReadPreassure() => throw new NotSupportedException("TemperatureSensorLegacy no soporta lectura de presión");

        public double ReadHumidity() => throw new NotSupportedException("TemperatureSensorLegacy no soporta lectura de humedad");
    }
}
