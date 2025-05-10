using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata3
{
    public class PlaneLegacyAnterior : IVehicleAnterior
    {
        public void Drive() => throw new NotSupportedException("PlaneLegacy no puede conducir");

        public void Fly() => Console.WriteLine("[Legacy] Plane is flying");

        public void Sail() => throw new NotSupportedException("PlaneLegacy no puede navegar");
    }
}
