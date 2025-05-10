using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata3
{
    public class BoatLegacyAnterior : IVehicleAnterior
    {
        public void Drive() => throw new NotSupportedException("BoatLegacy no puede conducir");

        public void Fly() => throw new NotSupportedException("BoatLegacy no puede volar");

        public void Sail() => Console.WriteLine("[Legacy] Boat is sailing");
    }
}
