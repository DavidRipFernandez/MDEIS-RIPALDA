using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata4
{
    public interface ISensorLegacy
    {
        double ReadTemperature();
        double ReadPreassure();
        double ReadHumidity();
    }
}
