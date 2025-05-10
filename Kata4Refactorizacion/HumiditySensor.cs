using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata4Refactorizacion
{
    public class HumiditySensor : IHumidityReadable
    {
        public double ReadHumidity() => 45.7;
    }
}
